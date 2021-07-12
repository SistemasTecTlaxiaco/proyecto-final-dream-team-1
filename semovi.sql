-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-07-2021 a las 17:49:46
-- Versión del servidor: 10.4.19-MariaDB
-- Versión de PHP: 8.0.7
-- edicion
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `semovi`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `citas`
--

CREATE TABLE `citas` (
  `id_c` int(5) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `departamento` varchar(20) NOT NULL,
  `correo` varchar(25) NOT NULL,
  `fecha` varchar(10) NOT NULL,
  `hora` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `citas`
--

INSERT INTO `citas` (`id_c`, `nombre`, `departamento`, `correo`, `fecha`, `hora`) VALUES
(9, 'David Sanchez', 'LICENCIAS', 'aesha@gmail.com', '2021-7-20', '10:00'),
(10, 'Mario Aguirre', 'LICENCIAS', 'mamm@hotmail.com', '2021-7-20', '15:00'),
(11, 'Arturo Quezada', 'TENENCIA', 'quez@gamilc.om', '2021-7-20', '13:00'),
(12, 'Paco Mendez', 'LICENCIAS', 'pacoo@gmail.com', '2021-7-21', '12:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `citas`
--
ALTER TABLE `citas`
  ADD PRIMARY KEY (`id_c`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `citas`
--
ALTER TABLE `citas`
  MODIFY `id_c` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
