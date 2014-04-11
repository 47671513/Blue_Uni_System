<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModManForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModManForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModuleDataGridView = New System.Windows.Forms.DataGridView()
        Me.ModulesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniBlueDBDataSet = New ICT3611_Assignment1.UniBlueDBDataSet()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ModulesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniBlueDBDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.ModuleTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ModuleIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModCreateButton = New System.Windows.Forms.Button()
        Me.ModuleCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UniBlueDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulesTableAdapter = New ICT3611_Assignment1.UniBlueDBDataSetTableAdapters.ModulesTableAdapter()
        Me.ModulesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModuleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ModuleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniBlueDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniBlueDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UniBlueDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModulesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ModuleDataGridView)
        Me.Panel3.Controls.Add(Me.CloseButton)
        Me.Panel3.Location = New System.Drawing.Point(376, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 412)
        Me.Panel3.TabIndex = 9
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
        Me.Label1.Location = New System.Drawing.Point(208, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Module Selection"
        '
        'ModuleDataGridView
        '
        Me.ModuleDataGridView.AllowUserToAddRows = False
        Me.ModuleDataGridView.AllowUserToDeleteRows = False
        Me.ModuleDataGridView.AutoGenerateColumns = False
        Me.ModuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModuleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModuleIDDataGridViewTextBoxColumn, Me.ModuleCodeDataGridViewTextBoxColumn, Me.MTitleDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn, Me.AYearDataGridViewTextBoxColumn, Me.Semester})
        Me.ModuleDataGridView.DataSource = Me.ModulesBindingSource4
        Me.ModuleDataGridView.Location = New System.Drawing.Point(3, 37)
        Me.ModuleDataGridView.MultiSelect = False
        Me.ModuleDataGridView.Name = "ModuleDataGridView"
        Me.ModuleDataGridView.ReadOnly = True
        Me.ModuleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ModuleDataGridView.Size = New System.Drawing.Size(548, 321)
        Me.ModuleDataGridView.TabIndex = 2
        '
        'ModulesBindingSource4
        '
        Me.ModulesBindingSource4.DataMember = "Modules"
        Me.ModulesBindingSource4.DataSource = Me.UniBlueDBDataSet
        '
        'UniBlueDBDataSet
        '
        Me.UniBlueDBDataSet.DataSetName = "UniBlueDBDataSet"
        Me.UniBlueDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(439, 375)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(112, 32)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'ModulesBindingSource
        '
        Me.ModulesBindingSource.DataMember = "Modules"
        Me.ModulesBindingSource.DataSource = Me.UniBlueDBDataSetBindingSource1
        '
        'UniBlueDBDataSetBindingSource1
        '
        Me.UniBlueDBDataSetBindingSource1.DataSource = Me.UniBlueDBDataSet
        Me.UniBlueDBDataSetBindingSource1.Position = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(3, 373)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(351, 32)
        Me.UpdateButton.TabIndex = 18
        Me.UpdateButton.Text = "Update Module Activation"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ActiveCheckBox)
        Me.Panel1.Controls.Add(Me.SemesterComboBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.YearComboBox)
        Me.Panel1.Controls.Add(Me.ModuleTitleTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ModuleIDTextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ModCreateButton)
        Me.Panel1.Controls.Add(Me.ModuleCodeTextBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 412)
        Me.Panel1.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(3, 222)
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
        Me.Label9.Size = New System.Drawing.Size(135, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Module Activation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Active"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(115, 264)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 26
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.Enabled = False
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Location = New System.Drawing.Point(115, 335)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(95, 21)
        Me.SemesterComboBox.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Semester"
        '
        'YearComboBox
        '
        Me.YearComboBox.Enabled = False
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(115, 295)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(95, 21)
        Me.YearComboBox.TabIndex = 23
        '
        'ModuleTitleTextBox
        '
        Me.ModuleTitleTextBox.Location = New System.Drawing.Point(111, 138)
        Me.ModuleTitleTextBox.Name = "ModuleTitleTextBox"
        Me.ModuleTitleTextBox.Size = New System.Drawing.Size(232, 20)
        Me.ModuleTitleTextBox.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Module Title"
        '
        'ModuleIDTextBox
        '
        Me.ModuleIDTextBox.Location = New System.Drawing.Point(111, 49)
        Me.ModuleIDTextBox.Name = "ModuleIDTextBox"
        Me.ModuleIDTextBox.ReadOnly = True
        Me.ModuleIDTextBox.Size = New System.Drawing.Size(232, 20)
        Me.ModuleIDTextBox.TabIndex = 18
        Me.ModuleIDTextBox.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Module ID"
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
        Me.Label2.Size = New System.Drawing.Size(114, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Module Details"
        '
        'ModCreateButton
        '
        Me.ModCreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ModCreateButton.Location = New System.Drawing.Point(3, 180)
        Me.ModCreateButton.Name = "ModCreateButton"
        Me.ModCreateButton.Size = New System.Drawing.Size(351, 32)
        Me.ModCreateButton.TabIndex = 4
        Me.ModCreateButton.Text = "Create New Module"
        Me.ModCreateButton.UseVisualStyleBackColor = False
        '
        'ModuleCodeTextBox
        '
        Me.ModuleCodeTextBox.Location = New System.Drawing.Point(111, 93)
        Me.ModuleCodeTextBox.Name = "ModuleCodeTextBox"
        Me.ModuleCodeTextBox.Size = New System.Drawing.Size(232, 20)
        Me.ModuleCodeTextBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Start Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Module Code"
        '
        'UniBlueDBDataSetBindingSource
        '
        Me.UniBlueDBDataSetBindingSource.DataSource = Me.UniBlueDBDataSet
        Me.UniBlueDBDataSetBindingSource.Position = 0
        '
        'ModulesTableAdapter
        '
        Me.ModulesTableAdapter.ClearBeforeFill = True
        '
        'ModulesBindingSource1
        '
        Me.ModulesBindingSource1.DataMember = "Modules"
        Me.ModulesBindingSource1.DataSource = Me.UniBlueDBDataSetBindingSource1
        '
        'ModulesBindingSource2
        '
        Me.ModulesBindingSource2.DataMember = "Modules"
        Me.ModulesBindingSource2.DataSource = Me.UniBlueDBDataSetBindingSource
        '
        'ModulesBindingSource3
        '
        Me.ModulesBindingSource3.DataMember = "Modules"
        Me.ModulesBindingSource3.DataSource = Me.UniBlueDBDataSetBindingSource
        '
        'ModuleIDDataGridViewTextBoxColumn
        '
        Me.ModuleIDDataGridViewTextBoxColumn.DataPropertyName = "ModuleID"
        Me.ModuleIDDataGridViewTextBoxColumn.HeaderText = "ModuleID"
        Me.ModuleIDDataGridViewTextBoxColumn.Name = "ModuleIDDataGridViewTextBoxColumn"
        Me.ModuleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModuleCodeDataGridViewTextBoxColumn
        '
        Me.ModuleCodeDataGridViewTextBoxColumn.DataPropertyName = "ModuleCode"
        Me.ModuleCodeDataGridViewTextBoxColumn.HeaderText = "ModuleCode"
        Me.ModuleCodeDataGridViewTextBoxColumn.Name = "ModuleCodeDataGridViewTextBoxColumn"
        Me.ModuleCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MTitleDataGridViewTextBoxColumn
        '
        Me.MTitleDataGridViewTextBoxColumn.DataPropertyName = "MTitle"
        Me.MTitleDataGridViewTextBoxColumn.HeaderText = "MTitle"
        Me.MTitleDataGridViewTextBoxColumn.Name = "MTitleDataGridViewTextBoxColumn"
        Me.MTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AYearDataGridViewTextBoxColumn
        '
        Me.AYearDataGridViewTextBoxColumn.DataPropertyName = "AYear"
        Me.AYearDataGridViewTextBoxColumn.HeaderText = "AYear"
        Me.AYearDataGridViewTextBoxColumn.Name = "AYearDataGridViewTextBoxColumn"
        Me.AYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester1"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        '
        'ModManForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 436)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 470)
        Me.MinimumSize = New System.Drawing.Size(950, 470)
        Me.Name = "ModManForm"
        Me.Text = "Modules"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ModuleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniBlueDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniBlueDBDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.UniBlueDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModulesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModuleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ModuleIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ModCreateButton As System.Windows.Forms.Button
    Friend WithEvents ModuleCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ModuleTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SemesterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UniBlueDBDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UniBlueDBDataSet As ICT3611_Assignment1.UniBlueDBDataSet
    Friend WithEvents UniBlueDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModulesTableAdapter As ICT3611_Assignment1.UniBlueDBDataSetTableAdapters.ModulesTableAdapter
    Friend WithEvents ModulesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ModulesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ModulesBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ModulesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ModuleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModuleCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semester As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
