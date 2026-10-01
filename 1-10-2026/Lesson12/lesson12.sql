USE master;
GO

IF DB_ID(N'lesson12') IS NULL
BEGIN
    CREATE DATABASE lesson12;
END
GO

USE lesson12;
GO

SELECT
    DB_NAME() AS DatabaseName,
    SUSER_SNAME() AS LoginName,
    USER_NAME() AS DatabaseUser,
    IS_MEMBER('db_owner') AS IsDbOwner;
GO

-- Sau khi chạy project, EF Core Migration sẽ tự tạo VTQCategory và VTQProduct.
