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

-- REGISTRO COMPLETO PERSONA
-- *********************************************************************************************************************************************
DELIMITER //
CREATE PROCEDURE registrarPersonaCOMPLETO
(IN CURP CHAR(18), nombre VARCHAR(80), fechaNac DATETIME, sexoH BOOLEAN, telefono VARCHAR(20), correo VARCHAR(60), calle VARCHAR(80), examen BOOLEAN,
implante BOOLEAN, comunidad BOOLEAN, alergia BOOLEAN, enfermedad BOOLEAN, mexicano BOOLEAN, ife BOOLEAN, ID_periodo INT, ID_censo INT, ID_colonia INT,
ID_estadoCivil INT, ID_nivelEducativo INT, ID_institucionEducativa INT, anoEstudio INT, ID_lenguaDominante INT, ID_nivelEspanol INT, ID_nivelIngles INT,
ID_nivelLSM INT, descripcion_empleo VARCHAR(80), nombreCompany VARCHAR(50), correoEmpleo VARCHAR(80), telefonoEmpleo VARCHAR(20), calleEmpleo VARCHAR(80),
interpretacion_LSM BOOLEAN, ID_areaTrabajo INT, ID_sueldo INT, ID_coloniaEmpleo INT, ID_perdidaAuditiva INT, prelinguistica BOOLEAN, ID_grado INT, ID_causa INT,
ID_aparatoAuditivo INT, modelo VARCHAR(30))
BEGIN
	DECLARE IDempleo INT;
	-- DECLARE anoCenso NUMERIC;
	-- SELECT ano INTO anoCenso FROM Censo c WHERE ID_censo = c.ID_censo;
	CALL registrarPersona(CURP, nombre, fechaNac, sexoH, telefono, correo, calle, examen, implante, comunidad, alergia, 
						enfermedad, mexicano, ife, ID_periodo);
	INSERT INTO PerteneceCenso VALUES(CURP, ID_censo);
	INSERT INTO Vive VALUES(CURP, ID_colonia, ID_censo);
	INSERT INTO TieneEstadoCivil VALUES(CURP, ID_estadoCivil, ID_censo);
	INSERT INTO TieneNivelEducativo VALUES(CURP, ID_nivelEducativo, ID_censo);
	INSERT INTO Estudiado VALUES(ID_institucionEducativa, ID_nivelEducativo, CURP, anoEstudio);
	INSERT INTO TieneLenguaDominante VALUES(CURP, ID_lenguaDominante, ID_censo);
	INSERT INTO TieneNivelEspanol VALUES(CURP, ID_nivelEspanol, ID_censo);
	INSERT INTO TieneNivelIngles VALUES(CURP, ID_nivelIngles, ID_censo);
	INSERT INTO TieneNivelLSM VALUES(CURP, ID_nivelLSM, ID_censo);
	CALL registrarEmpleo(descripcion_empleo, nombreCompany, correoEmpleo, telefonoEmpleo, calleEmpleo, interpretacion_LSM, ID_areaTrabajo);
	SELECT MAX(ID_empleo) INTO IDempleo FROM Empleo;
	INSERT INTO LocalizaEmpleo VALUES(IDempleo, ID_coloniaEmpleo);
	INSERT INTO Gana VALUES(IDempleo, ID_sueldo, ID_censo);
	INSERT INTO TieneEmpleo VALUES(CURP, IDempleo, ID_censo);
	INSERT INTO TienePerdidaAuditiva VALUES(CURP, ID_perdidaAuditiva, prelinguistica, ID_censo);
	INSERT INTO EsGrado VALUES(CURP, ID_perdidaAuditiva, ID_grado, ID_censo);
	INSERT INTO Causado VALUES (CURP, ID_perdidaAuditiva, ID_causa, ID_censo);
	INSERT INTO PoseeAparatoAuditivo VALUES (CURP, ID_aparatoAuditivo, ID_censo, modelo);
END //
DELIMITER ;							

-- PERSONA
DELIMITER //
CREATE PROCEDURE registrarPersona
(IN CURP CHAR(18), nombre VARCHAR(80), fechaNac DATETIME, sexoH BOOLEAN, telefono VARCHAR(20), correo VARCHAR(60), calle VARCHAR(80), examen BOOLEAN,
implante BOOLEAN, comunidad BOOLEAN, alergia BOOLEAN, enfermedad BOOLEAN, mexicano BOOLEAN, ife BOOLEAN, ID_periodo INT)
BEGIN
	INSERT INTO Persona VALUES(CURP, nombre, fechaNac, sexoH, telefono, correo, calle, examen, implante, comunidad, alergia, 
								enfermedad, mexicano, ife, ID_periodo);
END //
DELIMITER ;	

-- EMPLEO
DELIMITER //
CREATE PROCEDURE registrarEmpleo
(IN descripcion VARCHAR(80), nombreCompany VARCHAR(50), correo VARCHAR(80), telefono VARCHAR(20), calle VARCHAR(80),
interpretacion_LSM BOOLEAN, ID_areaTrabajo INT)
BEGIN
	INSERT INTO Empleo VALUES(0,descripcion, nombreCompany, correo, telefono, calle, interpretacion_LSM, ID_areaTrabajo);
END	//
DELIMITER ;

-- HIJO
DELIMITER //
CREATE PROCEDURE registrarHijo
(IN nombre VARCHAR(80), fechaNac DATETIME, sordo BOOLEAN, CURPpadre CHAR(18))
BEGIN
	INSERT INTO Hijo(0, nombre, fechaNac, sordo, CURPpadre);
END //
DELIMITER ;	
						
-- **************************************************************************************************************************************************
-- BUSQUEDAS



-- Busqueda PERSONA
DELIMITER //
CREATE PROCEDURE busquedaEnPersona
(IN variable VARCHAR(80))
BEGIN
	SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, c.ano as Censo
	FROM Persona p, PerteneceCenso pC, Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
	TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
	TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA 
	WHERE (p.nombre LIKE variable OR p.CURP LIKE variable OR p.correo LIKE variable)
	AND p.CURP = pC.CURP AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP AND p.CURP = es.CURP
	AND P.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
	AND em.ID_empleo = tE.ID_empleo AND e.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
	AND p.CURP = pAA.CURP;
END //
DELIMITER ;


-- Busqueda INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE busquedaEnInstitucionEducativa
(IN variable VARCHAR(80))
BEGIN 
	SELECT i.nombre as Nombre, i.correo as Correo FROM Institucioneducativa i, Colonia c, Estado e, Municipio m,
	Delegacion d, Localizainstitucioneducativa loc
	WHERE i.nombre LIKE variable
	AND loc.ID_institucionEducativa = i.ID_institucionEducativa AND loc.ID_colonia = c.ID_colonia AND
	c.ID_delegacion = d.ID_delegacion AND c.ID_municipio = m.ID_municipio AND m.ID_estado = e.ID_estado;
END //
DELIMITER ;


-- Busqueda COLONIA
DELIMITER //
CREATE PROCEDURE busquedaEnColonia
(IN variable VARCHAR(80))
BEGIN
	SELECT c.nombre as Colonia, m.nombre as Municipio, e.nombre as Estado 
    FROM Colonia c, Municipio m, Estado e
	WHERE c.nombre LIKE variable
	AND c.ID_municipio = m.ID_municipio AND m.ID_estado = e.ID_estado;
END //
DELIMITER ;


-- Busqueda DELEGACION
DELIMITER //
CREATE PROCEDURE busquedaEnDelegacion
(IN variable VARCHAR(80))
BEGIN
	SELECT d.nombre as Delegacion, m.nombre as Municipio, e.nombre as Estado 
	FROM Delegacion d, Municipio m, Estado e
	WHERE d.nombre LIKE variable 
	AND m.ID_municipio = d.ID_municipio AND e.ID_estado = m.ID_estado;
END //
DELIMITER ;	

-- Busqueda MUNICIPIO
DELIMITER //
CREATE PROCEDURE busquedaEnMunicipio
(IN variable VARCHAR(80))
BEGIN
	SELECT m.nombre as Municipio, e.nombre as Estado
	FROM Municipio m, Estado e
	WHERE m.nombre LIKE variable
	AND m.ID_estado = e.ID_estado;
END //
DELIMITER ;	


-- Busqueda ESTADO
DELIMITER //
CREATE PROCEDURE busquedaEnEstado
(IN variable VARCHAR (80))
BEGIN 
	SELECT nombre as Estado FROM Estado 
	WHERE nombre LIKE variable;
END //
DELIMITER ;	


-- Busqueda APARATOAUDITIVO
DELIMITER //
CREATE PROCEDURE busquedaEnAparatoAuditivo
(IN variable VARCHAR(60))
BEGIN 
	SELECT a.tipo as Tipo, m.nombre as Marca FROM AparatoAuditivo a, Marca m
	WHERE a.tipo LIKE variable AND a.ID_marca = m.ID_marca;
END //
DELIMITER ;


-- Busqueda SUELDO
DELIMITER //
CREATE PROCEDURE busquedaEnSueldo
(IN variable VARCHAR(20))
BEGIN
	SELECT minimo as Minimo, maximo as Maximo FROM Sueldo
	WHERE minimo LIKE variable OR maximo LIKE variable;
END //
DELIMITER ;


-- Busqueda MARCA
DELIMITER // 
CREATE PROCEDURE busquedaEnMarca
(IN variable VARCHAR(40))
BEGIN
	SELECT nombre as Marca FROM Marca
	WHERE nombre LIKE variable;
END //
DELIMITER ;


-- Busqueda CENSO
DELIMITER //
CREATE PROCEDURE busquedaEnCenso
(IN variable NUMERIC(4))
BEGIN
	SELECT ano as Año FROM Censo 
	WHERE ano LIKE variable;
END //
DELIMITER ;


-- Busqueda CAUSA
DELIMITER //
CREATE PROCEDURE busquedaEnCausa
(IN variable VARCHAR(50))
BEGIN
	SELECT causa as Causa
	FROM Causa 
	WHERE causa LIKE variable;
END //
DELIMITER ;

-- Busqueda AREA TRABAJO
DELIMITER //
CREATE PROCEDURE busquedaEnAreaTrabajo
(IN variable VARCHAR(60))
BEGIN
	SELECT nombre as AreaTrabajo 
	FROM AreaTrabajo
	WHERE nombre LIKE variable;
END //
DELIMITER ;	

-- Busqueda USUARIO
DELIMITER //
CREATE PROCEDURE busquedaEnUsuario
(IN variable VARCHAR(30))
BEGIN
	SELECT login as Login 
	FROM Usuario 
	WHERE login LIKE variable;
END //
DELIMITER ;	
-- ****************************************************************************************************************8
-- -------------------------------PENDIENTES : Persona - InstitucionEducativa


