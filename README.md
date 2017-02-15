#  CaM2091/DotnetcoreSQLiteAPI

A simple boostrap for an API running in dotnet core using SQLite for storage.

## Technologies

- .NET Core
- Swagger.io (For API documentation)
- SQLite (For data storage)
- Visual Studio Code (For code edition)

## Install dependencies

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run with watcher

```
cd src
dotnet watch run
```

## Run in Docker

```
docker build -t src .
docker run -p 5000:5000 IO.Swagger
```

## Update database schema

Run ```dotnet ef migrations add MyFirstMigration``` to scaffold a migration to create the initial set of tables for your model.

Run ```dotnet ef database update``` to apply the new migration to the database. Because your database doesn't exist yet, it will be created for you before the migration is applied.

## Todo
- JWT Authentication
- Sample controllers and models
- Base controller
- Base model
- SQLite abstraction class
