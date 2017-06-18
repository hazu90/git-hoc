
/****** Object:  Table [dbo].[FoodyTitle]    Script Date: 6/15/2017 10:00:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FoodyInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FoodyName] [nvarchar](1000) NULL,
	[Street] [nvarchar](500) NULL,
	[ProvinceId] [nvarchar](250) NULL,
	[CityId] [int] NULL,
	[QualityScore] [float] NULL,
	[ServingScore] [float] NULL,
	[SpaceScore] [float] NULL,
	[CostScore] [float] NULL,
	[CommentScore] [float] NULL,
 CONSTRAINT [PK_FoodyTitle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


