Se necesita una base de datos con procedimientos aqui les dejo los procedimientos y tablas creados


CREATE TABLE Equipos (
    idEquipo INT IDENTITY(1,1) PRIMARY KEY,
    NombreEquipo VARCHAR(100)
);



CREATE TABLE Partidos (
    idPartido INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE,
    idEquipoLocal INT FOREIGN KEY REFERENCES Equipos(idEquipo),
    idEquipoVisitante INT FOREIGN KEY REFERENCES Equipos(idEquipo)
);

CREATE TABLE Usuarios (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(100),
    -- Otros campos de información del usuario según tus necesidades
);



CREATE PROCEDURE AgregarEquipo
    @NombreEquipo VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Equipos (NombreEquipo)
    VALUES (@NombreEquipo);
END;




CREATE PROCEDURE RegistrarUsuario
    @NombreUsuario VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuarios (NombreUsuario)
    VALUES (@NombreUsuario);
END;

CREATE PROCEDURE AgregarPartido
    @Fecha DATE,
    @idEquipoLocal INT,
    @idEquipoVisitante INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Partidos (Fecha, idEquipoLocal, idEquipoVisitante)
    VALUES (@Fecha, @idEquipoLocal, @idEquipoVisitante);
END;


CREATE PROCEDURE VerFechaPartido
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Partidos.Fecha AS "Fecha"
    FROM Partidos
    INNER JOIN Equipos AS EquiposLocal ON Partidos.idEquipoLocal = EquiposLocal.idEquipo
    INNER JOIN Equipos AS EquiposVisitante ON Partidos.idEquipoVisitante = EquiposVisitante.idEquipo;
END;



CREATE PROCEDURE VerEquipoVisitante
AS
BEGIN
    SET NOCOUNT ON;

    SELECT EquiposVisitante.NombreEquipo AS "Equipo Visitante"
    FROM Partidos
    INNER JOIN Equipos AS EquiposLocal ON Partidos.idEquipoLocal = EquiposLocal.idEquipo
    INNER JOIN Equipos AS EquiposVisitante ON Partidos.idEquipoVisitante = EquiposVisitante.idEquipo;
END;




CREATE PROCEDURE VerEquipoLocal
AS
BEGIN
    SET NOCOUNT ON;

    SELECT EquiposLocal.NombreEquipo AS "Equipo Local"
    FROM Partidos
    INNER JOIN Equipos AS EquiposLocal ON Partidos.idEquipoLocal = EquiposLocal.idEquipo
    INNER JOIN Equipos AS EquiposVisitante ON Partidos.idEquipoVisitante = EquiposVisitante.idEquipo;
END;


CREATE PROCEDURE VerEquipos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Equipos;
END;z


CREATE PROCEDURE VerPartidos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Partidos.Fecha, EquiposLocal.NombreEquipo AS EquipoLocal, EquiposVisitante.NombreEquipo AS EquipoVisitante
    FROM Partidos
    INNER JOIN Equipos AS EquiposLocal ON Partidos.idEquipoLocal = EquiposLocal.idEquipo
    INNER JOIN Equipos AS EquiposVisitante ON Partidos.idEquipoVisitante = EquiposVisitante.idEquipo;
END;


CREATE PROCEDURE verUsuarios
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Usuarios;
END;


