
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HieuBV
-- Create date: 08/07/2017
-- Description:	
-- =============================================
CREATE PROCEDURE UserInformation_UpdateConfirmedEmailAndActive
	@UserEmail		NVARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE	[UserInformation]
		SET [ConfirmedEmail] = 1,
			[Active]		 = 1
	WHERE	[UserEmail]		 = @UserEmail			
END
GO
