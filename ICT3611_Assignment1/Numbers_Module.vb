Module Numbers_Module

    'Module : Number Creation and Check Functios

    'Function creates new Student Number and returns as Int
    Public Sub CreateStudentNumber(ByVal i_sNextStudentNum As String, ByRef o_iStudentNumber As Integer, ByRef o_sError As String)

        Dim _sYearPart As String
        Dim o_sStudentNumber As String
        Dim _iCheckVal As Integer
        Try

            'Connect to DB to get Highest Student Number

            'add year part to the Number
            _sYearPart = Year(Now).ToString.Substring(2, 2)
            o_sStudentNumber = _sYearPart & i_sNextStudentNum

            'add 1 to the hisghest student number in the DB
            o_iStudentNumber = Convert.ToInt32(o_sStudentNumber)
            o_iStudentNumber += 1

            'add all the numbers and add Check value
            For Each Element As Char In Convert.ToString(o_iStudentNumber)
                _iCheckVal += Convert.ToInt32(Element.ToString())
            Next Element

            Dim _iRem As Integer = _iCheckVal Mod 10
            _iCheckVal = 10 - _iRem

            If _iCheckVal = 10 Then    'in case check value is 10 we have to make it 0 to keep Student numbers the same length
                _iCheckVal = 0
            End If

            o_iStudentNumber = Convert.ToInt32(Convert.ToString(o_iStudentNumber) & Convert.ToString(_iCheckVal))
            o_sError = "OK"

            'return error if process failed 
        Catch ex As Exception
            o_iStudentNumber = 0
            o_sError = ex.ToString()
        End Try


    End Sub

    'Function that checks if Student Number is valid
    Public Sub CheckStudnum(ByVal i_iStudentnum As Integer, ByRef io_sError As String)

        Try
            Dim _sStringNumber = Convert.ToString(i_iStudentnum)    ' convert supplied Student number to string
            Dim _iCheckVal As Integer = 0

            For Each _cNum As Char In _sStringNumber    'itterate through string to add individual numbers 

                _iCheckVal += Convert.ToInt16(_cNum.ToString())

            Next

            If _iCheckVal Mod 10 = 0 Then       '  Do calculation to test number - return OK if result is 0
                io_sError = "OK"
            Else
                io_sError = "Student Number Check Failed"
            End If

        Catch
            io_sError = "Student Number Check Error Occured"
        End Try

    End Sub

    'Function For Checking Module Code Validity


End Module
