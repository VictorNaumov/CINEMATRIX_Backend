CREATE FUNCTION GetMaximumRevenueForHall (
	@hallId INT
)
RETURNS INT AS
BEGIN
	DECLARE @return_value INT;

	SET @return_value = (SELECT SUM(Price) FROM Seats 
		Left JOIN Halls ON Halls.Id = Seats.HallId
		INNER JOIN SeatTypes ON Seats.SeatTypeId = SeatTypes.Id
		where Halls.Id = @hallId)
 
    RETURN @return_value
END;

--Example for invoke function in SQL
--Select dbo.GetMaximumRevenueForHall(3)