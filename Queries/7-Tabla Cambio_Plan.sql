--7
CREATE TABLE STRANGER_STRINGS.Cambio_Plan(
Id_Cambio INT IDENTITY(1,1)PRIMARY KEY,
Id_Paciente INT FOREIGN KEY REFERENCES STRANGER_STRINGS.Paciente(Id_Paciente),
Motivo VARCHAR(255),
Id_Plan_Viejo INT FOREIGN KEY REFERENCES STRANGER_STRINGS.Plan_Medico(Id_Plan),
Id_Plan_Nuevo INT FOREIGN KEY REFERENCES STRANGER_STRINGS.Plan_Medico(Id_Plan))