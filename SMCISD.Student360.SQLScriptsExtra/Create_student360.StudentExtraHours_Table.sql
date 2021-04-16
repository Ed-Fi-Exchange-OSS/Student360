USE [EdFi_Ods]
GO

/****** Object:  Table [student360].[StudentExtraHours]    Script Date: 4/16/2021 10:36:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [student360].[StudentExtraHours](
	[StudentExtraHoursId] [int] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[StudentUniqueId] [nvarchar](32) NOT NULL,
	[GradeLevel] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](75) NOT NULL,
	[LastSurname] [nvarchar](75) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Hours] [int] NULL,
	[SchoolYear] [smallint] NOT NULL,
	[UserCreatedUniqueId] [nvarchar](50) NOT NULL,
	[UserRole] [nvarchar](100) NOT NULL,
	[Comments] [nvarchar](256) NULL,
	[ReasonId] [int] NOT NULL,
	[UserFirstName] [nvarchar](75) NOT NULL,
	[UserLastSurname] [nvarchar](75) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [StudentExtraHours_PK] PRIMARY KEY CLUSTERED 
(
	[StudentExtraHoursId] ASC,
	[Version] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [student360].[StudentExtraHours] ADD  CONSTRAINT [StudentExtraHours_DF_CreateDate]  DEFAULT (getutcdate()) FOR [CreateDate]
GO

ALTER TABLE [student360].[StudentExtraHours] ADD  CONSTRAINT [StudentExtraHours_DF_Id]  DEFAULT (newid()) FOR [Id]
GO

ALTER TABLE [student360].[StudentExtraHours]  WITH CHECK ADD  CONSTRAINT [FK_StudentExtraHours_Reason] FOREIGN KEY([ReasonId])
REFERENCES [student360].[Reasons] ([ReasonId])
GO

ALTER TABLE [student360].[StudentExtraHours] CHECK CONSTRAINT [FK_StudentExtraHours_Reason]
GO


