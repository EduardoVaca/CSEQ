-- ************************************************
-- STORED PROCEDURES
-- ************************************************
--
-- VIEW PARA LLENAR COMBO BOX DE APARATO
CREATE VIEW AparatoConMarca AS SELECT ID_aparatoAuditivo, CONCAT(tipo, ' - ', m.nombre) as 
'Contenido' FROM AparatoAuditivo a, Marca m WHERE a.ID_marca = m.ID_marca;

-- NUEVOS REGISTROS ******************************************************************************************************

-- CAUSA
DELIMITER //
CREATE PROCEDURE registrarCausa
(IN nombreCausa CHAR(50))
BEGIN
	START TRANSACTION;
		INSERT INTO Causa VALUES (0, nombreCausa);
    COMMIT;
END //
DELIMITER ;


-- COLONIA
DELIMITER //
CREATE PROCEDURE registrarColonia
(IN nombreColonia CHAR(50), ID_municipio INT, delegacion VARCHAR(80))
BEGIN
	START TRANSACTION;
		INSERT INTO Colonia VALUES (0, nombreColonia, ID_municipio, delegacion);
	COMMIT;
END //
DELIMITER ;

-- MUNICIPIO 
DELIMITER //
CREATE PROCEDURE registrarMunicipio
(IN nombreMunicipio CHAR(70), ID_estado INT)
BEGIN
	START TRANSACTION;
		INSERT INTO Municipio VALUES (0, nombreMunicipio, ID_estado);
	COMMIT;
END //
DELIMITER ;

-- ESTADO 
DELIMITER //
CREATE PROCEDURE registrarEstado
(IN nombreEstado CHAR(70))
BEGIN
	START TRANSACTION;
		INSERT INTO Estado VALUES(0, nombreEstado);
	COMMIT;
END //
DELIMITER ;

-- CENSO
DELIMITER //
CREATE PROCEDURE registrarCenso(IN ID_censo NUMERIC(4))
BEGIN
	START TRANSACTION;
		INSERT INTO Censo VALUES (ID_censo);
	COMMIT;
END //
DELIMITER ;

-- APARATOAUDITIVO
DELIMITER //
CREATE PROCEDURE registrarAparatoAuditivo
(IN tipo CHAR(70), ID_marca INT)
BEGIN
	START TRANSACTION;
		INSERT INTO AparatoAuditivo VALUES(0, tipo, ID_marca);
	COMMIT;
END //
DELIMITER ;

-- MARCA
DELIMITER //
CREATE PROCEDURE registrarMarca
(IN nombreMarca CHAR(40))
BEGIN
	START TRANSACTION;
		INSERT INTO Marca VALUES (0, nombreMarca);
	COMMIT;
END //
DELIMITER ;

-- SUELDO
DELIMITER //
CREATE PROCEDURE registrarSueldo
(IN minimo CHAR(20), maximo CHAR(20))
BEGIN
	START TRANSACTION;
		INSERT INTO Sueldo VALUES (0, minimo, maximo);
	COMMIT;
END //
DELIMITER ;

-- AREATRABAJO
DELIMITER //
CREATE PROCEDURE registrarAreaTrabajo
(IN nombreArea varchar(60))
BEGIN
	START TRANSACTION;
		INSERT INTO AreaTrabajo VALUES (0, nombreArea);
	COMMIT;
END //
DELIMITER ;

-- INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE registrarInstitucionEducativa
(IN nombre VARCHAR(90), calle VARCHAR(80), telefono VARCHAR(20), correo VARCHAR(80), privada BOOLEAN, especializada BOOLEAN, ID_colonia INT)
BEGIN
	DECLARE ID INT;
	START TRANSACTION;
		INSERT INTO InstitucionEducativa VALUES(0, nombre, calle, telefono, correo, privada, especializada);	
	    SELECT @@IDENTITY as ID_Institucion;
	    SELECT MAX(ID_InstitucionEducativa) INTO ID FROM InstitucionEducativa;
	    INSERT INTO LocalizaInstitucionEducativa VALUES(ID, ID_colonia);
	COMMIT;
END //
DELIMITER ;

-- REGISTRO COMPLETO PERSONA
-- *********************************************************************************************************************************************
DELIMITER //
CREATE PROCEDURE registrarPersonaCOMPLETO
(IN CURP CHAR(18), nombre VARCHAR(80), fechaNac DATETIME, sexoH BOOLEAN, telefono VARCHAR(20), correo VARCHAR(60), calle VARCHAR(80), examen BOOLEAN,
implante BOOLEAN, comunidad BOOLEAN, alergia BOOLEAN, enfermedad BOOLEAN, mexicano BOOLEAN, ife BOOLEAN, ID_periodo INT, ID_censo NUMERIC(4), ID_colonia INT,
ID_estadoCivil INT, ID_nivelEducativo INT, ID_institucionEducativa INT, anoEstudio INT, ID_lenguaDominante INT, ID_nivelEspanol INT, ID_nivelIngles INT,
ID_nivelLSM INT, descripcion_empleo VARCHAR(80), nombreCompany VARCHAR(50), correoEmpleo VARCHAR(80), telefonoEmpleo VARCHAR(20), calleEmpleo VARCHAR(80),
interpretacion_LSM BOOLEAN, ID_areaTrabajo INT, ID_sueldo INT, ID_coloniaEmpleo INT, ID_perdidaAuditiva INT, prelinguistica BOOLEAN, ID_grado INT, bilateral BOOLEAN,
ID_causa INT, ID_aparatoAuditivo INT, modelo VARCHAR(30), tiene_empleo BOOLEAN, tiene_aparato BOOLEAN)
BEGIN
	DECLARE IDempleo INT;
	START TRANSACTION;		
		CALL registrarPersona(CURP, nombre, fechaNac, sexoH, telefono, correo, calle, examen, implante, comunidad, alergia, 
							enfermedad, mexicano, ife, ID_periodo, ID_censo, tiene_empleo, tiene_aparato);
		INSERT INTO PerteneceCenso VALUES(CURP, ID_censo);
		INSERT INTO Vive VALUES(CURP, ID_colonia, ID_censo);
		INSERT INTO TieneEstadoCivil VALUES(CURP, ID_estadoCivil, ID_censo);
		INSERT INTO TieneNivelEducativo VALUES(CURP, ID_nivelEducativo, ID_censo);
		INSERT INTO Estudiado VALUES(ID_institucionEducativa, ID_nivelEducativo, CURP, anoEstudio);
		INSERT INTO TieneLenguaDominante VALUES(CURP, ID_lenguaDominante, ID_censo);
		INSERT INTO TieneNivelEspanol VALUES(CURP, ID_nivelEspanol, ID_censo);
		INSERT INTO TieneNivelIngles VALUES(CURP, ID_nivelIngles, ID_censo);
		INSERT INTO TieneNivelLSM VALUES(CURP, ID_nivelLSM, ID_censo);
		IF tiene_empleo = TRUE THEN
			CALL registrarEmpleo(descripcion_empleo, nombreCompany, correoEmpleo, telefonoEmpleo, calleEmpleo, interpretacion_LSM, ID_areaTrabajo);
			SELECT MAX(ID_empleo) INTO IDempleo FROM Empleo;
			INSERT INTO LocalizaEmpleo VALUES(IDempleo, ID_coloniaEmpleo);
			INSERT INTO Gana VALUES(IDempleo, ID_sueldo, ID_censo);
			INSERT INTO TieneEmpleo VALUES(CURP, IDempleo, ID_censo);
		END IF;
		INSERT INTO TienePerdidaAuditiva VALUES(CURP, ID_perdidaAuditiva, prelinguistica, ID_censo);
		INSERT INTO EsGrado VALUES(CURP, ID_perdidaAuditiva, ID_grado, ID_censo, bilateral);
		INSERT INTO Causado VALUES (CURP, ID_perdidaAuditiva, ID_causa, ID_censo);
	    IF tiene_aparato = TRUE then
			INSERT INTO PoseeAparatoAuditivo VALUES (CURP, ID_aparatoAuditivo, ID_censo, modelo);
		END IF;
	COMMIT;
END //
DELIMITER ;								

-- PERSONA
DELIMITER //
CREATE PROCEDURE registrarPersona
(IN CURP CHAR(18), nombre VARCHAR(80), fechaNac DATETIME, sexoH BOOLEAN, telefono VARCHAR(20), correo VARCHAR(60), calle VARCHAR(80), examen BOOLEAN,
implante BOOLEAN, comunidad BOOLEAN, alergia BOOLEAN, enfermedad BOOLEAN, mexicano BOOLEAN, ife BOOLEAN, ID_periodo INT, ID_censo numeric(4),
tiene_empleo BOOLEAN, tiene_aparato BOOLEAN)
BEGIN
	START TRANSACTION;
		INSERT INTO Persona VALUES(CURP, nombre, fechaNac, sexoH, telefono, correo, calle, examen, implante, comunidad, alergia, 
									enfermedad, mexicano, ife, ID_periodo, ID_censo, tiene_empleo, tiene_aparato);
	COMMIT;
END //
DELIMITER ;	

-- EMPLEO
DELIMITER //
CREATE PROCEDURE registrarEmpleo
(IN descripcion VARCHAR(80), nombreCompany VARCHAR(50), correo VARCHAR(80), telefono VARCHAR(20), calle VARCHAR(80),
interpretacion_LSM BOOLEAN, ID_areaTrabajo INT)
BEGIN
	START TRANSACTION;
		INSERT INTO Empleo VALUES(0,descripcion, nombreCompany, correo, telefono, calle, interpretacion_LSM, ID_areaTrabajo);
	COMMIT;
END	//
DELIMITER ;


-- HIJO
DELIMITER //
CREATE PROCEDURE registrarHijo
(IN nombre VARCHAR(80), fechaNac DATETIME, sordo BOOLEAN, CURPpadre CHAR(18))
BEGIN
	START TRANSACTION;
		INSERT INTO Hijo VALUES(0, nombre, fechaNac, sordo, CURPpadre);
	COMMIT;
END //
DELIMITER ;	

-- USUARIO
DELIMITER //
CREATE PROCEDURE registrarUsuario
(IN loginNuevo VARCHAR(30), passwordNuevo VARCHAR(30), ID_rolNuevo INT)
BEGIN
	START TRANSACTION;
		INSERT INTO Usuario VALUES(loginNuevo, passwordNuevo);
		INSERT INTO TieneRol VALUES(loginNuevo, ID_rolNuevo);
	COMMIT;
END //
DELIMITER ;
						
-- **************************************************************************************************************************************************
-- BUSQUEDAS

-- busqueda PERSONA COMPLETO
DELIMITER //
CREATE PROCEDURE busquedaPersonaCOMPLETO
(IN variable VARCHAR(80))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, pC.ID_censo as Censo, v.ID_colonia as ID_coloniaPersona,
					Colonia.ID_municipio as ID_municipioPersona, Municipio.ID_estado as ID_estadoPersona
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
					TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA, Estado, Colonia, Municipio 
					WHERE (p.nombre LIKE variable)
					AND p.CURP = pC.CURP AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
					AND em.ID_empleo = tE.ID_empleo AND em.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND p.CURP = pAA.CURP AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					AND lE.ID_empleo = tE.ID_empleo 
				    GROUP BY p.CURP) as Tabla_Persona, (SELECT p.CURP as CURP, lE.ID_colonia as ID_coloniaEmleo,  
				    									col.ID_municipio as ID_municipioEmpleo, mun.ID_estado as ID_estadoEMPLEO 
				    									FROM Persona p, Empleo e, TieneEmpleo tE, LocalizaEmpleo lE, Colonia col, Municipio mun
				    									WHERE p.nombre LIKE variable
				    									AND p.CURP = tE.CURP AND tE.ID_empleo = lE.ID_empleo AND
				    									lE.ID_colonia = col.ID_colonia AND mun.ID_municipio = col.ID_municipio) as Tabla_empleo
    WHERE Tabla_Persona.CURP = Tabla_empleo.CURP
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE busquedaPersonaCOMPLETOporCenso
(IN variable VARCHAR(80), IDcensoInput numeric(4))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, pC.ID_censo as Censo, v.ID_colonia as ID_coloniaPersona,
					Colonia.ID_municipio as ID_municipioPersona, Municipio.ID_estado as ID_estadoPersona
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
					TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA, Estado, Colonia, Municipio 
					WHERE (p.nombre LIKE variable) AND p.ID_censo = IDcensoInput
					AND p.CURP = pC.CURP AND (pC.ID_censo = IDcensoInput) AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
					AND em.ID_empleo = tE.ID_empleo AND em.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND p.CURP = pAA.CURP AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					AND lE.ID_empleo = tE.ID_empleo 
				    GROUP BY p.CURP) as Tabla_Persona, (SELECT p.CURP as CURP, lE.ID_colonia as ID_coloniaEmleo,  
				    									col.ID_municipio as ID_municipioEmpleo, mun.ID_estado as ID_estadoEMPLEO 
				    									FROM Persona p, Empleo e, TieneEmpleo tE, LocalizaEmpleo lE, Colonia col, Municipio mun
				    									WHERE p.nombre LIKE variable
				    									AND p.CURP = tE.CURP AND (tE.ID_censo = IDcensoInput) AND tE.ID_empleo = lE.ID_empleo AND
				    									lE.ID_colonia = col.ID_colonia AND mun.ID_municipio = col.ID_municipio) as Tabla_empleo
    WHERE Tabla_Persona.CURP = Tabla_empleo.CURP
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE mostrarPersona
(IN nombreIn VARCHAR(80), CURPIn CHAR(18), IDcensoInput numeric(4))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, p.sexo_masculino, p.fecha_nacimiento, p.telefono, p.calle,  pC.ID_censo as Censo, Municipio.ID_estado,
					v.ID_colonia, Colonia.ID_municipio, p.mexicano, p.comunidad_indigena, p.credencialIFE, tEC.ID_estadoCivil, tNE.ID_nivelEducativo, es.ano,
					es.ID_institucionEducativa, tLD.ID_lenguaDominante, tNEsp.ID_nivelEspanol, tNI.ID_nivelIngles, tNL.ID_nivelLSM, em.descripcion, em.nombre_compania,
					g.ID_sueldo, em.ID_areaTrabajo, em.telefono as telefonoEmpleo, em.calle as calleEmpleo, em.correo as correoEmpleo, em.interpretacion_LSM, p.ID_periodo,
					tPA.ID_perdidaAuditiva, eG.ID_grado, eG.bilateral, c.ID_causa, p.examen_audiometria, p.enfermedad, p.alergia, p.implante_coclear, tPA.prelinguistica, pAA.ID_aparatoAuditivo,
					pAA.modelo
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
					TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA, Estado, Colonia, Municipio 
					WHERE (p.nombre = nombreIn) AND p.CURP = CURPIn
					AND p.CURP = pC.CURP AND (pC.ID_censo = IDcensoInput) AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
					AND em.ID_empleo = tE.ID_empleo AND em.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND p.CURP = pAA.CURP AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					AND lE.ID_empleo = tE.ID_empleo 
				    GROUP BY p.CURP) as Tabla_Persona, (SELECT p.CURP as CURP, lE.ID_colonia as ID_coloniaEmpleo, 
				    									col.ID_municipio as ID_municipioEmpleo, mun.ID_estado as ID_estadoEmpleo 
				    									FROM Persona p, Empleo e, TieneEmpleo tE, LocalizaEmpleo lE, Colonia col, Municipio mun
				    									WHERE p.nombre = nombreIn AND p.CURP = CURPIn
				    									AND p.CURP = tE.CURP AND (tE.ID_censo = IDcensoInput) AND tE.ID_empleo = lE.ID_empleo AND
				    									lE.ID_colonia = col.ID_colonia AND mun.ID_municipio = col.ID_municipio) as Tabla_empleo
    WHERE Tabla_Persona.CURP = Tabla_empleo.CURP
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;
-- ******************************************************************************************************************************

-- Busqueda PERSONA
DELIMITER //
CREATE PROCEDURE busquedaEnPersona
(IN variable VARCHAR(80))
BEGIN
	SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, pC.ID_censo as Censo, v.ID_colonia as  Colonia_datos, lE.ID_colonia as Colonia_empleo
	FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
	TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
	TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA, Estado, Colonia, Municipio 
	WHERE (p.nombre LIKE variable)
	AND p.CURP = pC.CURP AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP AND p.CURP = es.CURP
	AND P.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
	AND em.ID_empleo = tE.ID_empleo AND em.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
	AND p.CURP = pAA.CURP AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
	AND lE.ID_empleo = tE.ID_empleo 
    GROUP BY p.CURP;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE buscarPersona
(IN variable VARCHAR(80))
BEGIN 
	SELECT p.nombre as Nombre, p.CURP as CURP, p.ID_censo as Censo, p.tiene_empleo as Empleo,
    p.tiene_aparato as Aparato
    FROM Persona p
	WHERE (p.nombre LIKE variable);
END //
DELIMITER ;


-- Busqueda INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE busquedaEnInstitucionEducativa
(IN variable VARCHAR(80))
BEGIN 
	SELECT i.nombre as Nombre, i.correo as Correo, c.ID_colonia as Colonia, m.ID_municipio as Municipio, m.ID_estado as Estado
	FROM InstitucionEducativa i, Colonia c, Estado e, Municipio m,
	LocalizaInstitucionEducativa loc
	WHERE i.nombre LIKE variable
	AND loc.ID_institucionEducativa = i.ID_institucionEducativa AND loc.ID_colonia = c.ID_colonia 
	AND c.ID_municipio = m.ID_municipio AND m.ID_estado = e.ID_estado;
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
	SELECT ID_censo as Censo FROM Censo 
	WHERE ID_censo LIKE variable;
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
	SELECT u.login as Login 
	FROM Usuario u, TieneRol t
	WHERE u.login LIKE variable AND u.login = t.login;
END //
DELIMITER ;	


-- Busqueda en Hijos
DELIMITER //
CREATE PROCEDURE busquedaEnHijo
(IN CURPinput CHAR(18))
BEGIN
	SELECT nombre as Nombre, sordo as Sordo, CURP as CURP_Padre, ID_Hijo as ID
    FROM Hijo
    WHERE CURP = CURPinput;
END //
DELIMITER ;


-- Mostrar Hijo
DELIMITER //
CREATE PROCEDURE mostrarHijo
(IN ID_hijoInput INT)
BEGIN
	SELECT nombre as nombreHijo, sordo as SordoHijo
    FROM Hijo
    WHERE ID_hijo = ID_hijoInput;
END //
DELIMITER ;

-- ****************************************************************************************************************8

-- ELIMINACIONES/ DELETIONS

-- eliminar APARATOAUDITIVO
DELIMITER //
CREATE PROCEDURE eliminarAparatoAuditivo
(IN tipoA VARCHAR(70), ID_marcaA INT)
BEGIN
	DECLARE IDaparato INT;
	START TRANSACTION;	
		SELECT ID_aparatoAuditivo INTO IDaparato FROM AparatoAuditivo WHERE tipo = tipoA AND ID_marca = ID_marcaA;
		DELETE FROM PoseeAparatoAuditivo WHERE ID_aparatoAuditivo = IDaparato;
		DELETE FROM AparatoAuditivo WHERE tipoA = tipo AND ID_marcaA = ID_marca;
	COMMIT;
END //
DELIMITER ;

-- eliminar CENSO
DELIMITER //
CREATE PROCEDURE eliminarCenso
(IN IDcensoObtenido NUMERIC(4))
BEGIN
	START TRANSACTION;
		DELETE FROM PerteneceCenso WHERE ID_censo = IDcensoObtenido;
		DELETE FROM Vive WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneNivelEducativo WHERE ID_censo = IDcensoObtenido;
		DELETE FROM Gana WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneLenguaDominante WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneNivelEspanol WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneNivelIngles WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneNivelLSM WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TieneEstadoCivil WHERE ID_censo = IDcensoObtenido;
		DELETE FROM PoseeAparatoAuditivo WHERE ID_censo = IDcensoObtenido;
		DELETE FROM TienePerdidaAuditiva WHERE ID_censo = IDcensoObtenido;
		DELETE FROM Causado WHERE ID_censo = IDcensoObtenido;
		DELETE FROM EsGrado WHERE ID_censo = IDcensoObtenido;	
		DELETE FROM TieneEmpleo WHERE ID_censo = IDcensoObtenido;
		DELETE FROM Censo WHERE ID_censo = IDcensoObtenido;
	COMMIT;
END //
DELIMITER ;	

-- eliminar MARCA
DELIMITER //
CREATE PROCEDURE eliminarMarca
(IN nombreM VARCHAR(40))
BEGIN
	DECLARE IDmarcaObtenido INT;
	START TRANSACTION;		    
		SELECT ID_marca INTO IDmarcaObtenido FROM Marca WHERE nombre = nombreM;    
	    UPDATE AparatoAuditivo SET ID_marca = null WHERE ID_marca = IDmarcaObtenido;	
		DELETE FROM Marca WHERE ID_marca = IDmarcaObtenido;
	COMMIT;
END //
DELIMITER ;	

-- eliminar CAUSA
DELIMITER //
CREATE PROCEDURE eliminarCausa
(IN causaC VARCHAR(50))
BEGIN
	DECLARE IDcausaObtenido INT;
	START TRANSACTION;		
		SELECT ID_causa INTO IDcausaObtenido FROM Causa WHERE causa = causaC;
		DELETE FROM Causado WHERE ID_causa = IDcausaObtenido;
		DELETE FROM Causa WHERE ID_causa = IDcausaObtenido;
	COMMIT;
END //
DELIMITER ;	

-- eliminar SUELDO
DELIMITER //
CREATE PROCEDURE eliminarSueldo
(IN minimoS VARCHAR(20), maximoS VARCHAR(20))
BEGIN
	DECLARE IDsueldoObtenido INT;
	START TRANSACTION;		
		SELECT ID_sueldo INTO IDsueldoObtenido FROM Sueldo WHERE minimo = minimoS AND maximo = maximoS;
		DELETE FROM Gana WHERE ID_sueldo = IDsueldoObtenido;
		DELETE FROM Sueldo WHERE ID_sueldo = IDsueldoObtenido;
	COMMIT;
END //
DELIMITER ;	


-- Eliminar HIJO
DELIMITER //
CREATE PROCEDURE eliminarHijo
(IN ID_hijoInput INT)
BEGIN 
	START TRANSACTION;
		DELETE FROM Hijo WHERE ID_hijo = ID_hijoInput;
	COMMIT;
END //
DELIMITER ;


-- eliminar AREATRABAJO
DELIMITER //
CREATE PROCEDURE eliminarAreaTrabajo
(IN nombreA VARCHAR(60))
BEGIN
	DECLARE IDareaTrabajoObtenido INT;
	START TRANSACTION;		
		SELECT ID_areaTrabajo INTO IDareaTrabajoObtenido FROM AreaTrabajo WHERE nombre = nombreA;
		UPDATE Empleo SET ID_areaTrabajo = null WHERE ID_areaTrabajo = IDareaTrabajoObtenido;
		DELETE FROM AreaTrabajo WHERE nombre = nombreA;
	COMMIT;
END //
DELIMITER ;


-- eliminar USUARIO
DELIMITER //
CREATE PROCEDURE eliminarUsuario
(IN loginU VARCHAR(30))
BEGIN
	START TRANSACTION;
		DELETE FROM TieneRol WHERE login = loginU;
		DELETE FROM Usuario WHERE login = loginU;
	COMMIT;
END //
DELIMITER ;	


-- eliminar PERSONA (POSIBLE CAMBIO)
DELIMITER //
CREATE PROCEDURE eliminarPersona
(IN CURPinput CHAR(18), ID_censoInput NUMERIC(4))
BEGIN
	START TRANSACTION;
		DELETE FROM PerteneceCenso WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM Vive WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneNivelEducativo WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM Estudiado WHERE CURP = CURPinput;
		DELETE FROM TieneEmpleo WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneLenguaDominante WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneNivelEspanol WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneNivelIngles WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneNivelLSM WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM TieneEstadoCivil WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM PoseeAparatoAuditivo WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM Hijo WHERE CURP = CURPinput;
		DELETE FROM TienePerdidaAuditiva WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM Causado WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM EsGrado WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
		DELETE FROM Persona WHERE CURP = CURPinput AND ID_censo = ID_censoInput;
	COMMIT;
END //
DELIMITER ;	


-- eliminar COLONIA
DELIMITER //
CREATE PROCEDURE eliminarColonia
(IN nombreC VARCHAR(80), IDmunicipio INT)
BEGIN
	DECLARE IDcoloniaObtenido INT;
	START TRANSACTION;	
		SELECT ID_colonia INTO IDcoloniaObtenido FROM Colonia WHERE nombre = nombreC AND ID_municipio = IDmunicipio;
		DELETE FROM Vive WHERE ID_colonia = IDcoloniaObtenido;
		DELETE FROM LocalizaInstitucionEducativa WHERE ID_colonia = IDcoloniaObtenido;
		DELETE FROM LocalizaEmpleo WHERE ID_colonia = IDcoloniaObtenido;
		DELETE FROM Colonia WHERE ID_colonia = IDcoloniaObtenido;
	COMMIT;
END //
DELIMITER ;


-- eliminar MUNICIPIO
DELIMITER //
CREATE PROCEDURE eliminarMunicipio
(IN nombreM VARCHAR(80), IDestado INT)
BEGIN
	DECLARE IDmunicpioObtenido INT;
	START TRANSACTION;		
		SELECT ID_municipio INTO IDmunicpioObtenido FROM Municipio WHERE nombre = nombreM AND ID_estado = IDestado;
		DELETE FROM Colonia WHERE ID_municipio = IDmunicpioObtenido;	
		DELETE FROM Municipio WHERE ID_municipio = IDmunicpioObtenido;
	COMMIT;
END //
DELIMITER ;


-- eliminar ESTADO
DELIMITER //
CREATE PROCEDURE eliminarEstado
(IN nombreE VARCHAR(80))
BEGIN
	DECLARE IDestadoObtenido INT;
	START TRANSACTION;		
		SELECT ID_estado INTO IDestadoObtenido FROM Estado WHERE nombre = nombreE;
		DELETE FROM Municipio WHERE ID_estado = IDestadoObtenido;
		DELETE FROM Estado WHERE ID_estado = IDestadoObtenido;
	COMMIT;
END //
DELIMITER ;

-- elimanar INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE eliminarInstitucionEducativa
(IN nombreI VARCHAR(90))
BEGIN
	DECLARE IDinstitucionObtenida INT;
	START TRANSACTION;		
		SELECT ID_institucionEducativa INTO IDinstitucionObtenida FROM InstitucionEducativa WHERE nombre = nombreI;
		DELETE FROM Estudiado WHERE ID_institucionEducativa = IDinstitucionObtenida;
		DELETE FROM LocalizaInstitucionEducativa WHERE ID_institucionEducativa = IDinstitucionObtenida;
	COMMIT;
END //
DELIMITER ;	


-- **********************************************************************************************************************************
-- MODIFICA

-- modifica APARATO AUDITIVO
DELIMITER //
CREATE PROCEDURE modificarAparatoAuditivo
(IN tipoA VARCHAR(70), ID_marcaA INT, tipoNuevo VARCHAR(70), ID_marcaNuevo INT)
BEGIN
	DECLARE IDaparatoObtenido INT;
	START TRANSACTION;		
		SELECT ID_aparatoAuditivo INTO IDaparatoObtenido FROM AparatoAuditivo WHERE tipo = tipoA AND ID_marca = ID_marcaA;
		UPDATE AparatoAuditivo SET tipo = tipoNuevo, ID_marca = ID_marcaNuevo
		WHERE ID_aparatoAuditivo = IDaparatoObtenido;
	COMMIT;
END //
DELIMITER ;

-- modifica CENSO
DELIMITER //
CREATE PROCEDURE modificarCenso
(IN IDcenso NUMERIC(4), IDcensoNuevo NUMERIC(4))
BEGIN
	START TRANSACTION;
		CALL registrarCenso(IDcensoNuevo);
		UPDATE PerteneceCenso SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE Persona SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE Vive SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneNivelEducativo SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE Gana SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneLenguaDominante SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneNivelEspanol SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneNivelIngles SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneNivelLSM SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneEstadoCivil SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE PoseeAparatoAuditivo SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TienePerdidaAuditiva SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE Causado SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE EsGrado SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		UPDATE TieneEmpleo SET ID_censo = IDcensoNuevo WHERE ID_censo = IDcenso;
		CALL eliminarCenso(IDcenso);
	COMMIT;
END //
DELIMITER ;	

-- modificar MARCA
DELIMITER //
CREATE PROCEDURE modificarMarca
(IN nombreM VARCHAR(40), nombreNuevo VARCHAR(40))
BEGIN
	DECLARE IDmarcaObtenido INT;
	START TRANSACTION;		
	    SELECT ID_marca INTO IDmarcaObtenido FROM Marca WHERE nombre = nombreM;
		UPDATE Marca SET nombre = nombreNuevo WHERE nombre = nombreM;
	COMMIT;
END //
DELIMITER ;

-- modificar CAUSA 
DELIMITER //
CREATE PROCEDURE modificarCausa
(IN causaC VARCHAR(50), causaNueva VARCHAR(50))
BEGIN
	DECLARE IDcausaObtenido INT;
	START TRANSACTION;		
		SELECT ID_causa INTO IDcausaObtenido FROM Causa WHERE causa = causaC;
		UPDATE Causa SET causa = causaNueva WHERE ID_causa = IDcausaObtenido;
	COMMIT;
END //
DELIMITER ;	

-- modificar SUELDO
DELIMITER //
CREATE PROCEDURE modificarSueldo
(IN minimoS VARCHAR(20), maximoS VARCHAR(20), minimoNuevo VARCHAR(20), maximoNuevo VARCHAR(20))
BEGIN
	START TRANSACTION;
		UPDATE Sueldo SET minimo = minimoNuevo, maximo = maximoNuevo WHERE minimo = minimoS AND maximo = maximoS;
	COMMIT;
END //
DELIMITER ;	

-- Modificar HIJO
DELIMITER // 
CREATE PROCEDURE modificarHijo
(IN ID_hijoInput INT, nombreInput VARCHAR(80), fecha DATETIME, esSordo BOOLEAN)	
BEGIN
	START TRANSACTION;
		UPDATE Hijo SET nombre = nombreInput, fecha_nacimiento = fecha, sordo = esSordo
	    WHERE ID_hijo = ID_hijoInput;
	COMMIT;
END // 
DELIMITER ;


-- modificar AREATRABAJO
DELIMITER //
CREATE PROCEDURE modificarAreaTrabajo
(IN nombreA VARCHAR(60), nombreNuevo VARCHAR(60))
BEGIN 
	START TRANSACTION;
		UPDATE AreaTrabajo SET nombre = nombreNuevo WHERE nombre = nombreA;
	COMMIT;
END //
DELIMITER ;

-- modificar USUARIO
DELIMITER //
CREATE PROCEDURE modificarUsuario
(IN loginU VARCHAR(30), loginNuevo VARCHAR(30), passwordNuevo VARCHAR(30), IDrolViejo INT, IDrolNevo INT)
BEGIN
	START TRANSACTION;
		UPDATE TieneRol SET ID_rol = IDrolNevo, login = loginNuevo WHERE login = loginU AND ID_rol = IDrolViejo;	
		UPDATE Usuario SET login = loginNuevo, password_usuario = passwordNuevo WHERE login = loginU;
	COMMIT;
END //
DELIMITER ;

-- modificar PERSONA
DELIMITER //
CREATE PROCEDURE modificarPersona
(IN CURP CHAR(18), nombre VARCHAR(80), fechaNac DATETIME, sexoH BOOLEAN, telefono VARCHAR(20), correo VARCHAR(60), calle VARCHAR(80), examen BOOLEAN,
implante BOOLEAN, comunidad BOOLEAN, alergia BOOLEAN, enfermedad BOOLEAN, mexicano BOOLEAN, ife BOOLEAN, ID_periodo INT, ID_censo NUMERIC(4), ID_colonia INT,
ID_estadoCivil INT, ID_nivelEducativo INT, ID_institucionEducativa INT, anoEstudio INT, ID_lenguaDominante INT, ID_nivelEspanol INT, ID_nivelIngles INT,
ID_nivelLSM INT, descripcion_empleo VARCHAR(80), nombreCompany VARCHAR(50), correoEmpleo VARCHAR(80), telefonoEmpleo VARCHAR(20), calleEmpleo VARCHAR(80),
interpretacion_LSM BOOLEAN, ID_areaTrabajo INT, ID_sueldo INT, ID_coloniaEmpleo INT, ID_perdidaAuditiva INT, prelinguistica BOOLEAN, ID_grado INT, bilateral BOOLEAN,
ID_causa INT, ID_aparatoAuditivo INT, modelo VARCHAR(30), tiene_empleo BOOLEAN, tiene_aparato BOOLEAN)
BEGIN
	START TRANSACTION;
		CALL eliminarPersona(CURP, ID_censo);
		CALL registrarPersonaCOMPLETO(CURP, nombre, fechaNac, sexoH, telefono, correo, calle, examen, implante, comunidad, alergia, enfermedad, mexicano, ife,
									ID_periodo, ID_censo, ID_colonia, ID_estadoCivil, ID_nivelEducativo, ID_institucionEducativa, anoEstudio, ID_lenguaDominante,
									ID_nivelEspanol, ID_nivelIngles, ID_nivelLSM, descripcion_empleo, nombreCompany, correoEmpleo, telefonoEmpleo, calleEmpleo,
									interpretacion_LSM, ID_areaTrabajo, ID_sueldo, ID_coloniaEmpleo, ID_perdidaAuditiva, prelinguistica, ID_grado, bilateral,
									ID_causa, ID_aparatoAuditivo, modelo, tiene_empleo, tiene_aparato);
	COMMIT;
END //
DELIMITER ;


-- modificar COLONIA
DELIMITER //
CREATE PROCEDURE modificarColonia
(IN nombreC VARCHAR(80), IDmunicipio INT, nombreNuevo VARCHAR(80), IDmunicipioNuevo INT, delegacionNuevo VARCHAR(80))
BEGIN
	DECLARE IDcoloniaObtenido INT;
	START TRANSACTION;		
		SELECT ID_colonia INTO IDcoloniaObtenido FROM Colonia WHERE nombre = nombreC AND ID_municipio = IDmunicipio;
		UPDATE Colonia SET nombre = nombreNuevo, ID_municipio = IDmunicipioNuevo, delegacion = delegacionNuevo WHERE ID_colonia = IDcoloniaObtenido;
	COMMIT;
END //
DELIMITER ;

-- modificar MUNICIPIO
DELIMITER //
CREATE PROCEDURE modificarMunicipio
(IN nombreM VARCHAR(80), IDestado INT, nombreNuevo VARCHAR(80), IDestadoNuevo INT)
BEGIN
	START TRANSACTION;
		UPDATE Municipio SET nombre = nombreNuevo, ID_estado = IDestadoNuevo WHERE nombre = nombreM AND ID_estado = IDestado;
	COMMIT;
END //
DELIMITER ;


-- modificar ESTADO
DELIMITER //
CREATE PROCEDURE modificarEstado
(IN nombreE VARCHAR(80), nombreNuevo VARCHAR(80))
BEGIN
	START TRANSACTION;
		UPDATE Estado SET nombre = nombreNuevo WHERE nombre  = nombreE;
	COMMIT;
END //
DELIMITER ;

-- modificar INSTITUCIONEDUCATIVA
DELIMITER //
CREATE PROCEDURE modificarInstitucionEducativa
(IN nombreViejo VARCHAR(90), nombreNuevo VARCHAR(90), calleNuevo VARCHAR(80), telefonoNuevo VARCHAR(20), correoNuevo VARCHAR(80),
 privadaNuevo BOOLEAN, especializadaNuevo BOOLEAN, IDcoloniaNuevo INT)
BEGIN
	DECLARE IDinstitucion INT;
	START TRANSACTION;		
		SELECT ID_institucionEducativa INTO IDinstitucion FROM InstitucionEducativa WHERE nombre = nombreViejo;
		UPDATE InstitucionEducativa SET nombre = nombreNuevo, calle = calleNuevo, telefono = telefonoNuevo, correo = correoNuevo, privada = privadaNuevo,
		especializada = especializadaNuevo WHERE nombre = nombreViejo;
		UPDATE LocalizaInstitucionEducativa SET ID_colonia = IDcoloniaNuevo WHERE ID_institucionEducativa = IDinstitucion;
	COMMIT;
END //
DELIMITER ;


-- Procedimeintos para hacer posible crear personas sin empleo y aparato

-- obtener direccion de Persona
DELIMITER //
CREATE PROCEDURE obtenerDireccionPersona
(IN CURPInput CHAR(18), ID_censoInput NUMERIC(4))
BEGIN
	SELECT m.ID_estado, m.ID_municipio, c.ID_colonia
    FROM Vive v, Colonia c, Municipio m 
    WHERE v.CURP = CURPInput AND v.ID_censo = ID_censoInput 
    AND v.ID_colonia = c.ID_colonia AND c.ID_municipio = m.ID_municipio;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE obtenerDireccionEmpleo
(IN CURPinput CHAR(18), ID_censoInput NUMERIC(4))
BEGIN
	SELECT m.ID_estado, m.ID_municipio, c.ID_colonia
    FROM TieneEmpleo tE, LocalizaEmpleo lE, Colonia c, Municipio m 
    WHERE tE.CURP = CURPinput AND tE.ID_censo = ID_censoInput AND tE.ID_empleo = lE.ID_empleo
    AND lE.ID_colonia = c.ID_colonia AND c.ID_municipio = m.ID_municipio;
END //
DELIMITER ;


-- mostrar Persona sin empleo
DELIMITER //
CREATE PROCEDURE mostrarPersonaSinEmpleo
(IN nombreIn VARCHAR(80), CURPIn CHAR(18), IDcensoInput numeric(4))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, p.sexo_masculino, p.fecha_nacimiento, p.telefono, p.calle,  pC.ID_censo as Censo, Municipio.ID_estado,
					v.ID_colonia, Colonia.ID_municipio, p.mexicano, p.comunidad_indigena, p.credencialIFE, tEC.ID_estadoCivil, tNE.ID_nivelEducativo, es.ano,
					es.ID_institucionEducativa, tLD.ID_lenguaDominante, tNEsp.ID_nivelEspanol, tNI.ID_nivelIngles, tNL.ID_nivelLSM, p.ID_periodo,
					tPA.ID_perdidaAuditiva, eG.ID_grado, eG.bilateral, c.ID_causa, p.examen_audiometria, p.enfermedad, p.alergia, p.implante_coclear, tPA.prelinguistica, pAA.ID_aparatoAuditivo,
					pAA.modelo
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,
					TienePerdidaAuditiva tPA, EsGrado eG, Causado c, PoseeAparatoAuditivo pAA, Estado, Colonia, Municipio 
					WHERE (p.nombre = nombreIn) AND p.CURP = CURPIn
					AND p.CURP = pC.CURP AND (pC.ID_censo = IDcensoInput) AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP 
					AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND p.CURP = pAA.CURP AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					GROUP BY p.CURP) as Tabla_Persona
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;


-- mostrar Persona sin Aparato Auditivo
DELIMITER //
CREATE PROCEDURE mostrarPersonaSinAparato
(IN nombreIn VARCHAR(80), CURPIn CHAR(18), IDcensoInput numeric(4))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, p.sexo_masculino, p.fecha_nacimiento, p.telefono, p.calle,  pC.ID_censo as Censo, Municipio.ID_estado,
					v.ID_colonia, Colonia.ID_municipio, p.mexicano, p.comunidad_indigena, p.credencialIFE, tEC.ID_estadoCivil, tNE.ID_nivelEducativo, es.ano,
					es.ID_institucionEducativa, tLD.ID_lenguaDominante, tNEsp.ID_nivelEspanol, tNI.ID_nivelIngles, tNL.ID_nivelLSM, em.descripcion, em.nombre_compania,
					g.ID_sueldo, em.ID_areaTrabajo, em.telefono as telefonoEmpleo, em.calle as calleEmpleo, em.correo as correoEmpleo, em.interpretacion_LSM, p.ID_periodo,
					tPA.ID_perdidaAuditiva, eG.ID_grado, eG.bilateral, c.ID_causa, p.examen_audiometria, p.enfermedad, p.alergia, p.implante_coclear, tPA.prelinguistica
					
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,  Empleo em,
					TieneEmpleo tE, LocalizaEmpleo lE, Gana g, TienePerdidaAuditiva tPA, EsGrado eG, Causado c, Estado, Colonia, Municipio 
					WHERE (p.nombre = nombreIn) AND p.CURP = CURPIn
					AND p.CURP = pC.CURP AND (pC.ID_censo = IDcensoInput) AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP AND p.CURP = tE.CURP
					AND em.ID_empleo = tE.ID_empleo AND em.ID_empleo = g.ID_empleo AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					AND lE.ID_empleo = tE.ID_empleo 
				    GROUP BY p.CURP) as Tabla_Persona, (SELECT p.CURP as CURP, lE.ID_colonia as ID_coloniaEmpleo, 
				    									col.ID_municipio as ID_municipioEmpleo, mun.ID_estado as ID_estadoEmpleo 
				    									FROM Persona p, Empleo e, TieneEmpleo tE, LocalizaEmpleo lE, Colonia col, Municipio mun
				    									WHERE p.nombre = nombreIn AND p.CURP = CURPIn
				    									AND p.CURP = tE.CURP AND (tE.ID_censo = IDcensoInput) AND tE.ID_empleo = lE.ID_empleo AND
				    									lE.ID_colonia = col.ID_colonia AND mun.ID_municipio = col.ID_municipio) as Tabla_empleo
    WHERE Tabla_Persona.CURP = Tabla_empleo.CURP
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;


-- mostrar persona sin empleo ni aparato
DELIMITER //
CREATE PROCEDURE mostrarPersonaSinEmpleoSinAparato
(IN nombreIn VARCHAR(80), CURPIn CHAR(18), IDcensoInput numeric(4))
BEGIN 
	SELECT * FROM (SELECT p.nombre as Nombre, p.CURP as CURP, p.Correo as Correo, p.sexo_masculino, p.fecha_nacimiento, p.telefono, p.calle,  pC.ID_censo as Censo, Municipio.ID_estado,
					v.ID_colonia, Colonia.ID_municipio, p.mexicano, p.comunidad_indigena, p.credencialIFE, tEC.ID_estadoCivil, tNE.ID_nivelEducativo, es.ano,
					es.ID_institucionEducativa, tLD.ID_lenguaDominante, tNEsp.ID_nivelEspanol, tNI.ID_nivelIngles, tNL.ID_nivelLSM, p.ID_periodo,
					tPA.ID_perdidaAuditiva, eG.ID_grado, eG.bilateral, c.ID_causa, p.examen_audiometria, p.enfermedad, p.alergia, p.implante_coclear, tPA.prelinguistica					
					FROM Persona p, PerteneceCenso pC, Censo ce,  Vive v, TieneEstadoCivil tEC, TieneNivelEducativo tNE, Estudiado es,
					TieneLenguaDominante tLD, TieneNivelEspanol tNEsp, TieneNivelIngles tNI, TieneNivelLSM tNL,
					TienePerdidaAuditiva tPA, EsGrado eG, Causado c, Estado, Colonia, Municipio 
					WHERE (p.nombre = nombreIn) AND p.CURP = CURPIn
					AND p.CURP = pC.CURP AND (pC.ID_censo = IDcensoInput) AND pC.ID_censo = ce.ID_censo AND p.CURP = v.CURP AND p.CURP = tEC.CURP AND p.CURP = tNE.CURP
					AND p.CURP = es.CURP AND p.CURP = tLD.CURP AND tNEsp.CURP = p.CURP AND p.CURP = tNI.CURP AND p.CURP = tNL.CURP 
					AND p.CURP = tPA.CURP AND p.CURP = eG.CURP AND c.CURP = p.CURP
					AND v.ID_colonia = Colonia.ID_colonia AND Colonia.ID_municipio = Municipio.ID_municipio AND Municipio.ID_estado = Estado.ID_estado
					GROUP BY p.CURP) as Tabla_Persona
    GROUP BY Tabla_Persona.CURP;
END //
DELIMITER ;















