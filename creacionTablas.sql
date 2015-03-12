
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


--Creacion tabla: Colonia
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Colonia')
	DROP TABLE Colonia
CREATE TABLE Colonia
(
	ID_colonia INT IDENTITY(1,1) not null,
	nombre varchar(30) not null,
	ID_Delegacion INT,
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
	nombre varchar(20) not null,
	CONSTRAINT llaveMunicipio PRIMARY KEY (ID_municipio)
)


--Creacion tabla: Delegacion
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Delegacion')
	DROP TABLE Delegacion
CREATE TABLE Delegacion
(
	ID_delegacion INT IDENTITY(1,1) not null,
	nombre varchar(30) not null,
	ID_municipio INT not null,
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
	nombre varchar(50) not null,
	calle varchar(50),
	telefono numeric(10),
	correo varchar(30),
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
	ano numeric(4),
	CONSTRAINT llaveEstudiado PRIMARY KEY (ID_institucionEducativa, ID_nivelEducativo, ano)
)


--Creacion tabla: Periodo
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Periodo')
	DROP TABLE Periodo
CREATE TABLE Periodo
(
	ID_periodo INT IDENTITY (1,1) not null,
	periodo varchar(30) not null,
	descripcion varchar(40) not null,
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
	descripcion varchar(40) not null,
	nombre_compania varchar(50) not null, 
	correo varchar(40),
	telefono numeric(10),
	calle varchar(50),
	interpretacion_LSM bit not null,
	ID_areaTrabajo INT not null,
	CONSTRAINT llaveEmpleo PRIMARY KEY (ID_empleo)
)


--Creacion tabla: Sueldo
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Sueldo')
    DROP TABLE Sueldo
CREATE TABLE Sueldo
(
    ID_sueldo INT IDENTITY(1,1) not null,
    minimo numeric(10, 2) not null,
    maximo numeric(10, 2) not null,
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
    CURP numeric(18) not null,
    ID_empleo INT not null,
    ID_censo INT not null,
    CONSTRAINT llaveTieneEmpleo PRIMARY KEY (CURP, ID_empleo, ID_censo)
)
--CONSTRAINTS DE LLAVES FORANEAS

--Contraint (PERSONA)
ALTER TABLE Persona ADD CONSTRAINT cfPersonaID_periodo FOREIGN KEY (ID_periodo) REFERENCES Periodo (ID_periodo)

--Constraint (COLONIA)
ALTER TABLE Colonia ADD CONSTRAINT cfColoniaID_delegacion FOREIGN KEY (ID_delegacion) REFERENCES Delegacion (ID_delegacion)

--Constraint (VIVE)
ALTER TABLE Vive ADD CONSTRAINT cfViveCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP)
ALTER TABLE Vive ADD CONSTRAINT cfViveID_colonia FOREIGN KEY (ID_colonia) REFERENCES Colonia (ID_colonia)
ALTER TABLE Vive ADD CONSTRAINT cfViveID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo)

--Constarint (DELEGACION)
ALTER TABLE Delegacion ADD CONSTRAINT cfDelegacionID_municipio FOREIGN KEY (ID_municipio) REFERENCES Municipio (ID_municipio)

--Constraint (TIENENIVELEDUCATIVO)
ALTER TABLE TieneNivelEducativo ADD CONSTRAINT cfTieneNivelEducativoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP)
ALTER TABLE TieneNivelEducativo ADD	CONSTRAINT cfTieneNivelEducativoID_nivelEducativo FOREIGN KEY (ID_nivelEducativo) 
								REFERENCES NivelEducativo (ID_nivelEducativo)
ALTER TABLE TieneNivelEducativo ADD	CONSTRAINT cfTieneNivelEducativoID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo)

--Constraint(ESTUDIADO)
ALTER TABLE Estudiado ADD CONSTRAINT cfEstudiadoID_institucionEducativa FOREIGN KEY (ID_institucionEducativa) 
					  REFERENCES InstitucionEducativa (ID_institucionEducativa)
ALTER TABLE Estudiado ADD CONSTRAINT cfEstudiadoID_nivelEducativo FOREIGN KEY (ID_nivelEducativo) REFERENCES NivelEducativo (ID_nivelEducativo)

--Constraint(LOCALIZAINSTITUCIONEDUCATIVA)
ALTER TABLE LocalizaInstitucionEducativa ADD CONSTRAINT cfLocalizaInstitucionEducativaID_institucionEducativa FOREIGN KEY (ID_institucionEducativa)
										 REFERENCES InstitucionEducativa (ID_institucionEducativa)
ALTER TABLE LocalizaInstitucionEducativa ADD CONSTRAINT cfLocalizaInstitucionEducativaID_colonia FOREIGN KEY (ID_colonia)
										 REFERENCES Colonia (ID_colonia)							

--Constraint(EMPLEO)
--ALTER TABLE Empleo ADD CONSTRAINT cfEmpleoID_areaTrabajo FOREIGN KEY (ID_areaTrabajo) REFERENCES AreaTrabajo (ID_areaTrabajo)	

--Constrant (GANA)
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_empleo FOREIGN KEY (ID_empleo) REFERENCES Empleo (ID_empleo)
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_sueldo FOREIGN KEY (ID_sueldo) REFERENCES Sueldo (ID_sueldo)
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo)	

--Constraint (TIENEEMPLEO)
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP)
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoID_empleo FOREIGN KEY (ID_empleo) REFERENCES Empleo (ID_empleo)							 
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo)
