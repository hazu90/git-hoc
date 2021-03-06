/****** Object:  StoredProcedure [dbo].[Location_GetAll]    Script Date: 12/06/2017 21:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HieuBV
-- Create date: 06/12/2017
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Location_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [LocationId]
      ,[LocationName]
      ,[Address]
      ,[CategoryGrId]
      ,[CountryId]
      ,[CityId]
      ,[ProvinceId]
      ,[NearBy]
      ,[AddressDescription]
      ,[PhoneNumber]
      ,[Email]
      ,[WebsiteUrl]
      ,[Description]
      ,[NumberOfPersonInRoom]
      ,[OpenTime]
      ,[ClosedTime]
      ,[LastClientInTime]
      ,[MinCost]
      ,[MaxCost]
      ,[LanguageUsed]
      ,[CreatedBy]
      ,[CreatedDate]
      ,[UpdatedDate]
      ,[UpdatedBy]
      ,[IsApproved]
      ,[HrefLink]
      ,[RepImgLink]
  FROM [Location]
END
