CREATE DATABASE Spinoza
GO

USE Spinoza
GO

CREATE TABLE [User] (
    ID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

CREATE PROCEDURE CreateUser
    @Username NVARCHAR(100),
    @Password NVARCHAR(255),
    @ID INT OUTPUT
AS
BEGIN
    INSERT INTO [User] (Username, Password)
    VALUES (@Username, @Password);

    SET @ID = SCOPE_IDENTITY();
END
GO

-- Get User
CREATE PROCEDURE GetUserByUsername
    @Username NVARCHAR(50)
AS
BEGIN
    SELECT Usery.ID, Usery.Username, Usery.Password
    FROM [User] Usery
    WHERE Usery.Username = @Username
END
GO