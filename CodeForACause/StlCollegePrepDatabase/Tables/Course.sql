CREATE TABLE [dbo].[Course]
(
	[CourseId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [InstructorId] NVARCHAR(128) NOT NULL, 
    [Subject] VARCHAR(50) NOT NULL, 
    [Level] INT NOT NULL, 
    [CreditHours] INT NULL, 
    [StartTime] TIME NULL, 
    [EndTime] TIME NULL, 
    [Year] INT NULL, 
    [Semester] VARCHAR(6) NULL,
)
