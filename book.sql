
CREATE TABLE [dbo].[admin](
	[account] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[name] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 2020/4/23 20:51:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](30) NOT NULL,
	[summary] [varchar](250) NOT NULL,
	[author] [varchar](20) NOT NULL,
	[addedTime] [varchar](20) NOT NULL,
	[collection] [int] NOT NULL,
	[imgUrl] [varchar](50) NOT NULL,
	[Types] [int] NOT NULL,
	[status] [int] NOT NULL,
	[txtUrl] [varchar](50) NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collect]    Script Date: 2020/4/23 20:51:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collect](
	[userid] [int] NOT NULL,
	[booksid] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[opinion]    Script Date: 2020/4/23 20:51:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[opinion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [int] NOT NULL,
	[username] [varchar](20) NOT NULL,
	[content] [varchar](255) NOT NULL,
 CONSTRAINT [PK_opinion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2020/4/23 20:51:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[account] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[userName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[valuation]    Script Date: 2020/4/23 20:51:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[valuation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[booksid] [int] NOT NULL,
	[content] [varchar](250) NOT NULL,
	[userName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_valuation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[books] ADD  CONSTRAINT [DF_books_collection]  DEFAULT ((0)) FOR [collection]
GO
ALTER TABLE [dbo].[books] ADD  CONSTRAINT [DF_books_status]  DEFAULT ((0)) FOR [status]

