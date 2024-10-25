CREATE TABLE  [dbo].[Table]
(
	[ElectronicCode] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NCHAR(50) NOT NULL, 
    [Type] NCHAR(50) NOT NULL, 
    [Category] NCHAR(50) NOT NULL, 
    [Prise] INT NOT NULL
)
