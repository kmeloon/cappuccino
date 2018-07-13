USE [C:\USERS\SCHOOL\DESKTOP\SCHOOL\CAPSTONE\DATABASE1.MDF]
GO

/****** Object: Table [dbo].[Table] Script Date: 7/1/2018 10:37:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo] (
    [Id]           INT        NOT NULL,
    [productName]  NCHAR (10) NULL,
    [UnitsInStock] NCHAR (10) NULL
);
Insert into [dbo].[Table] (
id,productName,UnitsInStock
)
Values(1,1,100);
select * from [dbo];

