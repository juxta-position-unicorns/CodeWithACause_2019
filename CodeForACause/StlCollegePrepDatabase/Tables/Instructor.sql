﻿CREATE TABLE [dbo].[Instructor]
(
    [UserId] NVARCHAR(128) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(60) NOT NULL,

    UNIQUE ([Name]),
);
