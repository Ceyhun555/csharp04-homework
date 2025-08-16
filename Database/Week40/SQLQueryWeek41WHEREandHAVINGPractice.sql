CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    Amount DECIMAL(10,2),
    Status NVARCHAR(20)
);



INSERT INTO Orders (OrderID, CustomerID, OrderDate, Amount, Status) VALUES
(1,  1, '2025-01-10', 120.50, 'Completed'),
(2,  2, '2025-01-15', 250.00, 'Completed'),
(3,  1, '2025-01-20', 300.00, 'Pending'),
(4,  3, '2025-02-01', 500.00, 'Completed'),
(5,  2, '2025-02-05', 150.00, 'Completed'),
(6,  4, '2025-02-10', 700.00, 'Pending'),
(7,  1, '2025-02-15', 200.00, 'Completed'),
(8,  5, '2025-02-20', 1000.00,'Completed');



--WHERE ile
SELECT OrderID, CustomerID, Amount, Status
FROM Orders
WHERE Status = 'Completed';



--HAVING ile
SELECT CustomerID, COUNT(*) AS CompletedOrders
FROM Orders
WHERE Status = 'Completed'    
GROUP BY CustomerID
HAVING COUNT(*) > 2;  



--WHERE ve  HAVING bir yerde
SELECT CustomerID, SUM(Amount) AS TotalAmount
FROM Orders
WHERE Status = 'Completed'
GROUP BY CustomerID
HAVING SUM(Amount) > 400;


