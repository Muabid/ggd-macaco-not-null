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
	rol_activo [bit] NOT NULL
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
	rese_fecha datetime2 (3) NOT NULL
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
	pasa_reserva_id int FOREIGN KEY REFERENCES [MACACO_NOT_NULL].[RESERVA](rese_id),
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
			BEGIN TRANSACTION
				INSERT INTO [MACACO_NOT_NULL].ROL(rol_nombre,rol_activo)	
				VALUES(@nombre_rol,@activo)
			COMMIT TRANSACTION
		END
	ELSE
		BEGIN
			RAISERROR('ERROR: El rol ingresado ya existe',16,1)
		END
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
 
 
------------------------- LOGIN Y SEGURIDAD ------------

---------------- FUNCION ENCRIPTACION PASSWORD ------------------------------------
CREATE FUNCTION [MACACO_NOT_NULL].EncriptarPassword(@password NVARCHAR(255))
RETURNS nvarchar(255)
AS
BEGIN
	RETURN CONVERT(nvarchar(255),HASHBYTES('SHA2_256',@password),1)
END

GO
 
CREATE PROCEDURE [MACACO_NOT_NULL].LoguearUsuario 
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
  
 ---------------------- ABM DE CRUCERO -------------
  
  
 GO
-------------------- AGREGAR BAJA A CRUCERO ------------
-------- EN LA PANTALLA DE DAR DE BAJA A UN CRUCERO, AGREGAR UN COMBOBOX AL FINAL EN DONDE EL ADMIN TENGA A ELEGIR LO QUE SE DEBE HACER CON LOS PASAJES VENDIDOS DE TODOS LOS VIAJES QUE REALIZABA EL CRUCERO ---
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

 -------------------------------- REEMPLAZAR CRUCERO POR OTRO ---------------------------
----------- SE EJECUTAR LUEGO DE AGREGAR UNA BAJA A UN CRUCERO (SIEMPRE Y CUANDO LA ACCION POSTERIOR ELEGIDA POR EL ADMIN ERA REEMPLAZAR EL CRUCERO POR OTRO QUE PUEDA CUMPLIR TODOS LOS VIAJES) ------------

 
  
  
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
			DELETE FROM [MACACO_NOT_NULL].[PASAJE] WHERE pasa_reserva_id = @loopCounter
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
			DELETE FROM [MACACO_NOT_NULL].[PASAJE] WHERE pasa_reserva_id = @id_reserva
			DELETE FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva
		END
	END
END

GO

----------- GENERACION RESERVA ------------
CREATE PROCEDURE [MACACO_NOT_NULL].GenerarReserva
@nombre_usuario  NVARCHAR(255) ,
@apellido_usuario NVARCHAR(255),
@dni_usuario INT,
@direccion_usuario NVARCHAR(255)
--agregar fechaNac telefono y mail y generar el rese_codigo para q no se repita
AS
BEGIN
	INSERT INTO [MACACO_NOT_NULL].RESERVA (rese_usuario_id,rese_codigo,rese_fecha)
	VALUES (
		(SELECT usua_id,(SELECT MAX(rese_id) from [MACACO_NOT_NULL].RESERVA) + 1 ,CONVERT(datetime2(3), GETDATE(),121)
		FROM [MACACO_NOT_NULL].USUARIO
		WHERE usua_apellido = @apellido_usuario and usua_nombre = @nombre_usuario and usua_dni = @dni_usuario
		and @direccion_usuario = usua_direccion)
	)

END


GO

--------- PROCEDURE QUE AGREGA 1 PASAJE -----------
CREATE PROCEDURE [MACACO_NOT_NULL].AgregarPasaje
	@precio_pasaje decimal (18,2),
	@cab_id_pasaje int,
	@viaje_id_pasaje int,
	@pasa_reserva_id int = NULL, -- si es una reserva el valor = SELECT MAX(rese_id) from [MACACO_NOT_NULL].RESERVA ; si es directamente una comprar = null
	@pasa_pago_id int = NULL -- si es una reserva el valor = NULL, si es una compra directa el valor = pago ; Se debe llamar a este procedure luego de agregar un Pago al usuario ejecutando: INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES (@id_usuario)
AS
BEGIN
	INSERT INTO [MACACO_NOT_NULL].PASAJE (pasa_codigo,pasa_precio,pasa_fecha_compra,pasa_cab_id,pasa_viaje_id,pasa_reserva_id,pasa_pago_id)
	VALUES (
		 (SELECT MAX(pasa_id) from [MACACO_NOT_NULL].PASAJE) + 1 ,@precio_pasaje,CONVERT(datetime2(3), GETDATE(),121),
		 @cab_id_pasaje,@viaje_id_pasaje,@pasa_reserva_id,@pasa_pago_id)
END


GO

------------------------------- PAGO DE RESERVA --------------

-------------- FUNCIONAMIENTO ----------------
---------- 1) AL INGRESAR EL CODIGO DE UNA RESERVA SE DEBE VERIFICAR QUE EXISTA ALGUNA CON ESE NUMERO. LLAMAR A FUNCION ComprobarExistenciaReserva
---------- 2) SE LLAMA A LA FUNCION detallesReserva(codigoReserva) QUE DEVUELVE TODA LA INFORMACION ASOCIADA A LA RESERVA
---------- 3) LUEGO DE INGRESAR TODOS LOS MEDIOS DE PAGO DESEADOS SE LLAMA 1 VEZ AL PROCEDURE AgregarPago_A_Reserva
---------- 4) LUEGO SE LLAMA AL PROCEDURE AgregarMedioDePago_Al_PagoDeLaReserva TANTAS VECES COMO MEDIO DE PAGO INGRESO EL USUARIO (PASANDO LOS PARAMETROS CORRECTOS EN CADA LLAMADA)
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

CREATE PROCEDURE [MACACO_NOT_NULL].AgregarPago_A_Reserva
@codigo_reserva DECIMAL(18,0)
AS
BEGIN 
	DECLARE @id_reserva INT, @id_usuario INT
	SET @id_reserva = (SELECT rese_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	SET @id_usuario = (SELECT rese_usuario_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_id = @id_reserva)
	INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES (@id_usuario)
	UPDATE [MACACO_NOT_NULL].[PASAJE] SET pasa_pago_id = (SELECT TOP 1 pago_id FROM [MACACO_NOT_NULL].[PAGO] ORDER BY pago_id DESC)
		WHERE pasa_reserva_id = @id_reserva
END

GO

CREATE PROCEDURE [MACACO_NOT_NULL].AgregarMedioDePago_Al_PagoDeLaReserva
@codigo_reserva DECIMAL(18,0),
@medio_Pago NVARCHAR(255),
@cantidad_cuotas INT
AS
BEGIN
	DECLARE @id_pago INT, @id_reserva INT
	SET @id_reserva = (SELECT rese_id FROM [MACACO_NOT_NULL].[RESERVA] WHERE rese_codigo = @codigo_reserva)
	SET @id_pago = (SELECT pago_id FROM [MACACO_NOT_NULL].[PAGO] INNER JOIN [MACACO_NOT_NULL].[PASAJE] ON pago_id = pasa_pago_id
					 WHERE pasa_reserva_id = @id_reserva)
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
	UPDATE [MACACO_NOT_NULL].PASAJE SET pasa_fecha_compra = CONVERT(datetime2(3), GETDATE(),121) WHERE pasa_reserva_id = @id_reserva 
	UPDATE [MACACO_NOT_NULL].PASAJE SET pasa_reserva_id = NULL WHERE pasa_reserva_id = @id_reserva 
	DELETE FROM [MACACO_NOT_NULL].RESERVA WHERE rese_id = @id_reserva 
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
	INNER JOIN [MACACO_NOT_NULL].VIAJE on viaj_id = pasa_viaje_id
	INNER JOIN [MACACO_NOT_NULL].CRUCERO on viaj_crucero_id = cruc_id
	INNER JOIN [MACACO_NOT_NULL].COMPANIA on comp_id = cruc_compañia_id
	INNER JOIN [MACACO_NOT_NULL].CABINA on cabi_id = pasa_cab_id
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

CREATE PROCEDURE [MACACO_NOT_NULL].RecorridosConMasPasajesComprados 
AS
BEGIN
	DECLARE @tablaRecorridos TABLE(pasajes_comprados int,recorrido_id int, recorrido_codigo int);
	insert into @tablaRecorridos (pasajes_comprados,recorrido_id,recorrido_codigo)
		select COUNT(pasa_id),reco_id,reco_codigo
		from [MACACO_NOT_NULL].[PASAJE] 	
		INNER JOIN [MACACO_NOT_NULL].VIAJE ON pasa_viaje_id = viaj_id
		INNER JOIN [MACACO_NOT_NULL].[RECORRIDO] ON reco_id = viaj_recorrido_id
		where pasa_pago_id IS NOT NULL
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
  

CREATE PROCEDURE [MACACO_NOT_NULL].CrucerosConMasReparaciones 
AS
BEGIN
  SELECT TOP 5 cruc_modelo,cruc_nombre,comp_nombre 
  FROM [MACACO_NOT_NULL].[CRUCERO]
  INNER JOIN [MACACO_NOT_NULL].[COMPANIA] ON cruc_compañia_id = comp_id
  order by  (
				SELECT SUM(DATEDIFF(day,baja_cruc_fecha_fuera_servicio, baja_cruc_fecha_reinicio_servicio))
				FROM [MACACO_NOT_NULL].[BAJA_CRUCERO] 	
				where baja_cruc_id = cruc_id
			) DESC 
 END
GO 
 
-- CONVERT(datetime2(3),'1962-09-16 00:00:00.000',121)
  
CREATE PROCEDURE [MACACO_NOT_NULL].RecorridosConMasCabinasLibresEnSusViajes 
AS
BEGIN
	DECLARE @tablaPasajes TABLE(cab_ocupados int,viaje_id int);
	insert into @tablaPasajes (cab_ocupados,viaje_id)
		select COUNT(distinct (pasa_cab_id)),pasa_viaje_id
		from [MACACO_NOT_NULL].[PASAJE] 
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
  
 
/* DROP TABLE [MACACO_NOT_NULL].[TRAMO]
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

DROP SCHEMA MACACO_NOT_NULL */




