USE ShoppingDB;
GO


--Exercise 1: Customer Order Summary
SELECT 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    c.Email,
    COUNT(o.ID) AS TotalOrders
FROM Customer c
LEFT JOIN [Order] o ON c.ID = o.CustomerID
GROUP BY c.FirstName, c.LastName, c.Email
ORDER BY TotalOrders DESC;


SELECT 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    c.Email,
    COUNT(o.ID) AS TotalOrders,
    SUM(o.TotalAmount) AS TotalAmount
    FROM Customer c
    LEFT JOIN [Order] o ON c.ID = o.CustomerID
    GROUP BY c.FirstName, c.LastName, c.Email
    ORDER BY TotalOrders DESC;


SELECT *FROM Customer

SELECT * FROM [Order]


--Exercise 2: Product Performance Analysis
SELECT 
    p.ProductName,
    p.Price,
    COUNT(od.ID) AS TimesOrdered
FROM Product p
LEFT JOIN OrderDetail od ON p.ID = od.ProductID
GROUP BY p.ProductName, p.Price
ORDER BY TimesOrdered DESC;


--Exercise 4: High-Value Orders
SELECT 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    c.Email,
    c.Phone,
    o.ID AS OrderID,
    o.TotalAmount,
    o.Status
FROM Customer c
INNER JOIN [Order] o ON c.ID = o.CustomerID
WHERE o.TotalAmount > 2000
ORDER BY o.TotalAmount DESC;


--Exercise 5: Product Category Popularity
SELECT 
    p.ProductName,
    COUNT(od.ID) AS TotalOrders
FROM Product p
INNER JOIN OrderDetail od ON p.ID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalOrders DESC;



--Exercise 6: Customer Purchase History
SELECT 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    p.ProductName,
    od.Quantity,
    od.UnitPrice
FROM Customer c
INNER JOIN [Order] o ON c.ID = o.CustomerID
INNER JOIN OrderDetail od ON o.ID = od.OrderID
INNER JOIN Product p ON od.ProductID = p.ID
ORDER BY c.FirstName, o.OrderDate;



--Exercise 7: Order Status Analysis
SELECT 
    c.TotalAmount,
    o.Status,
    COUNT(o.ID) AS OrderCount
FROM Customer c
INNER JOIN [Order] o ON c.ID = o.CustomerID
GROUP BY c.TotalAmount, o.Status
ORDER BY c.TotalAmount, OrderCount DESC;


--Exercise 8: Product Revenue Analysis
SELECT 
    p.ProductName,
    SUM(od.UnitPrice) AS TotalRevenue
FROM Product p
INNER JOIN OrderDetail od ON p.ID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalRevenue DESC;


--Exercise 9: Customer Loyalty Analysis
SELECT 
    c.FirstName + ' ' + c.LastName AS CustomerName,
    COUNT(o.ID) AS TotalOrders
FROM Customer c
INNER JOIN [Order] o ON c.ID = o.CustomerID
GROUP BY c.FirstName, c.LastName
HAVING COUNT(o.ID) > 1
ORDER BY TotalOrders DESC;


--Exercise 10: Brand Performance




--FOREIGN KEYLERIN ELAVE EDILMESI.

ALTER TABLE [Order]
ADD Constraint FK_Order_Customer
FOREIGN KEY(CustomerID)
REFERENCES Customer (ID)


SELECT * FROM [Order]

SELECT * FROM Customer

UPDATE [Order]
SET CustomerID = 1
WHERE CustomerID IN (4,6,7,8) 

UPDATE [Order]
SET ShipperID = 1
WHERE ShipperID IS NULL
SELECT * FROM [Order] 
WHERE ShipperID IS NULL

ALTER TABLE [Order]
ADD Constraint FK_Order_Shipper
FOREIGN KEY(ShipperID)
REFERENCES Shipper (ID)

ALTER TABLE [Order]
ALTER COLUMN ShipperID INT NOT NULL


SELECT * FROM Shipper


ALTER TABLE OrderDetail
ADD Constraint FK_OrderDetail_Product
FOREIGN KEY(ProductID)
REFERENCES [Product] (ID)

ALTER TABLE OrderDetail
ALTER COLUMN ProductID INT NOT NULL


SELECT DISTINCT
ProductID 
FROM OrderDetail 
WHERE NOT EXISTS (
SELECT 1
FROM [Product]
WHERE Product.ID = OrderDetail.ProductID
);


UPDATE OrderDetail
SET ProductID = 1
WHERE ProductID = 6


--OrderDetail cedvelinde orderID gore foreign key elave edilmesi.
