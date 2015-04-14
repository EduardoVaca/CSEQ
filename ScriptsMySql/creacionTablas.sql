-- CREACION DE TABLAS
-- Creacion tabla: Persona
DROP TABLE IF EXISTS Persona;
CREATE TABLE Persona
(
	CURP char(18) not null unique, 
	nombre varchar(80) not null, 
	fecha_nacimiento DATETIME not null,
	sexo_masculino boolean not null,
	telefono varchar(20), 
	correo varchar(60), 
	calle varchar(80), 
	examen_audiometria boolean not null,
	implante_coclear boolean not null,
	comunidad_indigena boolean not null,
	alergia boolean not null,
	enfermedad boolean,
	mexicano boolean not null,
	credencialIFE boolean not null,
	ID_periodo INT not null,
	CONSTRAINT llavePersona PRIMARY KEY(CURP)
);

-- Creacion tabla: Censo
DROP TABLE IF EXISTS Censo;
CREATE TABLE Censo
(
	ID_censo numeric(4) not null unique,
	CONSTRAINT llaveCenso PRIMARY KEY (ID_Censo)
);

-- Creacion tabla: PerteneceCenso
DROP TABLE IF EXISTS PerteneceCenso;
CREATE TABLE PerteneceCenso
(
	CURP char(18) not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llavePerteneceCenso PRIMARY KEY (CURP, ID_censo)
);


-- Creacion tabla: Colonia
DROP TABLE IF EXISTS Colonia;
CREATE TABLE Colonia
(
	ID_colonia INT auto_increment not null unique,
	nombre varchar(80) not null,
	ID_Delegacion INT,
	ID_municipio INT,
	CONSTRAINT llaveColonia PRIMARY KEY (ID_colonia)
);


-- Creacion tabla: Vive
DROP TABLE IF EXISTS Vive;
CREATE TABLE Vive
(
	CURP char(18) not null,
	ID_colonia INT not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveVive PRIMARY KEY (CURP, ID_colonia, ID_censo)
);


-- Creacion tabla: Municipio
DROP TABLE IF EXISTS Municipio;
CREATE TABLE Municipio
(
	ID_municipio INT auto_increment not null unique,
	nombre varchar(80) not null,
	ID_estado INT not null,
	CONSTRAINT llaveMunicipio PRIMARY KEY (ID_municipio)
);

-- Creacion tabla: Estado
DROP TABLE IF EXISTS Estado;
CREATE TABLE Estado
(
	ID_estado INT auto_increment not null unique,
	nombre varchar(60) not null,
	CONSTRAINT llaveEstado PRIMARY KEY (ID_estado)
);


-- Creacion tabla: Delegacion
DROP TABLE IF EXISTS Delegacion;
CREATE TABLE Delegacion
(
	ID_delegacion INT auto_increment not null unique,
	nombre varchar(80) not null,
	ID_municipio INT,
	CONSTRAINT llaveDelegacion PRIMARY KEY (ID_delegacion)
);


-- Creacion tabla: Nivel Educativo
DROP TABLE IF EXISTS NivelEducativo;
CREATE TABLE NivelEducativo
(
    ID_nivelEducativo INT auto_increment not null unique,
    nivel varchar(20) not null,
	CONSTRAINT llaveNivelEducativo PRIMARY KEY (ID_nivelEducativo)
);


-- Creacion tabla: InstitucionEducativa
DROP TABLE IF EXISTS InstitucionEducativa;
CREATE TABLE InstitucionEducativa
(
	ID_institucionEducativa INT auto_increment not null unique,
	nombre varchar(90) not null,
	calle varchar(80),
	telefono varchar(20),
	correo varchar(70),
	privada boolean not null,
	especializada boolean not null,
	CONSTRAINT llaveInstitucionEducativa PRIMARY KEY (ID_institucionEducativa)
);


-- Creacion tabla: TieneNivelEducativo
DROP TABLE IF EXISTS TieneNivelEducativo;
CREATE TABLE TieneNivelEducativo (
	CURP char(18) not null,
	ID_nivelEducativo INT not null,
	ID_Censo numeric(4) not null,
	CONSTRAINT llaveTieneNivelEducativo PRIMARY KEY (CURP, ID_nivelEducativo, ID_censo)
);


-- Creacion tabla: Estudiado
DROP TABLE IF EXISTS Estudiado;
CREATE TABLE Estudiado
(
	ID_institucionEducativa INT not null,
	ID_nivelEducativo INT not null,
	CURP char (18) not null,
	ano numeric(4) not null,
	CONSTRAINT llaveEstudiado PRIMARY KEY (ID_institucionEducativa, ID_nivelEducativo, CURP, ano)
);


-- Creacion tabla: Periodo
DROP TABLE IF EXISTS Periodo;
CREATE TABLE Periodo
(
	ID_periodo INT auto_increment not null unique,
	periodo varchar(30) not null,
	descripcion varchar(80),
	CONSTRAINT llavePeriodo PRIMARY KEY (ID_periodo)
);


-- Creacion tabla: LocalizaInstitucionEducativa
DROP TABLE IF EXISTS LocalizaInstitucionEducativa;
CREATE TABLE LocalizaInstitucionEducativa
(
	ID_institucionEducativa INT not null,
	ID_colonia INT not null,
	CONSTRAINT llaveLocalizaInstitucionEducativa PRIMARY KEY (ID_institucionEducativa, ID_colonia)
);


-- Creacion tabla: Empleo
DROP TABLE IF EXISTS Empleo;
CREATE TABLE Empleo
(
	ID_empleo INT auto_increment not null unique,
	descripcion varchar(80) not null,
	nombre_compania varchar(50), 
	correo varchar(80),
	telefono varchar(20),
	calle varchar(80),
	interpretacion_LSM boolean,
	ID_areaTrabajo INT,
	CONSTRAINT llaveEmpleo PRIMARY KEY (ID_empleo)
);


-- Creacion tabla: Sueldo
DROP TABLE IF EXISTS Sueldo;
CREATE TABLE Sueldo
(
    ID_sueldo INT auto_increment not null unique,
    minimo varchar(20) not null,
    maximo varchar(20) not null,
    CONSTRAINT llaveSueldo PRIMARY KEY (ID_sueldo)
);


-- Creacion tabla: Gana
DROP TABLE IF EXISTS Gana;
CREATE TABLE Gana
(
    ID_empleo INT not null,
    ID_sueldo INT not null,
    ID_censo numeric(4) not null,
    CONSTRAINT llaveGana PRIMARY KEY (ID_empleo, ID_sueldo, ID_censo)
);

-- Creacion table: TieneEmpleo
DROP TABLE IF EXISTS TieneEmpleo;
CREATE TABLE TieneEmpleo
(
    CURP char(18) not null,
    ID_empleo INT not null,
    ID_censo numeric(4) not null,
    CONSTRAINT llaveTieneEmpleo PRIMARY KEY (CURP, ID_empleo, ID_censo)
);

-- Creacion table: LocalizaEmpleo
DROP TABLE IF EXISTS LocalizaEmpleo;
CREATE TABLE LocalizaEmpleo
(
	ID_empleo INT not null,
	ID_colonia INT not null,
	CONSTRAINT llaveLocalizaEmpleo PRIMARY KEY (ID_empleo, ID_colonia)
);


-- Creacion tabla: AreaTrabajo
DROP TABLE IF EXISTS AreaTrabajo;
CREATE TABLE AreaTrabajo
(
 ID_areaTrabajo INT auto_increment not null unique,
 nombre varchar(60) not null,
 CONSTRAINT llaveAreaTrabajo PRIMARY KEY(ID_areaTrabajo)
);


-- Creacion tabla: LenguaDominante
DROP TABLE IF EXISTS LenguaDominante;
CREATE TABLE LenguaDominante
(
	ID_lenguaDominante INT auto_increment not null unique,
	nombre varchar(40),
	CONSTRAINT llaveLenguaDominante PRIMARY KEY (ID_lenguaDominante)
);

-- Creacion tabla: TieneLenguaDominante
DROP TABLE IF EXISTS TieneLenguaDominante;
CREATE TABLE TieneLenguaDominante
(
	CURP char(18) not null,
	ID_lenguaDominante INT not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveTieneLenguaDominante PRIMARY KEY (CURP, ID_lenguaDominante, ID_censo)
);


-- Creacion tabla: NivelEspanol
DROP TABLE IF EXISTS NivelEspanol;
CREATE TABLE NivelEspanol
(
	ID_nivelEspanol INT auto_increment not null unique,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelEspanol PRIMARY KEY (ID_nivelEspanol)
);

-- Creacion tabla: TieneNivelEspanol
DROP TABLE IF EXISTS TieneNivelEspanol;
CREATE TABLE TieneNivelEspanol
(
	CURP char(18) not null,
	ID_nivelEspanol INT not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveTieneNivelEspanol PRIMARY KEY (CURP, ID_nivelEspanol, ID_censo)
);

-- Creacion tabla: NivelIngles
DROP TABLE IF EXISTS NivelIngles;
CREATE TABLE NivelIngles
(
	ID_nivelIngles INT auto_increment not null unique,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelIngles PRIMARY KEY (ID_nivelIngles)
);

-- Creacion tabla: TieneNivelIngles
DROP TABLE IF EXISTS TieneNivelIngles;
CREATE TABLE TieneNivelIngles
(
	CURP char(18) not null,
	ID_nivelIngles INT not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveTieneNivelIngles PRIMARY KEY (CURP, ID_nivelIngles, ID_censo)
);

-- Creacion tabla: NivelLSM
DROP TABLE IF EXISTS NivelLSM;
CREATE TABLE NivelLSM
(
	ID_nivelLSM INT auto_increment not null unique,
	nivel varchar(10) not null,
	CONSTRAINT llaveNivelLSM PRIMARY KEY (ID_nivelLSM)
);


-- Creacion tabla: TieneNivelLSM
DROP TABLE IF EXISTS TieneNivelLSM;
CREATE TABLE TieneNivelLSM
(
	CURP char (18) not null,
	ID_nivelLSM INT not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveTieneNivelLSM PRIMARY KEY (CURP, ID_nivelLSM,ID_censo)
);

-- Creacion tabla: EstadoCivil
DROP TABLE IF EXISTS EstadoCivil;
CREATE TABLE EstadoCivil
(
	ID_estadoCivil INT auto_increment not null ,
	nombre varchar(30) not null,
	CONSTRAINT llaveEstadoCivil PRIMARY KEY (ID_estadoCivil)
);


-- Creacion tabla: TieneEstadoCivil
DROP TABLE IF EXISTS TieneEstadoCivil;
CREATE TABLE TieneEstadoCivil
(
	CURP char (18) not null,
	ID_estadoCivil INT not null,
	ID_Censo numeric(4) not null,
	CONSTRAINT llaveTieneEstadoCivil PRIMARY KEY (CURP, ID_estadoCivil, ID_Censo)
);


-- Creacion tabla: AparatoAuditivo
DROP TABLE IF EXISTS AparatoAuditivo;
CREATE TABLE AparatoAuditivo
(
	ID_aparatoAuditivo INT auto_increment not null unique,
	tipo varchar (60) not null,
	ID_marca INT,
	CONSTRAINT llaveAparatoAuditivo PRIMARY KEY (ID_aparatoAuditivo)
);


-- Creacion tabla: PoseeAparatoAuditivo
DROP TABLE IF EXISTS PoseeAparatoAuditivo;
CREATE TABLE PoseeAparatoAuditivo
(
	CURP char(18) not null,
	ID_aparatoAuditivo INT not null,
	ID_censo numeric(4) not null,
	modelo varchar(30),
	CONSTRAINT llavePoseeAparatoAuditivo PRIMARY KEY (CURP, ID_aparatoAuditivo, ID_censo, modelo)
);

-- Creacion tabla: Marca
DROP TABLE IF EXISTS Marca;
CREATE TABLE Marca
(
	ID_marca INT auto_increment not null unique,
	nombre varchar(40) not null,
	CONSTRAINT llaveMarca PRIMARY KEY (ID_marca)
);

-- Creacion tabla: Hijo
DROP TABLE IF EXISTS Hijo;
CREATE TABLE Hijo
(
	ID_hijo INT auto_increment not null not null,
	nombre varchar(80) not null,		
	fecha_nacimiento DATETIME not null,
	sordo boolean not null,
	CURP char (18) not null,
	CONSTRAINT llaveHijo PRIMARY KEY (ID_hijo)
);

-- Creacion tabla: PerdidaAuditiva
DROP TABLE IF EXISTS PerdidaAuditiva;
CREATE TABLE PerdidaAuditiva
(
	ID_perdidaAuditiva INT auto_increment not null unique,
	tipo varchar(50) not null,
	descripcion varchar(50)not null,
	CONSTRAINT llavePerdidaAuditiva PRIMARY KEY (ID_perdidaAuditiva)
);

-- Creacion tabla: TienePerdidaAuditiva
DROP TABLE IF EXISTS TienePerdidaAuditiva;
CREATE TABLE TienePerdidaAuditiva
(
	CURP char(18) not null,
	ID_perdidaAuditiva INT not null,
	prelinguistica boolean not null,
	ID_censo numeric(4) not null,
	CONSTRAINT llaveTienePerdidaAuditiva PRIMARY KEY (CURP, ID_perdidaAuditiva, ID_censo)
);

-- Creacion tabla: Causa
DROP TABLE IF EXISTS Causa;
CREATE TABLE Causa
(
	ID_causa INT auto_increment not null unique,
	causa varchar (50) not null,
	CONSTRAINT llaveCausa PRIMARY KEY (ID_causa)
);

-- Creacion tabla: Causado
DROP TABLE IF EXISTS Causado;
CREATE TABLE Causado
(
	CURP char(18) not null,
	ID_perdidaAuditiva INT not null,
	ID_causa INT not null,	
	ID_censo numeric(4) not null,
	CONSTRAINT llaveCausado PRIMARY KEY (ID_perdidaAuditiva, ID_causa, CURP, ID_censo)
);

-- Creacion tabla: Grado
DROP TABLE IF EXISTS Grado;
CREATE TABLE Grado
(
	ID_grado INT auto_increment not null unique,
	grado varchar (40) not null,
	descripcion varchar(60),
	CONSTRAINT llaveGrado PRIMARY KEY (ID_grado)
);

-- Creacion tabla: EsGrado
DROP TABLE IF EXISTS EsGrado;
CREATE TABLE EsGrado
(
	CURP char(18) not null,
	ID_perdidaAuditiva INT not null,
	ID_grado INT not null,
	ID_censo numeric(4) not null,
	bilateral boolean not null,
	CONSTRAINT llaveEsGrado PRIMARY KEY (CURP, ID_perdidaAuditiva, ID_grado, ID_censo)
);

-- SECCION DE ROLES

-- Creacion tabla: Usuario
DROP TABLE IF EXISTS Usuario;
CREATE TABLE Usuario
(
	login varchar(30) not null,
	password varchar(30) not null,
	CONSTRAINT llaveUsuario PRIMARY KEY (login)
);

-- Creacion tabla: Rol
DROP TABLE IF EXISTS Rol;
CREATE TABLE Rol
(
	ID_rol INT auto_increment not null unique,
	nombre varchar (40) not null,
	CONSTRAINT llaveRol PRIMARY KEY (ID_rol)
);

-- Creacion tabla: TieneRol
DROP TABLE IF EXISTS TieneRol;
CREATE TABLE TieneRol
(
	login varchar(30) not null,
	ID_rol INT not null,
	CONSTRAINT llaveTieneRol PRIMARY KEY (login, ID_rol)
);

-- Creacion tabla: Privilegio
DROP TABLE IF EXISTS Privilegio;
CREATE TABLE Privilegio
(
	ID_privilegio INT auto_increment not null unique,
	nombre varchar(100) not null,
	descripcion varchar(100),
	CONSTRAINT llavePrivilegio PRIMARY KEY (ID_privilegio)
);

-- Creacion tabla: IncluyePrivilegio
DROP TABLE IF EXISTS IncluyePrivilegio;
CREATE TABLE IncluyePrivilegio
(
	ID_rol INT not null,
	ID_privilegio INT not null,
	CONSTRAINT llaveIncluyePrivilegio PRIMARY KEY (ID_rol, ID_privilegio)
);
