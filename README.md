# PROG6212-POE-Part-1

# Contract Monthly Claim System (CMCS)

This project is a **Contract Monthly Claim System (CMCS)** built using **ASP.NET Core MVC** and **Entity Framework Core**. It allows **lecturers** to submit claims for approval, upload supporting documents, and track the status of their claims. **Programme Coordinators** and **Academic Managers** can verify, approve, and reject claims. 

At this stage, this project is a prototype focusing on the front-end design, with a basic database setup using **SQL Server**. 

Features

1. Lecturer Functionality:
   - Submit new claims.
   - Upload supporting documents (file upload functionality not implemented yet).
   - View all submitted claims.
   - Track the status of claims.

2. Programme Coordinator/Academic Manager Functionality:
   - Verify claims.
   - Approve or reject claims.
   - View all claims in the system.

 Technologies Used

- ASP.NET Core MVC: For building the web interface and structure.
- Entity Framework Core: For managing the database and providing an ORM for SQL Server.
- SQL Server: As the relational database for storing data.

 Database Setup

The database is set up using SQL Server. The schema includes tables for Lecturers, Claims, Administrators. The relationships between these entities are established using foreign keys.

 Database Tables

1. Lecturer
   - `LecturerId`: Primary key, unique identifier for lecturers.
   - `Name`: Lecturer's full name.
   - `Email`: Contact email for the lecturer.
   - `PhoneNumber`: Optional contact phone number.

2. Claim
   - `ClaimId`: Primary key, unique identifier for each claim.
   - `DateSubmitted`: Date the claim was submitted.
   - `Amount`: The amount being claimed.
   - `Status`: Current status of the claim (Pending, Approved, Rejected).
   - `LecturerId`: Foreign key that links to the `Lecturer` table.

3. Administrator
   - `AdminId`: Primary key, unique identifier for administrators.
   - `Name`: Administrator’s full name.
   - `Email`: Contact email for the administrator.
   - `PhoneNumber`: Optional contact phone number.
 Project Setup Instructions

 Prerequisites

- **.NET Core SDK**: Make sure you have .NET 6 or later installed on your machine.
- **SQL Server**: Ensure you have SQL Server and SQL Server Management Studio (SSMS) installed.
- **Entity Framework Core Tools**: Install via NuGet if needed.

