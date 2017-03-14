DECLARE @XML AS XML, @hDoc AS INT, @SQL as NVARCHAR(MAX)

SELECT @XML = XMLData FROM XMLTemporary WHERE XMLTemporary_Id = 3

EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML

INSERT INTO Meteorology (DateTimeStart, WindDirection, WindSpeed, Temperature, Humidity, Radiation, Pressure)
	SELECT *
		FROM OPENXML(@hDoc, '/DocumentElement/Data', 3)
			WITH 
			(
				StartDateTime [DATE],
				WindDirection [FLOAT],
				WindSpeed [FLOAT],
				Temperature [FLOAT],
				Humidity [FLOAT],
				Radiation [FLOAT],
				Pressure [FLOAT]
			);

EXEC sp_xml_removedocument @hDoc
GO