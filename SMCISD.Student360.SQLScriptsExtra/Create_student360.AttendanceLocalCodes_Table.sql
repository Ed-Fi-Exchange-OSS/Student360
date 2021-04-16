USE [EdFi_Ods]
GO

/****** Object:  Table [dbo].[student360.AttendanceLocalCodes]    Script Date: 4/16/2021 10:24:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[student360.AttendanceLocalCodes](
	[AttendanceCode] [nchar](10) NULL,
	[scription] [varchar](50) NULL,
	[DistrictGroup] [nchar](10) NULL,
	[StateGroup] [nchar](10) NULL,
	[School_Year] [nchar](10) NULL,
	[UniqueKey] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_student360.AttendanceLocalCodes] PRIMARY KEY CLUSTERED 
(
	[UniqueKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


