
-- It represents Many to Many Relationship Between Table Contact and Phone

CREATE TABLE [dbo].[ContactPhone]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [ContactId] INT NOT NULL, 
    [PhoneId] INT NOT NULL
)
