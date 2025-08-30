
# ✅ Task Manager - ASP.NET Core MVC

A simple **Task Manager** web application built with **ASP.NET Core MVC** and **SQL Server**.  
This project demonstrates CRUD operations, model binding, validation, and basic filtering in MVC.  
It is lightweight and designed for learning + portfolio purposes.

---

## 🚀 Features

- Add, Edit, Delete tasks
- Mark tasks as **Pending** or **Completed**
- Assign **priority levels** (Low, Medium, High)
- Filter tasks by **Status** and **Priority**
- Search tasks by **Title**
- Responsive Bootstrap-based UI
- Follows MVC architecture best practices

---

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core MVC 7 (or 6)
- **Frontend:** Bootstrap 5, Razor Views
- **Database:** SQL Server (LocalDB or SQL Express)
- **ORM:** Entity Framework Core
- **Language:** C#

---

## 📂 Project Structure

TaskManager/
│-- Controllers/
│ └── TasksController.cs
│-- Models/
│ └── TaskItem.cs
│-- Views/
│ └── Tasks/
│ ├── Index.cshtml # Task list + Filters
│ ├── Create.cshtml # Add task
│ ├── Edit.cshtml # Update task
│ ├── Delete.cshtml # Confirm delete
│ └── Details.cshtml # Task details
│-- Data/
│ └── ApplicationDbContext.cs
│-- wwwroot/
│ └── css, js, bootstrap assets
│-- appsettings.json
│-- Program.cs
│-- TaskManager.csproj

---

## ⚙️ Installation & Setup
1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/task-manager-mvc.git
   cd task-manager-mvc

2. **Update Database Connection**
   2.1) Open appsettings.json
   2.2) Update the connection string.
   ```bash
   "ConnectionStrings": {
   "DefaultConnection": "add your connection string here"
   }

4. Apply Migrations & Create Database
   ```bash
   dotnet ef database update

5. Run the application
   ```bash
   dotnet run




   

