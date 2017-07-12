/****** Object:  Table [dbo].[CategoryGroup]    Script Date: 7/12/2017 4:24:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CategoryGroup](
	[CateId] [int] IDENTITY(1,1) NOT NULL,
	[CateName] [nvarchar](150) NULL,
	[GrCateLink] [nvarchar](250) NULL,
 CONSTRAINT [PK_CategoryGroup] PRIMARY KEY CLUSTERED 
(
	[CateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


