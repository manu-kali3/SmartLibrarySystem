Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports SmartLibrarySystem.Models

Public Module DatabaseHelper

    ' Loads the connection string from App.config.
    ' Change the Server value in App.config to match your SQL Server instance.
    Public Function GetConnectionString() As String
        Dim cs As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("LibraryDB")
        If cs IsNot Nothing AndAlso Not String.IsNullOrEmpty(cs.ConnectionString) Then
            Return cs.ConnectionString
        End If
        Return "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False;"
    End Function

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(GetConnectionString())
    End Function

    ' Connection string pointing at the "master" database on the same server,
    ' used to create LibraryDB on first launch.
    Public Function GetMasterConnectionString() As String
        Dim builder As New SqlConnectionStringBuilder(GetConnectionString())
        builder.InitialCatalog = "master"
        Return builder.ConnectionString
    End Function

    ' ===================================================
    ' LocalDB bootstrap: creates LibraryDB (if missing),
    ' its tables, and the seed data. Called on app start.
    ' ===================================================
    Public Sub InitializeDatabase()
        ' 1. Create the database if it does not exist.
        Using conn As SqlConnection = New SqlConnection(GetMasterConnectionString())
            Using cmd As New SqlCommand("IF DB_ID(N'LibraryDB') IS NULL CREATE DATABASE [LibraryDB];", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' 2. Create the tables if they do not exist.
        Dim tablesSql As String =
            "IF OBJECT_ID(N'dbo.Books', N'U') IS NULL " &
            "CREATE TABLE dbo.Books (" &
            "BookID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " &
            "Title VARCHAR(100) NOT NULL, " &
            "Author VARCHAR(100) NOT NULL, " &
            "Quantity INT NOT NULL DEFAULT 0, " &
            "Available BIT NOT NULL DEFAULT 1); " &
            "IF OBJECT_ID(N'dbo.Members', N'U') IS NULL " &
            "CREATE TABLE dbo.Members (" &
            "AdmissionNo VARCHAR(20) NOT NULL PRIMARY KEY, " &
            "StudentName VARCHAR(100) NOT NULL, " &
            "RegistrationDate DATETIME NOT NULL DEFAULT GETDATE()); " &
            "IF OBJECT_ID(N'dbo.BorrowedBooks', N'U') IS NULL " &
            "CREATE TABLE dbo.BorrowedBooks (" &
            "BorrowID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " &
            "AdmissionNo VARCHAR(20) NOT NULL, " &
            "BookID INT NOT NULL, " &
            "Issuer VARCHAR(100) NOT NULL, " &
            "BorrowDate DATE NOT NULL, " &
            "ReturnDate DATE NOT NULL, " &
            "TimeBorrowed VARCHAR(20) NOT NULL, " &
            "Returned BIT NOT NULL DEFAULT 0, " &
            "ActualReturnDate DATE NULL, " &
            "CONSTRAINT FK_BorrowedBooks_Members FOREIGN KEY (AdmissionNo) REFERENCES dbo.Members(AdmissionNo), " &
            "CONSTRAINT FK_BorrowedBooks_Books FOREIGN KEY (BookID) REFERENCES dbo.Books(BookID)); " &
            "IF OBJECT_ID(N'dbo.BookCategories', N'U') IS NULL " &
            "CREATE TABLE dbo.BookCategories (" &
            "CategoryID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " &
            "CategoryName VARCHAR(100) NOT NULL UNIQUE); " &
            "IF OBJECT_ID(N'dbo.Publishers', N'U') IS NULL " &
            "CREATE TABLE dbo.Publishers (" &
            "PublisherID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " &
            "PublisherName VARCHAR(100) NOT NULL UNIQUE); " &
            "IF OBJECT_ID(N'dbo.Departments', N'U') IS NULL " &
            "CREATE TABLE dbo.Departments (" &
            "DepartmentID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " &
            "DepartmentName VARCHAR(100) NOT NULL UNIQUE);"
        ExecuteNonQuery(tablesSql, Nothing)

        ' 3. Seed the data (only when previously empty).
        Dim seedSql As String =
            "IF NOT EXISTS (SELECT 1 FROM dbo.Books) " &
            "BEGIN " &
            "INSERT INTO dbo.Books (Title, Author, Quantity, Available) VALUES " &
            "('Introduction to Programming', 'John Nganga', 10, 1), " &
            "('Database Systems', 'Mary Wanjiku', 8, 1), " &
            "('Computer Networks', 'Peter Otieno', 6, 1), " &
            "('Data Structures & Algorithms', 'Alice Muthoni', 12, 1), " &
            "('Software Engineering', 'Brian Kipchoge', 7, 1), " &
            "('Web Development with HTML', 'Grace Njeri', 9, 1); " &
            "END; " &
            "IF NOT EXISTS (SELECT 1 FROM dbo.Members) " &
            "BEGIN " &
            "INSERT INTO dbo.Members (AdmissionNo, StudentName) VALUES " &
            "('ADM-2024-001', 'James Mwangi'), " &
            "('ADM-2024-002', 'Faith Wairimu'), " &
            "('ADM-2024-003', 'Daniel Karanja'); " &
            "END; " &
            "IF NOT EXISTS (SELECT 1 FROM dbo.BookCategories) " &
            "BEGIN " &
            "INSERT INTO dbo.BookCategories (CategoryName) VALUES " &
            "('Programming'), " &
            "('Networking'), " &
            "('Business Studies'), " &
            "('General'); " &
            "END; " &
            "IF NOT EXISTS (SELECT 1 FROM dbo.Publishers) " &
            "BEGIN " &
            "INSERT INTO dbo.Publishers (PublisherName) VALUES " &
            "('Nairobi Press'), " &
            "('TechBooks Ltd'), " &
            "('University Publications'); " &
            "END; " &
            "IF NOT EXISTS (SELECT 1 FROM dbo.Departments) " &
            "BEGIN " &
            "INSERT INTO dbo.Departments (DepartmentName) VALUES " &
            "('Computer Science'), " &
            "('Electrical Engineering'), " &
            "('Business Studies'); " &
            "END;"
        ExecuteNonQuery(seedSql, Nothing)
    End Sub

    ' ---------- Generic ExecuteNonQuery ----------
    Public Function ExecuteNonQuery(commandText As String, parameters As List(Of SqlParameter)) As Integer
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(commandText, conn)
                cmd.CommandType = CommandType.Text
                If parameters IsNot Nothing Then
                    For Each p As SqlParameter In parameters
                        cmd.Parameters.Add(p)
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' ---------- Books ----------
    Public Function GetAllBooks() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT BookID, Title, Author, Quantity, Available FROM Books ORDER BY Title", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function GetAvailableBooks() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT BookID, Title, Author, Quantity, Available FROM Books WHERE Available = 1 AND Quantity > 0 ORDER BY Title", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddBook(title As String, author As String, quantity As Integer) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@Title", title),
            New SqlParameter("@Author", author),
            New SqlParameter("@Quantity", quantity)
        }
        Return ExecuteNonQuery(
            "INSERT INTO Books (Title, Author, Quantity, Available) VALUES (@Title, @Author, @Quantity, CASE WHEN @Quantity > 0 THEN 1 ELSE 0 END)",
            parameters)
    End Function

    Public Function GetBookByTitle(title As String) As Book
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT BookID, Title, Author, Quantity, Available FROM Books WHERE Title = @Title", conn)
                cmd.Parameters.AddWithValue("@Title", title)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Return New Book With {
                            .BookID = Convert.ToInt32(rdr("BookID")),
                            .Title = rdr("Title").ToString(),
                            .Author = rdr("Author").ToString(),
                            .Quantity = Convert.ToInt32(rdr("Quantity")),
                            .Available = Convert.ToBoolean(rdr("Available"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function GetBookByID(bookID As Integer) As Book
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT BookID, Title, Author, Quantity, Available FROM Books WHERE BookID = @BookID", conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Return New Book With {
                            .BookID = Convert.ToInt32(rdr("BookID")),
                            .Title = rdr("Title").ToString(),
                            .Author = rdr("Author").ToString(),
                            .Quantity = Convert.ToInt32(rdr("Quantity")),
                            .Available = Convert.ToBoolean(rdr("Available"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    ' Decrement stock by 1 after a successful borrow.
    Public Function DecrementStock(bookID As Integer) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@BookID", bookID)
        }
        Return ExecuteNonQuery(
            "UPDATE Books SET Quantity = Quantity - 1, Available = CASE WHEN (Quantity - 1) > 0 THEN 1 ELSE 0 END WHERE BookID = @BookID",
            parameters)
    End Function

    ' Increment stock by 1 after a return.
    Public Function IncrementStock(bookID As Integer) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@BookID", bookID)
        }
        Return ExecuteNonQuery(
            "UPDATE Books SET Quantity = Quantity + 1, Available = 1 WHERE BookID = @BookID",
            parameters)
    End Function

    ' ---------- Members ----------
    Public Function GetAllMembers() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT AdmissionNo, StudentName, RegistrationDate FROM Members ORDER BY StudentName", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddMember(admissionNo As String, studentName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@AdmissionNo", admissionNo),
            New SqlParameter("@StudentName", studentName)
        }
        Return ExecuteNonQuery(
            "INSERT INTO Members (AdmissionNo, StudentName) VALUES (@AdmissionNo, @StudentName)",
            parameters)
    End Function

    Public Function GetMemberByAdmission(admissionNo As String) As Member
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT AdmissionNo, StudentName, RegistrationDate FROM Members WHERE AdmissionNo = @AdmissionNo", conn)
                cmd.Parameters.AddWithValue("@AdmissionNo", admissionNo)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Return New Member With {
                            .AdmissionNo = rdr("AdmissionNo").ToString(),
                            .StudentName = rdr("StudentName").ToString(),
                            .RegistrationDate = Convert.ToDateTime(rdr("RegistrationDate"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    ' ---------- Borrowed Books ----------
    Public Function AddBorrowedBook(admissionNo As String, bookID As Integer,
                                    issuer As String, borrowDate As Date,
                                    returnDate As Date, timeBorrowed As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@AdmissionNo", admissionNo),
            New SqlParameter("@BookID", bookID),
            New SqlParameter("@Issuer", issuer),
            New SqlParameter("@BorrowDate", borrowDate),
            New SqlParameter("@ReturnDate", returnDate),
            New SqlParameter("@TimeBorrowed", timeBorrowed)
        }
        Return ExecuteNonQuery(
            "INSERT INTO BorrowedBooks (AdmissionNo, BookID, Issuer, BorrowDate, ReturnDate, TimeBorrowed, Returned) " &
            "VALUES (@AdmissionNo, @BookID, @Issuer, @BorrowDate, @ReturnDate, @TimeBorrowed, 0)",
            parameters)
    End Function

    Public Function GetAllBorrowedBooks() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT bb.BorrowID, bb.AdmissionNo, m.StudentName, bb.BookID, b.Title AS BookTitle, " &
                "bb.Issuer, bb.BorrowDate, bb.ReturnDate, bb.TimeBorrowed, bb.Returned, bb.ActualReturnDate " &
                "FROM BorrowedBooks bb " &
                "INNER JOIN Members m ON bb.AdmissionNo = m.AdmissionNo " &
                "INNER JOIN Books b ON bb.BookID = b.BookID " &
                "ORDER BY bb.BorrowDate DESC", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    ' Returns the active (not yet returned) borrow for a given admission number.
    Public Function GetActiveBorrowByAdmission(admissionNo As String) As BorrowedBook
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT TOP 1 bb.BorrowID, bb.AdmissionNo, m.StudentName, bb.BookID, b.Title AS BookTitle, " &
                "bb.Issuer, bb.BorrowDate, bb.ReturnDate, bb.TimeBorrowed, bb.Returned, bb.ActualReturnDate " &
                "FROM BorrowedBooks bb " &
                "INNER JOIN Members m ON bb.AdmissionNo = m.AdmissionNo " &
                "INNER JOIN Books b ON bb.BookID = b.BookID " &
                "WHERE bb.AdmissionNo = @AdmissionNo AND bb.Returned = 0 " &
                "ORDER BY bb.BorrowDate DESC", conn)
                cmd.Parameters.AddWithValue("@AdmissionNo", admissionNo)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Return ReadBorrowedBook(rdr)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    ' Returns the active borrow record for a given BookID.
    Public Function GetActiveBorrowByBook(bookID As Integer) As BorrowedBook
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT TOP 1 bb.BorrowID, bb.AdmissionNo, m.StudentName, bb.BookID, b.Title AS BookTitle, " &
                "bb.Issuer, bb.BorrowDate, bb.ReturnDate, bb.TimeBorrowed, bb.Returned, bb.ActualReturnDate " &
                "FROM BorrowedBooks bb " &
                "INNER JOIN Members m ON bb.AdmissionNo = m.AdmissionNo " &
                "INNER JOIN Books b ON bb.BookID = b.BookID " &
                "WHERE bb.BookID = @BookID AND bb.Returned = 0 " &
                "ORDER BY bb.BorrowDate DESC", conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        Return ReadBorrowedBook(rdr)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    ' Marks a borrow record as returned.
    Public Function ReturnBook(borrowID As Integer, actualReturnDate As Date) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@BorrowID", borrowID),
            New SqlParameter("@ActualReturnDate", actualReturnDate)
        }
        Return ExecuteNonQuery(
            "UPDATE BorrowedBooks SET Returned = 1, ActualReturnDate = @ActualReturnDate WHERE BorrowID = @BorrowID",
            parameters)
    End Function

    ' Returns all borrow records (returned or not) as a typed list for calculations.
    Public Function GetAllBorrowedBooksList() As List(Of BorrowedBook)
        Dim result As New List(Of BorrowedBook)()
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT bb.BorrowID, bb.AdmissionNo, m.StudentName, bb.BookID, b.Title AS BookTitle, " &
                "bb.Issuer, bb.BorrowDate, bb.ReturnDate, bb.TimeBorrowed, bb.Returned, bb.ActualReturnDate " &
                "FROM BorrowedBooks bb " &
                "INNER JOIN Members m ON bb.AdmissionNo = m.AdmissionNo " &
                "INNER JOIN Books b ON bb.BookID = b.BookID " &
                "ORDER BY bb.BorrowDate DESC", conn)
                conn.Open()
                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        result.Add(ReadBorrowedBook(rdr))
                    End While
                End Using
            End Using
        End Using
        Return result
    End Function

    Private Function ReadBorrowedBook(rdr As SqlDataReader) As BorrowedBook
        Dim bb As New BorrowedBook() With {
            .BorrowID = Convert.ToInt32(rdr("BorrowID")),
            .AdmissionNo = rdr("AdmissionNo").ToString(),
            .StudentName = If(rdr("StudentName") Is DBNull.Value, "", rdr("StudentName").ToString()),
            .BookID = Convert.ToInt32(rdr("BookID")),
            .BookTitle = If(rdr("BookTitle") Is DBNull.Value, "", rdr("BookTitle").ToString()),
            .Issuer = rdr("Issuer").ToString(),
            .BorrowDate = Convert.ToDateTime(rdr("BorrowDate")),
            .ReturnDate = Convert.ToDateTime(rdr("ReturnDate")),
            .TimeBorrowed = rdr("TimeBorrowed").ToString(),
            .Returned = Convert.ToBoolean(rdr("Returned"))
        }
        If rdr("ActualReturnDate") IsNot DBNull.Value Then
            bb.ActualReturnDate = Convert.ToDateTime(rdr("ActualReturnDate"))
        End If
        Return bb
    End Function

    ' ===================================================
    ' Reference Data: Book Categories, Publishers, Departments
    ' ===================================================
    Public Function GetCategories() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT CategoryID, CategoryName FROM BookCategories ORDER BY CategoryName", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddCategory(categoryName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@CategoryName", categoryName)
        }
        Return ExecuteNonQuery(
            "INSERT INTO BookCategories (CategoryName) VALUES (@CategoryName)",
            parameters)
    End Function

    Public Function DeleteCategory(categoryName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@CategoryName", categoryName)
        }
        Return ExecuteNonQuery(
            "DELETE FROM BookCategories WHERE CategoryName = @CategoryName",
            parameters)
    End Function

    Public Function GetPublishers() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT PublisherID, PublisherName FROM Publishers ORDER BY PublisherName", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddPublisher(publisherName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@PublisherName", publisherName)
        }
        Return ExecuteNonQuery(
            "INSERT INTO Publishers (PublisherName) VALUES (@PublisherName)",
            parameters)
    End Function

    Public Function DeletePublisher(publisherName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@PublisherName", publisherName)
        }
        Return ExecuteNonQuery(
            "DELETE FROM Publishers WHERE PublisherName = @PublisherName",
            parameters)
    End Function

    Public Function GetDepartments() As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(
                "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentName", conn)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function AddDepartment(departmentName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@DepartmentName", departmentName)
        }
        Return ExecuteNonQuery(
            "INSERT INTO Departments (DepartmentName) VALUES (@DepartmentName)",
            parameters)
    End Function

    Public Function DeleteDepartment(departmentName As String) As Integer
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@DepartmentName", departmentName)
        }
        Return ExecuteNonQuery(
            "DELETE FROM Departments WHERE DepartmentName = @DepartmentName",
            parameters)
    End Function

End Module
