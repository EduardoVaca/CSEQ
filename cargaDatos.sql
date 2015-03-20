--CARGA DE DATOS

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
GO

--Carga PERSONA	
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
GO

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
GO	

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
GO	

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
GO	

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
GO	

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
GO	

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
GO	

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
GO	

--Carga CENSO
BULK INSERT BDequipo4.BDequipo4.[Censo]
	FROM 'e:\wwwroot\BDequipo4\Censo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga MARCA
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
GO	

--Carga HIJO
BULK INSERT BDequipo4.BDequipo4.[Hijo]
	FROM 'e:\wwwroot\BDequipo4\Hijo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga GRADO
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
GO	

--Carga CAUSA
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
GO	

--Carga SUELDO
BULK INSERT BDequipo4.BDequipo4.[Sueldo]
	FROM 'e:\wwwroot\BDequipo4\Sueldo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga AREATRABAJO
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
GO	

--Carga MUNICIPIO
BULK INSERT BDequipo4.BDequipo4.[Municipio]
	FROM 'e:\wwwroot\BDequipo4\Municipio.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga DELEGACION
BULK INSERT BDequipo4.BDequipo4.[Delegacion]
	FROM 'e:\wwwroot\BDequipo4\Delegacion.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga COLONIA
BULK INSERT BDequipo4.BDequipo4.[Colonia]
	FROM 'e:\wwwroot\BDequipo4\Colonia.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga Vive
BULK INSERT BDequipo4.BDequipo4.[Vive]
	FROM 'e:\wwwroot\BDequipo4\Vive.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO


--Carga LOCALIZAINSTITUCIONEDUCATIVA
BULK INSERT BDequipo4.BDequipo4.[LocalizaInstitucionEducativa]
	FROM 'e:\wwwroot\BDequipo4\LocalizaInstitucionEducativa.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga NIVELEDUCATIVO
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
GO	

--Carga ESTUDIADO
BULK INSERT BDequipo4.Bdequipo4.[Estudiado]
	FROM 'e:\wwwroot\BDequipo4\Estudiado.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga TIENENIVELEDUCATIVO
BULK INSERT BDequipo4.Bdequipo4.[TieneNivelEducativo]
	FROM 'e:\wwwroot\BDequipo4\TieneNivelEducativo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga TIENELENGUADOMINANTE
BULK INSERT BDequipo4.Bdequipo4.[TieneLenguaDominante]
	FROM 'e:\wwwroot\BDequipo4\TieneLenguaDominante.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENENIVELINLGES
BULK INSERT BDequipo4.Bdequipo4.[TieneNivelIngles]
	FROM 'e:\wwwroot\BDequipo4\TieneNivelIngles.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENENIVELESPANOL
BULK INSERT BDequipo4.Bdequipo4.[TieneNivelEspanol]
	FROM 'e:\wwwroot\BDequipo4\TieneNivelEspanol.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENENIVELLSM
BULK INSERT BDequipo4.Bdequipo4.[TieneNivelLSM]
	FROM 'e:\wwwroot\BDequipo4\TieneNivelLSM.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENEESTADOCIVIL
BULK INSERT BDequipo4.Bdequipo4.[TieneEstadoCivil]
	FROM 'e:\wwwroot\BDequipo4\TieneEstadoCivil.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga PERTENECECENSO
BULK INSERT BDequipo4.Bdequipo4.[PerteneceCenso]
	FROM 'e:\wwwroot\BDequipo4\PerteneceCenso.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga APARATOAUDITIVO
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
GO

--Carga POSEEAPARATOAUDITIVO
BULK INSERT BDequipo4.BDequipo4.[PoseeAparatoAuditivo]
	FROM 'e:\wwwroot\BDequipo4\PoseeAparatoAuditivo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga PERIDAAUDITIVA	
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
GO	

--Carga CAUSADO
BULK INSERT BDequipo4.BDequipo4.[Causado]
	FROM 'e:\wwwroot\BDequipo4\Causado.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga ESGRADO	
BULK INSERT BDequipo4.BDequipo4.[EsGrado]
	FROM 'e:\wwwroot\BDequipo4\EsGrado.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENEPERDIDAAUDITIVA
BULK INSERT BDequipo4.BDequipo4.[TienePerdidaAuditiva]
	FROM 'e:\wwwroot\BDequipo4\TienePerdidaAuditiva.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO		

--Carga EMPLEO
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
 GO

 --Carga GANA	
BULK INSERT BDequipo4.BDequipo4.[Gana]
	FROM 'e:\wwwroot\BDequipo4\Gana.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga TIENEEMPLEO
BULK INSERT BDequipo4.BDequipo4.[TieneEmpleo]
	FROM 'e:\wwwroot\BDequipo4\TieneEmpleo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--Carga LOCALIZAEMPLEO
BULK INSERT BDequipo4.BDequipo4.[LocalizaEmpleo]
	FROM 'e:\wwwroot\BDequipo4\LocalizaEmpleo.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO	

--SECCION DE ROLES
--Carga USUARIO
BULK INSERT BDequipo4.BDequipo4.[Usuario]
	FROM 'e:\wwwroot\BDequipo4\Usuario.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga ROL
BULK INSERT BDequipo4.BDequipo4.[Rol]
	FROM 'e:\wwwroot\BDequipo4\Rol.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga PRIVILEGIO
BULK INSERT BDequipo4.BDequipo4.[Privilegio]
	FROM 'e:\wwwroot\BDequipo4\Privilegio.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga TIENEROL
BULK INSERT BDequipo4.BDequipo4.[TieneRol]
	FROM 'e:\wwwroot\BDequipo4\TieneRol.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO

--Carga INCLUYEPRIVILEGIO
BULK INSERT BDequipo4.BDequipo4.[IncluyePrivilegio]
	FROM 'e:\wwwroot\BDequipo4\IncluyePrivilegio.csv'
	WITH
	(
		CHECK_CONSTRAINTS,
		CODEPAGE = 'ACP',
		FIRSTROW = 2,
		FIELDTERMINATOR = ',',
		ROWTERMINATOR = '\n'
	)
GO



