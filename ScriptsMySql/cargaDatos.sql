-- CARGA DE DATOS

-- Carga de PERIODO.

LOAD DATA INFILE 'periodo.csv'
INTO TABLE cseq.periodo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga PERSONA
LOAD DATA INFILE 'Persona.csv'
INTO TABLE cseq.persona
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga de ESTADO

LOAD DATA INFILE 'Estado.csv'
INTO TABLE cseq.estado
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- carga de INSTITUCIONEDUCATIVA

LOAD DATA INFILE 'InstitucionEducativa.csv'
INTO TABLE cseq.institucioneducativa
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga LENGUADOMINANTE

LOAD DATA INFILE 'LenguaDominante.csv'
INTO TABLE cseq.lenguadominante
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga NIVELINGLES

LOAD DATA INFILE 'NivelIngles.csv'
INTO TABLE cseq.nivelingles
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga NIVELESPANOL

LOAD DATA INFILE 'NivelEspanol.csv'
INTO TABLE cseq.nivelespanol
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga NIVELLSM

LOAD DATA INFILE 'NivelLSM.csv'
INTO TABLE cseq.nivellsm
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga ESTADOCIVIL

LOAD DATA INFILE 'EstadoCivil.csv'
INTO TABLE cseq.estadocivil
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga CENSO

LOAD DATA INFILE 'Censo.csv'
INTO TABLE cseq.censo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga MARCA

LOAD DATA INFILE 'Marca.csv'
INTO TABLE cseq.marca
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga HIJO

LOAD DATA INFILE 'Hijo.csv'
INTO TABLE cseq.hijo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga GRADO

LOAD DATA INFILE 'Grado.csv'
INTO TABLE cseq.grado
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga CAUSA

LOAD DATA INFILE 'Causa.csv'
INTO TABLE cseq.causa
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga SUELDO

LOAD DATA INFILE 'Sueldo.csv'
INTO TABLE cseq.sueldo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga AREATRABAJO

LOAD DATA INFILE 'AreaTrabajo.csv'
INTO TABLE cseq.areatrabajo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga MUNICIPIO

LOAD DATA INFILE 'Municipio.csv'
INTO TABLE cseq.municipio
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga COLONIA

LOAD DATA INFILE 'Colonia.csv'
INTO TABLE cseq.colonia
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga Vive

LOAD DATA INFILE 'Vive.csv'
INTO TABLE cseq.vive
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga LOCALIZAINSTITUCIONEDUCATIVA

LOAD DATA INFILE 'LocalizaInstitucionEducativa.csv'
INTO TABLE cseq.localizainstitucioneducativa
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga NIVELEDUCATIVO

LOAD DATA INFILE 'NivelEducativo.csv'
INTO TABLE cseq.niveleducativo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga ESTUDIADO
LOAD DATA INFILE 'Estudiado.csv'
INTO TABLE cseq.estudiado
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENENIVELEDUCATIVO
LOAD DATA INFILE 'TieneNivelEducativo.csv'
INTO TABLE cseq.tieneniveleducativo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;
	

-- Carga TIENELENGUADOMINANTE
LOAD DATA INFILE 'TieneLenguaDominante.csv'
INTO TABLE cseq.tienelenguadominante
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENENIVELINLGES
LOAD DATA INFILE 'TieneNivelIngles.csv'
INTO TABLE cseq.tienenivelingles
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENENIVELESPANOL
LOAD DATA INFILE 'TieneNivelEspanol.csv'
INTO TABLE cseq.tienenivelespanol
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENENIVELLSM
LOAD DATA INFILE 'TieneNivelLSM.csv'
INTO TABLE cseq.tienenivellsm
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENEESTADOCIVIL
LOAD DATA INFILE 'TieneEstadoCivil.csv'
INTO TABLE cseq.tieneestadocivil
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga PERTENECECENSO
LOAD DATA INFILE 'PerteneceCenso.csv'
INTO TABLE cseq.pertenececenso
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga APARATOAUDITIVO
LOAD DATA INFILE 'AparatoAuditivo.csv'
INTO TABLE cseq.aparatoauditivo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga POSEEAPARATOAUDITIVO
LOAD DATA INFILE 'PoseeAparatoAuditivo.csv'
INTO TABLE cseq.poseeaparatoauditivo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;
	

-- Carga PERIDAAUDITIVA	
LOAD DATA INFILE 'PerdidaAuditiva.csv'
INTO TABLE cseq.perdidaauditiva
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga CAUSADO
LOAD DATA INFILE 'Causado.csv'
INTO TABLE cseq.causado
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga ESGRADO	
LOAD DATA INFILE 'EsGrado.csv'
INTO TABLE cseq.EsGrado
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENEPERDIDAAUDITIVA
LOAD DATA INFILE 'TienePerdidaAuditiva.csv'
INTO TABLE cseq.tieneperdidaauditiva
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga EMPLEO
LOAD DATA INFILE 'Empleo.csv'
INTO TABLE cseq.empleo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

 -- Carga GANA
 
LOAD DATA INFILE 'Gana.csv'
INTO TABLE cseq.gana
FIELDS TERMINATED BY ','
IGNORE 1 LINES;
	

-- Carga TIENEEMPLEO

LOAD DATA INFILE 'TieneEmpleo.csv'
INTO TABLE cseq.tieneempleo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga LOCALIZAEMPLEO

LOAD DATA INFILE 'LocalizaEmpleo.csv'
INTO TABLE cseq.localizaempleo
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- SECCION DE ROLES
-- Carga USUARIO

LOAD DATA INFILE 'Usuario.csv'
INTO TABLE cseq.usuario
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga ROL

LOAD DATA INFILE 'Roles.csv'
INTO TABLE cseq.rol
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga PRIVILEGIO

LOAD DATA INFILE 'Privilegio.csv'
INTO TABLE cseq.privilegio
FIELDS TERMINATED BY ','
IGNORE 1 LINES;


-- Carga TIENEROL

LOAD DATA INFILE 'TieneRol.csv'
INTO TABLE cseq.tienerol
FIELDS TERMINATED BY ','
IGNORE 1 LINES;

-- Carga INCLUYEPRIVILEGIO

LOAD DATA INFILE 'IncluyePrivilegio.csv'
INTO TABLE cseq.incluyeprivilegio
FIELDS TERMINATED BY ','
IGNORE 1 LINES;



