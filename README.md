# FWDSchool

# Dev Notes
## Web Development (Full Stack)
* Frontend: HTML, CSS, JS/TS, Figma Mockups, SPA (React/Angular/Vue) 
* Application Backend:  .NET, Java, Python, PHP etc.
* Data: Relational - MySql, SQLite, SQL Server, Oracle, Postgres etc.
	NoSQL/Document - MongoDb, DynamoDB etc.
* .NET - SDK
* ASP.NET Core - Web Framework
* 0, 1, 1, 2, 3, 5, 8, 13....

## Tables we need
### Student
Id(PK), RN(CK), Name, Address, Program, Phone(CK), Email(CK), FName, MName

### Tutorial
Id(PK), Title, Description, Type, Published, Author

### TutorialSection
Id(Pk), Title, Content, Image, LastUpdated, Author, TutorialId(FK)


# Application Progress
1. Add project template
1. Modfiy navbar logo
1. Add contents to home page
1. Add menu items to navigation bar
1. Add icon library to project (bootstrap icons)
1. Refactor (4)
   1. Use array of menus and use for loop to render all menu items
   1. Add appropriate icons to all menu items
1. Add "VersionControl" controller
    1. Add Index action
    1. Add Index view and render it from action
1. Add "FrontEnd" controller
    1. Add Index action
    1. Add Index view and render it from action
