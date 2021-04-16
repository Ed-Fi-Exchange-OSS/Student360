USE [EdFi_Ods]
GO

/****** Object:  Table [dbo].[StaffAccessLevel]    Script Date: 4/16/2021 10:48:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffAccessLevel](
	[Id] [nvarchar](3) NOT NULL,
	[Description] [nvarchar](30) NULL,
	[IsAdmin] [bit] NULL,
	[StaffClassificationDescriptorId] [varchar](50) NULL,
	[AccessLevel] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



--An Example of how to setup the initial security access levels at the LEA

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 0	'Super Admin'	,1	,40789	,'District'

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 10,	'District Admin'	,NULL	,40790	,'District'

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 15,	'Attendance Clerk'	,NULL	,40791	,'School'

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 20,	'Campus Administrator'	,NULL,	40788	,'School'

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 30,	'Teacher'	,NULL	2047	,'Section'

Insert into [EdFi_Ods].[dbo].[StaffAccessLevel] 
( Id,	Description,	IsAdmin,	StaffClassificationDescriptorId,	AccessLevel)
SELECT 40,	'Parent'	,NULL	40787	,'Student'


