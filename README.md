# Study2Crack - E-Learning Platform

A beautifully designed, premium text-based e-learning platform inspired by sites like W3Schools and Coursera. Built on the modern **ASP.NET Core MVC (.NET 9)** stack with **Entity Framework Core**, giving administrators the power to dynamically manage coding courses, topics, and contact messages natively.

## 🚀 Features

* **Modern Design**: Completely custom responsive UI featuring sleek dark mode, glassmorphism, FontAwesome icons, and Bootstrap 5.
* **Public Course Viewer**: Learners can explore specific courses, read fully text-based topics, and copy rich code snippets with built-in Prism.js syntax highlighting.
* **Admin Dashboard**: A secure backend where authorized administrators can instantly create, update, and manage the hierarchy of Courses and Topics.
* **Contact Management**: An automated "Contact Us" loop serving inquiries straight from the live form directly into an internal Admin review Inbox.

## 📋 Prerequisites

To run this project on a brand new system, you must have the following installed:
1. **[.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)** (or later)
2. **SQL Server Management Studio (SSMS)** or **SQL Server Express** for the local database.

---

## 🛠️ Step-by-Step Installation Guide

### Step 1: Clone or Copy the Project
Ensure you have the entirety of the `Study2Crack` folder unzipped and placed on your desired machine. 

### Step 2: Configure the Database Connection
This application requires a SQL Server connection to store courses, topics, and incoming messages.

1. Navigate into the `ELearningPlatform` folder.
2. Open the `appsettings.json` file.
3. Locate the `DefaultConnection` string. It is currently pointing to `localhost\SQLEXPRESS03`.
4. **Important**: Change `localhost\SQLEXPRESS03` to match the exact name of your PC's local SQL Server instance (e.g., `.\SQLEXPRESS`, `localhost`, etc.) if it is different.

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Study2CrackDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

### Step 3: Run the Entity Framework Database Migration
You must generate the database tables (Courses, Topics, ContactMessages) before starting the app.

1. Open a Command Prompt or PowerShell window directly inside the `ELearningPlatform` folder.
2. If you don't already have the EF Core tools installed on this PC, run:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
3. Push the migrations to your SQL Server to officially build the database:
   ```bash
   dotnet ef database update
   ```

### Step 4: Run the Application
1. In that same terminal window, start the local Kestrel web server by typing:
   ```bash
   dotnet run
   ```
2. The terminal will indicate that the application has started. 
3. Open your web browser and navigate to: **`http://localhost:5201/`**

---

## 🔐 Administrator Access

To manage the website content, you must log in to the admin panel. 

You can click "Admin Login" in the top right corner of the website and use the hardcoded credentials found in `appsettings.json`:
* **Username**: `admin`
* **Password**: `password123`

Once logged in, you will instantly unlock access to the restricted `Admin: Courses`, `Admin: Topics`, and `Admin: Messages` navigation tabs!
