CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Country NVARCHAR(50),
    IsActive BIT
);

INSERT INTO Customers (CustomerID, FirstName, LastName, Country, IsActive) VALUES
(1, 'Aynur',  'Mammadova', 'Azerbaijan', 1),
(2, 'Elvin',  'Aliyev',    'Azerbaijan', 1),
(3, 'Nigar',  'Huseynova', 'Azerbaijan', 0),
(4, 'Rauf',   'Aliyev',    'Turkey',     1),
(5, 'Leyla',  'Karimova',  'Turkey',     1),
(6, 'Murad',  'Ibrahimov', 'Turkey',     1);


--WHERE setirlerin filtirlenmesi ucun istifade olunur
SELECT CustomerID,FirstName,LastName,Country
FROM Customers
WHERE Country = 'Azerbaijan' AND IsActive = 1;



--GROUP BY + HAVING ise qruplarin filtirlenmesi ucun istifade olunur
SELECT Country, COUNT(*) AS ActiveCustomerCount
FROM Customers
WHERE IsActive = 1
GROUP BY Country
HAVING COUNT(*) > 2;



--WHERE ve HAVING bir yerde 
SELECT Country, COUNT(*) AS ActiveCustomerCount
FROM Customers 
WHERE IsActive = 1
GROUP BY Country
HAVING COUNT(*) >= 2;


