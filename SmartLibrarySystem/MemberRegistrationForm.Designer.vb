<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberRegistrationForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblAdmissionNo = New System.Windows.Forms.Label()
        Me.txtAdmissionNo = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(220, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(230, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Member Registration"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdmissionNo
        '
        Me.lblAdmissionNo.AutoSize = True
        Me.lblAdmissionNo.Location = New System.Drawing.Point(60, 90)
        Me.lblAdmissionNo.Name = "lblAdmissionNo"
        Me.lblAdmissionNo.Size = New System.Drawing.Size(105, 20)
        Me.lblAdmissionNo.TabIndex = 1
        Me.lblAdmissionNo.Text = "Admission No"
        '
        'txtAdmissionNo
        '
        Me.txtAdmissionNo.Location = New System.Drawing.Point(210, 85)
        Me.txtAdmissionNo.MaxLength = 20
        Me.txtAdmissionNo.Name = "txtAdmissionNo"
        Me.txtAdmissionNo.Size = New System.Drawing.Size(240, 27)
        Me.txtAdmissionNo.TabIndex = 2
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(60, 140)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(102, 20)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(210, 135)
        Me.txtStudentName.MaxLength = 100
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(240, 27)
        Me.txtStudentName.TabIndex = 4
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnRegister.Location = New System.Drawing.Point(60, 195)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(180, 40)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register Member"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClose.Location = New System.Drawing.Point(270, 195)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(180, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnMainMenu.Location = New System.Drawing.Point(470, 195)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(180, 40)
        Me.btnMainMenu.TabIndex = 9
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AllowUserToOrderColumns = True
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Location = New System.Drawing.Point(60, 260)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.RowTemplate.Height = 24
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(660, 250)
        Me.dgvMembers.TabIndex = 7
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(60, 520)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 20)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "Total members: 0"
        '
        'MemberRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.txtAdmissionNo)
        Me.Controls.Add(Me.lblAdmissionNo)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MemberRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Registration"
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblAdmissionNo As System.Windows.Forms.Label
    Friend WithEvents txtAdmissionNo As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents dgvMembers As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class