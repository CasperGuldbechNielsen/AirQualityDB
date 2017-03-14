INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\Mercury.xml', SINGLE_BLOB) 
				AS x;
GO

INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\Meteorologi.xml', SINGLE_BLOB) 
				AS x;
GO

INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\Ozone.xml', SINGLE_BLOB) 
				AS x;
GO

INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\Particles.xml', SINGLE_BLOB) 
				AS x;
GO

INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\Precipitation.xml', SINGLE_BLOB) 
				AS x;
GO

INSERT INTO XMLTemporary (XMLData, InsertedDate) 
	SELECT CONVERT(XML, BulkColumn)
		AS BulkColumn, GETDATE() 
			FROM OPENROWSET(BULK 'C:\Users\Casper\Dropbox\School\Fourth semester\Databases\Assigment 2\Data\StationTemperature.xml', SINGLE_BLOB) 
				AS x;
GO