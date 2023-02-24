
-- It represents Many to Many Relationship Between Table Contact and Email

CREATE TABLE [dbo].[CustomerEmail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [ContactId] INT NOT NULL, 
    [EmailId] INT NOT NULL
)
