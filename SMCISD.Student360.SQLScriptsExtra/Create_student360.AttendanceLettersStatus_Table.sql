﻿-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

USE [EdFi_Ods]
GO

/****** Object:  Table [student360].[AttendanceLetterStatus]    Script Date: 4/16/2021 10:30:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [student360].[AttendanceLetterStatus](
	[AttendanceLetterStatusId] [int] IDENTITY(1,1) NOT NULL,
	[CodeValue] [nvarchar](50) NOT NULL,
	[ShortDescription] [nvarchar](75) NOT NULL,
	[Description] [nvarchar](1024) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [AttendanceLetterStatus_PK] PRIMARY KEY CLUSTERED 
(
	[AttendanceLetterStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [student360].[AttendanceLetterStatus] ADD  CONSTRAINT [AttendanceLetterStatus_DF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO

ALTER TABLE [student360].[AttendanceLetterStatus] ADD  CONSTRAINT [AttendanceLetterStatus_DF_Id]  DEFAULT (newid()) FOR [Id]
GO

