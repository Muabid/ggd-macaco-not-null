CREATE PROCEDURE [MACACO_NOT_NULL].GetTramos @reco_codigo decimal(18,0)
AS
BEGIN
	SELECT tram_id as tramoId, p_d.puer_nombre as desde, p_h.puer_nombre as hasta, tram_precio_base as precio
	FROM MACACO_NOT_NULL.RECORRIDO AS r
	LEFT JOIN MACACO_NOT_NULL.TRAMO t
	ON r.reco_id = t.tram_recorrido_id
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_d
	ON p_d.puer_id = tram_puerto_desde
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_h
	ON p_h.puer_id = tram_puerto_hasta
	WHERE reco_codigo = @reco_codigo AND reco_activo = 1
	ORDER BY tram_id
END
GO

CREATE FUNCTION MACACO_NOT_NULL.ciudad_origen (@reco_id INT)  
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @origen nvarchar(255);
	SET @origen = (select puer_nombre from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_id
		and t.tram_id = (select MIN(t.tram_id) from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_id))

	RETURN(@origen);
END
GO


CREATE FUNCTION MACACO_NOT_NULL.ciudad_destino (@reco_id INT)  
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @destino nvarchar(255)
	SET @destino = (select puer_nombre from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_hasta)
		where t.tram_recorrido_id = @reco_id
		and t.tram_id = (select MAX(t.tram_id) from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_hasta)
		where t.tram_recorrido_id = @reco_id))

	RETURN(@destino)
END
GO


CREATE PROCEDURE [MACACO_NOT_NULL].getRecorridos @reco_codigo DECIMAL(18,0),
	@ciudad_origen NVARCHAR(256), @ciudad_destino NVARCHAR(256)
AS
BEGIN
	SELECT r.reco_id as id,r.reco_codigo as codigo, MACACO_NOT_NULL.ciudad_origen(t.tram_recorrido_id) as
	 ciudadOrigen, MACACO_NOT_NULL.ciudad_destino(t.tram_recorrido_id) as
	  ciudadDestino, SUM(t.tram_precio_base) as precio
	FROM MACACO_NOT_NULL.RECORRIDO AS r
	LEFT JOIN MACACO_NOT_NULL.TRAMO t
	ON r.reco_id = t.tram_recorrido_id
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_d
	ON p_d.puer_id = tram_puerto_desde
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_h
	ON p_h.puer_id = tram_puerto_hasta
	WHERE reco_activo = 1 
	GROUP BY  r.reco_id,r.reco_codigo,t.tram_recorrido_id
	HAVING (@reco_codigo IS NULL OR (CONVERT(NVARCHAR(18),reco_codigo) LIKE CONCAT('%',@reco_codigo,'%')))
	AND (@ciudad_origen IS NULL OR (MACACO_NOT_NULL.ciudad_origen(t.tram_recorrido_id) = @ciudad_origen))
	AND (@ciudad_destino IS NULL OR (MACACO_NOT_NULL.ciudad_destino(t.tram_recorrido_id) = @ciudad_destino)) 
END
GO


CREATE TYPE [MACACO_NOT_NULL].TRAMOTYPE AS TABLE   
( ciudadOrigen INT 
, ciudadDestino INT
,precio DECIMAL(18,2)
,indice INT
,tramoId INT )  
GO


CREATE PROCEDURE [MACACO_NOT_NULL].InsertRecorrido @reco_codigo decimal(18,0),
 @tramos [MACACO_NOT_NULL].TRAMOTYPE READONLY
AS
BEGIN  
	IF EXISTS (SELECT reco_id FROM [MACACO_NOT_NULL].RECORRIDO
	 WHERE reco_codigo =@reco_codigo)
		THROW 51000, 'Código ya existente', 1;
	 ELSE
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO [MACACO_NOT_NULL].RECORRIDO (reco_codigo,reco_activo)
			VALUES (@reco_codigo,1);

		DECLARE @reco_id INT;

		SET @reco_id = (SELECT reco_id FROM  [MACACO_NOT_NULL].RECORRIDO
					WHERE reco_codigo = @reco_codigo);

		INSERT INTO [MACACO_NOT_NULL].TRAMO 
		SELECT @reco_id, ciudadOrigen, ciudadDestino, precio 
		FROM @tramos
		ORDER BY indice

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK;
		THROW;
	END CATCH
END 
GO

CREATE PROCEDURE [MACACO_NOT_NULL].BajaRecorrido @reco_codigo decimal(18,0)
AS
BEGIN
IF EXISTS (SELECT pasa_id FROM [MACACO_NOT_NULL].RECORRIDO AS r 
			JOIN [MACACO_NOT_NULL].VIAJE AS v
			ON (r.reco_id = v.viaj_recorrido_id)
			JOIN [MACACO_NOT_NULL].PASAJE AS p
			ON (v.viaj_recorrido_id = p.pasa_viaje_id)
			WHERE reco_codigo = @reco_codigo
			AND v.viaj_fecha_llegada > GETDATE())
		THROW 51000, 'Existen pasajes de viajes que contienen al recorrido', 1;
	 ELSE
		UPDATE [MACACO_NOT_NULL].RECORRIDO
		SET reco_activo = 0
		WHERE reco_codigo = @reco_codigo
END
GO


CREATE FUNCTION [MACACO_NOT_NULL].GetPuertoId (@puerto NVARCHAR(256))
RETURNS INT
AS
BEGIN
	DECLARE @id INT
	SET @id = (SELECT puer_id FROM [MACACO_NOT_NULL].PUERTO WHERE puer_nombre = @puerto)
	RETURN (@id)
END
GO

CREATE PROCEDURE [MACACO_NOT_NULL].GetPuertoByName @name NVARCHAR(256)
AS
BEGIN 
	SELECT puer_id,puer_nombre FROM [MACACO_NOT_NULL].PUERTO WHERE puer_nombre = @name
END

GO

CREATE PROCEDURE [MACACO_NOT_NULL].ModificarRecorrido @reco_codigo decimal(18,0),
@tramos [MACACO_NOT_NULL].TRAMOTYPE READONLY 
AS
BEGIN
	MERGE MACACO_NOT_NULL.TRAMO as t 
		USING @tramos as t_n
		on (t.tram_id = t_n.tramoId)
	WHEN MATCHED THEN UPDATE
	SET t.tram_puerto_desde = t_n.ciudadOrigen
	, t.tram_puerto_hasta = t_n.ciudadDestino
	, t.tram_precio_base = t_n.precio
	WHEN NOT MATCHED BY TARGET
	THEN INSERT (tram_recorrido_id,tram_puerto_desde,tram_puerto_hasta,tram_precio_base)
	VALUES (MACACO_NOT_NULL.GetRecorridoIdByRecoCodigo(@reco_codigo),t_n.ciudadOrigen, t_n.ciudadDestino,t_n.precio)
	WHEN NOT MATCHED  BY SOURCE AND t.tram_recorrido_id = MACACO_NOT_NULL.GetRecorridoIdByRecoCodigo(@reco_codigo)
	 THEN DELETE;
END
GO

CREATE FUNCTION [MACACO_NOT_NULL].GetRecorridoIdByRecoCodigo (@reco_codigo DECIMAL(18,0))
RETURNS INT
AS
BEGIN
	DECLARE @reco_id INT
	SET @reco_id = (SELECT reco_id FROM MACACO_NOT_NULL.RECORRIDO WHERE reco_codigo = @reco_codigo)
	RETURN (@reco_id)
END
GO


CREATE FUNCTION [MACACO_NOT_NULL].PrecioRecorrido (@reco_id decimal(18,0))
RETURNS DECIMAL(18,2)
AS
BEGIN
DECLARE @sum DECIMAL(18,2)

SET @sum = 	(SELECT SUM(tram_precio_base)
	FROM [MACACO_NOT_NULL].TRAMO
	WHERE tram_recorrido_id = @reco_id)
return(@sum)
END