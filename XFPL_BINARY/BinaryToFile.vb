Private Function BinaryToFile(ByRef FileData() As Byte, ByVal FileName As String, Optional ByRef ErrorText As String = "") As Boolean

    Dim OK As Boolean = True
    Dim fs As FileStream
    Dim bw As BinaryWriter

    ErrorText = ""

    'Create SileStream
    Try
        fs = New FileStream(FileName, System.IO.FileMode.CreateNew)
    Catch ex As Exception
        ErrorText = "Failed to create FileStream." & vbCrLf & ex.Message
        fs = Nothing
        OK = False
    End Try

    'Create BinaryWriter
    If OK Then
        Try
            bw = New BinaryWriter(fs)
        Catch ex As Exception
            ErrorText = "Failed to create BinaryWriter." & vbCrLf & ex.Message
            bw = Nothing
            OK = False
        End Try
    End If

    'Write data to file
    If OK Then
        Dim i As Integer
        For i = 0 To UBound(FileData)
            bw.Write(FileData(i))
        Next i
    End If

    if Not IsNothing(bw) Then bw.Close()
    If Not IsNothing(fs) Then fs.Close()

    Return OK

End Function

