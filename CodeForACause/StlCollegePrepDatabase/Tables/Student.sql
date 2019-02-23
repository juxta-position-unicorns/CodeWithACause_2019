CREATE TABLE [dbo].[Student]
(
    [UserId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(30) NOT NULL, 
    [LastName] NVARCHAR(30) NOT NULL,
    [StudentNumber] VARCHAR(20) NOT NULL,  
    [SchoolName] NVARCHAR(50) NULL,
    [IEP] BIT NULL,
    [GraduateBy] VARCHAR(20) NULL,
);
