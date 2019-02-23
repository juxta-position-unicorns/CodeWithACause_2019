CREATE TABLE [dbo].[CourseStudent]
(
	[CourseId] INT NOT NULL, 
    [StudentId] NVARCHAR(128) NOT NULL, 
    [AcademicYear] INT NULL, 
    [AwardedGrade] DECIMAL NULL, 
    PRIMARY KEY ([CourseId], [StudentId]),
	FOREIGN KEY ([CourseId]) REFERENCES [Course] ([CourseId]),
	FOREIGN KEY ([StudentId]) REFERENCES [Student] ([UserId]),
)
