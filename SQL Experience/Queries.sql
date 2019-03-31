USE Antiques
GO

--SELECT Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
--	Customers.Address + ' ' + Customers.Suburb + ' ' + Customers.State + ' ' +
--	CONVERT(varchar(10), Customers.Postcode) AS PostalAddress
--FROM Customers
--GO

--SELECT Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
--	Customers.Address + ' ' + Customers.Suburb + ' ' + Customers.State + ' ' +
--	CONVERT(varchar(10), Customers.Postcode) AS PostalAddress, CustomerCategories.CategoryDescription
--FROM Customers JOIN CustomerCategories ON (Customers.CategoryID = CustomerCategories.CategoryID)
--GO

--SELECT Items.ItemDescription, Items.YearMade, Items.Price, ItemTypes.ItemTypeDescription
--FROM Items JOIN ItemTypes ON (Items.ItemTypeID = ItemTypes.ItemTypeID)
--ORDER BY Items.ItemDescription ASC, Items.YearMade DESC
--GO

--SELECT Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
--	Customers.Address + ' ' + Customers.Suburb + ' ' + Customers.State + ' ' +
--	CONVERT(varchar(10), Customers.Postcode) AS PostalAddress, CustomerCategories.CategoryDescription
--FROM Customers JOIN CustomerCategories ON (Customers.CategoryID = CustomerCategories.CategoryID)
--WHERE Customers.SendCatalogue = 1
--GO

--SELECT Items.ItemDescription, Items.YearMade, Items.Price, ItemTypes.ItemTypeDescription
--FROM Items JOIN ItemTypes ON (Items.ItemTypeID = ItemTypes.ItemTypeID)
--WHERE Items.YearMade <= 1940
--ORDER BY Items.ItemDescription ASC, Items.YearMade DESC
--GO

--SELECT Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
--	Customers.Address + ' ' + Customers.Suburb + ' ' + Customers.State + ' ' +
--	CONVERT(varchar(10), Customers.Postcode) AS PostalAddress, CustomerCategories.CategoryDescription
--FROM Customers JOIN CustomerCategories ON (Customers.CategoryID = CustomerCategories.CategoryID)
--WHERE Customers.CategoryID < 6 AND Customers.LastName LIKE '%S%'
--GO

--SELECT Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
--	Sales.SaleDate, Items.ItemDescription, Items.Price
--FROM Customers JOIN Sales ON (Customers.CustomerID = Sales.CustomerID)
--	JOIN SaleItems ON (Sales.SaleID = SaleItems.SaleID) JOIN
--	Items ON (SaleItems.ItemID = Items.ItemID)
--WHERE Sales.SaleDate BETWEEN '2016-06-03' AND '2016-06-06'
--ORDER BY Sales.SaleDate ASC
--GO

--SELECT MIN(Items.Price) AS MinPrice, MAX(Items.Price) AS MaxPrice, AVG(Items.Price) AS AveragePrice
--FROM Items
--GO

--SELECT Sales.SaleID, Sales.SaleDate, Customers.FirstName + ' ' + Customers.LastName AS CustomerName, TotalPrice
--FROM Customers JOIN Sales ON (Customers.CustomerID = Sales.CustomerID)
--	JOIN (SELECT SaleItems.SaleID, SUM(Items.Price) AS TotalPrice
--	FROM SaleItems JOIN Items ON (SaleItems.ItemID = Items.ItemID)
--	GROUP BY SaleItems.SaleID) AS A ON (Sales.SaleID = A.SaleID)
--ORDER BY Sales.SaleID ASC
--GO

--SELECT COUNT(SaleItems.ItemID)
--FROM SaleItems JOIN Sales ON (SaleItems.SaleID = Sales.SaleID)
--WHERE Sales.SaleDate BETWEEN '2016-06-03' AND '2016-06-06'
--GO

--SELECT LEFT(Customers.FirstName, 1) + ' ' + Customers.LastName AS InitialName,
--	LEN(Customers.FirstName + ' ' + Customers.LastName) AS FullNameLength
--FROM Customers
--GO

--SELECT DATEDIFF(dd, MIN(Sales.SaleDate), MAX(Sales.SaleDate))
--FROM Sales
--GO