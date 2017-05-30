-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-05-2017 a las 14:44:15
-- Versión del servidor: 10.1.13-MariaDB
-- Versión de PHP: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sgtaforce`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `armada`
--

CREATE TABLE `armada` (
  `izena` varchar(30) NOT NULL,
  `irudiUrl` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `armada`
--

INSERT INTO `armada` (`izena`, `irudiUrl`) VALUES
('Errusia', NULL),
('Ipar Korea', NULL),
('Japonia', NULL),
('Russia', NULL),
('Txina', NULL),
('USA', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pertsonaia`
--

CREATE TABLE `pertsonaia` (
  `izena` varchar(20) NOT NULL,
  `armada` varchar(30) DEFAULT NULL,
  `bizitzaP` int(11) DEFAULT NULL,
  `atake` int(11) DEFAULT NULL,
  `defensa` int(11) DEFAULT NULL,
  `mugikortasuna` int(11) DEFAULT NULL,
  `helmena` int(11) DEFAULT NULL,
  `irudiUrl` varchar(200) DEFAULT 'floresiñas_soldado'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pertsonaia`
--

INSERT INTO `pertsonaia` (`izena`, `armada`, `bizitzaP`, `atake`, `defensa`, `mugikortasuna`, `helmena`, `irudiUrl`) VALUES
('Donald Trump', 'USA', 110, 11, 11, 3, 3, 'floresiñas_perso_azul'),
('Kim Yong Un', 'Ipar Korea', 105, 15, 5, 2, 4, 'floresiñas_perso_azul'),
('Shinzo Abe', 'Japonia', 112, 14, 10, 6, 1, 'floresiñas_perso_azul'),
('Vladimir Putin', 'Errusia', 108, 12, 10, 4, 2, 'floresiñas_perso_azul'),
('Xi Jinping', 'Txina', 120, 8, 14, 2, 2, 'floresiñas_perso_azul');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `soldadua`
--

CREATE TABLE `soldadua` (
  `mota` varchar(20) NOT NULL,
  `armada` varchar(30) NOT NULL,
  `bizitzaP` int(11) DEFAULT NULL,
  `atake` int(11) DEFAULT NULL,
  `defensa` int(11) DEFAULT NULL,
  `mugikortasuna` int(11) DEFAULT NULL,
  `helmena` int(11) DEFAULT NULL,
  `irudiUrl` varchar(200) NOT NULL DEFAULT 'floresiñas_soldado'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `soldadua`
--

INSERT INTO `soldadua` (`mota`, `armada`, `bizitzaP`, `atake`, `defensa`, `mugikortasuna`, `helmena`, `irudiUrl`) VALUES
('mele', 'Errusia', 25, 10, 5, 2, 1, 'floresiñas_soldado'),
('mele', 'Ipar Korea', 25, 10, 5, 2, 1, 'floresiñas_soldado'),
('mele', 'Japonia', 25, 10, 5, 2, 1, 'floresiñas_soldado'),
('mele', 'Txina', 25, 10, 5, 2, 1, 'floresiñas_soldado'),
('mele', 'USA', 25, 10, 5, 3, 1, 'floresiñas_soldado'),
('sniper', 'Errusia', 20, 30, 1, 2, 7, 'floresiñas_sniper'),
('sniper', 'Ipar Korea', 20, 30, 1, 2, 7, 'floresiñas_sniper'),
('sniper', 'Japonia', 20, 30, 1, 2, 7, 'floresiñas_sniper'),
('sniper', 'Txina', 20, 30, 1, 2, 7, 'floresiñas_sniper'),
('sniper', 'USA', 20, 30, 1, 2, 7, 'floresiñas_sniper'),
('tank', 'Errusia', 80, 22, 10, 3, 4, 'floresiñas_tank'),
('tank', 'Ipar Korea', 50, 25, 15, 1, 3, 'floresiñas_tank'),
('tank', 'Japonia', 55, 15, 12, 2, 6, 'floresiñas_tank'),
('tank', 'Txina', 30, 36, 10, 4, 4, 'floresiñas_tank'),
('tank', 'USA', 50, 27, 14, 3, 3, 'floresiñas_tank');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `armada`
--
ALTER TABLE `armada`
  ADD PRIMARY KEY (`izena`);

--
-- Indices de la tabla `pertsonaia`
--
ALTER TABLE `pertsonaia`
  ADD PRIMARY KEY (`izena`),
  ADD KEY `armada` (`armada`);

--
-- Indices de la tabla `soldadua`
--
ALTER TABLE `soldadua`
  ADD PRIMARY KEY (`mota`,`armada`),
  ADD KEY `armada` (`armada`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `pertsonaia`
--
ALTER TABLE `pertsonaia`
  ADD CONSTRAINT `pertsonaia_ibfk_1` FOREIGN KEY (`armada`) REFERENCES `armada` (`izena`);

--
-- Filtros para la tabla `soldadua`
--
ALTER TABLE `soldadua`
  ADD CONSTRAINT `soldadua_ibfk_1` FOREIGN KEY (`armada`) REFERENCES `armada` (`izena`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
