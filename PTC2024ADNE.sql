USE master
GO

DROP DATABASE IF EXISTS ADNE2024
GO

CREATE DATABASE ADNE2024
GO

USE ADNE2024
GO

---------------------------------------* CREACIÓN DE COMBOBOX *---------------------------------------

--Se crea la tabla de Desempeño
CREATE TABLE Desempeno(
--		CAMPO				TIPO DE DATO			RESTRICCIONES
		desempenoId			INT						IDENTITY (1,1) PRIMARY KEY,
		desempeno			VARCHAR(60)				NOT NULL
)
GO

--Insertamos los roles que existen en ADNE
INSERT INTO Desempeno VALUES
('Administrador'),
('Empleado')
GO

SELECT * FROM Desempeno
GO

--Se crea la tabla de Especialidad
CREATE TABLE Especialidad(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		especialidadId		INT						IDENTITY (1,1) PRIMARY KEY,
		nombreEspecialidad	VARCHAR(50)				NOT NULL
)
GO

INSERT INTO Especialidad VALUES
('Profesional'),
('Psicólogo'),
('Terapeuta'),
('Educador')
GO

SELECT * FROM Especialidad
GO

--CREATE TABLE EspecialidadAlt(

----		CAMPO					TIPO DE DATO			RESTRICCIONES
--		especialidadAltId		INT						IDENTITY (1,1) PRIMARY KEY,
--		nombreEspecialidadAlt	VARCHAR(50)				NOT NULL
--)
--GO

--INSERT INTO EspecialidadAlt VALUES
--('Profesional'),
--('Psicólogo'),
--('Terapeuta'),
--('Educador'),
--('No posee')
--GO

--SELECT * FROM EspecialidadAlt
--GO

--Se crea la tabla de Genero
CREATE TABLE Genero(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		generoId			INT						IDENTITY (1,1) PRIMARY KEY,
		genero				VARCHAR(45)				NOT NULL
)
GO

INSERT INTO Genero VALUES
('Masculino'),
('Femenino'),
('LGBT Comunity'),
('Otro')
GO

SELECT * FROM Genero
GO

--Se crea la tabla de Estado
CREATE TABLE Estado(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		estadoId			INT						IDENTITY (1,1) PRIMARY KEY,
		estado				VARCHAR(45)				NOT NULL
)
GO

INSERT INTO Estado VALUES
('Atendida'),
('Pendiente'),
('Perdida')
GO

SELECT * FROM Estado
GO

CREATE TABLE Lugar(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		lugarId				INT						IDENTITY (1,1) PRIMARY KEY,
		lugar				VARCHAR(45)				NOT NULL
)
GO

INSERT INTO Lugar VALUES
('Presencial'),
('Virtual')
GO

SELECT * FROM Lugar
GO

---------------------------------------* CAMPOS DENTRO DE LOS CRUD *---------------------------------------

--Se crea la tabla Usuario
CREATE TABLE Usuario(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		usuarioId			INT						IDENTITY (1,1) PRIMARY KEY,
		nombreUsuario		VARCHAR(30)				COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
		contraseña			VARCHAR(256)			NOT NULL,
		correoElectronico	VARCHAR(125)			COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL
)
GO

--------------------------* INSERCIÓN EN LA TABLA USUARIO - CREATE *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= '@nombreUsuario'
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
DECLARE @correoElectronico	VARCHAR(125)		= '@correoElectronico'

INSERT INTO Usuario (nombreUsuario, contraseña, correoElectronico)
OUTPUT INSERTED.usuarioId VALUES 
(@nombreUsuario, @contraseña, @correoElectronico)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA USUARIO CONTRASEÑA - UPDATE *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= 'sanguchito'
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
DECLARE @correoElectronico	VARCHAR(125)		= '@correoElectronico'
UPDATE Usuario SET
contraseña			= @contraseña

WHERE
nombreUsuario = @nombreUsuario OR correoElectronico = @correoElectronico
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA USUARIO - UPDATE *--------------------------
DECLARE @usuarioId			INT					= 1
DECLARE @nombreUsuario		VARCHAR(30)			= '@bin'
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
DECLARE @correoElectronico	VARCHAR(125)		= '@correoGmail'

UPDATE Usuario SET
nombreUsuario		= @nombreUsuario,
contraseña			= @contraseña,
correoElectronico	= @correoElectronico

WHERE
usuarioId = @usuarioId OR correoElectronico = @correoElectronico
GO

--------------------------* CONSLUTA EN LA TABLA USUARIO - READ *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= '@nombreUsuario'
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario AND contraseña = @contraseña
GO

--------------------------* CONSLUTA EN LA TABLA USUARIO CORREO - READ *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= '@nombreUsuario'
DECLARE @correoElectronico	VARCHAR(125)		= '@correoElectronico'
SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario OR correoElectronico = @correoElectronico
GO

--------------------------* CONSLUTA EN LA TABLA USUARIO ID - READ *--------------------------
DECLARE @usuarioId			INT					= 1
SELECT * FROM Usuario WHERE usuarioId = @usuarioId
GO

SELECT * FROM Usuario
GO

--------------------------* ELIMINACIÓN EN LA TABLA USUARIO - DELETE *--------------------------
--DECLARE @usuarioId			INT				= 1

--DELETE FROM Usuario WHERE usuarioId = @usuarioId
--GO

--Se crea la tabla de DatosDelSistema
CREATE TABLE DatosDelSistema(

--		CAMPO					TIPO DE DATO			RESTRICCIONES
		nombreEmpresa			VARCHAR(150)			PRIMARY KEY,
		direccionEmpresa		VARCHAR(300)			NOT NULL,
		correoElectronicoE		VARCHAR(125)			NOT NULL UNIQUE,
		numeroTelefono			VARCHAR(15)				NOT NULL,
		numeroPBX				VARCHAR(15)				NOT NULL,
		fechaCreacionE			DATE					NOT NULL CHECK(fechaCreacionE <= getDate()),
		fotoEmpresa				VARCHAR(200)			NOT NULL
)
GO

--------------------------* INSERCIÓN EN LA TABLA EMPRESA - CREATE *--------------------------
DECLARE @nombreEmpresa			VARCHAR(150)	= 'ADNE'
DECLARE @direccionEmpresa		VARCHAR(300)	= 'Soyapango'
DECLARE @correoElectronicoE		VARCHAR(125)	= 'adne@gmail.com'
DECLARE @numeroTelefono			VARCHAR(15)		= '2273-6000'
DECLARE @numeroPBX				VARCHAR(15)		= '2257-7777'
DECLARE @fechaCreacionE			DATE			= '2024-08-23'
DECLARE @fotoEmpresa			VARCHAR(200)	= 'rutaImagen'

INSERT INTO DatosDelSistema (nombreEmpresa, direccionEmpresa, correoElectronicoE, numeroTelefono, numeroPBX, fechaCreacionE, fotoEmpresa)
VALUES
(@nombreEmpresa, @direccionEmpresa, @correoElectronicoE, @numeroTelefono, @numeroPBX, @fechaCreacionE, @fotoEmpresa)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA EMPRESA - UPDATE *--------------------------
DECLARE @nombreEmpresa			VARCHAR(150)	= 'ADNE'
DECLARE @direccionEmpresa		VARCHAR(300)	= 'Soyapango'
DECLARE @correoElectronicoE		VARCHAR(125)	= 'adne@gmail.com'
DECLARE @numeroTelefono			VARCHAR(15)		= '2273-6000'
DECLARE @numeroPBX				VARCHAR(15)		= '2257-7777'
DECLARE @fechaCreacionE			DATE			= '2024-08-23'
DECLARE @fotoEmpresa			VARCHAR(200)	= 'rutaImagen'

UPDATE DatosDelSistema SET
nombreEmpresa			= @nombreEmpresa,
direccionEmpresa		= @direccionEmpresa,
correoElectronicoE		= @correoElectronicoE,
numeroTelefono			= @numeroTelefono,
numeroPBX				= @numeroPBX,
fechaCreacionE			= @fechaCreacionE,
fotoEmpresa				= @fotoEmpresa

WHERE
nombreEmpresa = @nombreEmpresa
GO

SELECT * FROM DatosDelSistema
GO

--Se crea la tabla principal de Paciente
CREATE TABLE Paciente(
 
--		CAMPO				TIPO DE DATO			RESTRICCIONES
		documentoPresentado	VARCHAR(11)				PRIMARY KEY,
		fechaNacimiento		DATE					NOT NULL CHECK(fechaNacimiento <= getDate()),
		nombre				VARCHAR(65)				NOT NULL,
		apellido			VARCHAR(65)				NOT NULL,
		domicilio			VARCHAR(300),
		nacionalidad		VARCHAR(125)			NOT NULL,
		correoElectronico	VARCHAR(125)			COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
		telefono			VARCHAR(12)				NOT NULL,
		profesion			VARCHAR(100)			NOT NULL,
		edad				INT						NOT NULL,
		composicionFamiliar	VARCHAR(125)			NOT NULL,
		motivo				VARCHAR(300)			NOT NULL,
		antecedente			VARCHAR(300)			NOT NULL,
		descripcionSituacion VARCHAR(300)           NOT NULL,
		aspectosPreocupantes VARCHAR(300)			NOT NULL,
		generoId			INT						FOREIGN KEY REFERENCES Genero(generoId) ON UPDATE CASCADE
)
GO

--------------------------* INSERCIÓN EN LA TABLA PACIENTE - CREATE *--------------------------
DECLARE @documentoPresentado	VARCHAR(11)			= '012345678-9'
DECLARE @fechaNacimiento		DATE				= '2007-12-24'
DECLARE @nombre					VARCHAR(65)			= '@Juan Carlos'
DECLARE @apellido				VARCHAR(65)			= '@Rodríguez Funes'
DECLARE @domicilio				VARCHAR(300)		= '@Santísima Trinidad'
DECLARE @nacionalidad			VARCHAR(125)		= '@Salvadoreña'
DECLARE @correoElectronico		VARCHAR(125)		= '@20240158@ricaldone.edu.sv'
DECLARE @telefono				VARCHAR(12)			= '6317-4848'
DECLARE @profesion				VARCHAR(100)		= '@Estudiante'
DECLARE @edad					INT					= 16
DECLARE @composicionFamiliar	VARCHAR(125)		= '@Toda la familia'
DECLARE @motivo					VARCHAR(300)		= '@Fin de una relación'
DECLARE @antecedente			VARCHAR(300)		= '@Ninguno'
DECLARE @descripcionSituacion	VARCHAR(300)        = '@Un caso de cuidado'   
DECLARE @aspectosPreocupantes	VARCHAR(300)		= '@Su actitud'
DECLARE @generoId				INT					= 1
 
INSERT INTO Paciente(documentoPresentado, fechaNacimiento, nombre, apellido, domicilio, nacionalidad, correoElectronico, telefono, profesion, edad, composicionFamiliar, motivo, antecedente, descripcionSituacion, aspectosPreocupantes, generoId)
VALUES
(@documentoPresentado, @fechaNacimiento, @nombre, @apellido, @domicilio, @nacionalidad, @correoElectronico, @telefono, @profesion, @edad, @composicionFamiliar, @motivo, @antecedente, @descripcionSituacion, @aspectosPreocupantes, @generoId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA PACIENTE - UPDATE *--------------------------
DECLARE @documentoPresentado	VARCHAR(11)			= '012345678-8'
DECLARE @fechaNacimiento		DATE				= '2007-12-24'
DECLARE @nombre					VARCHAR(65)			= '@Camila Alejandra'
DECLARE @apellido				VARCHAR(65)			= '@Claudia Reyes'
DECLARE @domicilio				VARCHAR(300)		= '@----'
DECLARE @nacionalidad			VARCHAR(125)		= '@Salvadoreña'
DECLARE @correoElectronico		VARCHAR(125)		= '@20230559@ricaldone.edu.sv'
DECLARE @telefono				VARCHAR(12)			= '6317-4848'
DECLARE @profesion				VARCHAR(100)		= '@Estudiante'
DECLARE @edad					INT					= 17
DECLARE @composicionFamiliar	VARCHAR(125)		= '@Toda la familia'
DECLARE @motivo					VARCHAR(300)		= '@Fin de una relación'
DECLARE @antecedente			VARCHAR(300)		= '@Ninguno'
DECLARE @descripcionSituacion	VARCHAR(300)        = '@Un caso de cuidado'   
DECLARE @aspectosPreocupantes	VARCHAR(300)		= '@Su actitud'
DECLARE @generoId				INT					= 2
 
UPDATE Paciente SET
documentoPresentado		= @documentoPresentado,
fechaNacimiento			= @fechaNacimiento,
nombre					= @nombre,
apellido				= @apellido,
domicilio				= @domicilio,
nacionalidad			= @nacionalidad,
correoElectronico		= @correoElectronico,
telefono				= @telefono,
profesion				= @profesion,
edad					= @edad,
composicionFamiliar		= @composicionFamiliar,
motivo					= @motivo,
antecedente				= @antecedente,
descripcionSituacion	= @descripcionSituacion,
aspectosPreocupantes	= @aspectosPreocupantes,
generoId				= @generoId
 
WHERE
documentoPresentado = @documentoPresentado
GO

SELECT * FROM Paciente
GO

--------------------------* VISTA EN LA TABLA INFORMACION PERSONAL - READ *--------------------------
CREATE VIEW VistaPaciente AS
SELECT CONCAT (P.nombre,' ',P.apellido) AS 'Nombre de Paciente', P.documentoPresentado AS 'DUI'
FROM Paciente AS p
GO

SELECT * FROM VistaPaciente
GO

--Se crea la tabla de Expediente
CREATE TABLE Expediente(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		expedienteId		INT					    IDENTITY (1,1) PRIMARY KEY,
		estadoAnimo			VARCHAR(500)			NOT NULL,
		estadoConductual	VARCHAR(500)			NOT NULL,
		somatizacion		VARCHAR(500)			NOT NULL,
		vidaInterpersonal	VARCHAR(500)			NOT NULL,
		cognicion			VARCHAR(500)			NOT NULL,
		redSocial			VARCHAR(500)			NOT NULL,
		pauta				VARCHAR(500)			NOT NULL,
		riesgoValorado		VARCHAR(500)			NOT NULL,
		observacion			VARCHAR(500)			NOT NULL,
		aproximacionDiag	VARCHAR(500)			NOT NULL,
		atencionBrindada	VARCHAR(500)			NOT NULL,
		documentoPresentado	VARCHAR(11)				FOREIGN KEY REFERENCES Paciente(documentoPresentado) ON UPDATE CASCADE ON DELETE CASCADE UNIQUE
)
GO
--------------------------* INSERCIÓN EN LA TABLA EXPEDIENTE - CREATE *--------------------------
DECLARE @estadoAnimo			VARCHAR(500)		= '@Estable'
DECLARE @estadoConductual		VARCHAR(500)		= '@Alegre'
DECLARE @somatizacion			VARCHAR(500)		= '@Dolor Sentimental'
DECLARE @vidaInterpersonal		VARCHAR(500)		= '@Normal'
DECLARE @cognicion				VARCHAR(500)		= '@Aprendizaje rápido, buen lenguaje corporal'
DECLARE @redSocial				VARCHAR(500)		= '@Facebook, Instagram'
DECLARE @pauta					VARCHAR(500)		= '@Cursiva'
DECLARE @riesgoValorado			VARCHAR(500)		= '@Impacto en emociones'
DECLARE @observacion			VARCHAR(500)		= '@Paciente en mejora'
DECLARE @aproximacionDiag		VARCHAR(500)		= '@Mejora educativa en el ámbito de psicopedagogo'
DECLARE @atencionBrindada		VARCHAR(500)		= '@Profesional encargado'
DECLARE @documentoPresentado	VARCHAR(11)			= '012345678-9'

INSERT INTO Expediente(estadoAnimo, estadoConductual, somatizacion, vidaInterpersonal, cognicion, redSocial, pauta, riesgoValorado, observacion, aproximacionDiag, atencionBrindada, documentoPresentado)
VALUES 
(@estadoAnimo, @estadoConductual, @somatizacion, @vidaInterpersonal, @cognicion, @redSocial, @pauta, @riesgoValorado, @observacion, @aproximacionDiag, @atencionBrindada, @documentoPresentado)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA EXPEDIENTE - UPDATE *--------------------------
DECLARE @expedienteId			INT					= 1
DECLARE @estadoAnimo			VARCHAR(500)		= '@Estable'
DECLARE @estadoConductual		VARCHAR(500)		= '@Triste'
DECLARE @somatizacion			VARCHAR(500)		= '@Dolor Sentimental'
DECLARE @vidaInterpersonal		VARCHAR(500)		= '@Normal'
DECLARE @cognicion				VARCHAR(500)		= '@Aprendizaje rápido, buen lenguaje corporal'
DECLARE @redSocial				VARCHAR(500)		= '@Whatsapp'
DECLARE @pauta					VARCHAR(500)		= '@Molde'
DECLARE @riesgoValorado			VARCHAR(500)		= '@Impacto en emociones'
DECLARE @observacion			VARCHAR(500)		= '@Paciente en mejora'
DECLARE @aproximacionDiag		VARCHAR(500)		= '@Mejora educativa en el ámbito de psicopedagogo'
DECLARE @atencionBrindada		VARCHAR(500)		= '@Profesional encargado'
DECLARE @documentoPresentado	VARCHAR(11)			= '012345678-9'

UPDATE Expediente SET
estadoAnimo			= @estadoAnimo,
estadoConductual	= @estadoConductual,
somatizacion		= @somatizacion,
vidaInterpersonal	= @vidaInterpersonal,
cognicion			= @cognicion,
redSocial			= @redSocial,
pauta				= @pauta,
riesgoValorado		= @riesgoValorado,
observacion			= @observacion,
aproximacionDiag	= @aproximacionDiag,
atencionBrindada	= @atencionBrindada,
documentopresentado	= @documentoPresentado

WHERE
expedienteId = @expedienteId
GO

--Se crea la tabla de Profesional
CREATE TABLE Profesional(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		DUI					VARCHAR(11)				PRIMARY KEY,
		telefono			VARCHAR(10)				NOT NULL,
		nombre				VARCHAR(65)				NOT NULL,
		apellido			VARCHAR(65)				NOT NULL,
		correoElectronico	VARCHAR(125)			COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
		foto				VARCHAR(200)			NOT NULL,
		desempenoId			INT						FOREIGN KEY REFERENCES Desempeno(desempenoId) ON UPDATE CASCADE ON DELETE NO ACTION,
		usuarioId			INT						FOREIGN KEY REFERENCES Usuario(usuarioId) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

--------------------------* INSERCIÓN EN LA TABLA PROFESIONAL - CREATE *--------------------------
DECLARE @DUI					VARCHAR(11)		= '012345688-9'
DECLARE @telefono				VARCHAR(11)		= '@telefono'
DECLARE @nombre					VARCHAR(65)		= '@nombre'
DECLARE @apellido				VARCHAR(65)		= '@apellido'
DECLARE @correoElectronico		VARCHAR(125)	= '@correoElectronico'
DECLARE @foto					VARCHAR(200)	= '@Directorio de la Imagen'
DECLARE @desempenoId			INT				= 1
DECLARE @usuarioId				INT				= 1

INSERT INTO Profesional(DUI, telefono, nombre, apellido, correoElectronico, foto, desempenoId, usuarioId)
VALUES 
(@DUI, @telefono, @nombre, @apellido, @correoElectronico, @foto, @desempenoId, @usuarioId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA PROFESIONAL - UPDATE *--------------------------
DECLARE @DUI					VARCHAR(11)		= '012345688-9'
DECLARE @telefono				VARCHAR(11)		= '@telefono'
DECLARE @nombre					VARCHAR(65)		= '@nombre'
DECLARE @apellido				VARCHAR(65)		= '@apellido'
DECLARE @correoElectronico		VARCHAR(125)	= '@correoElectronico'
DECLARE @foto					VARCHAR(200)	= '@Directorio de la Imagen'
DECLARE @desempenoId			INT				= 1

UPDATE Profesional SET
telefono			= @telefono,
nombre				= @nombre,
apellido			= @apellido,
correoElectronico	= @correoElectronico,
foto				= @foto,
desempenoId			= @desempenoId

WHERE
DUI = @DUI
GO

SELECT * FROM Profesional
GO

-- Creacion de la tabla intermediaria Nombre Especialidades
CREATE TABLE NombreEspecialidades(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		especialidadNId		INT						IDENTITY (1,1) PRIMARY KEY,
		DUI					VARCHAR(11)				FOREIGN KEY REFERENCES Profesional(DUI) ON UPDATE CASCADE ON DELETE CASCADE,
		especialidadId		INT						FOREIGN KEY REFERENCES Especialidad(especialidadId) ON UPDATE CASCADE ON DELETE SET NULL,

		-- Creamos la restricción validando que, un mismo profesional, no posea la misma especialidad, sin embargo la relación de muchos a muchos se mantiene estática
		CONSTRAINT UQ_DUI_Especialidad UNIQUE (DUI, especialidadId)
)
GO

DECLARE @DUI					VARCHAR(11)		= '012345688-9'
DECLARE @especialidadId			INT				= 2

INSERT INTO NombreEspecialidades (DUI, especialidadId)
VALUES 
(@DUI, @especialidadId)
GO

SELECT * FROM NombreEspecialidades WHERE DUI = '08912798-0'
GO

--------------------------* VISTA EN LA TABLA NOMBRE DE ESPECIALIDADES - READ *--------------------------
CREATE VIEW vistaEspecialidades AS
SELECT N.DUI AS 'DUI', N.especialidadNId, CONCAT (P.nombre,' ', P.apellido) AS 'Nombre del Profesional', E.nombreEspecialidad AS 'Nombre de la Especialidad'
FROM NombreEspecialidades AS N
INNER JOIN Profesional AS P ON N.DUI = P.DUI
INNER JOIN Especialidad AS E ON N.especialidadId = E.especialidadId
GO

SELECT * FROM vistaEspecialidades WHERE DUI = '89723498-2'
GO

SELECT * FROM Desempeno
GO

--------------------------* VISTA EN LA TABLA PROFESIONAL - READ *--------------------------
CREATE VIEW vistaProfesional AS
SELECT P.DUI, P.telefono, CONCAT(P.nombre, ' ', P.apellido) AS 'Nombre del Profesional', P.foto, D.desempeno, U.nombreUsuario AS 'Nombre del Usuario', STRING_AGG(E.nombreEspecialidad, ', ') AS 'Nombre de la Especialidad'
FROM Profesional AS P
INNER JOIN Desempeno AS D ON P.desempenoId = D.desempenoId
INNER JOIN Usuario AS U ON P.usuarioId = U.usuarioId
INNER JOIN NombreEspecialidades AS N ON P.DUI = N.DUI
LEFT JOIN Especialidad AS E ON N.especialidadId = E.especialidadId

GROUP BY
	P.DUI,
	P.telefono,
	P.nombre,
	P.apellido,
	P.foto,
	D.desempeno,
	U.nombreUsuario
GO

SELECT * FROM vistaProfesional
GO

--------------------------* VISTA EN LA TABLA PROFESIONAL CON PARÁMETROS - READ *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= 'sanguchito'

SELECT * FROM vistaProfesional WHERE [Nombre del Usuario] = @nombreUsuario
GO

--------------------------* VISTA EN LA TABLA PROFESIONAL DATA GRID - READ *--------------------------
CREATE VIEW vistaProfesionalDGV AS
SELECT P.usuarioId AS 'ID Usuario', P.DUI AS 'DUI', P.telefono AS 'Teléfono', P.nombre AS 'Nombres', P.apellido AS 'Apellidos', P.correoElectronico AS 'Correo Electrónico', P.foto AS 'Imagen de la Persona', D.desempeno AS 'Desempeño', U.nombreUsuario AS 'Nombre del Usuario', STRING_AGG(E.nombreEspecialidad, ', ') AS 'Especialidades'
FROM Profesional AS P
INNER JOIN Desempeno AS D ON P.desempenoId = D.desempenoId
INNER JOIN Usuario AS U ON P.usuarioId = U.usuarioId
INNER JOIN NombreEspecialidades AS N ON P.DUI = N.DUI
LEFT JOIN Especialidad AS E ON N.especialidadId = E.especialidadId

GROUP BY
	P.usuarioId,
	P.DUI,
	P.telefono,
	P.nombre,
	P.apellido,
	P.correoElectronico,
	P.foto,
	D.desempeno,
	U.nombreUsuario
GO

SELECT * FROM vistaProfesionalDGV
GO

--------------------------* VISTA EN LA TABLA PROFESIONAL USERCONTROL - READ *--------------------------
CREATE VIEW vistaDataTable AS
SELECT P.DUI, CONCAT(P.nombre, ' ', P.apellido) AS 'Nombre del Profesional', P.correoElectronico, STRING_AGG(E.nombreEspecialidad, ', ') AS 'Especialidades'
FROM Profesional AS P
INNER JOIN NombreEspecialidades AS N ON P.DUI = N.DUI
LEFT JOIN Especialidad AS E ON N.especialidadId = E.especialidadId

GROUP BY
	P.DUI,
	P.nombre,
	P.apellido,
	P.correoElectronico
GO

SELECT * FROM vistaDataTable
GO

--Se crea la tabla de Cita
CREATE TABLE Cita(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		citaId				INT						IDENTITY (1,1) PRIMARY KEY,
		fecha				DATE					NOT NULL CHECK(fecha >= getDate()),
		horaInicio			TIME					NOT NULL,
		horaFinal			TIME					NOT NULL,
		estadoId			INT						FOREIGN KEY REFERENCES Estado(estadoId) ON UPDATE CASCADE ON DELETE SET NULL, 
		documentoPresentado	VARCHAR(11)				FOREIGN KEY REFERENCES Paciente(documentoPresentado) ON UPDATE CASCADE ON DELETE NO ACTION,
		DUI					VARCHAR(11)				FOREIGN KEY REFERENCES Profesional(DUI) ON UPDATE CASCADE ON DELETE SET NULL,
		lugarId				INT						FOREIGN KEY REFERENCES Lugar(lugarId) ON UPDATE CASCADE ON DELETE SET NULL
)
GO

--------------------------* INSERCIÓN EN LA TABLA CITA - CREATE *--------------------------
DECLARE @fecha					DATE			= '2024-12-21'
DECLARE @horaInicio				TIME			= '13:30:00'
DECLARE @horaFinal				TIME			= '13:30:00'
DECLARE @estadoId				INT				= 1
DECLARE @documentoPresentado	VARCHAR(11)		= '012345678-9'
DECLARE @DUI					VARCHAR(11)		= '012345688-9'
DECLARE @lugarId				INT				= 1

INSERT INTO Cita (fecha, horaInicio, horaFinal, estadoId, documentoPresentado, DUI, lugarId)
 OUTPUT INSERTED.citaId VALUES  
(@fecha, @horaInicio, @horaFinal, @estadoId, @documentoPresentado, @DUI, @lugarId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA CITA - UPDATE *--------------------------
DECLARE @citaId					INT				= 2
DECLARE @fecha					DATE			= '2024-12-21'
DECLARE @horaInicio				TIME			= '13:30:00'
DECLARE @horaFinal			    TIME			= '13:30:00'
DECLARE @estadoId				INT				= 1
DECLARE @documentoPresentado	VARCHAR(11)		= '012345678-9'
DECLARE @DUI					VARCHAR(11)		= '012345688-9'
DECLARE @lugarId				INT				= 1

UPDATE Cita SET
fecha				= @fecha,
horaInicio			= @horaInicio,
horaFinal			= @horaFinal,
estadoId			= @estadoId,
documentoPresentado	= @documentoPresentado,
DUI					= @DUI,
lugarId				= @lugarId

WHERE
citaId = @citaId
GO

SELECT * FROM Cita
GO

--Se crea la tabla de Consulta
CREATE TABLE Consulta(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		consultaId			INT						IDENTITY (1,1) PRIMARY KEY,
		descripcion			VARCHAR(500)			NOT NULL,
		citaId				INT						FOREIGN KEY REFERENCES Cita(citaId) ON UPDATE CASCADE ON DELETE CASCADE UNIQUE
)
GO

--------------------------* INSERCIÓN EN LA TABLA CONSULTA - CREATE *--------------------------
DECLARE @descripcion		VARCHAR(500)		= '@El paciente se encuentra en buen estado'
DECLARE @citaId				INT					= 1

INSERT INTO Consulta (descripcion, citaId)
VALUES 
(@descripcion, @citaId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA CONSULTA - UPDATE *--------------------------
DECLARE @consultaId			INT					= 1
DECLARE @descripcion		VARCHAR(500)		= '@El paciente se encuentra en MAL estado'
DECLARE @citaId				INT					= 1

UPDATE Consulta SET
descripcion			= @descripcion,
citaId				= @citaId

WHERE
consultaId = @consultaId
GO

SELECT * FROM Consulta
GO

--------------------------* VISTA EN LA TABLA CITAS - READ *--------------------------
CREATE VIEW vistaCitasAgendadas AS
SELECT C.citaId AS 'ID de la Cita', CU.consultaId AS 'ID de la Consulta', C.documentoPresentado AS 'DUI', C.DUI AS 'ID del Profesional', C.fecha AS 'Fecha de la Cita', C.horaInicio AS 'Hora de Inicio', C.horaFinal AS 'Hora de Finalización', E.estado AS 'Estado de la Cita', CU.descripcion AS 'Descripción', P.nombre AS 'Nombre del Paciente', P.apellido AS 'Apellido del Paciente', PR.nombre AS 'Profesional Encargado', L.lugar AS 'Lugar de la Cita'
FROM Consulta AS CU
INNER JOIN Cita AS C ON CU.citaID = C.citaId
INNER JOIN Estado AS E ON C.estadoId = E.estadoId
INNER JOIN Paciente AS P ON C.documentoPresentado = P.documentoPresentado
INNER JOIN Profesional AS PR ON C.DUI = PR.DUI
INNER JOIN Lugar AS L ON C.lugarId = L.lugarId
GO

SELECT * FROM vistaCitasAgendadas
GO

--------------------------* VISTA EN LA TABLA INFORMACION PERSONAL, EXPEDIENTE Y CITAS PARA EL PDF - READ *--------------------------
CREATE VIEW vistaObtenerInformacionYExpediente AS
--////** Vista para los datos del paciente - Información Personal **////--
SELECT E.expedienteId AS 'Nº de Expediente', CONCAT (P.nombre, ' ', P.apellido) AS 'Nombre del paciente', P.domicilio AS 'Domicilio', P.nacionalidad AS 'Nacionalidad', P.documentoPresentado AS 'Documento Presentado', P.telefono AS 'Teléfono',
P.edad AS 'Edad del Paciente', G.genero AS 'Género', P.profesion AS 'Profesión', P.composicionFamiliar AS 'Composición Familiar', P.motivo AS 'Motivo de la Consulta', P.antecedente AS 'Antecedentes Relevantes', P.descripcionSituacion AS 'Descripción de la Situación',
P.aspectosPreocupantes AS 'Aspectos preocupantes',

----////** Vista para los datos del paciente - Expediente **////--
E.estadoAnimo AS 'Afectividad y sintomatología', E.estadoConductual AS 'Estado Conductual', E.somatizacion AS 'Somatizaciones', E.vidaInterpersonal AS 'Vida Interpersonal, Cambios y manejo', E.cognicion AS 'Cogniciones', E.redSocial AS 'Redes sociales de apoyo',
E.pauta AS 'Pautas de afrontamiento', E.riesgoValorado AS 'Valoración del riesgo', E.observacion AS 'Observaciones Generales', E.aproximacionDiag AS 'Aproximaciones Diagnósticas', E.atencionBrindada AS 'Atención brindada', C.fecha AS 'Fecha de la Cita',
L.lugar AS 'Lugar de la Cita', CO.descripcion AS 'Descripción de la Cita',

----////** Creamos los ID que nos servirán para declarar restricciones dentro de la Vista **////--
P.documentoPresentado AS 'ID del Paciente', E.expedienteId AS 'ID del Expediente', C.citaId AS 'ID de la Cita'

FROM Expediente AS E
INNER JOIN Paciente AS P ON E.documentoPresentado = P.documentoPresentado
INNER JOIN Genero AS G ON P.generoId = G.generoId
INNER JOIN Cita AS C ON P.documentoPresentado = C.documentoPresentado
INNER JOIN Lugar AS L ON C.lugarId = L.lugarId
LEFT JOIN Consulta AS CO ON C.citaId = CO.citaId
GO

DECLARE @documentoPresentado	VARCHAR(11)			= '012345678-9'
DECLARE @expedienteId			INT					= 1
DECLARE @citaId					INT					= 1

SELECT * FROM vistaObtenerInformacionYExpediente --WHERE DUI = @pacienteId AND [ID del Expediente] = @expedienteId AND [ID de la Cita] = @citaId
GO

CREATE VIEW vistaCita AS
SELECT C.citaId , C.documentoPresentado, ESP.expedienteId, E.estado AS 'Estado', CONCAT(P.nombre, ' ', P.apellido) AS 'Nombre del Paciente', C.fecha AS 'Fecha de la Cita', C.horaInicio 'Hora de Inicio'
FROM Cita AS C
INNER JOIN Paciente AS P ON C.documentoPresentado = P.documentoPresentado
INNER JOIN Estado AS E ON C.estadoId = E.estadoId
INNER JOIN Expediente AS ESP ON P.documentoPresentado = ESP.documentoPresentado
GO

SELECT * FROM vistaCita --WHERE [Nombre del Paciente] LIKE '%Eduardo%'
GO

DELETE FROM DatosDelSistema
GO

DELETE FROM Profesional
GO

DELETE FROM Usuario
GO

DELETE FROM Cita
GO

DELETE FROM Paciente
GO

DELETE FROM Expediente
GO

DELETE FROM Consulta
GO

--------------------------* VISTAS EN LA TABLA CITAS, ESTRUCTURA PARA EL CAMPO DE ESTADÍSTICAS - READ *--------------------------
SELECT COUNT (citaId) FROM Cita WHERE estadoId = 1	-- Para que se muestre en el dash las 3 opciones de Edwinaso Bv
GO
SELECT COUNT (citaId) FROM Cita WHERE estadoId = 2	-- Para la opción de cita perdida 
GO
SELECT COUNT (citaId) FROM Cita WHERE estadoId = 3	-- Para la opción de cita pendiente 
GO

DECLARE  @rangoInicio	DATE ='2024-08-30'
DECLARE  @rangoFinal	DATE ='2024-09-10' 

SELECT COUNT (citaId) FROM Cita WHERE fecha BETWEEN  @rangoInicio AND @rangoFinal -- Para que se muestre parametros de 30 dias
GO

DECLARE  @fechaInicio	DATE ='2024-08-30'
DECLARE  @fechaFinal	DATE ='2024-09-10' 

SELECT fecha, COUNT(citaId) FROM Cita WHERE fecha BETWEEN @fechaInicio AND @fechaFinal GROUP BY fecha
GO