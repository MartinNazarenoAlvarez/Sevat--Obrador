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
	IN `_dni_nuevo` VARCHAR(50),
	IN `_activo` TINYINT
)
BEGIN
    UPDATE empleados
    SET 
	   	dni = _dni_nuevo,
	      apellido = _apellido,
	      nombre = _nombre,
	   	cargo = _cargo,
	      telefono = _telefono,
	      activo = _activo
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

-- Volcando estructura para procedimiento bd_obrador.asp_guardar_herramienta
DELIMITER //
CREATE PROCEDURE `asp_guardar_herramienta`(
	IN `_serial` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_descripcion` VARCHAR(150),
	IN `_marca` VARCHAR(50),
	IN `_modelo` VARCHAR(50),
	IN `_estado` VARCHAR(20)
)
BEGIN
	INSERT INTO herramientas(numero_serie, nombre, descripcion, marca, modelo, estado, disponible, activo)
	VALUES (_serial, _nombre, _descripcion, _marca, _modelo, _estado, TRUE, TRUE);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_totalEmpleado
DELIMITER //
CREATE PROCEDURE `asp_totalEmpleado`()
BEGIN
    SELECT 
        COUNT(CASE WHEN activo = 0 THEN 1 END) AS TotalInactivos,
        COUNT(CASE WHEN activo = 1 THEN 1 END) AS TotalActivos
    FROM empleados;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_totalEmpleadoInactivos
DELIMITER //
CREATE PROCEDURE `asp_totalEmpleadoInactivos`()
BEGIN
	SELECT COUNT(*) AS TotalEmpleados FROM empleados WHERE activo = 0;
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
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.empleados: ~12 rows (aproximadamente)
INSERT INTO `empleados` (`IdEmpleado`, `dni`, `apellido`, `nombre`, `cargo`, `telefono`, `activo`) VALUES
	(2, '46666269', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1),
	(3, '50493264', 'Alvarez Romero', 'Pancracio', 'No se', '3838383834', 1),
	(4, '12345678', 'ApellidoPrueba', 'NombrePrueba', 'Carg1', '123456789', 1),
	(7, '1', 'ApellidoPrueba', 'NombrePrueba', 'd', '123456789', 1),
	(13, '29436853', 'Cano', 'Marcelo', 'Docente', '333-444', 1),
	(29, '46666266', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1),
	(38, '43', '2', '3', '5', '2', 0),
	(39, '46432323', 'Alvarez Romero', 'Csharp', 'Crack', '333333', 1),
	(42, '555', '2', '2', '34', '2', 0),
	(44, '3232', '3232', '23232', '3232', '3232', 1),
	(45, '', '', '', '', '', 0),
	(46, '554', 'Alvarez', '343', '54', '54', 1),
	(47, '5547', 'Alvarez', '343', '54', '54', 1);

-- Volcando estructura para tabla bd_obrador.herramientas
CREATE TABLE IF NOT EXISTS `herramientas` (
  `idHerramienta` int(11) NOT NULL AUTO_INCREMENT,
  `numero_serie` varchar(20) DEFAULT NULL,
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `descripcion` varchar(150) NOT NULL DEFAULT '0',
  `marca` varchar(50) NOT NULL DEFAULT '0',
  `modelo` varchar(50) NOT NULL DEFAULT '0',
  `estado` varchar(20) NOT NULL DEFAULT '0',
  `disponible` tinyint(1) NOT NULL DEFAULT 0,
  `activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idHerramienta`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.herramientas: ~14 rows (aproximadamente)
INSERT INTO `herramientas` (`idHerramienta`, `numero_serie`, `nombre`, `descripcion`, `marca`, `modelo`, `estado`, `disponible`, `activo`) VALUES
	(1, 'A0001', 'prueba', 'prueba', 'prueba', 'prueba', 'Nuevo', 1, 1),
	(2, '1', '11', '', '1', '1', 'Algo desgastado', 1, 1),
	(3, '5', '1', 'Esta es una herramienta la cual cuenta con un pequ', '1', '1', 'Algo desgastado', 1, 1),
	(4, 'A0002', '1', '', '1', '1', 'Casi nuevo', 1, 1),
	(5, 'A0202', '1', '', '1', '1', 'Casi nuevo', 1, 1),
	(6, 'A0102', '1', '', '1', '1', 'Algo desgastado', 1, 1),
	(7, 'A1002', '1', 'Esta es una herramienta la cual cuenta con un peque que sirve', '1', '1', 'Casi nuevo', 1, 1),
	(8, 'A1022', '1', 'Esta es una herramienta la cual cuenta con un peque que sirve. Esta es una herramienta la cual cuenta con un peque que sirve. Esta es una herramienta ', '1', '1', 'Casi nuevo', 1, 1),
	(9, 'A5002', '1', 'Esta es una herramienta la cual cuenta con un peque que sirve, es una prueba.Esta es una herramienta la cual cuenta con un peque que sirve, es una pre', '1', '1', 'Algo desgastado', 1, 1),
	(10, 'A0006', 'eee', '', 'eee', 'eee', 'Casi nuevo', 1, 1),
	(11, 'A0022', 'eee', 'a', 'eee', 'eee', 'Casi nuevo', 1, 1),
	(12, 'a', '2', '', '2', '2', 'Bastante desgastado', 1, 1),
	(13, '2', '2', '', '2', '2', 'Algo desgastado', 1, 1),
	(14, 'i', '2', 'No posee una descripcion', '2', '2', 'Algo desgastado', 1, 1),
	(15, 'id', '2', 'dfdfdfdfdfdfdfdfddfdddfdfdfdfd455454545435533fesfsdfds siiii cin cin cin cin', '2', '2', 'Algo desgastado', 1, 1),
	(16, 'id1', '2', 'No posee una descripcion', '2', '2', 'Algo desgastado', 1, 1),
	(17, 'A1502', '1', 'ssss', '1', '1', 'Algo desgastado', 1, 1),
	(18, 'A2002', '1', 'ss', '1', '1', 'Algo desgastado', 1, 1);

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
SELECT idEmpleado,dni,apellido,nombre,cargo,telefono, activo FROM empleados WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleadosActivos
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleadosActivos`()
BEGIN
SELECT idEmpleado,dni,apellido,nombre,cargo,telefono, activo FROM empleados WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleadosInactivos
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleadosInactivos`()
BEGIN
SELECT idEmpleado,dni,apellido,nombre,cargo,telefono, activo FROM empleados WHERE activo = 0;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleadosXApellido
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleadosXApellido`(
	IN `_apellido` VARCHAR(50),
	IN `_empleadoInactivosVisibles` TINYINT
)
BEGIN
    IF _empleadoInactivosVisibles = 1 THEN
        SELECT * FROM empleados
        WHERE apellido LIKE CONCAT('%', _apellido, '%') AND activo = 0;
    ELSE
        SELECT * FROM empleados
        WHERE apellido LIKE CONCAT('%', _apellido, '%') AND activo = 1;
    END IF;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleadosXid
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleadosXid`(
	IN `_id` INT
)
BEGIN
SELECT * FROM empleados WHERE idEmpleado = _id AND activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientas
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientas`()
BEGIN
SELECT idHerramienta, numero_serie, nombre, descripcion, marca, modelo, estado, disponible FROM herramientas WHERE activo = 1;
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

-- Volcando estructura para procedimiento bd_obrador.psa_listarHerramientaXSerial
DELIMITER //
CREATE PROCEDURE `psa_listarHerramientaXSerial`(
	IN `_serial` VARCHAR(20)
)
BEGIN
	SELECT * 
	FROM herramientas
	WHERE numero_serie = _serial AND activo = 1;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;