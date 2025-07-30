To create the required SQL Server database for this API, run the following script in SSMS:


```sql
CREATE DATABASE StudentManagement;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Email NVARCHAR(100),
    Department NVARCHAR(100) NULL
);
