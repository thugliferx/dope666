﻿CREATE TABLE [dbo].[Recmd]
(
	
	[RmdId] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[RmdAnnex] NVARCHAR(64) NOT NULL,
	[RmdDescrip] NVARCHAR(256) NULL,
	[Id] NVARCHAR(64) NOT NULL,
	
)
