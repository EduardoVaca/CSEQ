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
	SELECT enfermedad as 'TienenEnfermedad', COUNT(*) as 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
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
	SELECT alergia as 'TienenAlergia', COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
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
	SELECT examen_audiometria AS 'HanRealizadoExamenAudiometria',  COUNT(*) AS 'Total', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'
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
	SELECT COUNT(*) as 'Personas sin educación', (COUNT(*) / totalPersonas * 100) as 'Porcentaje Sin'
	FROM Persona p
	WHERE CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t)) as Tabla1, (SELECT COUNT(*) as 'Personas con educación',
					  (COUNT(*) / totalPersonas * 100) as 'Porcentaje Con' FROM Persona p
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
		SELECT COUNT(*) as 'Personas sin educación', (COUNT(*) / totalPersonas * 100) as 'Porcentaje Sin'
		FROM Persona  p WHERE ID_censo = censo
		AND CURP NOT IN(SELECT CURP FROM TieneNivelEducativo t WHERE ID_censo = censo)) as Tabla1, (SELECT COUNT(*) AS 'Personas con educación',
		(COUNT(*) / totalPersonas * 100) as 'Porcentaje Con' FROM PerteneceCenso per
		WHERE ID_censo = censo
		AND CURP IN(SELECT CURP FROM TieneNivelEducativo t WHERE ID_censo = censo)) as Tabla2;
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
DELIMITER;


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
DELIMITER;



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
DELIMITER;



-- Número de personas sordas que estudian en institución especializada de sexo masculino
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
	SELECT n.nivel AS 'Nivel de español', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
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
	SELECT n.nivel AS 'Nivel de español', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
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
	SELECT n.nivel AS 'Nivel de inglés', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
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
	SELECT n.nivel AS 'Nivel de inglés', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
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
	SELECT s.minimo AS 'Mínimo', s.maximo AS 'Máximo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
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
	SELECT s.minimo AS 'Mínimo', s.maximo AS 'Máximo', COUNT(t.CURP) AS 'No. de Personas', (COUNT(t.CURP) / totalPersonas * 100) AS 'Porcentaje'
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