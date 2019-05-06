This document describes:
- Deployment of web site
- Migration of data to chosen database


Deployment of web site
=============

Web site can be deployed in three different environments:
- Development
- Staging (already configured)
- Production (not yet ready)

Development
---------------

Open appsettings.Development.json and configure default db connection string to for your development workstation.

Create new database in local instance of SQL Server
---------------
`CREATE DATABASE SafeHouse;`

Migration of data to chosen database
=============

Add new migration
---------------
`> cd .\SafeHouse.Data`

`> dotnet ef migrations add <GiveSomeNameMigration> -s ..\SafeHouse.Api\SafeHouse.Api.csproj -o .\Migrations\`

Update db
---------------
`> cd .\SafeHouse.Api`

`> dotnet ef database update`

Clean all migrations
---------------
`> dotnet ef database update 0`

`> dotnet ef migrations remove -s ..\SafeHouse.Api\SafeHouse.Api.csproj`