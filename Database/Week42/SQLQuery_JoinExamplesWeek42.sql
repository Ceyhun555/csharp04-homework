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
INNER JOIN [Order] ON Customer.ID = [Order].CustomerID




SELECT 
	Customer.*,
	[Order].*
FROM Customer
INNER JOIN [Order] ON Customer.ID = [Order].CustomerID




SELECT 
	*
FROM Customer
INNER JOIN [Order] ON Customer.ID = [Order].CustomerID