USE Antiques
GO

CREATE PROCEDURE sp_Customers_ExistsCustomer
	(@FirstName varchar(100),
	@LastName varchar(100),
	@Address varchar(100),
	@Suburb varchar(50),
	@State varchar(3),
	@Postcode int,
	@RecordCount INT OUTPUT)
AS
BEGIN
	SELECT @RecordCount = COUNT(*)
	FROM Customers
	WHERE (Customers.FirstName = @FirstName
		AND Customers.LastName = @LastName
		AND Customers.Address = @Address
		AND Customers.Suburb = @Suburb
		AND Customers.State = @State
		AND Customers. Postcode = @Postcode)
END
GO

CREATE PROCEDURE sp_Customers_CreateCustomer
	(@CategoryID int,
	@FirstName varchar(100),
	@LastName varchar(100),
	@Address varchar(100),
	@Suburb varchar(50),
	@State varchar(3),
	@Postcode int,
	@NewCustomerID INT OUTPUT)
AS
BEGIN
	INSERT INTO Customers (CategoryID,
						FirstName,
						LastName,
						Address,
						Suburb,
						State,
						Postcode)
	VALUES (@CategoryID,
			@FirstName,
			@LastName,
			@Address,
			@Suburb,
			@State,
			@Postcode)
	SET @NewCustomerID = @@IDENTITY
END
GO

CREATE PROCEDURE sp_Customers_UpdateCustomer
	(@CustomerID int,
	@CategoryID int,
	@FirstName varchar(100),
	@LastName varchar(100),
	@Address varchar(100),
	@Suburb varchar(50),
	@State varchar(3),
	@Postcode int)
AS
BEGIN
	UPDATE Customers
	SET CategoryID = @CategoryID,
		FirstName = @FirstName,
		LastName = @LastName,
		Address = @Address,
		Suburb = @Suburb,
		State = @State,
		Postcode = @Postcode
	WHERE CustomerID = @CustomerID
END
GO

CREATE PROCEDURE sp_Customers_AllowDeleteCustomer
	(@CustomerID int,
	@RecordCount INT OUTPUT)
AS
BEGIN
	SELECT @RecordCount = COUNT(*)
	FROM Customers
	WHERE Customers.CustomerID = @CustomerID
END
GO

CREATE PROCEDURE sp_Customers_DeleteCustomer
	(@CustomerID int)
AS
BEGIN
	DELETE FROM Customers
	WHERE Customers.CustomerID = @CustomerID
END
GO

CREATE PROCEDURE sp_Customers_SearchCustomers
	(@CustomerID int)
AS
BEGIN
	IF (@CustomerID = 0)
		BEGIN
			SELECT *
			FROM Customers
		END
	ELSE
		BEGIN
			SELECT *
			FROM Customers
			WHERE Customers.CustomerID = @CustomerID
		END
END
GO