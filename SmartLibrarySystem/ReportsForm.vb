Imports System.Windows.Forms
Imports System.Data
Imports SmartLibrarySystem.Models

Public Class ReportsForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private allBorrows As List(Of BorrowedBook) = New List(Of BorrowedBook)()

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            allBorrows = DatabaseHelper.GetAllBorrowedBooksList()
            dgvBorrows.DataSource = DatabaseHelper.GetAllBorrowedBooks()
            FormatGrid()
            CalculateSummary()
        Catch ex As Exception
            MessageBox.Show("Could not load report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dgvBorrows.Columns.Count > 0 Then
            dgvBorrows.Columns("BorrowID").HeaderText = "Borrow ID"
            dgvBorrows.Columns("AdmissionNo").HeaderText = "Admission No"
            dgvBorrows.Columns("StudentName").HeaderText = "Student Name"
            dgvBorrows.Columns("BookID").HeaderText = "Book ID"
            dgvBorrows.Columns("BookTitle").HeaderText = "Book Title"
            dgvBorrows.Columns("Issuer").HeaderText = "Issuer"
            dgvBorrows.Columns("BorrowDate").HeaderText = "Borrow Date"
            dgvBorrows.Columns("ReturnDate").HeaderText = "Return Deadline"
            dgvBorrows.Columns("TimeBorrowed").HeaderText = "Time Borrowed"
            dgvBorrows.Columns("Returned").HeaderText = "Returned"
            dgvBorrows.Columns("ActualReturnDate").HeaderText = "Actual Return"
            dgvBorrows.AutoResizeColumns()
        End If
    End Sub

    Private Sub CalculateSummary()
        ' Use a loop to display all borrowed books and calculate total fines.
        Dim totalFines As Decimal = 0D
        Dim overdueCount As Integer = 0
        Dim lines As New System.Text.StringBuilder()
        lines.AppendLine("BORROWING REPORT")
        lines.AppendLine("Generated: " & DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"))
        lines.AppendLine("")

        For Each bb As BorrowedBook In allBorrows
            totalFines += bb.Fine
            If bb.Status.Contains("Overdue") Then
                overdueCount += 1
            End If

            lines.AppendLine(
                bb.BorrowID & " | " & bb.StudentName & " | " & bb.BookTitle &
                " | Borrowed: " & bb.BorrowDate.ToString("dd-MM-yyyy") &
                " | Deadline: " & bb.ReturnDate.ToString("dd-MM-yyyy") &
                " | Days Borrowed: " & bb.DaysBorrowed &
                " | Days Overdue: " & bb.DaysOverdue &
                " | Fine: Ksh. " & bb.Fine.ToString("0.00") &
                " | Status: " & bb.Status)
        Next

        lblTotalBorrows.Text = "Total Borrow Records: " & allBorrows.Count
        lblOverdueCount.Text = "Overdue Books: " & overdueCount
        lblTotalFines.Text = "Total Fines: Ksh. " & totalFines.ToString("0.00")

        ' Average borrowing time (days) across all records.
        Dim avgDays As Double = LibraryLogic.CalculateAverageBorrowingTimePerStudent(allBorrows)
        lblAvgDays.Text = "Average Borrowing Time: " & avgDays & " days"

        ' Average borrowing time per student (grouped).
        Dim byStudent = allBorrows.GroupBy(Function(b) b.AdmissionNo)
        lblAvgPerStudent.Text = "Average Borrowing Time Per Student:"
        txtReport.Text = lines.ToString()
        txtReport.AppendText("" & vbCrLf)
        For Each grp In byStudent
            txtReport.AppendText("  " & grp.First().StudentName & " (" & grp.Key & "): " &
                                 LibraryLogic.CalculateAverageBorrowingTimePerStudent(grp.ToList()) & " days per borrow" & vbCrLf)
        Next
    End Sub

    Private Sub btnViewOverdue_Click(sender As Object, e As EventArgs) Handles btnViewOverdue.Click
        ' Build a filtered grid of overdue books using a loop.
        Dim overdueRows As New DataTable()
        Dim dt As DataTable = DatabaseHelper.GetAllBorrowedBooks()

        For Each col As DataColumn In dt.Columns
            overdueRows.Columns.Add(col.ColumnName, col.DataType)
        Next

        ' Loop through overdue books and generate a report of them.
        Dim overdueList As New List(Of BorrowedBook)()
        For Each bb As BorrowedBook In allBorrows
            If bb.DaysOverdue > 0 Then
                overdueList.Add(bb)
            End If
        Next

        For Each bb As BorrowedBook In overdueList
            Dim row As DataRow = overdueRows.NewRow()
            row("BorrowID") = bb.BorrowID
            row("AdmissionNo") = bb.AdmissionNo
            row("StudentName") = bb.StudentName
            row("BookID") = bb.BookID
            row("BookTitle") = bb.BookTitle
            row("Issuer") = bb.Issuer
            row("BorrowDate") = bb.BorrowDate
            row("ReturnDate") = bb.ReturnDate
            row("TimeBorrowed") = bb.TimeBorrowed
            row("Returned") = bb.Returned
            If bb.ActualReturnDate.HasValue Then
                row("ActualReturnDate") = bb.ActualReturnDate.Value
            Else
                row("ActualReturnDate") = DBNull.Value
            End If
            overdueRows.Rows.Add(row)
        Next

        dgvBorrows.DataSource = overdueRows
        FormatGrid()
        lblTotalBorrows.Text = "Overdue Books Listed: " & overdueRows.Rows.Count
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        LoadReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
    End Sub

End Class