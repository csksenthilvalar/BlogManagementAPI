# BlogManagement

### 1. **Install .NET Core SDK**
   - Visit the [.NET Core download page](https://dotnet.microsoft.com/download/dotnet).
   - Download the latest .NET Core SDK installer for your operating system (Windows, macOS, Linux).
   - Run the installer and follow the installation instructions.

### 2. **Verify the Installation**
   - Open a terminal or command prompt.
   - Run the following command to check if .NET Core is installed correctly:
     ```bash
     dotnet --version
     ```
   - You should see the version number of the .NET Core SDK you installed.

### 3. **Set Up Your Development Environment**
   - **IDE Choice:** 
     - **Visual Studio**: For Windows, Visual Studio is a popular choice. Make sure to select the ".NET Core cross-platform development" workload during installation.
     - **Visual Studio Code**: Available for Windows, macOS, and Linux. You’ll need the C# extension from the Visual Studio Marketplace.
     - **JetBrains Rider**: A cross-platform IDE that supports .NET Core development.

### 4. **Create a New .NET Core Project**
### 5. **Build and Run the Project**
### 6. **Managing Dependencies with NuGet**
This project was generated with .net Core 8.0

This repository contains the code for a Blog Management System WebAPI, which allows users to create and manage blog posts. 

# Data Storage:
  Utilize a local JSON file as a mock database.
[{"Id":1,"BlogDesc":"sample data test11","UserName":"user1","CreatedDate":"27-08-2024"},{"Id":2,"BlogDesc":"sample data test 2","UserName":"user1","CreatedDate":"27-08-2024"}]

# Data Model: 
  Id: Auto-incrementing integer -->Post IDs must be unique
  Username: String, required
  DateCreated: Date, required
  BlogDesc: String, required


