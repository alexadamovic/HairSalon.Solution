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

_This C# web application, styled as an employee / client management portal for Eau Claire's Salon, lets a user create a list of sylists, each with a roster of clients, that utilizes a MySQL database and connects the ```stylist``` and ```client``` tables in a One-To-Many relationship (see infographic below). Through the UI, the user is able to navigate between views to add vendors (with name and description properties) and orders (with title, description, price, and date properties). User form inputs are passed into objects of class "Vendor" & "Order" as arguments through Post requests, and RESTful routes are employed with CRUD actions to ensure development standardization. MSTest is utilized to cover all functionality of each class and its respective methods. This application is meant to showcase proper testing fundamentals within an ASP.NET core web framework._

![image](HairSalon/wwwroot/images/hair_salon_tables.png)

## Setup/Installation Requirements

* _clone repository from https://github.com/alexadamovic/VendorOrderTracker.Solution_
* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory VendorOrderTracker.Tests and enter ```dotnet restore``` to install project dependencies_
* _the project is now ready to test and run_

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