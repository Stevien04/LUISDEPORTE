CREATE DATABASE PRUEBADEPORTE
GO

USE PRUEBADEPORTE
GO

CREATE TABLE tbTipoDocumento(
	IDTipoDocumento INT IDENTITY(1,1) PRIMARY KEY,
	TipoDocumento VARCHAR (30) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1,
);
GO

INSERT INTO tbTipoDocumento (TipoDocumento)
VALUES 
('DNI'),
('Carnet de Extranjería'),
('Pasaporte');
GO

CREATE TABLE tbPersona(
	IDPersona INT IDENTITY(1,1) PRIMARY KEY,
	Nombres VARCHAR (250) NOT NULL,
	ApellidoPaterno VARCHAR (250) NOT NULL,
	ApellidoMaterno VARCHAR (250) NOT NULL,
	IDTipoDocumento INT NOT NULL,
	Documento VARCHAR (15) NOT NULL UNIQUE,
	FechaNacimiento DATE NOT NULL,
	Telefono VARCHAR (9),
	Correo VARCHAR(250) NOT NULL UNIQUE,
	Genero CHAR(1) CHECK (Genero IN ('M', 'F')),

	FOREIGN KEY (IDTipoDocumento) REFERENCES tbTipoDocumento(IDTipoDocumento)
);
GO

CREATE TABLE tbUsuario(
	IDUsuario INT IDENTITY(1,1) PRIMARY KEY,
	IDPersona INT NOT NULL,
	NombreUsuario VARCHAR (50) NOT NULL,
	Clave VARCHAR (25) NOT NULL,
	FechaRegistro DATETIME DEFAULT GETDATE(),
	Estado BIT NOT NULL DEFAULT 1,

	FOREIGN KEY (IDPersona) REFERENCES tbPersona(IDPersona)
);
GO

CREATE TABLE tbEquipo(
	IDEquipo INT IDENTITY(1,1) PRIMARY KEY,
	IDCreador INT NOT NULL,
	NombreEquipo VARCHAR(150) NOT NULL,
	Descripcion VARCHAR(250),
	FechaRegistro DATETIME DEFAULT GETDATE(),
	FechaModificacion DATETIME,
	Estado BIT NOT NULL DEFAULT 1,

	FOREIGN KEY (IDCreador) REFERENCES tbUsuario(IDUsuario)
);
GO

CREATE TABLE tbInvitacionEquipo (
    IdInvitacion INT identity PRIMARY KEY not null ,
    IdEquipo INT,
    IdUsuarioInvitador INT,
    IdUsuarioCreador INT,
    Estado VARCHAR(255),
    FechaEnvio DATETIME,
    FechaRespuesta DATETIME,
    FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo),
    FOREIGN KEY (idUsuarioInvitador) REFERENCES tbUsuario(idUsuario),
    FOREIGN KEY (idUsuarioCreador) REFERENCES tbUsuario(idUsuario)
);

CREATE TABLE tbEquipoMiembros (
    idEquipo INT,
    idUsuarioMiembro INT,
    Rol VARCHAR(255),
    FechaUnion DATETIME,
    PRIMARY KEY (idEquipo, idUsuarioMiembro),
    FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo),
    FOREIGN KEY (idUsuarioMiembro) REFERENCES tbUsuario(idUsuario)
);

CREATE TABLE tbTorneos (
    IdTorneos INT identity PRIMARY KEY not null ,
    IdCreador INT,
    NombreTorneo VARCHAR(255) NOT NULL,
    Descripcion TEXT,
    FechaCreacion DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (idCreador) REFERENCES tbUsuario(idUsuario)
);

CREATE TABLE TorneoEquipos (
    idTorneo INT,
    idEquipo INT,
    FechaUnion DATE DEFAULT GETDATE(),
    PRIMARY KEY (idTorneo, idEquipo),
    FOREIGN KEY (idTorneo) REFERENCES tbTorneos(idTorneos),
    FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo)
);

CREATE TABLE tbEnfrentamientos (
    IdEnfrentamiento INT identity PRIMARY KEY not null ,
    IdTorneo INT,
    IdEquipo1 INT,
    IdEquipo2 INT,
    MarcadorEquipo1 INT DEFAULT 0,
    MarcadorEquipo2 INT DEFAULT 0,
    FechaProgramada DATETIME,
    Estado VARCHAR(255),
    EstadoEncuentro varchar(20)
    FOREIGN KEY (idTorneo) REFERENCES tbTorneos(idTorneos),
    FOREIGN KEY (idEquipo1) REFERENCES tbEquipo(idEquipo),
    FOREIGN KEY (idEquipo2) REFERENCES tbEquipo(idEquipo)
);

CREATE TABLE tbEstadisticasEquipoEnfrentamiento (
    idEstadistica INT identity PRIMARY KEY not null ,
    idEnfrentamiento INT,         
    idEquipo INT,                 
    GolesMarcados INT DEFAULT 0,  
    GolesEnContra INT DEFAULT 0,  
    Victorias INT DEFAULT 0,     
    Derrotas INT DEFAULT 0,      
    Empates INT DEFAULT 0,       
    TarjetasAmarillas INT DEFAULT 0, 
    TarjetasRojas INT DEFAULT 0,  
    FechaRegistro DATETIME
    FOREIGN KEY (idEnfrentamiento) REFERENCES tbEnfrentamientos(idEnfrentamiento),
    FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo) 
);

CREATE TABLE tbHistorialEquipoTorneo (
    idHistorial INT identity PRIMARY KEY not null ,
    idEquipo INT,              
    idTorneo INT,              
    Puesto INT,                
    Victorias INT DEFAULT 0,    
    Derrotas INT DEFAULT 0,     
    Empates INT DEFAULT 0,      
    GolesAFavor INT DEFAULT 0,  
    GolesEnContra INT DEFAULT 0, 
    FechaRegistro DATETIME ,
    FOREIGN KEY (idEquipo) REFERENCES tbEquipo(idEquipo),
    FOREIGN KEY (idTorneo) REFERENCES tbTorneos(idTorneos)
);



SELECT * FROM tbUsuario
SELECT * FROM tbPersona
SELECT * FROM tbEquipo
--SELECT * FROM tbInvitacionEquipo


CREATE PROCEDURE sp_ListarEquiposPorUsuario
    @IDCreador INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IDEquipo,
        NombreEquipo,
        Descripcion,
        FechaRegistro,
        FechaModificacion
    FROM tbEquipo
    WHERE IDCreador = @IDCreador
    ORDER BY FechaRegistro DESC;
END
GO

CREATE PROCEDURE usp_ModificarEquipo
    @IDEquipo INT,
    @NombreEquipo VARCHAR(150),
    @Descripcion VARCHAR(250),
    @Estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tbEquipo
    SET 
        NombreEquipo = @NombreEquipo,
        Descripcion = @Descripcion,
        Estado = @Estado,
        FechaModificacion = GETDATE()
    WHERE IDEquipo = @IDEquipo;
END
GO


