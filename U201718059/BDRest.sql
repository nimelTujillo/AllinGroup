CREATE TABLE BDOperaciaciones
USE BDOperaciaciones

CREATE TABLE usuario(
dni_usuario INT NOT NULL PRIMARY KEY,
nombre VARCHAR(30),
apellido VARCHAR(40),
email VARCHAR(50)
usu_login VARCHAR(50),
pass_login VARCHAR(50),
tx_estado VARCHAR(20) 
)

INSERT INTO usuario VALUES(12345678, 'Nimel', 'Trujillo Ramos', 'nimel.tr@gmail.com', 'ntrujillo', '12345', 'ACTIVO')
