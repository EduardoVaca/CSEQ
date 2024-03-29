--CREACION DE TABLAS
--Creacion tabla: Persona
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persona')
	DROP TABLE Persona
CREATE TABLE Persona
(
	CURP char(18) not null, 
	nombre varchar(80) not null, 
	fecha_nacimiento DATETIME not null,
	sexo_masculino bit not null,
	telefono numeric(10), 
	correo varchar(60), 
	calle varchar(80), 
	examen_audiometria bit not null,
	implante_coclear bit not null,
	comunidad_indigena bit not null,
	alergia bit not null,
	enfermedad bit,
	mexicano bit not null,
	credencialIFE bit not null,
	ID_periodo INT not null,
	CONSTRAINT llavePersona PRIMARY KEY(CURP)
)

--Creacion tabla: Censo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Censo')
	DROP TABLE Censo
CREATE TABLE Censo
(
	ID_censo INT IDENTITY(1,1) not null,
	ano numeric(4),
	CONSTRAINT llaveCenso PRIMARY KEY (ID_Censo)
)

--Creacion tabla: PerteneceCenso
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PerteneceCenso')
	DROP TABLE PerteneceCenso
CREATE TABLE PerteneceCenso
(
	CURP char(18) not null,
	ID_censo INT not null,
	CONSTRAINT llavePerteneceCenso PRIMARY KEY (CURP, ID_censo)
)


--Creacion tabla: Colonia
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Colonia')
	DROP TABLE Colonia
CREATE TABLE Colonia
(
	ID_colonia INT IDENTITY(1,1) not null,
	nombre varchar(80) not null,
	ID_Delegacion INT,
	ID_municipio INT not null,
	CONSTRAINT llaveColonia PRIMARY KEY (ID_colonia)
)


--Creacion tabla: Vive
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vive')
	DROP TABLE Vive
CREATE TABLE Vive
(
	CURP char(18) not null,
	ID_colonia INT not null,
	ID_censo INT not null
	CONSTRAINT llaveVive PRIMARY KEY (CURP, ID_colonia, ID_censo)
)


-- Creacion tabla: Municipio
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Municipio')
	DROP TABLE Municipio
CREATE TABLE Municipio
(
	ID_municipio INT IDENTITY(1,1) not null,
	nombre varchar(80) not null,
	ID_estado INT not null,
	CONSTRAINT llaveMunicipio PRIMARY KEY (ID_municipio)
)

-- Creacion tabla: Estado
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Estado')
	DROP TABLE Estado
CREATE TABLE Estado
(
	ID_estado INT IDENTITY(1,1) not null,
	nombre varchar(60) not null,
	CONSTRAINT llaveEstado PRIMARY KEY (ID_estado)
)


--Creacion tabla: Delegacion
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Delegacion')
	DROP TABLE Delegacion
CREATE TABLE Delegacion
(
	ID_delegacion INT IDENTITY(1,1) not null,
	nombre varchar(80) not null,
	ID_municipio INT,
	CONSTRAINT llaveDelegacion PRIMARY KEY (ID_delegacion)
)


--Creacion tabla: Nivel Educativo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'NivelEducativo')
    DROP TABLE NivelEducativo
CREATE TABLE NivelEducativo
(
    ID_nivelEducativo INT IDENTITY(1,1) not null,
    nivel varchar(20) not null,
	CONSTRAINT llaveNivelEducativo PRIMARY KEY (ID_nivelEducativo)
)


-- Creacion tabla: InstitucionEducativa
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'InstitucionEducativa')
	DROP TABLE InstitucionEducativa
CREATE TABLE InstitucionEducativa
(
	ID_institucionEducativa INT IDENTITY(1,1) not null,
	nombre varchar(90) not null,
	calle varchar(80),
	telefono numeric(10),
	correo varchar(70),
	privada bit not null,
	especializada bit not null,
	CONSTRAINT llaveInstitucionEducativa PRIMARY KEY (ID_institucionEducativa)
)


-- Creacion tabla: TieneNivelEducativo
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneNivelEducativo')
 DROP TABLE TieneNivelEducativo
CREATE TABLE TieneNivelEducativo (
	CURP char(18) not null,
	ID_nivelEducativo INT not null,
	ID_Censo INT not null,
	CONSTRAINT llaveTieneNivelEducativo PRIMARY KEY (CURP, ID_nivelEducativo, ID_censo)
)


--Creacion tabla: Estudiado
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Estudiado')
	DROP TABLE Estudiado
CREATE TABLE Estudiado
(
	ID_institucionEducativa INT not null,
	ID_nivelEducativo INT not null,
	CURP char (18) not null,
	ano numeric(4) not null,
	CONSTRAINT llaveEstudiado PRIMARY KEY (ID_institucionEducativa, ID_nivelEducativo, CURP, ano)
)


--Creacion tabla: Periodo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Periodo')
	DROP TABLE Periodo
CREATE TABLE Periodo
(
	ID_periodo INT IDENTITY (1,1) not null,
	periodo varchar(30) not null,
	descripcion varchar(80),
	CONSTRAINT llavePeriodo PRIMARY KEY (ID_periodo)
)


--Creacion tabla: LocalizaInstitucionEducativa
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'LocalizaInstitucionEducativa')
	DROP TABLE LocalizaInstitucionEducativa
CREATE TABLE LocalizaInstitucionEducativa
(
	ID_institucionEducativa INT not null,
	ID_colonia INT not null,
	CONSTRAINT llaveLocalizaInstitucionEducativa PRIMARY KEY (ID_institucionEducativa, ID_colonia)
)


--Creacion tabla: Empleo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Empleo')
	DROP TABLE Empleo
CREATE TABLE Empleo
(
	ID_empleo INT IDENTITY(1,1) not null,
	descripcion varchar(80) not null,
	nombre_compania varchar(50), 
	correo varchar(80),
	telefono numeric(10),
	calle varchar(80),
	interpretacion_LSM bit,
	ID_areaTrabajo INT not null,
	CONSTRAINT llaveEmpleo PRIMARY KEY (ID_empleo, ID_areaTrabajo)
)


--Creacion tabla: Sueldo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Sueldo')
    DROP TABLE Sueldo
CREATE TABLE Sueldo
(
    ID_sueldo INT IDENTITY(1,1) not null,
    minimo varchar(20) not null,
    maximo varchar(20) not null,
    CONSTRAINT llaveSueldo PRIMARY KEY (ID_sueldo)
)


--Creacion tabla: Gana
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Gana')
    DROP TABLE Gana
CREATE TABLE Gana
(
    ID_empleo INT not null,
    ID_sueldo INT not null,
    ID_censo INT not null,
    CONSTRAINT llaveGana PRIMARY KEY (ID_empleo, ID_sueldo, ID_censo)
)

--Creacion table: TieneEmpleo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneEmpleo')
    DROP TABLE TieneEmpleo
CREATE TABLE TieneEmpleo
(
    CURP char(18) not null,
    ID_empleo INT not null,
    ID_censo INT not null,
    CONSTRAINT llaveTieneEmpleo PRIMARY KEY (CURP, ID_empleo, ID_censo)
)

--Creacion table: LocalizaEmpleo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'LocalizaEmpleo')
	DROP TABLE LocalizaEmpleo
CREATE TABLE LocalizaEmpleo
(
	ID_empleo INT not null,
	ID_colonia INT not null,
	CONSTRAINT llaveLocalizaEmpleo PRIMARY KEY (ID_empleo, ID_colonia)
)


--Creacion tabla: AreaTrabajo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'AreaTrabajo')
	DROP TABLE AreaTrabajo
CREATE TABLE AreaTrabajo
(
 ID_areaTrabajo INT IDENTITY(1,1) not null,
 nombre varchar(60) not null,
 CONSTRAINT llaveAreaTrabajo PRIMARY KEY(ID_areaTrabajo)
)


--Creacion tabla: LenguaDominante
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'LenguaDominante')
	DROP TABLE LenguaDominante
CREATE TABLE LenguaDominante
(
	ID_lenguaDominante INT IDENTITY(1,1) not null,
	nombre varchar(40),
	CONSTRAINT llaveLenguaDominante PRIMARY KEY (ID_lenguaDominante)
)

--Creacion tabla: TieneLenguaDominante
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneLenguaDominante')
	DROP TABLE TieneLenguaDominante
CREATE TABLE TieneLenguaDominante
(
	CURP char(18) not null,
	ID_lenguaDominante INT not null,
	ID_censo INT not null,
	CONSTRAINT llaveTieneLenguaDominante PRIMARY KEY (CURP, ID_lenguaDominante, ID_censo)
)


--Creacion tabla: NivelEspanol
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'NivelEspanol')
	DROP TABLE NivelEspanol
CREATE TABLE NivelEspanol
(
	ID_nivelEspanol INT IDENTITY(1,1) not null,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelEspanol PRIMARY KEY (ID_nivelEspanol)
)

--Creacion tabla: TieneNivelEspanol
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneNivelEspanol')
	DROP TABLE TieneNivelEspanol
CREATE TABLE TieneNivelEspanol
(
	CURP char(18) not null,
	ID_nivelEspanol INT not null,
	ID_censo INT not null,
	CONSTRAINT llaveTieneNivelEspanol PRIMARY KEY (CURP, ID_nivelEspanol, ID_censo)
)

--Creacion tabla: NivelIngles
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'NivelIngles')
	DROP TABLE NivelIngles
CREATE TABLE NivelIngles
(
	ID_nivelIngles INT IDENTITY(1,1) not null,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelIngles PRIMARY KEY (ID_nivelIngles)
)

--Creacion tabla: TieneNivelIngles
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneNivelIngles')
	DROP TABLE TieneNivelIngles
CREATE TABLE TieneNivelIngles
(
	CURP char(18) not null,
	ID_nivelIngles INT not null,
	ID_censo INT not null,
	CONSTRAINT llaveTieneNivelIngles PRIMARY KEY (CURP, ID_nivelIngles, ID_censo)
)

--Creacion tabla: NivelLSM
IF EXISTS( SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'NivelLSM')
	DROP TABLE NivelLSM
CREATE TABLE NivelLSM
(
	ID_nivelLSM INT IDENTITY(1,1) not null,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelLSM PRIMARY KEY (ID_nivelLSM)
)


--Creacion tabla: TieneNivelLSM
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'TieneNivelLSM')
	DROP TABLE TieneNivelLSM
CREATE TABLE TieneNivelLSM
(
	CURP char (18) not null,
	ID_nivelLSM INT not null,
	ID_censo INT not null,
	CONSTRAINT llaveTieneNivelLSM PRIMARY KEY (CURP, ID_nivelLSM,ID_censo)
)



--Creacion tabla: EstadoCivil
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EstadoCivil')
	DROP TABLE EstadoCivil
CREATE TABLE EstadoCivil
(
	ID_estadoCivil INT IDENTITY(1,1) not null,
	nombre varchar(30) not null,
	CONSTRAINT llaveEstadoCivil PRIMARY KEY (ID_estadoCivil)
)


--Creacion tabla: TieneEstadoCivil
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'TieneEstadoCivil')
	DROP TABLE TieneEstadoCivil
CREATE TABLE TieneEstadoCivil
(
	CURP char (18) not null,
	ID_estadoCivil INT not null,
	ID_Censo INT not null,
	CONSTRAINT llaveTieneEstadoCivil PRIMARY KEY (CURP, ID_estadoCivil, ID_Censo)
)


--Creacion tabla: AparatoAuditivo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'AparatoAuditivo')
	DROP TABLE AparatoAuditivo
CREATE TABLE AparatoAuditivo
(
	ID_aparatoAuditivo INT IDENTITY (1,1) not null,
	tipo varchar (60) not null,
	ID_marca INT not null,
	CONSTRAINT llaveAparatoAuditivo PRIMARY KEY (ID_aparatoAuditivo)
)


--Creacion tabla: PoseeAparatoAuditivo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PoseeAparatoAuditivo')
	DROP TABLE PoseeAparatoAuditivo
CREATE TABLE PoseeAparatoAuditivo
(
	CURP char(18) not null,
	ID_aparatoAuditivo INT not null,
	ID_censo INT not null,
	modelo varchar(30),
	CONSTRAINT llavePoseeAparatoAuditivo PRIMARY KEY (CURP, ID_aparatoAuditivo, ID_censo, modelo)
)

--Creacion tabla: Marca
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Marca')
	DROP TABLE Marca
CREATE TABLE Marca
(
	ID_marca INT IDENTITY(1,1) not null,
	nombre varchar(40) not null,
	CONSTRAINT llaveMarca PRIMARY KEY (ID_marca)
)

--Creacion tabla: Hijo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'Hijo')
	DROP TABLE Hijo
CREATE TABLE Hijo
(
	ID_hijo INT IDENTITY (1,1) not null,
	nombre varchar(80) not null,	
	sexo_masculino bit not null,
	fecha_nacimiento DATETIME not null,
	sordo bit not null,
	CURP char (18) not null,
	CONSTRAINT llaveHijo PRIMARY KEY (ID_hijo)
)

--Creacion tabla: PerdidaAuditiva
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PerdidaAuditiva')
	DROP TABLE PerdidaAuditiva
CREATE TABLE PerdidaAuditiva
(
	ID_perdidaAuditiva INT IDENTITY(1,1) not null,
	tipo varchar(50) not null,
	descripcion varchar(50)not null,
	CONSTRAINT llavePerdidaAuditiva PRIMARY KEY (ID_perdidaAuditiva)
)

--Creacion tabla: TienePerdidaAuditiva
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TienePerdidaAuditiva')
	DROP TABLE TienePerdidaAuditiva
CREATE TABLE TienePerdidaAuditiva
(
	CURP char(18) not null,
	ID_perdidaAuditiva INT not null,
	prelinguistica bit not null,
	CONSTRAINT llaveTienePerdidaAuditiva PRIMARY KEY (CURP, ID_perdidaAuditiva)
)

--Creacion tabla: Causa
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'Causa')
	DROP TABLE Causa
CREATE TABLE Causa
(
	ID_causa INT IDENTITY (1,1) not null,
	causa varchar (50) not null,
	CONSTRAINT llaveCausa PRIMARY KEY (ID_causa)
)

--Creacion tabla: Causado
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Causado')
	DROP TABLE Causado
CREATE TABLE Causado
(
	ID_perdidaAuditiva INT not null,
	ID_causa INT not null,
	CURP char(18) not null,
	ID_censo INT not null,
	CONSTRAINT llaveCausado PRIMARY KEY (ID_perdidaAuditiva, ID_causa, CURP, ID_censo)
)

--Creacion tabla: Grado
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.Tables WHERE TABLE_NAME = 'Grado')
	DROP TABLE Grado
CREATE TABLE Grado
(
	ID_grado INT IDENTITY (1,1) not null,
	grado varchar (40) not null,
	descripcion varchar(60),
	CONSTRAINT llaveGrado PRIMARY KEY (ID_grado)
)

--Creacion tabla: EsGrado
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EsGrado')
	DROP TABLE EsGrado
CREATE TABLE EsGrado
(
	CURP char(18) not null,
	ID_perdidaAuditiva INT not null,
	ID_grado INT not null,
	ID_censo INT not null,
	CONSTRAINT llaveEsGrado PRIMARY KEY (CURP, ID_perdidaAuditiva, ID_grado, ID_censo)
)


--SECCION DE ROLES

--Creacion tabla: Usuario
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
	DROP TABLE Usuario
CREATE TABLE Usuario
(
	login varchar(30) not null,
	password varchar(30) not null,
	CONSTRAINT llaveUsuario PRIMARY KEY (login)
)

-- Creacion tabla: Rol
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Rol')
	DROP TABLE Rol
CREATE TABLE Rol
(
	ID_rol INT IDENTITY (1,1) not null,
	nombre varchar (40) not null,
	CONSTRAINT llaveRol PRIMARY KEY (ID_rol)
)

-- Creacion tabla: TieneRol
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneRol')
	DROP TABLE TieneRol
CREATE TABLE TieneRol
(
	login varchar(30) not null,
	ID_rol INT not null,
	CONSTRAINT llaveTieneRol PRIMARY KEY (login, ID_rol)
)

--Creacion tabla: Privilegio
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Privilegio')
	DROP TABLE Privilegio
CREATE TABLE Privilegio
(
	ID_privilegio INT IDENTITY (1,1) not null,
	nombre varchar(100) not null,
	descripcion varchar(100),
	CONSTRAINT llavePrivilegio PRIMARY KEY (ID_privilegio)
)

--Creacion tabla: IncluyePrivilegio
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'IncluyePrivilegio')
	DROP TABLE IncluyePrivilegio
CREATE TABLE IncluyePrivilegio
(
	ID_rol INT not null,
	ID_privilegio INT not null,
	CONSTRAINT llaveIncluyePrivilegio PRIMARY KEY (ID_rol, ID_privilegio)
)
