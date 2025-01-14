# HerzingBookStore

## Description
Simple application for performing CRUD operations on a database of books.
The project was created to familiarize myself with ASP.NET Core MVC and was done as a part of my course at Herzing College.
The application is very basic, consisting of only a few views. The main view is the Book List which contains a table filled with books along with their author and price. From this page, signed in users can edit or delete a book, or add a whole new book. Users who aren't signed in can still view the list of books, but cannot perform any of these actions.
The books within the book list are sourced from a SQL Server database I've created, and each edit, deletion, or new book automatically updates the database.
The book list and database connection have all been created following the tutorial from Bhrugen at Free Code Camp (https://github.com/bhrugen/BookListMVC, https://youtu.be/C5cnZ-gZy2I?si=lhbrG4c7pQy8bIae)
The authentication for the application was implemented using ASP.NET Core Identity, meaning all of the logic behind authentication as well as the views for the login and registration page were taken from this framework. Sidenote: there are views from ASP.NET Core Identity that I left in even though I didn't use them just incase I want to come back to this project and implement them later.

## What's in this repository?
- The ASP.NET Core application itself is found in the HerzingMVC folder
- A published version of the application is found in the PublishedBookStore folder
- .bak files for the user and booklist databases are found in the Databases folder

## How to Run
To run the page locally, you'll need to first import the databases (found in the "Databases" folder) into SQL Server. If you use the same server name as me ((LocalDb)\MSSQLLocalDB), then you should be able to run and view and interact with the site by directly running the "HerzingMVC.exe" file from the "PublishedBookStore" folder. From there, just copy the localhost link from the cmd prompt into your browser and you should be good to go.
If you're using a different server, you'll need to edit the connection strings in the appsettings.json which is found in the "HerzingMVC" folder so that the application can connect to the database.

## Deployment Notes
If you would like to deploy the application, here is a brief overview of the steps you'd have to take:
1. Get a domain name
2. Pick a hosting provider that will host your application (ex: Azure, AWS, etc.). Make sure the provider you pick supports ASP.NET Core.
3. Pick a cloud database that will hold the information for your users and books
4. Deploy your application to the hosting provider and import your database into your new cloud database
5. Configure your domain so it points to the hosting provider you picked