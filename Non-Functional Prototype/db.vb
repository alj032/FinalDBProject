Imports System.Data.SqlClient

Public Class db
    ' login to database server
    Protected connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=ISYS4283F1720;Trusted_Connection=yes;"}
    ' prepare a query
    Protected command As New SqlCommand With {.Connection = connection}

    ' set and get sql command
    Public Property sql() As String
        Get
            Return command.CommandText
        End Get

        Set(value As String)
            command.CommandText = value
        End Set
    End Property

    ' bind sql parameters
    Public Sub bind(ByVal parameter As String, ByRef value As Object)
        command.Parameters.AddWithValue(parameter, value)
    End Sub

    ' populate a data grid view
    Public Sub fill(ByRef dgv As DataGridView)
        Dim adapter As SqlDataAdapter
        Dim dataset As DataSet

        Try
            connection.Open()
            adapter = New SqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset)
            If dataset.Tables.Count > 0 Then
                dgv.Refresh()
                dgv.DataSource = dataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        command.CommandText = Nothing
        command.Parameters.Clear()
    End Sub

    ' execute a DML statement
    Public Sub execute()
        Try
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        command.CommandText = Nothing
        command.Parameters.Clear()
    End Sub
End Class

