create database LosRapidosSAbd;
use LosRapidosSAbd;

/* ---------------------- USUARIO -------------------------- */
CREATE TABLE Usuario
(
 
  Id_Usuario      int  identity (1,1) not null,
  Nombre         VARCHAR (40) not null,
  Apellido              VARCHAR (40) not null ,
  Cedula           VARCHAR (10) unique not null ,
  NombreUsuario                 VARCHAR(40) unique not null ,
  Password            VARCHAR(40) not null,
  Foto	               image not null,
  Primary Key(Id_Usuario));
  -- drop table Usuario;

  -- Crear Stored procedured --

USE [LosRapidosSAbd]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[UsuarioInsertCommand]
(
	@Nombre varchar(40),
	@Apellido varchar(40),
	@Cedula varchar(10),
	@NombreUsuario varchar(40),
	@Password varchar(40),
	@Foto image
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Usuario] ([Nombre], [Apellido], [Cedula], [NombreUsuario], [Password], [Foto]) VALUES (@Nombre, @Apellido, @Cedula, @NombreUsuario, @Password, @Foto);
	
SELECT Id_Usuario, Nombre, Apellido, Cedula, NombreUsuario, Password, Foto FROM Usuario WHERE (Id_Usuario = SCOPE_IDENTITY())

GO

/* ---------------------- CLIENTE -------------------------- */

CREATE TABLE Cliente
(
  Id_Cliente      int  identity (1,1) not null,
  Cedula         VARCHAR (60) unique not null,
  Nombre             VARCHAR (60) not null ,
  Apellido           VARCHAR (60) not null ,
  Edad                 int  not null ,
  Domicilio           VARCHAR(60) not null,
  Sexo	               VARCHAR(60) not null,
  Imagen               VARCHAR(400) not null,
  CodigoCliente	        VARCHAR(60) not null,

  Primary Key(Id_Cliente)

);
-- drop table Cliente;
-- Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente from Cliente
--INSERT
USE [LosRapidosSAbd]
GO

/** Object:  StoredProcedure [dbo].[CLIENTEInsertCommand]    Script Date: 11/01/2022 20.56.41 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CLIENTEInsertCommand]
(
	@Cedula varchar(60),
	@Nombre varchar(60),
	@Apellido varchar(60),
	@Edad int,
	@Domicilio varchar(60),
	@Sexo varchar(60),
	@Imagen varchar(400),
	@CodigoCliente varchar(60)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Cliente] ([Cedula], [Nombre], [Apellido], [Edad], [Domicilio], [Sexo], [Imagen], [CodigoCliente]) VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Domicilio, @Sexo, @Imagen, @CodigoCliente);
	
SELECT Id_Cliente, Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen, CodigoCliente FROM Cliente WHERE (Id_Cliente = SCOPE_IDENTITY())
GO


---SELECT
USE [LosRapidosSAbd]
GO

/** Object:  StoredProcedure [dbo].[CLIENTESelectCommand]    Script Date: 11/01/2022 20.57.10 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CLIENTESelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Cliente.*
FROM            Cliente
GO

--BUSCAR INDIVIDUAL
USE [LosRapidosSAbd]
GO

/** Object:  StoredProcedure [dbo].[CLIENTESelectCommand]    Script Date: 11/01/2022 20.57.10 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CLIENTESelectindividualCommand]
(@cedula   VARCHAR (60)  
)

AS
	SET NOCOUNT ON;
SELECT        Cliente.*
FROM            Cliente
WHERE Cedula = @cedula;
GO



---ELIMINAR
USE [LosRapidosSAbd]
GO

/** Object:  StoredProcedure [dbo].[CLIENTEDeleteCommand]    Script Date: 11/01/2022 20.57.45 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CLIENTEDeleteCommand]
(
	
	@Original_Cedula varchar(60)

)
AS
	SET NOCOUNT OFF;
DELETE FROM [Cliente] WHERE( [Cedula] = @Original_Cedula) 
GO

---ACTUALIZAR-


USE [LosRapidosSAbd]
GO

/** Object:  StoredProcedure [dbo].[CLIENTEUpdateCommand]    Script Date: 11/01/2022 20.57.24 **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CLIENTEUpdateCommand]
(
	@Cedula varchar(60),
	@Nombre varchar(60),
	@Apellido varchar(60),
	@Edad int,
	@Domicilio varchar(60),
	@Sexo varchar(60),
	@Imagen varchar(400),
	@CodigoCliente varchar(60)
	
)
AS
	SET NOCOUNT OFF;
UPDATE [Cliente] SET  [Nombre] = @Nombre, [Apellido] = @Apellido, [Edad] = @Edad, [Domicilio] = @Domicilio, [Sexo] = @Sexo, [Imagen] = @Imagen, [CodigoCliente] = @CodigoCliente WHERE ([Cedula] = @Cedula);
	
GO


/* --------------------- AMBULANCIA ------------------------ */

CREATE TABLE Ambulancia
(
  Id_Ambulancia      int  identity (1,1) not null,
  modelo         VARCHAR (40) not null,
  tipoAmbulancia              VARCHAR (40) not null ,
  placa           VARCHAR (40) unique not null,
  matricula                 VARCHAR(40) unique not null,
  Primary Key(Id_Ambulancia)
);
-- drop table Ambulancia;


USE [LosRapidosSAbd]
GO

/******  Insertar Ambulancia *****/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambInsertCommand]
(
	@modelo varchar(40),
	@tipoAmbulancia varchar(40),
	@placa varchar(40),
	@matricula varchar(40)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Ambulancia] ([modelo], [tipoAmbulancia], [placa], [matricula]) VALUES (@modelo, @tipoAmbulancia, @placa, @matricula);
	
SELECT Id_Ambulancia, modelo, tipoAmbulancia, placa, matricula FROM Ambulancia WHERE (Id_Ambulancia = SCOPE_IDENTITY())
GO



/******  Buscar ******/

GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Ambulancia.*
FROM            Ambulancia
GO

/****** Buscar individual   ******/


USE [LosRapidosSAbd]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambSelectindividualCommand](
@placa varchar(40)
)
AS
	SET NOCOUNT ON;
SELECT        Ambulancia.*
FROM            Ambulancia
WHERE placa = @placa;

GO

/****** Delete Ambulancia ******/

USE [LosRapidosSAbd]
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[AmbDeleteCommand]
(
	@Original_placa varchar(40)
)
AS
SET NOCOUNT OFF;
DELETE FROM [Ambulancia] WHERE ([placa] = @Original_placa)
GO

/****** Update Ambulancia ******/


GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[ambUpdateCommand]
(
	@modelo varchar(40),
	@tipoAmbulancia varchar(40),
	@placa varchar(40),
	@matricula varchar(40)
)
AS
	SET NOCOUNT OFF;
UPDATE [Ambulancia] SET [modelo] = @modelo, [tipoAmbulancia] = @tipoAmbulancia, [matricula] = @matricula WHERE ([placa] = @placa);

GO

/* ---------------------- CONDUCTOR ------------------------ */

CREATE TABLE Conductor
(
  Id_Conductor      int  identity (1,1) not null,
  Cedula         VARCHAR (60) unique not null,
  Nombre             VARCHAR (60) not null ,
  Apellido           VARCHAR (60) not null ,
  Edad                 int  not null ,
  Domicilio           VARCHAR(60) not null,
  Sexo	               VARCHAR(60) not null,
  Licencia             VARCHAR(60) not null,

  Primary Key(Id_Conductor)
);

/* Registrar conductor*/
USE [LosRapidosSAbd]
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CONDUCTORInsertCommand]
(
	@Cedula varchar(60),
	@Nombre varchar(60),
	@Apellido varchar(60),
	@Edad int,
	@Domicilio varchar(60),
	@Sexo varchar(60),
	@Licencia varchar(60)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Conductor] ([Cedula], [Nombre], [Apellido], [Edad], [Domicilio], [Sexo], [Licencia]) VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Domicilio, @Sexo, @Licencia);
	
SELECT Id_Conductor, Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia FROM Conductor WHERE (Id_Conductor = SCOPE_IDENTITY())
GO

/*          Consulta de conductores            */

CREATE OR ALTER PROCEDURE [dbo].[CONDUCTORSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Conductor.*
FROM            Conductor
GO

/*           Actualizar Conductores               */
CREATE OR ALTER PROCEDURE [dbo].[CONDUCTORUpdateCommand]
(
	@Cedula varchar(60),
	@Nombre varchar(60),
	@Apellido varchar(60),
	@Edad int,
	@Domicilio varchar(60),
	@Sexo varchar(60),
	@Licencia varchar(60)
	
)
AS
	SET NOCOUNT OFF;
UPDATE [Conductor] SET  [Nombre] = @Nombre, [Apellido] = @Apellido, [Edad] = @Edad, [Domicilio] = @Domicilio, [Sexo] = @Sexo, [Licencia] = @Licencia WHERE ([Cedula] = @Cedula);
	
GO

/*                    Eliminar conductor                        */

CREATE OR ALTER PROCEDURE [dbo].[CONDUCTORDeleteCommand]
(
	@Cedula varchar(60)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Conductor] WHERE( [Cedula] = @Cedula) 
GO


/*                Busqueda por cedula                          */

CREATE OR ALTER PROCEDURE [dbo].[CONDUCTORSelectByCedulaCommand](
@cedula varchar(60)
)
AS
	SET NOCOUNT ON;
SELECT        Conductor.*
FROM            Conductor
WHERE Cedula = @cedula;

GO

/* ---------------------- Asignacion ------------------------ */


CREATE TABLE Asignacion
(

  Id_Asignacion int identity (1,1) not null,
  Id_AmbulanciaAsignacion  int unique not null,
  Id_ConductorAsignacion  int unique not null,
  
  Primary Key(Id_Asignacion)
);

-------- Foraneas para Asignacion
alter table Asignacion add constraint fk_Id_Ambulancia
foreign key(Id_AmbulanciaAsignacion) REFERENCES Ambulancia(Id_Ambulancia) ON DELETE CASCADE;

alter table Asignacion add constraint fk_Id_Conductor
foreign key(Id_ConductorAsignacion) REFERENCES Conductor(Id_Conductor) ON DELETE CASCADE;

/****** INSERT ASIGNACION ******/
USE [LosRapidosSAbd]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[AsignacionInsertCommand]
(
	@Id_AmbulanciaAsignacion int,
	@Id_ConductorAsignacion int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Asignacion] ([Id_AmbulanciaAsignacion], [Id_ConductorAsignacion]) VALUES (@Id_AmbulanciaAsignacion, @Id_ConductorAsignacion);
	
SELECT Id_Asignacion, Id_AmbulanciaAsignacion, Id_ConductorAsignacion FROM Asignacion WHERE (Id_Asignacion = SCOPE_IDENTITY())
GO

/* ------------------------ PAGOS -------------------------- */
