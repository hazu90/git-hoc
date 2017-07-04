
/****** Object:  StoredProcedure [dbo].[City_Create]    Script Date: 7/4/2017 11:31:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HieuBV
-- Create date: 04/07/2017
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[City_Create] 
	@CityName		NVARCHAR(250),
	@CityCode		NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO	[City]([CityCode] ,[CityName])
				VALUES(@CityCode  ,@CityName)
END

GO


