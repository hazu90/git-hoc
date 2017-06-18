
/****** Object:  StoredProcedure [dbo].[City_GetAll]    Script Date: 6/18/2017 8:53:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[City_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT   [Id]
			,[CityName]
			,[CityCode]
	FROM [City]
END

GO


