USE [GD1C2019]

GO

IF NOT EXISTS (SELECT * FROM SYS.SCHEMAS WHERE name = 'MACACO_NOT_NULL')
BEGIN
EXEC ('CREATE SCHEMA [MACACO_NOT_NULL] AUTHORIZATION [gdCruceros2019]')
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
	AND TABLE_NAME = 'ROL'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[ROL] (
	rol_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	rol_nombre [nvarchar](255) NOT NULL,
	rol_activo [bit] NOT NULL
);
END
GO


IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
	AND TABLE_NAME = 'RESERVA'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE [MACACO_NOT_NULL].[RESERVA] (
	rese_id  int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	rese_usuario_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[USUARIO] (usua_id),
	rese_codigo decimal (18,0) NOT NULL,
	rese_fecha datetime2 (3) NOT NULL
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
	AND TABLE_NAME = 'CRUCERO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
CREATE TABLE  [MACACO_NOT_NULL].[CRUCERO] (
	cruc_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	cruc_compañia_id  int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[COMPANIA] (comp_id), 
	cruc_nombre [nvarchar](255),
	cruc_modelo  [nvarchar](50),
	cruc_fuera_de_servicio [bit],
	cruc_fecha_fuera_servicio [datetime2](3),
	cruc_fecha_alta [datetime2](3),
	cruc_fecha_baja_definitiva [datetime2](3),
	cruc_fecha_reinicio_servicio [datetime2](3),
	cruc_baja_por_vida_util [bit],
	cruc_cantidad_cabinas [int]
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
	AND TABLE_NAME = 'RECORRIDO'
	AND TABLE_SCHEMA = 'MACACO_NOT_NULL'
)
BEGIN
 CREATE TABLE [MACACO_NOT_NULL].[RECORRIDO] (
	reco_id int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	reco_codigo decimal (18,0) NOT NULL,
	reco_activo bit 
 );
 END
 GO

 IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	pasa_reserva_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[RESERVA](rese_id),
	pasa_pago_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[PAGO] (pago_id)
);
END
GO

IF NOT EXISTS (
	SELECT 1
	FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_TYPE = 'BASE_TABLE'
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
	VALUES ('JUAN','Perez',40545987,'Gestion123',78543625,'gdd@gmail.com',CONVERT(datetime2,'1988-08-28 00:00:00.000',121),1,1),
		   ('JOSE','Gonzalez',40987234,'Medrano 876',45237825,'almagro@gmail.com',CONVERT(datetime2,'1998-04-22 00:00:00.000',121),1,1),
		   ('ANDRES','Montana',61248982,'Avenida Cordoba 8568',48916685,'montana@gmail.com',CONVERT(datetime2,'1964-11-18 00:00:00.000',121),1,1),
		   ('MICAELA','MOZART',37918442,'Avenida Corrientes 6732',42359645,'sinfonia@gmail.com',CONVERT(datetime2,'1976-12-24 00:00:00.000',121),1,1),
		   ('ROCIO','TESORO',15948315,'Avenida Callao 458',46549821,'rtesoro@gmail.com',CONVERT(datetime2,'1982-04-06 00:00:00.000',121),1,1);
	
INSERT INTO [MACACO_NOT_NULL].LOGIN (logi_username,logi_password,logi_usuario_id,logi_intento_fallido)	
	VALUES ('rtesoro','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 15948315 and usua_direccion = 'Avenida Callao 458'),0),
		   ('mMozart','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 37918442 and usua_direccion = 'Avenida Corrientes 6732'),0),
	       ('aMontana','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 61248982 and usua_direccion = 'Avenida Cordoba 8568'),0),
	       ('jGonzalez','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 40987234 and usua_direccion = 'Medrano 876'),0),
		   ('jPerez','w23e',(select usua_id FROM [MACACO_NOT_NULL].[USUARIO] where usua_dni = 40545987 and usua_direccion = 'Gestion123'),0);
		  
INSERT INTO [MACACO_NOT_NULL].COMPANIA (comp_nombre)
	select distinct CRU_FABRICANTE FROM [GD1C2019].[gd_esquema].[Maestra];


INSERT INTO [MACACO_NOT_NULL].TIPO_SERVICIO (tipo_servicio_descripcion,tipo_servicio_porc_recargo)
		select distinct CABINA_TIPO,CABINA_TIPO_PORC_RECARGO FROM [GD1C2019].[gd_esquema].[Maestra];

INSERT INTO [MACACO_NOT_NULL].PUERTO (puer_nombre)
		select distinct PUERTO_DESDE FROM [GD1C2019].[gd_esquema].[Maestra];


 INSERT INTO [MACACO_NOT_NULL].CRUCERO(
											cruc_nombre,
											cruc_modelo ,
											cruc_compañia_id																														
										)
	select distinct CRUCERO_IDENTIFICADOR,CRUCERO_MODELO,
		(	
			 select comp_id
			 from [MACACO_NOT_NULL].COMPANIA 
			 where comp_nombre = CRU_FABRICANTE
		)
		FROM [GD1C2019].[gd_esquema].[Maestra];

--PREGUNTAR QUE HACER CON CANTIDAD DE CABINAS DE LOS CRUCEROS DE LA TABLA MAESTRA

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
   
   
INSERT INTO [MACACO_NOT_NULL].RESERVA(
											rese_codigo,
											rese_fecha ,
											rese_usuario_id																																									
									 )
	select distinct RESERVA_CODIGO,RESERVA_FECHA,
	(	
			 select usua_id
			 from [MACACO_NOT_NULL].USUARIO 
			 where CLI_DNI = usua_dni 
					and CLI_DIRECCION = usua_direccion
	) 
   FROM [GD1C2019].[gd_esquema].[Maestra]
   where RESERVA_CODIGO is not null 
	and RESERVA_FECHA is not null;


  INSERT INTO [MACACO_NOT_NULL].RECORRIDO(
											[reco_codigo],
											[reco_activo] 																																								
										)
	select distinct RECORRIDO_CODIGO,1
   FROM [GD1C2019].[gd_esquema].[Maestra];

   
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
  

/*
DROP TABLE [MACACO_NOT_NULL].[TRAMO]
DROP TABLE [MACACO_NOT_NULL].[PASAJE]
DROP TABLE [MACACO_NOT_NULL].[VIAJE]
DROP TABLE [MACACO_NOT_NULL].[RECORRIDO]
DROP TABLE [MACACO_NOT_NULL].[CABINA]
DROP TABLE [MACACO_NOT_NULL].[CRUCERO]
DROP TABLE [MACACO_NOT_NULL].[TIPO_SERVICIO]
DROP TABLE [MACACO_NOT_NULL].[PUERTO]
DROP TABLE [MACACO_NOT_NULL].[MEDIO_DE_PAGO]
DROP TABLE [MACACO_NOT_NULL].[PAGO]
DROP TABLE [MACACO_NOT_NULL].[RESERVA]
DROP TABLE [MACACO_NOT_NULL].[COMPANIA]
DROP TABLE [MACACO_NOT_NULL].[ROL_FUNCIONALIDAD]
DROP TABLE [MACACO_NOT_NULL].[FUNCIONALIDAD]
DROP TABLE [MACACO_NOT_NULL].[LOGIN]
DROP TABLE [MACACO_NOT_NULL].[USUARIO]
DROP TABLE [MACACO_NOT_NULL].[ROL]

DROP SEQUENCE [MACACO_NOT_NULL].CountBy1 

DROP SCHEMA MACACO_NOT_NULL
*/
