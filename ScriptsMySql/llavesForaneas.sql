-- CONSTRAINTS DE LLAVES FORANEAS.

-- Contraint (PERSONA)
ALTER TABLE Persona ADD CONSTRAINT cfPersonaID_periodo FOREIGN KEY (ID_periodo) REFERENCES Periodo (ID_periodo);

-- Constraint (COLONIA).
ALTER TABLE Colonia ADD CONSTRAINT cfColoniaID_municipio FOREIGN KEY (ID_municipio) REFERENCES Municipio (ID_municipio);

-- Constraint (VIVE)
ALTER TABLE Vive ADD CONSTRAINT cfViveCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);
ALTER TABLE Vive ADD CONSTRAINT cfViveID_colonia FOREIGN KEY (ID_colonia) REFERENCES Colonia (ID_colonia);
ALTER TABLE Vive ADD CONSTRAINT cfViveID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo);

-- Contsraint (MUNICIPIO)
ALTER TABLE Municipio ADD CONSTRAINT cfMunicipioID_estado FOREIGN KEY (ID_estado) REFERENCES Estado (ID_estado);

-- Constraint (TIENENIVELEDUCATIVO)
ALTER TABLE TieneNivelEducativo ADD CONSTRAINT cfTieneNivelEducativoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);
ALTER TABLE TieneNivelEducativo ADD	CONSTRAINT cfTieneNivelEducativoID_nivelEducativo FOREIGN KEY (ID_nivelEducativo) 
								REFERENCES NivelEducativo (ID_nivelEducativo);
ALTER TABLE TieneNivelEducativo ADD	CONSTRAINT cfTieneNivelEducativoID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo);

-- Constraint(ESTUDIADO)
ALTER TABLE Estudiado ADD CONSTRAINT cfEstudiadoID_institucionEducativa FOREIGN KEY (ID_institucionEducativa) 
					  REFERENCES InstitucionEducativa (ID_institucionEducativa);
ALTER TABLE Estudiado ADD CONSTRAINT cfEstudiadoID_nivelEducativo FOREIGN KEY (ID_nivelEducativo) REFERENCES NivelEducativo (ID_nivelEducativo);
ALTER TABLE Estudiado ADD CONSTRAINT cfEstudiadoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);

-- Constraint(LOCALIZAINSTITUCIONEDUCATIVA)
ALTER TABLE LocalizaInstitucionEducativa ADD CONSTRAINT cfLocalizaInstitucionEducativaID_institucionEducativa FOREIGN KEY (ID_institucionEducativa)
										 REFERENCES InstitucionEducativa (ID_institucionEducativa);
ALTER TABLE LocalizaInstitucionEducativa ADD CONSTRAINT cfLocalizaInstitucionEducativaID_colonia FOREIGN KEY (ID_colonia)
										 REFERENCES Colonia (ID_colonia);							

-- Constraint(EMPLEO)
ALTER TABLE Empleo ADD CONSTRAINT cfEmpleoID_areaTrabajo FOREIGN KEY (ID_areaTrabajo) REFERENCES AreaTrabajo (ID_areaTrabajo);	

-- Constrant (GANA)
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_empleo FOREIGN KEY (ID_empleo) REFERENCES Empleo (ID_empleo);
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_sueldo FOREIGN KEY (ID_sueldo) REFERENCES Sueldo (ID_sueldo);
ALTER TABLE Gana ADD CONSTRAINT cfGanaID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo);

-- Constraint (TIENEEMPLEO)
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoID_empleo FOREIGN KEY (ID_empleo) REFERENCES Empleo (ID_empleo);							 
ALTER TABLE TieneEmpleo ADD CONSTRAINT cfTieneEmpleoID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo);

-- Constraint (LOCALIZAEMPLEO)
ALTER TABLE LocalizaEmpleo ADD CONSTRAINT cfLocalizaEmpleoID_empleo FOREIGN KEY (ID_empleo) REFERENCES Empleo (ID_empleo);
ALTER TABLE LocalizaEmpleo ADD CONSTRAINT cfLocalizaEmpleoID_colonia FOREIGN KEY (ID_colonia) REFERENCES Colonia (ID_colonia);
							
							
-- Constraint (TIENELENGUADOMINANTE)
ALTER TABLE TieneLenguaDominante ADD CONSTRAINT cfTieneLenguaDominanteCURP FOREIGN KEY (CURP)
								REFERENCES Persona (CURP);
ALTER TABLE TieneLenguaDominante ADD CONSTRAINT cfTieneLenguaDominanteID_lenguaDominante FOREIGN KEY (ID_lenguaDominante)
								 REFERENCES LenguaDominante (ID_lenguaDominante);
ALTER TABLE TieneLenguaDominante ADD CONSTRAINT cfTieneLenguaDominanteID_censo FOREIGN KEY (ID_censo)
								 REFERENCES Censo (ID_censo);
								 
-- Contraint (TIENENIVELESPANOL)
ALTER TABLE TieneNivelEspanol ADD CONSTRAINT cfTieneNivelEspanolCURP FOREIGN KEY (CURP)
							  REFERENCES Persona (CURP);
ALTER TABLE TieneNivelEspanol ADD CONSTRAINT cfTieneNivelEspanolID_nivelEspanol FOREIGN KEY (ID_nivelEspanol)
							  REFERENCES NivelEspanol (ID_nivelEspanol);
ALTER TABLE TieneNivelEspanol ADD CONSTRAINT cfTieneNivelEspanolID_censo FOREIGN KEY (ID_censo)
							  REFERENCES Censo (ID_censo);
							  
-- Contraint (TIENENIVELINGLES)
ALTER TABLE TieneNivelIngles ADD CONSTRAINT cfTieneNivelInglesCURP FOREIGN KEY (CURP)
							  REFERENCES Persona (CURP);
ALTER TABLE TieneNivelIngles ADD CONSTRAINT cfTieneNivelInglesID_nivelIngles FOREIGN KEY (ID_nivelIngles)
							  REFERENCES NivelIngles (ID_nivelIngles);
ALTER TABLE TieneNivelIngles ADD CONSTRAINT cfTieneNivelInglesID_censo FOREIGN KEY (ID_censo)
							  REFERENCES Censo (ID_censo);	
							  
-- Contraint (TIENENIVELSM)
ALTER TABLE TieneNivelLSM ADD CONSTRAINT cfTieneNivelLSMCURP FOREIGN KEY (CURP)
							  REFERENCES Persona (CURP);
ALTER TABLE TieneNivelLSM ADD CONSTRAINT cfTieneNivelLSMID_nivelLSM FOREIGN KEY (ID_nivelLSM)
							  REFERENCES NivelLSM (ID_nivelLSM);
ALTER TABLE TieneNivelLSM ADD CONSTRAINT cfTieneNivelLSMID_censo FOREIGN KEY (ID_censo)
							  REFERENCES Censo (ID_censo);	
							  
-- Constraint (TIENEESTADOCIVIL)
ALTER TABLE TieneEstadoCivil ADD CONSTRAINT cfTieneEstadoCivilCURP FOREIGN KEY (CURP)
							 REFERENCES Persona (CURP);
ALTER TABLE TieneEstadoCivil ADD CONSTRAINT cfTieneEstadoCivilID_estadoCivil FOREIGN KEY (ID_estadoCivil)
							 REFERENCES EstadoCivil (ID_estadoCivil);
ALTER TABLE TieneEstadoCivil ADD CONSTRAINT cfTieneEstadoCivilID_censo FOREIGN KEY (ID_censo)
							 REFERENCES Censo (ID_censo);

-- Constraint (PERTENECECENSO)
ALTER TABLE PerteneceCenso ADD CONSTRAINT cfPerteneceCensoCURP FOREIGN KEY (CURP)
						   REFERENCES Persona (CURP);
ALTER TABLE PerteneceCenso ADD CONSTRAINT cfPerteneceCensoID_censo FOREIGN KEY (ID_censo)
						   REFERENCES Censo (ID_censo);
						   
-- Constraint (APARATOAUDITIVO)
ALTER TABLE AparatoAuditivo ADD CONSTRAINT cfAparatoAuditivoID_marca FOREIGN KEY (ID_marca)
							REFERENCES Marca (ID_marca);

-- Constraint (POSEEAPARATOAUDITIVO)
ALTER TABLE PoseeAparatoAuditivo ADD CONSTRAINT cfPoseeAparatoAuditivoCURP FOREIGN KEY (CURP)
								 REFERENCES Persona (CURP);
ALTER TABLE PoseeAparatoAuditivo ADD CONSTRAINT cfPoseeAparatoAuditivoID_aparatoAuditivo FOREIGN KEY (ID_aparatoAuditivo)
								 REFERENCES AparatoAuditivo (ID_aparatoAuditivo);
ALTER TABLE PoseeAparatoAuditivo ADD CONSTRAINT cfPoseeAparatoAuditivoID_censo FOREIGN KEY (ID_censo)
								 REFERENCES Censo (ID_censo);

-- Constraint (HIJO)
ALTER TABLE Hijo ADD CONSTRAINT cfHijoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);

-- Constraint (TIENEPERDIDAAUDITIVA)
ALTER TABLE TienePerdidaAuditiva ADD CONSTRAINT cfTienePerdidaAuditivaCURP FOREIGN KEY (CURP)
								 REFERENCES Persona (CURP);
ALTER TABLE TienePerdidaAuditiva ADD CONSTRAINT cfTienePerdidaAuditivaID_perdidaAuditiva FOREIGN KEY (ID_perdidaAuditiva)
								 REFERENCES PerdidaAuditiva (ID_perdidaAuditiva);
ALTER TABLE TienePerdidaAuditiva ADD CONSTRAINT cfTienePeridaAuditivaID_censo FOREIGN KEY (ID_censo)
								 REFERENCES Censo (ID_censo);							 
								 
-- Constraint (CAUSADO)
ALTER TABLE Causado ADD CONSTRAINT cfCausadoID_perdidaAuditiva FOREIGN KEY (ID_perdidaAuditiva)
					REFERENCES PerdidaAuditiva (ID_perdidaAuditiva);
ALTER TABLE Causado ADD CONSTRAINT cfCausadoID_causa FOREIGN KEY (ID_causa) REFERENCES Causa (ID_causa);	
ALTER TABLE Causado ADD CONSTRAINT cfCausadoCURP FOREIGN KEY (CURP) REFERENCES Persona (CURP);
ALTER TABLE Causado ADD CONSTRAINT cfCausadoID_censo FOREIGN KEY (ID_censo) REFERENCES Censo (ID_censo);

-- Constraint (ESGRADO)
ALTER TABLE EsGrado ADD CONSTRAINT cfEsGradoCURP FOREIGN KEY (CURP)
					REFERENCES Persona (CURP);				
ALTER TABLE EsGrado ADD CONSTRAINT cfEsGradoID_perdidaAuditiva FOREIGN KEY (ID_perdidaAuditiva)
					REFERENCES PerdidaAuditiva (ID_perdidaAuditiva);
ALTER TABLE EsGrado ADD CONSTRAINT cfEsGradoID_grado FOREIGN KEY (ID_grado)
					REFERENCES Grado (ID_grado);
ALTER TABLE EsGrado ADD CONSTRAINT cfEsGradoID_censo FOREIGN KEY (ID_censo)
					REFERENCES Censo (ID_censo);					

-- Constarint (TieneRol)
ALTER TABLE TieneRol ADD CONSTRAINT cfTieneRolLogin FOREIGN KEY (login)
					 REFERENCES Usuario (login);
ALTER TABLE TieneRol ADD CONSTRAINT cfTieneRolID_rol FOREIGN KEY (ID_rol)
					 REFERENCES Rol (ID_rol);

-- Constraint (IncluyePrivilegio)
ALTER TABLE IncluyePrivilegio ADD CONSTRAINT cfIncluyePrivilegioID_rol FOREIGN KEY (ID_rol)
							  REFERENCES Rol (ID_rol);
ALTER TABLE IncluyePrivilegio ADD CONSTRAINT cfIncluyePrivilegioID_privilegio FOREIGN KEY (ID_privilegio)
							  REFERENCES Privilegio (ID_privilegio);							  					 