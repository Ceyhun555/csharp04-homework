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