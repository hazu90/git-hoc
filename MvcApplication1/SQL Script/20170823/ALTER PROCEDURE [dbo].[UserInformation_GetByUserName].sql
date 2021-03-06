/****** Object:  StoredProcedure [dbo].[UserInformation_GetByUserName]    Script Date: 08/23/2017 21:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HieuBV
-- Create date: 08/07/2017
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UserInformation_GetByUserName]
	@UserName	NVARCHAR(56)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [UserName]
		  ,[FirstName]
		  ,[LastName]
		  ,[UserEmail]
		  ,[CityCode]
		  ,[Status]
		  ,[DateOfBirth]
		  ,[Sex]
		  ,[Description]
		  ,[IsPrivate]
		  ,[Yahoo]
		  ,[FacebookUrl]
		  ,[Skype]
		  ,[Phone]
	FROM [UserInformation] 
	WHERE [UserName] = @UserName
END
