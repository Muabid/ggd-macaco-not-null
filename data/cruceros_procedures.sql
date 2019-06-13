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

exec MACACO_NOT_NULL.GetCruceros null, NULL,NULL,NULL,NULL,NULL									