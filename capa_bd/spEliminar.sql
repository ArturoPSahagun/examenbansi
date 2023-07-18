CREATE PROCEDURE spEliminar(
	@id AS INT
)
AS
BEGIN
	BEGIN TRY
		DELETE FROM tblExamen
		WHERE
			idExamen = @id;
		SELECT 
            0 AS codigo_retorno,
            'Registro eliminado satisfactoriamente' AS mensaje_retorno;
	END TRY
	BEGIN CATCH
		SELECT  
            ERROR_NUMBER() AS codigo_retorno,
			ERROR_MESSAGE() AS mensaje_retorno
	END CATCH
END;