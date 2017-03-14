DECLARE @XML AS XML, @hDoc AS INT, @SQL as NVARCHAR(MAX)

SELECT @XML = XMLData FROM XMLTemporary WHERE XMLTemporary_Id = 5

EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML

INSERT INTO Precipitation(DateTimeStart, PrepHour, PrepTotal)
	SELECT *
		FROM OPENXML(@hDoc, '/DocumentElement/Data', 3)
			WITH 
			(
				DateTimeStart [DATE],
				Prep_Hour [FLOAT],
				Prep_Tot [FLOAT]
			);

EXEC sp_xml_removedocument @hDoc
GO