# Console Application for Department and Instructor Management

## Overview
This is a **console application** developed as part of a team project during the **MTI training**. The application handles **CRUD (Create, Read, Update, Delete) operations** for managing departments and instructors using **C#**, **Object-Oriented Programming (OOP)** principles, and **Entity Framework**. The data is stored in a **Microsoft SQL Server** database.

## Features

### General Features
- **CRUD Operations for Departments**:
  - Add, delete, update, and view department information.
  
- **CRUD Operations for Instructors**:
  - Add, delete, update, and view instructor information.
  
- **Console-based Interface**:
  - Simple and interactive command-line interface for managing departments and instructors.

### Database Management:
- **Microsoft SQL Server** for secure and efficient data storage.
- **Entity Framework** for database access and management.

### OOP Principles:
- The application is designed using **Object-Oriented Programming (OOP)** concepts, ensuring clean code, reusability, and scalability.

## Technology Stack

### Backend:
- **C#** for developing the core application logic.
- **Entity Framework** as the Object-Relational Mapper (ORM) for database interactions.
- **Microsoft SQL Server** for data storage and management.

### Design:
- **Object-Oriented Programming (OOP)** principles applied for clean architecture and code structure.

## Setup and Installation

1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Set up the **SQL Server** database and configure the connection string in the `appsettings.json` file.
4. Run **Entity Framework migrations** to create the required tables in the database:
   ```bash
   Update-Database
