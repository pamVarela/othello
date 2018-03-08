
--Tabla de usuarios
CREATE TABLE usuario(
	correo VARCHAR(50) PRIMARY KEY,
	nombre_usuario VARCHAR(20),
	contraseña VARCHAR(20),
	partidas_Ganadas INTEGER,
	partidas_Perdidas INTEGER,
	partidas_Empates INTEGER
)


-- funcion insertar usuarios
CREATE OR REPLACE FUNCTION insertar_usuario(
	u_correo VARCHAR(50) ,
	u_nombre_usuario VARCHAR(20),
	u_contraseña VARCHAR(20)
)RETURNS void AS
$BODY$
BEGIN
	RAISE NOTICE 'Insertando';
	INSERT INTO usuario VALUES(u_correo,u_nombre_usuario,u_contraseña,0,0,0);
	RAISE NOTICE 'Se inserto Usuario';
END $BODY$
LANGUAGE plpgsql;

--funcion editar usuarios
CREATE OR REPLACE FUNCTION editar_usuario(
	u_correo VARCHAR(50),
	u_nombre_usuario VARCHAR(20),
	u_contraseña VARCHAR(20),
	u_partidas_Ganadas INTEGER,
	u_partidas_Perdidas INTEGER,
	u_partidas_Empates INTEGER
)RETURNS void AS
$BODY$
BEGIN
	UPDATE usuario SET
		nombre_usuario=u_nombre_usuario,
		contraseña=u_contraseña,
		partidas_Ganadas=u_partidas_Ganadas,
		partidas_Perdidas=u_partidas_Perdidas,
		partidas_Empates= u_partidas_Empates
	WHERE nombre_usuario=u_nombre_usuario;
		
END $BODY$
LANGUAGE plpgsql;

--funcion eliminar usuarios
CREATE OR REPLACE FUNCTION eliminar_usuario(
	u_correo VARCHAR(50)
)RETURNS void AS
$BODY$
BEGIN
	DELETE FROM tablero WHERE (SELECT id_tablero FROM partida WHERE u_correo=correo_p) = id_tablero;

	DELETE FROM tablero WHERE (SELECT id_tablero FROM partida WHERE u_correo=correo) = id_tablero;

	DELETE FROM usuario WHERE correo=u_correo; 

	RAISE NOTICE 'Eliminación exitosa';
END $BODY$
LANGUAGE plpgsql;

-- select * from tablero
-- select * from partida
-- prueba usuario --
-- select * from usuario
-- select insertar_tablero('1,2,1,0,0,0,0,1,2','5x5')
-- select insertar_partida('Jurguen.r.r@gmail.com','Jurguen.r.r@gmail.com',4)
-- select insertar_usuario('Jurguen.r.r@gmail.com','Jurguen','jurguen11');
-- select editar_usuario('Jurguen.r.r@gmail.com','Jurguen','jurguen11',0,0,2);
-- select eliminar_usuario('Jurguen.r.r@gmail.com')