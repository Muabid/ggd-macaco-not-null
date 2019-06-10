USE [GD1C2019]

GO

IF NOT EXISTS (SELECT * FROM SYS.SCHEMAS WHERE name = 'MACACO_NOT_NULL')
BEGIN
EXEC ('CREATE SCHEMA [MACACO_NOT_NULL] AUTHORIZATION [gdCruceros2019]')
END
GO

IF NOT EXISTS (
	SELECT *
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'ROL'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[ROL] (
	rol_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	rol_nombre [nvarchar](255) NOT NULL,
	rol_activo [bit] NOT NULL DEFAULT 1
);
END
GO


IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'USUARIO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[USUARIO] (
	usua_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	usua_nombre [nvarchar](255) NOT NULL,
	usua_apellido [nvarchar](255) NOT NULL,
	usua_dni [decimal](18, 0)  NOT NULL   ,
	usua_direccion [nvarchar](255) NOT NULL,
	usua_telefono [int] NOT NULL,
	usua_mail [nvarchar](255),
	usua_fecha_nac  [datetime2](3) NOT NULL,
	usua_rol_id [int] FOREIGN KEY REFERENCES [MACACO_NOT_NULL].ROL(rol_id),
	usua_activo [bit] NOT NULL
);
END
GO
 
 IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'LOGIN'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[LOGIN](
	logi_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	logi_username [nvarchar](255) UNIQUE NOT NULL,
	logi_password [nvarchar](255) NOT NULL,
	logi_usuario_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].USUARIO(usua_id) NOT NULL,
	logi_intento_fallido int NOT NULL 
);
END
GO

 IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'FUNCIONALIDAD'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[FUNCIONALIDAD] (
	func_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	func_detalle [nvarchar](255) NOT NULL,
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'ROL_FUNCIONALIDAD'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[ROL_FUNCIONALIDAD] (
	rol_funcionalidad_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	rol_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].ROL(rol_id) NOT NULL,
	func_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].FUNCIONALIDAD(func_id) NOT NULL,
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'COMPANIA'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[COMPANIA] (
	comp_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	comp_nombre [nvarchar](255) NOT NULL,
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'RESERVA'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[RESERVA] (
	rese_id  int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	rese_usuario_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[USUARIO] (usua_id),
	rese_codigo decimal (18,0) NOT NULL,
	rese_fecha datetime2 (3) NOT NULL,
	rese_viaje_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[VIAJE] (viaj_id)
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'PAGO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE  [MACACO_NOT_NULL].[PAGO] (
	pago_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	pago_usuario_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[USUARIO] (usua_id) NOT NULL
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'MEDIO_DE_PAGO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[MEDIO_DE_PAGO] (
	medi_pago_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	pago_id  int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[PAGO](pago_id),
	medi_cantidad_cuotas int NOT NULL,
	medi_descripcion [nvarchar](255) NOT NULL
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'PUERTO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE  [MACACO_NOT_NULL].[PUERTO] (
	puer_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	puer_nombre [nvarchar](255) NOT NULL
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'TIPO_SERVICIO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE  [MACACO_NOT_NULL].[TIPO_SERVICIO] (
	tipo_servicio_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	tipo_servicio_descripcion nvarchar(255) NOT NULL,
	tipo_servicio_porc_recargo [decimal](18, 2)
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'CRUCERO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[CRUCERO] (
	cruc_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	cruc_compañia_id  int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[COMPANIA] (comp_id), 
	cruc_nombre [nvarchar](255),
	cruc_modelo [nvarchar](50),
	cruc_activo [bit],
	cruc_fecha_alta [datetime2](3),
	cruc_cantidad_cabinas [int]
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'BAJA_CRUCERO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[BAJA_CRUCERO] (
	baja_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	baja_cruc_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[CRUCERO] (cruc_id), 
	baja_cruc_fecha_fuera_servicio [datetime2](3),
	baja_cruc_fecha_reinicio_servicio [datetime2](3),
	baja_cruc_motivo [nvarchar](255)
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'CABINA'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[CABINA] (
	cabi_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	cabi_nro  decimal (18,0) NOT NULL, 
	cabi_piso decimal (18,0) NOT NULL , 
	cabi_tipo_servicio_id int  FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[TIPO_SERVICIO] (tipo_servicio_id), 
	cabi_crucero_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[CRUCERO] (cruc_id) 
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'RECORRIDO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
 CREATE TABLE [MACACO_NOT_NULL].[RECORRIDO] (
	reco_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	reco_codigo decimal (18,0) NOT NULL,
	reco_activo bit DEFAULT 1
 );
 END
 GO

 IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'VIAJE'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
 CREATE TABLE [MACACO_NOT_NULL].[VIAJE] ( 
	viaj_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	viaj_fecha_salida datetime2(3) NOT NULL, 
	viaj_fecha_llegada datetime2(3) NOT NULL ,
	viaj_fecha_llegada_estimada datetime2(2) NOT NULL, 
	viaj_crucero_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[CRUCERO](cruc_id),
	viaj_recorrido_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[RECORRIDO] (reco_id) 
 );
 END
 GO

 IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'PASAJE'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[PASAJE] (
	pasa_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	pasa_codigo decimal(18,0) NOT NULL,
	pasa_precio decimal (18,2) NOT NULL,
	pasa_fecha_compra datetime2(3) NOT NULL,
	pasa_cab_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[CABINA](cabi_id),
	pasa_viaje_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[VIAJE](viaj_id),
	pasa_pago_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[PAGO](pago_id),
	pasa_baja_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[BAJA_CRUCERO](baja_id)
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'TRAMO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[TRAMO] (
	tram_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	tram_recorrido_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].RECORRIDO(reco_id),
	tram_puerto_desde [int] FOREIGN KEY REFERENCES [MACACO_NOT_NULL].PUERTO(puer_id),
	tram_puerto_hasta [int] FOREIGN KEY REFERENCES [MACACO_NOT_NULL].PUERTO(puer_id),
	tram_precio_base decimal (18,2) NOT NULL
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE TABLE'
	AND TABLE_NAME = 'RESERVA_CABINA'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[RESERVA_CABINA] (
	rese_cabi_id  int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	reserva_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[RESERVA] (rese_id),
	cabina_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[CABINA] (cabi_id),
	rese_cabi_costo DECIMAL (18,2) 
);
END
GO

INSERT INTO [MACACO_NOT_NULL].[ROL] (rol_nombre,rol_activo)	
	VALUES ('ADMINISTRADOR',1),('CLIENTE',1);

 INSERT INTO [MACACO_NOT_NULL].[FUNCIONALIDAD] (func_detalle)	
	VALUES ('ABM de Rol'),('ABM de Recorrido'), 
		   ('ABM de Crucero'),('Generar Viaje'), 
		   ('Compra y/o reserva de viaje'),('Pago Reserva'),('Listado Estadístico');

INSERT INTO [MACACO_NOT_NULL].[ROL_FUNCIONALIDAD] (rol_id,func_id)	
	VALUES (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(2,5),(2,6);
	 
 INSERT INTO [MACACO_NOT_NULL].USUARIO (
											usua_nombre,
											usua_apellido,
											usua_dni,
											usua_direccion ,
											usua_telefono,
											usua_mail,
											usua_fecha_nac,
											usua_rol_id ,
											usua_activo
										)
	select distinct CLI_NOMBRE,CLI_APELLIDO,CLI_DNI,CLI_DIRECCION,CLI_TELEFONO,CLI_MAIL,CLI_FECHA_NAC,2,1
		FROM [GD1C2019].[gd_esquema].[Maestra];

INSERT INTO [MACACO_NOT_NULL].[USUARIO] (
											usua_nombre,
											usua_apellido,
											usua_dni,
											usua_direccion,
											usua_telefono,
											usua_mail,
											usua_fecha_nac,
											usua_rol_id,
											usua_activo											
										)	
	VALUES ('JUAN','Perez',40545987,'Gestion123',78543625,'gdd@gmail.com',CONVERT(datetime2(3),'1988-08-28 00:00:00.000',121),1,1),
		   ('JOSE','Gonzalez',40987234,'Medrano 876',45237825,'almagro@gmail.com',CONVERT(datetime2(3),'1998-04-22 00:00:00.000',121),1,1),
		   ('ANDRES','Montana',61248982,'Avenida Cordoba 8568',48916685,'montana@gmail.com',CONVERT(datetime2(3),'1964-11-18 00:00:00.000',121),1,1),
		   ('MICAELA','MOZART',37918442,'Avenida Corrientes 6732',42359645,'sinfonia@gmail.com',CONVERT(datetime2(3),'1976-12-24 00:00:00.000',121),1,1),
		   ('ROCIO','TESORO',15948315,'Avenida Callao 458',46549821,'rtesoro@gmail.com',CONVERT(datetime2(3),'1982-04-06 00:00:00.000',121),1,1),
		   ('Administrador','General',1,'Admin12345',45231111,'admin@gmail.com',CONVERT(datetime2(3),'1962-09-16 00:00:00.000',121),1,1);
	
INSERT INTO [MACACO_NOT_NULL].LOGIN (logi_username,logi_password,logi_usuario_id,logi_intento_fallido)	
	VALUES ('rtesoro','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 15948315 and usua_direccion = 'Avenida Callao 458'),0),
		   ('mMozart','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 37918442 and usua_direccion = 'Avenida Corrientes 6732'),0),
	       ('aMontana','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 61248982 and usua_direccion = 'Avenida Cordoba 8568'),0),
	       ('jGonzalez','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 40987234 and usua_direccion = 'Medrano 876'),0),
		   ('jPerez','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 40545987 and usua_direccion = 'Gestion123'),0),
		   ('admin','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 1 and usua_direccion = 'Admin12345'),0);
		  
INSERT INTO [MACACO_NOT_NULL].COMPANIA (comp_nombre)
	select distinct CRU_FABRICANTE FROM [GD1C2019].[gd_esquema].[Maestra];


INSERT INTO [MACACO_NOT_NULL].TIPO_SERVICIO (tipo_servicio_descripcion,tipo_servicio_porc_recargo)
		select distinct CABINA_TIPO,CABINA_TIPO_PORC_RECARGO FROM [GD1C2019].[gd_esquema].[Maestra];

INSERT INTO [MACACO_NOT_NULL].PUERTO (puer_nombre)
		select distinct PUERTO_DESDE FROM [GD1C2019].[gd_esquema].[Maestra];


 INSERT INTO [MACACO_NOT_NULL].CRUCERO(
											cruc_nombre,
											cruc_modelo ,
											cruc_compañia_id,
											cruc_cantidad_cabinas																														
										)
	select a.CRUCERO_IDENTIFICADOR,a.CRUCERO_MODELO,company,COUNT(*)
	from 
		(
			select distinct m2.CABINA_NRO,m2.CABINA_PISO,m2.CRUCERO_IDENTIFICADOR,m2.CRUCERO_MODELO,
				(	
					 select comp_id
					 from [MACACO_NOT_NULL].COMPANIA 
					 where comp_nombre = m2.CRU_FABRICANTE
				) as company
			FROM [GD1C2019].[gd_esquema].[Maestra] m2   
		) a  
	group by a.CRUCERO_IDENTIFICADOR,a.CRUCERO_MODELO,company;

INSERT INTO [MACACO_NOT_NULL].CABINA(
											cabi_nro,
											cabi_piso ,
											cabi_crucero_id,
											cabi_tipo_servicio_id																														
										)
	select distinct CABINA_NRO,CABINA_PISO,
	(	
			 select cruc_id
			 from [MACACO_NOT_NULL].CRUCERO 
			 where CRUCERO_IDENTIFICADOR = cruc_nombre
	),
	(	
			 select tipo_servicio_id
			 from [MACACO_NOT_NULL].TIPO_SERVICIO 
			 where tipo_servicio_descripcion = CABINA_TIPO
	) 
   FROM [GD1C2019].[gd_esquema].[Maestra];
   
   
  INSERT INTO [MACACO_NOT_NULL].RECORRIDO(
											[reco_codigo],
											[reco_activo] 																																								
										)
	select distinct RECORRIDO_CODIGO,1
   FROM [GD1C2019].[gd_esquema].[Maestra];


--INSERTA EN ORDEN LOS TRAMOS--

BEGIN TRANSACTION
	BEGIN
	DECLARE @reco_cod DECIMAL(18,0)
	DECLARE @origen nvarchar(256)
	DECLARE @destino nvarchar(256)
	DECLARE @precio DECIMAL(18,2)	
	DECLARE reco_cod CURSOR FOR SELECT reco_codigo FROM MACACO_NOT_NULL.RECORRIDO 
	OPEN reco_cod
	FETCH NEXT FROM reco_cod INTO @reco_cod
	WHILE  @@FETCH_STATUS = 0  
	BEGIN
		SET @origen= (select DISTINCT  PUERTO_DESDE
			FROM gd_esquema.Maestra
			WHERE PUERTO_DESDE not in (select PUERTO_HASTA from gd_esquema.Maestra where RECORRIDO_CODIGO =@reco_cod)
			 AND RECORRIDO_CODIGO = @reco_cod)
		SET @destino = (SELECT DISTINCT PUERTO_HASTA FROM gd_esquema.Maestra
						 WHERE PUERTO_DESDE = @origen AND RECORRIDO_CODIGO = @reco_cod) 
		

		WHILE  @destino IS NOT NULL
		BEGIN
			SET @precio = (SELECT DISTINCT RECORRIDO_PRECIO_BASE FROM gd_esquema.Maestra
					 WHERE PUERTO_DESDE = @origen AND PUERTO_HASTA = @destino AND RECORRIDO_CODIGO = @reco_cod)

			INSERT INTO MACACO_NOT_NULL.TRAMO (tram_puerto_desde, tram_puerto_hasta,tram_recorrido_id,tram_precio_base) 
			VALUES ((SELECT puer_id FROM MACACO_NOT_NULL.PUERTO WHERE puer_nombre = @origen),
			(SELECT puer_id FROM MACACO_NOT_NULL.PUERTO WHERE puer_nombre = @destino),
			(SELECT reco_id FROM MACACO_NOT_NULL.RECORRIDO WHERE reco_codigo = @reco_cod),
			@precio)

			SET @origen = @destino
			SET @destino = (SELECT DISTINCT PUERTO_HASTA FROM gd_esquema.Maestra
							 WHERE PUERTO_DESDE = @origen AND RECORRIDO_CODIGO = @reco_cod)
		END
		FETCH NEXT FROM reco_cod INTO @reco_cod
	END
	CLOSE reco_cod;  
	DEALLOCATE reco_cod;
	COMMIT TRANSACTION;
END

/*   
INSERT INTO [MACACO_NOT_NULL].TRAMO(
										tram_precio_base,
										tram_recorrido_id,
										tram_puerto_desde,
										tram_puerto_hasta																																								
									)
	select distinct RECORRIDO_PRECIO_BASE,
	(	
			 select reco_id
			 from [MACACO_NOT_NULL].RECORRIDO 
			 where reco_codigo = RECORRIDO_CODIGO
	),
	(	
			 select puer_id 
			 from [MACACO_NOT_NULL].PUERTO 
			 where puer_nombre = PUERTO_DESDE
	),
	(	
			 select puer_id 
			 from [MACACO_NOT_NULL].PUERTO 
			 where puer_nombre = PUERTO_HASTA
	) 
   FROM [GD1C2019].[gd_esquema].[Maestra];
*/  
 INSERT INTO [MACACO_NOT_NULL].VIAJE(
										viaj_fecha_salida,
										viaj_fecha_llegada,
										viaj_fecha_llegada_estimada,
										viaj_crucero_id,
										viaj_recorrido_id																																								
									)
	select distinct FECHA_SALIDA,FECHA_LLEGADA,FECHA_LLEGADA_ESTIMADA,
	(	
			 select cruc_id
			 from [MACACO_NOT_NULL].CRUCERO 
			 where CRUCERO_IDENTIFICADOR = cruc_nombre
	),
	(	
			 select reco_id
			 from [MACACO_NOT_NULL].RECORRIDO 
			 where reco_codigo = RECORRIDO_CODIGO
	)
	FROM [GD1C2019].[gd_esquema].[Maestra];

	
INSERT INTO [MACACO_NOT_NULL].RESERVA(
											rese_codigo,
											rese_fecha ,
											rese_usuario_id,
											rese_viaje_id
									 )
	select distinct RESERVA_CODIGO,RESERVA_FECHA,
	(	
			 select usua_id
			 from [MACACO_NOT_NULL].USUARIO 
			 where CLI_DNI = usua_dni 
					and CLI_DIRECCION = usua_direccion
	),
	(
			select viaj_id 	
			FROM [MACACO_NOT_NULL].[VIAJE]
			where viaj_fecha_salida = FECHA_SALIDA     
			   and viaj_fecha_llegada = FECHA_LLEGADA  
			   and viaj_fecha_llegada_estimada = FECHA_LLEGADA_ESTIMADA     
			   and viaj_crucero_id = (select cruc_id from [MACACO_NOT_NULL].CRUCERO where cruc_nombre = CRUCERO_IDENTIFICADOR) 
			   and viaj_recorrido_id = (select reco_id from [MACACO_NOT_NULL].RECORRIDO where reco_codigo = RECORRIDO_CODIGO)         
	)
   FROM [GD1C2019].[gd_esquema].[Maestra]
   where RESERVA_CODIGO is not null 
	and RESERVA_FECHA is not null;
	

INSERT INTO [MACACO_NOT_NULL].RESERVA_CABINA(
											reserva_id,
											cabina_id
									 )
	select distinct 
	(	
			 select rese_id
			 from [MACACO_NOT_NULL].RESERVA 
			 where rese_codigo = RESERVA_CODIGO 
	),
	(	
			 select cabi_id
			 from [MACACO_NOT_NULL].CABINA 
			 where cabi_nro = CABINA_NRO
				and cabi_piso = CABINA_PISO
                and cabi_tipo_servicio_id = (select tipo_servicio_id from [MACACO_NOT_NULL].TIPO_SERVICIO where tipo_servicio_descripcion = CABINA_TIPO) 
                and cabi_crucero_id = (select cruc_id from [MACACO_NOT_NULL].CRUCERO where cruc_nombre = CRUCERO_IDENTIFICADOR) 
	)	
   FROM [GD1C2019].[gd_esquema].[Maestra]
   where RESERVA_CODIGO is not null 
	and RESERVA_FECHA is not null;
	
	
INSERT INTO [MACACO_NOT_NULL].PASAJE(
										pasa_codigo,
										pasa_precio,
										pasa_fecha_compra,
										pasa_cab_id,
										pasa_viaje_id																																					
									)
	select distinct PASAJE_CODIGO,PASAJE_PRECIO,PASAJE_FECHA_COMPRA,
	(	
			 select cabi_id
			 from [MACACO_NOT_NULL].CABINA 
				INNER JOIN [MACACO_NOT_NULL].TIPO_SERVICIO 
					ON tipo_servicio_id = cabi_tipo_servicio_id
				INNER JOIN [MACACO_NOT_NULL].CRUCERO
					ON cruc_id = cabi_crucero_id
			 where CRUCERO_IDENTIFICADOR = cruc_nombre
				and tipo_servicio_descripcion = CABINA_TIPO
				and cabi_nro = CABINA_NRO
				and cabi_piso = CABINA_PISO
	),
	(	
			 select viaj_id
			 from [MACACO_NOT_NULL].VIAJE 
				INNER JOIN [MACACO_NOT_NULL].CRUCERO
					ON cruc_id = viaj_crucero_id
				INNER JOIN [MACACO_NOT_NULL].RECORRIDO
					on reco_id = viaj_recorrido_id
			 where CRUCERO_IDENTIFICADOR = cruc_nombre
				and RECORRIDO_CODIGO = reco_codigo	
				and FECHA_SALIDA = viaj_fecha_salida
				and FECHA_LLEGADA = viaj_fecha_llegada
				and FECHA_LLEGADA_ESTIMADA = viaj_fecha_llegada_estimada	 
	)
	FROM [GD1C2019].[gd_esquema].[Maestra]
	where PASAJE_CODIGO IS NOT NULL and
	PASAJE_PRECIO IS NOT NULL and
	PASAJE_FECHA_COMPRA IS NOT NULL ;
	

INSERT INTO [MACACO_NOT_NULL].PAGO(
										pago_usuario_id																																				
									)
  SELECT usua_id from [GD1C2019].[gd_esquema].[Maestra],[MACACO_NOT_NULL].USUARIO
	 where CLI_DNI = usua_dni 
		 and CLI_DIRECCION = usua_direccion
		 and PASAJE_CODIGO IS NOT NULL 
		 and PASAJE_PRECIO IS NOT NULL 
		 and PASAJE_FECHA_COMPRA IS NOT NULL ;

GO



IF NOT EXISTS (
	SELECT *
	FROM INFORMATION_SCHEMA.SEQUENCES
	WHERE SEQUENCE_NAME = 'CountBy1'
)
BEGIN	 
CREATE SEQUENCE [MACACO_NOT_NULL].CountBy1  
    START WITH 1  
    INCREMENT BY 1 ; 
END
GO

update [MACACO_NOT_NULL].PASAJE set pasa_pago_id = (NEXT VALUE FOR [MACACO_NOT_NULL].CountBy1)
		where 1 = (select ROW_NUMBER() OVER(ORDER BY pasa_id ASC));

GO  
ALTER SEQUENCE [MACACO_NOT_NULL].CountBy1 
RESTART WITH 1;
  
  
  
------------- ABM Rol---------------
---------------ALTA---------------
GO
CREATE PROCEDURE [MACACO_NOT_NULL].AltaRol
@nombre_rol NVARCHAR(255),
@activo BIT
AS
BEGIN
	IF(NOT EXISTS(SELECT rol_nombre FROM [MACACO_NOT_NULL].ROL WHERE rol_nombre = @nombre_rol))
		BEGIN
				INSERT INTO [MACACO_NOT_NULL].ROL(rol_nombre,rol_activo)	
				VALUES(@nombre_rol,@activo)
		END
	ELSE
		BEGIN
		DECLARE @rol_id int
		SET @rol_id = (SELECT rol_id FROM [MACACO_NOT_NULL].ROL WHERE rol_nombre = @nombre_rol)
			IF ( EXISTS(SELECT rol_activo FROM [MACACO_NOT_NULL].ROL WHERE rol_nombre = @nombre_rol) )
				BEGIN
				BEGIN TRANSACTION
					UPDATE [MACACO_NOT_NULL].ROL SET rol_activo = 1	WHERE rol_id = @rol_id
		
					UPDATE [MACACO_NOT_NULL].USUARIO SET usua_rol_id = @rol_id	WHERE usua_rol_id = @rol_id
				COMMIT TRANSACTION
				END
			ELSE
			BEGIN
				RAISERROR('ERROR: El rol ingresado ya existe',16,1)
			END
		END
END
GO;



-----BuscarRol



CREATE PROCEDURE [MACACO_NOT_NULL].BuscarRol
@nombre_rol NVARCHAR(255),
@activo BIT,
@nombre_funcionalidad NVARCHAR(255)

AS
BEGIN
	
	DECLARE @roles TABLE (
	rol_id INT,
	rol_nombre NVARCHAR(255),
	rol_activo BIT
	)

	INSERT INTO @roles
	SELECT rol_id,rol_nombre,rol_activo FROM [MACACO_NOT_NULL].[ROL]
    WHERE (rol_nombre IS NULL OR  rol_nombre LIKE CONCAT('%',@nombre_rol,'%'))AND
	rol_activo = @activo 
	
	SELECT rol_id,rol_nombre,rol_activo FROM @roles as r
	WHERE @nombre_funcionalidad IS NULL OR @nombre_funcionalidad 
	 IN (select func_detalle from MACACO_NOT_NULL.ROL a join MACACO_NOT_NULL.ROL_FUNCIONALIDAD b on a.rol_id = b.rol_id
	join MACACO_NOT_NULL.FUNCIONALIDAD c on c.func_id = b.func_id WHERE a.rol_id = r.rol_id)
	
END
GO
---------------BAJA---------------
CREATE PROCEDURE [MACACO_NOT_NULL].BajaRol
@rol_id int
AS
	BEGIN
		BEGIN TRANSACTION
			UPDATE [MACACO_NOT_NULL].ROL SET rol_activo = 0	WHERE rol_id = @rol_id		
			UPDATE [MACACO_NOT_NULL].USUARIO SET usua_rol_id = NULL	WHERE usua_rol_id = @rol_id
		COMMIT TRANSACTION
	END
GO

---------------MODIFICACION---------------
--Se llama este procedure primero al querer modificar un rol
CREATE PROCEDURE [MACACO_NOT_NULL].ModificarNombreRol
@rol_id int,
@nuevoNombreRol NVARCHAR(255)
AS
BEGIN
	IF(NOT EXISTS(SELECT rol_nombre FROM [MACACO_NOT_NULL].ROL WHERE rol_nombre = @nuevoNombreRol))
	BEGIN
		UPDATE [MACACO_NOT_NULL].ROL SET rol_nombre = @nuevoNombreRol WHERE rol_id = @rol_id
		DELETE from [MACACO_NOT_NULL].ROL_FUNCIONALIDAD where rol_id = @rol_id		
	END
	ELSE
	BEGIN
		RAISERROR('ERROR: Nombre de rol ya existente',16,1)
	END
END
GO

-- Si en la tabla de funcionalidad  pantalla de modificacion de Rol hay N filas, llamar a este procedure N veces
CREATE PROCEDURE [MACACO_NOT_NULL].AgregarFuncionalidadRol 
@rol_id int,
@nombreNuevaFuncionalidadRol NVARCHAR(255)
AS
	BEGIN
	DECLARE @idNuevaFuncionalidadRol int
	SET @idNuevaFuncionalidadRol = (SELECT func_id FROM [MACACO_NOT_NULL].[FUNCIONALIDAD] where func_detalle = @nombreNuevaFuncionalidadRol)
	IF(NOT EXISTS(SELECT func_id FROM [MACACO_NOT_NULL].ROL_FUNCIONALIDAD WHERE func_id = @idNuevaFuncionalidadRol AND rol_id = @rol_id))
		BEGIN
			BEGIN TRANSACTION
				INSERT INTO [MACACO_NOT_NULL].ROL_FUNCIONALIDAD(rol_id,func_id)	VALUES (@rol_id,@idNuevaFuncionalidadRol)
			COMMIT TRANSACTION
		END
	ELSE 
		BEGIN
			RAISERROR('ERROR: Funcionalidad existente para este rol',16,1)
		END	
END
GO

CREATE PROCEDURE [MACACO_NOT_NULL].HabilitarRol 
@rol_id int
AS
BEGIN
	UPDATE [MACACO_NOT_NULL].ROL SET rol_activo = 1 WHERE rol_id = @rol_id
END

GO
 
-------------------------- LOGIN Y SEGURIDAD ------------

---------------- FUNCION ENCRIPTACION PASSWORD ------------------------------------
CREATE FUNCTION [MACACO_NOT_NULL].EncriptarPassword(@password NVARCHAR(255))
RETURNS nvarchar(255)
AS
BEGIN
	RETURN CONVERT(nvarchar(255),HASHBYTES('SHA2_256',@password),1)
END

GO
 
CREATE PROCEDURE [MACACO_NOT_NULL].LogearUsuario 
@username NVARCHAR(255),
@password NVARCHAR(255)
AS
BEGIN
	DECLARE @intentosFallidosActuales int
	IF(NOT EXISTS(SELECT logi_usuario_id FROM [MACACO_NOT_NULL].LOGIN WHERE logi_username = @username))
	BEGIN
			RAISERROR ('ERROR: Loggin incorrecto, no existe ningun usuario con el username ingresado',16,1)
	END
	ELSE
	BEGIN	
		SET @intentosFallidosActuales = (SELECT logi_intento_fallido FROM [MACACO_NOT_NULL].LOGIN WHERE logi_username = @username)
		IF(NOT EXISTS(SELECT logi_usuario_id FROM [MACACO_NOT_NULL].LOGIN WHERE logi_username = @username AND logi_password	= [MACACO_NOT_NULL].EncriptarPassword(@password)))
		BEGIN						
			BEGIN TRANSACTION
				UPDATE [MACACO_NOT_NULL].LOGIN SET logi_intento_fallido = (@intentosFallidosActuales + 1) WHERE logi_username = @username
			COMMIT TRANSACTION
			RAISERROR ('ERROR: Loggin incorrecto para el usuario %s .',16,1,@username)
		END
		ELSE 
		BEGIN
			BEGIN TRANSACTION
				UPDATE [MACACO_NOT_NULL].LOGIN SET logi_intento_fallido = 0 WHERE logi_username = @username
				DECLARE @idUsuarioLoggeado INT
				SET @idUsuarioLoggeado = (SELECT logi_usuario_id FROM [MACACO_NOT_NULL].LOGIN WHERE logi_username = @username)
				UPDATE [MACACO_NOT_NULL].USUARIO set usua_activo = 1 WHERE usua_id = @idUsuarioLoggeado
			COMMIT TRANSACTION
		END				
	END	
END
GO
 
 
-----------------------------TRIGGER-------------------------------------
----- SE EJECUTA POST LOGIN FALLIDO --------
CREATE TRIGGER [MACACO_NOT_NULL].TRIGGER_BLOQUEAR_USUARIO_POR_LOGIN_FALLIDO ON [MACACO_NOT_NULL].LOGIN AFTER UPDATE
AS
BEGIN
	IF (select logi_intento_fallido from inserted)>=3
		UPDATE [MACACO_NOT_NULL].USUARIO set usua_activo = 0 WHERE usua_id = (select logi_usuario_id from inserted)
END

GO
  
  
----------- PROCEDURE QUE DEVUELVE LOS TRAMOS DE LOS RECORRIDOS ORDENADOS LOGICAMENTE ---------------
 CREATE PROCEDURE [MACACO_NOT_NULL].OrdenarTramosRecorridos
AS
BEGIN
	 DECLARE @tablaRecorridos TABLE(reco_id int,origen1 NVARCHAR(255),destino1 NVARCHAR(255), origen2 NVARCHAR(255), destino2 NVARCHAR(255));
	 insert into @tablaRecorridos (reco_id,origen1,destino1,origen2,destino2)
		SELECT reco_id,P1.puer_nombre, P2.puer_nombre, P3.puer_nombre, P4.puer_nombre
		from MACACO_NOT_NULL.RECORRIDO 
		inner join [MACACO_NOT_NULL].[TRAMO] T1 on reco_id = tram_recorrido_id
		inner join MACACO_NOT_NULL.[TRAMO] T2 on T1.tram_recorrido_id = T2.tram_recorrido_id
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P1 ON P1.puer_id = T1.tram_puerto_desde 
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P2 ON P2.puer_id = T1.tram_puerto_hasta 
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P3 ON P3.puer_id = T2.tram_puerto_desde 
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P4 ON P4.puer_id = T2.tram_puerto_hasta
		where  P2.puer_nombre = P3.puer_nombre
		order by reco_id
	 insert into @tablaRecorridos (reco_id,origen1,destino1)
		SELECT tram_recorrido_id, P1.puer_nombre, P2.puer_nombre
		from [MACACO_NOT_NULL].[TRAMO]
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P1 ON P1.puer_id = tram_puerto_desde
		INNER JOIN [MACACO_NOT_NULL].[PUERTO] P2 ON P2.puer_id = tram_puerto_hasta 
		where tram_recorrido_id not in (select reco_id from @tablaRecorridos)

	-- SELECT reco_id,origen1,destino1,origen2,destino2
	 --FROM @tablaRecorridos
	 --order by reco_id
	IF NOT EXISTS (
	SELECT *
	FROM INFORMATION_SCHEMA.SEQUENCES
	WHERE SEQUENCE_NAME = 'IncrementoEn1'
	)
	BEGIN	 
	CREATE SEQUENCE [MACACO_NOT_NULL].IncrementoEn1  
		START WITH 1  
		INCREMENT BY 1 ; 
	END
	
		ALTER SEQUENCE [MACACO_NOT_NULL].IncrementoEn1 
		RESTART WITH 1

	 DECLARE @tablaTramosOrdenados TABLE (reco_id int,tram_id int,puertoDesde[nvarchar](255),puertoHasta [nvarchar](255))
	 insert into @tablaTramosOrdenados (reco_id,tram_id,puertoDesde,puertoHasta)
		SELECT reco_id, (NEXT VALUE FOR [MACACO_NOT_NULL].IncrementoEn1),origen1,destino1 from @tablaRecorridos
	 insert into @tablaTramosOrdenados (reco_id,tram_id,puertoDesde,puertoHasta)
		SELECT reco_id,(NEXT VALUE FOR [MACACO_NOT_NULL].IncrementoEn1),origen2,destino2 from @tablaRecorridos where origen2 is not null and destino2 is not null

	SELECT reco_id,puertoDesde,puertoHasta
		FROM @tablaTramosOrdenados
	order by reco_id,tram_id

END
  
  
GO
  
  
  
  
 ---------------------- ABM DE CRUCERO -------------
  
  
 GO
-------------------- AGREGAR BAJA A CRUCERO ------------
-------- EN LA PANTALLA DE DAR DE BAJA A UN CRUCERO, AGREGAR UN COMBOBOX AL FINAL EN DONDE EL ADMIN TENGA A ELEGIR LO QUE SE DEBE HACER CON LOS PASAJES VENDIDOS DE TODOS LOS VIAJES QUE REALIZABA EL CRUCERO (CANCELAR LOS PASAJES O REEMPLAZAR EL CRUCERO POR OTRO) ---
------- ESTO HACE QUE LUEGO DE ESTE PROCEDURE, SE DEBA EJECUTAR ALGUNO DE LOS 2 DE ABAJO, DEPENDIENDO DE LA OPCION ELEGIDA ------------
CREATE PROCEDURE [MACACO_NOT_NULL].AgregarBajaCrucero
@idCrucero int,
@baja_cruc_fecha_fuera_servicio [datetime2](3),
@baja_cruc_fecha_reinicio_servicio [datetime2](3),
@motivo [nvarchar](255)
AS
BEGIN
	INSERT INTO [MACACO_NOT_NULL].[BAJA_CRUCERO] (baja_cruc_id,baja_cruc_fecha_fuera_servicio,baja_cruc_fecha_reinicio_servicio,baja_cruc_motivo)
		VALUES (@idCrucero,@baja_cruc_fecha_fuera_servicio,@baja_cruc_fecha_reinicio_servicio,@motivo)
END

GO
  
  -------------------------------- CANCELACION DE PASAJES VENDIDOS ---------------------------
----------- SE EJECUTAR LUEGO DE AGREGAR UNA BAJA A UN CRUCERO (SIEMPRE Y CUANDO LA ACCION POSTERIOR ELEGIDA POR EL ADMIN ERA CANCELAR LOS PASAJES VENDIDOS DEL VIAJE) ------------
-- REALIZA 4 CONSULTAS:
-- 1) BORRA LOS MEDIOS DE PAGOS ASOCIADOS AL PAGO DE LOS PASAJES CUYO VIAJE LO REALIZA EL CRUCERO QUE SE ACABA DE DAR DE BAJA
-- 2) BORRA EL PAGO ASOCIADO
-- 3) SETEA LA FOREIGN KEY DE LOS PASAJES CANCELADOS, RELACIONANDOLOS CON LA BAJA QUE SE ACABA DE REALIZAR
-- 4) BORRA LAS RESERVAS ASOCIADAS (SI LAS HAY) A TODOS LOS PASAJES CANCELADOS

CREATE PROCEDURE [MACACO_NOT_NULL].CancelarPasajes
@idCrucero int
AS
BEGIN
	DELETE MedioPago
		FROM [MACACO_NOT_NULL].MEDIO_DE_PAGO MedioPago
		INNER JOIN [MACACO_NOT_NULL].PAGO Pago ON MedioPago.medi_pago_id = Pago.pago_id
		INNER JOIN [MACACO_NOT_NULL].PASAJE Pasaje ON Pago.pago_id = Pasaje.pasa_pago_id 
		INNER JOIN [MACACO_NOT_NULL].VIAJE Viaje ON Pasaje.pasa_viaje_id = Viaje.viaj_id
		WHERE Viaje.viaj_crucero_id = @idCrucero
	UPDATE Pasaje SET pasa_baja_id = (SELECT MAX(baja_id) from [MACACO_NOT_NULL].BAJA_CRUCERO)
		FROM [MACACO_NOT_NULL].PASAJE Pasaje
		INNER JOIN [MACACO_NOT_NULL].VIAJE Viaje ON Pasaje.pasa_viaje_id = Viaje.viaj_id
		WHERE Viaje.viaj_crucero_id = @idCrucero
	DELETE Pago
		FROM [MACACO_NOT_NULL].PAGO Pago 
		INNER JOIN [MACACO_NOT_NULL].PASAJE Pasaje ON Pago.pago_id = Pasaje.pasa_pago_id 
		WHERE pasa_baja_id = (SELECT MAX(baja_id) from [MACACO_NOT_NULL].BAJA_CRUCERO)
	DELETE Reserva
		FROM [MACACO_NOT_NULL].RESERVA Reserva 
		INNER JOIN [MACACO_NOT_NULL].PASAJE Pasaje ON Reserva.rese_id = Pasaje.pasa_reserva_id
		WHERE pasa_baja_id = (SELECT MAX(baja_id) from [MACACO_NOT_NULL].BAJA_CRUCERO)
END

GO
 
 -------------------------------- REEMPLAZAR CRUCERO POR OTRO ---------------------------
----------- SE EJECUTAR LUEGO DE AGREGAR UNA BAJA A UN CRUCERO (SIEMPRE Y CUANDO LA ACCION POSTERIOR ELEGIDA POR EL ADMIN ERA REEMPLAZAR EL CRUCERO POR OTRO QUE PUEDA CUMPLIR TODOS LOS VIAJES) ------------
---- LOS PASOS SON:
-- 1) SI LA OPCION ELEGIDA PARA ESE CRUCERO ERA POSPONER LOS VIAJES QUE TENIA ASIGNADO: LLAMAR AL PROCEDURE PosponerViajes (SI NO SE DEBE POSPONER SALTEAR ESTE PASO)
-- 2) LLAMAR A LA FUNCION BUSCARCRUCEROREEMPLAZANTE, QUE DEVUELVE EL CRUC_ID DEL CRUCERO QUE PUEDE REALIZAR TODOS LOS VIAJES DEL CRUCERO QUE SE ACABA DE DAR DE BAJA.
-- 3) A) SI LA FUNCION DEVOLVIO UN ID VALIDO DE UN CRUCERO EXISTENTE: LLAMAR AL PROCEDURE ReemplazarCrucero PASANDO LOS ID DE LOS 2 CRUCEROS (EL DADODEBAJA Y EL REEMPLAZANTE)
-- 3) B) SI LA FUNCION DEVOLVIO -1: QUIERE DECIR QUE NO EXISTE NINGUN CRUCERO QUE PUEDA CUMPLIR CON TODOS LOS VIAJES, 
---------CON LO QUE EL SISTEMA DEBE LLAMAR A LA PANTALLA DE ALTA DE NUEVO CRUCERO, REGISTRAR UN NUEVO CRUCERO Y LUEGO LLAMAR AL PROCEDURE ReemplazarCrucero PASANDOLE EL ID DEL CRUCERO QUE SE ACABA DE DAR DE ALTA (SELECT MAX(cruc_id) FROM MACACO_NOT_NULL.CRUCERO) Y EL ID DEL DADODEBAJA)


------------ PROCEDURE PARA POSPONER, UNA CIERTA CANTIDAD DE DIAS, LOS VIAJES DEL CRUCERO QUE SE ACABA DE DAR DE BAJA ---------------
----------- REVISAR DESPUES SI ESTO FUNCIONA BIEN... --------------
CREATE PROCEDURE [MACACO_NOT_NULL].PosponerViajes
@idCruceroInactivo int,
@cantidadDias int
AS
BEGIN
	UPDATE Viaje1 
	SET
		Viaje1.viaj_fecha_llegada = (
							SELECT DATEADD(day,@cantidadDias,Viaje2.viaj_fecha_llegada)
							FROM [MACACO_NOT_NULL].VIAJE Viaje2
							INNER JOIN [MACACO_NOT_NULL].CRUCERO Crucero ON Crucero.cruc_id = Viaje2.viaj_crucero_id
							WHERE Viaje2.viaj_crucero_id = @idCruceroInactivo 
							AND Viaje1.viaj_id = Viaje2.viaj_id
									)   ,
		Viaje1.viaj_fecha_salida = (
							SELECT DATEADD(day,@cantidadDias,Viaje2.viaj_fecha_salida)
							FROM [MACACO_NOT_NULL].VIAJE Viaje2
							INNER JOIN [MACACO_NOT_NULL].CRUCERO Crucero ON Crucero.cruc_id = Viaje2.viaj_crucero_id
							WHERE Viaje2.viaj_crucero_id = @idCruceroInactivo 
							AND Viaje1.viaj_id = Viaje2.viaj_id
									)  ,
		Viaje1.viaj_fecha_llegada_estimada = (
							SELECT DATEADD(day,@cantidadDias,Viaje2.viaj_fecha_llegada_estimada)
							FROM [MACACO_NOT_NULL].VIAJE Viaje2
							INNER JOIN [MACACO_NOT_NULL].CRUCERO Crucero ON Crucero.cruc_id = Viaje2.viaj_crucero_id
							WHERE Viaje2.viaj_crucero_id = @idCruceroInactivo 
							AND Viaje1.viaj_id = Viaje2.viaj_id
											)
	FROM [MACACO_NOT_NULL].VIAJE Viaje1
	INNER JOIN [MACACO_NOT_NULL].CRUCERO Crucero ON Crucero.cruc_id = Viaje1.viaj_crucero_id
	WHERE Viaje1.viaj_crucero_id = @idCruceroInactivo
END


GO



GO

CREATE PROCEDURE [MACACO_NOT_NULL].ReemplazarCrucero
@idCruceroInactivo int,
@idCruceroReemplazante int
AS
BEGIN
	UPDATE Viaje1 
	SET Viaje1.viaj_crucero_id = @idCruceroReemplazante
	FROM [MACACO_NOT_NULL].VIAJE Viaje1
	INNER JOIN [MACACO_NOT_NULL].CRUCERO Crucero ON Crucero.cruc_id = Viaje1.viaj_crucero_id
	WHERE Viaje1.viaj_crucero_id = @idCruceroInactivo
END
 
  
GO
 
---------------------- CREACION DE UN NUEVO VIAJE ----------------------

CREATE PROCEDURE [MACACO_NOT_NULL].CrearViaje 
@fechaSalida datetime2(3),
@fechaLlegada datetime2(3),
@fechaLlegadaEstimada datetime2(2),
@cruceroId int,
@recorridoId int
AS
BEGIN
	INSERT INTO [MACACO_NOT_NULL].VIAJE(viaj_fecha_salida,viaj_fecha_llegada,viaj_fecha_llegada_estimada,viaj_crucero_id,viaj_recorrido_id)
		VALUES(@fechaSalida,@fechaLlegada,@fechaLlegadaEstimada,@cruceroId,@recorridoId)
END


GO
 
  --------- COMPROBACION VENCIMIENTO DE TODAS LAS RESERVAS DEL SISTEMA --------------
 
CREATE PROCEDURE [MACACO_NOT_NULL].ComprobarVigenciaReservasDelSistema
@fecha_sistema DATETIME2(3)
AS
BEGIN 
	DECLARE @loopCounter INT,@maxReservaId INT,@reserva_codigo decimal (18,0),@reserva_fecha DATETIME2(3)
	SELECT @loopCounter = min(rese_id),@maxReservaId = max(rese_id) FROM [MACACO_NOT_NULL].[RESERVA]
	WHILE (@loopCounter IS NOT NULL AND @loopCounter <= @maxReservaId)
	BEGIN
	   SELECT @reserva_codigo = rese_codigo FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_id = @loopCounter 
	   SELECT @reserva_fecha = rese_fecha FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_id = @loopCounter 
	   IF (DATEDIFF(day, @reserva_fecha, @fecha_sistema) > 3) 
	   BEGIN
			DELETE FROM [MACACO_NOT_NULL].[RESERVA_CABINA] WHERE reserva_id = @loopCounter
			DELETE FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @reserva_codigo
	   END
	   SELECT @loopCounter = min(rese_id) FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_id > @loopCounter
	END
END
 
GO
 
 --------- COMPROBACION VENCIMIENTO RESERVA --------------

CREATE PROCEDURE [MACACO_NOT_NULL].ComprobarVigenciaReserva
@codigo_reserva [decimal] (18,0),
@fecha_sistema DATETIME2(3)
AS
BEGIN 
	DECLARE @fecha_reserva DATETIME2(3)
	SET @fecha_reserva = (SELECT rese_fecha from [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	IF (@fecha_reserva IS NULL)
	BEGIN
		RAISERROR ('ERROR: No existe ninguna reserva cuyo codigo sea: %d .',16,1,@codigo_reserva)
	END
	ELSE
	BEGIN
		DECLARE @id_reserva INT
		SET @id_reserva = (SELECT rese_id from [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
		IF (DATEDIFF(day, @fecha_reserva, @fecha_sistema) > 3) 
		BEGIN
			DELETE FROM [MACACO_NOT_NULL].[RESERVA_CABINA] WHERE reserva_id = @id_reserva
			DELETE FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva
		END
	END
END

GO

CREATE PROCEDURE MACACO_NOT_NULL.CabinasDisponiblesViaje
@cantidad int,
@categoria nvarchar(255),
@viaje_id int
AS
BEGIN
	DECLARE @tablaCabinasLibre TABLE(cabina_numero int,cabina_piso int)
	INSERT INTO @tablaCabinasLibre(cabina_numero,cabina_piso)
		SELECT TOP (@cantidad) cabi_nro, cabi_piso 	
		FROM MACACO_NOT_NULL.CABINA 
		INNER JOIN MACACO_NOT_NULL.TIPO_SERVICIO ON tipo_servicio_id = cabi_tipo_servicio_id
		where tipo_servicio_descripcion = @categoria
		and cabi_id NOT IN (SELECT pasa_cab_id from MACACO_NOT_NULL.PASAJE where pasa_viaje_id = @viaje_id)
	IF((SELECT COUNT(cabina_numero) FROM @tablaCabinasLibre) < @cantidad)
	BEGIN
		RAISERROR('ERROR: Cantidad insuficientes de cabinas libres',16,1)	
	END
	ELSE
	BEGIN
		SELECT cabina_numero,cabina_piso FROM @tablaCabinasLibre
	END
END

GO

----------- GENERACION RESERVA ------------
CREATE PROCEDURE [MACACO_NOT_NULL].GenerarReserva
@nombre_usuario  NVARCHAR(255),
@apellido_usuario NVARCHAR(255),
@dni_usuario INT,
@direccion_usuario NVARCHAR(255),
@idViaje INT
--agregar fechaNac telefono y mail y generar el rese_codigo para q no se repita
AS
BEGIN
	INSERT INTO [MACACO_NOT_NULL].RESERVA (rese_usuario_id,rese_codigo,rese_fecha,rese_viaje_id)
	VALUES (
		(SELECT usua_id,(SELECT MAX(rese_id) from [MACACO_NOT_NULL].RESERVA) + 1 ,CONVERT(datetime2(3), GETDATE(),121),@idViaje
		FROM [MACACO_NOT_NULL].USUARIO
		WHERE usua_apellido = @apellido_usuario and usua_nombre = @nombre_usuario and usua_dni = @dni_usuario
		and @direccion_usuario = usua_direccion)
	)

END

GO

--------- PROCEDURE QUE AGREGA 1 CABINA A 1 RESERVA -----------
CREATE PROCEDURE [MACACO_NOT_NULL].AgregarCabina_Reserva
	@cab_id_pasaje int,
	@reserva_id int 
AS
BEGIN
	DECLARE @porcentajeRecargo DECIMAL (18,2)
	SET @porcentajeRecargo = (SELECT tipo_servicio_porc_recargo FROM [MACACO_NOT_NULL].CABINA INNER JOIN TIPO_SERVICIO ON cabi_tipo_servicio_id = tipo_servicio_id)
	INSERT INTO [MACACO_NOT_NULL].RESERVA_CABINA (reserva_id,cabina_id,rese_cabi_costo)
	VALUES (
			@reserva_id,@cab_id_pasaje,
			(
			 SELECT SUM(tram_precio_base)
			 FROM [MACACO_NOT_NULL].TRAMO 
			 INNER JOIN [MACACO_NOT_NULL].RECORRIDO ON reco_id = tram_recorrido_id
			 INNER JOIN [MACACO_NOT_NULL].VIAJE ON reco_id = viaj_recorrido_id
			 WHERE viaj_id = (SELECT rese_viaje_id FROM [MACACO_NOT_NULL].RESERVA WHERE rese_id = @reserva_id)) * @porcentajeRecargo				
			)
END


GO


--------- PROCEDURE QUE AGREGA 1 PASAJE ----------- 
-- SE EJECUTE EN EL CASO QUE SE COMPRE DIRECTAMENTE UN PASAJE, SIN PASAR POR LA RESERVA.
-- 1) SE DEBE AGREGAR PRIMERO UN PAGO AL USUARIO: INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES (@id_usuario) (VER ESTE PUNTO).
-------- EN LA PANTAL DE COMPRA/RESERVA DE VIAJE, AL PEDIR LOS DATOS DEL CLIENTE, CUANDO ESCRIBIS EL DNI, TE TIENE QUE MOSTRAR UNA TABLA , CON LOS USUARIOS QUE TIENEN ESE DNI (EN EL CASO QUE HAYA),
-------- DESPUES SI ELEGIS UNO TE TIENE QUE AUTOCOMPLETAR LOS OTROS CAMPOS, Y VOS LOS PODES MODIFICAR. AL TRAER LOS DATOS DEL CLIENTE ELEGIDO, TRAES EL IDUSUARIO. 
-------- ESE ID ES EL QUE USAS EN EL INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES (@id_usuario)
-------- DESPUES SE HACE UN UPDATE DEL CLIENTE CON LOS DATOS PERSONALES DEL FORMULARIO (YA QUE PUEDE HABER MODIFICADO ALGUN CAMPO)
-------- OSEA EL PUNTO 1) ES TODO POR VISUAL STUDIO (A LO SUMO HACER DESPUES UN PROCEDURE DE MODIFICACION DE UN USUARIO)
-- 2) SE DEBE AGREGAR EL/LOS MEDIO DE PAGO. SE LLAMA AL PROCEDURE AgregarMedioDePago_Al_NuevoPago TANTAS VECES COMO MEDIO DE PAGO INGRESO EL USUARIO (PASANDO LOS PARAMETROS CORRECTOS EN CADA LLAMADA)
-- 3) SE LLAMA A ESTE PROCEDURE TANTAS VECES COMO PASAJES HAYA COMPRADO (LOS PARAMETROS DEL VIAJE Y PAGO SON LOS MISMOS PERO EL IDCABINA CAMBIA)
CREATE PROCEDURE [MACACO_NOT_NULL].AgregarPasajeA_Cliente
	@cab_id_pasaje int,
	@viaje_id_pasaje int
AS
BEGIN
	DECLARE @porcentajeRecargo DECIMAL (18,2)
	SET @porcentajeRecargo = (SELECT tipo_servicio_porc_recargo FROM [MACACO_NOT_NULL].CABINA INNER JOIN TIPO_SERVICIO ON cabi_tipo_servicio_id = tipo_servicio_id)
	INSERT INTO [MACACO_NOT_NULL].PASAJE (pasa_codigo,pasa_precio,pasa_fecha_compra,pasa_cab_id,pasa_viaje_id,pasa_pago_id)
	VALUES 
	(
		 (SELECT MAX(pasa_id) from [MACACO_NOT_NULL].PASAJE) + 1 ,
		 (
			SELECT SUM(tram_precio_base)
			FROM [MACACO_NOT_NULL].TRAMO 
			INNER JOIN [MACACO_NOT_NULL].RECORRIDO ON reco_id = tram_recorrido_id
			INNER JOIN [MACACO_NOT_NULL].VIAJE ON reco_id = viaj_recorrido_id
			WHERE viaj_id = @viaje_id_pasaje
		 ) * @porcentajeRecargo,				
		 CONVERT(datetime2(3), GETDATE(),121),
		 @cab_id_pasaje,@viaje_id_pasaje,(SELECT MAX(pago_id) FROM [MACACO_NOT_NULL].PAGO)
	)
END


GO

------------------------------- PAGO DE RESERVA --------------

-------------- FUNCIONAMIENTO ----------------
---------- 1) AL INGRESAR EL CODIGO DE UNA RESERVA SE DEBE VERIFICAR QUE EXISTA ALGUNA CON ESE NUMERO. LLAMAR A FUNCION ComprobarExistenciaReserva
---------- 2) SE LLAMA A LA FUNCION detallesReserva(codigoReserva) QUE DEVUELVE TODA LA INFORMACION ASOCIADA A LA RESERVA
---------- 3) LUEGO DE INGRESAR TODOS LOS MEDIOS DE PAGO DESEADOS SE LLAMA 1 VEZ AL PROCEDURE AgregarPagoReserva_Y_PasajesAlCliente
---------- 4) LUEGO SE LLAMA AL PROCEDURE AgregarMedioDePago_Al_NuevoPago TANTAS VECES COMO MEDIO DE PAGO INGRESO EL USUARIO (PASANDO LOS PARAMETROS CORRECTOS EN CADA LLAMADA)
---------- 5) LUEGO SE LLAMA AL PROCEDURE EliminarReserva

CREATE FUNCTION [MACACO_NOT_NULL].ComprobarExistenciaReserva(@codigo_reserva [decimal] (18,0))
    RETURNS INT 
AS
BEGIN 
	DECLARE @fecha_reserva DATETIME2(3)
	SET @fecha_reserva = (SELECT rese_fecha from [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	IF (@fecha_reserva IS NULL)
	BEGIN
		RETURN 0
	END
	RETURN 1 
END

GO

CREATE PROCEDURE [MACACO_NOT_NULL].AgregarPagoReserva_Y_PasajesAlCliente
@codigo_reserva DECIMAL(18,0)
AS
BEGIN 
	DECLARE @id_reserva INT, @id_usuario INT
	SET @id_reserva = (SELECT rese_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	SET @id_usuario = (SELECT rese_usuario_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_id = @id_reserva)
	INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES (@id_usuario)
	--ahora migro las filas de la RESERVA a PASAJE 
	INSERT INTO [MACACO_NOT_NULL].PASAJE (pasa_codigo,pasa_precio,pasa_fecha_compra,pasa_cab_id,pasa_viaje_id,pasa_pago_id)
		SELECT 
			(SELECT MAX(pasa_id) from [MACACO_NOT_NULL].PASAJE) + 1,
			rese_cabi_costo,
			CONVERT(datetime2(3), GETDATE(),121),
			cabina_id,
			rese_viaje_id,
			(SELECT MAX(pago_id) from [MACACO_NOT_NULL].PAGO)
		FROM [MACACO_NOT_NULL].[RESERVA] INNER JOIN [MACACO_NOT_NULL].[RESERVA_CABINA] ON rese_id = reserva_id
		where rese_codigo = @codigo_reserva
END

GO

CREATE PROCEDURE [MACACO_NOT_NULL].AgregarMedioDePago_Al_NuevoPago
@medio_Pago NVARCHAR(255),
@cantidad_cuotas INT
AS
BEGIN
	DECLARE @id_pago INT
	SET @id_pago = (SELECT MAX(pago_id) FROM [MACACO_NOT_NULL].[PAGO])
	INSERT INTO [MACACO_NOT_NULL].MEDIO_DE_PAGO (pago_id,medi_descripcion,medi_cantidad_cuotas) 
		VALUES (@id_pago,@medio_Pago,@cantidad_cuotas)

END

GO

CREATE PROCEDURE [MACACO_NOT_NULL].EliminarReserva
@codigo_reserva DECIMAL(18,0)
AS
BEGIN 
	DECLARE @id_reserva INT
	SET @id_reserva = (SELECT rese_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	DELETE FROM [MACACO_NOT_NULL].[RESERVA_CABINA] WHERE reserva_id = @id_reserva
	DELETE FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva
END

GO

------- FUNCION QUE RETORNA TODA LA INFORMACION ASOCIADA A UNA RESERVA --------------

-- Agregar a la consulta la logica para que devuelva el puerto origen y destino del recorrido -------  VER ------

CREATE FUNCTION [MACACO_NOT_NULL].DetallesReserva(@codigo_reserva [decimal] (18,0))
    RETURNS @datosReserva TABLE (		
      rese_codigo [decimal](18,0),
      rese_fecha  [datetime2](3),
	  usua_nombre [nvarchar](255),
	  usua_apellido [nvarchar](255),
	  usua_dni [decimal](18, 0),
	  usua_direccion [nvarchar](255),
	  usua_telefono [int],
	  usua_fecha_nac [datetime2](3),
	  pasa_codigo decimal(18,0),
	  pasa_precio decimal (18,2),
	  viaj_fecha_salida datetime2(3), 
	  viaj_fecha_llegada datetime2(3),
	  viaj_fecha_llegada_estimada datetime2(2), 
	  cabi_nro decimal (18,0),
	  cabi_piso decimal (18,0),
	  tipo_servicio_descripcion nvarchar(255),
	  tipo_servicio_porc_recargo [decimal](18,2),
	  cruc_nombre [nvarchar](255),
	  cruc_modelo [nvarchar](255),
	  comp_nombre [nvarchar](255),
	  reco_codigo [decimal](18, 0),
	  puer_origen [nvarchar](255),
	  puer_destino [nvarchar](255),
	  tram_precio_base [decimal](18,2)
    )
AS
BEGIN
    INSERT INTO @datosReserva
    SELECT 
      rese_codigo ,
      rese_fecha ,
	  usua_nombre,
	  usua_apellido,
	  usua_dni,
	  usua_direccion,
	  usua_telefono ,
	  usua_fecha_nac ,
	  pasa_codigo,
	  pasa_precio,
	  viaj_fecha_salida, 
	  viaj_fecha_llegada,
	  viaj_fecha_llegada_estimada, 
	  cabi_nro,
	  cabi_piso,
	  tipo_servicio_descripcion,
	  tipo_servicio_porc_recargo,
	  cruc_nombre,
	  cruc_modelo,
	  comp_nombre,
	  reco_codigo,
	  P1.puer_nombre,
	  P2.puer_id,
	  tram_precio_base
    FROM [MACACO_NOT_NULL].[RESERVA]
	INNER JOIN [MACACO_NOT_NULL].USUARIO ON usua_id = rese_usuario_id
	INNER JOIN [MACACO_NOT_NULL].PASAJE on rese_id = pasa_reserva_id
	INNER JOIN [MACACO_NOT_NULL].VIAJE on viaj_id = rese_viaje_id
	INNER JOIN [MACACO_NOT_NULL].CRUCERO on viaj_crucero_id = cruc_id
	INNER JOIN [MACACO_NOT_NULL].COMPANIA on comp_id = cruc_compañia_id
	INNER JOIN [MACACO_NOT_NULL].RESERVA_CABINA on rese_id = reserva_id
	INNER JOIN [MACACO_NOT_NULL].CABINA on cabi_id = cabina_id
	INNER JOIN [MACACO_NOT_NULL].TIPO_SERVICIO on cabi_tipo_servicio_id = tipo_servicio_id
	INNER JOIN [MACACO_NOT_NULL].RECORRIDO on reco_id = viaj_recorrido_id
	INNER JOIN [MACACO_NOT_NULL].TRAMO on tram_recorrido_id = reco_id
	INNER JOIN [MACACO_NOT_NULL].PUERTO P1 on tram_puerto_desde = P1.puer_id
	INNER JOIN [MACACO_NOT_NULL].PUERTO P2 on tram_puerto_hasta = P2.puer_id
	WHERE rese_codigo = @codigo_reserva 
 
    RETURN;
END;


GO

 -------------------- REPORTES ---------------------

CREATE PROCEDURE [MACACO_NOT_NULL].[RecorridosConMasPasajesComprados] 
@anio int,
@semestre int
AS
BEGIN
	DECLARE @tablaRecorridos TABLE(pasajes_comprados int,recorrido_id int, recorrido_codigo int);
	insert into @tablaRecorridos (pasajes_comprados,recorrido_id,recorrido_codigo)
		select COUNT(pasa_id),reco_id,reco_codigo
		from [MACACO_NOT_NULL].[PASAJE] 	
		INNER JOIN [MACACO_NOT_NULL].VIAJE ON pasa_viaje_id = viaj_id
		INNER JOIN [MACACO_NOT_NULL].[RECORRIDO] ON reco_id = viaj_recorrido_id
		where pasa_pago_id IS NOT NULL
		and YEAR(viaj_fecha_salida) = @anio
		and @semestre = CASE
				WHEN DATEPART(month,viaj_fecha_salida) <= 6 THEN 1
				WHEN DATEPART(month,viaj_fecha_salida) > 7 THEN 2
			END
		group by reco_id,reco_codigo

	SELECT TOP 5 recorrido_id,recorrido_codigo --atributos
	FROM @tablaRecorridos
	order by pasajes_comprados DESC 
END

GO
  

  
 --select tram_recorrido_id, P1.puer_nombre, P2.puer_nombre, tram_precio_base 
 --from [MACACO_NOT_NULL].[TRAMO]
 --INNER JOIN [MACACO_NOT_NULL].[PUERTO] P1 ON P1.puer_id = tram_puerto_desde
 --INNER JOIN [MACACO_NOT_NULL].[PUERTO] P2 ON P2.puer_id = tram_puerto_hasta
 --order by tram_recorrido_id
  -- Hacer que para mostrar los recorridos en una tabla: 
  -- Mostar en una fila el reco_codigo,ciudad inicio y ciudad destino.
  -- Poner al costado un boton de ver mas detalles, que te lleva a otra ventana en donde te muestra 
  -- 	todos los tramos (con sus atributos) del recorrido que elegiste.
  

CREATE PROCEDURE [MACACO_NOT_NULL].[CrucerosConMasReparaciones] 
@anio int,
@semestre int
AS
BEGIN
  SELECT TOP 5 cruc_modelo,cruc_nombre,comp_nombre 
  FROM [MACACO_NOT_NULL].[CRUCERO]
  INNER JOIN [MACACO_NOT_NULL].[COMPANIA] ON cruc_compañia_id = comp_id
  order by  (
				SELECT SUM(DATEDIFF(day,baja_cruc_fecha_fuera_servicio, baja_cruc_fecha_reinicio_servicio))
				FROM [MACACO_NOT_NULL].[BAJA_CRUCERO] 	
				where baja_cruc_id = cruc_id
				and YEAR(baja_cruc_fecha_fuera_servicio) = @anio
				and @semestre = CASE
						WHEN DATEPART(month,baja_cruc_fecha_fuera_servicio) <= 6 THEN 1
						WHEN DATEPART(month,baja_cruc_fecha_fuera_servicio) > 7 THEN 2
					END
			) DESC 
 END

GO 
 
-- CONVERT(datetime2(3),'1962-09-16 00:00:00.000',121)
  
CREATE PROCEDURE [MACACO_NOT_NULL].[RecorridosConMasCabinasLibresEnSusViajes] 
@anio int,
@semestre int
AS
BEGIN
	DECLARE @tablaPasajes TABLE(cab_ocupados int,viaje_id int);
	insert into @tablaPasajes (cab_ocupados,viaje_id)
		select COUNT(distinct (pasa_cab_id)),pasa_viaje_id
		from [MACACO_NOT_NULL].[PASAJE] 
		INNER JOIN [MACACO_NOT_NULL].VIAJE on viaj_id = pasa_viaje_id
		WHERE YEAR(viaj_fecha_salida) = @anio
		and @semestre = CASE
				WHEN DATEPART(month,viaj_fecha_salida) <= 6 THEN 1
				WHEN DATEPART(month,viaj_fecha_salida) > 7 THEN 2
			END
		group by pasa_viaje_id

	DECLARE @tabla TABLE(cab_libres int,recorrido_id int);
	insert into @tabla (cab_libres,recorrido_id)
		select cruc_cantidad_cabinas - (select cab_ocupados from @tablaPasajes where viaje_id = viaj_id),viaj_recorrido_id
		FROM [MACACO_NOT_NULL].[RECORRIDO] 	
		INNER JOIN [MACACO_NOT_NULL].VIAJE ON reco_id = viaj_recorrido_id
		INNER JOIN [MACACO_NOT_NULL].[CRUCERO] ON cruc_id = viaj_crucero_id	
		
	  SELECT TOP 5 reco_id,reco_codigo --atributos
	  FROM [MACACO_NOT_NULL].[RECORRIDO]
	  order by  (
					SELECT AVG(cab_libres) from @tabla t
					where t.recorrido_id = reco_id
				) DESC 
  
 END
 
GO 
  
 
/*
DROP TABLE [MACACO_NOT_NULL].[TRAMO]
DROP TABLE [MACACO_NOT_NULL].[RESERVA_CABINA]
DROP TABLE [MACACO_NOT_NULL].[RESERVA]
DROP TABLE [MACACO_NOT_NULL].[PASAJE]
DROP TABLE [MACACO_NOT_NULL].[VIAJE]
DROP TABLE [MACACO_NOT_NULL].[RECORRIDO]
DROP TABLE [MACACO_NOT_NULL].[CABINA]
DROP TABLE [MACACO_NOT_NULL].[CRUCERO]
DROP TABLE [MACACO_NOT_NULL].[TIPO_SERVICIO]
DROP TABLE [MACACO_NOT_NULL].[PUERTO]
DROP TABLE [MACACO_NOT_NULL].[MEDIO_DE_PAGO]
DROP TABLE [MACACO_NOT_NULL].[PAGO]
DROP TABLE [MACACO_NOT_NULL].[COMPANIA]
DROP TABLE [MACACO_NOT_NULL].[ROL_FUNCIONALIDAD]
DROP TABLE [MACACO_NOT_NULL].[FUNCIONALIDAD]
DROP TABLE [MACACO_NOT_NULL].[LOGIN]
DROP TABLE [MACACO_NOT_NULL].[USUARIO]
DROP TABLE [MACACO_NOT_NULL].[ROL]

DROP SEQUENCE [MACACO_NOT_NULL].CountBy1 

DROP SCHEMA MACACO_NOT_NULL */
