USE MASTER
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

CREATE TABLE EspecialidadAlt(

--		CAMPO					TIPO DE DATO			RESTRICCIONES
		especialidadAltId		INT						IDENTITY (1,1) PRIMARY KEY,
		nombreEspecialidadAlt	VARCHAR(50)				NOT NULL
)
GO

INSERT INTO EspecialidadAlt VALUES
('Profesional'),
('Psicólogo'),
('Terapeuta'),
('Educador'),
('No posee')
GO

SELECT * FROM EspecialidadAlt
GO

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

--Se crea la tabla de Consulta
CREATE TABLE Consulta(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		consultaId			INT						IDENTITY (1,1) PRIMARY KEY,
		descripcion			VARCHAR(500)			NOT NULL,
)
GO

--------------------------* INSERCIÓN EN LA TABLA CONSULTA - CREATE *--------------------------
DECLARE @descripcion		VARCHAR(500)		= '@El paciente se encuentra en buen estado'

INSERT INTO Consulta (descripcion)
OUTPUT INSERTED.consultaId VALUES 
(@descripcion)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA CONSULTA - UPDATE *--------------------------
DECLARE @consultaId			INT					= 5
DECLARE @descripcion		VARCHAR(500)		= '@El paciente se encuentra en MAL estado'

UPDATE Consulta SET
descripcion			= @descripcion

WHERE
consultaId = @consultaId
GO

SELECT * FROM Consulta
GO

--Se crea la tabla Usuario
CREATE TABLE Usuario(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		usuarioId			INT						IDENTITY (1,1) PRIMARY KEY,
		nombreUsuario		VARCHAR(30)				COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
		contraseña			VARCHAR(256)			NOT NULL,
		pinAcceso			INT						UNIQUE NOT NULL,
		correoElectronico	VARCHAR(125)			COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL
)
GO

--------------------------* INSERCIÓN EN LA TABLA USUARIO - CREATE *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= '@nombreUsuario'
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
DECLARE @pinAcceso			INT					= 12345678
DECLARE @correoElectronico	VARCHAR(125)		= '@correoElectronico'

INSERT INTO Usuario (nombreUsuario, contraseña, pinAcceso, correoElectronico)
OUTPUT INSERTED.usuarioId VALUES 
(@nombreUsuario, @contraseña, @pinAcceso, @correoElectronico)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA USUARIO CONTRASEÑA - UPDATE *--------------------------
DECLARE @usuarioId			INT					= 1
DECLARE @contraseña			VARCHAR(256)		= '@contraseña'
UPDATE Usuario SET
contraseña			= @contraseña

WHERE
usuarioId = @usuarioId
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
usuarioId = @usuarioId
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

--------------------------* CONSLUTA EN LA TABLA USUARIO PIN ACCESO - READ *--------------------------
DECLARE @pinAcceso			INT					= 12345678
SELECT * FROM Usuario WHERE pinAcceso = @pinAcceso
GO

SELECT * FROM Usuario
GO

--------------------------* ELIMINACIÓN EN LA TABLA USUARIO - DELETE *--------------------------
--DECLARE @usuarioId			INT				= 1

--DELETE FROM Usuario WHERE usuarioId = @usuarioId
--GO

--Se crea la tabla principal de Paciente
CREATE TABLE Paciente(
 
--		CAMPO				TIPO DE DATO			RESTRICCIONES
		pacienteId			INT						PRIMARY KEY,
		fechaNacimiento		DATE					NOT NULL CHECK(fechaNacimiento <= getDate()),
		nombre				VARCHAR(65)				NOT NULL,
		apellido			VARCHAR(65)				NOT NULL,
		domicilio			VARCHAR(300),
		nacionalidad		VARCHAR(125)			NOT NULL,
		documentoPresentado	VARCHAR(125)			NOT NULL,
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
DECLARE @pacienteId int   = 1
SELECT * FROM Paciente WHERE pacienteId = @pacienteId
GO
--------------------------* INSERCIÓN EN LA TABLA PACIENTE - CREATE *--------------------------
DECLARE @pacienteId				INT					= 0001
DECLARE @fechaNacimiento		DATE				= '2007-12-24'
DECLARE @nombre					VARCHAR(65)			= '@Juan Carlos'
DECLARE @apellido				VARCHAR(65)			= '@Rodríguez Funes'
DECLARE @domicilio				VARCHAR(300)		= '@Santísima Trinidad'
DECLARE @nacionalidad			VARCHAR(125)		= '@Salvadoreña'
DECLARE @documentoPresentado	VARCHAR(125)		= '@DUI (Documento Único de Identidad), Pasaporte'
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
 
INSERT INTO Paciente(pacienteId, fechaNacimiento, nombre, apellido, domicilio, nacionalidad, documentoPresentado, correoElectronico, telefono, profesion, edad, composicionFamiliar, motivo, antecedente, descripcionSituacion,aspectosPreocupantes,generoId)
VALUES
(@pacienteId, @fechaNacimiento, @nombre, @apellido, @domicilio, @nacionalidad, @documentoPresentado, @correoElectronico, @telefono, @profesion, @edad, @composicionFamiliar, @motivo, @antecedente, @descripcionSituacion,@aspectosPreocupantes,@generoId)
GO
SELECT * FROM Paciente
 
--------------------------* ACTUALIZACIÓN EN LA TABLA PACIENTE - UPDATE *--------------------------
DECLARE @pacienteId				INT					= 0001
DECLARE @fechaNacimiento		DATE				= '2007-12-24'
DECLARE @nombre					VARCHAR(65)			= '@Camila Alejandra'
DECLARE @apellido				VARCHAR(65)			= '@Claudia Reyes'
DECLARE @domicilio				VARCHAR(300)		= '@----'
DECLARE @nacionalidad			VARCHAR(125)		= '@Salvadoreña'
DECLARE @documentoPresentado	VARCHAR(125)		= '@DUI (Documento Único de Identidad), Pasaporte'
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
fechaNacimiento		= @fechaNacimiento,
nombre				= @nombre,
apellido			= @apellido,
domicilio			= @domicilio,
nacionalidad		= @nacionalidad,
documentoPresentado	= @documentoPresentado,
correoElectronico	= @correoElectronico,
telefono			= @telefono,
profesion			= @profesion,
edad				= @edad,
composicionFamiliar	= @composicionFamiliar,
motivo				= @motivo,
antecedente			= @antecedente,
descripcionSituacion	=@descripcionSituacion,
aspectosPreocupantes = @aspectosPreocupantes,
generoId			= @generoId
 
WHERE
pacienteId = @pacienteId
GO
 
SELECT * FROM Paciente
GO
SELECT * FROM Paciente
CREATE VIEW VistaPaciente AS
SELECT CONCAT (p.nombre,' ',p.apellido) AS 'Nombre de Paciente', p.pacienteId AS 'Paciente id'
FROM Paciente AS p
GO
--Se crea la tabla de Expediente
CREATE TABLE Expediente(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		expedienteId		INT					    PRIMARY KEY,
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
		pacienteId			INT						FOREIGN KEY REFERENCES Paciente(pacienteId) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

--------------------------* INSERCIÓN EN LA TABLA EXPEDIENTE - CREATE *--------------------------
DECLARE @expedienteId			INT					= 0001
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
DECLARE @pacienteId				INT					= 0001

INSERT INTO Expediente(expedienteId, estadoAnimo, estadoConductual, somatizacion, vidaInterpersonal, cognicion, redSocial, pauta, riesgoValorado, observacion, aproximacionDiag, atencionBrindada, pacienteId)
VALUES 
(@expedienteId, @estadoAnimo, @estadoConductual, @somatizacion, @vidaInterpersonal, @cognicion, @redSocial, @pauta, @riesgoValorado, @observacion, @aproximacionDiag, @atencionBrindada, @pacienteId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA EXPEDIENTE - UPDATE *--------------------------
DECLARE @expedienteId			INT					= 0001
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
DECLARE @pacienteId				INT					= 0001

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
pacienteId			= @pacienteId

WHERE
expedienteId = @expedienteId
GO

SELECT * FROM Expediente
GO

--Se crea la tabla de Profesional
CREATE TABLE Profesional(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		profesionalId		INT						IDENTITY (1,1) PRIMARY KEY,
		DUI					VARCHAR(11)				UNIQUE NOT NULL,
		telefono			VARCHAR(10)				NOT NULL,
		nombre				VARCHAR(65)				NOT NULL,
		apellido			VARCHAR(65)				NOT NULL,
		correoElectronico	VARCHAR(125)			COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
		foto				VARCHAR(200)			NOT NULL,
		desempenoId			INT						FOREIGN KEY REFERENCES Desempeno(desempenoId) ON UPDATE CASCADE ON DELETE NO ACTION,
		usuarioId			INT						FOREIGN KEY REFERENCES Usuario(usuarioId) ON UPDATE CASCADE ON DELETE CASCADE,
		especialidadId		INT						FOREIGN KEY REFERENCES Especialidad(especialidadId) ON UPDATE CASCADE ON DELETE NO ACTION,
		especialidadAltId	INT						FOREIGN KEY REFERENCES EspecialidadAlt(especialidadAltId) ON UPDATE CASCADE ON DELETE NO ACTION
)
GO

--------------------------* INSERCIÓN EN LA TABLA PROFESIONAL - CREATE *--------------------------
DECLARE @DUI					VARCHAR(9)		= '@DUI'
DECLARE @telefono				VARCHAR(11)		= '@telefono'
DECLARE @nombre					VARCHAR(65)		= '@nombre'
DECLARE @apellido				VARCHAR(65)		= '@apellido'
DECLARE @correoElectronico		VARCHAR(125)	= '@correoElectronico'
DECLARE @foto					VARCHAR(200)	= '@Directorio de la Imagen'
DECLARE @desempenoId			INT				= 1
DECLARE @usuarioId				INT				= 1
DECLARE @especialidadId			INT				= 1
DECLARE @especialidadAltId		INT				= 1

INSERT INTO Profesional(DUI, telefono, nombre, apellido, correoElectronico, foto, desempenoId, usuarioId, especialidadId, especialidadAltId)
OUTPUT INSERTED.profesionalId VALUES 
(@DUI, @telefono, @nombre, @apellido, @correoElectronico, @foto, @desempenoId, @usuarioId, @especialidadId, @especialidadAltId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA PROFESIONAL - UPDATE *--------------------------
DECLARE @profesionalId			INT				= 1
DECLARE @DUI					VARCHAR(9)		= '@DUI'
DECLARE @telefono				VARCHAR(11)		= '@telefono'
DECLARE @nombre					VARCHAR(65)		= '@nombre'
DECLARE @apellido				VARCHAR(65)		= '@apellido'
DECLARE @correoElectronico		VARCHAR(125)	= '@correoElectronico'
DECLARE @foto					VARCHAR(200)	= '@Directorio de la Imagen'
DECLARE @desempenoId			INT				= 1
DECLARE @especialidadId			INT				= 3
DECLARE @especialidadAltId		INT				= 1

UPDATE Profesional SET
DUI					= @DUI,
telefono			= @telefono,
nombre				= @nombre,
apellido			= @apellido,
correoElectronico	= @correoElectronico,
foto				= @foto,
desempenoId			= @desempenoId,
especialidadId		= @especialidadId,
especialidadAltId	= @especialidadAltId

WHERE
profesionalId = @profesionalId
GO

SELECT * FROM Profesional
GO

--Importante a USAR en el DataGridView

--------------------------* VISTA EN LA TABLA PROFESIONAL - READ *--------------------------
CREATE VIEW vistaProfesional AS
SELECT P.DUI, P.telefono, CONCAT(P.nombre, ' ', P.apellido) AS 'Nombre del Profesional', P.foto, D.desempeno, U.nombreUsuario AS 'Nombre del Usuario', ESP.nombreEspecialidad, ESPALT.nombreEspecialidadAlt
FROM Profesional AS P
INNER JOIN Desempeno AS D ON P.desempenoId = D.desempenoId
INNER JOIN Usuario AS U ON P.usuarioId = U.usuarioId
INNER JOIN Especialidad AS ESP ON P.especialidadId = ESP.especialidadId
INNER JOIN EspecialidadAlt AS ESPALT ON P.especialidadAltId = ESPALT.especialidadAltId
GO

SELECT * FROM vistaProfesional
GO

CREATE VIEW vistaProfesionalDGV AS
SELECT P.profesionalId AS 'ID Profesional', P.usuarioId AS 'ID Usuario', P.DUI AS 'DUI', P.telefono AS 'Teléfono', P.nombre AS 'Nombres', P.apellido AS 'Apellidos', P.correoElectronico AS 'Correo Electrónico', P.foto AS 'Imagen de la Persona', D.desempeno AS 'Desempeño', U.nombreUsuario AS 'Nombre del Usuario', ESP.nombreEspecialidad AS 'Especialidad Primaria', ESPALT.nombreEspecialidadAlt AS 'Especialidad Secundaria'
FROM Profesional AS P
INNER JOIN Desempeno AS D ON P.desempenoId = D.desempenoId
INNER JOIN Usuario AS U ON P.usuarioId = U.usuarioId
INNER JOIN Especialidad AS ESP ON P.especialidadId = ESP.especialidadId
INNER JOIN EspecialidadAlt AS ESPALT ON P.especialidadAltId = ESPALT.especialidadAltId
GO

SELECT * FROM vistaProfesionalDGV
GO

CREATE VIEW vistaDataTable AS
SELECT P.profesionalId, CONCAT(P.nombre, ' ', P.apellido) AS 'Nombre del Profesional', P.correoElectronico, ESP.nombreEspecialidad, ESPALT.nombreEspecialidadAlt
FROM Profesional AS P
INNER JOIN Especialidad AS ESP ON P.especialidadId = ESP.especialidadId
INNER JOIN EspecialidadAlt AS ESPALT ON P.especialidadAltId = ESPALT.especialidadAltId
GO

SELECT * FROM vistaDataTable
GO

--------------------------* VISTA EN LA TABLA PROFESIONAL CON PARÁMETROS - READ *--------------------------
DECLARE @nombreUsuario		VARCHAR(30)			= 'sanguchito'

SELECT * FROM vistaProfesional WHERE [Nombre del Usuario] = @nombreUsuario
GO

--Se crea la tabla de Cita
CREATE TABLE Cita(

--		CAMPO				TIPO DE DATO			RESTRICCIONES
		citaId				INT						IDENTITY (1,1) PRIMARY KEY,
		fecha				DATE					NOT NULL CHECK(fecha >= getDate()),
		horaInicio			TIME					NOT NULL,
		horaFinal			TIME					NOT NULL,
		estadoId			INT						FOREIGN KEY REFERENCES Estado(estadoId) ON UPDATE CASCADE ON DELETE NO ACTION, 
		consultaId			INT						FOREIGN KEY REFERENCES Consulta(consultaId) ON UPDATE CASCADE ON DELETE CASCADE,
		pacienteId			INT						FOREIGN KEY REFERENCES Paciente(pacienteId) ON UPDATE CASCADE ON DELETE NO ACTION,
		profesionalId		INT						FOREIGN KEY REFERENCES Profesional(profesionalId) ON UPDATE CASCADE ON DELETE CASCADE,
		lugarId				INT						FOREIGN KEY REFERENCES Lugar(lugarId) ON UPDATE CASCADE ON DELETE NO ACTION
)
GO

--------------------------* INSERCIÓN EN LA TABLA CITA - CREATE *--------------------------
DECLARE @fecha					DATE			= '2024-12-21'
DECLARE @horaInicio				TIME			= '13:30:00'
DECLARE @horaFinal				TIME			= '13:30:00'
DECLARE @estadoId				INT				= 1
DECLARE @consultaId				INT				= 1
DECLARE @pacienteId				INT				= 1
DECLARE @profesionalId			INT				= 1
DECLARE @lugarId				INT				= 1

INSERT INTO Cita (fecha, horaInicio, horaFinal, estadoId, consultaId, pacienteId, profesionalId, lugarId)
VALUES
(@fecha, @horaInicio, @horaFinal, @estadoId, @consultaId, @pacienteId, @profesionalId, @lugarId)
GO

--------------------------* ACTUALIZACIÓN EN LA TABLA CITA - UPDATE *--------------------------
DECLARE @citaId					INT				= 1
DECLARE @fecha					DATE			= '2024-12-21'
DECLARE @horaInicio				TIME			= '13:30:00'
DECLARE @horaFinal			    TIME			= '13:30:00'
DECLARE @estadoId				INT				= 1
DECLARE @consultaId				INT				= 1
DECLARE @pacienteId				INT				= 1
DECLARE @profesionalId			INT				= 1
DECLARE @lugarId				INT				= 1

UPDATE Cita SET
fecha				= @fecha,
horaInicio			= @horaInicio,
horaFinal			= @horaFinal,
estadoId			= @estadoId,
consultaId			= @consultaId,
pacienteId			= @pacienteId,
profesionalId		= @profesionalId,
lugarId				= @lugarId

WHERE
citaId = @citaId
GO

--------------------------* VISTA EN LA TABLA CITAS - READ *--------------------------
CREATE VIEW vistaCitasAgendadas AS
SELECT citaId AS 'ID de la Cita', C.consultaId AS 'ID de la Consulta', C.pacienteId AS 'ID del Paciente', C.profesionalId AS 'ID de Profesional', fecha AS 'Fecha de la Cita', horaInicio AS 'Hora de Inicio', horafinal AS 'Hora de Finalización', E.estado AS 'Estado de la Cita', CU.descripcion AS 'Descripción', P.nombre AS 'Nombre del Paciente', P.apellido AS 'Apellido del Paciente', PR.nombre AS 'Profesional Encargado', L.lugar AS 'Lugar de la Cita'
FROM Cita AS C
INNER JOIN Estado AS E ON C.estadoId = E.estadoId
INNER JOIN Consulta AS CU ON C.consultaId = CU.consultaId
INNER JOIN Paciente AS P ON C.pacienteId = P.pacienteId
INNER JOIN Profesional AS PR ON C.profesionalId = PR.profesionalId
INNER JOIN Lugar AS L ON C.lugarId = L.lugarId
GO

SELECT * FROM vistaCitasAgendadas
GO

SELECT * FROM Expediente
GO

DELETE FROM Profesional
GO

DELETE FROM Usuario
GO

DELETE FROM Paciente
GO

DELETE FROM Expediente
GO

DELETE FROM Cita
GO

DELETE FROM Consulta
GO