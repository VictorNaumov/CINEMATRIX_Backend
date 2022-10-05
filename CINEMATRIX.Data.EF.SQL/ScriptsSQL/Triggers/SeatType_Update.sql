
--Check for zero price for inserted and updated SeatType
GO
CREATE OR ALTER TRIGGER SeatType_Update 
	ON SeatTypes
	AFTER UPDATE, INSERT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @price INT 
	set @price = (Select inserted.Price FROM inserted)

	IF (@price < 0)
		BEGIN
		PRINT 'Value of price cannot be negative'
		ROLLBACK
		END
END	

--Example for invoke function in SQL
--Insert INTO SeatTypes (name, price) values ('best', -10)