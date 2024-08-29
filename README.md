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
### 7. **Working with ASP.NET Core (Optional)**
   
### 8. **Use Configuration Files (Optional)**
   - Use `appsettings.json` for configuration settings. You can access these configurations using the `IConfiguration` interface.

### 9. **Debugging**
   - In Visual Studio, you can start debugging by pressing `F5`.
   - In Visual Studio Code, use the Debug panel and ensure your `.vscode/launch.json` is set up correctly.

### 10. **Publishing the Application**
   

### 11. **Running Tests (Optional)**
 
### 12. **Version Control with Git**
 
### 13. **Dockerize Your .NET Core Application (Optional)**
  
### 14. **Deploying Your Application (Optional)**
   - You can deploy your .NET Core application to various cloud services like Azure, AWS, or Google Cloud, or host it on a local server.

### **Blog Management System WebAPI**

### This project was generated with .net Core 8.0

This repository contains the code for a **Blog Management System WebAPI**, which allows users to create, manage, and interact with blog posts. The WebAPI is built using .NET Core and follows RESTful principles, ensuring a scalable and maintainable architecture. 

### **Features:**

1. **Blog Post Management:**
   - **Create:** Users can create new blog posts with titles, content, and optional tags.
   - **Read:** Fetch a list of all blog posts or a specific post by its ID.
   - **Update:** Edit the title, content, or tags of an existing blog post.
   - **Delete:** Remove a blog post from the system.

2. **Commenting System:**
   - Users can add comments to blog posts.
   - Comments can be retrieved, edited, or deleted.

3. **Filtering:**
   - Filter for blog posts by keywords in id.
     
 7. **Error Handling and Logging:**
   - Consistent error handling across all endpoints.
   - Logging of errors and key events for monitoring and troubleshooting.

### **Technologies Used:**
- **.NET Core:** The primary framework for building the WebAPI.
- **Swagger:** For API documentation and testing.

### **Getting Started:**

1. **Run the Application:**  
   - The API will be accessible at `https://localhost:7000` or a configured port.

2. **Access API Documentation:**
   - Visit `https://localhost:7000/swagger` to view and interact with the API documentation using Swagger UI.


### ** Data Storage:**
  Utilize a local JSON file as a mock database.
[{"Id":1,"BlogDesc":"sample data test11","UserName":"user1","CreatedDate":"27-08-2024"},{"Id":2,"BlogDesc":"sample data test 2","UserName":"user1","CreatedDate":"27-08-2024"}]

# Data Model: 
  Id: Auto-incrementing integer -->Post IDs must be unique
  Username: String, required
  DateCreated: Date, required
  BlogDesc: String, required


