-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jul 14, 2021 at 09:07 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `realEstateDb`
--

-- --------------------------------------------------------

--
-- Table structure for table `Agents`
--

CREATE TABLE `Agents` (
  `SellingAgentId` int(11) NOT NULL,
  `SellingAgentName` longtext DEFAULT NULL,
  `AgentPhoto` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Agents`
--

INSERT INTO `Agents` (`SellingAgentId`, `SellingAgentName`, `AgentPhoto`) VALUES
(20, 'app', 'y2_1_08584_20210615160627.jpg'),
(21, 'xxx', 'y2_3_01158_20210615170604.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `realEstateModels`
--

CREATE TABLE `realEstateModels` (
  `RealEstateModelId` int(11) NOT NULL,
  `AC` longtext DEFAULT NULL,
  `Adress` longtext DEFAULT NULL,
  `City` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL,
  `Elevator` longtext DEFAULT NULL,
  `Floor` int(11) NOT NULL,
  `Image1` longtext DEFAULT NULL,
  `Image2` longtext DEFAULT NULL,
  `Meters` int(11) NOT NULL,
  `Parking` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `PropertyStatus` longtext DEFAULT NULL,
  `Rooms` int(11) NOT NULL,
  `image3` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `realEstateModels`
--

INSERT INTO `realEstateModels` (`RealEstateModelId`, `AC`, `Adress`, `City`, `Description`, `Elevator`, `Floor`, `Image1`, `Image2`, `Meters`, `Parking`, `Price`, `PropertyStatus`, `Rooms`, `image3`) VALUES
(1, 'y', 'Menahem Madmon 50', 'Tel Aviv', 'New apartment including water and property tax and cables', 'y', 0, 'y2_2_02205_20210608190642.jpeg', 'y2_3_09949_20210608190644.jpeg', 20, 1, 2800, 'rent', 1, ''),
(2, 'y', 'Yunizman 21', 'Tel Aviv', 'Mandarin Apartment House sits on the northernmost beach of Tel Aviv. Beautiful and very cozy and organized one-room apartment with lots of storage space. Overlooking the sea + balcony and seating area. Car owners have easy access to main roads. The building has a gym, a swimming pool 24/7 all year round, a sauna room + Jacuzzi. Descent to the cliff shore', 'y', 6, 'y2_1_05885_20210603100644.jpeg', 'y2_3_07935_20210603100613.jpeg', 30, 1, 4500, 'rent', 1, ''),
(3, 'y', 'Menahem Begin 19', 'Tel Aviv', 'New !!! Fully furnished studio apartments of a high standard, about 3 minutes from Rothschild Boulevard, in a building access control system for authorized tenants only, accessible by public transportation, can be rented for short and long periods, starting from 2,900 NIS. For more branches of the company visit our website Ramot Arazim- - Petah Tikva branch, Jerusalem branch', 'y', 3, 'o2_2_2_07385_20200421110433.jpg', 'o2_2_1_728619_20191017091031.jpg', 25, 1, 2900, 'rent', 1, ''),
(4, 'y', 'Ben Zion ave. 21', 'Tel Aviv', 'Wonderful and spacious single apartment in the best location in Tel Aviv. Mandatory collateral. Possible for a long time', 'y', 1, 'y2_1_09240_20210607200627.jpeg', 'y2_9_06666_20210611120639.jpeg', 38, 1, 4950, 'rent', 1, ''),
(5, 'y', 'Wolfson 60', 'Tel Aviv', 'In Wolfson 60! [Impossible to change number] In a neat and quiet building with young people, near Florentine, 3 minutes to Lewinsky Market and 7 minutes walk from Rothschild. Single apartment, spacious, renovated. Street parking, access to public transportation --- worth it !!! --- * No animals--', 'y', 0, 'y2_2_05701_20210330210353.jpeg', 'y2_4_09928_20210330210300.jpeg', 30, 1, 3200, 'rent', 1, ''),
(6, 'y', 'Haim Ben Atar 18', 'Tel Aviv', 'Cute and furnished one-room apartment in Florence The price includes water and gas tax without mediation! Not on Saturday!', 'y', 3, 'o2_2_1_04841_20200910100902.jpg', 'o2_2_4_01429_20200910100956.jpg', 30, 1, 3000, 'rent', 1, ''),
(7, 'y', 'Oded 2', 'Tel Aviv', 'Large and new studio for an individual, which includes property taxes, water, and up to the Internet. Quiet apartment in a pastoral area - there is everything in the area! Ample public transportation 5 minutes to the center of Tel Aviv and Azrieli, 10 minutes to Bar Ilan. PS - also short and for a different fee. Not for smokers - quiet and solid tenants', 'y', 3, 'y2_2_06451_20201216181259.jpeg', 'y2_4_06053_20201216181256.jpeg', 25, 1, 3500, 'rent', 1, ''),
(8, 'y', 'HaAgmon 3', 'Tel Aviv', 'Large 2-room apartment + huge roof, 2 balconies, renovated, barred, partial furniture, solar water heater, air conditioning, a short distance from the Haganah train, market, main transport street, parking. (Evacuation can be earlier), suitable for a couple, for the serious only', 'y', 4, 'y2_1_09827_20210522120559.jpeg', 'y2_8_03771_20210522120511.jpeg', 45, 1, 3400, 'rend', 2, ''),
(9, 'y', 'HaZoar 29', 'Tel Aviv', 'Pleasant and well-kept apartment in good condition, two air directions (north and west) for a single or a couple - not suitable for partners', 'y', 1, 'y2_1_02782_20210610200613.jpeg', 'y2_4_08767_20210610200620.jpeg', 50, 1, 5800, 'rent', 2, ''),
(10, 'y', 'Zvia Lubetkin 23', 'Tel Aviv', 'New apartment with easy access to everywhere, how thin? From Ayalon, beautiful apartment with wooden doors, solar water heater, ample parking, it is recommended to come and be impressed !!!', 'y', 0, 'y2_3_08436_20210611200628.jpeg', 'y2_8_05870_20210611200631.jpeg', 45, 1, 3500, 'rent', 2, '');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20210608165801_initial', '2.0.1-rtm-125'),
('20210608165932_initial1', '2.0.1-rtm-125'),
('20210608170038_AddSomeAgents', '2.0.1-rtm-125'),
('20210609170005_tableWithAgentPhoto', '2.0.1-rtm-125'),
('20210616173911_real-estate-model', '2.0.1-rtm-125'),
('20210616174426_real-estate-model1', '2.0.1-rtm-125');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Agents`
--
ALTER TABLE `Agents`
  ADD PRIMARY KEY (`SellingAgentId`);

--
-- Indexes for table `realEstateModels`
--
ALTER TABLE `realEstateModels`
  ADD PRIMARY KEY (`RealEstateModelId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Agents`
--
ALTER TABLE `Agents`
  MODIFY `SellingAgentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `realEstateModels`
--
ALTER TABLE `realEstateModels`
  MODIFY `RealEstateModelId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
