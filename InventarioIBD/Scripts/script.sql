USE [base_ibd]
GO
/****** Object:  Table [dbo].[BODEGA]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BODEGA](
	[id_bodega] [varchar](15) NOT NULL,
	[nombre_bodega] [varchar](256) NULL,
	[estado] [varchar](20) NULL,
	[id_usuario] [varchar](20) NULL,
	[fecha_creacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXISTENCIA]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXISTENCIA](
	[id_item] [varchar](20) NOT NULL,
	[cantidad] [int] NULL,
	[last_update] [datetime] NULL,
	[costo_prom] [decimal](13, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INV_TRANSACTION_DET]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INV_TRANSACTION_DET](
	[id_detalle_trx] [varchar](20) NOT NULL,
	[id_trx] [varchar](20) NULL,
	[id_item] [varchar](20) NULL,
	[cantidad] [int] NULL,
	[costo_real] [decimal](13, 2) NULL,
	[costo_promedio] [decimal](13, 2) NULL,
	[precio_venta] [decimal](13, 2) NULL,
	[fecha_expiracion] [datetime] NULL,
	[estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_trx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INV_TRANSACTION_HEAD]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INV_TRANSACTION_HEAD](
	[id_trx] [varchar](20) NOT NULL,
	[fecha_tran] [datetime] NULL,
	[id_bodega] [varchar](20) NULL,
	[id_usuario] [varchar](20) NULL,
	[tipo_transaccion] [varchar](20) NULL,
	[estado] [varchar](20) NULL,
	[id_proveedor] [varchar](20) NULL,
	[tipo_doc_origen] [varchar](20) NULL,
	[numero_doc_origen] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_trx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMS](
	[id_item] [varchar](20) NOT NULL,
	[nombre] [datetime] NULL,
	[id_tipo] [varchar](20) NULL,
	[id_unidad_medida] [varchar](20) NULL,
	[fecha_creacion] [datetime] NULL,
	[id_usuario] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_ITEMS]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_ITEMS](
	[id_tipo] [varchar](20) NOT NULL,
	[descripcion] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_TRANSACCION]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_TRANSACCION](
	[tipo_transaccion] [varchar](20) NOT NULL,
	[nombre_transaccion] [varchar](20) NULL,
	[id_usuario] [varchar](20) NULL,
	[in_out] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNIDAD_MEDIDA]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDAD_MEDIDA](
	[id_unidad_medida] [varchar](20) NOT NULL,
	[unidad_medida] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_unidad_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[id_usuario] [varchar](20) NOT NULL,
	[nombre] [varchar](256) NULL,
	[fecha_creacion] [datetime] NULL,
	[estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ('Activo') FOR [estado]
GO
/****** Object:  StoredProcedure [dbo].[GestionarBodegas]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GestionarBodegas]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_bodega varchar(15),
    @nombre_bodega varchar(256),
    @estado varchar(20),
    @id_usuario varchar(20),
    @fecha_creacion datetime
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO BODEGA (id_bodega, nombre_bodega, estado, id_usuario, fecha_creacion)
        VALUES (@id_bodega, @nombre_bodega, @estado, @id_usuario, @fecha_creacion);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE BODEGA
        SET nombre_bodega = @nombre_bodega, estado = @estado, id_usuario = @id_usuario, fecha_creacion = @fecha_creacion
        WHERE id_bodega = @id_bodega;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM BODEGA
        WHERE id_bodega = @id_bodega;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM BODEGA;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarExistencias]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GestionarExistencias]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_item varchar(20),
    @cantidad integer,
    @last_update datetime,
    @costo_prom decimal(13, 2)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO EXISTENCIA (id_item, cantidad, last_update, costo_prom)
        VALUES (@id_item, @cantidad, @last_update, @costo_prom);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE EXISTENCIA
        SET cantidad = @cantidad, last_update = @last_update, costo_prom = @costo_prom
        WHERE id_item = @id_item;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM EXISTENCIA
        WHERE id_item = @id_item;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM EXISTENCIA;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarItems]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GestionarItems]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_item varchar(20),
    @nombre datetime,
    @id_tipo varchar(20),
    @id_unidad_medida varchar(20),
    @fecha_creacion datetime,
    @id_usuario varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO ITEMS (id_item, nombre, id_tipo, id_unidad_medida, fecha_creacion, id_usuario)
        VALUES (@id_item, @nombre, @id_tipo, @id_unidad_medida, @fecha_creacion, @id_usuario);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE ITEMS
        SET nombre = @nombre, id_tipo = @id_tipo, id_unidad_medida = @id_unidad_medida, fecha_creacion = @fecha_creacion, id_usuario = @id_usuario
        WHERE id_item = @id_item;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM ITEMS
        WHERE id_item = @id_item;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM ITEMS;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarTipoItems]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GestionarTipoItems]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_tipo varchar(20),
    @descripcion varchar(256)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO TIPO_ITEMS (id_tipo, descripcion)
        VALUES (@id_tipo, @descripcion);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE TIPO_ITEMS
        SET descripcion = @descripcion
        WHERE id_tipo = @id_tipo;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM TIPO_ITEMS
        WHERE id_tipo = @id_tipo;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM TIPO_ITEMS;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarTipoTransaccion]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GestionarTipoTransaccion]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @tipo_transaccion varchar(20),
    @nombre_transaccion varchar(20),
    @id_usuario varchar(20),
    @in_out varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO TIPO_TRANSACCION (tipo_transaccion, nombre_transaccion, id_usuario, in_out)
        VALUES (@tipo_transaccion, @nombre_transaccion, @id_usuario, @in_out);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE TIPO_TRANSACCION
        SET nombre_transaccion = @nombre_transaccion, id_usuario = @id_usuario, in_out = @in_out
        WHERE tipo_transaccion = @tipo_transaccion;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM TIPO_TRANSACCION
        WHERE tipo_transaccion = @tipo_transaccion;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM TIPO_TRANSACCION;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarTransaccionDetalle]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GestionarTransaccionDetalle]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_detalle_trx varchar(20),
    @id_trx varchar(20),
    @id_item varchar(20),
    @cantidad integer,
    @costo_real decimal(13, 2),
    @costo_promedio decimal(13, 2),
    @precio_venta decimal(13, 2),
    @fecha_expiracion datetime,
    @estado varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO INV_TRANSACTION_DET (id_detalle_trx, id_trx, id_item, cantidad, costo_real, costo_promedio, precio_venta, fecha_expiracion, estado)
        VALUES (@id_detalle_trx, @id_trx, @id_item, @cantidad, @costo_real, @costo_promedio, @precio_venta, @fecha_expiracion, @estado);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE INV_TRANSACTION_DET
        SET id_trx = @id_trx, id_item = @id_item, cantidad = @cantidad, costo_real = @costo_real, costo_promedio = @costo_promedio, precio_venta = @precio_venta, fecha_expiracion = @fecha_expiracion, estado = @estado
        WHERE id_detalle_trx = @id_detalle_trx;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM INV_TRANSACTION_DET
        WHERE id_detalle_trx = @id_detalle_trx;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM INV_TRANSACTION_DET;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarTransacciones]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GestionarTransacciones]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_trx varchar(20),
    @fecha_tran datetime,
    @id_bodega varchar(20),
    @id_usuario varchar(20),
    @tipo_transaccion varchar(20),
    @estado varchar(20),
    @id_proveedor varchar(20),
    @tipo_doc_origen varchar(20),
    @numero_doc_origen varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO INV_TRANSACTION_HEAD (id_trx, fecha_tran, id_bodega, id_usuario, tipo_transaccion, estado, id_proveedor, tipo_doc_origen, numero_doc_origen)
        VALUES (@id_trx, @fecha_tran, @id_bodega, @id_usuario, @tipo_transaccion, @estado, @id_proveedor, @tipo_doc_origen, @numero_doc_origen);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE INV_TRANSACTION_HEAD
        SET fecha_tran = @fecha_tran, id_bodega = @id_bodega, id_usuario = @id_usuario, tipo_transaccion = @tipo_transaccion, estado = @estado, 
            id_proveedor = @id_proveedor, tipo_doc_origen = @tipo_doc_origen, numero_doc_origen = @numero_doc_origen
        WHERE id_trx = @id_trx;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM INV_TRANSACTION_HEAD
        WHERE id_trx = @id_trx;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM INV_TRANSACTION_HEAD;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarUnidadesMedida]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GestionarUnidadesMedida]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_unidad_medida varchar(20),
    @unidad_medida varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO UNIDAD_MEDIDA (id_unidad_medida, unidad_medida)
        VALUES (@id_unidad_medida, @unidad_medida);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE UNIDAD_MEDIDA
        SET unidad_medida = @unidad_medida
        WHERE id_unidad_medida = @id_unidad_medida;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM UNIDAD_MEDIDA
        WHERE id_unidad_medida = @id_unidad_medida;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM UNIDAD_MEDIDA;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GestionarUsuarios]    Script Date: 2/11/2023 16:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GestionarUsuarios]
    @opcion char(1), -- I=Insert, U=Update, D=Delete, S=Select
    @id_usuario varchar(20),
    @nombre varchar(256),
    @fecha_creacion datetime,
    @estado varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF @opcion = 'I'
    BEGIN
        INSERT INTO USUARIO (id_usuario, nombre, fecha_creacion, estado)
        VALUES (@id_usuario, @nombre, @fecha_creacion, @estado);
    END
    ELSE IF @opcion = 'U'
    BEGIN
        UPDATE USUARIO
        SET nombre = @nombre, fecha_creacion = @fecha_creacion, estado = @estado
        WHERE id_usuario = @id_usuario;
    END
    ELSE IF @opcion = 'D'
    BEGIN
        DELETE FROM USUARIO
        WHERE id_usuario = @id_usuario;
    END
    ELSE IF @opcion = 'S'
    BEGIN
        SELECT * FROM USUARIO;
    END
END;
GO
