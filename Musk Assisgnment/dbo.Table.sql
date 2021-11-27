CREATE TABLE [dbo].[UserRegistrationTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First Name] VARCHAR(50) NULL, 
    [Last Name] VARCHAR(50) NULL, 
    [Username] VARCHAR(50) NULL, 
    [E-mail] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL, 
    [Confirm Password] VARCHAR(50) NULL
)
