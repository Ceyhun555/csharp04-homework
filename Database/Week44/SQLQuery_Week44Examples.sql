--Week44 practice

SELECT * FROM Customer

SELECT * FROM [Order]

SELECT * FROM OrderDetail

SELECT * FROM Product

-- Exercise 1: EXISTS Practice 
-- Write a query to find all products that have been ordered at least once
SELECT DISTINCT p.ID, p.ProductName 
FROM Product p 
WHERE EXISTS ( 
SELECT 1
FROM OrderDetail od 
WHERE od.ProductID = p.ID
);


-- Exercise 2: NOT EXISTS Practice
SELECT c.ID,c.FirstName 
FROM Customer c 
WHERE NOT EXISTS ( 
SELECT 1 
FROM [Order] o 
WHERE o.CustomerID = c.ID 
);


-- Exercise 3: ANY Practice
SELECT p.ID, p.ProductName, p.Price 
FROM Product p 
WHERE p.Price > ALL ( 
SELECT Price
FROM Product	
WHERE StockQuantity = 20
);



-- Exercise 5: CASE Practice
SELECT o.ID, o.TotalAmount, 
CASE WHEN o.TotalAmount < 1000 THEN 'Small' 
WHEN o.TotalAmount BETWEEN 1000 AND 3000 THEN 'Medium' 
ELSE 'Large' END AS OrderSize 
FROM [Order] o;



-- Exercise 6: NULL Functions Practice
SELECT c.ID, c.FirstName,
	   ISNULL(c.Phone, 'Not Provided') AS Phone 
FROM Customer c;




-- Exercise 7: COALESCE Practice
SELECT c.ID, c.FirstName, 
	   COALESCE(c.Phone, c.Email, 'No Contact') AS BestContact 
FROM Customer c;





-- Exercise 8: Complex CASE Practice
SELECT c.ID, c.FirstName, 
	   CASE 
	   WHEN SUM(o.TotalAmount) > 3000 THEN 'VIP' 
	   WHEN SUM(o.TotalAmount) BETWEEN 1000 AND 3000 THEN 'Gold'
	   WHEN SUM(o.TotalAmount) BETWEEN 500 AND 1000 THEN 'Silver'
	   ELSE 'Bronze' END AS CustomerCategory
FROM Customer c 
LEFT JOIN [Order] o ON c.ID = o.CustomerID 
GROUP BY c.ID, c.FirstName;




-- Exercise 9: EXISTS with Conditions
SELECT c.ID, c.FirstName
FROM Customer c 
WHERE EXISTS ( 
SELECT 1
FROM [Order] o 
WHERE o.CustomerID = c.ID AND o.OrderDate >= DATEADD(DAY, 30, GETDATE()) 
);




-- Exercise 10: Combined Practice
SELECT p.ID, p.ProductName, 
	   CASE 
			WHEN COUNT(od.OrderID) > 5 THEN 'Best Seller' 
			WHEN COUNT(od.OrderID) BETWEEN 2 AND 5 THEN 'Popular'
			WHEN COUNT(od.OrderID) = 1 THEN 'Rare' ELSE 'Never Ordered' 
	   END AS Performance 
FROM Product p 
LEFT JOIN OrderDetail od ON p.ID = od.ProductID 
GROUP BY p.ID, p.ProductName;





-- Advanced Exercise 1: Customer Segmentation 
-- Segment customers into categories based on spending, activity, and contact info
SELECT c.ID, c.FirstName, 
COALESCE(c.Phone, c.Email, 'No Contact') AS ContactMethod, 
CASE 
WHEN NOT EXISTS (SELECT 1 FROM [Order] o WHERE o.CustomerID = c.ID) 
THEN 'Inactive - 0' 
WHEN (SELECT SUM(o.TotalAmount) FROM [Order] o WHERE o.CustomerID = c.ID) > 5000 
THEN 'Platinum - >5000' 
WHEN (SELECT SUM(o.TotalAmount) FROM [Order] o WHERE o.CustomerID = c.ID) BETWEEN 2000 AND 5000 
THEN 'Gold - 2000 - 5000'
WHEN (SELECT SUM(o.TotalAmount) FROM [Order] o WHERE o.CustomerID = c.ID) BETWEEN 500 AND 2000
THEN 'Silver - 500 - 2000' 
ELSE 'Bronze - 0 - 500'
END AS Segment,
(SELECT SUM(o.TotalAmount) FROM [Order] o WHERE o.CustomerID = c.ID) AS TotalOrderAmount
FROM Customer c;




-- Advanced Exercise 2: Product Analysis 




-- Advanced Exercise 3: Order Analysis
-- Detailed categorization of orders with NULL handling
SELECT o.ID, o.CustomerID, ISNULL(o.TotalAmount, 0) AS SafeAmount, 
	CASE 
		WHEN o.TotalAmount IS NULL THEN 'Pending' 
		WHEN o.TotalAmount < 1000 THEN 'Small' 
		WHEN o.TotalAmount BETWEEN 1000 AND 3000 THEN 'Medium'
		WHEN o.TotalAmount > 3000 THEN 'Large' END AS OrderCategory, 
	
FROM [Order] o;





-- Advanced Exercise 4: Inventory Management 
-- Identify stock alerts and product demand status
SELECT p.ID, p.ProductName, p.StockQuantity, 
	CASE 
		WHEN p.StockQuantity = 0 THEN 'Out of Stock' 
		WHEN p.StockQuantity < 10 THEN 'Low Stock' 
	ELSE 'In Stock' END AS StockStatus, 
	CASE 
		WHEN EXISTS (
SELECT 1 
FROM OrderDetail od WHERE od.ProductID = p.ID) 
THEN 'Has Demand' 
	ELSE 'No Demand' END AS DemandStatus 
FROM Product p;




-- Advanced Exercise 5: Business Intelligence 
-- Comprehensive performance report combining multiple concepts
