Imports System.Windows.Forms

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome to SmartLibrarySystem"
        lblSubTitle.Text = "Technical Institute - Library Management System"
        lblServerInfo.Text = "Database: LibraryDB  |  Server: " & DatabaseHelper.GetConnectionString()
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