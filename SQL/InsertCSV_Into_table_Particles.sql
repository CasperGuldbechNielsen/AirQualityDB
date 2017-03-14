USE AirQuality
GO

BULK INSERT Particles
	FROM 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\ParticlesCopy.csv'
	WITH
	(
		FIRSTROW = 2,
		FORMATFILE = 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Particles-n.fmt',
		FIELDTERMINATOR = ';',
		ROWTERMINATOR = '\n',
		ERRORFILE = 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\error.log'
	)