DELIMITER //
CREATE PROCEDURE 

-- Numero de personas
SELECT COUNT(*)
FROM Persona p

-- SALUD **************************************************************************************************


			-- AUXILIARES AUDITIVOS

 -- Numero de personas que usan determinada marca
 -- ?????????????????????????
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
-- ?????????????????????????????????????
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
	GROUP BY enfermedad;
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
 -- ?????????????????????????????????????????????
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


-- Numero de personas que tienen Perdida Auditiva BILATERAL o Unilateral
-- ?????????????????????????
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
-- ??????????????????????????????
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
	SELECT e.nombre AS 'Estado civil', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM EstadoCivil e, TieneEstadoCivil c
	WHERE c.ID_estadoCivil = e.ID_estadoCivil
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


-- Consulta de personas con discapacidad auditiva que son mexicanas...
-- ???????????????????????
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
	SELECT e.nombre as 'Estado', COUNT(*) AS 'No. de Personas', (COUNT(*) / totalPersonas * 100) AS 'Porcentaje'
	FROM Estado es, Municipio m, Vive v, Colonia c
	WHERE es.ID_estado = m.ID_estado AND c.ID_municipio = m.ID_municipio AND c.ID_colonia = v.ID_colonia
	GROUP BY m.nombre;
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
	AND v.CURP IN (SELECT t.CURP FROM TieneNivelEducativo t);
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

	FROM estudiado e, institucioneducativa i, persona p
	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa

	AND e.CURP=p.CURP

	AND i.privada=1

	GROUP BY i.privada;

END //

DELIMITER;

-- Número de personas sordas que estudian en institución especializada y utilizan LSM

DELIMITER // 
CREATE PROCEDURE consultaPersonasEspecializadaLSM

()

BEGIN
	DECLARE totalPersonas INT;

	SELECT COUNT(*) INTO totalPersonas FROM Persona p;

	SELECT l.nombre as 'Lengua Dominante', COUNT(*) as 'No. de personas', (COUNT(*) / totalPersonas * 100) as 'Porcentaje'

	FROM estudiado e, institucioneducativa i, persona p, tienelenguadominante t, lenguadominante l
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

	FROM estudiado e, institucioneducativa i, persona p, tienelenguadominante t, lenguadominante l
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

	FROM estudiado e, institucioneducativa i, persona p, tienelenguadominante t, lenguadominante l

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

	FROM estudiado e, institucioneducativa i, persona p, tienelenguadominante t, lenguadominante l

	WHERE i.ID_institucionEducativa=e.ID_institucionEducativa

	AND e.CURP=p.CURP

	AND p.CURP=t.CURP

	AND t.ID_lenguaDominante=l.ID_lenguaDominante

	AND i.especializada=1

	AND p.sexo_masculino=0
	GROUP BY p.sexo_masculino;

END //

DELIMITER ;