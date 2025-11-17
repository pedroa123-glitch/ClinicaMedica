  CREAR BASE DE DATOS
-- ===========================================
CREATE DATABASE ClinicaMedica;
GO
USE ClinicaMedica;
GO

-- ===========================================
--   TABLA: Usuario
-- ===========================================
CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    [Contraseña] VARCHAR(15),
    Rol VARCHAR(20) CHECK (Rol IN ('Medico', 'Administrador')) NOT NULL
);

-- ===========================================
--   TABLA: Medico
-- ===========================================
CREATE TABLE Medico (
    IdMedico INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL UNIQUE,
    Especialidad VARCHAR(100),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);

-- ===========================================
--   TABLA: Paciente
-- ===========================================
CREATE TABLE Paciente (
    IdPaciente INT IDENTITY(1,1) PRIMARY KEY,
    DNI CHAR(8) UNIQUE NOT NULL,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    FechaNacimiento DATE,
    Genero CHAR(1),
    Telefono VARCHAR(14),
    Direccion VARCHAR(100)
);

-- ===========================================
--   TABLA: HistorialClinico
-- ===========================================
CREATE TABLE HistorialClinico (
    IdHistorial INT IDENTITY(1,1) PRIMARY KEY,
    IdPaciente INT NOT NULL,
    IdMedico INT,
    FechaRegistro DATETIME2 DEFAULT GETDATE(),
    Diagnostico VARCHAR(MAX),
    FOREIGN KEY (IdPaciente) REFERENCES Paciente(IdPaciente),
    FOREIGN KEY (IdMedico) REFERENCES Medico(IdMedico)
);

-- ===========================================
--   TABLA: Consultorio
-- ===========================================
CREATE TABLE Consultorio (
    IdConsultorio INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Especialidad VARCHAR(100),
    Ubicacion VARCHAR(100)
);

-- ===========================================
--   TABLA: Cita
-- ===========================================
CREATE TABLE Cita (
    IdCita INT IDENTITY(1,1) PRIMARY KEY,
    IdPaciente INT,
    IdMedico INT,
    IdConsultorio INT,
    FechaHora DATETIME2,
    Estado VARCHAR(20) DEFAULT 'Programada'
        CHECK (Estado IN ('Programada','Atendida','Cancelada')),
    FOREIGN KEY (IdPaciente) REFERENCES Paciente(IdPaciente),
    FOREIGN KEY (IdMedico) REFERENCES Medico(IdMedico),
    FOREIGN KEY (IdConsultorio) REFERENCES Consultorio(IdConsultorio)
);

-- ===========================================
--   TABLA: Medicamento
-- ===========================================
CREATE TABLE Medicamento (
    IdMedicamento INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(255),
    Stock INT NOT NULL CHECK (Stock >= 0)
);

-- ===========================================
--   TABLA: Receta
-- ===========================================
CREATE TABLE Receta (
    IdReceta INT IDENTITY(1,1) PRIMARY KEY,
    IdCita INT,
    IdMedicamento INT,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    Instrucciones VARCHAR(MAX),
    FOREIGN KEY (IdCita) REFERENCES Cita(IdCita),
    FOREIGN KEY (IdMedicamento) REFERENCES Medicamento(IdMedicamento)
);

-- ===========================================
--   TABLA: Reporte
-- ===========================================
CREATE TABLE Reporte (
    IdReporte INT IDENTITY(1,1) PRIMARY KEY,
    IdMedico INT NOT NULL,
    Fecha DATETIME2 DEFAULT GETDATE(),
    TipoReporte VARCHAR(100),
    FOREIGN KEY (IdMedico) REFERENCES Medico(IdMedico)
);

-- ===========================================
--   TABLA: Estadistica
-- ===========================================
CREATE TABLE Estadistica (
    IdEstadistica INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME2 DEFAULT GETDATE(),
    TotalPacientes INT,
    TotalCitas INT,
    TotalRecetas INT
);

-- ===========================================
--   INSERTS INICIALES
-- ===========================================
INSERT INTO Usuario (Nombre, Apellido, Email, [Contraseña], Rol)
VALUES
('Juan', 'Perez', 'juan.perez@clinica.com', 'clave123', 'Medico'),
('Ana', 'Gomez', 'ana.gomez@clinica.com', 'admin123', 'Administrador');

INSERT INTO Medico (IdUsuario, Especialidad)
VALUES (1, 'Medicina General');

INSERT INTO Paciente (DNI, Nombre, Apellido, FechaNacimiento, Genero, Telefono, Direccion)
VALUES
('12345678', 'Carlos', 'Lopez', '1985-03-10', 'M', '987654321', 'Av. Lima 123'),
('87654321', 'Maria', 'Sanchez', '1990-07-15', 'F', '987123456', 'Jr. Iquitos 456');

INSERT INTO Consultorio (Nombre, Especialidad, Ubicacion)
VALUES
('Consultorio 201', 'Medicina General', 'Piso 2'),
('Consultorio 305', 'Pediatría', 'Piso 3');

INSERT INTO Cita (IdPaciente, IdMedico, IdConsultorio, FechaHora, Estado)
VALUES
(1, 1, 1, '2025-10-30 10:00', 'Programada'),
(2, 1, 1, '2025-10-31 09:30', 'Programada');

INSERT INTO HistorialClinico (IdPaciente, IdMedico, Diagnostico)
VALUES
(1, 1, 'Cefalea tensional. Se recomienda reposo e hidratación.'),
(2, 1, 'Chequeo general. Paciente estable, sin complicaciones.');

INSERT INTO Medicamento (Nombre, Descripcion, Stock)
VALUES
('Paracetamol', 'Analgésico y antipirético', 100),
('Amoxicilina', 'Antibiótico de uso común', 50);

INSERT INTO Receta (IdCita, IdMedicamento, Cantidad, Instrucciones)
VALUES
(1, 1, 10, 'Tomar 1 tableta (500 mg) cada 8 horas después de comer'),
(2, 2, 14, 'Tomar 1 cápsula cada 12 horas con agua. Completar el tratamiento');

INSERT INTO Reporte (IdMedico, TipoReporte)
VALUES
(1, 'Certificado médico por reposo de 2 días'),
(1, 'Informe de control general');

INSERT INTO Estadistica (TotalPacientes, TotalCitas, TotalRecetas)
VALUES (2, 2, 2);

-- ===========================================
--   USUARIO 2 COMO MEDICO
-- ===========================================
INSERT INTO Medico (IdUsuario, Especialidad)
VALUES (2, 'Medicina General');

UPDATE Usuario 
SET Rol = 'Medico' 
WHERE IdUsuario = 2;

-- ===========================================
--  Datos Usuario
-- ===========================================
-- Usuarios
INSERT INTO Usuario (Nombre, Apellido, Email, [Contraseña], Rol)
VALUES
('Luis', 'Ramirez', 'luis.ramirez@clinica.com', 'clave001', 'Medico'),
('Sofia', 'Torres', 'sofia.torres@clinica.com', 'clave002', 'Medico'),
('Pedro', 'Martinez', 'pedro.martinez@clinica.com', 'clave003', 'Medico'),
('Carla', 'Fernandez', 'carla.fernandez@clinica.com', 'clave004', 'Administrador'),
('Jorge', 'Vargas', 'jorge.vargas@clinica.com', 'clave005', 'Medico'),
('Elena', 'Rios', 'elena.rios@clinica.com', 'clave006', 'Medico'),
('Diego', 'Salazar', 'diego.salazar@clinica.com', 'clave007', 'Administrador'),
('Paula', 'Mendoza', 'paula.mendoza@clinica.com', 'clave008', 'Medico'),
('Raul', 'Castillo', 'raul.castillo@clinica.com', 'clave009', 'Medico'),
('Valeria', 'Guzman', 'valeria.guzman@clinica.com', 'clave010', 'Medico');

-- Datos Medicos
INSERT INTO Medico (IdUsuario, Especialidad)
VALUES
(3, 'Pediatría'),
(4, 'Dermatología'),
(5, 'Cardiología'),
(6, 'Medicina General'),
(7, 'Ginecología'),
(8, 'Neurología'),
(9, 'Psiquiatría'),
(10, 'Oftalmología'),
(11, 'Ortopedia'),
(12, 'Medicina Interna');

-- Datos Paciente
INSERT INTO Paciente (DNI, Nombre, Apellido, FechaNacimiento, Genero, Telefono, Direccion)
VALUES
('23456789', 'Fernando', 'Lopez', '1982-02-14', 'M', '987111222', 'Av. San Martin 101'),
('34567890', 'Lucia', 'Rojas', '1995-06-23', 'F', '987222333', 'Jr. Arequipa 234'),
('45678901', 'Martin', 'Diaz', '1978-09-10', 'M', '987333444', 'Calle Lima 12'),
('56789012', 'Paola', 'Vega', '1988-12-05', 'F', '987444555', 'Av. Brasil 45'),
('67890123', 'Andres', 'Cortes', '1992-04-18', 'M', '987555666', 'Jr. Cusco 78'),
('78901234', 'Camila', 'Soto', '2000-08-30', 'F', '987666777', 'Av. Arequipa 123'),
('89012345', 'Javier', 'Ruiz', '1985-11-22', 'M', '987777888', 'Calle Puno 56'),
('90123456', 'Natalia', 'Figueroa', '1997-03-12', 'F', '987888999', 'Av. Tacna 89'),
('01234567', 'Ricardo', 'Molina', '1990-07-04', 'M', '987999000', 'Jr. Ica 321'),
('11223344', 'Adriana', 'Cespedes', '1983-05-17', 'F', '987000111', 'Calle Loreto 77');

-- Datos Consultorio
INSERT INTO Consultorio (Nombre, Especialidad, Ubicacion)
VALUES
('Consultorio 101', 'Cardiología', 'Piso 1'),
('Consultorio 102', 'Pediatría', 'Piso 1'),
('Consultorio 103', 'Dermatología', 'Piso 1'),
('Consultorio 104', 'Neurología', 'Piso 1'),
('Consultorio 105', 'Ginecología', 'Piso 1'),
('Consultorio 106', 'Psiquiatría', 'Piso 1'),
('Consultorio 107', 'Oftalmología', 'Piso 2'),
('Consultorio 108', 'Ortopedia', 'Piso 2'),
('Consultorio 109', 'Medicina Interna', 'Piso 2'),
('Consultorio 110', 'Medicina General', 'Piso 2');

-- Datos Citas
INSERT INTO Cita (IdPaciente, IdMedico, IdConsultorio, FechaHora, Estado)
VALUES
(3, 3, 2, '2025-11-01 10:00', 'Programada'),
(4, 4, 3, '2025-11-01 11:00', 'Programada'),
(5, 5, 1, '2025-11-02 09:30', 'Programada'),
(6, 6, 4, '2025-11-02 10:30', 'Programada'),
(7, 7, 5, '2025-11-03 08:30', 'Programada'),
(8, 8, 6, '2025-11-03 09:00', 'Programada'),
(9, 9, 7, '2025-11-04 14:00', 'Programada'),
(10, 10, 8, '2025-11-04 15:00', 'Programada'),
(1, 11, 9, '2025-11-05 10:00', 'Programada'),
(2, 12, 10, '2025-11-05 11:30', 'Programada');

-- Datos Medicamentos
INSERT INTO Medicamento (Nombre, Descripcion, Stock)
VALUES
('Ibuprofeno', 'Analgesico antiinflamatorio', 200),
('Diclofenac', 'Anti inflamatorio no esteroideo', 150),
('Omeprazol', 'Inhibidor de la bomba de protones', 100),
('Lorazepam', 'Ansiolitico', 80),
('Metformina', 'Tratamiento diabetes tipo 2', 120),
('Simvastatina', 'Colesterol alto', 60),
('Amoxicilina Clavulanato', 'Antibiotico amplio espectro', 90),
('Cefalexina', 'Antibiotico oral', 70),
('Clonazepam', 'Ansiolitico', 50),
('Loratadina', 'Antihistaminico', 110);

-- Datos Recetas
INSERT INTO Receta (IdCita, IdMedicamento, Cantidad, Instrucciones)
VALUES
(3, 1, 15, 'Tomar 1 cada 8 horas'),
(4, 2, 10, 'Tomar 1 cada 12 horas'),
(5, 3, 20, 'Tomar 1 antes de desayunar'),
(6, 4, 10, 'Tomar 1 antes de dormir'),
(7, 5, 30, 'Tomar 1 después de comer'),
(8, 6, 15, 'Tomar 1 por la mañana'),
(9, 7, 20, 'Tomar 1 cada 8 horas'),
(10, 8, 10, 'Tomar 1 cada 12 horas'),
(1, 9, 5, 'Tomar 1 antes de dormir'),
(2, 10, 10, 'Tomar 1 por la mañana');

-- Datos Historiales clínicos
INSERT INTO HistorialClinico (IdPaciente, IdMedico, Diagnostico)
VALUES
(3, 3, 'Paciente con fiebre leve, se recomienda reposo'),
(4, 4, 'Chequeo dermatológico, piel sana'),
(5, 5, 'Paciente con hipertensión, control semanal'),
(6, 6, 'Dolor de cabeza frecuente, seguimiento'),
(7, 7, 'Consulta ginecológica, todo normal'),
(8, 8, 'Paciente con ansiedad leve'),
(9, 9, 'Control oftalmológico, visión estable'),
(10, 10, 'Paciente con dolor lumbar, fisioterapia recomendada'),
(1, 11, 'Chequeo cardiológico rutinario'),
(2, 12, 'Consulta medicina interna, paciente estable');

-- Datos Reportes
INSERT INTO Reporte (IdMedico, TipoReporte)
VALUES
(3, 'Informe de seguimiento pediátrico'),
(4, 'Reporte dermatología'),
(5, 'Informe cardiología'),
(6, 'Reporte medicina general'),
(7, 'Informe ginecológico'),
(8, 'Reporte psiquiatría'),
(9, 'Informe oftalmología'),
(10, 'Reporte ortopedia'),
(11, 'Informe medicina interna'),
(12, 'Reporte general');