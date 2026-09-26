IF DB_ID(N'VTQ2410900066_exam') IS NULL
BEGIN
    CREATE DATABASE VTQ2410900066_exam;
END
GO
USE VTQ2410900066_exam;
GO
IF OBJECT_ID(N'dbo.VTQEmployee', N'U') IS NOT NULL DROP TABLE dbo.VTQEmployee;
IF OBJECT_ID(N'dbo.VTQStudent', N'U') IS NOT NULL DROP TABLE dbo.VTQStudent;
GO
CREATE TABLE dbo.VTQEmployee
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    VTQName NVARCHAR(100) NOT NULL,
    VTQGender NVARCHAR(10) NULL,
    VTQBirthDay DATE NOT NULL,
    VTQEmail NVARCHAR(120) NULL,
    VTQPhone NVARCHAR(20) NULL,
    VTQActive BIT NOT NULL DEFAULT 1
);
GO
CREATE TABLE dbo.VTQStudent
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    VTQName NVARCHAR(100) NOT NULL,
    VTQGender NVARCHAR(10) NULL,
    VTQBirthDay DATE NOT NULL,
    VTQEmail NVARCHAR(120) NULL,
    VTQPhone NVARCHAR(20) NULL,
    VTQActive BIT NOT NULL DEFAULT 1
);
GO
INSERT INTO dbo.VTQEmployee (VTQName, VTQGender, VTQBirthDay, VTQEmail, VTQPhone, VTQActive) VALUES
(N'Vũ Tuấn Quyền',N'Nam','2006-06-09',N'radahotga1@gmail.com',N'0900000066',1),
(N'Nguyễn Minh Anh',N'Nữ','2006-03-15',N'minhanh@example.com',N'0912345678',1),
(N'Trần Hoàng Nam',N'Nam','2005-11-20',N'hoangnam@example.com',N'0987654321',0);
GO
INSERT INTO dbo.VTQStudent (VTQName, VTQGender, VTQBirthDay, VTQEmail, VTQPhone, VTQActive) VALUES
(N'Vũ Tuấn Quyền',N'Nam','2006-06-09',N'radahotga1@gmail.com',N'0900000066',1),
(N'Nguyễn Minh Anh',N'Nữ','2006-03-15',N'minhanh@example.com',N'0912345678',1),
(N'Trần Hoàng Nam',N'Nam','2005-11-20',N'hoangnam@example.com',N'0987654321',0);
GO
