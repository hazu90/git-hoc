/****** Object:  StoredProcedure [dbo].[City_GetAll]    Script Date: 7/20/2017 5:53:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[City_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT   [Id]
			,[CityName]
			,[CityCode]
			,[LocationLink]
			,[CountryId]
	FROM [City]
END
