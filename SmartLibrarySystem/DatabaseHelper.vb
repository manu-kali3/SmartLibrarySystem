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
        Return "Server=localhost\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;Trusted_Connection=True;"
    End Function

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(GetConnectionString())
    End Function

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

End Module
