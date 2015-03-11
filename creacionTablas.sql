--Creacion tabla: Persona
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Persona')
	DROP TABLE Persona
CREATE TABLE Persona
(
	CURP char(18) not null,
	nombre varchar(50) not null,
	fecha_nacimiento DATETIME not null,
	sexo_masculino bit not null,
	telefono numeric(10),
	correo varchar(40),
	calle varchar(40),
	examen_audiometria bit not null,
	implante_coclear bit not null,
	comunidad_indigena bit not null,
	alergia bit not null,
	enfermedad bit not null,
	mexicano bit not null,
	credencialIFE bit not null,
	ID_periodo INT,
)


--Creacion tabla: Colonia
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Colonia')
	DROP TABLE Colonia
CREATE TABLE Colonia
(
	ID_colonia INT IDENTITY PRIMARY KEY,
	nombre varchar(30) not null,
	ID_Delegacion INT
)


--Creacion tabla: Vive
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vive')
	DROP TABLE Vive
CREATE TABLE Vive
(
	CURP char(18) not null,
	ID_colonia INT not null,
	ano numeric(4) not null
)


--Creacion tabla: Delegacion
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Delegacion')
	DROP TABLE Delegacion
CREATE TABLE Delegacion
(
	ID_delegacion INT IDENTITY PRIMARY KEY,
	nombre varchar(30) not null,
	ID_municipio INT not null
)


-- Creacion tabla: Municipio
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Municipio')
	DROP TABLE Municipio
CREATE TABLE Municipio
(
	ID_municipio INT IDENTITY PRIMARY KEY,
	nombre varchar(20) not null
)


--Creacion tabla: Nivel Educativo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'NivelEducativo')
    DROP TABLE NivelEducativo
CREATE TABLE NivelEducativo
(
    ID_institucionEducativa INT IDENTITY PRIMARY KEY,
    nivel varchar(20) not null
)


-- Creacion tabla: InstitucionEducativa
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'InstitucionEducativa')
	DROP TABLE InstitucionEducativa
CREATE TABLE InstitucionEducativa
(
	ID_institucionEducativa INT IDENTITY PRIMARY KEY,
	nombre varchar(50) not null,
	calle varchar(50) not null,
	telefono numeric(10),
	correo varchar(30),
	privada bit not null,
	especializada bit not null
)


-- Creacion tabla: TieneNivelEducativo
IF EXISTS ( SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneNivelEducativo')
 DROP TABLE TieneNivelEducativo
CREATE TABLE TieneNivelEducativo (
	CURP char(18) not null,
	ID_nivelEducativo INT,
	ano numeric(4) not null
)


--Creacion tabla: Estudiado
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Estudiado')
	DROP TABLE Estudiado
CREATE TABLE Estudiado
(
	ID_institucionEducativa INT not null,
	ID_nivelEducativo INT not null,
	ano numeric(4) not null
)


--Creacion tabla: Periodo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Periodo')
	DROP TABLE Periodo
CREATE TABLE Periodo
(
	ID_periodo INT IDENTITY PRIMARY KEY,
	periodo varchar(30) not null,
	descripcion varchar(40) not null
)


--Creacion tabla: LocalizaInstitucionEducativa
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'LocalizaInstitucionEducativa')
	DROP TABLE LocalizaInstitucionEducativa
CREATE TABLE LocalizaInstitucionEducativa
(
	ID_institucionEducativa INT not null,
	ID_colonia INT not null
)


--Creacion tabla: Empleo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Empleo')
	DROP TABLE Empleo
CREATE TABLE Empleo
(
	ID_empleo INT IDENTITY PRIMARY KEY,
	descripcion varchar(40) not null,
	nombre_compania varchar(50) not null,
	correo varchar(40) not null,
	telefono numeric(10) not null,
	calle varchar(50) not null,
	interpretacion_LSM bit not null,
	ID_areaTrabajo INT not null
)


--Creacion tabla: Sueldo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Sueldo')
    DROP TABLE Sueldo
CREATE TABLE Sueldo
(
    ID_sueldo INT IDENTITY PRIMARY KEY,
    minimo numeric(10, 2) not null,
    maximo numeric(10, 2) not null
)


--Creacion tabla: Gana
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Gana')
    DROP TABLE Gana
CREATE TABLE Gana
(
    ID_empleo INT not null,
    ID_sueldo INT not null,
    ano numeric(4) not null
)

--Creacion table: TieneEmpleo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TieneEmpleo')
    DROP TABLE TieneEmpleo
CREATE TABLE TieneEmpleo
(
    CURP numeric(18) not null,
    ID_empleo INT not null,
    ano numeric(4) not null
)

--Contraint (PERSONA)
ALTER TABLE Persona ADD CONSTRAINT llavePersona PRIMARY KEY(CURP)
ALTER TABLE Persona ADD CONSTRAINT cfPeriodoID_periodo FOREIGN KEY
		 (ID_periodo) REFERENCES Periodo (ID_periodo)

--Constraint (COLONIA)
ALTER TABLE Colonia ADD CONSTRAINT cfDelegacionID_delegacion FOREIGN KEY
            (ID_Delegacion) REFERENCES Delegacion (ID_Delegacion)

--Constraint (VIVE)
ALTER TABLE Vive ADD CONSTRAINT llaveVive PRIMARY KEY(CURP, ID_colonia, ano)

--Constarint (DELEGACION)
ALTER TABLE Delegacion ADD CONSTRAINT cfMunicipioID_municipio FOREIGN KEY
            (ID_municipio) REFERENCES Municipio (ID_municipio)

--Constraint (TIENENIVELEDUCATIVO)
ALTER TABLE TieneNivelEducativo ADD CONSTRAINT llaveTieneNivelEducativo
			 PRIMARY KEY(CURP, ID_nivelEducativo, ano)

--Constraint(ESTUDIADO)
ALTER TABLE Estudiado ADD CONSTRAINT llaveEstudiado
			 PRIMARY KEY (ID_institucionEducativa, ID_nivelEducativo, ano)