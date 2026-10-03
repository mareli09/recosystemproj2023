-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2023 at 08:09 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `recsys`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblinterview`
--

CREATE TABLE `tblinterview` (
  `ID` int(11) NOT NULL,
  `ResidentName` varchar(300) NOT NULL,
  `Program` varchar(500) NOT NULL,
  `Question1` varchar(250) NOT NULL,
  `Question2` varchar(250) NOT NULL,
  `DateAdded` varchar(300) NOT NULL,
  `DateRemove` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblinterview`
--

INSERT INTO `tblinterview` (`ID`, `ResidentName`, `Program`, `Question1`, `Question2`, `DateAdded`, `DateRemove`) VALUES
(1, 'Naruto', 'Basic Computers', '10', '5', '01-23-2023 12:51:27 PM', 'N/A'),
(2, 'Sasuke', 'Graphics Design', '100', '40', '01-23-2023 12:54:53 PM', 'N/A'),
(3, 'Sakura', 'Word Processing', '20', '10', '01-23-2023 12:56:53 PM', 'N/A'),
(4, 'Rabanal', 'Basic Computers', '100', '50', '01-24-2023 11:42:36 PM', 'N/A'),
(5, 'Mark', 'PC Troubleshooting', '1000', '500', '01-25-2023 02:42:36 PM', 'N/A'),
(6, 'Chloe', 'Basic File Management', '5000', '3000', '01-26-2023 01:19:12 AM', 'N/A'),
(7, 'Dennis', 'Seminar as Anti-Bullying', '30', '10', '01-26-2023 03:04:25 PM', 'N/A'),
(8, 'Anne', 'Parent and child coaching', '10', '5', '01-27-2023 02:57:20 AM', 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `tblprogram`
--

CREATE TABLE `tblprogram` (
  `ID` int(11) NOT NULL,
  `PROGRAMNAME` varchar(500) NOT NULL,
  `DATEADDED` varchar(250) NOT NULL,
  `DATEREMOVE` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblprogram`
--

INSERT INTO `tblprogram` (`ID`, `PROGRAMNAME`, `DATEADDED`, `DATEREMOVE`) VALUES
(1, 'Basic Computers', '01-23-2023 12:31:28 AM', 'N/A'),
(2, 'Word Processing', '01-22-2023 4:00:00 PM', 'N/A'),
(3, 'Graphics Design', '01-22-2023 4:00:00 PM', 'N/A'),
(4, 'Multimedia Presentation', '01-22-2023 4:00:00 PM', 'N/A'),
(5, 'Spreadsheet application', '01-22-2023 4:00:00 PM', 'N/A'),
(6, 'Values Formation', '01-22-2023 4:00:00 PM', 'N/A'),
(7, 'Behavioral Assessment', '01-22-2023 4:00:00 PM', 'N/A'),
(8, 'Seminar as Anti-Bullying', '01-22-2023 4:00:00 PM', 'N/A'),
(9, 'Seminar on work balance in working method', '01-22-2023 4:00:00 PM', 'N/A'),
(10, 'Parent and child concealing', '01-22-2023 4:00:00 PM', 'N/A'),
(11, 'Parent and child coaching', '01-22-2023 4:00:00 PM', 'N/A'),
(12, 'Mathematics tutorial', '01-22-2023 4:00:00 PM', 'N/A'),
(13, 'Seminar on Basic Business Management using Mathematics Approach', '01-22-2023 4:00:00 PM', 'N/A'),
(14, 'Science Literary Program', '01-22-2023 4:00:00 PM', 'N/A'),
(15, 'Tutorial/Seminar on the use of the prototype water testing facility', '01-22-2023 4:00:00 PM', 'N/A'),
(16, 'Workshop on the utilization of the weakness station device', '01-22-2023 4:00:00 PM', 'N/A'),
(17, 'Basic File Management', '01-22-2023 4:00:00 PM', 'N/A'),
(18, 'PC Troubleshooting', '01-22-2023 4:00:00 PM', 'N/A'),
(19, 'LAN installation and Management', '01-22-2023 4:00:00 PM', 'N/A'),
(20, 'Basic Internet, Set-up and Configuration', '01-22-2023 4:00:00 PM', 'N/A'),
(26, 'Website', '01-23-2023 12:37:40 AM', '01-23-2023 12:37:48 AM'),
(27, 'Games 2', '01-23-2023 12:38:47 AM', '01-23-2023 12:38:52 AM'),
(28, 'Word Processing 2', '01-23-2023 09:02:37 AM', '01-23-2023 09:02:46 AM'),
(29, 'Web development 2', '01-23-2023 10:04:41 AM', '01-23-2023 10:04:51 AM'),
(30, 'Basic Computers 3', '01-23-2023 04:56:31 PM', '01-23-2023 04:57:24 PM'),
(31, 'Website Programming 1', '01-27-2023 01:39:43 AM', '01-27-2023 01:39:48 AM'),
(32, 'Parent and child concealing part 3', '01-26-2023 03:02:54 PM', '01-26-2023 03:03:19 PM'),
(33, 'Computer Programming 2', '01-26-2023 11:58:45 PM', '01-26-2023 11:59:22 PM');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `ID` int(10) NOT NULL,
  `USERNAME` varchar(250) NOT NULL,
  `PASSWORD` varchar(250) NOT NULL,
  `EMPLOYEENO` varchar(250) NOT NULL,
  `LASTNAME` varchar(250) NOT NULL,
  `MIDDLENAME` varchar(250) NOT NULL,
  `FIRSTNAME` varchar(250) NOT NULL,
  `GENDER` varchar(250) NOT NULL,
  `BIRTHDATE` varchar(250) NOT NULL,
  `POSITION` varchar(250) NOT NULL,
  `DEPARTMENT` varchar(250) NOT NULL,
  `ADDRESS` varchar(250) NOT NULL,
  `CONTACTNO` varchar(250) NOT NULL,
  `EMAIL` varchar(250) NOT NULL,
  `ACCESSLEVEL` varchar(250) NOT NULL,
  `ACTIVE` varchar(250) NOT NULL,
  `DATEADDED` varchar(250) NOT NULL,
  `DATEINACTIVE` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`ID`, `USERNAME`, `PASSWORD`, `EMPLOYEENO`, `LASTNAME`, `MIDDLENAME`, `FIRSTNAME`, `GENDER`, `BIRTHDATE`, `POSITION`, `DEPARTMENT`, `ADDRESS`, `CONTACTNO`, `EMAIL`, `ACCESSLEVEL`, `ACTIVE`, `DATEADDED`, `DATEINACTIVE`) VALUES
(1, '1', '1', '', '', '', 'super admin', '0', '', '', '', '', '', '', 'SUPERADMIN', 'YES', '', ''),
(3, '', '', '', 'UZUMAKI', 'NAMIKAZE', 'NARUTO', '0', 'Saturday, January 1, 2000', 'Student', 'Computer department', 'Manila', '099999999999', 'narutouzumaki@gmail.com', 'ADMIN', 'ACTIVE', '01-18-2023 10:54:17 PM', '01-18-2023 10:54:17 PM'),
(4, '', '', '', 'SON', 'NONE', 'GOKU', 'MALE', 'Tuesday, February 4, 2020', 'Fighter', 'DBZ', 'Tenkaichi', '0999999999', 'sample.email@email.com', 'ADMIN', 'ACTIVE', '01-19-2023 12:20:21 AM', '01-19-2023 12:20:21 AM'),
(5, '2', '2', '', 'RABANAL', '', 'JOHN', 'MALE', 'Friday, January 27, 2023', 'STUDENT', 'COLLEGE OF ART AND SCIENCE', 'MANILA', '0999999999', 'rabanal@gmail.com', 'ADMIN', 'ACTIVE', '01-27-2023 02:08:33 AM', '01-27-2023 02:08:33 AM'),
(6, '3', '2', '', '1', '1', '1', 'MALE', 'Friday, January 27, 2023', '1', '1', '1', '1', '1', 'ADMIN', 'ACTIVE', '01-27-2023 02:22:13 AM', '01-27-2023 02:22:13 AM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblinterview`
--
ALTER TABLE `tblinterview`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblprogram`
--
ALTER TABLE `tblprogram`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblinterview`
--
ALTER TABLE `tblinterview`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tblprogram`
--
ALTER TABLE `tblprogram`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
