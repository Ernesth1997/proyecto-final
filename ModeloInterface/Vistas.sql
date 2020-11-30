create view vwcategoria as
select idCategoria, nombre as 'Nombre', descripcion as 'Descripcion', fechaActualizacion as 'Registrado el:'
from categoria where estado=1;

insert into cliente	(nit, razonSocial) values ('9942923', 'Alexis Kempes');
create view vwcliente as 
select idCliente, nit as 'Nit', razonSocial as 'Razon Social', fechaActualizacion as 'Registrado el:'
from cliente where estado=1;

create view vwproducto as
select p.idProducto, c.nombre as 'Categoria', c.descripcion as 'Descripcion', p.nombreProducto as 'Nombre del Producto', p.precioCompra as 'Precio Compra', p.precioVenta as 'Precio Venta', p.stock as 'Stock', p.fechaActualizacion as 'Registrado el:'
from producto p inner join categoria c on p.idCategoria=c.idCategoria
where p.estado=1;

create view vwproveedor as 
select idProveedor, concat(nombre,' ',primerApellido,' ',segundoApellido) as 'Nombre Completo', direccion as 'Direccion', telefono as 'Telefono', fechaActualizacion as 'Registrado el:' 
from proveedor where estado=1;

create view vwusuario as
select * from usuario; 
select idUsuario, concat(nombre,' ',primerApellido,' ',segundoApellido) as 'Nombre Completo', email as 'Email', rol as 'Rol Usuario', fechaActualizacion as 'Registrado el:'
from usuario where estado=1;

INSERT INTO usuario (nombre, primerApellido,segundoApellido,ci,email,rol) 
values('ernesth', 'yanez','mayorga', md5('123
S), 'ernesth1994@gmail.com', 'administrador');