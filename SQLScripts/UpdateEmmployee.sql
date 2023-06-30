USE [KTjune23]
GO

/****** Object: SqlProcedure [dbo].[UpdateEmmployee] Script Date: 6/30/2023 10:45:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].UpdateEmmployee
	@EmpNo int,
	@Name varchar(30),
	@Basic decimal(18,2),
	@DeptNo int
AS
	if exists (select * from Employees where  EmpNo = @EmpNo)
	begin 
		update Employees 
		set empno = @EmpNo,
			Name = @Name,
			Basic = @Basic,
			DeptNo = @DeptNo
		where empno = @EmpNo;
	end
		
RETURN 0
