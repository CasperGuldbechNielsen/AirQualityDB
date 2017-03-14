DECLARE @XML AS XML, @hDoc AS INT, @SQL as NVARCHAR(MAX)

SELECT @XML = XMLData FROM XMLTemporary WHERE XMLTemporary_Id = 3

EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML

INSERT INTO Ozone (DateTimeStart, Ozone, Unit)
	SELECT *
		FROM OPENXML(@hDoc, '/DocumentElement/Data', 3)
			WITH 
			(
				DateTimeStart [DATE],
				Ozone [FLOAT],
				Unit [VARCHAR](10)
			);

EXEC sp_xml_removedocument @hDoc
GO