CREATE TABLE [dbo].[AspNetUsers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [email] NVARCHAR(50) NULL, 
    [emailConfirmed] NVARCHAR(50) NULL, 
    [passwordHash] NVARCHAR(50) NULL, 
    [securityStamp] NVARCHAR(50) NULL, 
    [phoneNumber] BIGINT NULL, 
    [phoneNumberConfirmed] BIGINT NULL, 
    [twoFactorEnabled] NVARCHAR(50) NULL, 
    [lockOutEndDateUTC] DATETIME NULL, 
    [lockOutEnabled] NVARCHAR(50) NULL, 
    [accessFailedCount] NVARCHAR(50) NULL, 
    [username] NVARCHAR(50) NULL
)
