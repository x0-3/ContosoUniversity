# ContosoUniversity

ContosoUniversity is a C# project built using the .NET Framework, designed to provide CRUD (Create, Read, Update, Delete) operations for managing students, their grades, and enrollments. This application simplifies the management of student data for educational institutions, making it easy to track and maintain student information.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Student Management**: Easily add, edit, view, and delete student records.
- **Grade Management**: Manage student grades and track their academic performance.
- **Enrollment Management**: Enroll students in courses and keep track of their academic progress.
- **User-Friendly Interface**: An intuitive and user-friendly interface for easy navigation.
- **Data Validation**: Ensure data accuracy with built-in validation checks.
- **Responsive Design**: The application is designed to work seamlessly on various screen sizes and devices.

## Getting Started

Follow these steps to get ContosoUniversity up and running on your local machine.

### Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) is installed on your system.
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) or any C# compatible IDE for development.
- A SQL Server database or SQL Server Express for storing student, grade, and enrollment data.

### Installation

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/x0-3/ContosoUniversity.git
   ```

2. Open the project in your preferred C# IDE (e.g., Visual Studio).

3. Update the database connection string in the `appsettings.json` file to point to your SQL Server instance:

   ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=contosoUniversity;User=root;Password=;"
    },
   ```

4. Open the Package Manager Console in Visual Studio and run the following command to apply migrations and create the database:

   ```bash
   Update-Database
   ```

5. Build and run the application.

## Usage

ContosoUniversity is designed to be straightforward to use:

- **Students**: Add, edit, or delete student records. View a list of all students.
- **Grades**: Manage student grades, including adding and editing grade information.
- **Enrollments**: Enroll students in courses and track their progress.

The application provides a user-friendly interface to interact with these features.
