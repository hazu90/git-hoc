
/****** Object:  Table [dbo].[Location]    Script Date: 7/16/2017 3:50:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Location](
	[LocationId] [int] NULL,
	[LocationName] [nvarchar](500) NULL,
	[Address] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[ProvinceId] [int] NULL,
	[NearBy] [nvarchar](200) NULL,
	[AddressDescription] [nvarchar](1000) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[WebsiteUrl] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[NumberOfPersonInRoom] [int] NULL,
	[OpenTime] [time](7) NULL,
	[ClosedTime] [time](7) NULL,
	[LastClientInTime] [time](7) NULL,
	[MinCost] [decimal](18, 0) NULL,
	[MaxCost] [decimal](18, 0) NULL,
	[LanguageUsed] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


