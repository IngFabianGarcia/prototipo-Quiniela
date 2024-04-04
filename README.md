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


CREATE PROCEDURE AgregarEquipo
    @NombreEquipo VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Equipos (NombreEquipo)
    VALUES (@NombreEquipo);
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


CREATE PROCEDURE VerEquipos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Equipos;
END;


CREATE PROCEDURE VerPartidos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Partidos.Fecha, EquiposLocal.NombreEquipo AS EquipoLocal, EquiposVisitante.NombreEquipo AS EquipoVisitante
    FROM Partidos
    INNER JOIN Equipos AS EquiposLocal ON Partidos.idEquipoLocal = EquiposLocal.idEquipo
    INNER JOIN Equipos AS EquiposVisitante ON Partidos.idEquipoVisitante = EquiposVisitante.idEquipo;
END;
