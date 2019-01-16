Public Class Timer
    Public Property seg As Integer
    Public Property min As Integer

    Function tiempo(ByVal xT As Timer) As Integer
        If xT.seg > 0 Then
            xT.seg = xT.seg - 1
        ElseIf xT.seg = 0 Then
            xT.min = xT.min - 1
            Return True
            If xT.min = -1 Then
                xT.min = 0
                Return False
            Else
                xT.seg = 59
                Return True
            End If
        End If
    End Function


End Class
