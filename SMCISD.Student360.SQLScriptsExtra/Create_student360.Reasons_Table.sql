-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

USE [EdFi_Ods]
GO

/****** Object:  Table [student360].[Reasons]    Script Date: 4/16/2021 10:33:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [student360].[Reasons](
	[Description] [nvarchar](max) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[HasHours] [bit] NOT NULL,
	[ReasonId] [int] IDENTITY(1,1) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [Reasons_PK] PRIMARY KEY CLUSTERED 
(
	[ReasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [student360].[Reasons] ADD  CONSTRAINT [Reasons_DF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO

