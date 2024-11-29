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

-- Volcando estructura para procedimiento bd_obrador.actualizar_estado_herramienta
DELIMITER //
CREATE PROCEDURE `actualizar_estado_herramienta`(
	IN `_id_herramienta` INT
)
BEGIN
   UPDATE herramientas SET prestamo_activo = 1 WHERE idHerramienta = _id_herramienta;
END//
DELIMITER ;

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
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.asignaciones: ~1 rows (aproximadamente)
INSERT INTO `asignaciones` (`idAsignacion`, `id_herramienta`, `id_empleado`, `fechaAsignacion`, `fechaDevolucion`, `activo`) VALUES
	(30, 26, 2, '2024-11-15', '2024-11-16', 1),
	(31, 28, 2, '2024-11-15', '2024-11-16', 1);

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
	IN `_tipo_movimiento` VARCHAR(50),
	IN `_cantidad` VARCHAR(50)
)
BEGIN
    INSERT INTO prestamos(idPrestamo, id_herramienta, id_empleado, fecha, tipo_movimiento, cantidad, activo)
    VALUES (_id, _id_herramientas, _id_empleado, _fecha, _tipo_movimiento, _cantidad, TRUE);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_listadoAsignacionesCano
DELIMITER //
CREATE PROCEDURE `asp_listadoAsignacionesCano`()
BEGIN
SELECT a.idAsignacion,h.nombre AS Nombre,e.apellido,e.nombre, a.fechaAsignacion AS Asignacion,a.fechaDevolucion
FROM herramientas AS h INNER JOIN asignaciones AS a ON h.idHerramienta = a.id_herramienta
INNER JOIN empleados AS e ON a.id_empleado = e.IdEmpleado;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_obrador.asp_listarHerramientasPrestamoActivo
DELIMITER //
CREATE PROCEDURE `asp_listarHerramientasPrestamoActivo`(
	IN `_id_empleado` INT
)
BEGIN
    SELECT 
        a.idAsignacion,
        h.idHerramienta,
        a.id_empleado,
        a.fechaAsignacion,
        a.fechaDevolucion,
        h.prestamo_activo
    FROM 
        herramientas AS h
    INNER JOIN 
        asignaciones AS a ON h.idHerramienta = a.id_herramienta
    WHERE 
        a.id_empleado = _id_empleado;
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
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.empleados: ~36 rows (aproximadamente)
INSERT INTO `empleados` (`IdEmpleado`, `dni`, `apellido`, `nombre`, `cargo`, `telefono`, `activo`) VALUES
	(2, '46666269', 'Romero Alvarez', 'Cintia', 'Empleada', '38157328', 1),
	(3, '50493264', 'Alvarez Romero', 'Pancracio', 'Empleado', '3838383834', 1),
	(7, '1', 'ApellidoPrueba', 'NombrePrueba', '-', '123456789', 1),
	(13, '29436853', 'Cano', 'Marcelo', 'Docente', '333-444', 1),
	(29, '46666266', 'Romero Alvarez', 'Cinthia', 'Gerente', '38157328', 1),
	(39, '46432323', 'Alvarez Romero', 'Csharp', 'Crack', '333333', 1),
	(51, '15654345', 'Gomez', 'Juan', 'Gerente', '3814567890', 1),
	(52, '23456789', 'Perez', 'Ana', 'Asistente', '3811234567', 1),
	(53, '19876543', 'Lopez', 'Carlos', 'Supervisor', '3819876543', 0),
	(54, '14567892', 'Martinez', 'Laura', 'Contador', '3813456789', 1),
	(55, '22334455', 'Fernandez', 'Lucia', 'Analista', '3816789123', 1),
	(56, '19023456', 'Diaz', 'Miguel', 'Ingeniero', '3814321567', 1),
	(57, '21098765', 'Sanchez', 'Maria', 'Secretaria', '3818765432', 0),
	(58, '17654321', 'Ramirez', 'Jorge', 'Técnico', '3819871234', 1),
	(59, '14253647', 'Gonzalez', 'Sofia', 'Diseñador', '3813216547', 1),
	(60, '19998877', 'Alvarez', 'Luciano', 'Administrador', '3817654321', 1),
	(61, '18334455', 'Silva', 'Valeria', 'Coordinador', '3815467890', 0),
	(62, '16458765', 'Ortiz', 'Daniel', 'Gerente', '3816547890', 1),
	(63, '14443210', 'Mendoza', 'Andrea', 'Asistente', '3819875467', 1),
	(64, '23234567', 'Rojas', 'Pablo', 'Supervisor', '3811237654', 0),
	(65, '18876543', 'Herrera', 'Clara', 'Contador', '3818765123', 1),
	(66, '15098765', 'Ibarra', 'Federico', 'Analista', '3814561234', 1),
	(67, '19334455', 'Arias', 'Noelia', 'Ingeniera', '3815432167', 1),
	(68, '18123654', 'Morales', 'Julian', 'Técnico', '3816783214', 0),
	(69, '16754321', 'Cabrera', 'Samantha', 'Diseñadora', '3817894321', 1),
	(70, '14098765', 'Paz', 'Diego', 'Administrador', '3814329876', 1),
	(71, '22234455', 'Torres', 'Agustina', 'Coordinadora', '3811238907', 1),
	(72, '19876532', 'Vera', 'Emiliano', 'Gerente', '3816541230', 0),
	(73, '17654322', 'Ruiz', 'Milena', 'Asistente', '3818761239', 1),
	(74, '14443211', 'Figueroa', 'Sebastian', 'Supervisor', '3815469872', 1),
	(75, '22298765', 'Correa', 'Valentina', 'Contadora', '3813210987', 1),
	(76, '19034567', 'Navarro', 'Bruno', 'Analista', '3811234568', 0),
	(77, '18343210', 'Ponce', 'Delfina', 'Ingeniera', '3818765433', 1),
	(78, '16723456', 'Castro', 'Ignacio', 'Técnico', '3814321987', 1),
	(79, '15598765', 'Peralta', 'Florencia', 'Diseñadora', '3819876542', 1),
	(80, '14237654', 'Villalba', 'Lucas', 'Administrador', '3815432178', 1);

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
  `prestamo_activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idHerramienta`),
  UNIQUE KEY `numero_serie` (`numero_serie`)
) ENGINE=InnoDB AUTO_INCREMENT=191 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.herramientas: ~33 rows (aproximadamente)
INSERT INTO `herramientas` (`idHerramienta`, `numero_serie`, `nombre`, `descripcion`, `marca`, `modelo`, `estado`, `disponible`, `activo`, `prestamo_activo`) VALUES
	(26, 'A0001', 'Taladro', 'Pequeno dano en la carcasa pero funciona bien', 'Bosch', 'ModelX', 'Nuevo', 0, 1, 1),
	(27, 'B1234', 'Martillo', 'Cabeza algo desgastada pero funcional', 'Stanley', 'HammerPro', 'Casi Nuevo', 1, 1, 0),
	(28, 'C5678', 'Sierra', 'Hoja en buen estado, mango con desgaste', 'Makita', 'SawMax', 'Algo desgastado', 0, 1, 1),
	(29, 'D4321', 'Llave Inglesa', 'Tiene oxido leve pero usable', 'DeWalt', 'WrenchMaster', 'Bastante desgastado', 1, 0, 0),
	(30, 'E9876', 'Destornillador', 'Funciona correctamente, punta desgastada', 'BlackDecker', 'ScrewX', 'Casi Nuevo', 1, 1, 0),
	(31, 'F6543', 'Nivel', 'Vidrio con rayones, pero funciona bien', 'Bosch', 'LevelPro', 'Nuevo', 1, 1, 0),
	(32, 'G8765', 'Pala', 'Mango un poco desgastado', 'Truper', 'ShovelPlus', 'Algo desgastado', 1, 1, 0),
	(33, 'H3456', 'Cincel', 'Perfecto estado', 'Stanley', 'ChiselX', 'Nuevo', 1, 1, 0),
	(34, 'I7890', 'Metro', 'Cinta algo desgastada pero funcional', 'DeWalt', 'TapeMax', 'Casi Nuevo', 1, 1, 0),
	(35, 'J1235', 'Alicate', 'Oxido leve en articulaciones', 'Makita', 'PliersPro', 'Algo desgastado', 1, 0, 0),
	(36, 'K5432', 'Llave de tubo', 'Funcionando correctamente', 'Bosch', 'TubeWrench', 'Nuevo', 1, 1, 0),
	(37, 'L6789', 'Escofina', 'Mango en buen estado, desgaste leve en hoja', 'BlackDecker', 'RaspFile', 'Casi Nuevo', 1, 1, 0),
	(38, 'M4567', 'Pinza', 'Articulacion en buen estado', 'Stanley', 'GripPlus', 'Nuevo', 1, 1, 0),
	(39, 'N9871', 'Cortadora', 'Hoja nueva, motor ruidoso', 'Makita', 'CutterMax', 'Algo desgastado', 1, 1, 0),
	(40, 'O7654', 'Amoladora', 'Perfecto estado', 'DeWalt', 'GrindPro', 'Nuevo', 1, 1, 0),
	(41, 'P2345', 'Llave fija', 'Tiene oxido superficial', 'Bosch', 'FixedWrench', 'Algo desgastado', 1, 0, 0),
	(42, 'Q3451', 'Compresor', 'Motor reparado recientemente', 'BlackDecker', 'AirPro', 'Casi Nuevo', 1, 1, 0),
	(43, 'R5678', 'Lijadora', 'Base de soporte desgastada', 'Stanley', 'SandMax', 'Bastante desgastado', 1, 0, 0),
	(44, 'S4322', 'Escalera', 'Pintura desgastada pero estable', 'Truper', 'LadderPro', 'Algo desgastado', 1, 1, 0),
	(45, 'T8763', 'Taladro Percutor', 'Funcionando correctamente', 'Bosch', 'ImpactDrill', 'Nuevo', 1, 1, 0),
	(46, 'U1236', 'Pistola de calor', 'Revisada y funcional', 'Makita', 'HeatGun', 'Casi Nuevo', 1, 1, 0),
	(47, 'V6547', 'Engrampadora', 'Muelle interno reemplazado', 'DeWalt', 'StaplerMax', 'Algo desgastado', 1, 1, 0),
	(48, 'W9870', 'Remachadora', 'Pequenos rayones', 'Stanley', 'RivetTool', 'Nuevo', 1, 1, 0),
	(49, 'X3452', 'Llave Allen', 'Perfecto estado', 'Truper', 'HexKeySet', 'Nuevo', 1, 1, 0),
	(50, 'Y7658', 'Prensa', 'Funcionando perfectamente', 'Bosch', 'ClampPro', 'Nuevo', 1, 1, 0),
	(51, 'Z1237', 'Cepillo', 'Hoja nueva, mango desgastado', 'Makita', 'PlaneTool', 'Algo desgastado', 1, 0, 0),
	(52, 'A9872', 'Martillo de goma', 'Pequenos detalles esteticos', 'Stanley', 'RubberHammer', 'Casi Nuevo', 1, 1, 0),
	(53, 'B4568', 'Soplete', 'Perfecto estado', 'BlackDecker', 'TorchPro', 'Nuevo', 1, 1, 0),
	(54, 'C6784', 'Carretilla', 'Oxido leve pero funcional', 'Truper', 'WheelBarrow', 'Algo desgastado', 1, 1, 0),
	(55, 'D2349', 'Caladora', 'Funcionando correctamente', 'Bosch', 'JigsawX', 'Casi Nuevo', 1, 1, 0),
	(56, 'E7653', 'Motosierra', 'Cadena nueva, motor desgastado', 'Makita', 'ChainSaw', 'Bastante desgastado', 1, 0, 0),
	(57, 'F8764', 'Taladro Inalambrico', 'Perfecto estado', 'DeWalt', 'DrillCordless', 'Nuevo', 1, 1, 0),
	(58, 'G1238', 'Multimetro', 'Display con rayones', 'Stanley', 'MultiPro', 'Algo desgastado', 1, 1, 0);

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
  UNIQUE KEY `id_herramienta` (`id_herramienta`),
  KEY `FK_empleado` (`id_empleado`),
  CONSTRAINT `FK_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_herramienta` FOREIGN KEY (`id_herramienta`) REFERENCES `herramientas` (`idHerramienta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla bd_obrador.prestamos: ~0 rows (aproximadamente)
INSERT INTO `prestamos` (`idPrestamo`, `id_herramienta`, `id_empleado`, `fecha`, `tipo_movimiento`, `cantidad`, `activo`) VALUES
	(48, 26, 2, '2024-11-15', 'Salida', 1, 1),
	(49, 28, 2, '2024-11-15', 'Mantenimiento', 1, 1);

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

-- Volcando estructura para procedimiento bd_obrador.psa_listadoPrestamos
DELIMITER //
CREATE PROCEDURE `psa_listadoPrestamos`()
BEGIN
	SELECT * FROM prestamos;
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

-- Volcando estructura para procedimiento bd_obrador.psa_verificar_herramienta_prestada
DELIMITER //
CREATE PROCEDURE `psa_verificar_herramienta_prestada`(
	IN `_id_herramienta` INT
)
BEGIN
	SELECT COUNT(*) FROM prestamos WHERE id_herramienta = _id_herramienta;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
