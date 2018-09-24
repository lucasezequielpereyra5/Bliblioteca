Public Class conexionSql

    Public cn As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    'cambiar con_string por los datos de la instancia de la base de datos y el nombre de la base
    Dim con_string = "Data Source=.\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True"

    Public Sub guardar(ByVal data_string As String)
        Console.WriteLine(data_string)
        Try
            cn.ConnectionString = con_string  'carga el connection string
            cn.Open() 'abro conexion 
            cmd = cn.CreateCommand 'creo command 
            cmd.Connection = cn ' paso conection 
            'para ejecutar consulta
            cmd.CommandType = CommandType.Text '
            cmd.CommandText = data_string 'paso query  
            cmd.ExecuteNonQuery() 'ejecuto

        Catch ex As Exception
            Console.WriteLine("PROBLEMA EN LA CAPA DATOS: " & ex.ToString)
        Finally
            cn.Close() 'cierro conexion
            cmd.Dispose() 'mato command 
            cn.Dispose() 'mato conection 

        End Try

    End Sub

    Public Function consultar(ByVal data_string As String) As DataTable
        Try
            cn.ConnectionString = con_string  'carga el connection string
            cn.Open() 'abro conexion 
            cmd = cn.CreateCommand 'creo command
            cmd.Connection = cn 'paso conection
            Using DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
                Using DS As DataSet = New DataSet
                    cmd.CommandText = data_string 'paso query
                    cmd.ExecuteNonQuery() 'ejecuto 
                    DA.Fill(DS) 'llena el DataAdapter con el Dataset
                    Return DS.Tables(0) 'devuelve dataset entero
                End Using
            End Using

        Catch ex As Exception
            Throw ex

        Finally
            cn.Close() 'cierro conexion
            cmd.Dispose() 'mato command 
            cn.Dispose() 'mato conection 
        End Try

    End Function


End Class
