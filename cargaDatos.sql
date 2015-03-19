--Carga de PERIODO
BULK INSERT BDequipo4.BDequipo4.[Periodo]
	FROM 'e:\wwwroot\BDequipo4\periodo.csv'
	WITH
	(			
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,		
		FIELDTERMINATOR = ',',		
		ROWTERMINATOR = '\n'		
	)

--Carga de ESTADO
BULK INSERT BDequipo4.BDequipo4.[Estado]
	FROM FROM 'e:\wwwroot\BDequipo4\Estado.csv'
	WITH
	(			
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,		
		FIELDTERMINATOR = ',',		
		ROWTERMINATOR = '\n'		
	)

--carga de INSTITUCIONEDUCATIVA
BULK INSERT BDequipo4.BDequipo4.[InstitucionEducativa]
	FROM 'e:\wwwroot\BDequipo4\InstitucionEducativa.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)

--Carga LENGUADOMINANTE
BULK INSERT BDequipo4.BDequipo4.[LenguaDominante]
	FROM 'e:\wwwroot\BDequipo4\LenguaDominante.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)

--Carga NIVELINGLES
BULK INSERT BDequipo4.BDequipo4.[NivelIngles]
	FROM 'e:\wwwroot\BDequipo4\NivelIngles.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)

--Carga NIVELESPANOL
BULK INSERT BDequipo4.BDequipo4.[NivelEspanol]
	FROM 'e:\wwwroot\BDequipo4\NivelEspanol.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)

--Carga NIVELLSM
BULK INSERT BDequipo4.BDequipo4.[NivelLSM]
	FROM 'e:\wwwroot\BDequipo4\NivelLSM.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)

--Carga ESTADOCIVIL
BULK INSERT BDequipo4.BDequipo4.[EstadoCivil]
	FROM 'e:\wwwroot\BDequipo4\EstadoCivil.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)


BULK INSERT BDequipo4.Bdequipo4.[NivelEducativo]
	FROM 'e:\wwwroot\BDequipo4\NivelEducativo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)


	
BULK INSERT BDequipo4.BDequipo4.[PerdidaAuditiva]
	FROM 'e:\wwwroot\BDequipo4\PerdidaAuditiva.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)



BULK INSERT BDequipo4.BDequipo4.[Grado]
	FROM 'e:\wwwroot\BDequipo4\grado.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
	
	

	
	


BULK INSERT BDequipo4.BDequipo4.[NivelLSM]
	FROM 'e:\wwwroot\BDequipo4\NivelLSM.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
	
	
BULK INSERT BDequipo4.BDequipo4.[AparatoAuditivo]
	FROM 'e:\wwwroot\BDequipo4\AparatoAuditivo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)



BULK INSERT BDequipo4.BDequipo4.[AreaTrabajo]
	FROM 'e:\wwwroot\BDequipo4\AreaTrabajo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)


BULK INSERT BDequipo4.BDequipo4.[Empleo]
 	FROM 'e:\wwwroot\BDequipo4\Empleo.csv'
 	WITH
 	(
 		CHECK_CONSTRAINTS,
 		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
 	)
	
BULK INSERT BDequipo4.BDequipo4.[Causa]
	FROM 'e:\wwwroot\BDequipo4\Causa.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
	

	
	
	
BULK INSERT BDequipo4.BDequipo4.[Marca]
	FROM 'e:\wwwroot\BDequipo4\Marca.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
	
SET DATEFORMAT dmy	
BULK INSERT BDequipo4.BDequipo4.[Persona]
	FROM 'e:\wwwroot\BDequipo4\Persona.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
