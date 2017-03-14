CREATE TABLE XMLTemporary (
	XMLTemporary_Id INT NOT NULL IDENTITY(1, 1),
	XMLData XML NOT NULL,
	InsertedDate DATE NOT NULL,

	CONSTRAINT PK_XMLTemporary PRIMARY KEY CLUSTERED (XMLTemporary_Id)
);
GO

CREATE TABLE Mercury (
	Mercury_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE NOT NULL,
	Hg FLOAT,
	Unit VARCHAR(10) NOT NULL,

	CONSTRAINT PK_Mercury PRIMARY KEY CLUSTERED (Mercury_Id)
);
GO

CREATE TABLE Meteorology (
	Meteorology_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE,
	WindDirection FLOAT,
	WindSpeed FLOAT,
	Temperature FLOAT,
	Humidity FLOAT,
	Radiation FLOAT,
	Pressure FLOAT,

	CONSTRAINT PK_Meteorology PRIMARY KEY CLUSTERED (Meteorology_Id)
);
GO

CREATE TABLE Ozone (
	Ozone_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE NOT NULL,
	Ozone FLOAT,
	Unit VARCHAR(10) NOT NULL,

	CONSTRAINT PK_Ozone PRIMARY KEY CLUSTERED (Ozone_Id)
);
GO

CREATE TABLE Particles (
	Particles_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE NOT NULL,
	NumberOfParticlesTotal FLOAT,
	VTotal FLOAT,

	CONSTRAINT PK_Particles PRIMARY KEY CLUSTERED (Particles_Id)
);
GO

CREATE TABLE Precipitation (
	Precipitation_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE NOT NULL,
	PrepHour FLOAT,
	PrepTotal FLOAT,

	CONSTRAINT PK_Precipitation PRIMARY KEY CLUSTERED (Precipitation_Id)
);
GO

CREATE TABLE StationTemperature (
	StationTemperature_Id INT NOT NULL IDENTITY(1, 1),
	DateTimeStart DATE NOT NULL,
	Temperature FLOAT,
	RoomHumidity FLOAT,

	CONSTRAINT PK_StationTemperature PRIMARY KEY CLUSTERED (StationTemperature_Id)
);
GO