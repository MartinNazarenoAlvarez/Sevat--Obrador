-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.32-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para bd_obrador
CREATE DATABASE IF NOT EXISTS `bd_obrador` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `bd_obrador`;

-- Volcando estructura para tabla bd_obrador.asignaciones
CREATE TABLE IF NOT EXISTS `asignaciones` (
  `idAsignacion` int(11) NOT NULL,
  `id_herramienta` int(11) DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `fechaAsignacion` date DEFAULT NULL,
  `fechaDevolucion` date DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idAsignacion`),
  UNIQUE KEY `id_herramienta` (`id_herramienta`),
  UNIQUE KEY `id_empleado` (`id_empleado`),
  CONSTRAINT `FK_empleado2` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_herramienta2` FOREIGN KEY (`id_herramienta`) REFERENCES `herramientas` (`idHerramienta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.asignaciones: ~0 rows (aproximadamente)

-- Volcando estructura para procedimiento bd_obrador.asp_actualizarEmpleado
DELIMITER //
CREATE PROCEDURE `asp_actualizarEmpleado`(
	IN `_apellido` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_cargo` VARCHAR(50),
	IN `_telefono` VARCHAR(50),
	IN `_dni_original` VARCHAR(10),
	IN `_dni_nuevo` VARCHAR(50)
)
BEGIN
    UPDATE empleados
    SET 
	   	dni = _dni_nuevo,
	      apellido = _apellido,
	      nombre = _nombre,
	   	cargo = _cargo,
	      telefono = _telefono
    WHERE dni = _dni_original;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_eliminarEmpleado
DELIMITER //
CREATE PROCEDURE `asp_eliminarEmpleado`(
	IN `_dni` VARCHAR(10)
)
BEGIN
	DELETE FROM empleados WHERE dni = _dni;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_guardar_empleado
DELIMITER //
CREATE PROCEDURE `asp_guardar_empleado`(
	IN `_dni` VARCHAR(10),
	IN `_apellido` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_cargo` VARCHAR(50),
	IN `_telefono` VARCHAR(15)
)
BEGIN
INSERT INTO empleados(dni, apellido, nombre, cargo, telefono,activo)
VALUES (_dni, _apellido, _nombre, _cargo, _telefono, TRUE);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_totalEmpleado
DELIMITER //
CREATE PROCEDURE `asp_totalEmpleado`()
BEGIN
	SELECT COUNT(*) AS TotalEmpleados FROM empleados WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para tabla bd_obrador.empleados
CREATE TABLE IF NOT EXISTS `empleados` (
  `IdEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `dni` varchar(10) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `cargo` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdEmpleado`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.empleados: ~8 rows (aproximadamente)
INSERT INTO `empleados` (`IdEmpleado`, `dni`, `apellido`, `nombre`, `cargo`, `telefono`, `activo`) VALUES
	(1, '46543435', 'Alvarez', 'Nazareno', 'No se', '38155682521', 1),
	(2, '46666269', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1),
	(3, '50493264', 'Alvarez Romero', 'Pancracio', 'No se', '3838383834', 0),
	(4, '12345678', 'ApellidoPrueba', 'NombrePrueba', 'Carg1', '123456789', 1),
	(6, '4643532', 'Alvarez', 'Nazareno', 'Gerente', '425210', 1),
	(7, '1', 'ApellidoPrueba', 'NombrePrueba', 'd', '123456789', 1),
	(13, '29436853', 'Cano', 'Marcelo', 'Docente', '333-444', 1),
	(29, '46666266', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1);

-- Volcando estructura para tabla bd_obrador.herramientas
CREATE TABLE IF NOT EXISTS `herramientas` (
  `idHerramienta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `descripcion` varchar(150) NOT NULL DEFAULT '0',
  `marca` varchar(50) NOT NULL DEFAULT '0',
  `modelo` varchar(50) NOT NULL DEFAULT '0',
  `estado` varchar(20) NOT NULL DEFAULT '0',
  `disponible` int(11) NOT NULL DEFAULT 0,
  `activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idHerramienta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.herramientas: ~0 rows (aproximadamente)

-- Volcando estructura para tabla bd_obrador.prestamos
CREATE TABLE IF NOT EXISTS `prestamos` (
  `idPrestamo` int(11) NOT NULL AUTO_INCREMENT,
  `id_herramienta` int(11) NOT NULL DEFAULT 0,
  `id_empleado` int(11) NOT NULL DEFAULT 0,
  `fecha` date DEFAULT NULL,
  `tipo_movimiento` varchar(20) DEFAULT '0',
  `cantidad` int(11) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrestamo`),
  UNIQUE KEY `id_empleado` (`id_empleado`),
  UNIQUE KEY `id_herramienta` (`id_herramienta`),
  CONSTRAINT `FK_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_herramienta` FOREIGN KEY (`id_herramienta`) REFERENCES `herramientas` (`idHerramienta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.prestamos: ~0 rows (aproximadamente)

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleados
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleados`()
BEGIN
SELECT idEmpleado,dni,apellido,nombre,cargo,telefono FROM empleados WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoXapellido
DELIMITER //
CREATE PROCEDURE `psa_listadoXapellido`(
	IN `_apellido` VARCHAR(50)
)
BEGIN
SELECT * FROM empleados WHERE apellido = _apellido AND activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoXid
DELIMITER //
CREATE PROCEDURE `psa_listadoXid`(
	IN `_id` VARCHAR(10)
)
BEGIN
SELECT * FROM empleados WHERE idEmpleado = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_ListarEmpleadoxdni
DELIMITER //
CREATE PROCEDURE `psa_ListarEmpleadoxdni`(
	IN `_dni` VARCHAR(10)
)
BEGIN
SELECT * FROM empleados WHERE dni = _dni AND activo = 1;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
