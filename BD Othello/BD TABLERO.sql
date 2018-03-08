--Tablero
CREATE TABLE tablero(
	id_tablero SERIAL PRIMARY KEY,
	matriz VARCHAR,
	tamaño VARCHAR
)

-- funcion insertar tablero
CREATE OR REPLACE FUNCTION insertar_tablero(
	matriz VARCHAR,
	tamaño VARCHAR
)RETURNS void AS
$BODY$
BEGIN
	RAISE NOTICE 'Insertando';
	INSERT INTO tablero(matriz,tamaño) VALUES(matriz,tamaño);
	RAISE NOTICE 'Se inserto Usuario';
END $BODY$
LANGUAGE plpgsql;

--funcion editar tablero
CREATE OR REPLACE FUNCTION editar_tablero(
	id_t INTEGER,
	mat VARCHAR
)RETURNS void AS
$BODY$
BEGIN
	UPDATE tablero SET
		matriz=mat
	WHERE id_tablero=id_t;
		
END $BODY$
LANGUAGE plpgsql;

--funcion eliminar tablero
CREATE OR REPLACE FUNCTION eliminar_tablero(
	id INTEGER
)RETURNS void AS
$BODY$
BEGIN
	RAISE NOTICE 'Eliminando';
	DELETE FROM partida WHERE id_tablero=id;
	DELETE FROM tablero WHERE id_tablero=id;
	RAISE NOTICE 'Eliminación exitosa';
END $BODY$
LANGUAGE plpgsql;

-- prueba tablero --
-- select * from tablero
-- select insertar_tablero('1.2,3.2,4.2','5x5');
-- select editar_tablero(1,'1,2,0.2,1.2');
-- select eliminar_tablero(2);