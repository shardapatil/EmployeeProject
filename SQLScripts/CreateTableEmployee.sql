-- Create table statement- Employee

USE [KTjune23]
GO

/****** Object: Table [dbo].[Employees] Script Date: 6/30/2023 10:42:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees] (
    [EmpNo]  INT             NOT NULL,
    [Name]   VARCHAR (50)    NOT NULL,
    [Basic]  DECIMAL (18, 2) NOT NULL,
    [DeptNo] INT             NOT NULL
);


