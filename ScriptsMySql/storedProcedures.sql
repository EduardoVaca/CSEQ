--************************************************
--STORED PROCEDURES
--************************************************
--

--NUEVOS REGISTROS ******************************************************************************************************

--CAUSA
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarCausa`(IN nombreCausa CHAR(50))
BEGIN
	INSERT INTO Causa VALUES (0, nombreCausa);
END

--COLONIA
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarColonia`(IN nombreColonia CHAR(50), ID_delegacion INT, ID_municipio INT)
BEGIN
	INSERT INTO Colonia VALUES (0, nombreColonia, ID_delegacion, ID_municipio);
END

--DELEGACION
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarDelegacion`(IN nombreDelegacion CHAR (80), ID_municipio INT)
BEGIN
	INSERT INTO Delegacion VALUES (0, nombreDelegacion, ID_municipio);
END

--MUNICIPIO 
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarMunicipio`(IN nombreMunicipio CHAR(70), ID_estado INT)
BEGIN
	INSERT INTO Municipio VALUES (0, nombreMunicipio, ID_estado);
END

--ESTADO 
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarEstado`(IN nombreEstado CHAR(70))
BEGIN
	INSERT INTO Estado VALUES(0, nombreEstado);
END

--CENSO
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarCenso`(IN anoCenso INT)
BEGIN
	INSERT INTO Censo VALUES (0, anoCenso);
END

--APARATOAUDITIVO
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarAparatoAuditivo`(IN tipo CHAR(70), ID_marca INT)
BEGIN
	INSERT INTO AparatoAuditivo VALUES(0, tipo, ID_marca);
END

--MARCA
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarMarca`(IN nombreMarca CHAR(40))
BEGIN
	INSERT INTO Marca VALUES (0, nombreMarca);
END

--SUELDO
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarSueldo`(IN minimo CHAR(20), maximo CHAR(20))
BEGIN
	INSERT INTO Sueldo VALUES (0, minimo, maximo);
END

--AREATRABAJO
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarAreaTrabajo`(IN nombreArea varchar(60))
BEGIN
	INSERT INTO AreaTrabajo VALUES (0, nombreArea);
END

--****************************************************************************************************************8
---------------------------------PENDIENTES : Persona - InstitucionEducativa