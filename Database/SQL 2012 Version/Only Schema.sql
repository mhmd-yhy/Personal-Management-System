USE [Personel]
GO
/****** Object:  Table [dbo].[Avanslar]    Script Date: 9.04.2024 15:36:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avanslar](
	[AvansID] [int] IDENTITY(1,1) NOT NULL,
	[Avans] [numeric](18, 0) NULL,
	[AyID] [int] NULL,
	[PersonID] [int] NULL,
 CONSTRAINT [PK_Avanslar] PRIMARY KEY CLUSTERED 
(
	[AvansID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aylar]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EgitimDurumu]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giris]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gorev]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucretler]    Script Date: 9.04.2024 15:36:33 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aylar] ON 

INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (1, N'Ocak      ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (2, N'Şubat     ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (3, N'Mart      ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (4, N'Nisan     ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (5, N'Mayis     ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (6, N'Haziran   ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (7, N'Temmuz    ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (8, N'Ağustos   ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (9, N'Eylül     ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (10, N'Ekim      ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (11, N'Kasim     ')
INSERT [dbo].[Aylar] ([AyID], [Ay]) VALUES (12, N'Aralik    ')
SET IDENTITY_INSERT [dbo].[Aylar] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (1, N'AF', N'Afghanistan', N'AFG', 4, 93)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (2, N'AL', N'Albania', N'ALB', 8, 355)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (3, N'DZ', N'Algeria', N'DZA', 12, 213)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (4, N'AS', N'American Samoa', N'ASM', 16, 1684)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (5, N'AD', N'Andorra', N'AND', 20, 376)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (6, N'AO', N'Angola', N'AGO', 24, 244)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (7, N'AI', N'Anguilla', N'AIA', 660, 1264)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (8, N'AQ', N'Antarctica', NULL, NULL, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (9, N'AG', N'Antigua and Barbuda', N'ATG', 28, 1268)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (10, N'AR', N'Argentina', N'ARG', 32, 54)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (11, N'AM', N'Armenia', N'ARM', 51, 374)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (12, N'AW', N'Aruba', N'ABW', 533, 297)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (13, N'AU', N'Australia', N'AUS', 36, 61)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (14, N'AT', N'Austria', N'AUT', 40, 43)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (15, N'AZ', N'Azerbaijan', N'AZE', 31, 994)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (16, N'BS', N'Bahamas', N'BHS', 44, 1242)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (17, N'BH', N'Bahrain', N'BHR', 48, 973)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (18, N'BD', N'Bangladesh', N'BGD', 50, 880)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (19, N'BB', N'Barbados', N'BRB', 52, 1246)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (20, N'BY', N'Belarus', N'BLR', 112, 375)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (21, N'BE', N'Belgium', N'BEL', 56, 32)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (22, N'BZ', N'Belize', N'BLZ', 84, 501)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (23, N'BJ', N'Benin', N'BEN', 204, 229)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (24, N'BM', N'Bermuda', N'BMU', 60, 1441)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (25, N'BT', N'Bhutan', N'BTN', 64, 975)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (26, N'BO', N'Bolivia', N'BOL', 68, 591)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (27, N'BA', N'Bosnia and Herzegovina', N'BIH', 70, 387)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (28, N'BW', N'Botswana', N'BWA', 72, 267)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (29, N'BV', N'Bouvet Island', NULL, NULL, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (30, N'BR', N'Brazil', N'BRA', 76, 55)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (31, N'IO', N'British Indian Ocean Territory', NULL, NULL, 246)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (32, N'BN', N'Brunei Darussalam', N'BRN', 96, 673)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (33, N'BG', N'Bulgaria', N'BGR', 100, 359)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (34, N'BF', N'Burkina Faso', N'BFA', 854, 226)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (35, N'BI', N'Burundi', N'BDI', 108, 257)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (36, N'KH', N'Cambodia', N'KHM', 116, 855)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (37, N'CM', N'Cameroon', N'CMR', 120, 237)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (38, N'CA', N'Canada', N'CAN', 124, 1)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (39, N'CV', N'Cape Verde', N'CPV', 132, 238)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (40, N'KY', N'Cayman Islands', N'CYM', 136, 1345)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (41, N'CF', N'Central African Republic', N'CAF', 140, 236)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (42, N'TD', N'Chad', N'TCD', 148, 235)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (43, N'CL', N'Chile', N'CHL', 152, 56)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (44, N'CN', N'China', N'CHN', 156, 86)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (45, N'CX', N'Christmas Island', NULL, NULL, 61)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (46, N'CC', N'Cocos (Keeling) Islands', NULL, NULL, 672)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (47, N'CO', N'Colombia', N'COL', 170, 57)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (48, N'KM', N'Comoros', N'COM', 174, 269)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (49, N'CG', N'Congo', N'COG', 178, 242)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (50, N'CD', N'Congo, the Democratic Republic of the', N'COD', 180, 242)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (51, N'CK', N'Cook Islands', N'COK', 184, 682)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (52, N'CR', N'Costa Rica', N'CRI', 188, 506)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (53, N'CI', N'Cote D''Ivoire', N'CIV', 384, 225)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (54, N'HR', N'Croatia', N'HRV', 191, 385)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (55, N'CU', N'Cuba', N'CUB', 192, 53)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (56, N'CY', N'Cyprus', N'CYP', 196, 357)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (57, N'CZ', N'Czech Republic', N'CZE', 203, 420)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (58, N'DK', N'Denmark', N'DNK', 208, 45)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (59, N'DJ', N'Djibouti', N'DJI', 262, 253)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (60, N'DM', N'Dominica', N'DMA', 212, 1767)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (61, N'DO', N'Dominican Republic', N'DOM', 214, 1809)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (62, N'EC', N'Ecuador', N'ECU', 218, 593)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (63, N'EG', N'Egypt', N'EGY', 818, 20)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (64, N'SV', N'El Salvador', N'SLV', 222, 503)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (65, N'GQ', N'Equatorial Guinea', N'GNQ', 226, 240)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (66, N'ER', N'Eritrea', N'ERI', 232, 291)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (67, N'EE', N'Estonia', N'EST', 233, 372)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (68, N'ET', N'Ethiopia', N'ETH', 231, 251)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (69, N'FK', N'Falkland Islands (Malvinas)', N'FLK', 238, 500)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (70, N'FO', N'Faroe Islands', N'FRO', 234, 298)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (71, N'FJ', N'Fiji', N'FJI', 242, 679)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (72, N'FI', N'Finland', N'FIN', 246, 358)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (73, N'FR', N'France', N'FRA', 250, 33)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (74, N'GF', N'French Guiana', N'GUF', 254, 594)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (75, N'PF', N'French Polynesia', N'PYF', 258, 689)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (76, N'TF', N'French Southern Territories', NULL, NULL, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (77, N'GA', N'Gabon', N'GAB', 266, 241)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (78, N'GM', N'Gambia', N'GMB', 270, 220)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (79, N'GE', N'Georgia', N'GEO', 268, 995)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (80, N'DE', N'Germany', N'DEU', 276, 49)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (81, N'GH', N'Ghana', N'GHA', 288, 233)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (82, N'GI', N'Gibraltar', N'GIB', 292, 350)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (83, N'GR', N'Greece', N'GRC', 300, 30)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (84, N'GL', N'Greenland', N'GRL', 304, 299)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (85, N'GD', N'Grenada', N'GRD', 308, 1473)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (86, N'GP', N'Guadeloupe', N'GLP', 312, 590)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (87, N'GU', N'Guam', N'GUM', 316, 1671)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (88, N'GT', N'Guatemala', N'GTM', 320, 502)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (89, N'GN', N'Guinea', N'GIN', 324, 224)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (90, N'GW', N'Guinea-Bissau', N'GNB', 624, 245)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (91, N'GY', N'Guyana', N'GUY', 328, 592)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (92, N'HT', N'Haiti', N'HTI', 332, 509)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (93, N'HM', N'Heard Island and Mcdonald Islands', NULL, NULL, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (94, N'VA', N'Holy See (Vatican City State)', N'VAT', 336, 39)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (95, N'HN', N'Honduras', N'HND', 340, 504)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (96, N'HK', N'Hong Kong', N'HKG', 344, 852)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (97, N'HU', N'Hungary', N'HUN', 348, 36)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (98, N'IS', N'Iceland', N'ISL', 352, 354)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (99, N'IN', N'India', N'IND', 356, 91)
GO
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (100, N'ID', N'Indonesia', N'IDN', 360, 62)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (101, N'IR', N'Iran, Islamic Republic of', N'IRN', 364, 98)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (102, N'IQ', N'Iraq', N'IRQ', 368, 964)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (103, N'IE', N'Ireland', N'IRL', 372, 353)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (104, N'IL', N'Israel', N'ISR', 376, 972)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (105, N'IT', N'Italy', N'ITA', 380, 39)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (106, N'JM', N'Jamaica', N'JAM', 388, 1876)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (107, N'JP', N'Japan', N'JPN', 392, 81)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (108, N'JO', N'Jordan', N'JOR', 400, 962)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (109, N'KZ', N'Kazakhstan', N'KAZ', 398, 7)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (110, N'KE', N'Kenya', N'KEN', 404, 254)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (111, N'KI', N'Kiribati', N'KIR', 296, 686)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (112, N'KP', N'Korea, Democratic People''s Republic of', N'PRK', 408, 850)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (113, N'KR', N'Korea, Republic of', N'KOR', 410, 82)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (114, N'KW', N'Kuwait', N'KWT', 414, 965)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (115, N'KG', N'Kyrgyzstan', N'KGZ', 417, 996)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (116, N'LA', N'Lao People''s Democratic Republic', N'LAO', 418, 856)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (117, N'LV', N'Latvia', N'LVA', 428, 371)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (118, N'LB', N'Lebanon', N'LBN', 422, 961)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (119, N'LS', N'Lesotho', N'LSO', 426, 266)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (120, N'LR', N'Liberia', N'LBR', 430, 231)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (121, N'LY', N'Libyan Arab Jamahiriya', N'LBY', 434, 218)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (122, N'LI', N'Liechtenstein', N'LIE', 438, 423)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (123, N'LT', N'Lithuania', N'LTU', 440, 370)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (124, N'LU', N'Luxembourg', N'LUX', 442, 352)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (125, N'MO', N'Macao', N'MAC', 446, 853)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (126, N'MK', N'Macedonia, the Former Yugoslav Republic of', N'MKD', 807, 389)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (127, N'MG', N'Madagascar', N'MDG', 450, 261)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (128, N'MW', N'Malawi', N'MWI', 454, 265)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (129, N'MY', N'Malaysia', N'MYS', 458, 60)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (130, N'MV', N'Maldives', N'MDV', 462, 960)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (131, N'ML', N'Mali', N'MLI', 466, 223)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (132, N'MT', N'Malta', N'MLT', 470, 356)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (133, N'MH', N'Marshall Islands', N'MHL', 584, 692)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (134, N'MQ', N'Martinique', N'MTQ', 474, 596)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (135, N'MR', N'Mauritania', N'MRT', 478, 222)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (136, N'MU', N'Mauritius', N'MUS', 480, 230)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (137, N'YT', N'Mayotte', NULL, NULL, 269)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (138, N'MX', N'Mexico', N'MEX', 484, 52)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (139, N'FM', N'Micronesia, Federated States of', N'FSM', 583, 691)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (140, N'MD', N'Moldova, Republic of', N'MDA', 498, 373)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (141, N'MC', N'Monaco', N'MCO', 492, 377)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (142, N'MN', N'Mongolia', N'MNG', 496, 976)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (143, N'MS', N'Montserrat', N'MSR', 500, 1664)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (144, N'MA', N'Morocco', N'MAR', 504, 212)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (145, N'MZ', N'Mozambique', N'MOZ', 508, 258)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (146, N'MM', N'Myanmar', N'MMR', 104, 95)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (147, N'NA', N'Namibia', N'NAM', 516, 264)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (148, N'NR', N'Nauru', N'NRU', 520, 674)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (149, N'NP', N'Nepal', N'NPL', 524, 977)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (150, N'NL', N'Netherlands', N'NLD', 528, 31)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (151, N'AN', N'Netherlands Antilles', N'ANT', 530, 599)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (152, N'NC', N'New Caledonia', N'NCL', 540, 687)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (153, N'NZ', N'New Zealand', N'NZL', 554, 64)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (154, N'NI', N'Nicaragua', N'NIC', 558, 505)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (155, N'NE', N'Niger', N'NER', 562, 227)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (156, N'NG', N'Nigeria', N'NGA', 566, 234)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (157, N'NU', N'Niue', N'NIU', 570, 683)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (158, N'NF', N'Norfolk Island', N'NFK', 574, 672)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (159, N'MP', N'Northern Mariana Islands', N'MNP', 580, 1670)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (160, N'NO', N'Norway', N'NOR', 578, 47)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (161, N'OM', N'Oman', N'OMN', 512, 968)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (162, N'PK', N'Pakistan', N'PAK', 586, 92)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (163, N'PW', N'Palau', N'PLW', 585, 680)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (164, N'PS', N'Palestinian Territory, Occupied', NULL, NULL, 970)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (165, N'PA', N'Panama', N'PAN', 591, 507)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (166, N'PG', N'Papua New Guinea', N'PNG', 598, 675)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (167, N'PY', N'Paraguay', N'PRY', 600, 595)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (168, N'PE', N'Peru', N'PER', 604, 51)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (169, N'PH', N'Philippines', N'PHL', 608, 63)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (170, N'PN', N'Pitcairn', N'PCN', 612, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (171, N'PL', N'Poland', N'POL', 616, 48)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (172, N'PT', N'Portugal', N'PRT', 620, 351)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (173, N'PR', N'Puerto Rico', N'PRI', 630, 1787)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (174, N'QA', N'Qatar', N'QAT', 634, 974)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (175, N'RE', N'Reunion', N'REU', 638, 262)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (176, N'RO', N'Romania', N'ROM', 642, 40)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (177, N'RU', N'Russian Federation', N'RUS', 643, 70)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (178, N'RW', N'Rwanda', N'RWA', 646, 250)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (179, N'SH', N'Saint Helena', N'SHN', 654, 290)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (180, N'KN', N'Saint Kitts and Nevis', N'KNA', 659, 1869)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (181, N'LC', N'Saint Lucia', N'LCA', 662, 1758)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (182, N'PM', N'Saint Pierre and Miquelon', N'SPM', 666, 508)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (183, N'VC', N'Saint Vincent and the Grenadines', N'VCT', 670, 1784)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (184, N'WS', N'Samoa', N'WSM', 882, 684)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (185, N'SM', N'San Marino', N'SMR', 674, 378)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (186, N'ST', N'Sao Tome and Principe', N'STP', 678, 239)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (187, N'SA', N'Saudi Arabia', N'SAU', 682, 966)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (188, N'SN', N'Senegal', N'SEN', 686, 221)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (189, N'CS', N'Serbia and Montenegro', NULL, NULL, 381)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (190, N'SC', N'Seychelles', N'SYC', 690, 248)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (191, N'SL', N'Sierra Leone', N'SLE', 694, 232)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (192, N'SG', N'Singapore', N'SGP', 702, 65)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (193, N'SK', N'Slovakia', N'SVK', 703, 421)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (194, N'SI', N'Slovenia', N'SVN', 705, 386)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (195, N'SB', N'Solomon Islands', N'SLB', 90, 677)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (196, N'SO', N'Somalia', N'SOM', 706, 252)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (197, N'ZA', N'South Africa', N'ZAF', 710, 27)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (198, N'GS', N'South Georgia and the South Sandwich Islands', NULL, NULL, 0)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (199, N'ES', N'Spain', N'ESP', 724, 34)
GO
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (200, N'LK', N'Sri Lanka', N'LKA', 144, 94)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (201, N'SD', N'Sudan', N'SDN', 736, 249)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (202, N'SR', N'Suriname', N'SUR', 740, 597)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (203, N'SJ', N'Svalbard and Jan Mayen', N'SJM', 744, 47)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (204, N'SZ', N'Swaziland', N'SWZ', 748, 268)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (205, N'SE', N'Sweden', N'SWE', 752, 46)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (206, N'CH', N'Switzerland', N'CHE', 756, 41)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (207, N'SY', N'Syrian', N'SYR', 760, 963)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (208, N'TW', N'Taiwan, Province of China', N'TWN', 158, 886)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (209, N'TJ', N'Tajikistan', N'TJK', 762, 992)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (210, N'TZ', N'Tanzania, United Republic of', N'TZA', 834, 255)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (211, N'TH', N'Thailand', N'THA', 764, 66)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (212, N'TL', N'Timor-Leste', NULL, NULL, 670)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (213, N'TG', N'Togo', N'TGO', 768, 228)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (214, N'TK', N'Tokelau', N'TKL', 772, 690)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (215, N'TO', N'Tonga', N'TON', 776, 676)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (216, N'TT', N'Trinidad and Tobago', N'TTO', 780, 1868)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (217, N'TN', N'Tunisia', N'TUN', 788, 216)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (218, N'TR', N'Turkey', N'TUR', 792, 90)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (219, N'TM', N'Turkmenistan', N'TKM', 795, 7370)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (220, N'TC', N'Turks and Caicos Islands', N'TCA', 796, 1649)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (221, N'TV', N'Tuvalu', N'TUV', 798, 688)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (222, N'UG', N'Uganda', N'UGA', 800, 256)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (223, N'UA', N'Ukraine', N'UKR', 804, 380)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (224, N'AE', N'United Arab Emirates', N'ARE', 784, 971)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (225, N'GB', N'United Kingdom', N'GBR', 826, 44)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (226, N'US', N'United States', N'USA', 840, 1)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (227, N'UM', N'United States Minor Outlying Islands', NULL, NULL, 1)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (228, N'UY', N'Uruguay', N'URY', 858, 598)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (229, N'UZ', N'Uzbekistan', N'UZB', 860, 998)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (230, N'VU', N'Vanuatu', N'VUT', 548, 678)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (231, N'VE', N'Venezuela', N'VEN', 862, 58)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (232, N'VN', N'Viet Nam', N'VNM', 704, 84)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (233, N'VG', N'Virgin Islands, British', N'VGB', 92, 1284)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (234, N'VI', N'Virgin Islands, U.s.', N'VIR', 850, 1340)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (235, N'WF', N'Wallis and Futuna', N'WLF', 876, 681)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (236, N'EH', N'Western Sahara', N'ESH', 732, 212)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (237, N'YE', N'Yemen', N'YEM', 887, 967)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (238, N'ZM', N'Zambia', N'ZMB', 894, 260)
INSERT [dbo].[Countries] ([Id], [Iso], [Country], [Iso3], [NumCode], [PhoneCode]) VALUES (239, N'ZW', N'Zimbabwe', N'ZWE', 716, 263)
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[EgitimDurumu] ON 

INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (1, N'IlkOkul')
INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (2, N'OrtaOkul')
INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (3, N'Lise')
INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (4, N'Önlisans')
INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (5, N'Lisans')
INSERT [dbo].[EgitimDurumu] ([EgitimID], [Egitim]) VALUES (6, N'YüksekLisans')
SET IDENTITY_INSERT [dbo].[EgitimDurumu] OFF
GO
SET IDENTITY_INSERT [dbo].[Giris] ON 

INSERT [dbo].[Giris] ([ID], [KullaniciAdi], [Sifre], [DogumYeri]) VALUES (1, N'admin     ', N'0000', N'şam')
SET IDENTITY_INSERT [dbo].[Giris] OFF
GO
SET IDENTITY_INSERT [dbo].[Gorev] ON 

INSERT [dbo].[Gorev] ([GorevID], [Gorev]) VALUES (1, N'Idari')
INSERT [dbo].[Gorev] ([GorevID], [Gorev]) VALUES (2, N'Memur')
INSERT [dbo].[Gorev] ([GorevID], [Gorev]) VALUES (3, N'İşçi')
SET IDENTITY_INSERT [dbo].[Gorev] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uc_Countries_Iso]    Script Date: 9.04.2024 15:36:33 ******/
ALTER TABLE [dbo].[Countries] ADD  CONSTRAINT [uc_Countries_Iso] UNIQUE NONCLUSTERED 
(
	[Iso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[Ucretler]  WITH CHECK ADD  CONSTRAINT [FK_Ucretler_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([ID])
GO
ALTER TABLE [dbo].[Ucretler] CHECK CONSTRAINT [FK_Ucretler_Person]
GO
