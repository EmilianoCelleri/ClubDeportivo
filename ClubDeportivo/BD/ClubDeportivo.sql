drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(30,'Euge','123456',120),
(31,'Ana','123456',120),
(28,'Nana','123456',120),
(29,'Emi','123456',120);



create table socio(
nro_socio int,
Nombre varchar(30),
Apellido varchar(40),
Direccion varchar(50),
Telefono int,
Email varchar(40),
Documento int,
constraint pk_socio primary key(nro_socio)
);

INSERT INTO socio (nro_socio, Nombre, Apellido, Direccion, Telefono, Email, Documento) VALUES
(1, 'Juan', 'Pérez', 'Calle 123, Ciudad A', 5551234, 'juan.perez@email.com', 12345678),
(2, 'María', 'González', 'Avenida XYZ, Ciudad B', 5555678, 'maria.gonzalez@email.com', 87654321),
(3, 'Carlos', 'López', 'Calle ABC, Ciudad C', 5559876, 'carlos.lopez@email.com', 34567890),
(4, 'Ana', 'Rodríguez', 'Avenida 456, Ciudad D', 5554321, 'ana.rodriguez@email.com', 67890123),
(5, 'Pedro', 'Martínez', 'Calle MNO, Ciudad E', 5558765, 'pedro.martinez@email.com', 23456789),
(6, 'Laura', 'Sánchez', 'Avenida PQR, Ciudad F', 5552345, 'laura.sanchez@email.com', 78901234),
(7, 'Miguel', 'Hernández', 'Calle DEF, Ciudad G', 5558765, 'miguel.hernandez@email.com', 45678901),
(8, 'Carmen', 'Gómez', 'Avenida UVW, Ciudad H', 5553456, 'carmen.gomez@email.com', 89012345),
(9, 'Raúl', 'Fernández', 'Calle GHI, Ciudad I', 5557890, 'raul.fernandez@email.com', 56789012),
(10, 'Sofía', 'Díaz', 'Avenida JKL, Ciudad J', 5551234, 'sofia.diaz@email.com', 90123456);

create table no_socio(
id int auto_increment,
Nombre varchar(30),
Apellido varchar(40),
Direccion varchar(50),
Telefono int,
Email varchar(40),
Documento int,
constraint pk_no_socio primary key(id)
);

create table pagos(
id int auto_increment,
nro_socio int,
fecha_pago date,
vencimiento date,
constraint pk_pagos primary key (id),
constraint fk_pagos foreign key (nro_socio) references socio(nro_socio)
);

INSERT INTO pagos (nro_socio, fecha_pago, vencimiento)
VALUES (
    1,
    '2023-10-25', 
    DATE_ADD('2023-10-25', INTERVAL 30 DAY)
),
(
    2,
    '2023-08-11',
    DATE_ADD('2023-08-11', INTERVAL 30 DAY)
),
(
    3,
    '2023-09-14', 
    DATE_ADD('2023-09-14', INTERVAL 30 DAY)
),
(
    4,
    '2023-03-22',
    DATE_ADD('2023-03-22', INTERVAL 30 DAY)
),
(
    5,
    '2023-07-21', 
    DATE_ADD('2023-07-21', INTERVAL 30 DAY)
);

