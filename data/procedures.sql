CREATE PROCEDURE MACACO_NOT_NULL.GetTramos @reco_codigo decimal(18,0)
AS
BEGIN
	SELECT p_d.puer_nombre as desde, p_h.puer_nombre as hasta, tram_precio_base as precio
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

CREATE PROCEDURE MACACO_NOT_NULL.getRecorridos 
AS
BEGIN
	SELECT r.reco_codigo as code, MACACO_NOT_NULL.ciudad_origen(t.tram_recorrido_id) as origin, MACACO_NOT_NULL.ciudad_destino(t.tram_recorrido_id) as 'end', SUM(t.tram_precio_base) as price
	FROM MACACO_NOT_NULL.RECORRIDO AS r
	LEFT JOIN MACACO_NOT_NULL.TRAMO t
	ON r.reco_id = t.tram_recorrido_id
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_d
	ON p_d.puer_id = tram_puerto_desde
	LEFT JOIN MACACO_NOT_NULL.PUERTO AS p_h
	ON p_h.puer_id = tram_puerto_hasta
	WHERE reco_activo = 1
	GROUP BY r.reco_codigo,t.tram_recorrido_id
END

CREATE FUNCTION MACACO_NOT_NULL.ciudad_origen (@reco_codigo decimal(18,0))  
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @origen nvarchar(255);
	SET @origen = (select puer_nombre from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_codigo
		and t.tram_id = (select MIN(t.tram_id) from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_codigo))

	RETURN(@origen);
END

CREATE FUNCTION MACACO_NOT_NULL.ciudad_destino (@reco_codigo decimal(18,0))  
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @origen nvarchar(255);
	SET @origen = (select puer_nombre from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_codigo
		and t.tram_id = (select MAX(t.tram_id) from MACACO_NOT_NULL.PUERTO as p 
		join MACACO_NOT_NULL.TRAMO as t on (p.puer_id = t.tram_puerto_desde)
		where t.tram_recorrido_id = @reco_codigo))

	RETURN(@origen);
END


