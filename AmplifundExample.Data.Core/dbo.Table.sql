CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Year] DATETIME2 NULL, 
    [Description] NVARCHAR(255) NULL, 
    [Make] NVARCHAR(255) NULL, 
    [Model] NVARCHAR(255) NULL, 
    [Trim] NVARCHAR(255) NULL, 
    [Vin] NVARCHAR(17) NULL, 
    [Miles] INT NULL, 
    [MPG] INT NULL
)
