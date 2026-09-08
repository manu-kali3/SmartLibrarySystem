<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferenceDataForm
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabCategories = New System.Windows.Forms.TabPage()
        Me.lblCategoryCount = New System.Windows.Forms.Label()
        Me.btnDeleteCategory = New System.Windows.Forms.Button()
        Me.lstCategories = New System.Windows.Forms.ListBox()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.lblCategoryName = New System.Windows.Forms.Label()
        Me.tabPublishers = New System.Windows.Forms.TabPage()
        Me.lblPublisherCount = New System.Windows.Forms.Label()
        Me.btnDeletePublisher = New System.Windows.Forms.Button()
        Me.lstPublishers = New System.Windows.Forms.ListBox()
        Me.btnAddPublisher = New System.Windows.Forms.Button()
        Me.txtPublisherName = New System.Windows.Forms.TextBox()
        Me.lblPublisherName = New System.Windows.Forms.Label()
        Me.tabDepartments = New System.Windows.Forms.TabPage()
        Me.lblDepartmentCount = New System.Windows.Forms.Label()
        Me.btnDeleteDepartment = New System.Windows.Forms.Button()
        Me.lstDepartments = New System.Windows.Forms.ListBox()
        Me.btnAddDepartment = New System.Windows.Forms.Button()
        Me.txtDepartmentName = New System.Windows.Forms.TextBox()
        Me.lblDepartmentName = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabControl.SuspendLayout()
        Me.tabCategories.SuspendLayout()
        Me.tabPublishers.SuspendLayout()
        Me.tabDepartments.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabCategories)
        Me.tabControl.Controls.Add(Me.tabPublishers)
        Me.tabControl.Controls.Add(Me.tabDepartments)
        Me.tabControl.Location = New System.Drawing.Point(35, 45)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(730, 500)
        Me.tabControl.TabIndex = 0
        '
        'tabCategories
        '
        Me.tabCategories.Controls.Add(Me.lblCategoryCount)
        Me.tabCategories.Controls.Add(Me.btnDeleteCategory)
        Me.tabCategories.Controls.Add(Me.lstCategories)
        Me.tabCategories.Controls.Add(Me.btnAddCategory)
        Me.tabCategories.Controls.Add(Me.txtCategoryName)
        Me.tabCategories.Controls.Add(Me.lblCategoryName)
        Me.tabCategories.Location = New System.Drawing.Point(4, 29)
        Me.tabCategories.Name = "tabCategories"
        Me.tabCategories.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCategories.Size = New System.Drawing.Size(722, 467)
        Me.tabCategories.TabIndex = 0
        Me.tabCategories.Text = "Book Categories"
        Me.tabCategories.UseVisualStyleBackColor = True
        '
        'lblCategoryName
        '
        Me.lblCategoryName.AutoSize = True
        Me.lblCategoryName.Location = New System.Drawing.Point(30, 26)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(62, 20)
        Me.lblCategoryName.TabIndex = 0
        Me.lblCategoryName.Text = "Category Name:"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(155, 22)
        Me.txtCategoryName.MaxLength = 100
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(300, 27)
        Me.txtCategoryName.TabIndex = 1
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddCategory.Location = New System.Drawing.Point(465, 20)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(140, 35)
        Me.btnAddCategory.TabIndex = 2
        Me.btnAddCategory.Text = "Add Category"
        Me.btnAddCategory.UseVisualStyleBackColor = True
        '
        'lstCategories
        '
        Me.lstCategories.FormattingEnabled = True
        Me.lstCategories.ItemHeight = 20
        Me.lstCategories.Location = New System.Drawing.Point(30, 70)
        Me.lstCategories.Name = "lstCategories"
        Me.lstCategories.Size = New System.Drawing.Size(660, 344)
        Me.lstCategories.TabIndex = 3
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDeleteCategory.Location = New System.Drawing.Point(30, 420)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(150, 35)
        Me.btnDeleteCategory.TabIndex = 4
        Me.btnDeleteCategory.Text = "Delete Selected"
        Me.btnDeleteCategory.UseVisualStyleBackColor = True
        '
        'lblCategoryCount
        '
        Me.lblCategoryCount.AutoSize = True
        Me.lblCategoryCount.ForeColor = System.Drawing.Color.Gray
        Me.lblCategoryCount.Location = New System.Drawing.Point(500, 427)
        Me.lblCategoryCount.Name = "lblCategoryCount"
        Me.lblCategoryCount.Size = New System.Drawing.Size(150, 20)
        Me.lblCategoryCount.TabIndex = 5
        Me.lblCategoryCount.Text = "Total categories: 0"
        '
        'tabPublishers
        '
        Me.tabPublishers.Controls.Add(Me.lblPublisherCount)
        Me.tabPublishers.Controls.Add(Me.btnDeletePublisher)
        Me.tabPublishers.Controls.Add(Me.lstPublishers)
        Me.tabPublishers.Controls.Add(Me.btnAddPublisher)
        Me.tabPublishers.Controls.Add(Me.txtPublisherName)
        Me.tabPublishers.Controls.Add(Me.lblPublisherName)
        Me.tabPublishers.Location = New System.Drawing.Point(4, 29)
        Me.tabPublishers.Name = "tabPublishers"
        Me.tabPublishers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPublishers.Size = New System.Drawing.Size(722, 467)
        Me.tabPublishers.TabIndex = 1
        Me.tabPublishers.Text = "Publishers"
        Me.tabPublishers.UseVisualStyleBackColor = True
        '
        'lblPublisherName
        '
        Me.lblPublisherName.AutoSize = True
        Me.lblPublisherName.Location = New System.Drawing.Point(30, 26)
        Me.lblPublisherName.Name = "lblPublisherName"
        Me.lblPublisherName.Size = New System.Drawing.Size(80, 20)
        Me.lblPublisherName.TabIndex = 0
        Me.lblPublisherName.Text = "Publisher Name:"
        '
        'txtPublisherName
        '
        Me.txtPublisherName.Location = New System.Drawing.Point(155, 22)
        Me.txtPublisherName.MaxLength = 100
        Me.txtPublisherName.Name = "txtPublisherName"
        Me.txtPublisherName.Size = New System.Drawing.Size(300, 27)
        Me.txtPublisherName.TabIndex = 1
        '
        'btnAddPublisher
        '
        Me.btnAddPublisher.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddPublisher.Location = New System.Drawing.Point(465, 20)
        Me.btnAddPublisher.Name = "btnAddPublisher"
        Me.btnAddPublisher.Size = New System.Drawing.Size(140, 35)
        Me.btnAddPublisher.TabIndex = 2
        Me.btnAddPublisher.Text = "Add Publisher"
        Me.btnAddPublisher.UseVisualStyleBackColor = True
        '
        'lstPublishers
        '
        Me.lstPublishers.FormattingEnabled = True
        Me.lstPublishers.ItemHeight = 20
        Me.lstPublishers.Location = New System.Drawing.Point(30, 70)
        Me.lstPublishers.Name = "lstPublishers"
        Me.lstPublishers.Size = New System.Drawing.Size(660, 344)
        Me.lstPublishers.TabIndex = 3
        '
        'btnDeletePublisher
        '
        Me.btnDeletePublisher.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDeletePublisher.Location = New System.Drawing.Point(30, 420)
        Me.btnDeletePublisher.Name = "btnDeletePublisher"
        Me.btnDeletePublisher.Size = New System.Drawing.Size(150, 35)
        Me.btnDeletePublisher.TabIndex = 4
        Me.btnDeletePublisher.Text = "Delete Selected"
        Me.btnDeletePublisher.UseVisualStyleBackColor = True
        '
        'lblPublisherCount
        '
        Me.lblPublisherCount.AutoSize = True
        Me.lblPublisherCount.ForeColor = System.Drawing.Color.Gray
        Me.lblPublisherCount.Location = New System.Drawing.Point(500, 427)
        Me.lblPublisherCount.Name = "lblPublisherCount"
        Me.lblPublisherCount.Size = New System.Drawing.Size(150, 20)
        Me.lblPublisherCount.TabIndex = 5
        Me.lblPublisherCount.Text = "Total publishers: 0"
        '
        'tabDepartments
        '
        Me.tabDepartments.Controls.Add(Me.lblDepartmentCount)
        Me.tabDepartments.Controls.Add(Me.btnDeleteDepartment)
        Me.tabDepartments.Controls.Add(Me.lstDepartments)
        Me.tabDepartments.Controls.Add(Me.btnAddDepartment)
        Me.tabDepartments.Controls.Add(Me.txtDepartmentName)
        Me.tabDepartments.Controls.Add(Me.lblDepartmentName)
        Me.tabDepartments.Location = New System.Drawing.Point(4, 29)
        Me.tabDepartments.Name = "tabDepartments"
        Me.tabDepartments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDepartments.Size = New System.Drawing.Size(722, 467)
        Me.tabDepartments.TabIndex = 2
        Me.tabDepartments.Text = "Departments"
        Me.tabDepartments.UseVisualStyleBackColor = True
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Location = New System.Drawing.Point(30, 26)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(95, 20)
        Me.lblDepartmentName.TabIndex = 0
        Me.lblDepartmentName.Text = "Department Name:"
        '
        'txtDepartmentName
        '
        Me.txtDepartmentName.Location = New System.Drawing.Point(155, 22)
        Me.txtDepartmentName.MaxLength = 100
        Me.txtDepartmentName.Name = "txtDepartmentName"
        Me.txtDepartmentName.Size = New System.Drawing.Size(300, 27)
        Me.txtDepartmentName.TabIndex = 1
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddDepartment.Location = New System.Drawing.Point(465, 20)
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.Size = New System.Drawing.Size(140, 35)
        Me.btnAddDepartment.TabIndex = 2
        Me.btnAddDepartment.Text = "Add Department"
        Me.btnAddDepartment.UseVisualStyleBackColor = True
        '
        'lstDepartments
        '
        Me.lstDepartments.FormattingEnabled = True
        Me.lstDepartments.ItemHeight = 20
        Me.lstDepartments.Location = New System.Drawing.Point(30, 70)
        Me.lstDepartments.Name = "lstDepartments"
        Me.lstDepartments.Size = New System.Drawing.Size(660, 344)
        Me.lstDepartments.TabIndex = 3
        '
        'btnDeleteDepartment
        '
        Me.btnDeleteDepartment.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnDeleteDepartment.Location = New System.Drawing.Point(30, 420)
        Me.btnDeleteDepartment.Name = "btnDeleteDepartment"
        Me.btnDeleteDepartment.Size = New System.Drawing.Size(150, 35)
        Me.btnDeleteDepartment.TabIndex = 4
        Me.btnDeleteDepartment.Text = "Delete Selected"
        Me.btnDeleteDepartment.UseVisualStyleBackColor = True
        '
        'lblDepartmentCount
        '
        Me.lblDepartmentCount.AutoSize = True
        Me.lblDepartmentCount.ForeColor = System.Drawing.Color.Gray
        Me.lblDepartmentCount.Location = New System.Drawing.Point(500, 427)
        Me.lblDepartmentCount.Name = "lblDepartmentCount"
        Me.lblDepartmentCount.Size = New System.Drawing.Size(160, 20)
        Me.lblDepartmentCount.TabIndex = 5
        Me.lblDepartmentCount.Text = "Total departments: 0"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnMainMenu.Location = New System.Drawing.Point(35, 560)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(150, 40)
        Me.btnMainMenu.TabIndex = 1
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClose.Location = New System.Drawing.Point(615, 560)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ReferenceDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReferenceDataForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reference Data"
        Me.tabControl.ResumeLayout(False)
        Me.tabDepartments.ResumeLayout(False)
        Me.tabDepartments.PerformLayout()
        Me.tabPublishers.ResumeLayout(False)
        Me.tabPublishers.PerformLayout()
        Me.tabCategories.ResumeLayout(False)
        Me.tabCategories.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabCategories As System.Windows.Forms.TabPage
    Friend WithEvents lblCategoryName As System.Windows.Forms.Label
    Friend WithEvents txtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCategory As System.Windows.Forms.Button
    Friend WithEvents lstCategories As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteCategory As System.Windows.Forms.Button
    Friend WithEvents lblCategoryCount As System.Windows.Forms.Label
    Friend WithEvents tabPublishers As System.Windows.Forms.TabPage
    Friend WithEvents lblPublisherName As System.Windows.Forms.Label
    Friend WithEvents txtPublisherName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPublisher As System.Windows.Forms.Button
    Friend WithEvents lstPublishers As System.Windows.Forms.ListBox
    Friend WithEvents btnDeletePublisher As System.Windows.Forms.Button
    Friend WithEvents lblPublisherCount As System.Windows.Forms.Label
    Friend WithEvents tabDepartments As System.Windows.Forms.TabPage
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents txtDepartmentName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddDepartment As System.Windows.Forms.Button
    Friend WithEvents lstDepartments As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteDepartment As System.Windows.Forms.Button
    Friend WithEvents lblDepartmentCount As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class