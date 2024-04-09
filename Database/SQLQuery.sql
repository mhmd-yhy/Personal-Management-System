USE [Personel]
GO
/****** Object:  Table [dbo].[Avanslar]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avanslar](
	[AvansID] [int] NOT NULL,
	[Avans] [numeric](18, 0) NULL,
	[AyID] [int] NULL,
	[PersonID] [int] NULL,
 CONSTRAINT [PK_Avanslar] PRIMARY KEY CLUSTERED 
(
	[AvansID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aylar]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aylar](
	[AyID] [int] IDENTITY(1,1) NOT NULL,
	[Ay] [char](10) NULL,
 CONSTRAINT [PK_Aylar] PRIMARY KEY CLUSTERED 
(
	[AyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Iso] [varchar](2) NOT NULL,
	[Country] [varchar](80) NOT NULL,
	[Iso3] [varchar](3) NULL,
	[NumCode] [int] NULL,
	[PhoneCode] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [uc_Countries_Iso] UNIQUE NONCLUSTERED 
(
	[Iso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EgitimDurumu]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EgitimDurumu](
	[EgitimID] [int] IDENTITY(1,1) NOT NULL,
	[Egitim] [nvarchar](25) NULL,
 CONSTRAINT [PK_EgitimDurum3bu0]]] PRIMARY KEY CLUSTERED 
(
	[EgitimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giris]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giris](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [char](10) NULL,
	[Sifre] [char](4) NULL,
	[DogumYeri] [nvarchar](25) NULL,
 CONSTRAINT [PK_Giris] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gorev]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gorev](
	[GorevID] [int] IDENTITY(1,1) NOT NULL,
	[Gorev] [nvarchar](25) NULL,
 CONSTRAINT [PK_gorev] PRIMARY KEY CLUSTERED 
(
	[GorevID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [char](10) NULL,
	[Isim] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[DogumYeri] [nvarchar](50) NULL,
	[DogumTarihi] [date] NULL,
	[Cinsiyet] [char](5) NULL,
	[MedeniDurumu] [char](5) NULL,
	[UyruguID] [int] NULL,
	[EgitimID] [int] NULL,
	[Tel] [char](12) NULL,
	[Email] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
	[GorevID] [int] NULL,
	[Ucret] [numeric](18, 0) NULL,
	[Fotograf] [image] NULL,
	[KayitTarihi] [char](12) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucretler]    Script Date: 9.04.2024 01:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucretler](
	[UcretID] [int] IDENTITY(1,1) NOT NULL,
	[Ucret] [numeric](18, 0) NULL,
	[AyID] [int] NULL,
	[PersonID] [int] NULL,
 CONSTRAINT [PK_Ucretler] PRIMARY KEY CLUSTERED 
(
	[UcretID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Avanslar]  WITH CHECK ADD  CONSTRAINT [FK_Avanslar_Aylar] FOREIGN KEY([AyID])
REFERENCES [dbo].[Aylar] ([AyID])
GO
ALTER TABLE [dbo].[Avanslar] CHECK CONSTRAINT [FK_Avanslar_Aylar]
GO
ALTER TABLE [dbo].[Avanslar]  WITH CHECK ADD  CONSTRAINT [FK_Avanslar_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
GO
ALTER TABLE [dbo].[Avanslar] CHECK CONSTRAINT [FK_Avanslar_Person]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Countries] FOREIGN KEY([UyruguID])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Countries]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_EgitimDurumu] FOREIGN KEY([EgitimID])
REFERENCES [dbo].[EgitimDurumu] ([EgitimID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_EgitimDurumu]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_gorev] FOREIGN KEY([GorevID])
REFERENCES [dbo].[Gorev] ([GorevID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_gorev]
GO
ALTER TABLE [dbo].[Ucretler]  WITH CHECK ADD  CONSTRAINT [FK_Aylar_Ucretler] FOREIGN KEY([AyID])
REFERENCES [dbo].[Aylar] ([AyID])
GO
ALTER TABLE [dbo].[Ucretler] CHECK CONSTRAINT [FK_Aylar_Ucretler]
GO
