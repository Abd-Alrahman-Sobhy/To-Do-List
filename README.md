# ✅ To-Do List App

<div align="center">

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![HTML](https://img.shields.io/badge/HTML-24%25-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS](https://img.shields.io/badge/CSS-6.5%25-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)

A clean and straightforward **To-Do List web application** built with **ASP.NET Core MVC**, featuring full task management with a responsive UI.

</div>

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Configuration](#-configuration)

---

## 🌟 Overview

This is a full-stack **To-Do List web application** built using the **ASP.NET Core MVC** pattern. It allows users to manage their daily tasks through an intuitive browser-based interface, with data persisted via Entity Framework Core and SQL Server.

---

## 🚀 Features

- ✏️ **Create** new tasks with a title and details
- 📋 **View** all tasks in a clean, organized list
- ✅ **Mark tasks as complete** to track progress
- 🗑️ **Delete** tasks when no longer needed
- 💾 **Persistent storage** — tasks are saved to a database
- 📱 **Responsive UI** built with HTML, CSS, and JavaScript

---

## 🧰 Tech Stack

| Technology | Purpose |
|---|---|
| **C#** | Backend logic |
| **ASP.NET Core MVC** | Web framework (Model-View-Controller) |
| **Entity Framework Core** | ORM & database access |
| **SQL Server** | Relational database |
| **HTML / CSS** | Views & styling |
| **JavaScript** | Frontend interactivity |
| **Razor Pages** | Server-side view rendering |

---

## 📁 Project Structure

```
To-Do-List/
├── ToDoList/                     # Main MVC project
│   ├── Controllers/              # Handle HTTP requests & route logic
│   ├── Models/                   # Task entity & view models
│   ├── Views/                    # Razor views (.cshtml files)
│   │   ├── Tasks/                # Task-related views (Index, Create, Edit, Delete)
│   │   └── Shared/               # Layout and partial views
│   ├── Data/                     # DbContext & EF Core configurations
│   ├── Migrations/               # EF Core database migrations
│   ├── wwwroot/                  # Static files (CSS, JS, images)
│   │   ├── css/
│   │   └── js/
│   ├── appsettings.json          # App configuration
│   └── Program.cs                # Entry point & middleware pipeline
└── ToDoList.sln                  # Solution file
```

---

## ⚡ Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (compatible version)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or SQL Server Express
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

**1. Clone the repository**
```bash
git clone https://github.com/Abd-Alrahman-Sobhy/To-Do-List.git
cd To-Do-List
```

**2. Restore dependencies**
```bash
dotnet restore
```

**3. Update the connection string** (see [Configuration](#-configuration))

**4. Apply database migrations**
```bash
dotnet ef database update
```

**5. Run the application**
```bash
dotnet run --project ToDoList
```

The app will be available at `https://localhost:5001` (or as shown in the terminal).

---

## ⚙️ Configuration

Update `appsettings.json` with your SQL Server connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=ToDoListDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

| Key | Description |
|---|---|
| `ConnectionStrings:DefaultConnection` | Your SQL Server connection string |

---

<div align="center">

Made with ❤️ by [Abd-Alrahman Sobhy](https://github.com/Abd-Alrahman-Sobhy)

⭐ If you find this project helpful, please consider giving it a star!

</div>
