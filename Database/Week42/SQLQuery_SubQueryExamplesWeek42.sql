USE SubQueryExamples;

CREATE TABLE Employees(
	ID INT PRIMARY KEY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	Position NVARCHAR(50),
	Salary INT 
	);


INSERT INTO Employees (ID, FirstName, LastName,Position, Salary)VALUES
(1,'Ceyhun', 'Ismayilov', 'Developer', 1200),
(2, 'Aynur', 'Memmedov', 'IT', 1500),
(3, 'Resad', 'Kerimov', 'Devops', 1000),
(4, 'Lale', 'Ehmedli', 'Junior Developer', 800),
(5, 'Rehim', 'Huseynli', 'Senior Developer', 2000),
(6, 'Murad', 'Salmanli', 'Product Owner' , 1400),
(7, 'Rasim', 'Eliyev', 'Project Manager', 1600),
(8, 'Adil', 'Qasimov', 'Business Analist', 2500),
(9, 'Lamiye', 'Memmedli', 'DBA', 1100),
(10, 'Nurcan', 'Seyidov', 'IT Recuiter', 2200);

--Departament cedveli yaradilacag. 

--Employe cedveline DepartamentID sutunu elave olunmalidi.

--Employe cedveline DepartamentID sutunu elave olundugdan sonra Employe cedvelindeki datalar update olunmalidir, yeni iscilere DepartamentID si set edilecek.


--This SQL code snippet demonstrates the use of a scalar subquery to compare each employee's salary to the average salary of all employees. Here's a breakdown:
--SELECT employee_name, salary, (SELECT AVG(salary) FROM employees) AS average_salary: This part selects the employee's name and salary from the employees table.
--It also includes a scalar subquery (SELECT AVG(salary) FROM employees) that calculates the average salary of all employees and labels it as average_salary.
--FROM employees: Specifies that the data is being selected from the employees table.
--WHERE salary &gt; (SELECT AVG(salary) FROM employees): Filters the results to only include employees whose salary is greater than the average salary. Note that &gt; 
--is an HTML entity for the greater-than symbol (>).
--Overall, this code aims to list all employees whose salaries are above the average salary, along with their salaries and the average salary for reference.


SELECT 
	ID,
	FirstName,
	LastName,
	Position,
	Salary,
	(SELECT AVG(Salary) FROM Employees) AS SalaryAVG
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees)


ALTER TABLE Employees 
ADD Department VARCHAR(50);

ALTER TABLE Employees
ADD HireDate DATE;

ALTER TABLE Employees
ADD Email VARCHAR(100)


CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100),
    Location VARCHAR(100)
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY,
    ProjectName VARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    Budget DECIMAL(12,2)
);		

TRUNCATE TABLE Employees;

INSERT INTO Employees(ID, FirstName, LastName, Email, HireDate, Department, Salary)VALUES
(1,'Ceyhun', 'Ismayilov', 'ceyhun.ismayilov@email.com', '2021-8-20', 'Developer', 1200),
(2, 'Aynur', 'Memmedov', 'aynur.memmedov@email.com', '2020-5-15', 'IT', 1500),
(3, 'Resad', 'Kerimov', 'resad.kerimov@email.com', '2022-3-19', 'Devops', 1000),
(4, 'Lale', 'Ehmedli', 'lale.ehmedli@email.com', '2024-7-25', 'Junior Developer', 800),
(5, 'Rehim', 'Huseynli', 'rehim.huseynli@email.com', '2018-10-30', 'Senior Developer', 2000),
(6, 'Murad', 'Salmanli', 'murad.salmanli@email.com', '2020-4-14', 'Product Owner' , 1400),
(7, 'Rasim', 'Eliyev', 'rasim.eliyev@email.com', '2019-6-28', 'Project Manager', 1600),
(8, 'Adil', 'Qasimov', 'adil.qasimov@email.com', '2021-2-11', 'Business Analist', 2500),
(9, 'Lamiye', 'Memmedli', 'lamiye.memmedli@email.com', '2017-9-17', 'DBA', 1100),
(10, 'Nurcan', 'Seyidov', 'nurcan.seyidov@email.com', '2022-1-20', 'IT Recuiter', 2200);


INSERT INTO Departments VALUES
(1, 'Dost Agentliyi', 'Building A, Floor 3'),
(2, 'Yelo-Bank', 'Building B, Floor 1'),
(3, 'ATL-Tech', 'Building A, Floor 2'),
(4, 'Anderson LLC', 'Building C, Floor 1'),
(5, 'Hello Digital', 'Building D, Floor 4'),
(6, 'Afea Group', 'Building A, Floor 2'),
(7, 'PASHA Real Estate', 'Building C, Floor 5'),
(8, 'Baku Shipyard LLC', 'Building D, Floor 3'),
(9, 'BANK OF BAKU', 'Bulding B, Floor 2'),
(10, 'Unibank ASC', 'Building C, Floor 5');

TRUNCATE TABLE CompanyProjects;

INSERT INTO CompanyProjects(ProjectID, ProjectName, StartDate, EndDate, Budget) VALUES
(1, 'HR Management System', '2021-01-15', '2021-09-30', 25000),
(2, 'E-Commerce Platform', '2020-06-10', '2021-02-20', 40000),
(3, 'Cloud Migration', '2022-04-01', '2022-12-15', 30000),
(4, 'Mobile Banking App', '2024-08-01', '2025-01-31', 18000),
(5, 'AI Chatbot', '2019-11-05', '2020-07-30', 50000),
(6, 'ERP Implementation', '2020-05-01', '2021-04-30', 35000),
(7, 'Agile Transformation', '2019-07-15', '2020-03-20', 20000),
(8, 'Business Intelligence Dashboard', '2021-03-01', '2021-12-20', 45000),
(9, 'Database Optimization', '2017-10-01', '2018-05-30', 15000),
(10, 'Talent Acquisition System', '2022-02-10', '2022-09-25', 28000);

-- EXERCISE 1: ALTER TABLE

-- Task 1: Add a 'Bonus' column to Employees table with DECIMAL(8,2) data type
ALTER TABLE Employees
ADD Bonus DECIMAL(8,2);


-- Task 2: Add 'ProjectManager' and 'TeamSize' columns to CompanyProjects table
ALTER TABLE CompanyProjects
ADD ProjectManager VARCHAR(100),
    TeamSize INT;

-- Task 3: Change the data type of Budget column to MONEY in CompanyProjects table
ALTER TABLE CompanyProjects
ALTER COLUMN Budget MONEY;


-- Task 4: Add a 'Description' column with default value
ALTER TABLE CompanyProjects
ADD Description VARCHAR(500) DEFAULT 'No description available';



SELECT * FROM Employees;



--EXERCISE 2: SUBQUERIES.

-- Task 1: Find employees who earn more than the company average salary
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees);


-- Task 2: Find departments that have employees with salary above 1400
SELECT DISTINCT Department
FROM Employees
WHERE Salary > 1400;


-- Task 3: Update all IT department employees to have 15% salary increase
UPDATE Employees
SET Salary = Salary * 1.15
WHERE Department = 'IT';


-- Task 4: Find employees who work in the same department as 'Ceyhun Ismayilov'
SELECT FirstName, LastName, Department
FROM Employees
WHERE Department = (SELECT Department FROM Employees WHERE FirstName = 'Ceyhun' AND LastName = 'Ismayilov');


-- Task 5: Create a table with employees who have salary in top 3
CREATE TABLE Top3Salaries (
    ID INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Salary DECIMAL(10,2)
);

INSERT INTO Top3Salaries
SELECT ID, FirstName, LastName, Salary
FROM Employees
WHERE Salary IN (
    SELECT DISTINCT TOP 3 Salary
    FROM Employees
    ORDER BY Salary DESC
);



--ADVANCED EXERCISES

-- Task 6: Find the second highest salary
SELECT MAX(Salary) AS SecondHighestSalary
FROM Employees
WHERE Salary < (SELECT MAX(Salary) FROM Employees);


-- Task 7: Find employees who earn more than the average salary of their department
SELECT e.FirstName, e.LastName, e.Salary, e.Department
FROM Employees e
WHERE e.Salary > (
    SELECT AVG(Salary) 
    FROM Employees e2
    WHERE e2.Department = e.Department
);


-- Task 8: Update project budgets to be 10% higher than the average budget
UPDATE CompanyProjects
SET Budget = (SELECT AVG(Budget) * 1.1 FROM CompanyProjects);


-- Task 9: Find departments that have more than 2 employees
SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY Department
HAVING COUNT(*) > 2;


-- Task 10: Create summary table with department statistics
CREATE TABLE DepartmentSummary (
    DepartmentName VARCHAR(100),
    EmployeeCount INT,
    AvgSalary DECIMAL(10,2),
    MaxSalary DECIMAL(10,2),
    MinSalary DECIMAL(10,2)
);


INSERT INTO DepartmentSummary
SELECT 
    Department,
    COUNT(*),
    AVG(Salary),
    MAX(Salary),
    MIN(Salary)
FROM Employees
GROUP BY Department;


--ADDITIONAL CHALLENGE EXERCISES

-- Challenge 1: Employee with highest salary in each department
SELECT e1.FirstName, e1.LastName, e1.Salary, e1.Department
FROM Employees e1
WHERE e1.Salary = (
    SELECT MAX(e2.Salary) 
    FROM Employees e2
    WHERE e2.Department = e1.Department
);



-- Challenge 2: Departments where average salary > company average
SELECT Department, AVG(Salary) AS AvgDeptSalary
FROM Employees
GROUP BY Department
HAVING AVG(Salary) > (SELECT AVG(Salary) FROM Employees);


-- Challenge 3: Update employee salaries to match highest in their department
UPDATE Employees
SET Salary = (
    SELECT MAX(e2.Salary)
    FROM Employees e2
    WHERE e2.Department = Employees.Department
);


-- Challenge 4: Employees with tenure longer than company average
SELECT FirstName, LastName, HireDate
FROM Employees
WHERE DATEDIFF(YEAR, HireDate, GETDATE()) >
      (SELECT AVG(DATEDIFF(YEAR, HireDate, GETDATE())) FROM Employees);




-- Challenge 5: Comprehensive employee report with rankings
SELECT 
    e.FirstName + ' ' + e.LastName AS EmployeeName,
    e.Salary,
    e.Department,
    RANK() OVER (PARTITION BY e.Department ORDER BY e.Salary DESC) AS DeptRank,
    RANK() OVER (ORDER BY e.Salary DESC) AS CompanyRank,
    dept_stats.AvgSalary AS DeptAvgSalary,
    (SELECT AVG(Salary) FROM Employees) AS CompanyAvgSalary
FROM Employees e
JOIN (
    SELECT Department, AVG(Salary) AS AvgSalary
    FROM Employees
    GROUP BY Department
) dept_stats ON e.Department = dept_stats.Department;
