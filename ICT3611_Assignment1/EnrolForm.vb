Public Class EnrolForm


    Private Sub EnrolForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Fill Table adapter with Dataset - StudentDatagrid  get populated with this
        Me.StudentTableAdapter.Fill(Me.UniBlueDBDataSet.Student)

        'Dissable 

        InitialsTextBox.Enabled = False
        TitleTextBox.Enabled = False
        SurnameTextBox.Enabled = False
        AddressTextBox.Enabled = False
        BirthDateTimePicker.Enabled = False


    End Sub

    Private Sub StudentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick

        Dim _iRow As Integer = 0


        InitialsTextBox.Enabled = True
        TitleTextBox.Enabled = True
        SurnameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        BirthDateTimePicker.Enabled = True

        EnrolNewButton.BackColor = Color.Gray
        EnrolNewButton.Text = "Start New Enrolment"

        If StudentDataGridView.CurrentRow.Index > -1 Then

            _iRow = StudentDataGridView.CurrentRow.Index
            StudentNumTextBox.Text = StudentDataGridView.Item(0, _iRow).Value
            InitialsTextBox.Text = StudentDataGridView.Item(1, _iRow).Value
            TitleTextBox.Text = StudentDataGridView.Item(2, _iRow).Value
            SurnameTextBox.Text = StudentDataGridView.Item(3, _iRow).Value
            AddressTextBox.Text = StudentDataGridView.Item(4, _iRow).Value
            BirthDateTimePicker.Value = Convert.ToDateTime(StudentDataGridView.Item(5, _iRow).Value)

        End If

    End Sub

    Private Sub EnrolNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolNewButton.Click


        'enabled reauired controls for new enrolment

        InitialsTextBox.Enabled = True
        TitleTextBox.Enabled = True
        SurnameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        BirthDateTimePicker.Enabled = True

        If Not StudentNumTextBox.Text = "" Then ' if there is other records being displayed first clear

            'Reset and Refresh the controls  
            Reset_Refresh()
            BirthDateTimePicker.Value = DateTime.Now
            EnrolNewButton.BackColor = Color.GreenYellow
            EnrolNewButton.Text = "Submit New Entry"
            TitleTextBox.Focus()

        Else

            ' initialize all Variables

            Dim _sTitle As String = ""
            Dim _sInitials As String = ""
            Dim _sSurname As String = ""
            Dim _sAddress As String = ""
            Dim _sBirthDate As String = ""
            Dim _sError As String = ""
            Dim _iStudentCount As Integer
            Dim _sHStudentNum As String
            Dim _iStudentNum As Integer

            ' Check textboxes are all completed
            If InitialsTextBox.Text = "" Or TitleTextBox.Text = "" Or SurnameTextBox.Text = "" Or AddressTextBox.Text = "" Then
                MessageBox.Show("All Fields Are Mandatory", "Empty Fields!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else        'call function to get the highest student number in DB

                DB_Module.GetHighestStudnum(_iStudentCount, _sError)

                If _sError = "OK" Then

                    _sHStudentNum = Str(_iStudentCount).Substring(3, 4)   'strip out current student num
                    Numbers_Module.CreateStudentNumber(_sHStudentNum, _iStudentNum, _sError)   'create new incremented Student number

                    If _sError = "OK" Then
                        ' set all the variables 
                        _sInitials = InitialsTextBox.Text
                        _sTitle = TitleTextBox.Text
                        _sSurname = SurnameTextBox.Text
                        _sAddress = AddressTextBox.Text
                        _sBirthDate = BirthDateTimePicker.Value.ToShortDateString

                        ' call inset function with all variables supplied
                        DB_Module.EnrolInsert(_iStudentNum, _sTitle, _sInitials, _sSurname, _sAddress, _sBirthDate, _sError)

                        If _sError = "OK" Then

                            MessageBox.Show("Student Enrolled Sucessfully", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'Reset and Refresh the controls  
                            Reset_Refresh()

                        Else
                            ' if the opperation failed clear textboxes and allert user          

                            'Reset and Refresh the controls  

                            MessageBox.Show(_sError, "Error Adding New Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Reset_Refresh()

                        End If

                    Else

                        MessageBox.Show(_sError, "Error Creating Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' if the opperation failed clear textboxes and allert user
                        'Reset and Refresh the controls  
                        Reset_Refresh()

                    End If
                Else

                    MessageBox.Show(_sError, "Error Creating Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' if the opperation failed clear textboxes and allert user
                    'Reset and Refresh the controls  
                    Reset_Refresh()

                End If

            End If
        End If



    End Sub

    Private Sub DelStudButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelStudButton.Click

        Dim _sError As String = ""
        Dim _iStudentNum As Integer
        _iStudentNum = StudentNumTextBox.Text

        ' Check if a record was selected before atempting Del

        If StudentNumTextBox.Text = "" Or StudentNumTextBox.Text = "0" Then
            MessageBox.Show("No record Selected : Please select a record from the Table", "Error Deleting record", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim _Result = MsgBox("Confirm Deletetion of " & _iStudentNum & " ?", vbYesNo) ' Get result from Message Box

            If _Result = DialogResult.Yes Then  ' If user confirmed continue

                Numbers_Module.CheckStudnum(StudentNumTextBox.Text, _sError)     ' Call Check Studentnumber function

                If _sError = "OK" Then

                    ' call Delete function _iStudentNum
                    DB_Module.DeleteRecord(_iStudentNum, _sError)

                    If _sError = "OK" Then

                        MessageBox.Show("Sucess Deleting Record", "Record Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Reset and Refresh the controls  
                        Reset_Refresh()

                    Else

                        MessageBox.Show(_sError, "Record Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Reset and Refresh the controls  
                        Reset_Refresh()

                    End If


                Else
                    ' Display appropriate Error message
                    MessageBox.Show(_sError, "Error Deleting record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Reset and Refresh the controls  
                    Reset_Refresh()
                End If

            End If
        End If

    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click

        ' Declare & Initiate required Variables
        Dim _sTitle As String = ""
        Dim _sInitials As String = ""
        Dim _sSurname As String = ""
        Dim _sAddress As String = ""
        Dim _sBirthDate As String = ""
        Dim _sError As String = ""
        Dim _iStudentNum As Integer

        If StudentNumTextBox.Text = "" Or StudentNumTextBox.Text = "0" Then  ' Check if a record was selected before atempting Update
            MessageBox.Show("No record Selected : Please select a record from the Table", "Error Updating record", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Numbers_Module.CheckStudnum(StudentNumTextBox.Text, _sError)     ' Call Check Studentnumber function

            If _sError = "OK" Then

                ' set all the variables 
                _iStudentNum = StudentNumTextBox.Text
                _sInitials = InitialsTextBox.Text
                _sTitle = TitleTextBox.Text
                _sSurname = SurnameTextBox.Text
                _sAddress = AddressTextBox.Text
                _sBirthDate = BirthDateTimePicker.Value.ToShortDateString

                ' call Update function with all variables supplied
                DB_Module.UpdateStudent(_iStudentNum, _sTitle, _sInitials, _sSurname, _sAddress, _sBirthDate, _sError)

                If _sError = "OK" Then

                    MessageBox.Show("Student Updated", "Student Information Updated Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Reset and Refresh the controls  
                    Reset_Refresh()
                Else

                    MessageBox.Show(_sError, "Student Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Reset and Refresh the controls  
                    Reset_Refresh()

                End If

            Else        ' Display appropriate Error message
                MessageBox.Show(_sError, "Error Updating record", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Reset and Refresh the controls and Datagrid
                Reset_Refresh()
            End If

        End If

    End Sub

    Private Sub Reset_Refresh()

        'Reset Enrol Button
        EnrolNewButton.BackColor = Color.Gray
        EnrolNewButton.Text = "Start New Enrolment"

        StudentNumTextBox.Text = ""
        InitialsTextBox.Text = ""
        TitleTextBox.Text = ""
        SurnameTextBox.Text = ""
        AddressTextBox.Text = ""
        BirthDateTimePicker.Value = DateTime.Now

        'Refresh the data grid to show changes
        Me.StudentTableAdapter.Fill(Me.UniBlueDBDataSet.Student)
        StudentDataGridView.Refresh()
        Me.Refresh()

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

End Class