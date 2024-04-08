CREATE DATABASE EVALUACION


CREATE TABLE Categorias(
    Codigo_categoria int primary key,
    Nombre VARCHAR(50)
	)
CREATE TABLE Editoriales(
    Nit int primary key,
    Nombres VARCHAR(100),
    Telefono VARCHAR(15), 
    Direccion VARCHAR(100),
    Email VARCHAR(100),
    Sitioweb VARCHAR(100)
)
CREATE TABLE Libros(
    Isbn varchar(20) primary key,
    Titulo VARCHAR(100) not null,
    Descripcion VARCHAR(255), 
    Nombre_autor VARCHAR(100),
    Publicacion date,
    Fecha_registro date,
    Codigo_categoria int,
    Nit_editorial int,
    foreign key (codigo_categoria) REFERENCES categorias(Codigo_categoria),
    foreign key (nit_editorial) REFERENCES editoriales(nit))