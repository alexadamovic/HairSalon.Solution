# Eau Claire's Salon: Employee Client Management Portal

#### A C# application built with ASP.NET Core & Entity to integrate MySQL databases

#### By Alex Adamovic

## Technologies Used

* _C#_
* _HTML_
* _CSS_
* _MySQL_

### Dependencies

* _Entity_
* _Bootstrap_
* _ASP.NET Core_

## Description

_This C# web application, styled as an employee / client management portal for Eau Claire's Salon, lets a user create a list of stylists, each with a roster of clients, that utilizes a MySQL database and connects the ```stylist``` and ```client``` tables in a One-To-Many relationship (see infographic below). From the splash page, the user is able to navigate between views to add stylists (with ```Name``` and ```Specialty``` properties) and clients (with ```Name``` and ```StylistId``` properties). By employing Entity and LINQ syntax, user form inputs are passed to the respective mySQL database tables through Post requests, and RESTful routes are employed with CRUD actions to ensure development standardization. HTML helper methods are also employed to DRY the code as much as possible. This application is meant to showcase proper database fundamentals in connecting an ASP.NET core web framework with mySQL databases using Entity._

### Database Table Structure

![image](HairSalon/wwwroot/images/hair_salon_tables.png)

## Setup/Installation Requirements

#### To Install MySQL & MySQL Workbench

* _go to https://dev.mysql.com/downloads/ and install **MySQL Community Server** and **MySQL Workbench** for your operating system_
* _follow the instructions at [learnhowtoprogram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for proper installation_

#### To Set Up Project With Dependencies

* _clone repository from https://github.com/alexadamovic/HairSalon.Solution_
* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory HairSalon and enter ```dotnet restore``` to install project dependencies_

#### To Import Database

* _open MySql Workbench_
* _in the Navigator > Administration window, select Data Import/Restore_
* _in Import Options select Import from Self-Contained File_
* _navigate to the file alex\_adamovic.sql in the root directory of this project_

Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end.
In this case to_do_list_test.
Click Ok.
Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.

#### To Run MSTest

* _navigate to the subdirectory VendorOrderTracker.Tests and enter ```dotnet test``` to run developer tests with MSTest_
* _all tests outlined in the VendorTests.cs and OrderTests.cs files in the VendorOrderTracker.Tests/ModelTests folder will run_

#### To Run the Web Application

* _navigate to the subdirectory VendorOrderTracker and enter ```dotnet run``` to start a local server for the application_
* _access the server in your browser by entering ```localhost:5000``` into your navigation bar_
* _click the hyperlinks and submit forms to navigate between the views_
* _enter ```ctrl``` + ```c``` for Windows or ```command``` + ```.``` for Mac in your terminal/command line to stop the server_

## Known Bugs

* _none_

## License

_MIT License_

Copyright (c) _2022_ _Alex Adamovic_

## Contact Information

alexanderadamovic@gmail.com