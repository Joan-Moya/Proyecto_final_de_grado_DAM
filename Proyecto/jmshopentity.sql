-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-05-2020 a las 02:05:24
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `jmshopentity`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administradores`
--

CREATE TABLE `administradores` (
  `AdministradorId` int(11) NOT NULL,
  `NombreUsuario` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Password` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `administradores`
--

INSERT INTO `administradores` (`AdministradorId`, `NombreUsuario`, `Password`, `Email`) VALUES
(1, 'root', '123', 'root@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccionesenvio`
--

CREATE TABLE `direccionesenvio` (
  `DireccionEnvioId` int(11) NOT NULL,
  `Calle` varchar(50) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NumDomicilio` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Poblacion` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Ciudad` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Provincia` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `CodPostal` varchar(10) CHARACTER SET utf8mb4 DEFAULT NULL,
  `UsuarioId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `direccionesenvio`
--

INSERT INTO `direccionesenvio` (`DireccionEnvioId`, `Calle`, `NumDomicilio`, `Poblacion`, `Ciudad`, `Provincia`, `CodPostal`, `UsuarioId`) VALUES
(16, 'dasd', 'asd', 'asd', 'asd', 'asd', 'asdas', 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `informacionpagos`
--

CREATE TABLE `informacionpagos` (
  `InformacionPagoId` int(11) NOT NULL,
  `NumTarjeta` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Tipo` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `FechaCaducidad` datetime(6) NOT NULL,
  `CodSeguridad` int(11) NOT NULL,
  `UsuarioId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `informacionpagos`
--

INSERT INTO `informacionpagos` (`InformacionPagoId`, `NumTarjeta`, `Tipo`, `FechaCaducidad`, `CodSeguridad`, `UsuarioId`) VALUES
(7, 'wdaw', 'awdawd', '2020-04-30 00:00:00.000000', 22, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `PedidoId` int(11) NOT NULL,
  `FechaCreacion` datetime(6) NOT NULL,
  `UsuarioId` int(11) NOT NULL,
  `EsCarrito` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`PedidoId`, `FechaCreacion`, `UsuarioId`, `EsCarrito`) VALUES
(19, '2020-05-25 20:08:55.640325', 9, 0),
(20, '2020-05-25 21:49:23.570957', 9, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Id` int(11) NOT NULL,
  `Descripcion` longtext CHARACTER SET utf8mb4,
  `Precio` double NOT NULL,
  `Cristal` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Diametro` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Marca` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Modelo` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `TipoCorrea` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ImagenProducto` varchar(100) CHARACTER SET utf8mb4 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Id`, `Descripcion`, `Precio`, `Cristal`, `Diametro`, `Marca`, `Modelo`, `TipoCorrea`, `ImagenProducto`) VALUES
(17, 'Ventanilla del día de la semana, calendario con aguja, ventanilla del mes.', 4500, 'Cuarzo', '21mm', 'Montblanc', 'Star legacy', 'Cuero', 'MontblancLegaci.jpg'),
(18, 'Automático, cuerda automática', 7600, 'Cristal', '32mm', 'Montblanc', 'Nicolas', 'Cuero', 'MontblancNicolas.jpg'),
(19, 'Reloj de alta joyería', 8700, 'Cristal', '45mm', 'Chopard', 'Perpetual', 'Cuero', 'ChopardPerceptual.jpg'),
(20, 'Oro rosa ético con certificado', 5200, 'Cuarzo', '42,5mm', 'Chopard', 'Strike', 'Cuero', 'ChopardStrike.jpg'),
(21, 'Reloj metálico', 7000, 'Cristal', '32mm', 'Seiko', 'Astron', 'Acero', 'SeikoAstron.jpg'),
(22, 'Reloj con GPSCauxo', 1720, 'Cuarzo', '32mm', 'Seiko', 'Gps solar', 'Acero', 'SeikoSolar.jpg'),
(23, 'Reloj mecanico', 6800, 'Cristal', '45mm', 'Luis Moinet', 'Chrono', 'Cuero', 'LuisMoinetChrono.jpg'),
(24, 'Edición limitada', 4700, 'Cuarzo', '32mm', 'Luis Moinet', 'Rosetta', 'Cuero', 'LuisMoinetRosetta.jpg'),
(25, 'Reloj metálico 5 atmosferas', 8900, 'Cuarzo', '45mm', 'Breitling', 'Navitime', 'Acero', 'BreitlingNavitime.jpg'),
(26, 'Edición limitada', 3400, 'Cristal', '32mm', 'Breitling', 'Automatic', 'Cuero', 'BreitlingAutomatic.jpg'),
(27, 'Especial edition', 4500, 'Cristal', '35mm', 'Omega', 'Speed Master', 'Cuero', 'OmegaSpeedmaster.jpg'),
(28, 'Edición oscura', 4600, 'Cristal', '35mm', 'Omega', 'Moonwatch', 'Cuero', 'OmegaMoonwatch.jpg'),
(29, 'Reloj mecánico', 3900, 'Cuarzo', '35mm', 'Rolex', 'Orient', 'Acero', 'RolexOrient.jpg'),
(30, 'Reloj a pila', 1450, 'Cristal', '35mm', 'Rolex', 'Daytona', 'Cauxo', 'RolexDaytona.jpg'),
(31, 'Reloj con muchas complicaciones', 34000, 'Cuarzo', '40mm', 'Patek Phillipe', 'Grand', 'Cuero', 'PatekPhillipeGrand.jpg'),
(32, 'Reloj 34 rubies', 5500, 'Cristal', '35mm', 'Patek Phillipe', 'Complicaciones', 'Cuero', 'PatekPhillipeComplicaciones.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productospedidos`
--

CREATE TABLE `productospedidos` (
  `ProductoPedidoId` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Total` double NOT NULL,
  `PedidoId` int(11) NOT NULL,
  `ProductoId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productospedidos`
--

INSERT INTO `productospedidos` (`ProductoPedidoId`, `Cantidad`, `Total`, `PedidoId`, `ProductoId`) VALUES
(31, 1, 4500, 20, 17),
(32, 1, 8900, 20, 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transacciones`
--

CREATE TABLE `transacciones` (
  `TransaccionId` int(11) NOT NULL,
  `Total` double NOT NULL,
  `Estado` varchar(25) CHARACTER SET utf8mb4 DEFAULT NULL,
  `FechaCreacion` datetime(6) NOT NULL,
  `InformacionPagoId` int(11) NOT NULL,
  `PedidoId` int(11) NOT NULL,
  `DireccionEnvioId` int(11) NOT NULL DEFAULT '0',
  `PagoRealizado` tinyint(1) NOT NULL DEFAULT '0',
  `NotasEntrega` varchar(150) CHARACTER SET utf8mb4 DEFAULT NULL,
  `FechaEntrega` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `transacciones`
--

INSERT INTO `transacciones` (`TransaccionId`, `Total`, `Estado`, `FechaCreacion`, `InformacionPagoId`, `PedidoId`, `DireccionEnvioId`, `PagoRealizado`, `NotasEntrega`, `FechaEntrega`) VALUES
(15, 33000, 'Entregado', '2020-05-25 20:10:44.281867', 7, 19, 16, 0, 'wdwdwd', '2020-05-28 20:10:44.281867'),
(16, 13400, 'Pendiente de pago', '2020-05-25 21:50:25.596353', 7, 20, 16, 0, 'dasfasdf', '2020-05-28 21:50:25.596353');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `UsuarioId` int(11) NOT NULL,
  `Nombre` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Apellidos` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Password` varchar(20) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Telefono` varchar(12) CHARACTER SET utf8mb4 DEFAULT NULL,
  `FechaNacimiento` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`UsuarioId`, `Nombre`, `Apellidos`, `Email`, `Password`, `Telefono`, `FechaNacimiento`) VALUES
(9, 'Joan', 'pepito palotes', 'joan@gmail.com', 'contraseña', '99999999', '2020-05-06 00:00:00.000000');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20200503123526_m1', '3.1.3'),
('20200519075351_m2', '3.1.3'),
('20200519080047_m3', '3.1.3'),
('20200520105324_m4', '3.1.3'),
('20200522103217_m5', '3.1.3'),
('20200522104659_m6', '3.1.3'),
('20200522170825_m7', '3.1.3'),
('20200522232917_m8', '3.1.3'),
('20200522235204_m9', '3.1.3'),
('20200523001803_m10', '3.1.3'),
('20200523002233_m11', '3.1.3'),
('20200523003439_m12', '3.1.3'),
('20200525192121_m13', '3.1.3');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `administradores`
--
ALTER TABLE `administradores`
  ADD PRIMARY KEY (`AdministradorId`);

--
-- Indices de la tabla `direccionesenvio`
--
ALTER TABLE `direccionesenvio`
  ADD PRIMARY KEY (`DireccionEnvioId`),
  ADD KEY `IX_DireccionesEnvio_UsuarioId` (`UsuarioId`);

--
-- Indices de la tabla `informacionpagos`
--
ALTER TABLE `informacionpagos`
  ADD PRIMARY KEY (`InformacionPagoId`),
  ADD KEY `IX_InformacionPagos_UsuarioId` (`UsuarioId`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`PedidoId`),
  ADD KEY `IX_Pedidos_UsuarioId` (`UsuarioId`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `productospedidos`
--
ALTER TABLE `productospedidos`
  ADD PRIMARY KEY (`ProductoPedidoId`),
  ADD KEY `IX_ProductosPedidos_PedidoId` (`PedidoId`),
  ADD KEY `IX_ProductosPedidos_ProductoId` (`ProductoId`);

--
-- Indices de la tabla `transacciones`
--
ALTER TABLE `transacciones`
  ADD PRIMARY KEY (`TransaccionId`),
  ADD UNIQUE KEY `IX_Transacciones_PedidoId` (`PedidoId`),
  ADD KEY `IX_Transacciones_InformacionPagoId` (`InformacionPagoId`),
  ADD KEY `IX_Transacciones_DireccionEnvioId` (`DireccionEnvioId`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`UsuarioId`);

--
-- Indices de la tabla `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `administradores`
--
ALTER TABLE `administradores`
  MODIFY `AdministradorId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `direccionesenvio`
--
ALTER TABLE `direccionesenvio`
  MODIFY `DireccionEnvioId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `informacionpagos`
--
ALTER TABLE `informacionpagos`
  MODIFY `InformacionPagoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `PedidoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT de la tabla `productospedidos`
--
ALTER TABLE `productospedidos`
  MODIFY `ProductoPedidoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `transacciones`
--
ALTER TABLE `transacciones`
  MODIFY `TransaccionId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `UsuarioId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `direccionesenvio`
--
ALTER TABLE `direccionesenvio`
  ADD CONSTRAINT `FK_DireccionesEnvio_Usuarios_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `usuarios` (`UsuarioId`) ON DELETE CASCADE;

--
-- Filtros para la tabla `informacionpagos`
--
ALTER TABLE `informacionpagos`
  ADD CONSTRAINT `FK_InformacionPagos_Usuarios_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `usuarios` (`UsuarioId`) ON DELETE CASCADE;

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `FK_Pedidos_Usuarios_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `usuarios` (`UsuarioId`) ON DELETE CASCADE;

--
-- Filtros para la tabla `productospedidos`
--
ALTER TABLE `productospedidos`
  ADD CONSTRAINT `FK_ProductosPedidos_Pedidos_PedidoId` FOREIGN KEY (`PedidoId`) REFERENCES `pedidos` (`PedidoId`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_ProductosPedidos_Productos_ProductoId` FOREIGN KEY (`ProductoId`) REFERENCES `productos` (`Id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `transacciones`
--
ALTER TABLE `transacciones`
  ADD CONSTRAINT `FK_Transacciones_DireccionesEnvio_DireccionEnvioId` FOREIGN KEY (`DireccionEnvioId`) REFERENCES `direccionesenvio` (`DireccionEnvioId`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Transacciones_InformacionPagos_InformacionPagoId` FOREIGN KEY (`InformacionPagoId`) REFERENCES `informacionpagos` (`InformacionPagoId`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Transacciones_Pedidos_PedidoId` FOREIGN KEY (`PedidoId`) REFERENCES `pedidos` (`PedidoId`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
