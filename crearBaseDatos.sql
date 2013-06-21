-- phpMyAdmin SQL Dump
-- version 2.10.2
-- http://www.phpmyadmin.net
-- 
-- Servidor: localhost
-- Tiempo de generación: 21-06-2013 a las 11:26:42
-- Versión del servidor: 5.0.45
-- Versión de PHP: 5.2.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Base de datos: `bd_crjr703`
-- 
CREATE DATABASE `bd_crjr703` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bd_crjr703`;

-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `cliente`
-- 

CREATE TABLE `cliente` (
  `rut` varchar(12) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `direccion` varchar(20) NOT NULL,
  `telefono` varchar(8) NOT NULL,
  PRIMARY KEY  (`rut`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Volcar la base de datos para la tabla `cliente`
-- 


-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `orden_trabajo`
-- 

CREATE TABLE `orden_trabajo` (
  `num_orden` int(5) NOT NULL auto_increment,
  `fecha` date NOT NULL,
  `observacion` varchar(131) NOT NULL,
  `rut_cliente` varchar(12) NOT NULL,
  `rut_empleado` varchar(12) NOT NULL,
  `cod_pc` varchar(5) NOT NULL,
  `tiempo` varchar(3) NOT NULL,
  PRIMARY KEY  (`num_orden`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- 
-- Volcar la base de datos para la tabla `orden_trabajo`
-- 


-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pc_escritorio`
-- 

CREATE TABLE `pc_escritorio` (
  `marca` varchar(10) NOT NULL,
  `modelo` varchar(10) NOT NULL,
  `cant_ram` varchar(2) NOT NULL,
  `tipo_pro` varchar(5) NOT NULL,
  `capacidad` varchar(2) NOT NULL,
  `cod_pc_e` varchar(5) NOT NULL,
  PRIMARY KEY  (`cod_pc_e`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Volcar la base de datos para la tabla `pc_escritorio`
-- 


-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `pc_portable`
-- 

CREATE TABLE `pc_portable` (
  `marca` varchar(10) NOT NULL,
  `modelo` varchar(10) NOT NULL,
  `cant_ram` varchar(2) NOT NULL,
  `tipo_pro` varchar(5) NOT NULL,
  `capacidad` varchar(2) NOT NULL,
  `diagnostico` varchar(131) NOT NULL,
  `acc_bateria` varchar(2) NOT NULL,
  `acc_cargador` varchar(2) NOT NULL,
  `cod_pc_p` varchar(5) NOT NULL,
  PRIMARY KEY  (`cod_pc_p`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Volcar la base de datos para la tabla `pc_portable`
-- 


-- --------------------------------------------------------

-- 
-- Estructura de tabla para la tabla `tecnico`
-- 

CREATE TABLE `tecnico` (
  `rut` varchar(12) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `direccion` varchar(20) NOT NULL,
  `telefono` varchar(8) NOT NULL,
  `especialidad` varchar(20) NOT NULL,
  PRIMARY KEY  (`rut`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Volcar la base de datos para la tabla `tecnico`
-- 

INSERT INTO `tecnico` VALUES ('13', 'maria', 'jj latorre', '34', 'analista ');
INSERT INTO `tecnico` VALUES ('33.333.333-3', 'dd', 'ff', '33', 'dd');
INSERT INTO `tecnico` VALUES ('12.312.321-3', 'claudio', 'coquimbo', '78', 'analista');
INSERT INTO `tecnico` VALUES ('15', 'maria', 'cuba', '33', 'analista');
INSERT INTO `tecnico` VALUES ('14.   .   -', 'sd', 'sd', '44', 'sd');
