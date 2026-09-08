Imports System.Windows.Forms

Public Class MainForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome to SmartLibrarySystem"
        lblSubTitle.Text = "Technical Institute - Library Management System"

        Try
            ' LocalDB bootstrap: create LibraryDB, tables and seed data on first launch.
            DatabaseHelper.InitializeDatabase()
            lblServerInfo.Text = "Database: LibraryDB (LocalDB)  |  Status: Ready"
            lblServerInfo.ForeColor = System.Drawing.Color.DarkGreen
        Catch ex As Exception
            lblServerInfo.Text = "Database not available - check that SQL Server LocalDB is installed."
            lblServerInfo.ForeColor = System.Drawing.Color.Red
            MessageBox.Show(
                "Could not connect to the local database (LibraryDB) and start the application:" & vbCrLf & vbCrLf &
                ex.Message & vbCrLf & vbCrLf &
                "This app uses SQL Server Express LocalDB, which is installed with Visual Studio 2019 " &
                "(.NET desktop development workload)." & vbCrLf &
                "If LocalDB is missing, install it from: " & vbCrLf &
                "https://learn.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb",
                "LocalDB Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Using frm As New BookManagementForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Using frm As New MemberRegistrationForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Using frm As New BorrowBookForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Using frm As New ReturnBookForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Using frm As New ReportsForm()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class