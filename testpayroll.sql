-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 28, 2020 at 10:48 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testpayroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `att_id` int(11) NOT NULL,
  `emp_id` int(11) DEFAULT NULL,
  `att_date` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `in_time` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `out_time` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `outNextDay` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `status` varchar(50) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`att_id`, `emp_id`, `att_date`, `in_time`, `out_time`, `outNextDay`, `status`) VALUES
(3, 2, '2020-01-28', '09:52:AM', '13:04:PM', '', 'CheckOut'),
(4, 1, '2020-01-28', '09:53:AM', '', '', 'CheckIn');

-- --------------------------------------------------------

--
-- Table structure for table `brake_inout_data`
--

CREATE TABLE `brake_inout_data` (
  `b_id` int(11) NOT NULL,
  `emp_id` int(11) DEFAULT NULL,
  `b_date` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `in_time` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `out_time` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `current_state` varchar(50) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `brake_inout_data`
--

INSERT INTO `brake_inout_data` (`b_id`, `emp_id`, `b_date`, `in_time`, `out_time`, `current_state`) VALUES
(19, 2, '2020-01-28', '10:10:AM', '10:17:AM', 'BrakeOut'),
(20, 2, '2020-01-28', '10:20:AM', '12:03:PM', 'BrakeOut');

-- --------------------------------------------------------

--
-- Table structure for table `check_inout_data`
--

CREATE TABLE `check_inout_data` (
  `c_id` int(11) NOT NULL,
  `emp_id` int(11) DEFAULT NULL,
  `c_date` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `in_time` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `out_time` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `current_state` varchar(50) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `check_inout_data`
--

INSERT INTO `check_inout_data` (`c_id`, `emp_id`, `c_date`, `in_time`, `out_time`, `current_state`) VALUES
(37, 2, '2020-01-28', '09:52:AM', '09:55:AM', 'CheckOut'),
(38, 1, '2020-01-28', '09:53:AM', '', 'CheckIn'),
(39, 2, '2020-01-28', '09:56:AM', '10:04:AM', 'CheckOut'),
(40, 2, '2020-01-28', '10:06:AM', '13:04:PM', 'CheckOut');

-- --------------------------------------------------------

--
-- Table structure for table `emp_details`
--

CREATE TABLE `emp_details` (
  `emp_id` int(11) NOT NULL,
  `full_name` varchar(150) COLLATE latin1_general_ci DEFAULT NULL,
  `nic_no` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `job_position` varchar(150) COLLATE latin1_general_ci DEFAULT NULL,
  `emp_dob` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `email_01` varchar(150) COLLATE latin1_general_ci DEFAULT NULL,
  `email_02` varchar(150) COLLATE latin1_general_ci DEFAULT NULL,
  `join_date` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `permanant_date` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `permanant_status` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `job_status` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `contact_mobile` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `contatct_fixed` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `gender` varchar(20) COLLATE latin1_general_ci DEFAULT NULL,
  `basic_salary` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `civil_status` varchar(30) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `emp_details`
--

INSERT INTO `emp_details` (`emp_id`, `full_name`, `nic_no`, `job_position`, `emp_dob`, `email_01`, `email_02`, `join_date`, `permanant_date`, `permanant_status`, `job_status`, `contact_mobile`, `contatct_fixed`, `gender`, `basic_salary`, `civil_status`) VALUES
(1, 'Harsha Indunil', '893707890v', 'CO', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Male', '5', 'Single'),
(2, 'Samantha Samaradiwakara', '930370789v', 'Software Dev', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Male', '3', 'Single');

-- --------------------------------------------------------

--
-- Table structure for table `finger_print_data`
--

CREATE TABLE `finger_print_data` (
  `f_id` int(11) NOT NULL,
  `line_number` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `in_out_code` int(11) DEFAULT NULL,
  `f_date` int(50) DEFAULT NULL,
  `f_time` int(50) DEFAULT NULL,
  `f_datetime` varchar(50) COLLATE latin1_general_ci DEFAULT NULL,
  `check_by` varchar(50) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `scan_details`
--

CREATE TABLE `scan_details` (
  `s_id` int(11) NOT NULL,
  `machine_name` varchar(150) COLLATE latin1_general_ci DEFAULT NULL,
  `s_date` int(30) DEFAULT NULL,
  `description` int(150) DEFAULT NULL,
  `scan_by` int(50) DEFAULT NULL,
  `s_other` int(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `temp_data`
--

CREATE TABLE `temp_data` (
  `t_id` int(11) NOT NULL,
  `line_number` int(11) DEFAULT NULL,
  `emp_id` int(11) DEFAULT NULL,
  `in_out_code` int(11) DEFAULT NULL,
  `t_date` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `t_time` varchar(30) COLLATE latin1_general_ci DEFAULT NULL,
  `t_datetime` varchar(50) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `temp_data`
--

INSERT INTO `temp_data` (`t_id`, `line_number`, `emp_id`, `in_out_code`, `t_date`, `t_time`, `t_datetime`) VALUES
(1, 1, 2, 100, '2020-1-28', '9:52:46', '2020-01-28 09:52:AM'),
(2, 2, 1, 100, '2020-1-28', '9:53:0', '2020-01-28 09:53:AM'),
(3, 3, 2, 101, '2020-1-28', '9:55:3', '2020-01-28 09:55:AM'),
(4, 4, 2, 100, '2020-1-28', '9:56:4', '2020-01-28 09:56:AM'),
(5, 5, 2, 101, '2020-1-28', '10:4:31', '2020-01-28 10:04:AM'),
(6, 6, 2, 100, '2020-1-28', '10:6:33', '2020-01-28 10:06:AM'),
(7, 7, 2, 130, '2020-1-28', '10:10:34', '2020-01-28 10:10:AM'),
(8, 8, 2, 131, '2020-1-28', '10:17:30', '2020-01-28 10:17:AM'),
(9, 9, 2, 130, '2020-1-28', '10:20:38', '2020-01-28 10:20:AM'),
(10, 10, 2, 131, '2020-1-28', '12:3:59', '2020-01-28 12:03:PM'),
(11, 11, 2, 101, '2020-1-28', '13:4:31', '2020-01-28 13:04:PM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`att_id`);

--
-- Indexes for table `brake_inout_data`
--
ALTER TABLE `brake_inout_data`
  ADD PRIMARY KEY (`b_id`);

--
-- Indexes for table `check_inout_data`
--
ALTER TABLE `check_inout_data`
  ADD PRIMARY KEY (`c_id`);

--
-- Indexes for table `emp_details`
--
ALTER TABLE `emp_details`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indexes for table `finger_print_data`
--
ALTER TABLE `finger_print_data`
  ADD PRIMARY KEY (`f_id`);

--
-- Indexes for table `scan_details`
--
ALTER TABLE `scan_details`
  ADD PRIMARY KEY (`s_id`);

--
-- Indexes for table `temp_data`
--
ALTER TABLE `temp_data`
  ADD PRIMARY KEY (`t_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `att_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `brake_inout_data`
--
ALTER TABLE `brake_inout_data`
  MODIFY `b_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `check_inout_data`
--
ALTER TABLE `check_inout_data`
  MODIFY `c_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `finger_print_data`
--
ALTER TABLE `finger_print_data`
  MODIFY `f_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `scan_details`
--
ALTER TABLE `scan_details`
  MODIFY `s_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `temp_data`
--
ALTER TABLE `temp_data`
  MODIFY `t_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
