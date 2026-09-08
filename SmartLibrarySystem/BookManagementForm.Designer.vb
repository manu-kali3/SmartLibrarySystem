<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookManagementForm
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
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnViewAvailable = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(250, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(230, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Book Management"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(45, 75)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(62, 20)
        Me.lblBookID.TabIndex = 1
        Me.lblBookID.Text = "Book ID"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(190, 70)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(220, 27)
        Me.txtBookID.TabIndex = 2
        Me.txtBookID.Text = "Auto-generated"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Location = New System.Drawing.Point(45, 115)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(78, 20)
        Me.lblBookTitle.TabIndex = 3
        Me.lblBookTitle.Text = "Book Title"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(190, 110)
        Me.txtBookTitle.MaxLength = 100
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(220, 27)
        Me.txtBookTitle.TabIndex = 4
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(45, 155)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(55, 20)
        Me.lblAuthor.TabIndex = 5
        Me.lblAuthor.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(190, 150)
        Me.txtAuthor.MaxLength = 100
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(220, 27)
        Me.txtAuthor.TabIndex = 6
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(45, 195)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(118, 20)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity in stock"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(190, 190)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(220, 27)
        Me.txtQuantity.TabIndex = 8
        '
        'btnAddBook
        '
        Me.btnAddBook.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddBook.Location = New System.Drawing.Point(45, 245)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(170, 40)
        Me.btnAddBook.TabIndex = 9
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnViewAvailable
        '
        Me.btnViewAvailable.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnViewAvailable.Location = New System.Drawing.Point(240, 245)
        Me.btnViewAvailable.Name = "btnViewAvailable"
        Me.btnViewAvailable.Size = New System.Drawing.Size(170, 40)
        Me.btnViewAvailable.TabIndex = 10
        Me.btnViewAvailable.Text = "View Available Books"
        Me.btnViewAvailable.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(45, 300)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(170, 40)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClose.Location = New System.Drawing.Point(240, 300)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(170, 40)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnMainMenu.Location = New System.Drawing.Point(435, 300)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(170, 40)
        Me.btnMainMenu.TabIndex = 15
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToOrderColumns = True
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(45, 365)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.RowTemplate.Height = 24
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(700, 250)
        Me.dgvBooks.TabIndex = 13
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(45, 625)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(90, 20)
        Me.lblCount.TabIndex = 14
        Me.lblCount.Text = "Total books: 0"
        '
        'BookManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnViewAvailable)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BookManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Management"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents btnViewAvailable As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class