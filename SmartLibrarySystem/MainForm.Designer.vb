<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblServerInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(12, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(560, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SmartLibrarySystem"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = False
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblWelcome.Location = New System.Drawing.Point(12, 68)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(560, 26)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to SmartLibrarySystem"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubTitle.Location = New System.Drawing.Point(12, 100)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(560, 26)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Technical Institute - Library Management System"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBooks
        '
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBooks.Location = New System.Drawing.Point(150, 145)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(280, 50)
        Me.btnBooks.TabIndex = 3
        Me.btnBooks.Text = "Book Management"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMembers.Location = New System.Drawing.Point(150, 195)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(280, 50)
        Me.btnMembers.TabIndex = 4
        Me.btnMembers.Text = "Member Registration"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBorrow.Location = New System.Drawing.Point(150, 260)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(280, 50)
        Me.btnBorrow.TabIndex = 5
        Me.btnBorrow.Text = "Borrow Book"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReturn.Location = New System.Drawing.Point(150, 325)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(280, 50)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReports.Location = New System.Drawing.Point(150, 390)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(280, 50)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "Borrowing Report"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(150, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(280, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblServerInfo
        '
        Me.lblServerInfo.AutoSize = True
        Me.lblServerInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblServerInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblServerInfo.Location = New System.Drawing.Point(40, 530)
        Me.lblServerInfo.Name = "lblServerInfo"
        Me.lblServerInfo.Size = New System.Drawing.Size(500, 20)
        Me.lblServerInfo.TabIndex = 9
        Me.lblServerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 575)
        Me.Controls.Add(Me.lblServerInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartLibrarySystem - Library Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblServerInfo As System.Windows.Forms.Label
End Class