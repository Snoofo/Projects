USE Antiques
GO

CREATE FUNCTION fn_CalculateGST
	(@ItemPrice float)
	RETURN money
AS
BEGIN
	DECLARE @GST float
	SET @GST = @ItemPrice * 0.1
	RETURN @GST
END
GO

CREATE VIEW vw_FullSalesDetails
AS
	SELECT Sales.SaleID, Sales.SaleDate, Customers.FirstName, Customers.LastName, 
		CustomerCategories.CategoryDescription, Items.ItemDescription, ItemTypes.ItemTypeDescription,
		Items.YearMade, Items.Price, dbo.fn_CalculateGST(Items.Price) AS GST
	FROM CustomerCategories JOIN Customers ON (CustomerCategories.CategoryID = Customers.CategoryID)
		JOIN Sales ON (Customers.CustomerID = Sales.CustomerID)
		JOIN SaleItems ON (Sales.SaleID = SaleItems.SaleID)
		JOIN Items ON (SaleItems.ItemID = Items.ItemID)
		JOIN ItemTypes ON (Items.ItemTypeID = ItemTypes.ItemTypeID)
GO