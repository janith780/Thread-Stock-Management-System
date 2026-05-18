CREATE TABLE [dbo].[ChatTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [sender] NVARCHAR(50) NULL, 
    [receiver] NVARCHAR(10) NULL, 
    [message] NVARCHAR(500) NULL, 
    [timestamp] DATETIME NULL
)
