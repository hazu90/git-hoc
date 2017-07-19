-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Location_Create
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
	@OpenTime					TIME(7),
	@ClosedTime					TIME(7),
	@LastClientInTime			TIME(7),
	@MinCost					DECIMAL(18,0),
	@MaxCost					DECIMAL(18,0),
	@LanguageUsed				INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Location]([LocationName] ,[Address],[CategoryGrId],[CountryId],
						   [CityId]	,[ProvinceId],[NearBy],[AddressDescription],
						   [PhoneNumber],[Email],[WebsiteUrl],[Description],
						   [NumberOfPersonInRoom],[OpenTime],[ClosedTime],
						   [LastClientInTime],[MinCost],[MaxCost],[LanguageUsed])
				   VALUES(@LocationName,@Address,@CategoryGrId,@CountryId,
						  @CityId,@ProvinceId,@NearBy,@AddressDescription,
						  @PhoneNumber,@Email,@WebsiteUrl,@Description,
						  @NumberOfPersonInRoom,@OpenTime,@ClosedTime,
						  @LastClientInTime,@MinCost,@MaxCost,@LanguageUsed )
END
GO
