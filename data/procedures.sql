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