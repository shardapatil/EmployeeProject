USE [KTjune23]
GO

/****** Object: SqlProcedure [dbo].[InsertEmployee] Script Date: 6/30/2023 10:44:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].InsertEmployee
	@EmpNo int,
	@Name varchar(50),
	@Basic decimal(18,2),
	@DeptNo int
AS
Insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)
RETURN 0
