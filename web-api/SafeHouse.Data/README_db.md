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