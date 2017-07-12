
/****** Object:  Table [dbo].[Category]    Script Date: 7/12/2017 4:37:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[CateId] [int] IDENTITY(1,1) NOT NULL,
	[CateName] [nvarchar](150) NULL,
	[CateLink] [nvarchar](250) NULL,
	[CateGrId] [int] NULL,
	[IconImgUrl] [nvarchar](500) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


