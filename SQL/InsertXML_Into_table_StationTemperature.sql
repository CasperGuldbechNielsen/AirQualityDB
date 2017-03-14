DECLARE @XML AS XML, @hDoc AS INT, @SQL as NVARCHAR(MAX)

SELECT @XML = XMLData FROM XMLTemporary WHERE XMLTemporary_Id = 6

EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML

INSERT INTO StationTemperature(DateTimeStart, Temperature, RoomHumidity)
	SELECT *
		FROM OPENXML(@hDoc, '/DocumentElement/Data', 3)
			WITH 
			(
				DateTimeStart DATE,
				T FLOAT,
				RH FLOAT
			);

EXEC sp_xml_removedocument @hDoc
GO