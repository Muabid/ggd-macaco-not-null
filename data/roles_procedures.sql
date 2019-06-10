CREATE PROCEDURE [MACACO_NOT_NULL].GetFuncionalidades @rol_id INT
AS
BEGIN
	SELECT f.func_id, func_detalle FROM [MACACO_NOT_NULL].FUNCIONALIDAD as f
	JOIN [MACACO_NOT_NULL].ROL_FUNCIONALIDAD as r_f
	ON f.func_id = r_f.func_id
	JOIN [MACACO_NOT_NULL].ROL as r
	ON r_f.rol_id = r.rol_id
	WHERE r.rol_id = @rol_id
END


CREATE

CREATE PROCEDURE [MACACO_NOT_NULL].UpdateRol @funcionalidades TABLE(func_id INT)
