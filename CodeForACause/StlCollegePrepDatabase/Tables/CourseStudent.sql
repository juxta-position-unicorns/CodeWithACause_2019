CREATE TABLE [dbo].[CourseStudent]
(
	[CourseId] INT NOT NULL, 
    [StudentId] INT NOT NULL, 
    [AcademicYear] INT NULL, 
    [AwardedGrade] DECIMAL NULL, 
    PRIMARY KEY ([CourseId], [StudentId])
)
