CREATE DATABASE ShoppingDB;
USE ShoppingDB;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(255)
    );

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);


CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);


CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Customers (FullName, Email, Phone, Address)
VAlUES 
(N'Ceyhun Ismayilov', N'ceyhun.m@gmail.com', N'+994515281876', N'Baki,Azerbaycan'),
(N'Resad Kerimov', N'resad.kerimov@mail.ru', N'+994555724672', N'Samaxi,Azerbaycan'),
(N'Adil Memmedov', N'adil23@example.com', N'+994702348976' N'Gence,Azerbaycan');


INSERT INTO Products (ProductName, Price, Stock)
VALUES 
(N'Notebook Lenovo', 1200.00, 10),
(N'Mobil Telefon Samsung', 800.00, 15),
(N'Qulaqlıq JBL', 150.00, 30);


INSERT INTO Orders (CustomerID)
VALUES (1), (2);


INSERT INTO OrderDetails (OrderID, ProductID, Quantity)
VALUES
(1, 1, 1),  -- Order 1: 1x Notebook
(1, 3, 2),  -- Order 1: 2x Qulaqlıq
(2, 2, 1);  -- Order 2: 1x Mobil Telefon

SELECT * FROM Orders;

SELECT * FROM Customers;

INSERT INTO Customers (FirstName, LastName, Email,Phone,Address)
VALUES (N'Ceyhun',N'Ismayilov',N'ceyhun.m@gmail.com',N'+994515281876',N'Baki');

INSERT INTO Customers 
(FirstName, LastName, Email,Phone,Address)
VALUES 
(N'Resad',N'Kerimov',N'resad.n@mail.ru',N'+994557824536',N'Baki'),
(N'Adil',N'Memmedov',N'adil.n@mail.ru',N'+994557824536',N'Baki'),
(N'Rehim',N'Eliyev',N'rehim.n@mail.ru',N'+994557824536',N'Baki');


SELECT * FROM Products;

SELECT * FROM Orders;

SELECT * FROM Customers;

SELECT *FROM OrderDetails;
INSERT INTO Orders
(CustomerID,OrderDate,TotalAmount)
VALUES
(1,'2025-07-19 12:44',150)

INSERT INTO OrderDetails
(OrderID,ProductID,Quantity,UnitPrice)
VALUES 
(2,3,30,150),
(2,2,15,800),
(2,1,10,1200);

--Orderin amountu update edilecek.

SELECT * FROM Customers;
SELECT * FROM Products;

INSERT INTO Orders
(CustomerID,OrderDate,TotalAmount)
VALUES
(2,'2025-07-19 12:54',800),
(3, CURRENT_TIMESTAMP, 150),
(4, CURRENT_TIMESTAMP, 1200);

SELECT * FROM OrderDetails;

SELECT * FROM Orders;

SELECT * FROM Products;

INSERT INTO OrderDetails
(OrderID,ProductID,Quantity,UnitPrice)
VALUES 
(3,2,1,800),
(5,1,1,1200),
(4,3,1,150);

SELECT * FROM Orders;
SELECT * FROM OrderDetails
WHERE OrderID = 2;



--update

UPDATE OrderDetails
SET Quantity = 1 
WHERE OrderID = 2;

--product id si sehv olan order detailler ucun ele bir sert vermeliyemki duzgun id ni set ede bilim
UPDATE OrderDetails
SET ProductID = 4
WHERE OrderDetailID = 6 OR OrderDetailID = 8;

UPDATE OrderDetails
SET ProductID =  4
WHERE ProductID =  1;

UPDATE OrderDetails
SET ProductID = 4
WHERE OrderDetailID IN (6,8);

UPDATE Orders
SET TotalAmount = 2150
WHERE OrderID = 2;

SELECT * FROM Products;
SELECT * FROM OrderDetails;
--3,2,4 -- 2 eded satis olub stocku 2 vahid azaltmaliyam .
UPDATE Products
SET Stock = Stock - 2
WHERE ProductID IN (3,2,4);