--Tabla partida
CREATE TABLE partida(
	id_partida SERIAL PRIMARY KEY,
	correo_p VARCHAR(50),
	correo VARCHAR(50),
	id_tablero INTEGER,
	CONSTRAINT FK_id_tablero FOREIGN KEY(id_tablero) REFERENCES tablero ON DELETE CASCADE,
	CONSTRAINT FK_correo_p FOREIGN KEY(correo_p) REFERENCES usuario ON DELETE CASCADE,
	CONSTRAINT FK_correo FOREIGN KEY(correo) REFERENCES usuario ON DELETE CASCADE
)

-- funcion insertar partida
CREATE OR REPLACE FUNCTION insertar_partida(
	c_p VARCHAR(50),
	c VARCHAR(50),
	id_t INTEGER
)RETURNS void AS
$BODY$
BEGIN
	RAISE NOTICE 'Insertando';
	INSERT INTO partida(correo_p,correo,id_tablero) VALUES(c_p,c,id_t);
	RAISE NOTICE 'Se inserto Partida';
END $BODY$
LANGUAGE plpgsql;

--funcion editar partida
CREATE OR REPLACE FUNCTION editar_partida(
	id integer,
	c_p VARCHAR(50),
	c VARCHAR(50),
	id_t INTEGER
)RETURNS void AS
$BODY$
BEGIN
	UPDATE partida SET
		correo_p=c_p,
		correo=c,
		id_tablero=id_t
	WHERE id_partida=id;
		
END $BODY$
LANGUAGE plpgsql;

--funcion eliminar partida
CREATE OR REPLACE FUNCTION eliminar_partida(
	id INTEGER
)RETURNS void AS
$BODY$
BEGIN
	RAISE NOTICE 'Eliminando';
	DELETE FROM partida WHERE id_partida=id; 
	RAISE NOTICE 'Eliminación exitosa';
END $BODY$
LANGUAGE plpgsql;

-- prueba partida --

--select * from partida
--select * from usuario
--select * from tablero

--select insertar_tablero('1.2,3.2,4.2','5x5');
--select insertar_usuario('Jurguen.r.r@gmail.com','Jurguen','12345');
--select insertar_usuario('Jurguen111615@gmail.com','Jurguen','12345');
--select insertar_partida('Jurguen.r.r@gmail.com','Jurguen111615@gmail.com',2)
--select editar_partida(1,'Jurguen111615@gmail.com','Jurguen.r.r@gmail.com',2);
--select eliminar_partida(1)
--select eliminar_tablero(2)