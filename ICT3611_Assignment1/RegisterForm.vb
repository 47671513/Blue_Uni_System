Public Class RegisterForm


    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _iStudentNum As Integer
        Dim _sError As String = ""
        Dim _sInitials As String = ""
        Dim _sSurname As String = ""


        If StudentNumTextBox.Text = "" Or StudentNumTextBox.Text = "0" Then
            MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            _iStudentNum = Convert.ToInt32(StudentNumTextBox.Text)

            Numbers_Module.CheckStudnum(_iStudentNum, _sError)

            If _sError = "OK" Then

                _sError = ""   ' Reset Error code 
                DB_Module.GetStudInfo(_iStudentNum, _sSurname, _sInitials, _sError) ' call Procedure to get student info

                If _sError = "OK" Then
                    ' display student info 
                    InitialsTextBox.Text = _sInitials
                    SurnameTextBox.Text = _sSurname

                    'Get All the Modules the Student is currently enroled in and display

                    Dim _iStudentNumber = Convert.ToInt32(StudentNumTextBox.Text)
                    Dim Enrol_Con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Computer.FileSystem.CurrentDirectory & "\UniBlueDB.accdb;Persist Security Info=False")
                    Dim Enroled_DS As New DataSet
                    Dim Enroled_Adapter As OleDb.OleDbDataAdapter

                    Try

                        Enrol_Con.Open()
                        Enroled_Adapter = New OleDb.OleDbDataAdapter("SELECT ModEnrolment.ModEnID, ModEnrolment.S_StudentNumber, Modules.ModuleCode, Modules.AYear, Modules.Semester FROM Modules INNER JOIN ModEnrolment ON Modules.[ModuleID] = ModEnrolment.[M_ModID] WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber, Enrol_Con)

                        'Enroled_Adapter = New OleDb.OleDbDataAdapter("SELECT ModEnrolment.S_StudentNumber, Modules.ModuleCode, Modules.MTitle, Modules.AYear, Modules.Semester FROM ModEnrolment INNER JOIN Modules ON ModEnrolment.M_ModID = Modules.ModuleID INNER JOIN Student ON ModEnrolment.S_StudentNumber = Student.StudentNumber WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber, Enrol_Con)
                        Enroled_Adapter.Fill(Enroled_DS)
                        Enrol_Con.Close()
                        'WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber

                    Catch

                        MessageBox.Show("Error getting Students enrolled Modules")
                        Enrol_Con.Close()

                    End Try

                    EnroledModsDataGridView.DataSource = Enroled_DS.Tables(0)
                    EnroledModsDataGridView.Refresh()



                Else

                    MessageBox.Show("Could not get Sudent Info", "Failed getting info", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Else

                MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub ModuleDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ModuleDataGridView.CellClick

        Dim _sSemesters As String
        Dim _iRow As Integer = 0

        ' enable and clear combo boxes
        YearComboBox.Enabled = True
        SemesterComboBox.Enabled = True
        SemesterComboBox.Items.Clear()
        YearComboBox.Items.Clear()

        SemesterComboBox.SelectedIndex = -1
        YearComboBox.SelectedIndex = -1
        SemesterComboBox.Text = "Please Select Semester"
        YearComboBox.Text = "Please Select Year"

        Try

            If ModuleDataGridView.CurrentRow.Index > -1 Then

                _iRow = ModuleDataGridView.CurrentRow.Index
                ModuleCodeTextBox.Text = ModuleDataGridView.Item(1, _iRow).Value

                'Add starting to year selection 
                YearComboBox.Items.Add(ModuleDataGridView.Item(4, _iRow).Value)

                _sSemesters = ModuleDataGridView.Item(5, _iRow).Value

                'Add available Semesters to Combobox 
                Select _sSemesters

                    Case "First"
                        ' Only first Semester available
                        SemesterComboBox.Items.Add("First")

                    Case "Second"
                        ' Only second Semester available
                        SemesterComboBox.Items.Add("Second")
                        'SemesterComboBox.SelectedText = "Please Select"
                    Case "Both"
                        ' first and second Semesters available
                        SemesterComboBox.Items.Add("First")
                        SemesterComboBox.Items.Add("Second")
                        'SemesterComboBox.SelectedText = "Please Select"
                    Case Else
                        SemesterComboBox.Items.Add("Not Available")
                        'SemesterComboBox.SelectedText = "Not Available"

                End Select


            End If

        Catch ex As Exception

            MessageBox.Show("Error Loading Module Data to Form", "Module Data Error")
            YearComboBox.Enabled = False
            SemesterComboBox.Enabled = False
            SemesterComboBox.Items.Clear()
            YearComboBox.Items.Clear()

        End Try


    End Sub


    Private Sub RegisterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'UniBlueDBDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.UniBlueDBDataSet.Student)
        'TODO: This line of code loads data into the 'UniBlueDBDataSet.Modules1' table. You can move, or remove it, as needed.
        Me.Modules1TableAdapter.Fill(Me.UniBlueDBDataSet.Modules1)


        If StudentNumTextBox.SelectedIndex <> -1 Then       ' if the Combobox item is selected update Enrolled Module Grid
            StudentNumTextBox_SelectedIndexChanged(sender, e)
        End If


    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        MainForm.Visible = True
        MainForm.Enabled = True
        Me.Close()

    End Sub

    Private Sub Dispose_close(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed

        MainForm.Visible = True
        MainForm.Enabled = True
        Me.Close()

    End Sub


    Private Sub EnrolModButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolModButton.Click


        If StudentNumTextBox.Text = "" Then

            MsgBox("First select a valid student number")

        ElseIf ModuleCodeTextBox.Text = "" Or YearComboBox.SelectedIndex <= -1 Or SemesterComboBox.SelectedIndex <= -1 Then

            MessageBox.Show("Module Data Not Valid or Incomplate", "Check Input")
            Exit Sub

        Else

            Dim _sError As String = ""
            Dim _sModCode As String = ModuleCodeTextBox.Text
            Dim _sStudNum As String = StudentNumTextBox.Text
            Dim _sSemester As String = SemesterComboBox.SelectedItem.ToString
            Dim _sAYear As String = YearComboBox.SelectedItem.ToString


            ModRegDuplCheck(_sStudNum, _sModCode, _sError)

            If _sError = "OK" Then

                _sError = ""    'Reset Error Variable
                ModRegDateCheck(_sModCode, _sAYear, _sSemester, _sError)

                If _sError = "OK" Then

                    _sError = ""    'Reset Error Variable
                    ModRegInsert(_sModCode, _sStudNum, _sError)

                    If _sError = "OK" Then


                    Else        ' if insert Fails
                        MessageBox.Show(_sError, "Module Add Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub

                    End If


                Else

                    MessageBox.Show(_sError, "Code Date Problem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub

                End If

            Else

                MessageBox.Show(_sError, "Code Check Problem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

        End If

    End Sub

    Private Sub StudentNumTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentNumTextBox.SelectedIndexChanged

        Dim _iStudentNum As Integer
        Dim _sError As String = ""
        Dim _sInitials As String = ""
        Dim _sSurname As String = ""


        If StudentNumTextBox.Text = "" Or StudentNumTextBox.Text = "0" Then
            MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            _iStudentNum = Convert.ToInt32(StudentNumTextBox.Text)

            Numbers_Module.CheckStudnum(_iStudentNum, _sError)

            If _sError = "OK" Then

                _sError = ""   ' Reset Error code 
                DB_Module.GetStudInfo(_iStudentNum, _sSurname, _sInitials, _sError) ' call Procedure to get student info

                If _sError = "OK" Then
                    ' display student info 
                    InitialsTextBox.Text = _sInitials
                    SurnameTextBox.Text = _sSurname

                    'Get All the Modules the Student is currently enroled in and display

                    Dim _iStudentNumber = Convert.ToInt32(StudentNumTextBox.Text)
                    Dim Enrol_Con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Computer.FileSystem.CurrentDirectory & "\UniBlueDB.accdb;Persist Security Info=False")
                    Dim Enroled_DS As New DataSet
                    Dim Enroled_Adapter As OleDb.OleDbDataAdapter

                    Try

                        Enrol_Con.Open()
                        Enroled_Adapter = New OleDb.OleDbDataAdapter("SELECT ModEnrolment.ModEnID, ModEnrolment.S_StudentNumber, Modules.ModuleCode, Modules.AYear, Modules.Semester FROM Modules INNER JOIN ModEnrolment ON Modules.[ModuleID] = ModEnrolment.[M_ModID] WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber, Enrol_Con)

                        'Enroled_Adapter = New OleDb.OleDbDataAdapter("SELECT ModEnrolment.S_StudentNumber, Modules.ModuleCode, Modules.MTitle, Modules.AYear, Modules.Semester FROM ModEnrolment INNER JOIN Modules ON ModEnrolment.M_ModID = Modules.ModuleID INNER JOIN Student ON ModEnrolment.S_StudentNumber = Student.StudentNumber WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber, Enrol_Con)
                        Enroled_Adapter.Fill(Enroled_DS)
                        Enrol_Con.Close()
                        'WHERE ModEnrolment.S_StudentNumber =" & _iStudentNumber

                    Catch

                        MessageBox.Show("Error getting Students enrolled Modules")
                        Enrol_Con.Close()

                    End Try

                    EnroledModsDataGridView.DataSource = Enroled_DS.Tables(0)
                    EnroledModsDataGridView.Refresh()



                Else

                    MessageBox.Show("Could not get Sudent Info", "Failed getting info", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Else

                MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub


End Class