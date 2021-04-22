-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

USE [EdFi_Ods_DEV]
GO

/****** Object:  Table [dbo].[DIM_Daily_Att_Rates_District]    Script Date: 4/16/2021 10:22:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DIM_Daily_Att_Rates_District](
	[LEVEL] [varchar](12) NULL,
	[MEMBERSHIPTOTAL] [nvarchar](4000) NULL,
	[ABS] [nvarchar](4000) NULL,
	[PRESENT] [nvarchar](4000) NULL,
	[YTDRATE] [nvarchar](4000) NULL,
	[INSTRUCTIONALDAY] [smallint] NULL,
	[CAL_DATE] [datetime] NULL,
	[SCHOOL_YEAR] [nchar](10) NULL
) ON [PRIMARY]
GO


