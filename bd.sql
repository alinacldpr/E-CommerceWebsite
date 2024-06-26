USE [ecommerce]
GO
/****** Object:  Table [dbo].[client]    Script Date: 4/10/2024 10:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] NOT NULL,
	[nume] [varchar](50) NULL,
	[parola] [varchar](50) NULL,
	[adresa] [varchar](500) NULL,
	[telefon] [varchar](20) NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comanda]    Script Date: 4/10/2024 10:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comanda](
	[id_comanda] [int] NOT NULL,
	[client] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comanda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producator]    Script Date: 4/10/2024 10:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producator](
	[id_producator] [int] NOT NULL,
	[nume] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[parola] [varchar](50) NULL,
	[adresa] [varchar](500) NULL,
	[telefon] [varchar](20) NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producator] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produs]    Script Date: 4/10/2024 10:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produs](
	[id_produs] [int] NOT NULL,
	[nume] [varchar](50) NULL,
	[inaltime] [float] NULL,
	[latime] [float] NULL,
	[greutate] [float] NULL,
	[disponibilitate] [int] NULL,
	[categorie] [varchar](50) NULL,
	[producator] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_produs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produse_comanda]    Script Date: 4/10/2024 10:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produse_comanda](
	[comanda] [int] NULL,
	[produs] [int] NOT NULL,
	[cantitate] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[produs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[comanda]  WITH CHECK ADD FOREIGN KEY([client])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[produs]  WITH CHECK ADD FOREIGN KEY([producator])
REFERENCES [dbo].[producator] ([id_producator])
GO
ALTER TABLE [dbo].[produse_comanda]  WITH CHECK ADD FOREIGN KEY([comanda])
REFERENCES [dbo].[comanda] ([id_comanda])
GO
ALTER TABLE [dbo].[produse_comanda]  WITH CHECK ADD FOREIGN KEY([produs])
REFERENCES [dbo].[produs] ([id_produs])
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [CK_parolaC] CHECK  (([parola] like '%[A-Z]%' AND [parola] like '%[a-z]%' AND [parola] like '%[0-9]%' AND [parola] like '%[^a-zA-Z0-9]%'))
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [CK_parolaC]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [CK_telefonC] CHECK  (([telefon] like '07[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [CK_telefonC]
GO
ALTER TABLE [dbo].[producator]  WITH CHECK ADD  CONSTRAINT [CK_parolaP] CHECK  (([parola] like '%[A-Z]%' AND [parola] like '%[a-z]%' AND [parola] like '%[0-9]%' AND [parola] like '%[^a-zA-Z0-9]%'))
GO
ALTER TABLE [dbo].[producator] CHECK CONSTRAINT [CK_parolaP]
GO
ALTER TABLE [dbo].[producator]  WITH CHECK ADD  CONSTRAINT [CK_telefonP] CHECK  (([telefon] like '03[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [telefon] like '02[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[producator] CHECK CONSTRAINT [CK_telefonP]
GO
