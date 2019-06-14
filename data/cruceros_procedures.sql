CREATE PROCEDURE [MACACO_NOT_NULL].GetCruceros @nombre NVARCHAR(256), @modelo NVARCHAR(256), @compania NVARCHAR(256), @cabinas INT, @fecha_salida DATETIME2, @fecha_llegada DATETIME2
AS
select cr.cruc_id,cruc_nombre, cruc_modelo, comp_nombre, cruc_cantidad_cabinas  
from MACACO_NOT_NULL.CRUCERO cr
join MACACO_NOT_NULL.COMPANIA co
on cr.cruc_compañia_id = co.comp_id
where cruc_activo = 1 and 
(@nombre is null or cruc_nombre like CONCAT('%',@nombre,'%')) and
(@modelo is null or cruc_modelo = @modelo) and 
(@compania is null or co.comp_nombre = @compania) and 
(@cabinas is null or @cabinas < cruc_cantidad_cabinas) and
cruc_id not in ( select viaj_crucero_id 
											from MACACO_NOT_NULL.VIAJE
											WHERE viaj_fecha_llegada_estimada between @fecha_salida and @fecha_salida
											or viaj_fecha_salida between @fecha_salida and @fecha_salida
											union
											select baja_cruc_id
											from MACACO_NOT_NULL.BAJA_CRUCERO
											where baja_cruc_id = cruc_id and
											baja_cruc_fecha_fuera_servicio between @fecha_salida and @fecha_salida
											or baja_cruc_fecha_reinicio_servicio between @fecha_salida and @fecha_salida)



CREATE TYPE [MACACO_NOT_NULL].CABINA_PISO AS TABLE (
cabinas INT,
piso INT,
servicio NVARCHAR(256) )

CREATE PROCEDURE [MACACO_NOT_NULL].CreateOrUpdateCrucero @nombre NVARCHAR(256), @modelo NVARCHAR(256),
	@compania INT,@fecha_alta DATETIME2(3),@cant_cabinas INT, @cabinas [MACACO_NOT_NULL].CABINA_PISO readonly  
AS
BEGIN TRANSACTION 
	INSERT INTO MACACO_NOT_NULL.CRUCERO (cruc_compañia_id, cruc_nombre, cruc_modelo, cruc_fecha_alta,cruc_cantidad_cabinas)
	VALUES (@compania,@nombre,@modelo,@fecha_alta,@cant_cabinas)
	DECLARE @cruc_id INT
	SET @cruc_id = (SELECT cruc_id from MACACO_NOT_NULL.CRUCERO WHERE cruc_nombre = @nombre)
	DECLARE @piso INT
	DECLARE @cabinas_piso INT
	DECLARE @servicio nvarchar(256)
	DECLARE pisos CURSOR FOR SELECT piso FROM @cabinas
	OPEN pisos
	FETCH NEXT FROM pisos INTO @piso
	WHILE  @@FETCH_STATUS = 0
	BEGIN
		DECLARE servicios CURSOR FOR SELECT servicio FROM @cabinas c WHERE c.piso = @piso
		OPEN servicios
		FETCH NEXT FROM servicios INTO @servicio
		WHILE  @@FETCH_STATUS = 0
		BEGIN
			SET @cabinas_piso = (select cabinas from @cabinas where piso = @piso and servicio = @servicio)
			DECLARE @i INT 
			SET @i = 1
				WHILE @i <= @cabinas_piso
				BEGIN 
					INSERT INTO MACACO_NOT_NULL.CABINA (cabi_piso,cabi_nro,cabi_tipo_servicio_id,cabi_crucero_id)
					VALUES (@piso,@i,(select tipo_servicio_id from MACACO_NOT_NULL.TIPO_SERVICIO where tipo_servicio_descripcion = @servicio),@cruc_id)
					SET @i = @i + 1;
				END
			FETCH NEXT FROM servicios INTO @servicio			
		END
		CLOSE servicios;
		FETCH NEXT FROM pisos INTO @piso
	 END
COMMIT TRANSACTION;
GO



					