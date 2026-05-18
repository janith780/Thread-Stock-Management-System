CREATE TABLE [dbo].[LoginTable2] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NULL,
    [password] NVARCHAR (50) NULL,
    [email]    NVARCHAR (60) NOT NULL,
    [row] NVARCHAR(20) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

