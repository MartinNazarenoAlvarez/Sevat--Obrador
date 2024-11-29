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
  `idAsignacion` int(11) NOT NULL AUTO_INCREMENT,
  `id_herramienta` int(11) DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `fechaAsignacion` date DEFAULT NULL,
  `fechaDevolucion` date DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idAsignacion`),
  KEY `FK_empleado2` (`id_empleado`),
  KEY `id_herramienta` (`id_herramienta`),
  CONSTRAINT `FK_empleado2` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_herramienta2` FOREIGN KEY (`id_herramienta`) REFERENCES `herramientas` (`idHerramienta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.asignaciones: ~16 rows (aproximadamente)
INSERT INTO `asignaciones` (`idAsignacion`, `id_herramienta`, `id_empleado`, `fechaAsignacion`, `fechaDevolucion`, `activo`) VALUES
	(2, 16, 13, '2024-10-01', '2024-10-05', 1),
	(3, 8, 7, '2024-11-01', '2024-11-29', 1),
	(6, 14, 29, '2024-11-01', '2024-11-02', 1),
	(10, 11, 13, '2024-11-29', '2024-11-30', 1),
	(11, 15, 7, '2024-11-01', '0001-01-01', 1),
	(13, 9, 7, '2024-11-01', '2024-11-02', 1),
	(16, 8, 7, '2024-11-01', '2024-11-02', 1),
	(17, 16, 39, '2024-11-01', '2024-11-30', 1),
	(19, 7, 3, '2024-11-01', '2024-11-02', 1),
	(20, 2, 3, '2024-11-01', '2024-11-02', 1),
	(22, 22, 3, '2024-11-01', '2024-11-02', 1),
	(25, 23, 2, '2024-11-01', '2024-11-10', 0),
	(26, 23, 2, '2024-11-01', '2024-11-02', 0),
	(27, 23, 2, '2024-11-10', '2024-11-11', 1),
	(28, 24, 2, '2024-11-10', '2024-11-11', 1),
	(29, 1, 2, '2024-11-10', '2024-11-11', 1);

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

-- Volcando estructura para procedimiento bd_obrador.asp_actualizarHerramienta
DELIMITER //
CREATE PROCEDURE `asp_actualizarHerramienta`(
	IN `_numeroS_original` VARCHAR(50),
	IN `_serial` VARCHAR(50),
	IN `_nombre` VARCHAR(50),
	IN `_descripcion` VARCHAR(150),
	IN `_marca` VARCHAR(50),
	IN `_modelo` VARCHAR(50),
	IN `_estado` VARCHAR(50),
	IN `_activo` TINYINT
)
BEGIN
    UPDATE herramientas
    SET 
	   	numero_serie = _serial,
			nombre = _nombre,
			descripcion = _descripcion,
			marca = _marca,
			modelo = _modelo,
			estado = _estado,
			activo = _activo
    WHERE numero_serie = _numeroS_original;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_actualizar_asignacion
DELIMITER //
CREATE PROCEDURE `asp_actualizar_asignacion`(
	IN `_id_herramienta` INT,
	IN `_id_empleado` INT,
	IN `_fechaAsignacion` DATETIME,
	IN `_fechaDevolucion` DATETIME,
	IN `_id_asignacion` INT,
	IN `_activo` TINYINT
)
BEGIN
    UPDATE asignaciones
    SET 
        id_herramienta = _id_herramienta,
        id_empleado = _id_empleado,
        fechaAsignacion = _fechaAsignacion,
        fechaDevolucion = _fechaDevolucion,
        activo = _activo
    WHERE idAsignacion = _id_asignacion;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_actualizar_estado_herramienta
DELIMITER //
CREATE PROCEDURE `asp_actualizar_estado_herramienta`(
	IN `_disponible` TINYINT,
	IN `_id_herramienta` INT
)
BEGIN
    UPDATE herramientas
    SET disponible = _disponible
    WHERE idHerramienta = _id_herramienta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_buscarAsignacionId
DELIMITER //
CREATE PROCEDURE `asp_buscarAsignacionId`(
	IN `_id_empleado` INT
)
BEGIN
	SELECT * FROM asignaciones WHERE id_empleado = _id_empleado;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_buscarAsignacionPorFechas
DELIMITER //
CREATE PROCEDURE `asp_buscarAsignacionPorFechas`(
	IN `_fechaDesde` DATETIME,
	IN `_fechaHasta` DATETIME
)
BEGIN
	SELECT * 
   FROM Asignaciones
   WHERE fechaAsignacion BETWEEN _fechaDesde AND _fechaHasta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_buscarAsignacionPorIdYFechas
DELIMITER //
CREATE PROCEDURE `asp_buscarAsignacionPorIdYFechas`(
	IN `_id_empleado` INT,
	IN `_fechaDesde` DATETIME,
	IN `_fechaHasta` DATETIME
)
BEGIN
	SELECT * 
   FROM Asignaciones
    WHERE id_empleado = _id_empleado AND fechaAsignacion BETWEEN _fechaDesde AND _fechaHasta
    ORDER BY fechaAsignacion;
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

-- Volcando estructura para procedimiento bd_obrador.asp_eliminarHerramienta
DELIMITER //
CREATE PROCEDURE `asp_eliminarHerramienta`(
	IN `_serial` VARCHAR(50)
)
BEGIN
	DELETE FROM herramientas WHERE numero_serie = _serial;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_eliminar_asignacion
DELIMITER //
CREATE PROCEDURE `asp_eliminar_asignacion`(
	IN `_idAsignacion` INT,
	IN `_id_herramienta` INT
)
BEGIN
	DELETE FROM asignaciones WHERE idAsignacion = _idAsignacion;
	UPDATE herramientas
	SET disponible = 1
   WHERE idHerramienta = _id_herramienta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_guardar_asignacion
DELIMITER //
CREATE PROCEDURE `asp_guardar_asignacion`(
	IN `_id_herramienta` INT,
	IN `_id_empleado` INT,
	IN `_fechaAsignacion` DATETIME,
	IN `_fechaDevolucion` DATETIME
)
BEGIN
	INSERT INTO asignaciones(id_herramienta, id_empleado, fechaAsignacion, fechaDevolucion, activo)
	VALUES (_id_herramienta, _id_empleado, _fechaAsignacion, _fechaDevolucion, TRUE);
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

-- Volcando estructura para procedimiento bd_obrador.asp_guardar_prestamo
DELIMITER //
CREATE PROCEDURE `asp_guardar_prestamo`(
	IN `_id` INT,
	IN `_id_herramientas` INT,
	IN `_id_empleado` INT,
	IN `_fecha` DATETIME,
	IN `_tipo_movimiento` INT,
	IN `_cantidad` VARCHAR(50)
)
BEGIN
    INSERT INTO prestamos(idPrestamo, id_herramienta, id_empleado, fecha, tipo_movimiento, cantidad, activo)
    VALUES (_id, _id_herramientas, _id_empleado, _fecha, _tipo_movimiento, _cantidad, TRUE)
    ON DUPLICATE KEY UPDATE
        fecha = VALUES(fecha),
        tipo_movimiento = VALUES(tipo_movimiento),
        cantidad = VALUES(cantidad),
        activo = VALUES(activo);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_REVISARLUEGO
DELIMITER //
CREATE PROCEDURE `asp_REVISARLUEGO`()
BEGIN
SELECT a.idAsignacion,h.nombre AS Nombre,e.apellido,e.nombre, a.fechaAsignacion AS Asignacion,a.fechaDevolucion
FROM herramientas AS h INNER JOIN asignaciones AS a ON h.idHerramienta = a.id_herramienta
INNER JOIN empleados AS e ON a.id_empleado = e.IdEmpleado;
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

-- Volcando estructura para procedimiento bd_obrador.asp_totalHerramientas
DELIMITER //
CREATE PROCEDURE `asp_totalHerramientas`()
BEGIN
    SELECT 
        COUNT(CASE WHEN activo = 0 THEN 1 END) AS TotalInactivos,
        COUNT(CASE WHEN activo = 1 THEN 1 END) AS TotalActivos
    FROM herramientas;
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
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.empleados: ~12 rows (aproximadamente)
INSERT INTO `empleados` (`IdEmpleado`, `dni`, `apellido`, `nombre`, `cargo`, `telefono`, `activo`) VALUES
	(2, '46666269', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1),
	(3, '50493264', 'Alvarez Romero', 'Pancracio', 'No se', '3838383834', 1),
	(4, '12345678', 'ApellidoPrueba', 'NombrePrueba', 'Carg1', '123456789', 1),
	(7, '1', 'ApellidoPrueba', 'NombrePrueba', 'd', '123456789', 1),
	(13, '29436853', 'Cano', 'Marcelo', 'Docente', '333-444', 1),
	(29, '46666266', 'Romero Alvarez', 'Cintia', 'No se', '38157328', 1),
	(39, '46432323', 'Alvarez Romero', 'Csharp', 'Crack', '333333', 1),
	(42, '555', '2', '2', '34', '2', 0),
	(44, '3232', '3232', '23232', '3232', '3232', 1),
	(46, '554', 'Alvarez', '343', '54', '54', 1),
	(47, '5547', 'Alvarez', '343', '54', '54', 0),
	(49, '2323232', 'alva', 'naza', 'crack', '3333333333', 1);

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
  PRIMARY KEY (`idHerramienta`),
  UNIQUE KEY `numero_serie` (`numero_serie`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.herramientas: ~19 rows (aproximadamente)
INSERT INTO `herramientas` (`idHerramienta`, `numero_serie`, `nombre`, `descripcion`, `marca`, `modelo`, `estado`, `disponible`, `activo`) VALUES
	(1, 'A0001', 'prueba', 'prueba', 'prueba', 'prueba', 'Nuevo', 0, 1),
	(2, '1', '11', '', '1', '1', 'Algo desgastado', 0, 1),
	(3, '5', '1', 'Esta es una herramienta la cual cuenta con un pequ', '1', '1', 'Algo desgastado', 1, 0),
	(4, 'A0002', '1', '', '1', '1', 'Casi nuevo', 1, 0),
	(5, 'A0202', '1', '', '1', '1', 'Casi nuevo', 1, 0),
	(7, 'A1002', '1', 'Esta es una herramienta la cual cuenta con un peque que sirve', '1', '1', 'Casi nuevo', 0, 1),
	(8, 'A1022', '1', 'Esta es una herramienta la cual cuenta con un peque que sirve. Esta es una herramienta la cual cuenta con un peque que sirve. Esta es una herramienta ', '1', '1', 'Casi nuevo', 0, 1),
	(9, '06', '0', '0000 es una herramienta la cual cuenta con un peque que sirve, es una prueba.Esta es una herramienta la cual cuenta con un peque que sirve, 0000000000', '0', '0', 'Nuevo', 0, 1),
	(10, 'A0006', 'eee', '', 'eee', 'eee', 'Casi nuevo', 1, 0),
	(11, 'A0022', 'eee', 'a', 'eee', 'eee', 'Casi nuevo', 0, 1),
	(12, 'a', '2', '', '2', '2', 'Bastante desgastado', 1, 0),
	(13, '2', '2', '', '2', '2', 'Algo desgastado', 1, 0),
	(14, 'i', '2', 'No posee una descripcion', '2', '2', 'Algo desgastado', 0, 1),
	(15, 'id', '2', 'dfdfdfdfdfdfdfdfddfdddfdfdfdfd455454545435533fesfsdfds siiii cin cin cin cin', '2', '2', 'Algo desgastado', 0, 1),
	(16, 'id1', '2', 'No posee una descripcion', '2', '2', 'Algo desgastado', 0, 1),
	(20, 'A0005', 'si', 'No posee una descripcion.', 'si', 'si', 'Nuevo', 0, 1),
	(22, '3', '2', 'No posee una descripcion.', '2', '2', 'Casi nuevo', 0, 1),
	(23, '1111', '2', 'No posee una descripcion.', '2', '2', 'Casi nuevo', 0, 1),
	(24, '111', '111', 'No posee una descripcion.', '111', '1', 'Casi nuevo', 0, 1);

-- Volcando estructura para tabla bd_obrador.prestamos
CREATE TABLE IF NOT EXISTS `prestamos` (
  `idPrestamo` int(11) NOT NULL AUTO_INCREMENT,
  `id_herramienta` int(11) NOT NULL DEFAULT 0,
  `id_empleado` int(11) NOT NULL DEFAULT 0,
  `fecha` date DEFAULT NULL,
  `tipo_movimiento` varchar(20) DEFAULT '0',
  `cantidad` varchar(50) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idPrestamo`),
  UNIQUE KEY `id_empleado` (`id_empleado`),
  UNIQUE KEY `id_herramienta` (`id_herramienta`),
  CONSTRAINT `FK_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_herramienta` FOREIGN KEY (`id_herramienta`) REFERENCES `herramientas` (`idHerramienta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.prestamos: ~3 rows (aproximadamente)
INSERT INTO `prestamos` (`idPrestamo`, `id_herramienta`, `id_empleado`, `fecha`, `tipo_movimiento`, `cantidad`, `activo`) VALUES
	(5, 14, 29, '2024-11-13', '0', '0', 1),
	(8, 8, 7, '2024-11-13', '0', '0', 1),
	(13, 16, 13, '2024-11-13', '0', '0', 1);

-- Volcando estructura para procedimiento bd_obrador.psa_buscarHerramientaXid
DELIMITER //
CREATE PROCEDURE `psa_buscarHerramientaXid`(
	IN `_id` INT
)
BEGIN
	SELECT * FROM herramientas
	WHERE idHerramienta = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoAsignaciones
DELIMITER //
CREATE PROCEDURE `psa_listadoAsignaciones`()
BEGIN
	SELECT * FROM asignaciones WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoAsignacionesInactivas
DELIMITER //
CREATE PROCEDURE `psa_listadoAsignacionesInactivas`()
BEGIN
	SELECT * FROM asignaciones WHERE activo = 0;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleados
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleados`()
BEGIN
SELECT * FROM empleados WHERE activo = 1;
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
SELECT * FROM empleados WHERE idEmpleado = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoEmpleadosXidInactivo
DELIMITER //
CREATE PROCEDURE `psa_listadoEmpleadosXidInactivo`(
	IN `_id` INT
)
BEGIN
	SELECT * FROM empleados WHERE idEmpleado = _id AND activo = 0;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientas
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientas`()
BEGIN
	SELECT * FROM herramientas WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientasActivas
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientasActivas`()
BEGIN
	SELECT * FROM herramientas WHERE activo = 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientasDisponibles
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientasDisponibles`()
BEGIN
	SELECT * FROM herramientas WHERE disponible = 1 AND activo = 1; 
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientasDisponiblesXEmpleado
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientasDisponiblesXEmpleado`(
	IN `_id` INT
)
BEGIN
	SELECT * FROM asignaciones WHERE id_empleado = _id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientasInactivas
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientasInactivas`()
BEGIN
	SELECT * FROM herramientas WHERE activo = 0;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listadoHerramientasXMarca
DELIMITER //
CREATE PROCEDURE `psa_listadoHerramientasXMarca`(
	IN `_marca` VARCHAR(50),
	IN `_herramientaActivasVisibles` TINYINT
)
BEGIN
    IF _herramientaActivasVisibles = 1 THEN
        SELECT *
        FROM herramientas
        WHERE marca = _marca AND activo = 0;
    ELSE
        SELECT *
        FROM herramientas
        WHERE marca = _marca AND activo = 1;
    END IF;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_ListarEmpleadoxdni
DELIMITER //
CREATE PROCEDURE `psa_ListarEmpleadoxdni`(
	IN `_dni` VARCHAR(10)
)
BEGIN
SELECT * FROM empleados WHERE dni = _dni;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_ListarEmpleadoxdniInactivos
DELIMITER //
CREATE PROCEDURE `psa_ListarEmpleadoxdniInactivos`(
	IN `_dni` VARCHAR(50)
)
BEGIN
SELECT * FROM empleados WHERE dni = _dni and activo = 0;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.psa_listarHerramientaXSerial
DELIMITER //
CREATE PROCEDURE `psa_listarHerramientaXSerial`(
	IN `_serial` VARCHAR(20)
)
BEGIN
SELECT * FROM herramientas WHERE numero_serie = _serial;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
