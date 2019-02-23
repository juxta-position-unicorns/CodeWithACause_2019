CREATE TABLE [dbo].[SubjectLevel]
(
    [CourseName] NVARCHAR(100) NOT NULL PRIMARY KEY,
    [Subject] VARCHAR(30) NULL, 
    [Level] INT NULL, 
    [IsElective] BIT DEFAULT((0)) NULL,
    [CreditHours] FLOAT NULL, 
);
