USE [Meteoroloska stanica]
GO

/****** Object:  Table [dbo].[tbl_merenja]    Script Date: 2/28/2021 12:29:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_merenja](
	[ID_Merenja] [int] IDENTITY(1,1) NOT NULL,
	[DatumMerenja] [varchar](50) NOT NULL,
	[Temperatura] [int] NOT NULL,
	[Pritisak] [float] NOT NULL,
	[PravacVetra] [varchar](50) NULL,
	[BrzinaVetra] [varchar](50) NULL,
	[Vlaznost] [int] NOT NULL,
 CONSTRAINT [PK_tbl_merenja] PRIMARY KEY CLUSTERED 
(
	[ID_Merenja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

