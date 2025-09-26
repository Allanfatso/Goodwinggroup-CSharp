#  Windows Forms Applications

This repository contains two **C# Windows Forms** applications that demonstrate building desktop software with **WinForms** and **MySQL database integration**.

## Projects

### 1. **c-sharp-library-app**

A simple **Library Management Application** that allows users to add and manage books in a personal catalogue.

#### Features

* **Main Form**

  * Navigation hub
  * Displays total number of books available
* **View Books Form**

  * DataGridView to list all books
  * Edit or delete existing records
* **Add Books Form**

  * Add new books to the catalogue with input fields
* **Database Integration**

  * Uses MySQL as backend storage
  * Supports basic CRUD operations (Create, Read, Update, Delete)

#### Tech Stack

* C# (WinForms)
* MySQL
* ADO.NET (for database connection)

---

### 2. **goodwinggroup_app**

A **TV Catalogue Application** that stores and displays TV programs.

#### Features

* MySQL backend with multiple related tables
* Uses **SELECT queries with JOINs** to pull information from different models
* Displays TV program details in the application UI
* Supports adding, browsing, and organizing shows

#### Tech Stack

* C# (WinForms)
* MySQL
* ADO.NET

---

## Getting Started

### Prerequisites

* [Visual Studio](https://visualstudio.microsoft.com/) (Windows Forms project support enabled)
* [MySQL Server](https://dev.mysql.com/downloads/mysql/) & MySQL Workbench
* [MySQL.Data](https://www.nuget.org/packages/MySql.Data/) NuGet package for database connections

### Setup

1. Clone this repository:

   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
   ```
2. Open the project folder (`c-sharp-library-app` or `goodwinggroup_app`) in Visual Studio.
3. Restore NuGet dependencies (MySQL.Data).
4. Update your **MySQL connection string** in the code (server, username, password, database name).
5. Run the application.


---
This project is open-source and available under the MIT License.

---

Would you like me to also create a **short MySQL setup guide** (with `CREATE TABLE` examples for books and tv shows) so anyone testing your repo can run it without guessing the schema?
