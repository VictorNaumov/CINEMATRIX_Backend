CREATE FUNCTION GetRevenueForSession (
	@sessionId INT
)
RETURNS DECIMAL(10, 3) AS
BEGIN
	DECLARE @return_value Decimal(10, 3);

	--TODO - FINISH WRITING THIS SCRIPT
	SET @return_value = (SELECT *
							FROM Tickets 
							LEFT JOIN Sessions ON Tickets.SessionId = Sessions.Id
							LEFT JOIN Seats ON Tickets.SeatId <> Seats.Id AND Sessions.HallId = Seats.HallId
							where Tickets.SessionId = 1)
 
    RETURN @return_value
END;

--Example for invoke function in SQL
--SELECT dbo.GetRevenueForSession(1) 
