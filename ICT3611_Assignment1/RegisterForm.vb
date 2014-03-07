Public Class RegisterForm


    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click

        Dim _iStudentNum As Integer
        Dim _sError As String = ""
        Dim _sInitials As String = ""
        Dim _sSurname As String = ""


        If StudentNumTextBox.Text = "" Or StudentNumTextBox.Text = "0" Then
            MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            _iStudentNum = Convert.ToInt16(StudentNumTextBox.Text)

            Numbers_Module.CheckStudnum(_iStudentNum, _sError)

            If _sError = "OK" Then

                _sError = ""   ' Reset Error code 
                DB_Module.GetStudInfo(_iStudentNum, _sSurname, _sInitials, _sError)

                If _sError = "OK" Then

                    InitialsTextBox.Text = _sInitials
                    SurnameTextBox.Text = _sSurname

                End If

            Else

                MessageBox.Show("Invalid Student Number", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub ModuleDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ModuleDataGridView.CellClick
        Dim _iRow As Integer = 0
        Try


            If ModuleDataGridView.CurrentRow.Index > -1 Then

                _iRow = ModuleDataGridView.CurrentRow.Index

                ModuleCodeTextBox.Text = ModuleDataGridView.Item(1, _iRow).Value
                YearComboBox.SelectedItem = ModuleDataGridView.Item(4, _iRow).Value
                SemesterComboBox.SelectedItem = ModuleDataGridView.Item(5, _iRow).Value

            End If

        Catch ex As Exception

            MessageBox.Show("Error Loading Module Data to Form", "Module Data Error")

        End Try
    End Sub
End Class