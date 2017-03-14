USE AirQuality

DECLARE @XML AS XML, @hDoc AS INT, @SQL as NVARCHAR(MAX)

SELECT @XML = XMLData FROM XMLTemporary WHERE XMLTemporary_Id = 1

EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML

--INSERT INTO Mercury (DateTimeStart, Hg, Unit) 
	SELECT *
		FROM OPENXML(@hDoc, '/DocumentElement/Data', 3)
			WITH 
			(
				DateTimeStart [DATE],
				Hg [FLOAT],
				unit [VARCHAR](10)
			);

EXEC sp_xml_removedocument @hDoc
GO