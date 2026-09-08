<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookForm
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchHint = New System.Windows.Forms.Label()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblBorrowIDValue = New System.Windows.Forms.Label()
        Me.lblBorrowID = New System.Windows.Forms.Label()
        Me.lblTimeBorrowedValue = New System.Windows.Forms.Label()
        Me.lblTimeBorrowed = New System.Windows.Forms.Label()
        Me.lblIssuedByValue = New System.Windows.Forms.Label()
        Me.lblIssuedBy = New System.Windows.Forms.Label()
        Me.lblBorrowerNameValue = New System.Windows.Forms.Label()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.lblBookTitleValue = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblBorrowDateValue = New System.Windows.Forms.Label()
        Me.lblBorrowDate = New System.Windows.Forms.Label()
        Me.lblReturnDeadlineValue = New System.Windows.Forms.Label()
        Me.lblReturnDeadline = New System.Windows.Forms.Label()
        Me.lblDaysBorrowedValue = New System.Windows.Forms.Label()
        Me.lblDaysBorrowed = New System.Windows.Forms.Label()
        Me.lblDaysOverdueValue = New System.Windows.Forms.Label()
        Me.lblDaysOverdue = New System.Windows.Forms.Label()
        Me.lblFineValue = New System.Windows.Forms.Label()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.lblStatusValue = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpDetails.SuspendLayout()
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
        Me.lblHeader.Text = "Return Book"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(60, 80)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(150, 20)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Admission No / Book ID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(220, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 27)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(540, 70)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 36)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Find Borrow"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearchHint
        '
        Me.lblSearchHint.AutoSize = True
        Me.lblSearchHint.ForeColor = System.Drawing.Color.Gray
        Me.lblSearchHint.Location = New System.Drawing.Point(220, 108)
        Me.lblSearchHint.Name = "lblSearchHint"
        Me.lblSearchHint.Size = New System.Drawing.Size(300, 20)
        Me.lblSearchHint.TabIndex = 4
        Me.lblSearchHint.Text = "Search hint..."
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblStatus)
        Me.grpDetails.Controls.Add(Me.lblStatusValue)
        Me.grpDetails.Controls.Add(Me.lblFine)
        Me.grpDetails.Controls.Add(Me.lblFineValue)
        Me.grpDetails.Controls.Add(Me.lblDaysOverdue)
        Me.grpDetails.Controls.Add(Me.lblDaysOverdueValue)
        Me.grpDetails.Controls.Add(Me.lblDaysBorrowed)
        Me.grpDetails.Controls.Add(Me.lblDaysBorrowedValue)
        Me.grpDetails.Controls.Add(Me.lblReturnDeadline)
        Me.grpDetails.Controls.Add(Me.lblReturnDeadlineValue)
        Me.grpDetails.Controls.Add(Me.lblBorrowDate)
        Me.grpDetails.Controls.Add(Me.lblBorrowDateValue)
        Me.grpDetails.Controls.Add(Me.lblBookTitle)
        Me.grpDetails.Controls.Add(Me.lblBookTitleValue)
        Me.grpDetails.Controls.Add(Me.lblBorrowerName)
        Me.grpDetails.Controls.Add(Me.lblBorrowerNameValue)
        Me.grpDetails.Controls.Add(Me.lblIssuedBy)
        Me.grpDetails.Controls.Add(Me.lblIssuedByValue)
        Me.grpDetails.Controls.Add(Me.lblTimeBorrowed)
        Me.grpDetails.Controls.Add(Me.lblTimeBorrowedValue)
        Me.grpDetails.Controls.Add(Me.lblBorrowID)
        Me.grpDetails.Controls.Add(Me.lblBorrowIDValue)
        Me.grpDetails.Location = New System.Drawing.Point(60, 145)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(600, 360)
        Me.grpDetails.TabIndex = 5
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Borrow Details"
        '
        'lblBorrowID
        '
        Me.lblBorrowID.AutoSize = True
        Me.lblBorrowID.Location = New System.Drawing.Point(30, 32)
        Me.lblBorrowID.Name = "lblBorrowID"
        Me.lblBorrowID.Size = New System.Drawing.Size(75, 20)
        Me.lblBorrowID.TabIndex = 6
        Me.lblBorrowID.Text = "Borrow ID:"
        '
        'lblBorrowIDValue
        '
        Me.lblBorrowIDValue.AutoSize = True
        Me.lblBorrowIDValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowIDValue.Location = New System.Drawing.Point(250, 32)
        Me.lblBorrowIDValue.Name = "lblBorrowIDValue"
        Me.lblBorrowIDValue.Size = New System.Drawing.Size(17, 20)
        Me.lblBorrowIDValue.TabIndex = 7
        Me.lblBorrowIDValue.Text = "-"
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.AutoSize = True
        Me.lblBorrowerName.Location = New System.Drawing.Point(30, 62)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(115, 20)
        Me.lblBorrowerName.TabIndex = 8
        Me.lblBorrowerName.Text = "Borrower Name:"
        '
        'lblBorrowerNameValue
        '
        Me.lblBorrowerNameValue.AutoSize = True
        Me.lblBorrowerNameValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowerNameValue.Location = New System.Drawing.Point(250, 62)
        Me.lblBorrowerNameValue.Name = "lblBorrowerNameValue"
        Me.lblBorrowerNameValue.Size = New System.Drawing.Size(17, 20)
        Me.lblBorrowerNameValue.TabIndex = 9
        Me.lblBorrowerNameValue.Text = "-"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Location = New System.Drawing.Point(30, 92)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(78, 20)
        Me.lblBookTitle.TabIndex = 10
        Me.lblBookTitle.Text = "Book Title:"
        '
        'lblBookTitleValue
        '
        Me.lblBookTitleValue.AutoSize = True
        Me.lblBookTitleValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBookTitleValue.Location = New System.Drawing.Point(250, 92)
        Me.lblBookTitleValue.Name = "lblBookTitleValue"
        Me.lblBookTitleValue.Size = New System.Drawing.Size(17, 20)
        Me.lblBookTitleValue.TabIndex = 11
        Me.lblBookTitleValue.Text = "-"
        '
        'lblBorrowDate
        '
        Me.lblBorrowDate.AutoSize = True
        Me.lblBorrowDate.Location = New System.Drawing.Point(30, 122)
        Me.lblBorrowDate.Name = "lblBorrowDate"
        Me.lblBorrowDate.Size = New System.Drawing.Size(95, 20)
        Me.lblBorrowDate.TabIndex = 12
        Me.lblBorrowDate.Text = "Borrow Date:"
        '
        'lblBorrowDateValue
        '
        Me.lblBorrowDateValue.AutoSize = True
        Me.lblBorrowDateValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowDateValue.Location = New System.Drawing.Point(250, 122)
        Me.lblBorrowDateValue.Name = "lblBorrowDateValue"
        Me.lblBorrowDateValue.Size = New System.Drawing.Size(17, 20)
        Me.lblBorrowDateValue.TabIndex = 13
        Me.lblBorrowDateValue.Text = "-"
        '
        'lblReturnDeadline
        '
        Me.lblReturnDeadline.AutoSize = True
        Me.lblReturnDeadline.Location = New System.Drawing.Point(30, 152)
        Me.lblReturnDeadline.Name = "lblReturnDeadline"
        Me.lblReturnDeadline.Size = New System.Drawing.Size(113, 20)
        Me.lblReturnDeadline.TabIndex = 14
        Me.lblReturnDeadline.Text = "Return Deadline:"
        '
        'lblReturnDeadlineValue
        '
        Me.lblReturnDeadlineValue.AutoSize = True
        Me.lblReturnDeadlineValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnDeadlineValue.Location = New System.Drawing.Point(250, 152)
        Me.lblReturnDeadlineValue.Name = "lblReturnDeadlineValue"
        Me.lblReturnDeadlineValue.Size = New System.Drawing.Size(17, 20)
        Me.lblReturnDeadlineValue.TabIndex = 15
        Me.lblReturnDeadlineValue.Text = "-"
        '
        'lblDaysBorrowed
        '
        Me.lblDaysBorrowed.AutoSize = True
        Me.lblDaysBorrowed.Location = New System.Drawing.Point(30, 182)
        Me.lblDaysBorrowed.Name = "lblDaysBorrowed"
        Me.lblDaysBorrowed.Size = New System.Drawing.Size(107, 20)
        Me.lblDaysBorrowed.TabIndex = 16
        Me.lblDaysBorrowed.Text = "Days Borrowed:"
        '
        'lblDaysBorrowedValue
        '
        Me.lblDaysBorrowedValue.AutoSize = True
        Me.lblDaysBorrowedValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDaysBorrowedValue.Location = New System.Drawing.Point(250, 182)
        Me.lblDaysBorrowedValue.Name = "lblDaysBorrowedValue"
        Me.lblDaysBorrowedValue.Size = New System.Drawing.Size(17, 20)
        Me.lblDaysBorrowedValue.TabIndex = 17
        Me.lblDaysBorrowedValue.Text = "-"
        '
        'lblDaysOverdue
        '
        Me.lblDaysOverdue.AutoSize = True
        Me.lblDaysOverdue.Location = New System.Drawing.Point(30, 212)
        Me.lblDaysOverdue.Name = "lblDaysOverdue"
        Me.lblDaysOverdue.Size = New System.Drawing.Size(105, 20)
        Me.lblDaysOverdue.TabIndex = 18
        Me.lblDaysOverdue.Text = "Days Overdue:"
        '
        'lblDaysOverdueValue
        '
        Me.lblDaysOverdueValue.AutoSize = True
        Me.lblDaysOverdueValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDaysOverdueValue.Location = New System.Drawing.Point(250, 212)
        Me.lblDaysOverdueValue.Name = "lblDaysOverdueValue"
        Me.lblDaysOverdueValue.Size = New System.Drawing.Size(17, 20)
        Me.lblDaysOverdueValue.TabIndex = 19
        Me.lblDaysOverdueValue.Text = "-"
        '
        'lblFine
        '
        Me.lblFine.AutoSize = True
        Me.lblFine.Location = New System.Drawing.Point(30, 242)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.Size = New System.Drawing.Size(90, 20)
        Me.lblFine.TabIndex = 20
        Me.lblFine.Text = "Fine Amount:"
        '
        'lblFineValue
        '
        Me.lblFineValue.AutoSize = True
        Me.lblFineValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFineValue.Location = New System.Drawing.Point(250, 242)
        Me.lblFineValue.Name = "lblFineValue"
        Me.lblFineValue.Size = New System.Drawing.Size(60, 20)
        Me.lblFineValue.TabIndex = 21
        Me.lblFineValue.Text = "Ksh. 0.00"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(30, 272)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(55, 20)
        Me.lblStatus.TabIndex = 22
        Me.lblStatus.Text = "Status:"
        '
        'lblStatusValue
        '
        Me.lblStatusValue.AutoSize = True
        Me.lblStatusValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatusValue.Location = New System.Drawing.Point(250, 272)
        Me.lblStatusValue.Name = "lblStatusValue"
        Me.lblStatusValue.Size = New System.Drawing.Size(17, 20)
        Me.lblStatusValue.TabIndex = 23
        Me.lblStatusValue.Text = "-"
        '
        'lblIssuedBy
        '
        Me.lblIssuedBy.AutoSize = True
        Me.lblIssuedBy.Location = New System.Drawing.Point(30, 302)
        Me.lblIssuedBy.Name = "lblIssuedBy"
        Me.lblIssuedBy.Size = New System.Drawing.Size(72, 20)
        Me.lblIssuedBy.TabIndex = 24
        Me.lblIssuedBy.Text = "Issued By:"
        '
        'lblIssuedByValue
        '
        Me.lblIssuedByValue.AutoSize = True
        Me.lblIssuedByValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIssuedByValue.Location = New System.Drawing.Point(250, 302)
        Me.lblIssuedByValue.Name = "lblIssuedByValue"
        Me.lblIssuedByValue.Size = New System.Drawing.Size(17, 20)
        Me.lblIssuedByValue.TabIndex = 25
        Me.lblIssuedByValue.Text = "-"
        '
        'lblTimeBorrowed
        '
        Me.lblTimeBorrowed.AutoSize = True
        Me.lblTimeBorrowed.Location = New System.Drawing.Point(30, 332)
        Me.lblTimeBorrowed.Name = "lblTimeBorrowed"
        Me.lblTimeBorrowed.Size = New System.Drawing.Size(112, 20)
        Me.lblTimeBorrowed.TabIndex = 26
        Me.lblTimeBorrowed.Text = "Time Borrowed:"
        '
        'lblTimeBorrowedValue
        '
        Me.lblTimeBorrowedValue.AutoSize = True
        Me.lblTimeBorrowedValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimeBorrowedValue.Location = New System.Drawing.Point(250, 332)
        Me.lblTimeBorrowedValue.Name = "lblTimeBorrowedValue"
        Me.lblTimeBorrowedValue.Size = New System.Drawing.Size(17, 20)
        Me.lblTimeBorrowedValue.TabIndex = 27
        Me.lblTimeBorrowedValue.Text = "-"
        '
        'btnReturn
        '
        Me.btnReturn.Enabled = False
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReturn.Location = New System.Drawing.Point(180, 530)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(180, 45)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClose.Location = New System.Drawing.Point(390, 530)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 45)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ReturnBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 600)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblSearchHint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReturnBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Book"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchHint As System.Windows.Forms.Label
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblBorrowID As System.Windows.Forms.Label
    Friend WithEvents lblBorrowIDValue As System.Windows.Forms.Label
    Friend WithEvents lblBorrowerName As System.Windows.Forms.Label
    Friend WithEvents lblBorrowerNameValue As System.Windows.Forms.Label
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents lblBookTitleValue As System.Windows.Forms.Label
    Friend WithEvents lblBorrowDate As System.Windows.Forms.Label
    Friend WithEvents lblBorrowDateValue As System.Windows.Forms.Label
    Friend WithEvents lblReturnDeadline As System.Windows.Forms.Label
    Friend WithEvents lblReturnDeadlineValue As System.Windows.Forms.Label
    Friend WithEvents lblDaysBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblDaysBorrowedValue As System.Windows.Forms.Label
    Friend WithEvents lblDaysOverdue As System.Windows.Forms.Label
    Friend WithEvents lblDaysOverdueValue As System.Windows.Forms.Label
    Friend WithEvents lblFine As System.Windows.Forms.Label
    Friend WithEvents lblFineValue As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblStatusValue As System.Windows.Forms.Label
    Friend WithEvents lblIssuedBy As System.Windows.Forms.Label
    Friend WithEvents lblIssuedByValue As System.Windows.Forms.Label
    Friend WithEvents lblTimeBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblTimeBorrowedValue As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class