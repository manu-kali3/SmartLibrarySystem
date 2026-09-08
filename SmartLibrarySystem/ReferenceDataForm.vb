Imports System.Windows.Forms
Imports System.Data

Public Class ReferenceDataForm

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ReferenceDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadPublishers()
        LoadDepartments()
    End Sub

    ' ---------- Categories ----------
    Private Sub LoadCategories()
        Try
            Dim dt As DataTable = DatabaseHelper.GetCategories()
            lstCategories.Items.Clear()
            For Each row As DataRow In dt.Rows
                lstCategories.Items.Add(row("CategoryName").ToString())
            Next
            lblCategoryCount.Text = "Total categories: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If String.IsNullOrWhiteSpace(txtCategoryName.Text) Then
            MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategoryName.Focus()
            Return
        End If

        Try
            DatabaseHelper.AddCategory(txtCategoryName.Text.Trim())
            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCategoryName.Clear()
            txtCategoryName.Focus()
            LoadCategories()
        Catch ex As Exception
            MessageBox.Show("Could not add category. It may already exist." & vbCrLf & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        If lstCategories.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a category to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name As String = lstCategories.SelectedItem.ToString()
        If MessageBox.Show("Delete category '" & name & "'?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DatabaseHelper.DeleteCategory(name)
                LoadCategories()
            Catch ex As Exception
                MessageBox.Show("Could not delete category: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ---------- Publishers ----------
    Private Sub LoadPublishers()
        Try
            Dim dt As DataTable = DatabaseHelper.GetPublishers()
            lstPublishers.Items.Clear()
            For Each row As DataRow In dt.Rows
                lstPublishers.Items.Add(row("PublisherName").ToString())
            Next
            lblPublisherCount.Text = "Total publishers: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load publishers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddPublisher_Click(sender As Object, e As EventArgs) Handles btnAddPublisher.Click
        If String.IsNullOrWhiteSpace(txtPublisherName.Text) Then
            MessageBox.Show("Please enter a publisher name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPublisherName.Focus()
            Return
        End If

        Try
            DatabaseHelper.AddPublisher(txtPublisherName.Text.Trim())
            MessageBox.Show("Publisher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPublisherName.Clear()
            txtPublisherName.Focus()
            LoadPublishers()
        Catch ex As Exception
            MessageBox.Show("Could not add publisher. It may already exist." & vbCrLf & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeletePublisher_Click(sender As Object, e As EventArgs) Handles btnDeletePublisher.Click
        If lstPublishers.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a publisher to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name As String = lstPublishers.SelectedItem.ToString()
        If MessageBox.Show("Delete publisher '" & name & "'?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DatabaseHelper.DeletePublisher(name)
                LoadPublishers()
            Catch ex As Exception
                MessageBox.Show("Could not delete publisher: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ---------- Departments ----------
    Private Sub LoadDepartments()
        Try
            Dim dt As DataTable = DatabaseHelper.GetDepartments()
            lstDepartments.Items.Clear()
            For Each row As DataRow In dt.Rows
                lstDepartments.Items.Add(row("DepartmentName").ToString())
            Next
            lblDepartmentCount.Text = "Total departments: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
            MessageBox.Show("Please enter a department name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepartmentName.Focus()
            Return
        End If

        Try
            DatabaseHelper.AddDepartment(txtDepartmentName.Text.Trim())
            MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDepartmentName.Clear()
            txtDepartmentName.Focus()
            LoadDepartments()
        Catch ex As Exception
            MessageBox.Show("Could not add department. It may already exist." & vbCrLf & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteDepartment_Click(sender As Object, e As EventArgs) Handles btnDeleteDepartment.Click
        If lstDepartments.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a department to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim name As String = lstDepartments.SelectedItem.ToString()
        If MessageBox.Show("Delete department '" & name & "'?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DatabaseHelper.DeleteDepartment(name)
                LoadDepartments()
            Catch ex As Exception
                MessageBox.Show("Could not delete department: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class