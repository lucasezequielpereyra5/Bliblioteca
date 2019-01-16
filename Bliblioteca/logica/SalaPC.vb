Imports Datos

Public Class SalaPC
    Public Property id As Integer
    Public Property dni_cliente As Integer


    Dim conexion As New conexionSql

    Public Function ocuparPC(ByVal t As SalaPC) As Boolean
        Try
            ' guardar dni del cliente
            conexion.guardar("Update pc set dni = " & t.dni_cliente & " where id= " & t.id)

        Catch ex As Exception
        End Try
    End Function

    Public Sub desocuparPC(ByVal t As SalaPC)
        Try
            conexion.guardar("Update pc set dni = 0 where id=" & t.id)
            ' conexion.guardar("Update pc set entrada = null where id=" & t.id)

        Catch ex As Exception
        End Try
    End Sub

    Public Function chequear(ByVal dni As Integer)
        Dim t As New SalaPC
        t.dni_cliente = dni
        ' chequea si el cliente ya se encuentra en alguna PC.
        Dim dt = conexion.consultar("Select id from pc where dni = " & dni)
        If dt.Rows.Count() = 0 Then
            Return 0
        Else
            Return dt.Rows.Item(0)(0)
        End If
    End Function

End Class
