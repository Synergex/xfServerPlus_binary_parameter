Private Function FileToBinary(ByVal FileName As String, ByRef FileData() As Byte, Optional ByRef ErrorText As String = "") As Boolean

    Dim OK As Boolean = True
    Dim fs As FileStream
    Dim br As BinaryReader

    ErrorText = ""

    'Create SileStream
    Try
        fs = New FileStream(FileName, System.IO.FileMode.Open)
    Catch ex As Exception
        ErrorText = "Failed to open file " & FileName & vbCrLf & ex.Message
        fs = Nothing
        OK = False
    End Try

    'Create BinaryReader
    If OK Then
        Try
            br = New BinaryReader(fs)
        Catch ex As Exception
            ErrorText = "Failed to create BinaryReader." & vbCrLf & ex.Message
            br = Nothing
            OK = False
        End Try
    End If

    'Read data from file
    If OK Then
        ReDim FileData(fs.Length - 1)
        FileData = br.ReadBytes(fs.Length)
    End If

    If Not IsNothing(br) Then br.Close()
    If Not IsNothing(fs) Then fs.Close()

    Return OK

End Function
