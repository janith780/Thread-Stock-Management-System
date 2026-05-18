CREATE TABLE [dbo].[ThreadIssue_Table]
(
	[IssueID] INT NOT NULL PRIMARY KEY, 
    [GRN_Number] NVARCHAR(50) NOT NULL, 
    [Article] NVARCHAR(100) NOT NULL, 
    [Color] NVARCHAR(50) NOT NULL, 
    [Style] NVARCHAR(10) NOT NULL, 
    [IssueQty] INT NOT NULL, 
    [IssueDate] DATETIME NOT NULL
)
