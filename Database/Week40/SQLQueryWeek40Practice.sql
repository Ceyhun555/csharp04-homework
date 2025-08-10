USE ShoppingDB;
GO

CREATE TABLE Customer (
    ID INT IDENTITY(1,1) PRIMARY KEY,         
    FirstName NVARCHAR(50) NOT NULL,           
    LastName NVARCHAR(50) NOT NULL,            
    Email NVARCHAR(100) UNIQUE NOT NULL,      
    Phone NVARCHAR(20),                        
    Address NVARCHAR(200),                    
    City NVARCHAR(50),        
    );


    CREATE TABLE Product (
    ID INT IDENTITY(1,1) PRIMARY KEY,          
    ProductName NVARCHAR(100) NOT NULL,       
    Description NVARCHAR(500),                
    Price DECIMAL(10,2) NOT NULL,             
    StockQuantity INT NOT NULL DEFAULT 0, 
    );


    CREATE TABLE [Order] (
    ID INT IDENTITY(1,1) PRIMARY KEY,         
    CustomerID INT NOT NULL,                   
    OrderDate DATETIME DEFAULT GETDATE(),      
    TotalAmount DECIMAL(10,2) NOT NULL DEFAULT 0,
    );



    CREATE TABLE OrderDetail (
    ID INT IDENTITY(1,1) PRIMARY KEY,          
    OrderID INT NOT NULL,                       
    ProductID INT NOT NULL,                     
    Quantity INT NOT NULL,                      
    UnitPrice DECIMAL(10,2) NOT NULL
    );



    INSERT INTO Customer (FirstName, LastName, Email, Phone, Address) VALUES
    (N'Ceyhun', N'Ismayilov', N'ceyhun.ismayilov@gmail.com', N'+994515281876', N'Baku'),
    (N'Resad', N'kerimov', N'resad.kerimovgmail.com', N'+994555789045', N'Sumqayit'),
    (N'Adil', N'Qedimov', N'adil.qedimov@gmail.com', N'+994509047822', N'Ganjha'),
    (N'Aynur', N'Memmedov', N'aynur.memmedov@gmail.com', N'+994777606660', N'Quba'),
    (N'Lale', N'Ehmedli', N'lale.ehmedli@gmail.com', N'+994706545539', N'Baku');

    SELECT * FROM Customer;

    SELECT * FROM Product;

    INSERT INTO Product (ProductName, Description, Price, StockQuantity) VALUES
    ('iPhone 16 Pro', 'Latest Apple smartphone with advanced features', 2999.99, 50),
    ('Samsung Galaxy S23 Ultra', 'Android flagship smartphone', 1899.99, 45),
    ('Lenovo ThinkPad', 'Lightweight laptop for professionals', 3999.99, 30),
    ('Iphone Airpods', 'High quality sound', 999.99, 25),
    ('Nike Air Max', 'Comfortable running shoes', 299.99, 100),
    ('Adidas Yezzy', 'Comfortable daily shoes', 399.99, 80),
    ('Adidas soccer ball', 'Professional football ball', 499.99, 60),
    ('Canon EOS R6', 'Professional mirrorless camera', 3499.99, 20);

    SELECT * FROM Customer;
    SELECT * FROM Product;

    INSERT INTO [Order] ( CustomerID, OrderDate, TotalAmount) VALUES
    (1,'2025-07-24 17:50', 2999.99),
    (2,'2025-07-24 17:55', 1899.99),
    (3,'2025-07-25 14:00', 3999.99),
    (4, CURRENT_TIMESTAMP, 999.99),
    (5, CURRENT_TIMESTAMP, 299.99),
    (6, CURRENT_TIMESTAMP, 399.99),
    (7, CURRENT_TIMESTAMP, 499.99),
    (8,CURRENT_TIMESTAMP, 3499.99);


    INSERT INTO OrderDetail (OrderID, ProductID, Quantity, UnitPrice) VALUES
    (1,1,1,2999.99),
    (2,2,2,1899.99),
    (3,3,3,3999.99),
    (4,4,4,999.99),
    (5,5,5,299.99),
    (6,6,6,399.99),
    (7,7,7,499.99),
    (8,8,8,3499.99);

    SELECT * FROM Customer
    WHERE Email = 'ceyhun.ismayilov@gmail.com';


    UPDATE Customer
    SET Phone = '+994519311877'
    WHERE Email  = 'ceyhun.ismayilov@gmail.com';

    --Order cedvelinde  orderdate sutunu dateTime tipinden oldugundan yeni tarix ve saat deyeri saxladigina gore asagidaki filtirasiya 
    --netice vermir.
    SELECT * FROM [Order]
    WHERE OrderDate = '2025-07-27';

    --Orderdate sutununu DATE tipine cast edib duzgun netice ala bilerik.
    SELECT * FROM [Order]
    WHERE CAST(OrderDate AS DATE) = '2025-07-27';

    --1 gunluk interval ilede axtaris edib duzgun netice ala bilerik.
    SELECT * FROM [Order]
    WHERE OrderDate >= '2025-07-27 00:00:00' 
    AND OrderDate < '2025-07-28 00:00:00';

    --Tarix ve saata gore filtirasiya asagidaki kimi hem tarix hemde saat qeyd olunmagla aparila biler.
    SELECT * FROM [Order]
    WHERE OrderDate = '2025-07-27 10:38:14.220';

    --her hansisa update zamani updateden evvel select statementinde filtir etdiyimiz sutunun uniq olmasina diqqet etmeliyik.


    --Tarixe gore filtirasiya edib update eden zaman bu tarixe aid butun datalari update edeceyimiz ucun bu script sehvdi.
    --UPDATE [Order]
    --SET OrderDate = '2025-07-27'
    --WHERE Orderdate = '2025-07-24';

    --Update emeliyyatindan evvel update etmek istediyimiz orderi ID sine gore yoxlamaliyig
    --ID ne gore ona gore yoxlayirigki spesific bir order uzerinde emeliyyat aparmag isteyirik.
    SELECT * FROM [Order]
    WHERE ID = 2;

    UPDATE [Order]
    SET OrderDate = '2025-07-27'
    WHERE ID = 2;

    --Burada tekrarlanan meulmat ola biler deye duzgun islemiye biler.
    UPDATE Product
    SET StockQuantity = StockQuantity - 1
    WHERE ProductName = 'Samsung Galaxy S24';

    --Onceden update edeceyimiz datani deqiqlesdirmek lazimdi sonra ise update etmek lazimdi.
    SELECT * FROM Product
    WHERE ID = 2;

    UPDATE Product
    SET StockQuantity = StockQuantity - 1
    WHERE ID = 2;






    --Distinct her hansisa bir sutuna gore tekrarlanan melumat varsa onu duplikati olmadan geri qaytarir.
    SELECT DISTINCT ProductName  FROM Product;
      
    --Count cedvelde olan setir sayini geri qaytarir.Icerisine verilen ulduz performans itkisine sebeb ola biler.
    SELECT COUNT(*) FROM Product;

    SELECT COUNT(1) FROM Product;

    SELECT * FROM Customer;

    SELECT * FROM Product;

    SELECT * FROM [Order];

    SELECT * FROM OrderDetail;


    Select *FROM Customer;
    Select Count(1) FROM Customer; 

    SELECT * FROM Customer
    WHERE FirstName = 'Aynur'
    AND EMAIL = 'aynur.memmedov@gmail.com'

    --Delete etmemisden evvel yuxaridaki kimi sileceyimiz datani deqiqlesdirmek lazimdi sonra Delete istifade ederek sile bilerik.
    DELETE  FROM Customer
    WHERE FirstName = 'Aynur'
    AND EMAIL = 'aynur.memmedov@gmail.com'


    SELECT * FROM Product
    WHERE ID = 6;

    DELETE FROM Product
    WHERE ID = 6;


    --Select top 
    SELECT TOP 5
        FirstName,
        LastName,
        Email,
        Phone,
        Address
    FROM Customer
    ORDER BY LastName ASC;

    SELECT
        FirstName,
        LastName,
        Email,
        Phone,
        Address
    FROM Customer
    ORDER BY FirstName
    FETCH FIRST 2 ROWS ONLY;



    SELECT COUNT(*) AS TotalCustomers FROM Customer;

    SELECT COUNT(1) AS ActiveCustomers
    FROM Customer
    WHERE IsActive = 1;


    --DISTINCT ile orderlerin countlarin gostermek
    SELECT COUNT(DISTINCT CustomerID) AS CustomersWithOrders 
    FROM [Order];

    --Product count 
    SELECT 
    ProductName,
    COUNT(*) AS ProductCount
    FROM Product
    GROUP BY ProductName
    ORDER BY ProductCount DESC;


    --total sum
    SELECT SUM(TotalAmount) AS TotalRevenue 
    FROM [Order];


    SELECT * FROM [Order]; 

   
    SELECT 
    CustomerID,
    SUM(TotalAmount) AS TotalSpent
    FROM [Order]
    GROUP BY CustomerID
    ORDER BY TotalSpent DESC;


    SELECT SUM(Price * StockQuantity) AS TotalInventoryValue 
    FROM Product;


    SELECT AVG(TotalAmount) AS AverageOrderAmount 
    FROM [Order];


    SELECT * FROM Product;

    --max qiymeti olan productlari goster
    SELECT 
    ProductName,
    Price,
    StockQuantity
    FROM Product
    WHERE Price = (SELECT MAX(Price) FROM Product);


    --total amountu max olan orderleri goster
    SELECT 
    ID,
    CustomerID,
    TotalAmount,
    OrderDate
    FROM [Order]
    WHERE TotalAmount = (SELECT MAX(TotalAmount) FROM [Order]);


    --stock sayi max olan productlari coxdan aza sirala
    SELECT 
    ProductName,
    MAX(StockQuantity) AS MaxStock
    FROM Product
    GROUP BY ProductName
    ORDER BY MaxStock DESC;


    --min qiymeti olan productu goster
    SELECT 
    ProductName,
    Price,
    StockQuantity
    FROM Product
    WHERE Price = (SELECT MIN(Price) FROM Product);


    --total amountu min olan orderi goster
    SELECT 
    ID,
    CustomerID,
    TotalAmount,
    OrderDate
    FROM [Order]
    WHERE TotalAmount = (SELECT MIN(TotalAmount) FROM [Order]);


    --min stock sayi olan productlari azdan coxa sirala
    SELECT 
    ProductName,
    MIN(StockQuantity) AS MinStock
    FROM Product
    GROUP BY ProductName
    ORDER BY MinStock ASC;
        


    SELECT 
    ProductName,
    COUNT(*) AS ProductCount,
    AVG(Price) AS AveragePrice,
    MIN(Price) AS MinPrice,
    MAX(Price) AS MaxPrice,
    SUM(StockQuantity) AS TotalStock
    FROM Product
    GROUP BY ProductName
    ORDER BY AveragePrice DESC;


    
    SELECT 
    CustomerID,
    COUNT(*) AS OrderCount,
    SUM(TotalAmount) AS TotalSpent,
    AVG(TotalAmount) AS AverageOrderAmount,
    MIN(TotalAmount) AS MinOrderAmount,
    MAX(TotalAmount) AS MaxOrderAmount
    FROM [Order]
    GROUP BY CustomerID
    ORDER BY TotalSpent DESC;


    --countu 2 den cox olan productlari goster
    SELECT 
    ProductName,
    COUNT(*) AS ProductCount
    FROM Product
    GROUP BY ProductName
    HAVING COUNT(*) > 2
    ORDER BY ProductCount DESC;


    --productlarin ortalama qiymetlerin azdan coxa sirala
    SELECT 
    ProductName,
    AVG(Price) AS AveragePrice
    FROM Product
    GROUP BY ProductName
    ORDER BY AveragePrice DESC;


    --qiymetlere gore coxdan aza productlari sirala
    SELECT 
    ProductName,
    Price,
    ProductName
    FROM Product
    ORDER BY Price DESC;


    -- aylig illik total amountu goster
    SELECT 
    YEAR(OrderDate) AS OrderYear,
    MONTH(OrderDate) AS OrderMonth,
    COUNT(*) AS OrderCount,
    SUM(TotalAmount) AS TotalRevenue
    FROM [Order]
    GROUP BY YEAR(OrderDate), MONTH(OrderDate)
    ORDER BY OrderYear, OrderMonth;



    --Like operatoru  %herfden sonra yazilirsa baslangici o herfle basliyani geri qaytar demekdir
    SELECT 
    FirstName,
    LastName,
    Email,
    City
    FROM Customer
    WHERE FirstName LIKE 'A%'
    ORDER BY FirstName;


    -- % herfden evvel yazilirsa sonu o herfle biteni geri qaytar demektir
    SELECT 
    FirstName,
    LastName,
    Email,
    City
    FROM Customer
    WHERE LastName LIKE '%v'
    ORDER BY LastName;


    --her iki terefinde % operator varsa hemin soz olan valuelari goster demektir
    SELECT 
    ProductName,
    Price,
    StockQuantity
    FROM Product
    WHERE ProductName LIKE '%phone%'
    ORDER BY ProductName;


    --@gmail.com ile bitenleri goster
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE Email LIKE '%@gmail.com'
    ORDER BY Email;


    -- 12 herfli productu goster
    SELECT 
    ProductName,
    StockQuantity,
    Price
    FROM Product
    WHERE ProductName LIKE '____________'
    ORDER BY ProductName;


    --5 herfli adi goster
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE FirstName LIKE '_____'
    ORDER BY FirstName;
   


    --+99450 ile basliyan nomreleri goster
    SELECT 
    FirstName,
    LastName,
    Phone
    FROM Customer
    WHERE Phone LIKE '+99450%'
    ORDER BY FirstName;



    --sonu .99 ile biten product qiymetlerin goster
    SELECT 
    ProductName,
    Price,
    StockQuantity
    FROM Product
    WHERE CAST(Price AS VARCHAR) LIKE '%.99'
    ORDER BY Price;



    --@ olan emailleri goster
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE Email LIKE '%.%@%.%'
    ORDER BY Email;



    --Pro sozu islenen productlari goster
    SELECT 
    ProductName,
    Price,
    StockQuantity
    FROM Product
    WHERE ProductName LIKE '%Pro%'
    ORDER BY ProductName;


    

    --bas herfi  A,B,C ile baslamiyan adlari goster 
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE FirstName LIKE '[^ABC]%'
    ORDER BY FirstName;



    -- 2 ci herfi a ve ya e olan adlari goster
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE FirstName LIKE '_[ae]%'
    ORDER BY FirstName;


    --bas herfi A,B,C ile basliyan adlari goster
    SELECT 
    FirstName,
    LastName,
    Email
    FROM Customer
    WHERE FirstName LIKE '[ABC]%'
    ORDER BY FirstName;




    SELECT TOP 5
    CustomerID,
    SUM(TotalAmount) AS TotalSpent,
    COUNT(*) AS OrderCount
    FROM [Order]
    GROUP BY CustomerID
    ORDER BY TotalSpent DESC;


    SELECT 
    CustomerID,
    AVG(TotalAmount) AS AverageSpending
FROM [Order]
GROUP BY CustomerID
ORDER BY AverageSpending DESC;

ALTER TABLE 