## api web en .Net Core 5 en linux

## ver que tipos de proyectos se pueden crear
$ dotnet new --list

## crear proyecto api, nombre: api
$ dotnet new webapi -o apiweb

## certificados en dev
$ dotnet dev-certs https -- trust

## correr proyecto
$ cd apiweb
$ dotnet run

## swagger
https://localhost:5001/swagger/index.html

## api de ejemplo
https://localhost:5001/weatherForecast

## crear controller de la api, fichero
Controllers/UserController.cs

## Crear base de datos - instalar entityframework version 5.0.4
$ dotnet add package Microsoft.EntityFrameworkCore --version 5.0.4
$ dotnet add package Microsoft.EntityFrameworkCore.tools --version 5.0.4
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.4

## crear dbcontext
-acceder a la base de datos
-crear servico en startup.cs
## crear carpeta Entidades y DTOS
- formato tabla
## añadir conexion a la DB
fichero "appsettings.Development.json"

## instalar AutoMapper
https://docs.automapper.org/en/latest/Getting-started.html
-genera mapeo automatica en net Core de las DTO
$ dotnet add package AutoMapper
$ dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

## crear carpeta utilidades
-crear fichero "AutoMapperProfiles.cs" para el mapeo las tablas

## migracion
- nombre de la migracion: Initial
$ dotnet ef migrations add Initial

## remover migracion
$ dotnet ef migrations remove

## endpoints
https://localhost:5001/swagger/index.html
