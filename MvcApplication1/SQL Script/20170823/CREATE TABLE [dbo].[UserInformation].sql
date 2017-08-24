
/****** Object:  Table [dbo].[UserInformation]    Script Date: 08/23/2017 21:59:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserInformation](
	[UserName] [nvarchar](56) NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[UserEmail] [nvarchar](150) NULL,
	[CityCode] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[DateOfBirth] [date] NULL,
	[Sex] [char](1) NULL,
	[Description] [nvarchar](1000) NULL,
	[IsPrivate] [bit] NULL,
	[Yahoo] [nvarchar](100) NULL,
	[FacebookUrl] [nvarchar](500) NULL,
	[Skype] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_UserInformation] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[UserInformation] ADD  CONSTRAINT [DF_UserInformation_IsPrivate]  DEFAULT ((0)) FOR [IsPrivate]
GO


