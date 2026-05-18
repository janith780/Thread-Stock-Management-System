CREATE TABLE [dbo].[GRN_Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GRN_Number] NVARCHAR(50) NOT NULL, 
    [GRN_Date] DATETIME NOT NULL, 
    [Merchant_Name] NVARCHAR(40) NOT NULL, 
    [Article_Name] NVARCHAR(50) NOT NULL, 
    [Supplier] NVARCHAR(100) NOT NULL, 
    [Qty] INT NOT NULL, 
    [UOM] NVARCHAR(10) NULL, 
    [Color] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(40) NOT NULL
)
