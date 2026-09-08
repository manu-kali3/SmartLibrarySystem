' Task: Create the LibraryDB database and all tables for SmartLibrarySystem
' Run this script in SQL Server Management Studio (SSMS) connected to your instance.

IF DB_ID(N'LibraryDB') IS NULL
BEGIN
    CREATE DATABASE LibraryDB;
END
GO

USE LibraryDB;
GO

-- ===================================================
-- Table i: Books
-- BookID P -> Primary Key
-- ===================================================
IF OBJECT_ID(N'dbo.Books', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Books
    (
        BookID      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Title       VARCHAR(100) NOT NULL,
        Author      VARCHAR(100) NOT NULL,
        Quantity    INT NOT NULL DEFAULT 0,
        Available   BIT NOT NULL DEFAULT 1
    );
END
GO

-- ===================================================
-- Table ii: Members
-- Admission No should store 20 characters
-- Student Name should store 100 characters
-- ===================================================
IF OBJECT_ID(N'dbo.Members', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Members
    (
        AdmissionNo VARCHAR(20) NOT NULL PRIMARY KEY,
        StudentName VARCHAR(100) NOT NULL,
        RegistrationDate DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- ===================================================
-- Table iii: Borrowed Books
-- ===================================================
IF OBJECT_ID(N'dbo.BorrowedBooks', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BorrowedBooks
    (
        BorrowID        INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        AdmissionNo     VARCHAR(20) NOT NULL,
        BookID          INT NOT NULL,
        Issuer          VARCHAR(100) NOT NULL,
        BorrowDate      DATE NOT NULL,
        ReturnDate      DATE NOT NULL,        -- Expected return date (BorrowDate + 7 days)
        TimeBorrowed    VARCHAR(20) NOT NULL, -- e.g. "10:45 AM"
        Returned        BIT NOT NULL DEFAULT 0,
        ActualReturnDate DATE NULL            -- set when the book is actually returned
        CONSTRAINT FK_BorrowedBooks_Members FOREIGN KEY (AdmissionNo)
            REFERENCES dbo.Members(AdmissionNo),
        CONSTRAINT FK_BorrowedBooks_Books FOREIGN KEY (BookID)
            REFERENCES dbo.Books(BookID)
    );
END
GO

-- ===================================================
-- Data collection: seed with at least 5 books
-- ===================================================
IF NOT EXISTS (SELECT 1 FROM dbo.Books)
BEGIN
    INSERT INTO dbo.Books (Title, Author, Quantity, Available) VALUES
    ('Introduction to Programming', 'John Nganga',       10, 1),
    ('Database Systems',            'Mary Wanjiku',       8,  1),
    ('Computer Networks',           'Peter Otieno',       6,  1),
    ('Data Structures & Algorithms','Alice Muthoni',      12, 1),
    ('Software Engineering',        'Brian Kipchoge',      7,  1),
    ('Web Development with HTML',   'Grace Njeri',        9,  1);
END
GO

-- ===================================================
-- Data collection: seed with at least 3 students
-- ===================================================
IF NOT EXISTS (SELECT 1 FROM dbo.Members)
BEGIN
    INSERT INTO dbo.Members (AdmissionNo, StudentName) VALUES
    ('ADM-2024-001', 'James Mwangi'),
    ('ADM-2024-002', 'Faith Wairimu'),
    ('ADM-2024-003', 'Daniel Karanja');
END
GO

PRINT 'LibraryDB created successfully with Books, Members and BorrowedBooks tables.';
GO
