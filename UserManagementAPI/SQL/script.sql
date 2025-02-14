USE [UserManagement]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 2024/10/15 下午 01:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Province] [nvarchar](450) NOT NULL,
	[City] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Province] ASC,
	[City] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2024/10/15 下午 01:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Email] [nvarchar](450) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Age] [int] NULL,
	[Gender] [int] NOT NULL,
	[Province] [nvarchar](450) NOT NULL,
	[City] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'上海', N'上海')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'北京', N'北京')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'廣東', N'廣州')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'廣東', N'深圳')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'廣東', N'珠海')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'廣西', N'南寧')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'廣西', N'桂林')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'福建', N'廈門')
INSERT [dbo].[Locations] ([Province], [City]) VALUES (N'福建', N'福州')
GO
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'cc@example.com', N'aa3333', N'string', NULL, 1, N'廣東', N'廣州')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'lisi@example.com', N'password123', N'李四', 25, 1, N'北京', N'北京')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'lisi2@example.com', N'password123', N'李四二', 26, 1, N'廣東', N'廣州')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'liuer@example.com', N'password123', N'李二', 29, 1, N'上海', N'上海')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'sunqi@example.com', N'password123', N'孫七', 22, 0, N'廣東', N'珠海')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'sunqi2@example.com', N'password123', N'孫七二', 23, 1, N'上海', N'上海')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'user@example.com', N'x6cb6R7S7g3u7tmt2X0AWjIkTJU1YKJW', N'string', 120, 0, N'廣西', N'南寧')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'wangwu@example.com', N'password123', N'王五', 20, 0, N'廣東', N'廣州')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'wangwu2@example.com', N'password123', N'王五二', 22, 0, N'廣東', N'深圳')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'wangyi@example.com', N'password123', N'王一', 23, 0, N'福建', N'福州')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'wujia@example.com', N'password123', N'吳九', 24, 0, N'廣西', N'桂林')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhangsan@example.com', N'password123', N'張三', 26, 0, N'上海', N'上海')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhangsan2@example.com', N'password123', N'張三二', 21, 0, N'北京', N'北京')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhaoliu@example.com', N'password123', N'趙六', 30, 1, N'廣東', N'深圳')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhaoliu2@example.com', N'password123', N'趙六二', 31, 1, N'廣東', N'珠海')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhengshi@example.com', N'password123', N'鄭十', 27, 1, N'福建', N'廈門')
INSERT [dbo].[Users] ([Email], [Password], [Name], [Age], [Gender], [Province], [City]) VALUES (N'zhouba@example.com', N'password123', N'周八', 28, 1, N'廣西', N'南寧')
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Locations_Province_City] FOREIGN KEY([Province], [City])
REFERENCES [dbo].[Locations] ([Province], [City])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Locations_Province_City]
GO
