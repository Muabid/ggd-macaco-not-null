GO

CREATE PROCEDURE [MACACO_NOT_NULL].GetFuncionalidades @rol_id INT
AS
BEGIN
	SELECT func_id, func_detalle FROM [MACACO_NOT_NULL].RolesXFuncionalidades
	WHERE rol_id = @rol_id
END;
GO


CREATE VIEW [MACACO_NOT_NULL].RolesXFuncionalidades AS
SELECT r_f.rol_funcionalidad_id,r.rol_id,r.rol_nombre, f.func_id, func_detalle FROM [MACACO_NOT_NULL].FUNCIONALIDAD as f
JOIN [MACACO_NOT_NULL].ROL_FUNCIONALIDAD as r_f
ON f.func_id = r_f.func_id
JOIN [MACACO_NOT_NULL].ROL as r
ON r_f.rol_id = r.rol_id;
GO


CREATE TYPE [MACACO_NOT_NULL].FUNCIONALIDADES_ROL_LIST AS TABLE(
rol_funcionalidad_id INT,
func_id INT,
func_detalle NVARCHAR(256));
GO

CREATE PROCEDURE [MACACO_NOT_NULL].UpdateRol @rol_id INT, @nombre NVARCHAR(256),
 @funcionalidades [MACACO_NOT_NULL].FUNCIONALIDADES_ROL_LIST READONLY 
AS
BEGIN TRANSACTION

	UPDATE [MACACO_NOT_NULL].ROL
	SET rol_nombre = @nombre
	WHERE rol_id = @rol_id;

	MERGE [MACACO_NOT_NULL].ROL_FUNCIONALIDAD as rf
	USING @funcionalidades as f 
	ON (rf.rol_funcionalidad_id = f.rol_funcionalidad_id)
	WHEN NOT MATCHED BY TARGET
	THEN INSERT (func_id, rol_id) VALUES (f.func_id,@rol_id)
	WHEN NOT MATCHED BY SOURCE AND rf.rol_id = @rol_id
	THEN DELETE;

COMMIT TRANSACTION;
GO

