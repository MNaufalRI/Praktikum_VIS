-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Apr 2026 pada 16.41
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

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
-- Struktur dari tabel `tb_animal_card`
--

CREATE TABLE `tb_animal_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaAnimal` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `strength` int(11) NOT NULL,
  `health` int(11) NOT NULL,
  `skillP` varchar(100) NOT NULL,
  `skillG` varchar(100) NOT NULL,
  `skillT` varchar(100) NOT NULL,
  `deskripsi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_animal_card`
--

INSERT INTO `tb_animal_card` (`kodeKartu`, `namaAnimal`, `rarity`, `strength`, `health`, `skillP`, `skillG`, `skillT`, `deskripsi`) VALUES
('A001', 'Lion', 'Gold', 7000, 7000, 'Royal Fang', 'King Smasher', 'Dynamic Spin', 'King of Animals');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_miracle_card`
--

CREATE TABLE `tb_miracle_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaKartu` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `jumlahMiracle` int(11) NOT NULL,
  `efekMiracle` varchar(100) NOT NULL,
  `deskripsi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_miracle_card`
--

INSERT INTO `tb_miracle_card` (`kodeKartu`, `namaKartu`, `rarity`, `jumlahMiracle`, `efekMiracle`, `deskripsi`) VALUES
('M002', 'Meteor Shower', 'Silver', 4000, 'All Doubling', 'Call forth the meteor showers in outer space! Crash them againts your enemies!');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_strong_card`
--

CREATE TABLE `tb_strong_card` (
  `kodeKartu` varchar(10) NOT NULL,
  `namaKartu` varchar(100) NOT NULL,
  `rarity` enum('Gold','Silver','Bronze','Common') NOT NULL,
  `nilaiP` int(11) NOT NULL,
  `nilaiG` int(11) NOT NULL,
  `nilaiT` int(11) NOT NULL,
  `auraEffect` varchar(50) NOT NULL,
  `deskripsi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tb_strong_card`
--

INSERT INTO `tb_strong_card` (`kodeKartu`, `namaKartu`, `rarity`, `nilaiP`, `nilaiG`, `nilaiT`, `auraEffect`, `deskripsi`) VALUES
('S004', 'Victory Power', 'Bronze', 2, 5, 1, 'Defense Aura', '');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_animal_card`
--
ALTER TABLE `tb_animal_card`
  ADD PRIMARY KEY (`kodeKartu`);

--
-- Indeks untuk tabel `tb_miracle_card`
--
ALTER TABLE `tb_miracle_card`
  ADD PRIMARY KEY (`kodeKartu`);

--
-- Indeks untuk tabel `tb_strong_card`
--
ALTER TABLE `tb_strong_card`
  ADD PRIMARY KEY (`kodeKartu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
