-- ************************************************
-- STORED PROCEDURES
-- ************************************************
--

-- NUEVOS REGISTROS ******************************************************************************************************

-- CAUSA
DELIMITER //
CREATE PROCEDURE registrarCausa
(IN nombreCausa CHAR(50))
BEGIN
	INSERT INTO Causa VALUES (0, nombreCausa);
END //


-- COLONIA
CREATE PROCEDURE registrarColonia
(IN nombreColonia CHAR(50), ID_delegacion INT, ID_municipio INT)
BEGIN
	INSERT INTO Colonia VALUES (0, nombreColonia, ID_delegacion, ID_municipio);
END //
DELIMITER ;

-- DELEGACION
CREATE PROCEDURE registrarDelegacion
(IN nombreDelegacion CHAR (80), ID_municipio INT)
BEGIN
	INSERT INTO Delegacion VALUES (0, nombreDelegacion, ID_municipio)
END //
DELIMITER ;

-- MUNICIPIO 
CREATE PROCEDURE registrarMunicipio
(IN nombreMunicipio CHAR(70), ID_estado INT)
BEGIN
	INSERT INTO Municipio VALUES (0, nombreMunicipio, ID_estado)
END //
DELIMITER ;

-- ESTADO 
CREATE PROCEDURE registrarEstado
(IN nombreEstado CHAR(70))
BEGIN
	INSERT INTO Estado VALUES(0, nombreEstado)
END //
DELIMITER ;

-- CENSO
CREATE PROCEDURE registrarCenso(IN anoCenso INT)
BEGIN
	INSERT INTO Censo VALUES (0, anoCenso)
END //
DELIMITER ;

-- APARATOAUDITIVO
CREATE PROCEDURE registrarAparatoAuditivo
(IN tipo CHAR(70), ID_marca INT)
BEGIN
	INSERT INTO AparatoAuditivo VALUES(0, tipo, ID_marca)
END //
DELIMITER ;

-- MARCA
CREATE PROCEDURE registrarMarca
(IN nombreMarca CHAR(40))
BEGIN
	INSERT INTO Marca VALUES (0, nombreMarca)
END //
DELIMITER ;

-- SUELDO
CREATE PROCEDURE registrarSueldo
(IN minimo CHAR(20), maximo CHAR(20))
BEGIN
	INSERT INTO Sueldo VALUES (0, minimo, maximo)
END //
DELIMITER ;

-- AREATRABAJO
CREATE PROCEDURE registrarAreaTrabajo
(IN nombreArea varchar(60))
BEGIN
	INSERT INTO AreaTrabajo VALUES (0, nombreArea)
END //
DELIMITER ;

-- INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE registrarInstitucionEducativa
(IN nombre VARCHAR(90), calle VARCHAR(80), telefono VARCHAR(20), correo VARCHAR(80), privada BOOLEAN, especializada BOOLEAN, ID_colonia INT)
BEGIN
    DECLARE ID INT;
	INSERT INTO InstitucionEducativa VALUES(0, nombre, calle, telefono, correo, privada, especializada);	
    SELECT @@IDENTITY as ID_Institucion;
    SELECT MAX(ID_InstitucionEducativa) INTO ID FROM InstitucionEducativa;
    INSERT INTO LocalizaInstitucionEducativa VALUES(ID, ID_colonia);
END //
DELIMITER ;


-- Busqueda INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE busquedaEnInstitucionEducativa
(IN variable VARCHAR(80))
BEGIN 
	SELECT nombre, correo FROM institucioneducativa
	WHERE nombre LIKE variable OR correo LIKE variable
    OR telefono LIKE variable;
END //
DELIMITER ;

-- ****************************************************************************************************************8
-- -------------------------------PENDIENTES : Persona - InstitucionEducativa


