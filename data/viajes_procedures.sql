CREATE PROCEDURE [MACACO_NOT_NULL].GenerarViaje @fecha_salida datetime2(3),
 @fecha_llegada datetime2(3), @recorrido_id INT, @crucero_id INT
AS
	BEGIN
		INSERT INTO [MACACO_NOT_NULL].VIAJE (viaj_fecha_salida,viaj_fecha_llegada_estimada,viaj_crucero_id,viaj_recorrido_id)
		VALUES(@fecha_salida,@fecha_llegada,@crucero_id,@recorrido_id)
	END
GO;

