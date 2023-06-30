USE [KTjune23]
GO

/****** Object: SqlProcedure [dbo].[DeleteEmployee] Script Date: 6/30/2023 10:46:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].DeleteEmployee
	@empno int
AS
	if exists (select * from Employees where  EmpNo = @empno)
	begin 
		delete from Employees 
		
		where empno = @empno;
	end

RETURN 0
