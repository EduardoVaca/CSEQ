-- CARGA DE DATOS

-- Carga de PERIODO.

INSERT INTO `Periodo` (`ID_periodo`, `periodo`, `descripcion`) VALUES
(1, 'Nacimiento', 'Perdida congenita de audicion/desarrollo intreuterino'),
(2, 'Infancia', 'Nacimiento - 7 años de edad'),
(3, 'Niñez', '7 - 11 años de edad'),
(4, 'Adolescencia', '11 - 16 años de edad'),
(5, 'Juventud', '16 - 25 años de edad'),
(6, 'Adultez', '25 - 65 años de edad'),
(7, 'Tercera Edad', '65 años en adelante'),
(8, 'No lo se', 'No lo se');

-- Carga LENGUADOMINANTE

INSERT INTO `LenguaDominante` (`ID_lenguaDominante`, `nombre`) VALUES
(1, 'Español'),
(2, 'Ingles'),
(3, 'Lengua de Señas Mexicana'),
(4, 'Lengua de Señas EUA');

-- Carga NIVELINGLES

INSERT INTO `NivelIngles` (`ID_nivelIngles`, `nivel`) VALUES
(1, 'Alto '),
(2, 'Medio'),
(3, 'Bajo'),
(4, 'No lo se');

-- Carga NIVELESPANOL

INSERT INTO `NivelEspanol` (`ID_nivelEspanol`, `nivel`) VALUES
(1, 'Alto '),
(2, 'Medio'),
(3, 'Bajo'),
(4, 'No lo se');

-- Carga NIVELLSM

INSERT INTO `NivelLSM` (`ID_nivelLSM`, `nivel`) VALUES
(1, 'Alto '),
(2, 'Medio'),
(3, 'Bajo'),
(4, 'No lo se');

-- Carga ESTADOCIVIL

INSERT INTO `EstadoCivil` (`ID_estadoCivil`, `nombre`) VALUES
(1, 'Soltero(a)'),
(2, 'Casado(a)'),
(3, 'Divorciado(a)'),
(4, 'Viudo(a)');

-- Carga MARCA

INSERT INTO `Marca` (`ID_marca`, `nombre`) VALUES
(1, 'Siemens'),
(2, 'Phonak'),
(3, 'Widex'),
(4, 'Oticon'),
(5, 'Starkey'),
(6, 'Audicus'),
(7, 'AudioTech');

-- Carga GRADO

INSERT INTO `Grado` (`ID_grado`, `grado`, `descripcion`) VALUES
(1, 'Leve', 'Umbral entre 20 y 40  dB'),
(2, 'Media', 'Umbral entre 40 y 70 dB'),
(3, 'Severa', 'Umbral entre 70 y 90 dB'),
(4, 'Profunda', 'Umbral superior a 90 dB '),
(5, 'Total', 'Cofosis');

-- Carga CAUSA

INSERT INTO `Causa` (`ID_causa`, `causa`) VALUES
(1, 'Infeccion'),
(2, 'Nacimiento'),
(3, 'Nacimiento prematuro'),
(4, 'Medicamento'),
(5, 'Lesion fisica'),
(6, 'Enfermedad durante embarazo'),
(7, 'Problemas asociados: Alta temperatura'),
(8, 'Edad');

-- Carga AREATRABAJO

INSERT INTO `AreaTrabajo` (`ID_areaTrabajo`, `nombre`) VALUES
(1, 'Administrativa'),
(2, 'Limpieza'),
(3, 'Publicidad'),
(4, 'Archivador'),
(5, 'Operador de maquina'),
(6, 'Obrero'),
(7, 'Fabricacion'),
(8, 'Especialidad en Almacenes');

-- Carga NIVELEDUCATIVO

INSERT INTO `NivelEducativo` (`ID_nivelEducativo`, `nivel`) VALUES
(1, 'Prescolar'),
(2, 'Primaria'),
(3, 'Secundaria'),
(4, 'Preparatoria'),
(5, 'Carrera Tecnica'),
(6, 'Licenciatura'),
(7, 'Especialidad'),
(8, 'Maestria'),
(9, 'Doctorado');

-- Carga Perdida Auditiva
INSERT INTO `PerdidaAuditiva` (`ID_perdidaAuditiva`, `tipo`, `descripcion`) VALUES
(1, 'Conductiva', 'Oido externo - medio'),
(2, 'Neurosensorial', 'Oido interno'),
(3, 'Mixta', 'Oido medio - interno'),
(4, 'Retrococlear', 'Oido interno / nervio auditivo'),
(5, 'No lo se', 'N/a');

-- Carga ROL

INSERT INTO `Rol` (`ID_rol`, `nombre`) VALUES
(1, 'Administrador'),
(2, 'Usuario Base');