use ClubDeportivo;


delimiter //  

 create procedure Nuevo_Socio(in Nombre varchar(30),in Apellido varchar(40),in Direccion varchar(50), in Telefono int, in Email varchar(40),in Dni int, out rta int)

 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socio);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de socio */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de socio almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(nro_socio) + 1 from socio);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el socio
		------------------------------------------------------- */	
		set existe = (select count(*) from socio where Documento = Dni);
     end if;
	 
	  if existe = 0 then	 
		 insert into socio values(filas,Nombre,Apellido,Direccion,Telefono,Email,Dni);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end //

delimiter ;
