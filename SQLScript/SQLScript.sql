CREATE DATABASE Spinoza
GO

USE Spinoza
GO

CREATE TABLE [User] (
    ID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- Get User
CREATE PROCEDURE GetUserByUsername
    @Username NVARCHAR(50)
AS
BEGIN
    SELECT Usery.ID, Usery.Username, Usery.Password, Roles.RoleName
    FROM [User] Usery
	JOIN Roles ON Usery.RoleID = Roles.ID
    WHERE Usery.Username = @Username
END
GO

-- Create User
CREATE PROCEDURE CreateUser
    @Username NVARCHAR(100),
    @Password NVARCHAR(255)
    @ID INT OUTPUT
AS
BEGIN
    VALUES (@Username, @Password);
	SET @ID = SCOPE_IDENTITY();
END
GO