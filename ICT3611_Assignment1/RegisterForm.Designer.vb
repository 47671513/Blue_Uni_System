<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModuleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InitialsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ModuleCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ModCreateButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StudentNumTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ModuleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ModuleDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(376, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 412)
        Me.Panel3.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 256)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(548, 151)
        Me.DataGridView1.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Semester"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Semester"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(3, 224)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(548, 26)
        Me.Panel6.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(164, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Enrolled Modules For this Student"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(548, 26)
        Me.Panel4.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Active Modules"
        '
        'ModuleDataGridView
        '
        Me.ModuleDataGridView.AllowUserToAddRows = False
        Me.ModuleDataGridView.AllowUserToDeleteRows = False
        Me.ModuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModuleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Semester})
        Me.ModuleDataGridView.Location = New System.Drawing.Point(3, 37)
        Me.ModuleDataGridView.MultiSelect = False
        Me.ModuleDataGridView.Name = "ModuleDataGridView"
        Me.ModuleDataGridView.ReadOnly = True
        Me.ModuleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ModuleDataGridView.Size = New System.Drawing.Size(548, 177)
        Me.ModuleDataGridView.TabIndex = 2
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(3, 370)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(351, 32)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SemesterComboBox)
        Me.Panel1.Controls.Add(Me.SurnameTextBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GetDataButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.YearComboBox)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.InitialsTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ModuleCodeTextBox)
        Me.Panel1.Controls.Add(Me.ModCreateButton)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.StudentNumTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 412)
        Me.Panel1.TabIndex = 10
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.Enabled = False
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Location = New System.Drawing.Point(144, 281)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(95, 21)
        Me.SemesterComboBox.TabIndex = 39
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(91, 119)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.ReadOnly = True
        Me.SurnameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.SurnameTextBox.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Surname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Select Semester"
        '
        'GetDataButton
        '
        Me.GetDataButton.Location = New System.Drawing.Point(242, 46)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(75, 23)
        Me.GetDataButton.TabIndex = 29
        Me.GetDataButton.Text = "Get Data"
        Me.GetDataButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(187, 332)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(167, 32)
        Me.UpdateButton.TabIndex = 18
        Me.UpdateButton.Text = "Remove Module"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'YearComboBox
        '
        Me.YearComboBox.Enabled = False
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(144, 241)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(95, 21)
        Me.YearComboBox.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(3, 158)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(351, 26)
        Me.Panel5.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(114, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Module Enrolment"
        '
        'InitialsTextBox
        '
        Me.InitialsTextBox.Location = New System.Drawing.Point(91, 84)
        Me.InitialsTextBox.Name = "InitialsTextBox"
        Me.InitialsTextBox.ReadOnly = True
        Me.InitialsTextBox.Size = New System.Drawing.Size(138, 20)
        Me.InitialsTextBox.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Initials"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 26)
        Me.Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student Selection"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Select Year"
        '
        'ModuleCodeTextBox
        '
        Me.ModuleCodeTextBox.Location = New System.Drawing.Point(115, 206)
        Me.ModuleCodeTextBox.Name = "ModuleCodeTextBox"
        Me.ModuleCodeTextBox.Size = New System.Drawing.Size(216, 20)
        Me.ModuleCodeTextBox.TabIndex = 34
        '
        'ModCreateButton
        '
        Me.ModCreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ModCreateButton.Location = New System.Drawing.Point(3, 332)
        Me.ModCreateButton.Name = "ModCreateButton"
        Me.ModCreateButton.Size = New System.Drawing.Size(178, 32)
        Me.ModCreateButton.TabIndex = 4
        Me.ModCreateButton.Text = "Enrol Module"
        Me.ModCreateButton.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Module Code"
        '
        'StudentNumTextBox
        '
        Me.StudentNumTextBox.Location = New System.Drawing.Point(91, 48)
        Me.StudentNumTextBox.Name = "StudentNumTextBox"
        Me.StudentNumTextBox.Size = New System.Drawing.Size(138, 20)
        Me.StudentNumTextBox.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Student #"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 436)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(950, 470)
        Me.MinimumSize = New System.Drawing.Size(950, 470)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ModuleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModuleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Semester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents InitialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ModCreateButton As System.Windows.Forms.Button
    Friend WithEvents StudentNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GetDataButton As System.Windows.Forms.Button
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SemesterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ModuleCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
