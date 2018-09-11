CREATE TABLE [dbo].[Case]
(
	[CaseId] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[CaseName] NVARCHAR(64) NOT NULL,
	[CaseField] NVARCHAR(20) NULL,
	[Email]	NVARCHAR(20) NULL,
	[Address] NVARCHAR(256) NULL, 
	[StartTime] datetime NULL,
	[EndTime] datetime NULL,
	[Money] NVARCHAR(20) NULL,
	[Require] NVARCHAR(256) NULL,

)
