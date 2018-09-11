CREATE TABLE [dbo].[Users]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Name] NVARCHAR(64) NOT NULL,
	[Phone] NVARCHAR(20) NULL,
	[Email]	NVARCHAR(20) NULL,
	[PassWord] NVARCHAR(64) NULL,
	[Address] NVARCHAR(256) NULL,
	[Region] NVARCHAR(256) NULL,
	[CreateTime] datetime NOT NULL,
	[UpdateTime] datetime NULL,
	[Birth] datetime NULL,
	[AuthID]  NVARCHAR(256) NOT NULL,


)
