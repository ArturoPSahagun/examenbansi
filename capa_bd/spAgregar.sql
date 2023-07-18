CREATE PROCEDURE spAgregar(
	@nombre AS VARCHAR(255), 
	@descripcion AS VARCHAR(255))
AS
BEGIN
	BEGIN TRY
		INSERT INTO tblExamen(Nombre, Descripcion)
		VALUES (@nombre, @descripcion);
		SELECT 
            0 AS codigo_retorno,
            'Registro insertado satisfactoriamente' AS mensaje_retorno;
	END TRY
	BEGIN CATCH
		SELECT  
            ERROR_NUMBER() AS codigo_retorno,
			ERROR_MESSAGE() AS mensaje_retorno
	END CATCH
END;