Public Class ModManForm

    Private Sub Modules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim _iYear As Integer = Convert.ToInt16(Year(Now).ToString())       'Get Current Year

        Me.ModulesTableAdapter.Fill(Me.UniBlueDBDataSet.Modules)

        While _iYear < Convert.ToInt16(Year(Now).ToString()) + 9        'counter to create 10 year Dropdown 

            YearComboBox.Items.Add(_iYear)                          'Create Dropdown next 10 year selection starting this year
            _iYear += 1

        End While

        SemesterComboBox.Items.Add("First")
        SemesterComboBox.Items.Add("Second")
        SemesterComboBox.Items.Add("Both")                        'Create semester Selection 


    End Sub

    Private Sub ModCreateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModCreateButton.Click

        Dim _sModCode As String
        Dim _sModTitle As String

        'Dim bool1 As Boolean = System.IO.File.Exists("z:\try.exe")
        'MessageBox.Show("The result is :" & bool1)


        Dim _bActive As Boolean
        Dim _iYear As Integer
        Dim _sSemester As String

        Dim _sError As String = ""


        If ModuleCodeTextBox.Text = "" Or ModuleTitleTextBox.Text = "" Then  ' check if Textboxes are empty

            MessageBox.Show("Module Code and Title Must be provided", "Manadatory fields empty", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            _sModCode = ModuleCodeTextBox.Text
            _sModTitle = ModuleTitleTextBox.Text

            If ActiveCheckBox.Checked Then          '  Check if module has been set to active 

                If YearComboBox.SelectedIndex < 0 Or SemesterComboBox.SelectedIndex < 0 Then        ' Check if the combos were selected 

                    MessageBox.Show("Year and Semester must be selected for Active Modules", "Manadatory fields empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub     'exit sub if conbo boxes werent completed

                End If

                _bActive = ActiveCheckBox.Checked
                _sSemester = SemesterComboBox.SelectedItem.ToString
                _iYear = Convert.ToInt16(YearComboBox.SelectedItem.ToString)


            Else    ' If Module is not active - load default values to module

                _bActive = False
                _iYear = 0
                _sSemester = "None"

            End If

            DB_Module.CheckModCode(_sModCode, _sError)      ' Call Procedure to check Code availability 

            If _sError = "OK" Then

                _sError = ""  'reset  the Error Code Variable 
                DB_Module.ModuleInsert(_sModCode, _sModTitle, _bActive, _iYear, _sSemester, _sError) 'Call Module Insert with given variables

                If _sError = "OK" Then

                    MessageBox.Show("Module Sucessfully Added")
                    Reset_Refresh()     'Reset controls and update Grid


                Else

                    ' Insert Action failed - return the Error code
                    MessageBox.Show(_sError, "Module Failed to add to the DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            Else

                ' Duplicate Module Code Found Error message and focus on Module code textbox
                MessageBox.Show(_sError, "Module Code Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ModuleCodeTextBox.Focus()

            End If

        End If


    End Sub

    Private Sub ModuleIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModuleIDTextBox.TextChanged

        If Not ModuleIDTextBox.Text = "0" And Not ModuleIDTextBox.Text = "" Then   '  If a Module has been selected 

            UpdateButton.Enabled = True     ' Enable the Update button

        End If


    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click

        Dim _sModuleID As String
        Dim _bActive As Boolean
        Dim _iYear As Integer
        Dim _sSemester As String

        Dim _sError As String = ""

        If ModuleIDTextBox.Text = "" Or ModuleIDTextBox.Text = "0" Then  ' check Module Has been selected

            MessageBox.Show("Module Selection Invalid", "Module Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            _sModuleID = ModuleIDTextBox.Text

            If ActiveCheckBox.Checked Then          '  Check if module has been set to active 

                If YearComboBox.SelectedIndex < 0 Or SemesterComboBox.SelectedIndex < 0 Then        ' Check if the combos were selected 

                    MessageBox.Show("Year and Semester must be selected To Active Modules", "Manadatory fields empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub     'exit sub if conbo boxes werent completed

                End If

                _bActive = ActiveCheckBox.Checked
                _sSemester = SemesterComboBox.SelectedItem.ToString
                _iYear = Convert.ToInt16(YearComboBox.SelectedItem.ToString)


            Else    ' If Module is not active - load default values to module

                _bActive = False
                _iYear = 0
                _sSemester = "None"

            End If


            _sError = ""  'reset  the Error Code Variable 
            DB_Module.ModActivateUpdate(_sModuleID, _bActive, _iYear, _sSemester, _sError) 'Call Module Activate Update with given variables

            If _sError = "OK" Then

                MessageBox.Show("Module Activation Updated Successfully")
                Reset_Refresh()     'Reset controls and update Grid


            Else

                ' Insert Action failed - return the Error code
                MessageBox.Show(_sError, "Module Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub

    Private Sub Dispose_close(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed

        MainForm.Visible = True
        MainForm.Enabled = True
        Me.Close()

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        MainForm.Visible = True
        MainForm.Enabled = True
        Me.Close()

    End Sub

    Private Sub Reset_Refresh()


        ModuleIDTextBox.Text = ""
        ModuleTitleTextBox.Text = ""
        ModuleCodeTextBox.Text = ""
        ActiveCheckBox.Checked = False
        YearComboBox.SelectedIndex = -1
        SemesterComboBox.SelectedIndex = -1
        YearComboBox.SelectedValue = ""
        SemesterComboBox.SelectedValue = ""

        'Refresh the data grid to show changes
        Me.ModulesTableAdapter.Fill(Me.UniBlueDBDataSet.Modules)
        ModuleDataGridView.Refresh()
        Me.Refresh()

    End Sub

    Private Sub ActiveCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveCheckBox.CheckedChanged

        YearComboBox.Enabled = ActiveCheckBox.Checked
        SemesterComboBox.Enabled = ActiveCheckBox.Checked

    End Sub


    Private Sub ModuleDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ModuleDataGridView.CellClick

        Dim _iRow As Integer = 0
        Try


            If ModuleDataGridView.CurrentRow.Index > -1 Then

                _iRow = ModuleDataGridView.CurrentRow.Index
                ModuleIDTextBox.Text = ModuleDataGridView.Item(0, _iRow).Value
                ModuleCodeTextBox.Text = ModuleDataGridView.Item(1, _iRow).Value
                ModuleTitleTextBox.Text = ModuleDataGridView.Item(2, _iRow).Value
                ActiveCheckBox.Checked = Convert.ToBoolean(ModuleDataGridView.Item(3, _iRow).Value)
                YearComboBox.SelectedItem = ModuleDataGridView.Item(4, _iRow).Value
                SemesterComboBox.SelectedItem = ModuleDataGridView.Item(5, _iRow).Value

            End If

        Catch ex As Exception

            MessageBox.Show("Error Loading Module Data to Form", "Module Data Error")

        End Try

    End Sub

End Class