CREATE TABLE [dbo].[Users]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Name] NVARCHAR(64) NOT NULL,
	[CellPhone] NVARCHAR(20) NULL,
	[Email]	NVARCHAR(20) NULL,
	[Address] NVARCHAR(256) NULL, 
	[CreateTime] datetime NOT NULL,
	[UpdateTime] datetime NULL,

)
