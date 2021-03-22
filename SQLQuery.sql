CREATE DATABASE  Users;
GO
alter database [Users]
set MULTI_USER
GO
USE Users;
GO
IF OBJECT_ID(N'User','U') IS NULL
	CREATE TABLE  [User](
[id] [INT] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[Login] [NVARCHAR](50) NOT NULL,
[Email] [NVARCHAR](50) NOT NULL,
[PhoneNumber] [NVARCHAR](11) NULL,
[Surname] [NVARCHAR](50) NOT NULL,
[Name] [NVARCHAR](50) NOT NULL,
[Patronymic] [NVARCHAR](50) NULL,
[DateOfCreation] [DATE] DEFAULT GETDATE() NOT NULL,
[DateOfChange] [DATE] NOT NULL)
ELSE
DELETE FROM [User]
GO
CREATE TRIGGER Client_Update
ON [dbo].[User]
AFTER UPDATE
AS 
BEGIN
UPDATE dbo.[User] SET dbo.[User].DateOfChange = GETDATE()
  FROM INSERTED
  WHERE inserted.id=[User].id
END