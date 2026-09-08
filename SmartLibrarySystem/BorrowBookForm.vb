Imports System.Windows.Forms
Imports System.Data
Imports SmartLibrarySystem.Models

Public Class BorrowBookForm

    Private Sub BorrowBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
        LoadMembers()
        UpdateDatesAndTime()
    End Sub

    Private Sub LoadBooks()
        Try
            Dim dt As DataTable = DatabaseHelper.GetAvailableBooks()
            cboBookTitle.Items.Clear()
            For Each row As DataRow In dt.Rows
                cboBookTitle.Items.Add(row("Title").ToString())
            Next
            cboBookTitle.Text = ""
            lblBooksHint.Text = "Available books with stock: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMembers()
        Try
            Dim dt As DataTable = DatabaseHelper.GetAllMembers()
            cboAdmissionNo.Items.Clear()
            For Each row As DataRow In dt.Rows
                cboAdmissionNo.Items.Add(row("AdmissionNo").ToString())
            Next
            cboAdmissionNo.Text = ""
        Catch ex As Exception
            MessageBox.Show("Could not load members: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateDatesAndTime()
        Dim today As Date = Date.Today
        lblCurrentDate.Text = today.ToString("dd-MM-yyyy")
        lblExpectedReturn.Text = LibraryLogic.GetExpectedReturnDate(today).ToString("dd-MM-yyyy")
        lblTimeBorrowed.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        ' Validate selections.
        If String.IsNullOrEmpty(cboBookTitle.Text) Then
            MessageBox.Show("Please select a book title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboBookTitle.Focus()
            Return
        End If

        If String.IsNullOrEmpty(cboAdmissionNo.Text) Then
            MessageBox.Show("Please select a member admission number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboAdmissionNo.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtIssuer.Text) Then
            MessageBox.Show("Please enter the name of the issuer (librarian).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIssuer.Focus()
            Return
        End If

        Try
            ' If...Else: check whether the member is registered.
            Dim member As Member = DatabaseHelper.GetMemberByAdmission(cboAdmissionNo.Text.Trim())
            If member Is Nothing Then
                MessageBox.Show("This admission number is not registered. Please register the member first.",
                                "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If...Else: check book availability before borrowing.
            Dim studentName As String = member.StudentName

            ' Step 1 - get the book by its title.
            Dim book As Book = DatabaseHelper.GetBookByTitle(cboBookTitle.Text.Trim())
            If book Is Nothing Then
                MessageBox.Show("Book not found.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Step 2 - check whether the book is currently available / quantity > 0.
            If Not book.Available OrElse book.Quantity <= 0 Then
                MessageBox.Show("This book is currently unavailable (quantity in stock is 0).",
                                "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check the book does not already have an outstanding active borrow.
            Dim existing As BorrowedBook = DatabaseHelper.GetActiveBorrowByBook(book.BookID)
            If existing IsNot Nothing Then
                MessageBox.Show("This exact book copy is currently borrowed and not yet returned.",
                                "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim today As Date = Date.Today
            Dim returnDate As Date = LibraryLogic.GetExpectedReturnDate(today)
            Dim timeBt As String = DateTime.Now.ToString("hh:mm:ss tt")

            DatabaseHelper.AddBorrowedBook(cboAdmissionNo.Text.Trim(), book.BookID,
                                           txtIssuer.Text.Trim(), today, returnDate, timeBt)
            DatabaseHelper.DecrementStock(book.BookID)

            MessageBox.Show("Book borrowed successfully!" & vbCrLf &
                            "Student: " & studentName & vbCrLf &
                            "Book: " & book.Title & vbCrLf &
                            "Borrow Date: " & today.ToString("dd-MM-yyyy") & vbCrLf &
                            "Expected Return: " & returnDate.ToString("dd-MM-yyyy"),
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadBooks()
            cboBookTitle.Text = ""
            txtIssuer.Clear()
            UpdateDatesAndTime()
        Catch ex As Exception
            MessageBox.Show("Could not borrow book: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBooks()
        LoadMembers()
        UpdateDatesAndTime()
    End Sub

End Class