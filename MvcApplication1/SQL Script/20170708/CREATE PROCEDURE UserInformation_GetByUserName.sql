SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HieuBV
-- Create date: 08/07/2017
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE UserInformation_GetByUserName
	@UserEmail	NVARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [UserName]
		  ,[FirstName]
		  ,[LastName]
		  ,[UserEmail]
		  ,[CityCode]
	FROM [UserInformation] 
	WHERE [UserEmail] = @UserEmail
END
GO
