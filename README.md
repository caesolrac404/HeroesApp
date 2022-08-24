# HeroesApp

# Decisions made to create the project
To create this project I had to implement 3 specific things in it:
- Creation of an extra project to manage the database and use mapper to map classes
- Implementation of Repository design pattern to manage the data sources (in this case only 1)
- Dependency injection to inject services needed

# Walkthrough of the project structure
- Basic standard MVC structure
- Common folder: in this case just for mapping
- Repository folder: for repository design pattern
- HeroesApp.Data project: to manage databases, creation of Migrations and DbContext

# Steps to deploy the app
1. Inside project files, Open appsettings.json
2. In ConnectionStrings:HeroesDb modify the connection string with your own configuration
3. Create database migration with command Add-Migration "name of migration" in Package Manager console (Tools > NuGet PAckage Manager > Package Manager Console)
4. Once created database migration execute command Update-Database in Package Manager console
5. If all OK, Run the App

# Thing that you need to know
- Once you modify the connection string and run the app, heroes will be insert automatically into database.
