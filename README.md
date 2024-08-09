# CoreWebApplication1

## Description
CoreWebApplication1 is a project developed as part of the Coursera course for the ".NET FullStack Developer Specialization" certification. This project focuses on the implementation of CRUD (Create, Read, Update, Delete) operations in an ASP.NET Core MVC application using the Code First approach.

In this project, you'll learn how to set up controllers and initialize the application's DbContext for managing the database. The project also demonstrates how to retrieve data from the database using lambda expressions and bind it to views. Additionally, you'll learn how to scaffold views for CRUD operations and handle actions such as creating, editing, and deleting data.

A key focus of the project is understanding lambda expressions and model binding, which are essential for effective communication with the database in ASP.NET Core applications. The project concludes with a demonstration of a complete CRUD operation using Entity Framework Code First approach.

## Table of Contents
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used
- **ASP.NET Core MVC**: Framework for building web applications using the Model-View-Controller pattern.
- **Entity Framework Core**: For implementing the Code First approach and managing database operations.
- **C#**: Programming language used in the project.
- **Lambda Expressions**: For querying the database in a concise manner.
- **Model Binding**: For binding data from the request to action method parameters.

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/CoreWebApplication1.git
   cd CoreWebApplication1

2. **Install Dependencies:**

    Ensure that you have the .NET SDK installed. Then, restore any required packages:

        dotnet restore

3. **Configure the Database:**

    Update the appsettings.json file with your database connection string.

4. **Run Migrations:**

    Apply the migrations to create the database and tables:

        dotnet ef migrations add InitialCreate
        dotnet ef database update

5. **Run the Application:**

    Start the application using the following command:

        dotnet run


## Usage ##
Once the application is running, you can perform CRUD operations through the web interface. The application allows you to create, read, update, and delete data using views scaffolded for these operations.


## License ##
This project is licensed under the MIT License. See the LICENSE file for more information.
