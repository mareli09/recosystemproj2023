using Microsoft.ML;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML.Data;
using System.Windows.Forms.DataVisualization.Charting;
using Accord.Statistics.Kernels;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;

namespace RecommendationSystem
{
    public partial class frmRecommendation : Form
    {

        public frmRecommendation()
        {
            InitializeComponent();
        }

        private void frmRecommendation_Load(object sender, EventArgs e)
        {
            
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "MM-dd-yyyy hh:mm:ss tt";

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "MM-dd-yyyy hh:mm:ss tt";



        }
        public static string connection = "server=localhost;user id=root;password=;database=recsys";
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //code here if its single day only..

            var context = new MLContext();


            using (var connection = new MySqlConnection("server=localhost;user id=root;password=;database=recsys"))
            {

                // Retrieve data for seminars
                var seminars = new List<SeminarData>();

                List<string> otherPrograms = new List<string>();
                List<double> otherProgramValues = new List<double>();

                connection.Open();
                if(dtFrom.Text == dtTo.Text)
                {
                    MessageBox.Show("must be more than a day before input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    using (var command = new MySqlCommand("SELECT Program, Question1, Question2 FROM tblInterview WHERE DateAdded BETWEEN '"+dtFrom.Text+"' AND '"+dtTo.Text+"'", connection))
                    {
                    
                        using (var reader = command.ExecuteReader())
                        {
                            int counter = 0;
                            while (reader.Read())
                            {
                                var name = reader.GetString("Program");
                                var interested = reader.GetInt32("Question1");
                                var attendees = reader.GetInt32("Question2");
                                seminars.Add(new SeminarData { Name = name, Interested = interested, Attendees = attendees });
                            
                            }
                        
                        }
                    }
                    // Convert the data to an IDataView
                    var data = context.Data.LoadFromEnumerable(seminars);

                    // Define the pipeline
                    var pipeline = context.Transforms.Concatenate("Features", "Interested", "Attendees")
                        .Append(context.Transforms.NormalizeMinMax("Features"));

                    // Train the model
                    var model = pipeline.Fit(data);

                    // User's interests and past attendance
                    var userInterests = 15;
                    var userAttendance = 10;

                    // Create an array of input data for the user
                    var userData = new[] { new SeminarData { Interested = userInterests, Attendees = userAttendance } };

                    // Convert the input data to an IDataView
                    var inputData = context.Data.LoadFromEnumerable(userData);

                    // Use the model to transform the input data
                    var transformedData = model.Transform(inputData);

                    // Extract the transformed data as an array of SeminarData
                    var userFeatures = context.Data.CreateEnumerable<SeminarData>(transformedData, true).First();

                    // Compute the Euclidean distance between the user's features and the features of each seminar
                    var distances = seminars.Select(s =>
                    {
                        var interestDiff = Math.Abs(s.Interested - userFeatures.Interested);
                        var attendanceDiff = Math.Abs(s.Attendees - userFeatures.Attendees);
                        var distance = Math.Sqrt(Math.Pow(interestDiff, 2) + Math.Pow(attendanceDiff, 2));
                        return new { Seminar = s, Distance = distance };
                    });

                    // Sort seminars by distance and recommend the closest one
                    var recommendedSeminar = distances.OrderByDescending(d => d.Distance).First().Seminar;

                    // Total number of interested and attendees
                    var totalInterested = seminars.Sum(s => s.Interested);
                    var totalAttendees = seminars.Sum(s => s.Attendees);

                    // Compute percentage of interested and attendees for the recommended seminar
                    var interestedPercentage = (double)recommendedSeminar.Interested / totalInterested;
                    var attendeesPercentage = (double)recommendedSeminar.Attendees / totalAttendees;

                    //MessageBox.Show("Recommended Seminar: " + recommendedSeminar.Name + " with a percentage of " + interestedPercentage + " and "+ attendeesPercentage , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Console.WriteLine("Recommended seminar: {0} - Interested: {1:P2}, Attendees: {2:P2}", recommendedSeminar.Name, interestedPercentage, attendeesPercentage);
                    // Add the recommended program to the chart

                    lblResult.Text = recommendedSeminar.Name;
                    lblDescription.Text = "This program is selected because of the content-based filtering algorithm that applies euclidean distance. Euclidean distance is a measure of the distance between two points in a multi-dimensional space. It is calculated as the square root of the sum of the squares of the differences between the coordinates of the two points. It is often used in machine learning to measure the similarity between two data points, for example, in clustering or k-nearest neighbors algorithms. The datasets are the number of people that will benefit and number of people that are not only be beneficial but also interested to participate in a program. Based on the computation here are the result of people who will benefit and interested. Number of people who will benefit:  '" + interestedPercentage + "' and people who are interested:  '" + attendeesPercentage + "'.";

                }

            }


        }
        class SeminarData
        {
            public string Name { get; set; }
            public float Interested { get; set; }
            public float Attendees { get; set; }

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomePage hp = new frmHomePage();
            hp.Show();
            this.Hide();
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmManageUser manageUser = new frmManageUser();
            this.Hide();
            manageUser.Show();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            frmInterview interview = new frmInterview();
            interview.Show();
            this.Hide();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            frmManageProgram mp = new frmManageProgram();
            mp.Show();
            this.Hide();
        }

        private void btnRecommendation_Click(object sender, EventArgs e)
        {
            frmRecommendation recommendation = new frmRecommendation();
            recommendation.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            this.Hide();
            about.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //not doing anything.
            }
        }

    }
}

