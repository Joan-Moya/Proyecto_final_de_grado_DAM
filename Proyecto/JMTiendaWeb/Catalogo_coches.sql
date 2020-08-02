-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 29, 2019 at 02:43 PM
-- Server version: 5.7.23
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Catalogo_coches`
--

-- --------------------------------------------------------

--
-- Table structure for table `coches`
--

CREATE TABLE `coches` (
  `id` int(10) NOT NULL,
  `marca` varchar(15) NOT NULL,
  `modelo` varchar(15) NOT NULL,
  `combustible` varchar(15) NOT NULL,
  `kilometros` int(6) NOT NULL,
  `puertas` int(8) NOT NULL,
  `cv` int(3) NOT NULL,
  `precio` decimal(8,2) NOT NULL,
  `descripcion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `coches`
--

INSERT INTO `coches` (`id`, `marca`, `modelo`, `combustible`, `kilometros`, `puertas`, `cv`, `precio`, `descripcion`) VALUES
(1, 'Audi', 'A1 SportBack', 'Diesel', 1200, 4, 110, '19000.00', 'Coche de importación'),
(2, 'Audi', 'A4', 'Gasolina', 0, 5, 150, '34569.00', 'Audi A4 Advanced edition'),
(3, 'Porsche', 'Boxter 718', 'Gasolina', 3000, 3, 290, '61547.00', 'Ultimo modelo de este año importado de Alemania'),
(4, 'Porsche', 'Panamera', 'Gasolina', 0, 5, 200, '105910.00', 'Porsche Panamera Berlina Gasolina'),
(5, 'Jaguar', 'Pace', 'Gasolina', 1000, 5, 180, '66880.00', 'Nuevo modelo'),
(6, 'Jaguar', 'F-Type', 'Gasolina', 2000, 5, 180, '72100.00', 'Coche de importación'),
(7, 'Mercedes', 'Clase c', 'Gasolina', 100, 5, 200, '45000.00', 'Coche de importación'),
(8, 'Mercedes', 'GLA', 'Gasolina', 0, 5, 130, '34000.00', 'Modelo con todos los extras'),
(9, 'Mercedes', 'GLC', 'Diesel', 15000, 5, 170, '52234.00', 'Coche de esposición'),
(10, 'Mercedes', 'Clase E', 'Gasolina', 12000, 5, 187, '53210.00', 'Mercedes clase-E edición sport'),
(11, 'Bmw', 'Serie 3', 'Gasolina', 3000, 5, 116, '33420.00', 'Consumo de 5.7/100, modelo ECO'),
(12, 'Aston Martin', 'DB11 V8', 'Gasolina', 1200, 5, 220, '100000.00', 'Modelo EcoSport'),
(13, 'Aston Martin', 'DB9', 'Gasolina', 0, 3, 190, '73000.00', 'Suspensión plus'),
(14, 'Aston Martin', 'Avantage', 'Diesel', 1200, 3, 180, '63000.00', 'Coche de importación'),
(15, 'Tesla', 'Model S', 'Electrico', 0, 5, 388, '59299.00', 'Tesla Model S ultimo modelo'),
(16, 'Tesla', 'Model S', 'Electrico', 0, 5, 400, '63000.00', 'Tesla Model-S con el motor mas potente'),
(17, 'Lexus', 'RC', 'Gasolina', 240, 5, 180, '48100.00', 'Modelo con color de edición limitada'),
(18, 'Lexus', 'NX', 'Diesel', 0, 5, 187, '45000.00', 'Lexus NX modelo 2018');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `coches`
--
ALTER TABLE `coches`
  ADD PRIMARY KEY (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
