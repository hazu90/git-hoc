
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HieuBV
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE UserInformation_Insert
	@UserName		NVARCHAR(56),
	@FirstName		NVARCHAR(150),
	@LastName		NVARCHAR(150),
	@UserEmail		NVARCHAR(150),
	@CityCode		NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [UserInformation]( [UserName],[FirstName],[LastName],[UserEmail],[CityCode] )
						   VALUES( @UserName ,@FirstName ,@LastName ,@UserEmail ,@CityCode)
END
GO
