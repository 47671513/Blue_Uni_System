﻿Imports System.Data.OleDb

Module DB_Module

    'Module for all Db related Functions

    'Create a connection to the DB
    Public Sub CreateDBCon(ByRef o_oDBcon As OleDbConnection, ByRef o_sDBError As String)

        'Try connection to DB 
        Try
            o_oDBcon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Computer.FileSystem.CurrentDirectory & "\UniBlueDB.accdb;Persist Security Info=False")
            o_oDBcon.Open()
            o_oDBcon.Close()
            o_sDBError = "OK"

        Catch ex As Exception

            ' catch Exception and return error code
            o_oDBcon = Nothing
            o_sDBError = "Connection To Data Base Failed "

        End Try

    End Sub

    'Select Highest Student Number ffrom DB and return
    Public Sub GetHighestStudnum(ByRef o_iHighStudentNum As Integer, ByRef o_sError As String)

        Dim _oNewCon As OleDbConnection = Nothing

        CreateDBCon(_oNewCon, o_sError)
        If o_sError = "OK" Then
            _oNewCon.Open()
            Try
                ' TOP(1) StudentNumber FROM Student ORDER BY StudentNumber DESC
                Dim _sSelectCmd = New OleDbCommand("SELECT MAX(StudentNumber) AS High_StudentNumber FROM Student", _oNewCon)
                Dim _SeqDataRder As OleDb.OleDbDataReader = _sSelectCmd.ExecuteReader()
                _SeqDataRder.Read()
                o_iHighStudentNum = Int(_SeqDataRder.Item("High_StudentNumber"))
                o_sError = "OK"
                _oNewCon.Close()

            Catch ex As Exception

                o_iHighStudentNum = 0
                o_sError = ex.ToString()
                _oNewCon.Close()

            End Try

        Else

            o_iHighStudentNum = 0
            o_sError = "Failed to Add Record - an Error occured"

        End If

    End Sub

    ' Function to add new record for student enrolemt to db
    Public Sub EnrolInsert(ByVal i_iStudentID As Integer, ByVal i_sTitle As String, ByVal i_sInitials As String, ByVal i_sSurname As String, ByVal i_sAddress As String, ByVal i_sBirthDate As String, ByRef o_sError As String)

        Dim _sError As String = ""

        'Create connection to DB
        Dim newCon As OleDb.OleDbConnection = Nothing
        DB_Module.CreateDBCon(newCon, _sError)

        If _sError = "OK" Then

            Try
                newCon.Open() ' open connection 
                'create Insert command and execute 

                Dim _sInsert As String = "INSERT INTO Student (StudentNumber, Title, Initials, Surname, Address, BirthDate) VALUES ('" & i_iStudentID & "','" & i_sTitle & "','" & i_sInitials & "','" & i_sSurname & "','" & i_sAddress & "','" & i_sBirthDate & "')"
                Dim _cInsertCmd As OleDbCommand = New OleDbCommand(_sInsert, newCon)
                Dim _iResult As Integer = _cInsertCmd.ExecuteNonQuery
                newCon.Close()      'Close Connection to DB 

                'Check Rows affected count - if > 0 then insert was sucess 
                If _iResult > 0 Then
                    o_sError = "OK"
                Else
                    _sError = "No Record Added"
                End If

            Catch ex As Exception

                o_sError = ex.ToString()
                newCon.Close()      'Close Connection to DB 

            End Try

        Else

            o_sError = _sError

        End If


    End Sub

    'Function to Update Student record with given StudentNumber from DB 
    Public Sub UpdateStudent(ByVal i_iStudentID As Integer, ByVal i_sTitle As String, ByVal i_sInitials As String, ByVal i_sSurname As String, ByVal i_sAddress As String, ByVal i_sBirthDate As String, ByRef o_sError As String)

        Dim _sError As String = ""

        Dim newCon As OleDb.OleDbConnection = Nothing     'Create connection to DB
        DB_Module.CreateDBCon(newCon, _sError)

        If _sError = "OK" Then

            Try
                newCon.Open() ' open connection to DB

                'create Update command and execute 
                Dim _sUpdate As String = "UPDATE Student SET Title = '" & i_sTitle & "' , Initials = '" & i_sInitials & "', Surname = '" & i_sSurname & "', Address = '" & i_sAddress & "', BirthDate = '" & i_sBirthDate & "' WHERE StudentNumber = " & i_iStudentID & " "
                Dim _cUpdateCmd As OleDbCommand = New OleDbCommand(_sUpdate, newCon)
                Dim _iResult As Integer = _cUpdateCmd.ExecuteNonQuery
                newCon.Close()          'Close Connection to DB

                'Check Rows affected count - if > 0 then Update was sucess 
                If _iResult > 0 Then
                    o_sError = "OK"
                Else
                    _sError = "Record Was not Updated"
                End If

            Catch ex As Exception  ' return exception string in Error variable

                o_sError = ex.ToString()
                newCon.Close()          'Close Connection to DB if error Occured

            End Try

        Else

            o_sError = _sError

        End If


    End Sub

    'Function to Delete Student record with given StudentNumber from DB  
    Public Sub DeleteRecord(ByVal i_iStudentID As Integer, ByRef o_sError As String)

        'Function to Delete Record with Selected StudentNumber

        Dim _sError As String = ""

        'Create connection to DB
        Dim newCon As OleDb.OleDbConnection = Nothing
        DB_Module.CreateDBCon(newCon, _sError)

        If _sError = "OK" Then

            Try
                newCon.Open() ' open connection 
                'create Insert command and execute 

                Dim _sDelete As String = "DELETE FROM Student WHERE StudentNumber = " & i_iStudentID & " "
                Dim _cDELCmd As OleDbCommand = New OleDbCommand(_sDelete, newCon)
                Dim _iResult As Integer = _cDELCmd.ExecuteNonQuery
                newCon.Close()      'Close Connection to DB 

                'Check Rows affected count - if greater than 0 then Delete was sucess 
                If _iResult > 0 Then
                    o_sError = "OK"
                Else
                    _sError = "Record Could not be Removed"
                End If

            Catch ex As Exception

                o_sError = ex.ToString()
                newCon.Close()                      'Close Connection to DB if Exceptio occured

            End Try


        Else

            o_sError = _sError

        End If


    End Sub

    'Function to check if Module code already exists in DB
    Public Sub CheckModCode(ByRef i_sModCode As String, ByRef o_sError As String)

        Dim _oNewCon As OleDbConnection = Nothing
        Dim _sCheck As String = ""

        CreateDBCon(_oNewCon, o_sError)

        If o_sError = "OK" Then
            _oNewCon.Open()

            Try

                Dim _sSelectCmd = New OleDbCommand("SELECT ModuleCode FROM Modules WHERE ModuleCode = '" & i_sModCode & "'", _oNewCon)
                Dim _SeqDataRder As OleDb.OleDbDataReader = _sSelectCmd.ExecuteReader()

                If _SeqDataRder.HasRows Then        'If data reader has rows then Code already exists
                    o_sError = "Code Exists"
                Else
                    o_sError = "OK"
                End If

                _oNewCon.Close()          'Close Connection to DB

            Catch ex As Exception
                o_sError = ex.ToString()
                _oNewCon.Close()

            End Try

        Else

            o_sError = "Failed to Add Record - an Error occured"

        End If

    End Sub

    ' Function to add new record for student enrolemt to db
    Public Sub ModuleInsert(ByVal i_iModuleCode As String, ByVal i_sTitle As String, ByVal i_bActive As Boolean, ByVal i_iYear As Integer, ByVal i_sSemester As String, ByRef o_sError As String)

        Dim _sError As String = ""

        'Create connection to DB
        Dim newCon As OleDb.OleDbConnection = Nothing
        DB_Module.CreateDBCon(newCon, _sError)

        If _sError = "OK" Then

            Try
                newCon.Open() ' open connection 
                'create Insert command and execute 

                Dim _sInsert As String = "INSERT INTO Modules (Modulecode, MTitle, Active, AYear, Semester) VALUES ('" & i_iModuleCode & "','" & i_sTitle & "'," & i_bActive & "," & i_iYear & ",'" & i_sSemester & "' )"
                Dim _cInsertCmd As OleDbCommand = New OleDbCommand(_sInsert, newCon)
                Dim _iResult As Integer = _cInsertCmd.ExecuteNonQuery
                newCon.Close()

                'Check Rows affected count - if > 0 then insert was sucess 
                If _iResult > 0 Then
                    o_sError = "OK"
                Else
                    _sError = "Module not Added"
                End If

            Catch ex As Exception

                o_sError = ex.ToString()

            End Try

        Else

            o_sError = _sError

        End If

    End Sub

    ' function to Update Activation Status
    Public Sub ModActivateUpdate(ByVal i_iModuleID As Integer, ByVal i_bActive As Boolean, ByVal i_iYear As Integer, ByVal i_Semester As String, ByRef o_sError As String)

        Dim _sError As String = ""

        Dim newCon As OleDb.OleDbConnection = Nothing     'Create connection to DB
        DB_Module.CreateDBCon(newCon, _sError)

        If _sError = "OK" Then

            Try
                newCon.Open() ' open connection to DB

                'create Update command and execute 
                Dim _sUpdate As String = "UPDATE Modules SET Active = " & i_bActive & " , AYear = " & i_iYear & ", Semester = '" & i_Semester & "' WHERE ModuleID = " & i_iModuleID & " "
                Dim _cUpdateCmd As OleDbCommand = New OleDbCommand(_sUpdate, newCon)
                Dim _iResult As Integer = _cUpdateCmd.ExecuteNonQuery
                newCon.Close()          'Close Connection to DB

                'Check Rows affected count - if > 0 then Update was sucess 
                If _iResult > 0 Then
                    o_sError = "OK"
                Else
                    _sError = "Record Was not Updated"
                End If

            Catch ex As Exception  ' return exception string in Error variable

                o_sError = ex.ToString()
                newCon.Close()          'Close Connection to DB if error Occured

            End Try

        Else

            o_sError = _sError

        End If
    End Sub

    'Select Student Info from DB for given Student Number and return
    Public Sub GetStudInfo(ByVal i_iStudentNum As Integer, ByRef o_sStudSurname As String, ByRef o_sInitials As String, ByRef o_sError As String)

        Dim _oNewCon As OleDbConnection = Nothing

        CreateDBCon(_oNewCon, o_sError)
        If o_sError = "OK" Then
            _oNewCon.Open()
            Try
                Dim _sSelectCmd = New OleDbCommand("SELECT * FROM Student WHERE StudentNumber = " & i_iStudentNum, _oNewCon)
                Dim _SeqDataRder As OleDb.OleDbDataReader = _sSelectCmd.ExecuteReader()
                _SeqDataRder.Read()
                o_sStudSurname = Int(_SeqDataRder.Item("Surname"))
                o_sInitials = Int(_SeqDataRder.Item("Initials"))
                o_sError = "OK"
                _oNewCon.Close()

            Catch ex As Exception

                o_sStudSurname = ""
                o_sInitials = ""
                o_sError = "Failed to get Student information"
                _oNewCon.Close()

            End Try

        Else

            o_sStudSurname = ""
            o_sInitials = ""
            o_sError = "Failed to get Student information"

        End If

    End Sub

End Module