CREATE PROCEDURE spConsultar(
	@nombre AS VARCHAR(255) = '', 
	@descripcion AS VARCHAR(255) = ''
)
AS
BEGIN
    SELECT idExamen, Nombre, Descripcion 
    FROM tblExamen 
    WHERE 
        Nombre = @nombre OR
        Descripcion = @descripcion;
END;