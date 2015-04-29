DELIMITER //
CREATE PROCEDURE 

-- Numero de personas
SELECT COUNT(*)
FROM Persona p

-- SALUD **************************************************************************************************


			-- AUXILIARES AUDITIVOS

 -- Numero de personas que usan determinada marca
DELIMITER //
CREATE PROCEDURE consultaMarca
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT m.nombre as Marca, COUNT(*) as 'No. de Personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Marca m, PoseeAparatoAuditivo p, AparatoAuditivo a
	WHERE a.ID_aparatoAuditivo = p.ID_aparatoAuditivo AND a.ID_marca = m.ID_marca
	GROUP BY m.nombre;
END //
DELIMITER ;
-- Variando censo
DELIMITER //
CREATE PROCEDURE consultaMarcaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo; -- Hay diferente totalPersonas cada censo
	SELECT m.nombre as Marca, COUNT(*) as 'No. de Personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Marca m, PoseeAparatoAuditivo p, AparatoAuditivo a
	WHERE a.ID_aparatoAuditivo = p.ID_aparatoAuditivo AND a.ID_marca = m.ID_marca AND p.ID_censo = censo
	GROUP BY m.nombre;
END //
DELIMITER ;

-- Numero de personas que usan determinado tipo de aparato
DELIMITER //
CREATE PROCEDURE consultaTipoAparato
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT a.tipo as Tipo, COUNT(*) as 'Total', COUNT(*) / totalPersonas * 100 as 'Porcentaje'
	FROM AparatoAuditivo a, PoseeAparatoAuditivo p
	WHERE p.ID_aparatoAuditivo = a.ID_aparatoAuditivo
	GROUP BY a.tipo;
END //
DELIMITER ;


-- Numero de personas que no tienen Auxiliar auditivo ****************************************
DELIMITER //
CREATE PROCEDURE consultaNoTienenAuxiliar
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT COUNT(*) as 'PersonasSinAparato', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona p
	WHERE CURP NOT IN (SELECT CURP FROM PoseeAparatoAuditivo p);	
END //
DELIMITER ;
-- Validacion por censo
DELIMITER //
CREATE PROCEDURE consultaNoTienenAuxiliarPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(*) as 'PersonasConAparato',  (COUNT(*) / totalPersonas * 100) as 'Porcentaje' 
	FROM PerteneceCenso p
	WHERE ID_censo = censo
	AND CURP NOT IN (SELECT CURP FROM PoseeAparatoAuditivo p WHERE ID_censo = censo);
END //
DELIMITER ;
-- **********************************************************************************************

-- Numero de personas que Si tienen Auxiliar auditivo *************************************
DELIMITER //
CREATE PROCEDURE consultaSiTienenAuxiliar
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT COUNT(*) as 'PersonasConAparato',  (COUNT(*) / totalPersonas * 100) as 'Porcentaje' 
	FROM Persona p
	WHERE CURP IN (SELECT CURP FROM PoseeAparatoAuditivo p);
END //
DELIMITER ;
-- validacion CENSO
DELIMITER //
CREATE PROCEDURE consultaSiTienenAuxiliarPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(*) as 'PersonasConAparato',  (COUNT(*) / totalPersonas * 100) as 'Porcentaje' 
	FROM PerteneceCenso p
	WHERE ID_censo = censo
	AND CURP IN (SELECT CURP FROM PoseeAparatoAuditivo p WHERE ID_censo = censo);
END //
DELIMITER ;
-- ******************************************************************************************

-- Personas con y sin APARATO
DELIMITER //
CREATE PROCEDURE consultaAuxiliares
()
BEGIN
	
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
    SELECT * FROM (
	SELECT COUNT(*) as 'PersonasSinAparato', (COUNT(*) / totalPersonas * 100) as 'PorcentajeSin'
	FROM Persona p
	WHERE CURP NOT IN (SELECT CURP FROM PoseeAparatoAuditivo p)) as tablaUno, (SELECT COUNT(*) as 'PersonasConAparato', (COUNT(*) / totalPersonas * 100) as 'PorcentajeCon'
	FROM Persona p
	WHERE CURP IN (SELECT CURP FROM PoseeAparatoAuditivo p)) AS TABLADOS;    
END //
DELIMITER ;
-- Personas con y sin APARATO (Por Censo)
DELIMITER //
CREATE PROCEDURE consultaAuxiliaresPorCenso
(IN Censo INT)
BEGIN	
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso p WHERE ID_censo = Censo;
    SELECT * FROM (
		SELECT COUNT(*) as 'PersonasSinAparato', (COUNT(*) / totalPersonas * 100) as 'PorcentajeSin'
		FROM PerteneceCenso p
        WHERE ID_censo = Censo
		AND CURP NOT IN (SELECT CURP FROM PoseeAparatoAuditivo p WHERE ID_censo = Censo)) as tablaUno,
		(SELECT COUNT(*) as 'PersonasConAparato', (COUNT(*) / totalPersonas * 100) as 'PorcentajeCon'
		FROM PerteneceCenso p
        WHERE ID_censo = Censo
		AND CURP IN (SELECT CURP FROM PoseeAparatoAuditivo p WHERE ID_censo = Censo)) AS TABLADOS;    
END //
DELIMITER ;


-- Numero de personas que tienen implante coclear*********************************************************
DELIMITER //
CREATE PROCEDURE consultaTienenImplanteCoclear
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT implante_coclear as TienenImplanteCoclear, COUNT(*) as Total, (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY implante_coclear;
END //
DELIMITER ;
-- Variacion en censo
DELIMITER //
CREATE PROCEDURE consultaTienenImplanteCoclearPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT implante_coclear as TienenImplanteCoclear, COUNT(*) as Total, (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona p, PerteneceCenso pert 
	WHERE p.CURP = pert.CURP AND pert.ID_censo = censo
	GROUP BY implante_coclear;
END //
DELIMITER ;
-- ********************************************************************************************************


					-- ESTADO DE SALUD

-- Numero de personas que tienen otra Enfermedad
DELIMITER //
CREATE PROCEDURE consultaTienenEnfermedad
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT enfermedad as 'TienenEnfermedad', COUNT(*) as 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY Enfermedad;
END //
DELIMITER ;



-- Numero de personas que tienen una alergia
DELIMITER //
CREATE PROCEDURE consultaTienenAlergia
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT alergia as 'TienenAlergia', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY alergia;
END //
DELIMITER ;

-- Numero de personas que han realizado examen audiometria
DELIMITER //
CREATE PROCEDURE consultaExamenAudiometria
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT examen_audiometria AS 'HanRealizadoExamenAudiometria',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY examen_audiometria;
END //
DELIMITER ;

		-- TIPOLOGIA DE PERDIDA

 -- Numero de personas sordas pertenecientes a cada grado de perdidia
 DELIMITER //
 CREATE PROCEDURE consultaGradoPerdidiaAuditiva
 ()
 BEGIN
 	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT grado as 'Grado', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Grado g, EsGrado es 
	WHERE g.ID_grado = es.ID_grado
	GROUP BY grado;
END //
DELIMITER ;

-- Numero de personas que tienen Perdida Auditiva BILATERAL o Unilateral
DELIMITER //
CREATE PROCEDURE consultaEsPerdidaBilateral
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT bilateral as 'Bilateral',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM EsGrado
	GROUP BY bilateral;
END //
DELIMITER ;


-- Numero de personas por causa de perdida de Audicion
DELIMITER //
CREATE PROCEDURE consultaPorCausa
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT Causa as 'Causa', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Causa c, Causado ca 
	WHERE c.ID_causa = ca.ID_causa
	GROUP BY Causa;
END //
DELIMITER ;

-- Numero de personas por tipo de perdida de audicion
DELIMITER //
CREATE PROCEDURE consultaPorTipoPerdidaAuditiva
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT Tipo as 'TipoPerdida', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM TienePerdidaAuditiva t, PerdidaAuditiva p
	WHERE p.ID_perdidaAuditiva = t.ID_perdidaAuditiva
	GROUP BY Tipo;
END //
DELIMITER ;

-- Numero de personas que tuvieron sordera PRELINGUISTICA
DELIMITER //
CREATE PROCEDURE consultaPerididaPrelinguistica
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT Prelinguistica as 'PerdidaPrelinguistica', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM TienePerdidaAuditiva
	GROUP BY Prelinguistica;
END //
DELIMITER ;
	

-- **********************************************************************************************************************
-- Consulta de pérdida de audición por etapas (periodos)
DELIMITER //
CREATE PROCEDURE consultaEtapasPerdidaAudicion
()
BEGIN
	DECLARE totalPersonas INT;
    SELECT COUNT(*) INTO totalPersonas FROM Persona p;
    SELECT t.periodo as 'Etapa', COUNT(*) as 'No. de Personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
    FROM Periodo t, Persona p
    WHERE t.ID_periodo = p.ID_periodo
    GROUP BY t.periodo;
END //
DELIMITER ;

-- *********************************************************************************************************************
								-- DEMOGRAFÍA
-- Consulta de personas con discapacidad auditiva por municipio...
DELIMITER //
CREATE PROCEDURE consultaPorMunicipio
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT m.nombre as 'Municipio', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Municipio m, Vive v, Colonia c
	WHERE c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia
	GROUP BY m.nombre;
END //
DELIMITER ;


-- Número de hombres y mujeres (por sexo)
DELIMITER // 
CREATE PROCEDURE consultaHombresMujeres
()
BEGIN 
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT sexo_masculino as EsHombre, COUNT(*) as Total, (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona 
	GROUP BY sexo_masculino;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por estado civil...
DELIMITER //
CREATE PROCEDURE consultaPorEstadoCivil
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT e.nombre AS 'Estao civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil
	GROUP BY e.nombre;
END //
DELIMITER ;