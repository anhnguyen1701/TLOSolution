# ASP.NET Core 3.1 project from Team 5
## Technologies
- ASP.NET Core 3.1
- Entity Framework Core 3.1
## Install Tools
- .NET Core SDK 3.1
- Visual Studio 2019
- SQL Server 2019
## How to configure and run
- Clone code from Github: git clone https://github.com/anhnguyen1701/TLOSolution.git
- Open solution TLOSolution.sln in Visual Studio 2019
- Set startup project is TLOSolution.Data
- Change connection string in Appsetting.json in TLOSolution.Data project
- Open Tools --> Nuget Package Manager -->  Package Manager Console in Visual Studio
- Open Package Manage Console and type "update-database" then press Enter
- After migrate database successful, set Startup Project is TLOSolution.WebApp
- Change database connection in appsettings.json in TLOSolution.WebApp project.
- Press F5, enjoy and star ⭐⭐⭐
