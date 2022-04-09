CREATE TABLE TB_EMPLEADOS(
DOCUMENTOS NVARCHAR(8) PRIMARY KEY,
NOMBRES NVARCHAR(100) NOT NULL,
APELLIDOS NVARCHAR(100) NOT NULL,
fecha  date,
hora time
)



select * from TB_EMPLEADOS 
insert into TB_EMPLEADOS values ('100','mariana krishe','ramos torres','2022-04-09','08:44:22')
insert into TB_EMPLEADOS values ('101','erick johan','vargas gutierrez','2022-04-06','07:30:22')
