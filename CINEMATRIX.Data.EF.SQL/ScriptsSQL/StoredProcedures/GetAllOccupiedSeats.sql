--Create stored procedure for getting all occupied seats by session id
CREATE PROCEDURE GetAllOccupiedSeats @sessionId INT
AS
	SELECT *
	FROM Tickets 
	LEFT JOIN Sessions ON Tickets.SessionId = Sessions.Id
	LEFT JOIN Seats ON Tickets.SeatId = Seats.Id
	where Tickets.SessionId = @sessionId
GO

--Example for invoke function in SQL
--Exec GetAllOccupiedSeats 3