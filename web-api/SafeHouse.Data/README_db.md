Add new migration
---------------
`              > cd .\SafeHouse.Data`
`SafeHouse.Data> dotnet ef migrations add <GiveSomeNameMigration> -s ..\SafeHouse.Api\SafeHouse.Api.csproj -o .\Migrations\`

Update db
---------------
`              > cd .\SafeHouse.Api`
` SafeHouse.Api> dotnet ef database update`