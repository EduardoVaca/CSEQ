-- Funcion RBAC

DELIMITER //
CREATE PROCEDURE validacionLogin
(IN loginInput VARCHAR(30), passwordInput VARCHAR(30))
BEGIN
	SELECT ID_rol FROM Usuario u, TieneRol t
	WHERE u.login = loginInput AND password_usuario = passwordInput AND t.login = u.login;
END //
DELIMITER ;



DELIMITER //
CREATE PROCEDURE validacionNombreLogin
(IN loginInput VARCHAR(30))
BEGIN
	SELECT Login FROM Usuario
	WHERE Login = loginInput;
END //
DELIMITER ;
