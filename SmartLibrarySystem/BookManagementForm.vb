Imports System.Windows.Forms
Imports System.Data

Public Class BookManagementForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BookManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBooks()
    End Sub

    Private Sub LoadAllBooks()
        Try
            Dim dt As DataTable = DatabaseHelper.GetAllBooks()
            dgvBooks.DataSource = dt
            FormatGrid()
            lblCount.Text = "Total books: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatGrid()
        If dgvBooks.Columns.Count > 0 Then
            dgvBooks.Columns("BookID").HeaderText = "Book ID"
            dgvBooks.Columns("Title").HeaderText = "Book Title"
            dgvBooks.Columns("Author").HeaderText = "Author"
            dgvBooks.Columns("Quantity").HeaderText = "Quantity"
            dgvBooks.Columns("Available").HeaderText = "Available"
            dgvBooks.AutoResizeColumns()
        End If
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        ' If...Else to validate the input before adding a book.
        If String.IsNullOrWhiteSpace(txtBookTitle.Text) Then
            MessageBox.Show("Please enter the book title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBookTitle.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAuthor.Text) Then
            MessageBox.Show("Please enter the author.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAuthor.Focus()
            Return
        End If

        Dim quantity As Integer = 0
        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity < 0 Then
            MessageBox.Show("Quantity must be a positive whole number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        Try
            DatabaseHelper.AddBook(txtBookTitle.Text.Trim(), txtAuthor.Text.Trim(), quantity)

            ' The BookID TextBox is optional; applications commonly auto-generate it,
            ' so we show the full list after every successful add.
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtBookTitle.Clear()
            txtAuthor.Clear()
            txtQuantity.Clear()
            txtBookTitle.Focus()

            LoadAllBooks()
        Catch ex As Exception
            MessageBox.Show("Could not add book: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnViewAvailable_Click(sender As Object, e As EventArgs) Handles btnViewAvailable.Click
        Try
            Dim dt As DataTable = DatabaseHelper.GetAvailableBooks()
            dgvBooks.DataSource = dt
            FormatGrid()
            lblCount.Text = "Available books (in stock): " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load available books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllBooks()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvBooks.CurrentRow IsNot Nothing Then
            txtBookID.Text = dgvBooks.CurrentRow.Cells("BookID").Value.ToString()
        End If
    End Sub

End Class