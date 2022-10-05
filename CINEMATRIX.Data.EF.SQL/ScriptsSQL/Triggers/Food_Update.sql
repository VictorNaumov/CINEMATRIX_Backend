
--Check for zero price for inserted and updated Food
GO
CREATE OR ALTER TRIGGER Food_Update 
	ON Foods
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
--Insert INTO Foods (name, price) values ('best', -10)