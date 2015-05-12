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
	SELECT COUNT(*) INTO totalPersonas FROM PoseeAparatoAuditivo p;
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
	SELECT COUNT(*) INTO totalPersonas FROM PoseeAparatoAuditivo WHERE ID_censo = censo; -- Hay diferente totalPersonas cada censo
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
	SELECT COUNT(*) INTO totalPersonas FROM PoseeAparatoAuditivo;
	SELECT a.tipo as Tipo, COUNT(*) as 'Total', COUNT(*) / totalPersonas * 100 as 'Porcentaje'
	FROM AparatoAuditivo a, PoseeAparatoAuditivo p
	WHERE p.ID_aparatoAuditivo = a.ID_aparatoAuditivo
	GROUP BY a.tipo;
END //
DELIMITER ;



-- Numero de personas que usan determinado tipo de aparato por censo...
DELIMITER //
CREATE PROCEDURE consultaTipoAparatoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PoseeAparatoAuditivo WHERE ID_censo = censo;
	SELECT a.tipo as Tipo, COUNT(*) as 'Total', COUNT(*) / totalPersonas * 100 as 'Porcentaje'
	FROM AparatoAuditivo a, PoseeAparatoAuditivo p
	WHERE p.ID_aparatoAuditivo = a.ID_aparatoAuditivo AND p.ID_censo = censo
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
	SELECT enfermedad as 'Tienen enfermedad', COUNT(*) as 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY Enfermedad;
END //
DELIMITER ;


-- Número de personas que tienen otra enfermedad por censo
DELIMITER //
CREATE PROCEDURE consultaTienenEnfermedadPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
    SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
    SELECT p.enfermedad AS 'Tienen enfermedad', COUNT(*) AS Total, (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
    FROM Persona p, PerteneceCenso per
    WHERE p.CURP = per.CURP AND per.ID_censo = censo
    GROUP BY enfermedad;
END //
DELIMITER ;



-- Numero de personas que tienen una alergia
DELIMITER //
CREATE PROCEDURE consultaTienenAlergia
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT alergia as 'Tienen alergia', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY alergia;
END //
DELIMITER ;


-- Número de persona que tienen una alergia por censo
DELIMITER //
CREATE PROCEDURE consultaTienenAlergiaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.alergia AS 'Tienen alergia', COUNT(*) AS Total, (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo
	GROUP BY p.alergia;
END //
DELIMITER ;

-- Numero de personas que han realizado examen audiometria
DELIMITER //
CREATE PROCEDURE consultaExamenAudiometria
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT examen_audiometria AS 'Han realizado examen audiometria',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona
	GROUP BY examen_audiometria;
END //
DELIMITER ;




-- Número de personas que han realizado examen de audiometría por censo
DELIMITER //
CREATE PROCEDURE consultaExamenAudiometriaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.examen_audiometria AS 'Han realizado examen de audiometria', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Persona p, PerteneceCenso per
	WHERE per.CURP = p.CURP AND per.ID_censo = censo
	GROUP BY p.examen_audiometria;
END //
DELIMITER ;



		-- TIPOLOGIA DE PERDIDA

 -- Numero de personas sordas pertenecientes a cada grado de perdida
 DELIMITER //
 CREATE PROCEDURE consultaGradoPerdidaAuditiva
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


-- Número de personas sordas pertenecientes a cada grado de pérdida
DELIMITER //
CREATE PROCEDURE consultaGradoPerdidaAuditivaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT g.grado AS 'Grado', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Grado g, EsGrado es
	WHERE g.ID_grado = es.ID_grado AND es.ID_censo = censo
	GROUP BY g.grado;
END //
DELIMITER ;



-- Número de personas sordas pertenecientes a cada grado de pérdida auditiva xrecibiendo 5 booleanos...
DELIMITER //
CREATE PROCEDURE consultaGradoPerdidaAuditivaPorCadaGrado
(IN leve boolean, media boolean, profunda boolean, severa boolean, total boolean)
BEGIN
	
	DECLARE perLeve VARCHAR(50);
	DECLARE perMedia VARCHAR(50);
	DECLARE perProf VARCHAR(50);
	DECLARE perSev VARCHAR(50);
	DECLARE perTotal VARCHAR(50);
	DECLARE totalPersonas INT;

	SET perLeve = 'Per', perMedia = 'Per', perProf = 'Per', perSev = 'Per', perTotal = 'Per';

	IF (leve) THEN
		SET perLeve = 'Perdida Auditiva Leve';
	END IF;

	IF (media) THEN
		SET perMedia = 'Perdida Auditiva Media';
	END IF;

	IF (profunda) THEN
		SET perProf = 'Perdida Auditiva Profunda';
	END IF;

	IF (severa) THEN
		SET perSev = 'Perdida Auditiva Severa';
	END IF;

	IF (total) THEN
		SET perTotal = 'Perdida Auditiva Total';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT g.grado as 'Grado', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Grado g, EsGrado es
	WHERE g.ID_grado = es.ID_grado AND g.grado IN(perLeve, perMedia, perProf, perSev, perTotal)
	GROUP BY g.grado;
END //
DELIMITER ;



-- Número de personas pertenecientes a cada grado de pérdida auditiva recibiendo 5 booleanos y un censo
DELIMITER //
CREATE PROCEDURE consultaGradoPerdidaAuditivaPorCadaGradoPorCenso
(IN leve boolean, media boolean, profunda boolean, severa boolean, total boolean, censo INT)
BEGIN
	
	DECLARE perLeve VARCHAR(50);
	DECLARE perMedia VARCHAR(50);
	DECLARE perProf VARCHAR(50);
	DECLARE perSev VARCHAR(50);
	DECLARE perTotal VARCHAR(50);
	DECLARE totalPersonas INT;

	SET perLeve = 'Per', perMedia = 'Per', perProf = 'Per', perSev = 'Per', perTotal = 'Per';

	IF (leve) THEN
		SET perLeve = 'Perdida Auditiva Leve';
	END IF;

	IF (media) THEN
		SET perMedia = 'Perdida Auditiva Media';
	END IF;

	IF (profunda) THEN
		SET perProf = 'Perdida Auditiva Profunda';
	END IF;

	IF (severa) THEN
		SET perSev = 'Perdida Auditiva Severa';
	END IF;

	IF (total) THEN
		SET perTotal = 'Perdida Auditiva Total';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT g.grado as 'Grado', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Grado g, EsGrado es
	WHERE g.ID_grado = es.ID_grado AND g.grado IN(perLeve, perMedia, perProf, perSev, perTotal) AND es.ID_censo = censo
	GROUP BY g.grado;
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


-- Número de personas que tienen pérdida auditiva Bilateral o Unilateral por censo
DELIMITER //
CREATE PROCEDURE consultaEsPerdidaBilateralPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT bilateral AS 'Bilateral', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EsGrado WHERE ID_censo = censo
	GROUP BY bilateral;
END //
DELIMITER ;



-- Consulta de tipos de perdida: si es bilateral o unilateral con booleanos...
DELIMITER //
CREATE PROCEDURE consultaPerdidaBilateralUnilateral
(IN bilateral boolean, unilateral boolean)
BEGIN
	DECLARE totalPersonas INT;

	IF(bilateral AND !unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM Persona;
		SELECT e.bilateral as 'Bilateral',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
		FROM EsGrado e WHERE e.bilateral = 1
		GROUP BY e.bilateral;
	END IF;

	IF(!bilateral AND unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM Persona;
		SELECT e.bilateral as 'Bilateral',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
		FROM EsGrado e WHERE e.bilateral = 0
		GROUP BY e.bilateral;
	END IF;

	IF(bilateral AND unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM Persona;
		SELECT e.bilateral as 'Bilateral',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
		FROM EsGrado e
		GROUP BY e.bilateral;
	END IF;
END //
DELIMITER ;


-- Consulta de tipos de pérdida por censo: si es bilateral o unilateral con booleanos...
DELIMITER //
CREATE PROCEDURE consultaPerdidaBilateralUnilateral
(IN bilateral boolean, unilateral boolean, censo INT)
BEGIN
	DECLARE totalPersonas INT;

	IF(bilateral AND !unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
		SELECT e.bilateral AS 'Bilateral', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
		FROM EsGrado e WHERE ID_censo = censo AND e.bilateral = 1
		GROUP BY e.bilateral;
		END IF;

	IF(!bilateral AND unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
		SELECT e.bilateral AS 'Bilateral', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
		FROM EsGrado e WHERE ID_censo = censo AND e.bilateral = 0
		GROUP BY e.bilateral;
	END IF;

	IF(bilateral AND unilateral)
	THEN
		SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
		SELECT e.bilateral AS 'Bilateral', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
		FROM EsGrado e WHERE ID_censo = censo
		GROUP BY e.bilateral;
	END IF;
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

-- Numero de personas por causa de pérdida de audición por censo
DELIMITER //
CREATE PROCEDURE consultaPorCausaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT c.Causa AS 'Causa', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Causa c, Causado ca
	WHERE c.ID_causa = ca.ID_causa AND ca.ID_censo = censo
	GROUP BY c.Causa;
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


--Número de personas por tipo de pérdida de audición por censo
DELIMITER //
CREATE PROCEDURE consultaPorTipoPerdidaAuditivaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.Tipo AS 'Tipo de perdida', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM TienePerdidaAuditiva t, PerdidaAuditiva p
	WHERE p.ID_perdidaAuditiva = t.ID_perdidaAuditiva AND t.ID_censo = censo
	GROUP BY p.Tipo;
END //
DELIMITER ;


-- Numero de personas que tuvieron sordera PRELINGUISTICA
DELIMITER //
CREATE PROCEDURE consultaPerdidaPrelinguistica
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT Prelinguistica as 'PerdidaPrelinguistica', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM TienePerdidaAuditiva
	GROUP BY Prelinguistica;
END //
DELIMITER ;


-- Número de personas que tuvieron sordera prelingüistica
DELIMITER //
CREATE PROCEDURE consultaPerdidaPrelinguisticaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT Prelinguistica AS 'Perdida prelinguistica', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM TienePerdidaAuditiva WHERE ID_censo = censo
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

-- Consulta de pérdida de audición por etapas por censo
DELIMITER //
CREATE PROCEDURE consultaEtapasPerdidaAudicionPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT t.periodo AS 'Etapa', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Periodo t, Persona p, PerteneceCenso per
	WHERE t.ID_periodo = p.ID_periodo AND per.CURP = p.CURP AND per.ID_censo = censo;
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


-- Consulta de personas con discapacidad auditiva por municipio por censo...
DELIMITER //
CREATE PROCEDURE consultaPorMunicipioPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT m.nombre AS 'Municipio', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Municipio m, Vive v, Colonia c
	WHERE c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia AND v.ID_censo = censo
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

-- Número de hombres y mujeres por censo
DELIMITER //
CREATE PROCEDURE consultaHombresMujeresPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.sexo_masculino AS 'Es hombre', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, PerteneceCenso per WHERE per.CURP = p.CURP AND per.ID_censo = censo
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por estado civil...
DELIMITER //
CREATE PROCEDURE consultaPorEstadoCivil
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT e.nombre AS 'Estado civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil
	GROUP BY e.nombre;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por estado civil por censo
DELIMITER //
CREATE PROCEDURE consultaPorEstadoCivilPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT e.nombre AS 'Estado civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil AND c.ID_censo = censo
	GROUP BY e.nombre;
END //
DELIMITER ;

-- Consulta de personas con discpacidad auditiva por lengua dominante...
DELIMITER //
CREATE PROCEDURE consultaPorLenguaDominante
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante
	GROUP BY l.nombre;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por lengua dominante por censo...
DELIMITER //
CREATE PROCEDURE consultaPorLenguaDominantePorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante AND t.ID_censo = censo
	GROUP BY l.nombre;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que son mexicanas...
DELIMITER //
CREATE PROCEDURE consultaMexicanos
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT mexicano AS 'Es mexicano', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona
	GROUP BY mexicano;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que son mexicanas por censo...
DELIMITER //
CREATE PROCEDURE consultaMexicanosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.mexicano AS 'Es mexicano', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, PerteneceCenso c
	WHERE p.CURP = c.CURP AND c.ID_censo = censo
	GROUP BY p.mexicano;
END //
DELIMITER ;


-- ************************************************** Consultas de empleo ************************************************************

-- Consulta de personas con discapacidad auditiva que tienen empleo...
DELIMITER //
CREATE PROCEDURE consultaTienenEmpleo
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT tiene_empleo AS 'Tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona
	GROUP BY tiene_empleo;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que tienen empleo por censo...
DELIMITER //
CREATE PROCEDURE consultaTienenEmpleoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT tiene_empleo AS 'Tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo
	GROUP BY tiene_empleo;
END //
DELIMITER ;


-- Consulta de los que tienen empleo...
DELIMITER //
CREATE PROCEDURE consultaEmpleados
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT tiene_empleo AS 'Tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona WHERE tiene_empleo = 1
	GROUP BY tiene_empleo;
END //
DELIMITER ;


-- Consulta de los que tienen empleo por censo...
DELIMITER //
CREATE PROCEDURE consultaEmpleadosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT tiene_empleo AS 'Tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo AND tiene_empleo = 1
	GROUP BY tiene_empleo;
END //
DELIMITER ;

-- Consulta de los que no tienen empleo...
DELIMITER //
CREATE PROCEDURE consultaDesempleados
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT tiene_empleo AS 'No tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona WHERE tiene_empleo = 0
	GROUP BY tiene_empleo;
END //
DELIMITER ;

-- Consulta de los que no tienen empleo por censo...
DELIMITER //
CREATE PROCEDURE consultaDesempleadosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT tiene_empleo AS 'No tiene empleo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo AND tiene_empleo = 0
	GROUP BY tiene_empleo;
END //
DELIMITER ;


-- Consulta empleados por área de trabajo
DELIMITER //
CREATE PROCEDURE consultaEmpleadosPorAreaTrabajo
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo;
	SELECT a.nombre AS 'Area de trabajo', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM TieneEmpleo t, Empleo e, AreaTrabajo a
	WHERE e.ID_empleo = t.ID_empleo AND e.ID_areaTrabajo = a.ID_areaTrabajo
	GROUP BY a.nombre;
END //
DELIMITER ;


-- Consulta empleados por área de trabajo por censo
DELIMITER //
CREATE PROCEDURE consultaEmpleadosPorAreaTrabajoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo WHERE ID_censo = censo;
	SELECT a.nombre AS 'Area de trabajo', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM TieneEmpleo t, Empleo e, AreaTrabajo a
	WHERE e.ID_empleo = t.ID_empleo AND e.ID_areaTrabajo = a.ID_areaTrabajo AND t.ID_censo = censo
	GROUP BY a.nombre;
END //
DELIMITER ;

-- *******************************************************************************************************************************



-- Consulta de personas con discapacidad auditiva por estado...
DELIMITER //
CREATE PROCEDURE consultaPorEstado
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT es.nombre as 'Estado', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estado es, Municipio m, Vive v, Colonia c
	WHERE es.ID_estado = m.ID_estado AND c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia
	GROUP BY es.nombre;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por estado...
DELIMITER //
CREATE PROCEDURE consultaPorEstadoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT es.nombre AS 'Estado', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estado es, Municipio m, Vive v, Colonia c 
	WHERE es.ID_estado = m.ID_estado AND c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia AND v.ID_censo = censo
	GROUP BY es.nombre;

END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por nivel educativo...
DELIMITER //
CREATE PROCEDURE consultaPorNivelEducativo
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT n.nivel AS 'Nivel educativo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva por nivel educativo por censo...
DELIMITER //
CREATE PROCEDURE consultaPorNivelEducativoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND t.ID_censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que tienen educación...
DELIMITER //
CREATE PROCEDURE consultaTienenEducacion
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT * FROM(
	SELECT COUNT(*) as 'Personas sin educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje sin educacion'
	FROM Persona p
	WHERE CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t)) as Tabla1, (SELECT COUNT(*) as 'Personas con educacion',
					  (COUNT(*) / totalPersonas * 100) as 'Porcentaje con educacion' FROM Persona p
					  WHERE CURP IN (SELECT CURP FROM TieneNivelEducativo t)) as Tabla2;
END //
DELIMITER ;



-- Consulta de personas con discapacidad auditiva que tienen educación por censo...
DELIMITER //
CREATE PROCEDURE consultaTieneEducacionPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT * FROM(
		SELECT COUNT(*) as 'Personas sin educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje sin educacion'
		FROM Persona  p WHERE ID_censo = censo
		AND CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t WHERE ID_censo = censo)) as Tabla1, (SELECT COUNT(*) AS 'Personas con educacion',
		(COUNT(*) / totalPersonas * 100) as 'Porcentaje con educacion' FROM PerteneceCenso per
		WHERE ID_censo = censo
		AND CURP IN(SELECT CURP FROM TieneNivelEducativo t WHERE ID_censo = censo)) as Tabla2;
END //
DELIMITER ;



-- Consulta de personas con educacion
DELIMITER //
CREATE PROCEDURE consultaConEducacion
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT COUNT(*) as 'Personas con educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje con educacion'
	FROM Persona p
	WHERE CURP IN(SELECT CURP FROM TieneNivelEducativo t);
END //
DELIMITER ;


-- Con educación por censo...
DELIMITER //
CREATE PROCEDURE consultaConEducacionPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(*) as 'Personas con educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje con educacion'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo AND p.CURP IN(SELECT CURP FROM TieneNivelEducativo t);
END //
DELIMITER ;


-- Sin educación...
DELIMITER //
CREATE PROCEDURE consultaSinEducacion
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT COUNT(*) as 'Personas con educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje sin educacion'
	FROM Persona p
	WHERE CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t);
END //
DELIMITER ;


-- Sin educación por censo...
DELIMITER //
CREATE PROCEDURE consultaSinEducacionPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(*) as 'Personas con educacion', (COUNT(*) / totalPersonas * 100) as 'Porcentaje sin educacion'
	FROM Persona p, PerteneceCenso per
	WHERE p.CURP = per.CURP AND per.ID_censo = censo AND p.CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t);
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que tienen educación por municipio...
DELIMITER //
CREATE PROCEDURE consultaTieneEducacionPorMunicipio
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT m.nombre as 'Municipio', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Municipio m, Vive v, Colonia c
	WHERE c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia
	AND v.CURP IN (SELECT t.CURP FROM TieneNivelEducativo t)
	GROUP BY m.nombre;
END //
DELIMITER ;


-- Consulta de personas con discapacidad auditiva que tienen educación por municipio por censo
DELIMITER //
CREATE PROCEDURE consultaTieneEducacionPorMunicipioPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT m.nombre as 'Municipio', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Municipio m, Vive v, Colonia c
	WHERE c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia AND v.ID_censo = censo
	AND v.CURP IN(SELECT t.CURP FROM TieneNivelEducativo t WHERE ID_censo = censo)
	GROUP BY m.nombre;
END //
DELIMITER ;



-- ****************************************** Las consultas de Max :P *************************************************************

-- Número de personas que tienen discapacidad auditiva que estudian en institución privada
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionPrivada
()
BEGIN 
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT i.privada as 'Institucion', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND i.privada=1
	GROUP BY i.privada;
END //
DELIMITER ;


-- Número de personas que tienen discapacidad auditiva que estudian en institución privada por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionPrivadaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT i.privada AS 'Institucion', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, PerteneceCenso per
	WHERE i.ID_institucionEducativa = e.ID_institucionEducativa AND e.CURP = p.CURP AND e.CURP = per.CURP
	AND i.privada = 1 AND per.ID_censo = censo
	GROUP BY i.privada;
END //
DELIMITER ;


-- Número de personas sordas que estudian en institución especializada y utilizan LSM
DELIMITER // 
CREATE PROCEDURE consultaPersonasEspecializadaLSM
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT l.nombre as 'Lengua Dominante', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
    AND e.CURP=p.CURP
	AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND t.ID_lenguaDominante=3
	GROUP BY l.nombre;
END //
DELIMITER ;



-- Número de personas sordas que estudian en institución especializada y utilizan lengua oral
DELIMITER // 
CREATE PROCEDURE consultaPersonasEspecializadaOral
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT l.nombre as 'Lengua Dominante', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
    AND e.CURP=p.CURP
	AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND t.ID_lenguaDominante=1
	OR t.ID_lenguaDominante=2
	GROUP BY l.nombre;
END //
DELIMITER ;



-- Número de personas sordas que estudian en institución especializada de sexo masculino
-- ?????????????????????????????????????
DELIMITER //
CREATE PROCEDURE consultaPersonasEspecializadaMasculino
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT p.sexo_masculino as 'Sexo', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND p.sexo_masculino=1
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;



-- Número de personas sordas que estudian en institución especializada de sexo femenino
-- ????????????????????????????????
DELIMITER //
CREATE PROCEDURE consultaPersonasEspecializadaFemenino
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT p.sexo_masculino as 'Sexo', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND p.sexo_masculino=0
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;




-- ***************************************** Más consultas ***************************************************************

-- Consulta de personas por dominio del español...
DELIMITER //
CREATE PROCEDURE consultaPorDominioEspanol
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT n.nivel AS 'Nivel de espanol', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEspanol n, TieneNivelEspanol t 
	WHERE n.ID_nivelEspanol = t.ID_nivelEspanol
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas por dominio del español por censo..
DELIMITER //
CREATE PROCEDURE consultaPorDominioEspanolPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT n.nivel AS 'Nivel de espanol', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEspanol n, TieneNivelEspanol t
	WHERE n.ID_nivelEspanol = t.ID_nivelEspanol AND t.ID_censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas por dominio del inglés...
DELIMITER //
CREATE PROCEDURE consultaPorDominioIngles
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT n.nivel AS 'Nivel de ingles', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelIngles n, TieneNivelIngles t 
	WHERE n.ID_nivelIngles = t.ID_nivelIngles
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas por dominio del inglés por censo...
DELIMITER //
CREATE PROCEDURE consultaPorDominioInglesPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT n.nivel AS 'Nivel de ingles', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelIngles n, TieneNivelIngles t 
	WHERE n.ID_nivelIngles = t.ID_nivelIngles AND t.ID_censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas por dominio del LSM
DELIMITER //
CREATE PROCEDURE consultaPorDominioLSM
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT n.nivel AS 'Nivel de LSM', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelLSM n, TieneNivelLSM t 
	WHERE n.ID_nivelLSM = t.ID_nivelLSM
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas por dominio del LSM por censo
DELIMITER //
CREATE PROCEDURE consultaPorDominioLSMPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT n.nivel AS 'Nivel de LSM', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelLSM n, TieneNivelLSM t 
	WHERE n.ID_nivelLSM = t.ID_nivelLSM AND t.ID_censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- ******************************************** EMPLEO ************************************************

-- Consulta de lengua dominante de personas con discapacidad auditiva con empleo 
DELIMITER //
CREATE PROCEDURE consultaLenguaDominantePersonasEmpleadas
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t, TieneEmpleo e 
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante AND e.CURP = t.CURP
	GROUP BY l.nombre;
END //
DELIMITER ;


-- Consulta de lengua dominante de personas con discapacidad auditiva con empleo por censo
DELIMITER //
CREATE PROCEDURE consultaLenguaDominantePersonasEmpleadasPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo WHERE ID_censo = censo;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t, TieneEmpleo e 
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante AND e.CURP = t.CURP AND e.ID_censo = censo
	GROUP BY l.nombre;
END //
DELIMITER ;


-- Consulta de ingresos de las personas con empleo
DELIMITER //
CREATE PROCEDURE consultaIngresosPersonasEmpleadas
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo;
	SELECT s.minimo AS 'Minimo', s.maximo AS 'Maximo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM Sueldo s, Gana g, Empleo e, TieneEmpleo t 
	WHERE s.ID_sueldo = g.ID_sueldo AND g.ID_empleo = e.ID_empleo AND e.ID_empleo = t.ID_empleo
	GROUP BY s.minimo;
END //
DELIMITER ;

-- Consulta de ingresos de las personas con empleo por censo
DELIMITER //
CREATE PROCEDURE consultaIngresosPersonasEmpleadasPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo WHERE ID_censo = censo;
	SELECT s.minimo AS 'Minimo', s.maximo AS 'Maximo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM Sueldo s, Gana g, Empleo e, TieneEmpleo t 
	WHERE s.ID_sueldo = g.ID_sueldo AND g.ID_empleo = e.ID_empleo AND e.ID_empleo = t.ID_empleo AND t.ID_censo = censo
	GROUP BY s.minimo;
END //
DELIMITER ;


-- Consulta de personas que tienen empleo por sexo
DELIMITER //
CREATE PROCEDURE consultaEmpleadosPorSexo
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo;
	SELECT p.sexo_masculino AS 'Es hombre', COUNT(e.CURP) AS 'No. de Personas', (COUNT(e.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, TieneEmpleo e
	WHERE p.CURP = e.CURP AND p.CURP IN(SELECT e.CURP FROM TieneEmpleo e)
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;


-- Consulta de personas que tienen empleo por sexo por censo
DELIMITER //
CREATE PROCEDURE consultaEmpleadosPorSexoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneEmpleo WHERE ID_censo = censo;
	SELECT p.sexo_masculino AS 'Es hombre', COUNT(e.CURP) AS 'No. de Personas', (COUNT(e.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM Persona p, TieneEmpleo e
	WHERE p.CURP = e.CURP AND e.ID_censo = censo AND p.CURP IN (SELECT e.CURP FROM TieneEmpleo e WHERE e.ID_censo = censo)
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;


-- Número de personas con discapacidad auditiva por censo...
DELIMITER //
CREATE PROCEDURE consultaPersonasPorCenso
()
BEGIN
	SELECT ID_censo, COUNT(*) AS 'No. de Personas' FROM PerteneceCenso
	GROUP BY ID_censo; 
END //
DELIMITER ;

-- Consulta personas que tienen licenciatura o ingeniería
DELIMITER //
CREATE PROCEDURE consultaPersonasConLicenciatura
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 6
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta personas que tienen licenciatura o ingeniería por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasConLicenciaturaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo WHERE ID_Censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 6 AND t.ID_Censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta personas que tienen especialidad
DELIMITER //
CREATE PROCEDURE consultaPersonasConEspecialidad
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 7
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta personas que tienen especialidad por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasConEspecialidadPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo WHERE ID_Censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 7 AND t.ID_Censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;

-- Consulta personas que tienen maestría
DELIMITER //
CREATE PROCEDURE consultaPersonasConMaestria
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 8
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta personas que tienen maestría por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasConMaestriaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo WHERE ID_Censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 8 AND t.ID_Censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;

-- Consulta personas que tienen doctorado
DELIMITER //
CREATE PROCEDURE consultaPersonasConDoctorado
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 9
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta personas que tienen maestría por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasConDoctoradoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM TieneNivelEducativo WHERE ID_Censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.ID_nivelEducativo = 9 AND t.ID_Censo = censo
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta de personas con y sin hijos
DELIMITER //
CREATE PROCEDURE consultaHijos
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
    SELECT * FROM (
		SELECT COUNT(*) AS 'Personas con hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
		FROM Persona p
		WHERE p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h)) AS tablaUno,
			(SELECT COUNT(*) AS 'Personas sin hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
			FROM Persona p WHERE p.CURP NOT IN(SELECT DISTINCT h.CURP FROM Hijo h)) AS tablaDos;
END //
DELIMITER ;


-- ***************************************** Consultas de hijos ***************************************************************

-- Consulta de personas con y sin hijos por censo
DELIMITER //
CREATE PROCEDURE consultaHijosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT * FROM (
		SELECT COUNT(*) AS 'Personas con hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
		FROM Persona p, PerteneceCenso per
		WHERE p.CURP = per.CURP AND per.ID_censo = censo
		AND p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h)) AS tablaUno,
			(SELECT COUNT(*) AS 'Personas sin hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje sin hijos'
				FROM Persona p, PerteneceCenso per
				WHERE p.CURP = per.CURP AND per.ID_censo = censo
				AND p.CURP NOT IN (SELECT DISTINCT h.CURP FROM Hijo h)) AS TablaDos;
END //
DELIMITER ;


-- Consulta personas con hijos por censo
DELIMITER //
CREATE PROCEDURE consultaConHijosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(p.CURP) AS 'Personas con hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p, PerteneceCenso per WHERE p.CURP = per.CURP AND per.ID_censo = censo
		AND p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h);
END //
DELIMITER ;

-- Consulta personas con hijos
DELIMITER //
CREATE PROCEDURE consultaConHijos
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT COUNT(p.CURP) AS 'Personas con hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p WHERE p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h);
END //
DELIMITER ;

-- Consulta con hijos que son sordos
DELIMITER //
CREATE PROCEDURE consultaConHijosSordos
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT COUNT(p.CURP) AS 'Personas con hijos sordos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p WHERE p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h WHERE h.sordo = 1);
END //
DELIMITER ;

-- Consulta con hijos que son sordos por censo
DELIMITER //
CREATE PROCEDURE consultaConHijosSordosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(p.CURP) AS 'Personas con hijos sordos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p, PerteneceCenso per WHERE p.CURP = per.CURP AND per.ID_censo = censo
		AND p.CURP IN (SELECT DISTINCT h.CURP FROM Hijo h WHERE h.sordo = 0);
END //
DELIMITER ;

-- Consulta sin hijos
DELIMITER //
CREATE PROCEDURE consultaSinHijos
()
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT COUNT(p.CURP) AS 'Personas sin hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p WHERE p.CURP NOT IN (SELECT DISTINCT h.CURP FROM Hijo h);
END //
DELIMITER ;

-- Consulta sin hijos por censo
DELIMITER //
CREATE PROCEDURE consultaSinHijosPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT COUNT(p.CURP) AS 'Personas sin hijos', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje con hijos'
	FROM Persona p, PerteneceCenso per WHERE p.CURP = per.CURP AND per.ID_censo = censo
		AND p.CURP NOT IN (SELECT DISTINCT h.CURP FROM Hijo h);
END //
DELIMITER ;

-- *************************************************************************************************************************

-- Consulta por cada estado civil
DELIMITER //
CREATE PROCEDURE consultaPorCadaEstadoCivil
(IN soltero boolean, casado boolean, divorciado boolean, viudo boolean)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE estadoSoltero VARCHAR(50);
	DECLARE estadoCasado VARCHAR(50);
	DECLARE estadoDivorciado VARCHAR(50);
	DECLARE estadoViudo VARCHAR(50);

	SET estadoSoltero = ' ', estadoCasado = ' ', estadoDivorciado = ' ', estadoViudo = ' ';

	IF (soltero)
	THEN
		SET estadoSoltero = 'Soltero(a)';
	END IF;

	IF (casado)
	THEN
		SET estadoCasado = 'Casado(a)';
	END IF;

	IF (divorciado)
	THEN
		SET estadoDivorciado = 'Divorciado(a)';
	END IF;

	IF (viudo)
	THEN
		SET estadoViudo = 'Viudo(a)';
	END IF;


	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT e.nombre AS 'Estado civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil AND e.nombre IN(estadoSoltero, estadoCasado, estadoDivorciado, estadoViudo)
	GROUP BY e.nombre;
END //
DELIMITER ;


-- Consulta por cada estado civil por censo
DELIMITER //
CREATE PROCEDURE consultaPorCadaEstadoCivilPorCenso
(IN soltero boolean, casado boolean, divorciado boolean, viudo boolean, censo INT)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE estadoSoltero VARCHAR(50);
	DECLARE estadoCasado VARCHAR(50);
	DECLARE estadoDivorciado VARCHAR(50);
	DECLARE estadoViudo VARCHAR(50);

	SET estadoSoltero = ' ', estadoCasado = ' ', estadoDivorciado = ' ', estadoViudo = ' ';

	IF (soltero)
	THEN
		SET estadoSoltero = 'Soltero(a)';
	END IF;

	IF (casado)
	THEN
		SET estadoCasado = 'Casado(a)';
	END IF;

	IF (divorciado)
	THEN
		SET estadoDivorciado = 'Divorciado(a)';
	END IF;

	IF (viudo)
	THEN
		SET estadoViudo = 'Viudo(a)';
	END IF;


	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT e.nombre AS 'Estado civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil AND c.ID_censo = censo AND e.nombre IN (estadoSoltero, estadoCasado, estadoDivorciado, estadoViudo)
	GROUP BY e.nombre;
END //
DELIMITER ;


-- Consulta por cada tipo de pérdida de audición...
DELIMITER //
CREATE PROCEDURE consultaPorCadaTipoPerdidaAuditiva
(IN conductiva boolean, neurosensorial boolean, mixta boolean, retrococlear boolean, noSe boolean)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE perdidaConduct VARCHAR(50);
	DECLARE perdidaNeuro VARCHAR(50);
	DECLARE perdidaMixta VARCHAR(50);
	DECLARE perdidaRetro VARCHAR(50);
	DECLARE perdidaNoSe VARCHAR(50);

	SET perdidaConduct = ' ', perdidaNeuro = ' ', perdidaMixta = ' ', perdidaRetro = ' ', perdidaNoSe = ' ';

	IF (conductiva)
	THEN
		SET perdidaConduct = 'Conductiva';
	END IF;

	IF (neurosensorial)
	THEN
		SET perdidaNeuro = 'Neurosensorial';
	END IF;

	IF (mixta)
	THEN
		SET perdidaMixta = 'Mixta';
	END IF;

	IF (retrococlear)
	THEN
		SET perdidaRetro = 'Retrococlear';
	END IF;

	IF (noSe)
	THEN
		SET perdidaNoSe = 'No lo se';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT tipo as 'Tipo de perdida', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM TienePerdidaAuditiva t, PerdidaAuditiva p
	WHERE p.ID_perdidaAuditiva = t.ID_perdidaAuditiva AND p.tipo IN (perdidaConduct, perdidaNeuro, perdidaMixta, perdidaRetro, perdidaNoSe)
	GROUP BY tipo;

END //
DELIMITER ;


-- Consulta por cada tipo de pérdida auditiva por censo
DELIMITER //
CREATE PROCEDURE consultaPorCadaTipoPerdidaAuditivaPorCenso
(IN conductiva boolean, neurosensorial boolean, mixta boolean, retrococlear boolean, noSe boolean, censo INT)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE perdidaConduct VARCHAR(50);
	DECLARE perdidaNeuro VARCHAR(50);
	DECLARE perdidaMixta VARCHAR(50);
	DECLARE perdidaRetro VARCHAR(50);
	DECLARE perdidaNoSe VARCHAR(50);

	SET perdidaConduct = ' ', perdidaNeuro = ' ', perdidaMixta = ' ', perdidaRetro = ' ', perdidaNoSe = ' ';

	IF (conductiva)
	THEN
		SET perdidaConduct = 'Conductiva';
	END IF;

	IF (neurosensorial)
	THEN
		SET perdidaNeuro = 'Neurosensorial';
	END IF;

	IF (mixta)
	THEN
		SET perdidaMixta = 'Mixta';
	END IF;

	IF (retrococlear)
	THEN
		SET perdidaRetro = 'Retrococlear';
	END IF;

	IF (noSe)
	THEN
		SET perdidaNoSe = 'No lo se';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT p.Tipo AS 'Tipo de perdida', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM TienePerdidaAuditiva t, PerdidaAuditiva p
	WHERE p.ID_perdidaAuditiva = t.ID_perdidaAuditiva AND t.ID_censo = censo AND p.tipo IN (perdidaConduct, perdidaNeuro, perdidaMixta, perdidaRetro, perdidaNoSe)
	GROUP BY p.Tipo;

END //
DELIMITER ;


-- ************************************************ Consultas de edades **************************************************************


-- Consulta que muestra cuantos niños(de 0 a 10 years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadNinos
()
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	GROUP BY Edad
	HAVING Edad >= 0 AND Edad <= 10;
END //
DELIMITER ;

-- Consulta que muestra cuantos niños(de 0 a 10 years) estan registrados en un censo determinado
DELIMITER //
CREATE PROCEDURE consultaEdadNinosPorCenso
(IN censo NUMERIC(4))
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	WHERE ID_censo = censo
	GROUP BY Edad
	HAVING Edad >= 0 AND Edad <= 10;
END //
DELIMITER ;


-- Consulta que muestra cuantos adolescentes(de 11 a 20 years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadAdolescentes
()
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	GROUP BY Edad
	HAVING Edad > 10 AND Edad <= 20;
END //
DELIMITER ;

-- Consulta que muestra cuantos adolescentes(de 11 a 20 years) estan registrados en un censo determinado
DELIMITER //
CREATE PROCEDURE consultaEdadAdolescentesPorCenso
(IN censo NUMERIC(4))
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	WHERE ID_censo = censo
	GROUP BY Edad
	HAVING Edad > 10 AND Edad <= 20;
END //
DELIMITER ;

-- Consulta que muestra cuantos adultos jovenes (21 a 40 years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadAdultosJovenes
()
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	GROUP BY Edad
	HAVING Edad > 20 AND Edad <= 40;
END //
DELIMITER ;

-- Consulta que muestra cuantos adultos jovenes (21 a 40 years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadAdultosJovenesPorCenso
(IN censo NUMERIC(4))
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	WHERE ID_censo = censo
	GROUP BY Edad
	HAVING Edad > 20 AND Edad <= 40;
END //
DELIMITER ;


-- Consulta que muestra cuantos adultos mayores (41 a 60 years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadAdultosMayores
()
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	GROUP BY Edad
	HAVING Edad > 40 AND Edad <= 60;
END //
DELIMITER ;

-- Consulta que muestra cuantos adultos mayores (41 a 60 years) estan registrados en un censo en especifico
DELIMITER //
CREATE PROCEDURE consultaEdadAdultosMayoresPorCenso
(IN censo NUMERIC(4))
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	WHERE ID_censo = censo
	GROUP BY Edad
	HAVING Edad > 40 AND Edad <= 60;
END //
DELIMITER ;


-- Consulta que muestra cuantos ancianos ( 60 a + years) estan registrados en todos los censos
DELIMITER //
CREATE PROCEDURE consultaEdadAncianos
()
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	GROUP BY Edad
	HAVING Edad > 60;
END //
DELIMITER ;

-- Consulta que muestra cuantos ancianos(60 a + years) estan registrados en un censo en especifico
DELIMITER //
CREATE PROCEDURE consultaEdadAncianosPorCenso
(IN censo NUMERIC(4))
BEGIN	
	SELECT YEAR(CURDATE()) - YEAR(fecha_nacimiento) as 'Edad', COUNT(*) as 'No.Personas'
	FROM Persona
	WHERE ID_censo = censo
	GROUP BY Edad
	HAVING Edad > 60;
END //
DELIMITER ;


-- ******************************************************************************************************************************************

-- Consulta por cada nivel educativo
DELIMITER //
CREATE PROCEDURE consultaPorCadaNivelEducativo
(IN preescolar boolean, primaria boolean, secundaria boolean, prepa boolean, tecnica boolean,
	licenciatura boolean, especialidad boolean, maestria boolean, doctorado boolean)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE nivelPrees VARCHAR(50);
	DECLARE nivelPrim VARCHAR(50);
	DECLARE nivelSec VARCHAR(50);
	DECLARE nivelPrepa VARCHAR(50);
	DECLARE nivelTecnica VARCHAR(50);
	DECLARE nivelLic VARCHAR(50);
	DECLARE nivelEsp VARCHAR(50);
	DECLARE nivelMaes VARCHAR(50);
	DECLARE nivelDocto VARCHAR(50);

	SET nivelPrees = ' ', nivelPrim = ' ', nivelSec = ' ', nivelPrepa = ' ', nivelTecnica = ' ', nivelLic = ' ', nivelEsp = ' ', nivelMaes = ' ', nivelDocto = ' ';

	IF(preescolar)
	THEN
		SET nivelPrees = 'Preescolar';
	END IF;

	IF(primaria)
	THEN
		SET nivelPrim = 'Primaria';
	END IF;

	IF(secundaria)
	THEN
		SET nivelSec = 'Secundaria';
	END IF;

	IF(prepa)
	THEN
		SET nivelPrepa = 'Preparatoria';
	END IF;

	IF(tecnica)
	THEN
		SET nivelTecnica = 'Carrera tecnica';
	END IF;

	IF(licenciatura)
		THEN SET nivelLic = 'Licenciatura';
	END IF;

	IF(especialidad)
		THEN SET nivelEsp = 'Especialidad';
	END IF;

	IF(maestria)
		THEN SET nivelMaes = 'Maestria';
	END IF;

	IF(doctorado)
		THEN SET nivelDocto = 'Doctorado';
	END IF;


	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT n.nivel AS 'Nivel educativo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND n.nivel IN (nivelPrees, nivelPrim, nivelSec, nivelPrepa, nivelTecnica,
																	nivelLic, nivelEsp, nivelMaes, nivelDocto)
	GROUP BY n.nivel;
END //
DELIMITER ;



-- Consulta por cada nivel educativo por censo...
DELIMITER //
CREATE PROCEDURE consultaPorCadaNivelEducativoPorCenso
(IN preescolar boolean, primaria boolean, secundaria boolean, prepa boolean, tecnica boolean,
	licenciatura boolean, especialidad boolean, maestria boolean, doctorado boolean, censo INT)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE nivelPrees VARCHAR(50);
	DECLARE nivelPrim VARCHAR(50);
	DECLARE nivelSec VARCHAR(50);
	DECLARE nivelPrepa VARCHAR(50);
	DECLARE nivelTecnica VARCHAR(50);
	DECLARE nivelLic VARCHAR(50);
	DECLARE nivelEsp VARCHAR(50);
	DECLARE nivelMaes VARCHAR(50);
	DECLARE nivelDocto VARCHAR(50);

	SET nivelPrees = ' ', nivelPrim = ' ', nivelSec = ' ', nivelPrepa = ' ', nivelTecnica = ' ', nivelLic = ' ', nivelEsp = ' ', nivelMaes = ' ', nivelDocto = ' ';

	IF(preescolar)
	THEN
		SET nivelPrees = 'Preescolar';
	END IF;

	IF(primaria)
	THEN
		SET nivelPrim = 'Primaria';
	END IF;

	IF(secundaria)
	THEN
		SET nivelSec = 'Secundaria';
	END IF;

	IF(prepa)
	THEN
		SET nivelPrepa = 'Preparatoria';
	END IF;

	IF(tecnica)
	THEN
		SET nivelTecnica = 'Carrera tecnica';
	END IF;

	IF(licenciatura)
		THEN SET nivelLic = 'Licenciatura';
	END IF;

	IF(especialidad)
		THEN SET nivelEsp = 'Especialidad';
	END IF;

	IF(maestria)
		THEN SET nivelMaes = 'Maestria';
	END IF;

	IF(doctorado)
		THEN SET nivelDocto = 'Doctorado';
	END IF;


	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT n.nivel AS 'Nivel educativo', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM NivelEducativo n, TieneNivelEducativo t
	WHERE n.ID_nivelEducativo = t.ID_nivelEducativo AND t.ID_censo = censo
	AND n.nivel IN (nivelPrees, nivelPrim, nivelSec, nivelPrepa, nivelTecnica, nivelLic, nivelEsp, nivelMaes, nivelDocto)
	GROUP BY n.nivel;
END //
DELIMITER ;


-- Consulta por cada lengua dominante...
DELIMITER //
CREATE PROCEDURE consultaPorCadaLenguaDominante
(IN espanol boolean, ingles boolean, LSM boolean, LSEUA boolean)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE lenguaEsp VARCHAR(50);
	DECLARE lenguaIng VARCHAR(50);
	DECLARE lenguaLSM VARCHAR(50);
	DECLARE lenguaLSEUA VARCHAR(50);

	IF(espanol)
	THEN
		SET lenguaEsp = 'Espanol';
	END IF;

	IF(ingles)
	THEN
		SET lenguaIng = 'Ingles';
	END IF;

	IF(LSM)
	THEN
		SET lenguaLSM = 'Lengua de Senas Mexicana';
	END IF;

	IF(LSEUA)
	THEN
		SET lenguaLSEUA = 'Lengua de Senas EUA';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM Persona;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante AND l.nombre IN(lenguaEsp, lenguaIng, lenguaLSM, lenguaLSEUA)
	GROUP BY l.nombre;

END //
DELIMITER ; 


-- Consulta por cada lengua dominante por censo...
DELIMITER //
CREATE PROCEDURE consultaPorCadaLenguaDominantePorCenso
(IN espanol boolean, ingles boolean, LSM boolean, LSEUA boolean, censo INT)
BEGIN
	DECLARE totalPersonas INT;
	DECLARE lenguaEsp VARCHAR(50);
	DECLARE lenguaIng VARCHAR(50);
	DECLARE lenguaLSM VARCHAR(50);
	DECLARE lenguaLSEUA VARCHAR(50);

	IF(espanol)
	THEN
		SET lenguaEsp = 'Espanol';
	END IF;

	IF(ingles)
	THEN
		SET lenguaIng = 'Ingles';
	END IF;

	IF(LSM)
	THEN
		SET lenguaLSM = 'Lengua de Senas Mexicana';
	END IF;

	IF(LSEUA)
	THEN
		SET lenguaLSEUA = 'Lengua de Senas EUA';
	END IF;

	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT l.nombre AS 'Lengua dominante', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM LenguaDominante l, TieneLenguaDominante t
	WHERE l.ID_lenguaDominante = t.ID_lenguaDominante AND t.ID_censo = censo AND l.nombre IN(lenguaEsp, lenguaIng, lenguaLSM, lenguaLSEUA)
	GROUP BY l.nombre;

END //
DELIMITER ; 



-- *********************************************** Consultas de Max ************************************************************

-- Número de personas que tienen discapacidad auditiva que estudian en institución privada por censo.
-- ?????????????????????????????????????????
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionPrivadaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso
	WHERE ID_censo = censo;
	SELECT i.privada AS 'Institucion', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, PerteneceCenso per
	WHERE i.ID_institucionEducativa = e.ID_institucionEducativa
	AND e.CURP = p.CURP
	AND e.CURP = per.CURP
	AND i.privada = 1
	AND per.ID_censo = censo
	GROUP BY i.privada;
END //
DELIMITER ;

-- Número de personas sordas que estudian en institución especializada y utilizan LSM por censo
-- ??????????????????????????????????????????????
DELIMITER // 
CREATE PROCEDURE consultaPersonasEspecializadaLSMPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso
	WHERE ID_censo = censo;
	SELECT l.nombre as 'Lengua Dominante', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l, PerteneceCenso per
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa AND e.CURP=p.CURP AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND t.ID_lenguaDominante=3
	AND per.ID_censo = censo
	GROUP BY l.nombre;
END //
DELIMITER ;

-- Número de personas sordas que estudian en institución especializada y utilizan lengua oral por censo
-- ????????????????????????????????????????
DELIMITER // 
CREATE PROCEDURE consultaPersonasEspecializadaOralPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso
	WHERE ID_censo = censo;
	SELECT l.nombre as 'Lengua Dominante', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l, PerteneceCenso per
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa AND e.CURP=p.CURP AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND t.ID_lenguaDominante=1
	OR t.ID_lenguaDominante=2
	AND per.ID_censo = censo
	GROUP BY l.nombre;
END //
DELIMITER ;



-- Número de personas sordas que estudian en institución especializada de sexo masculino por censo
-- ???????????????????????????????????????????????????
DELIMITER //
CREATE PROCEDURE consultaPersonasEspecializadaMasculinoPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso;
	SELECT p.sexo_masculino as 'Sexo', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, TieneLenguaDominante t, LenguaDominante l, PerteneceCenso per
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND p.CURP=t.CURP
	AND t.ID_lenguaDominante=l.ID_lenguaDominante
	AND i.especializada=1
	AND p.sexo_masculino=1
	AND per.ID_censo = censo
	GROUP BY p.sexo_masculino;
END //
DELIMITER ;


-- ***************************************************** Más consultas *****************************************************

-- Consulta de personas que estudian / estudiaron en institución pública
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionPublica
()
BEGIN 
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT i.privada as 'Institucion', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND i.privada=0
	GROUP BY i.privada;
END //
DELIMITER ;


-- Número de personas que tienen discapacidad auditiva que estudian en institución privada por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionPublicaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT i.privada AS 'Institucion', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, PerteneceCenso per
	WHERE i.ID_institucionEducativa = e.ID_institucionEducativa AND e.CURP = p.CURP AND e.CURP = per.CURP
	AND i.privada = 0 AND per.ID_censo = censo
	GROUP BY i.privada;
END //
DELIMITER ;



-- Consulta de personas que estudian / estudiaron en institución especializada
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionEspecializada
()
BEGIN 
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT i.especializada as 'Institucion', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND i.especializada=1
	GROUP BY i.especializada;
END //
DELIMITER ;



-- Consulta de personas que estudian / estudiaron en institución especializada por censo
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionEspecializadaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT i.especializada AS 'Institucion', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, PerteneceCenso per
	WHERE i.ID_institucionEducativa = e.ID_institucionEducativa AND e.CURP = p.CURP AND e.CURP = per.CURP
	AND i.especializada = 1 AND per.ID_censo = censo
	GROUP BY i.especializada;
END //
DELIMITER ;


-- Consulta de personas que estudian / estudiaron en una institución no especializada
DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionNoEspecializada
()
BEGIN 
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM Persona p;
	SELECT i.especializada as 'Institucion', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa
	AND e.CURP=p.CURP
	AND i.especializada=0
	GROUP BY i.especializada;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE consultaPersonasInstitucionNoEspecializadaPorCenso
(IN censo INT)
BEGIN
	DECLARE totalPersonas INT;
	SELECT COUNT(*) INTO totalPersonas FROM PerteneceCenso WHERE ID_censo = censo;
	SELECT i.especializada AS 'Institucion', COUNT(*) AS 'No. de personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estudiado e, InstitucionEducativa i, Persona p, PerteneceCenso per
	WHERE i.ID_institucionEducativa = e.ID_institucionEducativa AND e.CURP = p.CURP AND e.CURP = per.CURP
	AND i.especializada = 1 AND per.ID_censo = censo
	GROUP BY i.especializada;
END //
DELIMITER ;

