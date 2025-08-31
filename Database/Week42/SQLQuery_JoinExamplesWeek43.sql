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



