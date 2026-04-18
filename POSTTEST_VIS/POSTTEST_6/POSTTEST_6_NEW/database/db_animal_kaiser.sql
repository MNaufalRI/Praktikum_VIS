-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2026 at 03:32 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_animal_kaiser`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_animal_card`
--

CREATE TABLE `tb_animal_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaAnimal` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `strength` int(11) NOT NULL DEFAULT 0,
  `health` int(11) NOT NULL DEFAULT 0,
  `skillP` varchar(100) NOT NULL,
  `skillG` varchar(100) NOT NULL,
  `skillT` varchar(100) NOT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_deck`
--

CREATE TABLE `tb_deck` (
  `idDeck` int(11) NOT NULL,
  `namaDeck` varchar(100) NOT NULL,
  `idPemain` int(11) NOT NULL,
  `kodeAnimal` varchar(10) NOT NULL,
  `kodeStrong` varchar(10) NOT NULL,
  `kodeMiracle` varchar(10) NOT NULL,
  `totalPower` int(11) NOT NULL DEFAULT 0,
  `statusDeck` enum('Aktif','Nonaktif') NOT NULL DEFAULT 'Aktif',
  `tanggalBuat` date NOT NULL DEFAULT curdate(),
  `catatan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_miracle_card`
--

CREATE TABLE `tb_miracle_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaKartu` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `jumlahMiracle` int(11) NOT NULL DEFAULT 1,
  `efekMiracle` varchar(100) NOT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_pemain`
--

CREATE TABLE `tb_pemain` (
  `idPemain` int(11) NOT NULL,
  `namaPemain` varchar(100) NOT NULL,
  `username` varchar(50) NOT NULL,
  `totalDeck` int(11) NOT NULL DEFAULT 0,
  `totalMenang` int(11) NOT NULL DEFAULT 0,
  `totalKalah` int(11) NOT NULL DEFAULT 0,
  `tanggalDaftar` date NOT NULL DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_strong_card`
--

CREATE TABLE `tb_strong_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaKartu` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `nilaiP` int(11) NOT NULL DEFAULT 0,
  `nilaiG` int(11) NOT NULL DEFAULT 0,
  `nilaiT` int(11) NOT NULL DEFAULT 0,
  `auraEffect` varchar(50) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_animal_card`
--
ALTER TABLE `tb_animal_card`
  ADD PRIMARY KEY (`kodeKartu`);

--
-- Indexes for table `tb_deck`
--
ALTER TABLE `tb_deck`
  ADD PRIMARY KEY (`idDeck`),
  ADD KEY `idPemain` (`idPemain`),
  ADD KEY `kodeAnimal` (`kodeAnimal`),
  ADD KEY `kodeStrong` (`kodeStrong`),
  ADD KEY `kodeMiracle` (`kodeMiracle`);

--
-- Indexes for table `tb_miracle_card`
--
ALTER TABLE `tb_miracle_card`
  ADD PRIMARY KEY (`kodeKartu`);

--
-- Indexes for table `tb_pemain`
--
ALTER TABLE `tb_pemain`
  ADD PRIMARY KEY (`idPemain`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tb_strong_card`
--
ALTER TABLE `tb_strong_card`
  ADD PRIMARY KEY (`kodeKartu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_deck`
--
ALTER TABLE `tb_deck`
  MODIFY `idDeck` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_pemain`
--
ALTER TABLE `tb_pemain`
  MODIFY `idPemain` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_deck`
--
ALTER TABLE `tb_deck`
  ADD CONSTRAINT `tb_deck_ibfk_1` FOREIGN KEY (`idPemain`) REFERENCES `tb_pemain` (`idPemain`) ON DELETE CASCADE,
  ADD CONSTRAINT `tb_deck_ibfk_2` FOREIGN KEY (`kodeAnimal`) REFERENCES `tb_animal_card` (`kodeKartu`),
  ADD CONSTRAINT `tb_deck_ibfk_3` FOREIGN KEY (`kodeStrong`) REFERENCES `tb_strong_card` (`kodeKartu`),
  ADD CONSTRAINT `tb_deck_ibfk_4` FOREIGN KEY (`kodeMiracle`) REFERENCES `tb_miracle_card` (`kodeKartu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
