CREATE TABLE [dbo].[Writeoff_Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [GRN_Number] NVARCHAR(50) NOT NULL, 
    [Article] NVARCHAR(100) NOT NULL, 
    [Color] NVARCHAR(100) NOT NULL, 
    [Qty] INT NOT NULL, 
    [GRN_Date] DATETIME NOT NULL
)
