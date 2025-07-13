# ✅ Task Management System - Oritso Assignment

A simple ASP.NET Core MVC web application built for Oritso Private Limited's screening assignment.  
It demonstrates full **CRUD operations**, proper **MVC architecture**, **database integration**, and a **user-friendly UI** for managing tasks.

---

## 🚀 Features

- 🔍 View and search tasks
- ➕ Create new tasks with form validation
- 📝 Edit existing tasks
- 🗑️ Delete tasks with confirmation
- 📅 Set and manage due dates
- ✅ Dropdown-based task status (Pending / Completed)
- 💬 Remarks field for additional task notes
- 📄 Timestamps for creation and updates

---

## 📌 Overview (Per Oritso's Guidelines)

This application allows users to manage tasks effectively through a structured MVC solution.  
It includes the ability to perform:
- Create
- Read
- Update
- Delete
- Search  

All from the web frontend using Razor Views and Entity Framework.

---

## 🏗️ Application Structure

### ❓ MVC or SPA:
This is a **Standard MVC Server-Side Web Application** built using Razor Views, not a SPA.

### 🔧 Project Layers:
- **Model**: `Task.cs` representing Task entity
- **View**: Razor pages in `/Views/Tasks/`
- **Controller**: `TasksController.cs` handles HTTP logic
- **Data**: `ApplicationDbContext.cs` handles DB operations

---

## 🎨 Frontend Stack

- **Razor (.cshtml)**: For rendering dynamic HTML
- **Bootstrap 5**: For responsive layout and design
- **Validation**: DataAnnotations + client-side validation support

📌 **Why Razor + Bootstrap?**  
Razor Views simplify rendering on the server side, and Bootstrap ensures a clean, mobile-friendly UI without complexity.

---

## 🧩 Database Design

### ➤ Code First Approach (Why?):  
Used for fast development and easy schema changes with EF Core migrations. Keeps models and DB in sync via source control.

### ➤ Entity: `Task`
| Field              | Type           | Description                          |
|-------------------|----------------|--------------------------------------|
| Id                | int (PK)       | Task identifier                      |
| Title             | string         | Task title                           |
| Description       | string         | Full task description                |
| DueDate           | DateTime       | Task deadline                        |
| Status            | string         | Task status (Pending, Completed)     |
| Remarks           | string         | Optional remarks                     |
| CreatedOn         | DateTime       | Timestamp of task creation           |
| LastUpdatedOn     | DateTime       | Timestamp of last update             |
| CreatedBy         | string         | Name of creator                      |
| LastUpdatedBy     | string         | Name of last editor                  |

### ➤ Indexes Used:
- Primary Key: `Id`
- Index on `DueDate` and `Status` for filtering

### ➤ ER Diagram:
*Insert image here, e.g., `![ER Diagram](docs/er-diagram.png)`*

---

## ⚙️ Build and Run Instructions

### Prerequisites
- Visual Studio 2022+
- .NET 6 SDK+
- SQL Server / LocalDB

### Clone the Repo
```bash
git clone https://github.com/Sumit-Kumar-Kamti-CUSAT/Task-Management-Oritso.git
Open in Visual Studio
Open the .sln file

Restore NuGet packages
(Menu → Tools → NuGet Package Manager → Manage Packages for Solution)

Configure DB
Update appsettings.json:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TaskDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Apply EF Migrations
powershell
Copy
Edit
Update-Database
Run the App
Press F5 or click the green "Run" button.

🧪 User Acceptance Testing
All key operations were manually tested:

Task creation

Task editing

Task deletion

Filtering and search functionality

📦 Deployment Architecture
Local deployment using IIS Express. Can be easily adapted to production via:

Azure App Services

Docker container

On-premise IIS

🔄 Data Migration
Handled via Entity Framework Core Migrations (Update-Database).

🧯 Risks & Issues
No authentication layer included (can be extended)

Data is not user-specific (multi-user support can be added)

Basic styling – no custom design libraries used

📘 Abbreviations
Term	Meaning
MVC	Model-View-Controller
CRUD	Create, Read, Update, Delete
EF	Entity Framework
SPA	Single Page Application
MPA	Multi Page Application

👤 Author
Sumit Kumar Kamti
GitHub: github.com/Sumit-Kumar-Kamti-CUSAT
