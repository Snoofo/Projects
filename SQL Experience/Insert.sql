USE Antiques
GO

INSERT INTO CustomerCategories (CategoryDescription)
VALUES ('Under 18'),
		('19 - 25'),
		('26-29'),
		('30-39'),
		('40-49'),
		('50-65'),
		('Above 65')
GO

INSERT INTO ItemTypes (ItemTypeDescription)
VALUES ('Mens Jewellery'),
		('Womens Jewellery'),
		('Mens Watch'),
		('Womans Watch')
GO

INSERT INTO Items (ItemTypeID, ItemDescription, Price, YearMade)
VALUES (2, 'Diamond Earrings', 2500, 1924),
		(2, 'Diamond Ring', 1250, 1898),
		(2, 'Diamond Ring', 2300, 1952),
		(1, 'Gold Bracelet', 375, 1914),
		(2, 'Gold Broach', 570, 1901),
		(2, 'Gold Broach', 250, 1949),
		(1, 'Gold Earrings', 280, 1939),
		(1, 'Gold Necklace', 250, 1925),
		(2, 'Gold Ring', 340, 1889),
		(3, 'Gold Watch', 560, 1905),
		(2, 'Pearl Earrings', 460, 1936),
		(2, 'Pearl Necklace', 780, 1939),
		(2, 'Ruby Ring', 550, 1915),
		(2, 'Silver Bracelet', 245, 1946),
		(2, 'Silver Necklace', 275, 1876),
		(4, 'Silver Watch', 780, 1936)
GO

INSERT INTO Customers (CategoryID, FirstName, LastName, Address, Suburb, State, Postcode, SendCatalogue)
VALUES (4, 'John', 'Smith', '1 Sunnydale St', 'Sunnydale', 'NSW', 2011, 0),
		(1, 'Mary', 'Jones', '15 Victoria Road', 'Ryde', 'NSW', 2013, 1),
		(6, 'Rick', 'Spanner', '6/4 Burns Bay Rd', 'Lanecove', 'NSW', 2066, 1),
		(7, 'Tracy', 'Monahan', '23 Premier St', 'Kogarah', 'NSW', 2045, 0),
		(5, 'John', 'Smith', '72 Parramatta Rd', 'Liechhardt', 'NSW', 2089, 0),
		(2, 'Sandra', 'Kindale', '7/36 Chiefly Ave', 'Surry Hills', 'NSW', 2030, 1),
		(5, 'Margaret', 'Wilson', '6 Fouveau St', 'Surry Hills', 'NSW', 2022, 1)
GO

INSERT INTO Sales (CustomerID, SaleDate)
VALUES (1, '2016-06-02'),
		(2, '2016-06-02'),
		(3, '2016-06-03'),
		(1, '2016-06-04'),
		(4, '2016-06-04'),
		(2, '2016-06-06'),
		(5, '2016-06-07'),
		(6, '2016-06-07'),
		(7, '2016-06-08')
GO

INSERT INTO SaleItems (SaleID, ItemID)
VALUES (1,8),
		(1, 2),
		(2, 10),
		(3, 9),
		(3, 15),
		(3, 14),
		(4, 5),
		(5, 4),
		(5, 6),
		(6, 3),
		(6, 1),
		(7, 11),
		(7, 13),
		(8, 12),
		(9, 7),
		(9, 16)
GO