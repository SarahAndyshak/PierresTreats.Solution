# 🥨 Pierre's Bakery 🥨

#### By Sarah Andyshak

#### An app for bakery patrons to view pastries, and for the owner to update the site.

## Technologies Used

* C#
* .NET
* HTML
* MVC
* SQL Workbench
* Entity Framework
* Identity Framework
* CSS

## Description

A website for a bakery to show off pastries by type and flavor. Made using C# exploring authentication, authorization, and many-to-many relationships during Week 12 of Epicodus Coding School.

## Setup/Installation Requirements

* Clone this repo.
* Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Library".
* In the command line, run the command ``dotnet run`` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
* Optionally, you can run ``dotnet build`` to compile this console app without running it.
* This program was built using `Microsoft .NET SDK 6.0`, and may not be compatible with other versions.

* If you want to run the project in production mode with a watcher, you can use a command line flag to specify that you want to run the "production" profile. ``dotnet watch run --launch-profile "production"``
* Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)

## SQL Workbench Configuration
* Create an `appsetting.json` file in the "Library" directory of the project.
* Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=library_catalog;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* If you'd like to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore first.
* Once "appsettings.json" file has been created, navigate back to SQL Workbench. 
* Import the database named ``"PierresTreats.sql"`` from the root directory of the project. 

## Database Import Instructions

* Open SQL workbench.
* Navigate to the "Administration" tab in SQL Workbench.
* Click ``"Data Import/Restore"``
* Select the radio button "Import from Self-Contained File" and include file path to the sql file of this project that has been cloned to your machine.
* In "Default Schema to be Imported to" click "New".
* Name the schema then click "OK".
* Once named, switch to ``"Import Progress"`` tab and click ``"Start Import"``.

## Known Bugs

* No known issues.

## License
Enjoy the site! If you have questions or suggestions for fixing the code, please contact me!

[MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)

Copyright (c) 2023 Sarah Andyshak.