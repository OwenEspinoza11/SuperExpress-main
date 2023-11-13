create database SuperExpress2

use SuperExpress2

-- Tabla de Proveedores con Fecha de Registro
CREATE TABLE Proveedores (
    ID_Proveedor INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(15),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- Tabla de Clientes con Fecha de Registro
CREATE TABLE Clientes (
    ID_Cliente INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    CorreoElectronico VARCHAR(100),
    Telefono VARCHAR(15),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- Tabla de Productos con Fecha de Registro
CREATE TABLE Productos (
    ID_Producto INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50),
    Precio DECIMAL(10, 2),
    Stock INT,
    ID_Proveedor INT,
    Categoria VARCHAR(50),
    FechaLote DATE,
    FechaExpiracion DATE,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor)
);

-- Tabla de Ventas con Fecha de Registro
CREATE TABLE Ventas (
    ID_Venta INT PRIMARY KEY,
    ID_Cliente INT,
    FechaVenta DATE,
    Total DECIMAL(10, 2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);

-- Tabla de Detalles de Ventas con Fecha de Registro
CREATE TABLE DetallesVentas (
    ID_DetalleVenta INT PRIMARY KEY,
    ID_Venta INT,
    ID_Producto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta),
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);

-- Tabla de Compras con Fecha de Registro
CREATE TABLE Compras (
    ID_Compra INT PRIMARY KEY,
    FechaCompra DATE,
    Total DECIMAL(10, 2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- Tabla de Detalles de Compras con Fecha de Registro
CREATE TABLE DetallesCompras (
    ID_DetalleCompra INT PRIMARY KEY,
    ID_Compra INT,
    ID_Producto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Compra) REFERENCES Compras(ID_Compra),
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);


-- Tabla de Inventario
CREATE TABLE Inventario (
    ID_Inventario INT PRIMARY KEY,
    ID_Producto INT,
    StockActual INT,
    FechaActualizacion DATE,
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);


-- Tabla de Devoluciones
CREATE TABLE Devoluciones (
    ID_Devolucion INT PRIMARY KEY,
    ID_Venta INT,
    ID_Producto INT,
    CantidadDevuelta INT,
    Motivo VARCHAR(255),
    FechaDevolucion DATE,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta),
    FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);


create table Negocio(
IdNegocio int primary key,
Nombre varchar(60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(max) NULL
)


--Valores de prueba
go
-- Insertar Proveedores de Ejemplo
INSERT INTO Proveedores (Nombre, Direccion, Telefono)
VALUES
    ('Proveedor1', 'Dirección1', '123456789'),
    ('Proveedor2', 'Dirección2', '987654321');

	go
-- Insertar Productos de Ejemplo
INSERT INTO Productos (Nombre, Precio, Stock, ID_Proveedor, Categoria, FechaLote, FechaExpiracion)
VALUES
    ('Producto1', 10.99, 50, 1, 'Categoria1', '2023-01-01', '2023-12-31'),
    ('Producto2', 5.99, 30, 2, 'Categoria2', '2023-02-01', '2023-11-30');

	go
-- Insertar Clientes de Ejemplo
INSERT INTO Clientes (Nombre, Apellido, CorreoElectronico, Telefono)
VALUES
    ('Cliente1', 'Apellido1', 'cliente1@example.com', '111111111'),
    ('Cliente2', 'Apellido2', 'cliente2@example.com', '222222222');

	go
-- Insertar Ventas de Ejemplo
INSERT INTO Ventas (ID_Cliente, FechaVenta, Total)
VALUES
    (1, '2023-01-15', 50.00),
    (2, '2023-02-20', 75.50);

	go
-- Insertar Detalles de Ventas de Ejemplo
INSERT INTO DetallesVentas (ID_Venta, ID_Producto, Cantidad, PrecioUnitario, Subtotal)
VALUES
    (1, 1, 5, 10.99, 54.95),
    (2, 2, 3, 5.99, 17.97);

	go
-- Insertar Compras de Ejemplo
INSERT INTO Compras (FechaCompra, Total)
VALUES
    ('2023-03-01', 120.00),
    ('2023-03-10', 90.50);

	go
-- Insertar Detalles de Compras de Ejemplo
INSERT INTO DetallesCompras (ID_Compra, ID_Producto, Cantidad, PrecioUnitario, Subtotal)
VALUES
    (1, 1, 10, 8.99, 89.90),
    (2, 2, 5, 7.50, 37.50);

	go
	-- Insertar Inventario de Ejemplo
INSERT INTO Inventario (ID_Producto, StockActual, FechaActualizacion)
VALUES
    (1, 40, '2023-03-15'),
    (2, 25, '2023-03-15');

	go


SELECT 
    DV.ID_DetalleVenta,
    DV.ID_Venta,
    DV.ID_Producto,
    DV.Cantidad,
    DV.PrecioUnitario,
    DV.Subtotal,
    DV.ID_Cliente  -- Nueva adición: Incluye el ID del Cliente
FROM DetallesVentas DV
JOIN Ventas V ON DV.ID_Venta = V.ID_Venta;


SELECT 
    C.ID_Compra,
    C.FechaCompra,
    C.Total,
    C.ID_Proveedor,  -- Nueva adición: Incluye el ID del Proveedor
    C.FechaRegistro
FROM Compras C;


SELECT 
    DC.ID_DetalleCompra,
    DC.ID_Compra,
    DC.ID_Producto,
    DC.Cantidad,
    DC.PrecioUnitario,
    DC.Subtotal,
    DC.ID_Proveedor,  -- Nueva adición: Incluye el ID del Proveedor
    DC.FechaRegistro
FROM DetallesCompras DC;

sp_addlogin 'OWEN', 'OWEN123', 'SuperExpress2'
sp_addsrvrolemember 'OWEN', 'sysadmin'
sp_adduser 'OWEN', 'ODEL'
sp_addrolemember 'db_datareader', 'ODEL'
sp_addrolemember 'db_datawriter', 'ODEL'

sp_addlogin 'Alejandro2', 'Alejandro123', 'SuperExpress2'
sp_addsrvrolemember 'Alejandro2', 'sysadmin'
sp_adduser 'Alejandro2', 'AJRG'
sp_addrolemember 'db_datareader', 'AJRG'
sp_addrolemember 'db_datawriter', 'AJRG'
