CREATE TABLE [dbo].[StudentAvailability]
(
    [StudentId] INT NOT NULL PRIMARY KEY,
    [PeriodName] VARCHAR(20) NULL, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL
)
