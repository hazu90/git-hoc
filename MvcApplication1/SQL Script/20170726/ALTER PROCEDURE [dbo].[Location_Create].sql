/****** Object:  StoredProcedure [dbo].[Location_Create]    Script Date: 7/26/2017 10:23:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Location_Create]
	@LocationName				NVARCHAR(500),	
	@Address					NVARCHAR(200),
	@CategoryGrId				INT,
	@CountryId					INT,
	@CityId						INT,
	@ProvinceId					INT,
	@NearBy						NVARCHAR(200),
	@AddressDescription			NVARCHAR(1000),
	@PhoneNumber				NVARCHAR(50),
	@Email						NVARCHAR(50),
	@WebsiteUrl					NVARCHAR(500),
	@Description				NVARCHAR(1000),
	@NumberOfPersonInRoom		INT,
	@OpenTime					DATETIME,
	@ClosedTime					DATETIME,
	@LastClientInTime			DATETIME,
	@MinCost					DECIMAL(18,0),
	@MaxCost					DECIMAL(18,0),
	@LanguageUsed				INT,
	@CreatedBy					NVARCHAR(56)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Location]([LocationName] ,[Address],[CategoryGrId],[CountryId],
						   [CityId]	,[ProvinceId],[NearBy],[AddressDescription],
						   [PhoneNumber],[Email],[WebsiteUrl],[Description],
						   [NumberOfPersonInRoom],[OpenTime],[ClosedTime],
						   [LastClientInTime],[MinCost],[MaxCost],[LanguageUsed],[CreatedBy],[CreatedDate] )
				   VALUES(@LocationName,@Address,@CategoryGrId,@CountryId,
						  @CityId,@ProvinceId,@NearBy,@AddressDescription,
						  @PhoneNumber,@Email,@WebsiteUrl,@Description,
						  @NumberOfPersonInRoom,@OpenTime,@ClosedTime,
						  @LastClientInTime,@MinCost,@MaxCost,@LanguageUsed,@CreatedBy,GETDATE() )
END
