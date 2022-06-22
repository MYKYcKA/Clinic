CREATE TABLE Ingredients(
Id int NOT NULL primary key identity(1,1),
Name varchar(255) NOT NULL,
);
CREATE TABLE Medicines (
Id int NOT NULL PRIMARY KEY identity(1,1),
Name varchar(255) NOT NULL,
);
CREATE TABLE [Composition] (
Id int NOT NULL PRIMARY KEY identity(1,1),
IngredientId int NOT NULL,
MedicineId int NOT NULL,
FOREIGN KEY(MedicineId) REFERENCES Medicines(Id),
FOREIGN KEY(IngredientId) REFERENCES Ingredients(Id)
);
CREATE TABLE Address (
Id int NOT NULL PRIMARY KEY identity(1,1),
Street varchar(255) NOT NULL,
House smallint NOT NULL,
City varchar(255) NOT NULL,
Apartment smallint,
);

CREATE TABLE Patient (
Id int NOT NULL PRIMARY KEY identity(1,1),
Name varchar(255) NOT NULL,
Surname varchar(255) NOT NULL,
AddressId int UNIQUE NOT NULL,
FOREIGN KEY (AddressId) REFERENCES Address(Id)
);

CREATE TABLE Doctor (
Id int NOT NULL PRIMARY KEY identity(1,1),
Name varchar(255) NOT NULL,
[MiddleName] varchar(255),
Surname varchar(255) NOT NULL,
Specialization varchar(255) NOT NULL,
AddressId int UNIQUE NOT NULL,
FOREIGN KEY(AddressId) REFERENCES Address(Id)
);

CREATE TABLE Contraindication (
Id int NOT NULL PRIMARY KEY identity(1,1),
PatientId int NOT NULL,
MedicineId int NOT NULL,
FOREIGN KEY(PatientId) REFERENCES Patient(Id),
FOREIGN KEY(MedicineId) REFERENCES Medicines(Id)
);

CREATE TABLE HistoryOfIllness (
Id int NOT NULL PRIMARY KEY identity(1,1),
Diagnose varchar(30) NOT NULL,
[Start] date NOT NULL DEFAULT GETDATE(),
[End] date,
Rate smallint NOT NULL,
Characteristic text NOT NULL,
PatientId int NOT NULL,
DoctorId int NOT NULL,
OnSpecialCount bit NOT NULL default '0',
FOREIGN KEY(PatientId) REFERENCES Patient(Id),
FOREIGN KEY(DoctorId) REFERENCES Doctor(Id)
);

CREATE TABLE Appointment (
Id int NOT NULL PRIMARY KEY identity(1,1),
[AppointmentDate] date NOT NULL DEFAULT GETDATE(),
HistoryOfIllnessId int NOT NULL,
FOREIGN KEY(HistoryOfIllnessId) REFERENCES HistoryOfIllness(Id)
);

CREATE TABLE [AppointmentDetails] (
Id int NOT NULL PRIMARY KEY identity(1,1),
MedicineId int NOT NULL,
AppointmentId int NOT NULL,
FOREIGN KEY(MedicineId) REFERENCES Medicines(Id),
FOREIGN KEY(AppointmentId) REFERENCES Appointment(Id),
);
-- CHECK
ALTER TABLE HistoryOfIllness
ADD CHECK (rate>=0 AND rate<=100)

ALTER TABLE HistoryOfIllness
ADD CHECK ([End]>[Start]);