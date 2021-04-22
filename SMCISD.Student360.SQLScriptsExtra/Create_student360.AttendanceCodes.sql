-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

USE [EdFi_Ods]
GO

/****** Object:  Table [student360].[AttendanceCodes]    Script Date: 4/16/2021 10:27:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [student360].[AttendanceCodes](
	[AttendanceCode] [nvarchar](3) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[DistrictGroup] [nvarchar](50) NULL,
	[StateGroup] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AttendanceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


