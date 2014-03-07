<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrolForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrolForm))
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniBlueDBDataSet = New ICT3611_Assignment1.UniBlueDBDataSet()
        Me.DelStudButton = New System.Windows.Forms.Button()
        Me.EnrolNewButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StudentNumTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.InitialsTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UniBlueDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New ICT3611_Assignment1.UniBlueDBDataSetTableAdapters.StudentTableAdapter()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniBlueDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UniBlueDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNum, Me.TitleDataGridViewTextBoxColumn, Me.InitialsDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(0, 37)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(602, 334)
        Me.StudentDataGridView.TabIndex = 2
        '
        'StudentNum
        '
        Me.StudentNum.DataPropertyName = "StudentNumber"
        Me.StudentNum.HeaderText = "StudentNum"
        Me.StudentNum.Name = "StudentNum"
        Me.StudentNum.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InitialsDataGridViewTextBoxColumn
        '
        Me.InitialsDataGridViewTextBoxColumn.DataPropertyName = "Initials"
        Me.InitialsDataGridViewTextBoxColumn.HeaderText = "Initials"
        Me.InitialsDataGridViewTextBoxColumn.Name = "InitialsDataGridViewTextBoxColumn"
        Me.InitialsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.UniBlueDBDataSet
        '
        'UniBlueDBDataSet
        '
        Me.UniBlueDBDataSet.DataSetName = "UniBlueDBDataSet"
        Me.UniBlueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DelStudButton
        '
        Me.DelStudButton.BackColor = System.Drawing.Color.Red
        Me.DelStudButton.Location = New System.Drawing.Point(121, 377)
        Me.DelStudButton.Name = "DelStudButton"
        Me.DelStudButton.Size = New System.Drawing.Size(105, 32)
        Me.DelStudButton.TabIndex = 3
        Me.DelStudButton.Text = "Delete Student"
        Me.DelStudButton.UseVisualStyleBackColor = False
        '
        'EnrolNewButton
        '
        Me.EnrolNewButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.EnrolNewButton.Location = New System.Drawing.Point(15, 373)
        Me.EnrolNewButton.Name = "EnrolNewButton"
        Me.EnrolNewButton.Size = New System.Drawing.Size(274, 32)
        Me.EnrolNewButton.TabIndex = 4
        Me.EnrolNewButton.Text = "Start New Enrolment"
        Me.EnrolNewButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(490, 377)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(112, 32)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.StudentNumTextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.SurnameTextBox)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Me.EnrolNewButton)
        Me.Panel1.Controls.Add(Me.InitialsTextBox)
        Me.Panel1.Controls.Add(Me.TitleTextBox)
        Me.Panel1.Controls.Add(Me.BirthDateTimePicker)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 412)
        Me.Panel1.TabIndex = 6
        '
        'StudentNumTextBox
        '
        Me.StudentNumTextBox.Location = New System.Drawing.Point(111, 44)
        Me.StudentNumTextBox.Name = "StudentNumTextBox"
        Me.StudentNumTextBox.ReadOnly = True
        Me.StudentNumTextBox.Size = New System.Drawing.Size(178, 20)
        Me.StudentNumTextBox.TabIndex = 18
        Me.StudentNumTextBox.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Student #"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 26)
        Me.Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student Details "
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(111, 164)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.SurnameTextBox.TabIndex = 15
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(111, 208)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(178, 78)
        Me.AddressTextBox.TabIndex = 14
        '
        'InitialsTextBox
        '
        Me.InitialsTextBox.Location = New System.Drawing.Point(111, 122)
        Me.InitialsTextBox.Name = "InitialsTextBox"
        Me.InitialsTextBox.Size = New System.Drawing.Size(178, 20)
        Me.InitialsTextBox.TabIndex = 13
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(111, 85)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(63, 20)
        Me.TitleTextBox.TabIndex = 12
        '
        'BirthDateTimePicker
        '
        Me.BirthDateTimePicker.Location = New System.Drawing.Point(111, 310)
        Me.BirthDateTimePicker.Name = "BirthDateTimePicker"
        Me.BirthDateTimePicker.Size = New System.Drawing.Size(178, 20)
        Me.BirthDateTimePicker.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Birth Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Initials"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tiltle"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UpdateButton)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.StudentDataGridView)
        Me.Panel3.Controls.Add(Me.DelStudButton)
        Me.Panel3.Controls.Add(Me.CloseButton)
        Me.Panel3.Location = New System.Drawing.Point(325, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(605, 412)
        Me.Panel3.TabIndex = 7
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UpdateButton.Location = New System.Drawing.Point(3, 377)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(110, 32)
        Me.UpdateButton.TabIndex = 18
        Me.UpdateButton.Text = "Update Info"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(599, 26)
        Me.Panel4.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Student Record Selection"
        '
        'UniBlueDBDataSetBindingSource
        '
        Me.UniBlueDBDataSetBindingSource.DataSource = Me.UniBlueDBDataSet
        Me.UniBlueDBDataSetBindingSource.Position = 0
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'EnrolForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 436)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 470)
        Me.MinimumSize = New System.Drawing.Size(950, 470)
        Me.Name = "EnrolForm"
        Me.Text = "EnrolForm"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniBlueDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.UniBlueDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DelStudButton As System.Windows.Forms.Button
    Friend WithEvents EnrolNewButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InitialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UniBlueDBDataSet As ICT3611_Assignment1.UniBlueDBDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As ICT3611_Assignment1.UniBlueDBDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents UniBlueDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InitialsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
