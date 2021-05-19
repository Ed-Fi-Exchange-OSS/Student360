-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

USE [EdFi_Ods]
GO

/****** Object:  Table [student360].[AttendanceLetters]    Script Date: 4/16/2021 10:28:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [student360].[AttendanceLetters](
	[AttendanceLetterId] [int] IDENTITY(1,1) NOT NULL,
	[AttendanceLetterTypeId] [int] NOT NULL,
	[AttendanceLetterStatusId] [int] NOT NULL,
	[ClassPeriodName] [nvarchar](60) NOT NULL,
	[FirstAbsence] [datetime2](7) NOT NULL,
	[LastAbsence] [datetime2](7) NOT NULL,
	[StudentUniqueId] [nvarchar](32) NOT NULL,
	[FirstName] [nvarchar](75) NOT NULL,
	[MiddleName] [nvarchar](75) NULL,
	[LastSurname] [nvarchar](75) NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[ResolutionDate] [datetime2](7) NULL,
	[GradeLevel] [nvarchar](50) NOT NULL,
	[SchoolYear] [smallint] NOT NULL,
	[SchoolId] [int] NOT NULL,
	[UserCreatedUniqueId] [nvarchar](50) NULL,
	[UserFirstName] [nvarchar](75) NULL,
	[UserLastSurname] [nvarchar](75) NULL,
	[UserRole] [nvarchar](100) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [AttendanceLetters_PK] PRIMARY KEY CLUSTERED 
(
	[AttendanceLetterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [student360].[AttendanceLetters] ADD  CONSTRAINT [AttendanceLetters_DF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO

ALTER TABLE [student360].[AttendanceLetters] ADD  CONSTRAINT [AttendanceLetters_DF_Id]  DEFAULT (newid()) FOR [Id]
GO

ALTER TABLE [student360].[AttendanceLetters]  WITH CHECK ADD  CONSTRAINT [FK_AttendanceLetters_AttendanceLetterStatus] FOREIGN KEY([AttendanceLetterStatusId])
REFERENCES [student360].[AttendanceLetterStatus] ([AttendanceLetterStatusId])
GO

ALTER TABLE [student360].[AttendanceLetters] CHECK CONSTRAINT [FK_AttendanceLetters_AttendanceLetterStatus]
GO

ALTER TABLE [student360].[AttendanceLetters]  WITH CHECK ADD  CONSTRAINT [FK_AttendanceLetters_AttendanceLetterType] FOREIGN KEY([AttendanceLetterTypeId])
REFERENCES [student360].[AttendanceLetterType] ([AttendanceLetterTypeId])
GO

ALTER TABLE [student360].[AttendanceLetters] CHECK CONSTRAINT [FK_AttendanceLetters_AttendanceLetterType]
GO




