CREATE PROCEDURE spActualizar(
	@id AS INT,
	@nombre AS VARCHAR(255), 
	@descripcion AS VARCHAR(255)
)
AS
BEGIN
	BEGIN TRY
		UPDATE tblExamen
		SET 
			Nombre = @nombre,
			Descripcion = @descripcion
		WHERE
			idExamen = @id
		SELECT 
            0 AS codigo_retorno,
            'Registro actualizado satisfactoriamente' AS mensaje_retorno;
	END TRY
	BEGIN CATCH
		SELECT  
            ERROR_NUMBER() AS codigo_retorno,
			ERROR_MESSAGE() AS mensaje_retorno
	END CATCH
END;