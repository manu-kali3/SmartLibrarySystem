<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookForm
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
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.cboBookTitle = New System.Windows.Forms.ComboBox()
        Me.lblAdmissionNo = New System.Windows.Forms.Label()
        Me.cboAdmissionNo = New System.Windows.Forms.ComboBox()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblExpectedReturn = New System.Windows.Forms.Label()
        Me.lblTimeBorrowed = New System.Windows.Forms.Label()
        Me.lblIssuer = New System.Windows.Forms.Label()
        Me.txtIssuer = New System.Windows.Forms.TextBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblBooksHint = New System.Windows.Forms.Label()
        Me.lblHeaderCurrent = New System.Windows.Forms.Label()
        Me.lblHeaderReturn = New System.Windows.Forms.Label()
        Me.lblHeaderTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(290, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(170, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Borrow Book"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Location = New System.Drawing.Point(60, 90)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(78, 20)
        Me.lblBookTitle.TabIndex = 1
        Me.lblBookTitle.Text = "Book Title"
        '
        'cboBookTitle
        '
        Me.cboBookTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBookTitle.FormattingEnabled = True
        Me.cboBookTitle.Location = New System.Drawing.Point(210, 85)
        Me.cboBookTitle.Name = "cboBookTitle"
        Me.cboBookTitle.Size = New System.Drawing.Size(340, 28)
        Me.cboBookTitle.TabIndex = 2
        '
        'lblAdmissionNo
        '
        Me.lblAdmissionNo.AutoSize = True
        Me.lblAdmissionNo.Location = New System.Drawing.Point(60, 145)
        Me.lblAdmissionNo.Name = "lblAdmissionNo"
        Me.lblAdmissionNo.Size = New System.Drawing.Size(144, 20)
        Me.lblAdmissionNo.TabIndex = 3
        Me.lblAdmissionNo.Text = "Member Admission No"
        '
        'cboAdmissionNo
        '
        Me.cboAdmissionNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAdmissionNo.FormattingEnabled = True
        Me.cboAdmissionNo.Location = New System.Drawing.Point(210, 140)
        Me.cboAdmissionNo.Name = "cboAdmissionNo"
        Me.cboAdmissionNo.Size = New System.Drawing.Size(340, 28)
        Me.cboAdmissionNo.TabIndex = 4
        '
        'lblHeaderCurrent
        '
        Me.lblHeaderCurrent.AutoSize = True
        Me.lblHeaderCurrent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderCurrent.Location = New System.Drawing.Point(60, 200)
        Me.lblHeaderCurrent.Name = "lblHeaderCurrent"
        Me.lblHeaderCurrent.Size = New System.Drawing.Size(110, 23)
        Me.lblHeaderCurrent.TabIndex = 5
        Me.lblHeaderCurrent.Text = "Current Date:"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCurrentDate.Location = New System.Drawing.Point(210, 200)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(90, 23)
        Me.lblCurrentDate.TabIndex = 6
        Me.lblCurrentDate.Text = "dd-MM-yyyy"
        '
        'lblHeaderReturn
        '
        Me.lblHeaderReturn.AutoSize = True
        Me.lblHeaderReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderReturn.Location = New System.Drawing.Point(60, 240)
        Me.lblHeaderReturn.Name = "lblHeaderReturn"
        Me.lblHeaderReturn.Size = New System.Drawing.Size(100, 23)
        Me.lblHeaderReturn.TabIndex = 7
        Me.lblHeaderReturn.Text = "Return Date:"
        '
        'lblExpectedReturn
        '
        Me.lblExpectedReturn.AutoSize = True
        Me.lblExpectedReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblExpectedReturn.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblExpectedReturn.Location = New System.Drawing.Point(210, 240)
        Me.lblExpectedReturn.Name = "lblExpectedReturn"
        Me.lblExpectedReturn.Size = New System.Drawing.Size(90, 23)
        Me.lblExpectedReturn.TabIndex = 8
        Me.lblExpectedReturn.Text = "dd-MM-yyyy"
        '
        'lblHeaderTime
        '
        Me.lblHeaderTime.AutoSize = True
        Me.lblHeaderTime.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTime.Location = New System.Drawing.Point(60, 280)
        Me.lblHeaderTime.Name = "lblHeaderTime"
        Me.lblHeaderTime.Size = New System.Drawing.Size(128, 23)
        Me.lblHeaderTime.TabIndex = 9
        Me.lblHeaderTime.Text = "Time Borrowing:"
        '
        'lblTimeBorrowed
        '
        Me.lblTimeBorrowed.AutoSize = True
        Me.lblTimeBorrowed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimeBorrowed.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTimeBorrowed.Location = New System.Drawing.Point(210, 280)
        Me.lblTimeBorrowed.Name = "lblTimeBorrowed"
        Me.lblTimeBorrowed.Size = New System.Drawing.Size(100, 23)
        Me.lblTimeBorrowed.TabIndex = 10
        Me.lblTimeBorrowed.Text = "hh:mm:ss tt"
        '
        'lblIssuer
        '
        Me.lblIssuer.AutoSize = True
        Me.lblIssuer.Location = New System.Drawing.Point(60, 330)
        Me.lblIssuer.Name = "lblIssuer"
        Me.lblIssuer.Size = New System.Drawing.Size(95, 20)
        Me.lblIssuer.TabIndex = 11
        Me.lblIssuer.Text = "Issuer (Staff)"
        '
        'txtIssuer
        '
        Me.txtIssuer.Location = New System.Drawing.Point(210, 325)
        Me.txtIssuer.MaxLength = 100
        Me.txtIssuer.Name = "txtIssuer"
        Me.txtIssuer.Size = New System.Drawing.Size(340, 27)
        Me.txtIssuer.TabIndex = 12
        Me.txtIssuer.Text = "Librarian"
        '
        'btnBorrow
        '
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBorrow.Location = New System.Drawing.Point(60, 390)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(155, 45)
        Me.btnBorrow.TabIndex = 13
        Me.btnBorrow.Text = "Borrow Book"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(240, 390)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(135, 45)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(400, 390)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 45)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMainMenu.Location = New System.Drawing.Point(570, 390)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(150, 45)
        Me.btnMainMenu.TabIndex = 17
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblBooksHint
        '
        Me.lblBooksHint.AutoSize = True
        Me.lblBooksHint.ForeColor = System.Drawing.Color.Gray
        Me.lblBooksHint.Location = New System.Drawing.Point(210, 118)
        Me.lblBooksHint.Name = "lblBooksHint"
        Me.lblBooksHint.Size = New System.Drawing.Size(200, 20)
        Me.lblBooksHint.TabIndex = 16
        Me.lblBooksHint.Text = "Available books with stock: 0"
        '
        'BorrowBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 470)
        Me.Controls.Add(Me.lblBooksHint)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.txtIssuer)
        Me.Controls.Add(Me.lblIssuer)
        Me.Controls.Add(Me.lblTimeBorrowed)
        Me.Controls.Add(Me.lblHeaderTime)
        Me.Controls.Add(Me.lblExpectedReturn)
        Me.Controls.Add(Me.lblHeaderReturn)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblHeaderCurrent)
        Me.Controls.Add(Me.cboAdmissionNo)
        Me.Controls.Add(Me.lblAdmissionNo)
        Me.Controls.Add(Me.cboBookTitle)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BorrowBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents cboBookTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdmissionNo As System.Windows.Forms.Label
    Friend WithEvents cboAdmissionNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblHeaderCurrent As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents lblHeaderReturn As System.Windows.Forms.Label
    Friend WithEvents lblExpectedReturn As System.Windows.Forms.Label
    Friend WithEvents lblHeaderTime As System.Windows.Forms.Label
    Friend WithEvents lblTimeBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblIssuer As System.Windows.Forms.Label
    Friend WithEvents txtIssuer As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblBooksHint As System.Windows.Forms.Label
End Class