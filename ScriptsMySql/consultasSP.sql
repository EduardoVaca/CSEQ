DELIMITER //
CREATE PROCEDURE 

-- Numero de personas
SELECT COUNT(*)
FROM Persona p

-- SALUD **************************************************************************************************
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


-- Numero de personas que no tienen Auxiliar auditivo
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

-- Numero de personas que Si tienen Auxiliar auditivo
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


-- Numero de hombres y mujeres
DELIMITER // 
CREATE PROCEDURE consultaHombresMujeres
()
BEGIN 
	SELECT sexo_masculino as EsHombre, COUNT(*) as Total FROM Persona 
	GROUP BY sexo_masculino;
END //
DELIMITER ;

-- Numero de personas que tienen