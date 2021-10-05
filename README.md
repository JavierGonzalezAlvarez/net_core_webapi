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

## instalar entityframework version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.tools --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.4


