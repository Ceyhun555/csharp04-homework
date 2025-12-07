--Joins 

SELECT * FROM Customer;

SELECT * FROM [Order];


--Joinlerin umumi mentiqinde 2 ve daha artiq cedveli birlesdirerek datasini getirmekdi.
--Bu zaman cedveller arasinda elaqeni temin eden sutun olmalidi.
--Order ve Customers cedvelleri arasindaki elaqe Order cedvelindeki CustomerID uzerinden gedir.
--Order ve Customer cedveli arasinda one to many relationship var. yeni 1 in coxa musterinin sifarisleri menasini verir.
--Burda qeyd edilen 1 musteri cox ise onun sifarisleridi.
--Asagidaki numunede InnerJoin vasitesile iki cedveli merg ederek  datasini geri qaytardig.


SELECT 
	Customer.FirstName,
	Customer.LastName,
	[Order].ID,
	[Order].OrderDate,
	[Order].TotalAmount,
	[Order].Status
FROM Customer
INNER JOIN [Order] 
ON Customer.ID = [Order].CustomerID




SELECT 
	Customer.*,
	[Order].*
FROM Customer
INNER JOIN [Order] 
ON Customer.ID = [Order].CustomerID




SELECT 
	*
FROM Customer
INNER JOIN [Order] 
ON Customer.ID = [Order].CustomerID



SELECT 
	*
FROM Customer
 JOIN [Order] 
ON Customer.ID = [Order].CustomerID


--JOIN Three Tables

CREATE TABLE Shipper(
	ID INT PRIMARY KEY,
	Name NVARCHAR(50)
	)


INSERT INTO Shipper(ID, Name)VALUES
(1,'Expargo'),
(2,'Starex');


ALTER TABLE [Order] 
ADD ShipperID INT;


SELECT * FROM [Order];


UPDATE [Order] 
SET ShipperID = 2
WHERE ID > 15;





SELECT 
	Customer.FirstName,
	Customer.LastName,
	[Order].ID,
	[Order].OrderDate,
	[Order].TotalAmount,
	[Order].Status,
	Shipper.Name
FROM Customer
INNER JOIN [Order] 
ON Customer.ID = [Order].CustomerID
INNER JOIN Shipper
ON [Order].ShipperID = Shipper.ID




