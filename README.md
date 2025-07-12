# ✅ Task Management System - Oritso Assignment

A simple ASP.NET Core MVC web application to manage tasks efficiently.  
This project was built as part of a technical assignment and demonstrates full CRUD functionality, model validation, and basic UI integration.

## 🚀 Features

- 🔍 View and search tasks
- ➕ Create new tasks with validation
- 📝 Edit existing tasks
- 🗑️ Delete tasks with confirmation
- 📅 Set due dates
- ✅ Dropdown-based status selection
- 💬 Remarks field for additional notes

---

## 🛠️ Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor Views (.cshtml)
- Bootstrap 5 (via layout)
- Visual Studio IDE
- Git + GitHub

---

## 📸 Screenshots

### 🏠 Task List (Dashboard)
![Dashboard](master/dashboard.png)

### ➕ Create Task Form
![Create Task](screenshots/create-task-form.png)

### 📝 Edit Task
![Edit Task](screenshots/edit-task.png)

---

## 🧩 Database Setup

Ensure you have SQL Server installed and update the connection string in:

```bash
appsettings.json


"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TaskDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Then Run:
PM> Update-Database

🖥️ How to Run
Clone the repo:

bash
Copy
Edgit clone https://github.com/Sumit-Kumar-Kamti-CUSAT/Task-Management-Oritso.git
it

git clone https://github.com/Sumit-Kumar-Kamti-CUSAT/Task-Management-Oritso.git
Open the .sln file in Visual Studio.

Restore NuGet packages:

Menu: Tools > NuGet Package Manager > Manage NuGet Packages for Solution

Apply migrations if needed:

bash
Copy
Edit
PM> Update-Database
Run the project:

Press F5 or click ▶️ Start Debugging

🔗 GitHub Repository
📁 View on GitHub

👨‍💻 Author
Sumit Kumar Kamti
GitHub
LinkedIn

📄 L



