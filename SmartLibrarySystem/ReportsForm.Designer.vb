<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.dgvBorrows = New System.Windows.Forms.DataGridView()
        Me.btnViewOverdue = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblAvgPerStudent = New System.Windows.Forms.Label()
        Me.lblAvgDays = New System.Windows.Forms.Label()
        Me.lblTotalFines = New System.Windows.Forms.Label()
        Me.lblOverdueCount = New System.Windows.Forms.Label()
        Me.lblTotalBorrows = New System.Windows.Forms.Label()
        Me.txtReport = New System.Windows.Forms.TextBox()
        CType(Me.dgvBorrows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(310, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(210, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Borrowing Report"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvBorrows
        '
        Me.dgvBorrows.AllowUserToAddRows = False
        Me.dgvBorrows.AllowUserToDeleteRows = False
        Me.dgvBorrows.AllowUserToOrderColumns = True
        Me.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrows.Location = New System.Drawing.Point(40, 70)
        Me.dgvBorrows.Name = "dgvBorrows"
        Me.dgvBorrows.ReadOnly = True
        Me.dgvBorrows.RowHeadersVisible = False
        Me.dgvBorrows.RowTemplate.Height = 24
        Me.dgvBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrows.Size = New System.Drawing.Size(900, 220)
        Me.dgvBorrows.TabIndex = 1
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.lblAvgPerStudent)
        Me.grpSummary.Controls.Add(Me.lblAvgDays)
        Me.grpSummary.Controls.Add(Me.lblTotalFines)
        Me.grpSummary.Controls.Add(Me.lblOverdueCount)
        Me.grpSummary.Controls.Add(Me.lblTotalBorrows)
        Me.grpSummary.Location = New System.Drawing.Point(40, 305)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(900, 130)
        Me.grpSummary.TabIndex = 2
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'lblTotalBorrows
        '
        Me.lblTotalBorrows.AutoSize = True
        Me.lblTotalBorrows.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBorrows.Location = New System.Drawing.Point(20, 25)
        Me.lblTotalBorrows.Name = "lblTotalBorrows"
        Me.lblTotalBorrows.Size = New System.Drawing.Size(170, 23)
        Me.lblTotalBorrows.TabIndex = 0
        Me.lblTotalBorrows.Text = "Total Borrow Records: 0"
        '
        'lblOverdueCount
        '
        Me.lblOverdueCount.AutoSize = True
        Me.lblOverdueCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblOverdueCount.ForeColor = System.Drawing.Color.Red
        Me.lblOverdueCount.Location = New System.Drawing.Point(20, 55)
        Me.lblOverdueCount.Name = "lblOverdueCount"
        Me.lblOverdueCount.Size = New System.Drawing.Size(130, 23)
        Me.lblOverdueCount.TabIndex = 1
        Me.lblOverdueCount.Text = "Overdue Books: 0"
        '
        'lblTotalFines
        '
        Me.lblTotalFines.AutoSize = True
        Me.lblTotalFines.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalFines.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalFines.Location = New System.Drawing.Point(20, 85)
        Me.lblTotalFines.Name = "lblTotalFines"
        Me.lblTotalFines.Size = New System.Drawing.Size(130, 23)
        Me.lblTotalFines.TabIndex = 2
        Me.lblTotalFines.Text = "Total Fines: Ksh. 0"
        '
        'lblAvgDays
        '
        Me.lblAvgDays.AutoSize = True
        Me.lblAvgDays.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvgDays.Location = New System.Drawing.Point(460, 25)
        Me.lblAvgDays.Name = "lblAvgDays"
        Me.lblAvgDays.Size = New System.Drawing.Size(220, 23)
        Me.lblAvgDays.TabIndex = 3
        Me.lblAvgDays.Text = "Average Borrowing Time: 0 days"
        '
        'lblAvgPerStudent
        '
        Me.lblAvgPerStudent.AutoSize = True
        Me.lblAvgPerStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvgPerStudent.Location = New System.Drawing.Point(460, 55)
        Me.lblAvgPerStudent.Name = "lblAvgPerStudent"
        Me.lblAvgPerStudent.Size = New System.Drawing.Size(340, 23)
        Me.lblAvgPerStudent.TabIndex = 4
        Me.lblAvgPerStudent.Text = "Average Borrowing Time Per Student:"
        '
        'btnViewOverdue
        '
        Me.btnViewOverdue.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnViewOverdue.Location = New System.Drawing.Point(40, 455)
        Me.btnViewOverdue.Name = "btnViewOverdue"
        Me.btnViewOverdue.Size = New System.Drawing.Size(170, 40)
        Me.btnViewOverdue.TabIndex = 3
        Me.btnViewOverdue.Text = "View Overdue Books"
        Me.btnViewOverdue.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnShowAll.Location = New System.Drawing.Point(230, 455)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(150, 40)
        Me.btnShowAll.TabIndex = 4
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClose.Location = New System.Drawing.Point(730, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnMainMenu.Location = New System.Drawing.Point(400, 455)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(160, 40)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.txtReport.Location = New System.Drawing.Point(40, 505)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReport.Size = New System.Drawing.Size(900, 150)
        Me.txtReport.TabIndex = 6
        Me.txtReport.Text = ""
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 680)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnViewOverdue)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.dgvBorrows)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrowing Report"
        CType(Me.dgvBorrows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents dgvBorrows As System.Windows.Forms.DataGridView
    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents lblAvgPerStudent As System.Windows.Forms.Label
    Friend WithEvents lblAvgDays As System.Windows.Forms.Label
    Friend WithEvents lblTotalFines As System.Windows.Forms.Label
    Friend WithEvents lblOverdueCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalBorrows As System.Windows.Forms.Label
    Friend WithEvents btnViewOverdue As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
End Class