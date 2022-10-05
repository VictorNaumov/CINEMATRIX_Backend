--Create stored procedure for getting all occupied seats by session id
CREATE PROCEDURE CreateTableLogs
AS
	CREATE TABLE Logs (
        LogId INT PRIMARY KEY,
        Information NVARCHAR(MAX) NOT NULL,
        UpdateAt DATETIME NOT NULL,
	)
GO

--Example for invoke function in SQL
--exec CreateTableLogs