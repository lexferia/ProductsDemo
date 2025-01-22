# Products Demo WebAPI

Welcome to the **Products Demo WebAPI**! This project serves as a ready-made template that demonstrates how to implement pagination using SQL Server, .NET 6, and Docker. It is perfect for experiments, proofs of concept (PoCs), or as a foundation for building your own pagination-based applications.

---

## 🚀 Purpose

The purpose of this demo project is to provide a **quick-start template** for experimenting.
Whether you're exploring new concepts or building a PoC, this project will give you an easy-to-use, fully functional base.

---

## 🛠 Tools Needed

To set up and run this project, you'll need the following tools installed on your system:

1. **[Visual Studio](https://visualstudio.microsoft.com/)**  (Latest)
   - The recommended IDE for developing and running .NET applications.

2. **[.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)**  
   - The project is built on .NET 6, so you’ll need the SDK to build and run the solution.

3. **[SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)**  
   - For interacting with the SQL Server instance, running queries, and managing databases.

4. **[Docker Desktop](https://www.docker.com/products/docker-desktop)**  
   - This demo leverages Docker to quickly spin up a SQL Server instance without the need for a local installation.

---

## 📋 Instructions

Follow the steps below to get your environment set up and the demo project running:

### 1. Install Docker Desktop

- Download and install Docker Desktop from [here](https://www.docker.com/products/docker-desktop).
- After installation, ensure that Docker is running by checking the Docker icon in the system tray.

### 2. Clone the Repository

- Clone this repository to your local machine using the following command:

```bash
git clone https://github.com/lexferia/ProductsDemo.git
```
### 3. Open the Project Solution

- Open Visual Studio and load the `ProductsDemo` solution.

### 4. Run the Project Using Docker Compose

- In Visual Studio, right-click on the solution in the Solution Explorer.
- Right-click on the `docker-compose` project in the Solution Explorer.
- Select `Set as Startup Project`.
- Right-click again and Select `Compose Up` to start the services defined in the `docker-compose.yml` file or you could just click the run :arrow_forward:.

## Connect the Docker SQL Server to SQL Server Management Studio (SSMS)

### 1. Launch SQL Server Management Studio (SSMS).
### 2. Connect to your local Docker SQL Server using the following connection details:
- Server Name: localhost
- Authentication: SQL Server Authentication
- Login: sa
- Password: The password you set in the `docker-compose.yml` file.
### 3. After successfully connecting, you can manage your databases, run queries, and more.

---

🚀 You're Ready!
You’ve now successfully set up the Products Demo WebAPI Project! You can start the project, test the API and experiment with different configurations.
Enjoy! 🎉