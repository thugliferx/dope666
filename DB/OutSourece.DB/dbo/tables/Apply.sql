﻿CREATE TABLE [dbo].[Apply]
(
    [CaseId] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Id] NVARCHAR(64) NOT NULL,
	[State] NVARCHAR(256) NULL,
	[Assess] VARCHAR(64) NULL,
	[Evaluate] NVARCHAR(256) NULL,
	
)
