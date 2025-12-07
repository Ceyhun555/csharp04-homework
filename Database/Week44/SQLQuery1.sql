--EXISTS Examples
--Sifaris meblegi 500 manatdan cox olan musteriler.

SELECT 
*
FROM Customer AS c
WHERE EXISTS (
			SELECT o.ID 
			FROM [Order] AS O
			WHERE o.CustomerID = c.ID AND o.TotalAmount > 500)
			

SELECT * FROM [Order]

SELECT * FROM OrderDetail

SELECT * FROM Product

--Iphone15Pro olan sifarisleri qaytar

SELECT
*
FROM [Order] AS o
LEFT JOIN OrderDetail AS od  ON od.OrderID = o.ID
WHERE EXISTS (
			SELECT p.ID
			FROM Product AS p
			WHERE od.ProductID = p.ID AND ProductName = 'iPhone 15 Pro')

SELECT * FROM Product



--CASE Examples
--Total Orderi 500 aznden cox olan sifarisler ucun metn tipli sutunun elave olunmasi

SELECT 
* ,
CASE 
	WHEN TotalAmount > 500 THEN 'The TotalAmount greater than 500'
	WHEN TotalAmount = 500 THEN 'The TotalAmount is equal 500'
	ELSE  'The TotalAmount is under 500'
END AS TotalAmountText
FROM [Order]


SELECT * FROM Product


--NULL Functions example
--SELECT ProductName, UnitPrice * (UnitsInStock + ISNULL(UnitsOnOrder, 0))
--FROM Products;

SELECT 
ProductName,
Price,
StockQuantity,
Price * StockQuantity AS TotalStockPrice
FROM Product


SELECT 
ProductName,
Price,
StockQuantity,
Price * ISNULL( StockQuantity, 0) AS TotalStockPrice
FROM Product
	
UPDATE Product
SET StockQuantity = NULL 
WHERE ID = 11 

ALTER TABLE Product
ALTER COLUMN StockQuantity int NULL



ALTER TABLE Product
ADD UnitsOnOrder smallint NULL;


UPDATE Product
SET UnitsOnOrder = 0
WHERE StockQuantity = 0 AND UnitsOnOrder IS NULL;



SELECT ID, ProductName, UnitsOnOrder
FROM Product
WHERE UnitsOnOrder IS NULL;


SELECT ID, ProductName,
       ISNULL(CAST(UnitsOnOrder AS varchar), 'Not Ordered') AS UnitsOnOrderStatus
FROM Product;


SELECT * FROM Product


SELECT 
ProductName,
COALESCE(Price, 0) * (COALESCE(StockQuantity, 0) + COALESCE(UnitsOnOrder, 0)) AS TotalAmount
FROM Product




SELECT 
SUM(COALESCE(UnitsOnOrder, 0)) AS TotalUnitsOrder
FROM Product


SELECT * FROM Product 

--ORDER DETAILDE OLAN PRODUCTLARI TAPIB OLARI PRODUCT CEDVELINDE ELAVE ELEMELIYEM


SELECT
ProductID, 
SUM (Quantity) AS ProductCount
FROM OrderDetail
GROUP BY ProductID
ORDER BY ProductID

UPDATE [Product]
SET UnitsOnOrder = (
SELECT 
SUM (Quantity) AS ProductCount
FROM OrderDetail
WHERE Product.ID = OrderDetail.ProductID
GROUP BY ProductID
)


SELECT * FROM Product
SELECT * FROM OrderDetail

--Hansi prductlarin unitonorderi varsa onlarin stock quantitysi azalmalidi.