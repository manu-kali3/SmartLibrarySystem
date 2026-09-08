Imports System.Windows.Forms
Imports System.Data
Imports SmartLibrarySystem.Models

Public Class MemberRegistrationForm

    Private Sub MemberRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        Try
            Dim dt As DataTable = DatabaseHelper.GetAllMembers()
            dgvMembers.DataSource = dt
            If dgvMembers.Columns.Count > 0 Then
                dgvMembers.Columns("AdmissionNo").HeaderText = "Admission No"
                dgvMembers.Columns("StudentName").HeaderText = "Student Name"
                dgvMembers.Columns("RegistrationDate").HeaderText = "Registration Date"
                dgvMembers.AutoResizeColumns()
            End If
            lblCount.Text = "Total members: " & dt.Rows.Count
        Catch ex As Exception
            MessageBox.Show("Could not load members: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' If...Else validation before registering a member.
        If String.IsNullOrWhiteSpace(txtAdmissionNo.Text) Then
            MessageBox.Show("Please enter the admission number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmissionNo.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtStudentName.Text) Then
            MessageBox.Show("Please enter the student name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStudentName.Focus()
            Return
        End If

        ' Check whether the admission number is already registered.
        Dim existing As Member = DatabaseHelper.GetMemberByAdmission(txtAdmissionNo.Text.Trim())
        If existing IsNot Nothing Then
            MessageBox.Show("A member with this admission number already exists: " & existing.StudentName,
                            "Duplicate Member", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DatabaseHelper.AddMember(txtAdmissionNo.Text.Trim(), txtStudentName.Text.Trim())
            MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAdmissionNo.Clear()
            txtStudentName.Clear()
            txtAdmissionNo.Focus()
            LoadMembers()
        Catch ex As Exception
            MessageBox.Show("Could not register member: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class