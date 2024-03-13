# DotNet CodeTest

This repository contains a simple web application for managing student records built with ASP.NET Core MVC.

## Introduction

The DotNet CodeTest project is a web-based application designed to facilitate the management of student records. It provides functionalities for adding, editing, and deleting student information.

## Features

- Add new students with their names and email addresses.
- Edit existing student records.
- Delete students from the database.
- View a list of all students with their details.

## Technologies Used

- **ASP.NET Core MVC**: Web framework for building web applications with .NET.
- **Entity Framework Core**: Object-relational mapping framework for .NET.
- **C#**: Programming language used for backend development.
- **HTML/CSS**: Frontend markup and styling.
- **Bootstrap**: Frontend framework for responsive design.
- **JavaScript**: Client-side scripting language for interactivity.

## Installation

1. Clone the repository:
`git clone https://github.com/PeterIsaacc/DotNet-CodeTest.git`

2. Navigate to the project directory:
`cd DotNet-CodeTest`


3. Restore dependencies using .NET CLI:
`dotnet restore`


4. Update the database with Entity Framework Core migrations:
`dotnet ef database update`


5. Run the application:
`dotnet run`


6. Open the application in your web browser 

## Usage

1. Navigate to the "Students" section to view a list of all students.
2. Use the "Add Student" button to add a new student by providing their name and email.
3. Click on the "Edit" button next to a student to modify their details.
4. To delete a student, click on the "Delete" button next to their record and confirm the action.

## Contributing

Contributions are welcome! Please feel free to submit bug reports, feature requests, or pull requests.

## License

This project is licensed under the [MIT License](LICENSE).
