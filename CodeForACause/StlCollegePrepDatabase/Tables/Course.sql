CREATE TABLE [dbo].[Course]
(
	[CourseId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [InstructorId] NVARCHAR(128) NULL, 
    [CourseName] NVARCHAR(30) NOT NULL,
    [Subject] VARCHAR(30) NULL, 
    [Level] INT NULL, 
    [CreditHours] FLOAT NULL, 
    [PeriodName] VARCHAR(10) NULL, 
    [StartTime] TIME NULL, 
    [EndTime] TIME NULL, 
    [Year] INT NULL, 
    [Semester] VARCHAR(6) NULL,
);
