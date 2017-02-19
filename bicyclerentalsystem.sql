-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 30, 2017 at 11:58 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bicyclerentalsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `bicycles`
--

CREATE TABLE `bicycles` (
  `BicycleID` int(10) NOT NULL,
  `StationID` int(10) NOT NULL,
  `isReportedBroken` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `bicycles`
--

INSERT INTO `bicycles` (`BicycleID`, `StationID`, `isReportedBroken`) VALUES
(1, 1, 0),
(3, 3, 0),
(7, 3, 0),
(8, 2, 1),
(9, 2, 0),
(10, 3, 0);

-- --------------------------------------------------------

--
-- Table structure for table `rentsactive`
--

CREATE TABLE `rentsactive` (
  `RentID` int(10) NOT NULL,
  `PESEL` bigint(11) NOT NULL,
  `BicycleID` int(10) NOT NULL,
  `DateOfRent` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `rentsarchive`
--

CREATE TABLE `rentsarchive` (
  `RentsArchiveID` int(10) NOT NULL,
  `PESEL` bigint(11) NOT NULL,
  `BicycleID` int(10) NOT NULL,
  `DateOfRent` datetime NOT NULL,
  `DateOfReturn` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Cost` int(10) NOT NULL,
  `WasReportedBroken` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `rentsarchive`
--

INSERT INTO `rentsarchive` (`RentsArchiveID`, `PESEL`, `BicycleID`, `DateOfRent`, `DateOfReturn`, `Cost`, `WasReportedBroken`) VALUES
(12, 92031214563, 3, '2017-01-29 02:41:18', '2017-01-29 04:10:45', 22, 0),
(13, 92031214563, 8, '2017-01-29 04:10:51', '2017-01-29 04:10:54', 0, 1),
(14, 92031214563, 8, '2017-01-29 04:13:07', '2017-01-29 04:13:10', 0, 1),
(15, 92031214563, 3, '2017-01-29 04:14:38', '2017-01-29 04:14:40', 0, 0),
(16, 92031214563, 3, '2017-01-29 04:17:01', '2017-01-29 04:17:02', 0, 0),
(17, 92031214563, 3, '2017-01-29 04:17:12', '2017-01-29 04:17:14', 0, 1),
(18, 92031214563, 3, '2017-01-29 04:18:34', '2017-01-29 04:18:36', 0, 1),
(19, 92031214563, 3, '2017-01-29 04:24:31', '2017-01-29 04:25:44', 0, 0),
(20, 89012312345, 8, '2017-01-29 07:06:48', '2017-01-29 07:06:51', 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `stations`
--

CREATE TABLE `stations` (
  `StationID` int(10) NOT NULL,
  `StreetName` text COLLATE utf8_polish_ci NOT NULL,
  `StreetNumber` int(10) NOT NULL,
  `MaxBicycleCount` int(10) DEFAULT NULL,
  `BicycleCount` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `stations`
--

INSERT INTO `stations` (`StationID`, `StreetName`, `StreetNumber`, `MaxBicycleCount`, `BicycleCount`) VALUES
(1, 'Stacja Techniczna', 0, 50, 1),
(2, 'Grunwaldzka', 2, 5, 2),
(3, 'Rynek', 10, 10, 3),
(4, 'Nowowiejska', 15, 10, 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `PESEL` bigint(11) NOT NULL,
  `Name` text COLLATE utf8_polish_ci NOT NULL,
  `Surname` text COLLATE utf8_polish_ci NOT NULL,
  `Login` text COLLATE utf8_polish_ci NOT NULL,
  `Password` text COLLATE utf8_polish_ci NOT NULL,
  `Debt` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`PESEL`, `Name`, `Surname`, `Login`, `Password`, `Debt`) VALUES
(47041399043, 'Weronika', 'Tomaszewska', 'Nablowand1947', 'haslo', 0),
(71060423676, 'Przemysław', 'Zawadzki', 'Havor1971', 'haslo', 0),
(89012312345, 'Jan', 'Kowalski', 'jankowal', 'mojehaslo123', 0),
(91042023249, 'Jacek', 'Karuzela', 'jka', 'haslo', 0),
(91042512321, 'Jan', 'Kowal', 'jkowal', 'haslo', 0),
(92031214563, 'Adam', 'Nowak', 'anowak', 'haslonowak', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bicycles`
--
ALTER TABLE `bicycles`
  ADD PRIMARY KEY (`BicycleID`),
  ADD KEY `STATIONS_KEY` (`StationID`);

--
-- Indexes for table `rentsactive`
--
ALTER TABLE `rentsactive`
  ADD PRIMARY KEY (`RentID`),
  ADD KEY `USERS_KEY` (`PESEL`),
  ADD KEY `BICYCLES_KEY` (`BicycleID`);

--
-- Indexes for table `rentsarchive`
--
ALTER TABLE `rentsarchive`
  ADD PRIMARY KEY (`RentsArchiveID`),
  ADD KEY `USERS_KEY` (`PESEL`),
  ADD KEY `BICYCLES_KEY` (`BicycleID`);

--
-- Indexes for table `stations`
--
ALTER TABLE `stations`
  ADD PRIMARY KEY (`StationID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`PESEL`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bicycles`
--
ALTER TABLE `bicycles`
  MODIFY `BicycleID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `rentsactive`
--
ALTER TABLE `rentsactive`
  MODIFY `RentID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `rentsarchive`
--
ALTER TABLE `rentsarchive`
  MODIFY `RentsArchiveID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `stations`
--
ALTER TABLE `stations`
  MODIFY `StationID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
