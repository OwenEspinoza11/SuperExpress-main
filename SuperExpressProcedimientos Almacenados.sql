--PROCEDIMIENTOS ALMACENADOS
-- Agregar Proveedor

use SuperExpress2


CREATE PROCEDURE AgregarProveedor (
    @Nombre VARCHAR(50),
    @Direccion VARCHAR(100),
    @Telefono VARCHAR(15)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE LTRIM(RTRIM(@Nombre)) = '' 
	OR LTRIM(RTRIM(@Direccion)) = '' OR LTRIM(RTRIM(@Telefono)) = '')
    BEGIN
        INSERT INTO Proveedores (Nombre, Direccion, Telefono, FechaRegistro)
        VALUES (LTRIM(RTRIM(@Nombre)), LTRIM(RTRIM(@Direccion)), LTRIM(RTRIM(@Telefono)), GETDATE());
    END;
END;

-- Editar Proveedor
CREATE PROCEDURE EditarProveedor (
    @ID_Proveedor INT,
    @Nombre VARCHAR(50),
    @Direccion VARCHAR(100),
    @Telefono VARCHAR(15)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE LTRIM(RTRIM(@Nombre)) = '' 
	OR LTRIM(RTRIM(@Direccion)) = '' OR LTRIM(RTRIM(@Telefono)) = '')
    BEGIN
        UPDATE Proveedores
        SET Nombre = LTRIM(RTRIM(@Nombre)), Direccion = LTRIM(RTRIM(@Direccion)), Telefono = LTRIM(RTRIM(@Telefono))
        WHERE ID_Proveedor = @ID_Proveedor;
    END;
END;

-- Eliminar Proveedor
CREATE PROCEDURE EliminarProveedor (
    @ID_Proveedor INT
)
AS
BEGIN
    DELETE FROM Proveedores
    WHERE ID_Proveedor = @ID_Proveedor;
END;



-- Agregar Producto
CREATE PROCEDURE AgregarProducto (
    @Nombre VARCHAR(50),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @ID_Proveedor INT,
    @Categoria VARCHAR(50),
    @FechaLote DATE,
    @FechaExpiracion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Productos WHERE LTRIM(RTRIM(@Nombre)) = '' OR LTRIM(RTRIM(@Categoria)) = '')
    BEGIN
        INSERT INTO Productos (Nombre, Precio, Stock, ID_Proveedor, Categoria, FechaLote, FechaExpiracion, FechaRegistro)
        VALUES (LTRIM(RTRIM(@Nombre)), @Precio, @Stock, @ID_Proveedor, LTRIM(RTRIM(@Categoria)), @FechaLote, @FechaExpiracion, GETDATE());
    END;
END;

-- Editar Producto
CREATE PROCEDURE EditarProducto (
    @ID_Producto INT,
    @Nombre VARCHAR(50),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @ID_Proveedor INT,
    @Categoria VARCHAR(50),
    @FechaLote DATE,
    @FechaExpiracion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Productos WHERE LTRIM(RTRIM(@Nombre)) = '' OR LTRIM(RTRIM(@Categoria)) = '')
    BEGIN
        UPDATE Productos
        SET Nombre = LTRIM(RTRIM(@Nombre)), Precio = @Precio, Stock = @Stock, ID_Proveedor = @ID_Proveedor,
            Categoria = LTRIM(RTRIM(@Categoria)), FechaLote = @FechaLote, FechaExpiracion = @FechaExpiracion
        WHERE ID_Producto = @ID_Producto;
    END;
END;

-- Eliminar Producto
CREATE PROCEDURE EliminarProducto (
    @ID_Producto INT
)
AS
BEGIN
    DELETE FROM Productos
    WHERE ID_Producto = @ID_Producto;
END;



-- Agregar Cliente
CREATE PROCEDURE AgregarCliente (
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Telefono VARCHAR(15)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE LTRIM(RTRIM(@Nombre)) = '' OR LTRIM(RTRIM(@Apellido)) = '' OR LTRIM(RTRIM(@CorreoElectronico)) = '' OR LTRIM(RTRIM(@Telefono)) = '')
    BEGIN
        INSERT INTO Clientes (Nombre, Apellido, CorreoElectronico, Telefono, FechaRegistro)
        VALUES (LTRIM(RTRIM(@Nombre)), LTRIM(RTRIM(@Apellido)), LTRIM(RTRIM(@CorreoElectronico)), LTRIM(RTRIM(@Telefono)), GETDATE());
    END;
END;

-- Editar Cliente
CREATE PROCEDURE EditarCliente (
    @ID_Cliente INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Telefono VARCHAR(15)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE LTRIM(RTRIM(@Nombre)) = '' OR LTRIM(RTRIM(@Apellido)) = '' OR LTRIM(RTRIM(@CorreoElectronico)) = '' OR LTRIM(RTRIM(@Telefono)) = '')
    BEGIN
        UPDATE Clientes
        SET Nombre = LTRIM(RTRIM(@Nombre)), Apellido = LTRIM(RTRIM(@Apellido)), CorreoElectronico = LTRIM(RTRIM(@CorreoElectronico)), Telefono = LTRIM(RTRIM(@Telefono))
        WHERE ID_Cliente = @ID_Cliente;
    END;
END;

-- Eliminar Cliente
CREATE PROCEDURE EliminarCliente (
    @ID_Cliente INT
)
AS
BEGIN
    DELETE FROM Clientes
    WHERE ID_Cliente = @ID_Cliente;
END;


-- Agregar Venta
CREATE PROCEDURE AgregarVenta (
    @ID_Cliente INT,
    @FechaVenta DATE,
    @Total DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Ventas WHERE @ID_Cliente IS NULL OR @FechaVenta IS NULL OR @Total IS NULL)
    BEGIN
        INSERT INTO Ventas (ID_Cliente, FechaVenta, Total, FechaRegistro)
        VALUES (@ID_Cliente, @FechaVenta, @Total, GETDATE());
    END;
END;

-- Editar Venta
CREATE PROCEDURE EditarVenta (
    @ID_Venta INT,
    @ID_Cliente INT,
    @FechaVenta DATE,
    @Total DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Ventas WHERE @ID_Cliente IS NULL OR @FechaVenta IS NULL OR @Total IS NULL)
    BEGIN
        UPDATE Ventas
        SET ID_Cliente = @ID_Cliente, FechaVenta = @FechaVenta, Total = @Total
        WHERE ID_Venta = @ID_Venta;
    END;
END;

-- Eliminar Venta
CREATE PROCEDURE EliminarVenta (
    @ID_Venta INT
)
AS
BEGIN
    DELETE FROM Ventas
    WHERE ID_Venta = @ID_Venta;
END;


-- Agregar Detalle de Venta
CREATE PROCEDURE AgregarDetalleVenta (
    @ID_Venta INT,
    @ID_Producto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2),
    @Subtotal DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DetallesVentas WHERE @ID_Venta IS NULL OR @ID_Producto IS NULL OR @Cantidad IS NULL OR @PrecioUnitario IS NULL OR @Subtotal IS NULL)
    BEGIN
        INSERT INTO DetallesVentas (ID_Venta, ID_Producto, Cantidad, PrecioUnitario, Subtotal, FechaRegistro)
        VALUES (@ID_Venta, @ID_Producto, @Cantidad, @PrecioUnitario, @Subtotal, GETDATE());
    END;
END;

-- Editar Detalle de Venta
CREATE PROCEDURE EditarDetalleVenta (
    @ID_DetalleVenta INT,
    @ID_Venta INT,
    @ID_Producto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2),
    @Subtotal DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DetallesVentas WHERE @ID_Venta IS NULL OR @ID_Producto IS NULL OR @Cantidad IS NULL OR @PrecioUnitario IS NULL OR @Subtotal IS NULL)
    BEGIN
        UPDATE DetallesVentas
        SET ID_Venta = @ID_Venta, ID_Producto = @ID_Producto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Subtotal = @Subtotal
        WHERE ID_DetalleVenta = @ID_DetalleVenta;
    END;
END;

-- Eliminar Detalle de Venta
CREATE PROCEDURE EliminarDetalleVenta (
    @ID_DetalleVenta INT
)
AS
BEGIN
    DELETE FROM DetallesVentas
    WHERE ID_DetalleVenta = @ID_DetalleVenta;
END;


-- Agregar Compra
CREATE PROCEDURE AgregarCompra (
    @FechaCompra DATE,
    @Total DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Compras WHERE @FechaCompra IS NULL OR @Total IS NULL)
    BEGIN
        INSERT INTO Compras (FechaCompra, Total, FechaRegistro)
        VALUES (@FechaCompra, @Total, GETDATE());
    END;
END;

-- Editar Compra
CREATE PROCEDURE EditarCompra (
    @ID_Compra INT,
    @FechaCompra DATE,
    @Total DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Compras WHERE @FechaCompra IS NULL OR @Total IS NULL)
    BEGIN
        UPDATE Compras
        SET FechaCompra = @FechaCompra, Total = @Total
        WHERE ID_Compra = @ID_Compra;
    END;
END;

-- Eliminar Compra
CREATE PROCEDURE EliminarCompra (
    @ID_Compra INT
)
AS
BEGIN
    DELETE FROM Compras
    WHERE ID_Compra = @ID_Compra;
END;


-- Agregar Detalle de Compra
CREATE PROCEDURE AgregarDetalleCompra (
    @ID_Compra INT,
    @ID_Producto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2),
    @Subtotal DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DetallesCompras WHERE @ID_Compra IS NULL OR @ID_Producto IS NULL OR @Cantidad IS NULL OR @PrecioUnitario IS NULL OR @Subtotal IS NULL)
    BEGIN
        INSERT INTO DetallesCompras (ID_Compra, ID_Producto, Cantidad, PrecioUnitario, Subtotal, FechaRegistro)
        VALUES (@ID_Compra, @ID_Producto, @Cantidad, @PrecioUnitario, @Subtotal, GETDATE());
    END;
END;

-- Editar Detalle de Compra
CREATE PROCEDURE EditarDetalleCompra (
    @ID_DetalleCompra INT,
    @ID_Compra INT,
    @ID_Producto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10, 2),
    @Subtotal DECIMAL(10, 2)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DetallesCompras WHERE @ID_Compra IS NULL OR @ID_Producto IS NULL OR @Cantidad IS NULL OR @PrecioUnitario IS NULL OR @Subtotal IS NULL)
    BEGIN
        UPDATE DetallesCompras
        SET ID_Compra = @ID_Compra, ID_Producto = @ID_Producto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Subtotal = @Subtotal
        WHERE ID_DetalleCompra = @ID_DetalleCompra;
    END;
END;

-- Eliminar Detalle de Compra
CREATE PROCEDURE EliminarDetalleCompra (
    @ID_DetalleCompra INT
)
AS
BEGIN
    DELETE FROM DetallesCompras
    WHERE ID_DetalleCompra = @ID_DetalleCompra;
END;


-- Agregar Inventario
CREATE PROCEDURE AgregarInventario (
    @ID_Producto INT,
    @StockActual INT,
    @FechaActualizacion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Inventario WHERE @ID_Producto IS NULL OR @StockActual IS NULL OR @FechaActualizacion IS NULL)
    BEGIN
        INSERT INTO Inventario (ID_Producto, StockActual, FechaActualizacion)
        VALUES (@ID_Producto, @StockActual, @FechaActualizacion);
    END;
END;

-- Editar Inventario
CREATE PROCEDURE EditarInventario (
    @ID_Inventario INT,
    @ID_Producto INT,
    @StockActual INT,
    @FechaActualizacion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Inventario WHERE @ID_Producto IS NULL OR @StockActual IS NULL OR @FechaActualizacion IS NULL)
    BEGIN
        UPDATE Inventario
        SET ID_Producto = @ID_Producto, StockActual = @StockActual, FechaActualizacion = @FechaActualizacion
        WHERE ID_Inventario = @ID_Inventario;
    END;
END;

-- Eliminar Inventario
CREATE PROCEDURE EliminarInventario (
    @ID_Inventario INT
)
AS
BEGIN
    DELETE FROM Inventario
    WHERE ID_Inventario = @ID_Inventario;
END;


-- Agregar Devolución
CREATE PROCEDURE AgregarDevolucion (
    @ID_Venta INT,
    @ID_Producto INT,
    @CantidadDevuelta INT,
    @Motivo VARCHAR(255),
    @FechaDevolucion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Devoluciones WHERE @ID_Venta IS NULL OR @ID_Producto IS NULL OR @CantidadDevuelta IS NULL OR LTRIM(RTRIM(@Motivo)) = '' OR @FechaDevolucion IS NULL)
    BEGIN
        INSERT INTO Devoluciones (ID_Venta, ID_Producto, CantidadDevuelta, Motivo, FechaDevolucion, FechaRegistro)
        VALUES (@ID_Venta, @ID_Producto, @CantidadDevuelta, LTRIM(RTRIM(@Motivo)), @FechaDevolucion, GETDATE());
    END;
END;

-- Editar Devolución
CREATE PROCEDURE EditarDevolucion (
    @ID_Devolucion INT,
    @ID_Venta INT,
    @ID_Producto INT,
    @CantidadDevuelta INT,
    @Motivo VARCHAR(255),
    @FechaDevolucion DATE
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Devoluciones WHERE @ID_Venta IS NULL OR @ID_Producto IS NULL OR @CantidadDevuelta IS NULL OR LTRIM(RTRIM(@Motivo)) = '' OR @FechaDevolucion IS NULL)
    BEGIN
        UPDATE Devoluciones
        SET ID_Venta = @ID_Venta, ID_Producto = @ID_Producto, CantidadDevuelta = @CantidadDevuelta, Motivo = LTRIM(RTRIM(@Motivo)), FechaDevolucion = @FechaDevolucion
        WHERE ID_Devolucion = @ID_Devolucion;
    END;
END;

-- Eliminar Devolución
CREATE PROCEDURE EliminarDevolucion (
    @ID_Devolucion INT
)
AS
BEGIN
    DELETE FROM Devoluciones
    WHERE ID_Devolucion = @ID_Devolucion;
END;
