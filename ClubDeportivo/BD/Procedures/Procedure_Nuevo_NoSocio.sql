use ClubDeportivo;


delimiter //  

 create procedure Nuevo_NoSocio(in Nombre varchar(30),in Apellido varchar(40),in Direccion varchar(50), in Telefono int, in Email varchar(40),in Dni int, out rta int)

 begin

	 declare existe int default 0;

    		/* ---------------------------------------------------------
			para saber si ya esta almacenado el no socio
		------------------------------------------------------- */	
		set existe = (select count(*) from no_socio where Documento = Dni);
	 
	  if existe = 0 then	 
		 insert into no_socio(Nombre, Apellido, Direccion, Telefono, Email, Documento) values(Nombre, Apellido, Direccion, Telefono, Email, Dni);
		 set rta  = 0;
	  else
		 set rta = existe;
      end if;		 
    
     end //

delimiter ;
