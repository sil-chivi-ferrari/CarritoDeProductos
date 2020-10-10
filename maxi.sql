select * from CATEGORIAS
select * from ARTICULOS

select a.id, a.nombre, a.descripcion, a.imagenurl, c.Descripcion categoria from articulos as a, categorias as c where a.IdCategoria = c.Id

select id, descripcion from CATEGORIAS

insert into Articulos (Nombre, descripcion, imagenUrl,idCategoria) values ('','','')

delete from articulos 
where id in (22,23,24,25,26,27,28,29)

select a.id, a.nombre, c.descripcion, a.imagenurl, c.Descripcion as categoria from ARTICULOS as a, categorias as c where a.idcategoria = c.id

select id, descripcion from CATEGORIAS

select id, nombre, descripcion from ARTICULOS

select * from articulos

Select A.ID, A.Nombre, a.Descripcion, A.ImagenUrl, Precio, C.Descripcion Categoria From CATEGORIAS C, ARTICULOS A Where A.IdCategoria = c.Id

"select a.id, a.nombre, a.descripcion, a.imagenurl,c.descripcion as cat from articulos as a, categorias as c where c.Id = a.IdCategoria";

select a.id, a.nombre, a.descripcion, a.imagenurl,c.descripcion as categoria from articulos as a, categorias as c where c.Id = a.IdCategoria  