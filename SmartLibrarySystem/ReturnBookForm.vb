Imports System.Windows.Forms
Imports SmartLibrarySystem.Models

Public Class ReturnBookForm

    Private currentBorrow As BorrowedBook = Nothing

    Private Sub ReturnBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDisplay()
        lblSearchHint.Text = "Enter the member's Admission No OR the Book ID of an active borrow."
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchActiveBorrow()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            searchActiveBorrow()
        End If
    End Sub

    Private Sub searchActiveBorrow()
        ' If...Else: the search value must not be empty.
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            MessageBox.Show("Please enter an Admission Number or Book ID.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSearch.Focus()
            Return
        End If

        Dim value As String = txtSearch.Text.Trim()
        Dim foundBookID As Integer = 0
        Dim isBookID As Boolean = Integer.TryParse(value, foundBookID)

        Try
            If isBookID Then
                ' User typed a Book ID -> look up the active borrow on that book.
                currentBorrow = DatabaseHelper.GetActiveBorrowByBook(foundBookID)
            Else
                ' User typed an Admission No -> look up the active borrow of that member.
                currentBorrow = DatabaseHelper.GetActiveBorrowByAdmission(value)
            End If

            ' If...Else: whether the borrow record was found.
            If currentBorrow Is Nothing Then
                MessageBox.Show("No active (unreturned) borrow was found for that search value.",
                                "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearDisplay()
                Return
            End If

            DisplayBorrow(currentBorrow)
        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayBorrow(bb As BorrowedBook)
        Dim daysBorrowed As Integer = LibraryLogic.CalculateDaysBorrowed(bb.BorrowDate)
        Dim daysOverdue As Integer = LibraryLogic.CalculateDaysOverdue(bb.ReturnDate)
        Dim fine As Decimal = LibraryLogic.CalculateFine(daysOverdue)
        Dim status As String = LibraryLogic.GetBorrowStatus(bb.ReturnDate)

        lblBorrowerNameValue.Text = bb.StudentName
        lblBookTitleValue.Text = bb.BookTitle
        lblBorrowDateValue.Text = bb.BorrowDate.ToString("dd-MM-yyyy")
        lblReturnDeadlineValue.Text = bb.ReturnDate.ToString("dd-MM-yyyy")
        lblDaysBorrowedValue.Text = daysBorrowed.ToString()
        lblDaysOverdueValue.Text = daysOverdue.ToString()
        lblFineValue.Text = "Ksh. " & fine.ToString("0.00")
        lblStatusValue.Text = status
        lblBorrowIDValue.Text = bb.BorrowID.ToString()
        lblIssuedByValue.Text = bb.Issuer
        lblTimeBorrowedValue.Text = bb.TimeBorrowed

        If status = "Overdue" Then
            lblFineValue.ForeColor = System.Drawing.Color.Red
            lblStatusValue.ForeColor = System.Drawing.Color.Red
        Else
            lblFineValue.ForeColor = System.Drawing.Color.DarkGreen
            lblStatusValue.ForeColor = System.Drawing.Color.DarkGreen
        End If

        btnReturn.Enabled = True
    End Sub

    Private Sub ClearDisplay()
        lblBorrowerNameValue.Text = "-"
        lblBookTitleValue.Text = "-"
        lblBorrowDateValue.Text = "-"
        lblReturnDeadlineValue.Text = "-"
        lblDaysBorrowedValue.Text = "-"
        lblDaysOverdueValue.Text = "-"
        lblFineValue.Text = "Ksh. 0.00"
        lblStatusValue.Text = "-"
        lblBorrowIDValue.Text = "-"
        lblIssuedByValue.Text = "-"
        lblTimeBorrowedValue.Text = "-"
        lblFineValue.ForeColor = System.Drawing.Color.Black
        lblStatusValue.ForeColor = System.Drawing.Color.Black
        btnReturn.Enabled = False
        currentBorrow = Nothing
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If currentBorrow Is Nothing Then
            MessageBox.Show("Please search for a borrow record first.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Return book: " & currentBorrow.BookTitle & " for " & currentBorrow.StudentName & "?" & vbCrLf &
            "Fine to pay: Ksh. " & currentBorrow.Fine.ToString("0.00"),
            "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If...Else: act only on a "Yes".
        If result = DialogResult.Yes Then
            Try
                DatabaseHelper.ReturnBook(currentBorrow.BorrowID, Date.Today)
                DatabaseHelper.IncrementStock(currentBorrow.BookID)

                ' Confirmation MessageBox on successful return.
                MessageBox.Show("Book returned successfully!" & vbCrLf &
                                "Borrower: " & currentBorrow.StudentName & vbCrLf &
                                "Book: " & currentBorrow.BookTitle & vbCrLf &
                                "Days Borrowed: " & LibraryLogic.CalculateDaysBorrowed(currentBorrow.BorrowDate) & vbCrLf &
                                "Days Overdue: " & LibraryLogic.CalculateDaysOverdue(currentBorrow.ReturnDate) & vbCrLf &
                                "Fine: Ksh. " & currentBorrow.Fine.ToString("0.00"),
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearDisplay()
                txtSearch.Clear()
                txtSearch.Focus()
            Catch ex As Exception
                MessageBox.Show("Could not return the book: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class