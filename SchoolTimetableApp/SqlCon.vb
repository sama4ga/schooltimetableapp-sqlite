Imports System.Data.SqlClient
Imports System.Data
Public Class SqlCon

    Private con As SqlConnection
    Private cmd As SqlCommand
    Private da As SqlDataAdapter
    Private dt As DataTable
    Public ds As DataSet
    Public rd As SqlDataReader
    Public result As Boolean


    Private Sub OpenCon()
        con = New SqlConnection(My.Settings.timetable_data_ConnectionString)
        con.Open()
    End Sub

    Public Sub ExecuteQuery(query As String)
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            result = True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
        Finally
            con.Close()
            cmd.Dispose()
            con.Dispose()
        End Try

    End Sub


    Public Function InsertQuery(query As String, ParamValues As List(Of String)) As Integer
        Try
            OpenCon()

            Dim transaction As SqlTransaction = con.BeginTransaction()
            cmd = New SqlCommand(query, con)
            cmd.Transaction = transaction
            cmd.Prepare()
            'If command.IsPrepared Then
            cmd.Parameters.Clear()
            Dim count = 1
            For Each index As String In ParamValues
                Dim paramName As String = "@" & count
                cmd.Parameters.AddWithValue(paramName, index.ToString())
                count += 1
            Next

            Dim lastInsertId As Integer = 0
            Dim id As Object = cmd.ExecuteScalar()

            result = True
            cmd.Transaction.Commit()
            'transaction.Commit()
            If id IsNot Nothing Then
                If Integer.TryParse(id.ToString(), lastInsertId) Then
                    Return lastInsertId
                End If
            End If
            Return lastInsertId

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
            Return 0
        Finally
            con.Close()
            con.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Sub LoadComboBox(query As String, cmb As ComboBox, name As String)
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New SqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = dt.Columns(1).ColumnName
            cmb.ValueMember = dt.Columns(0).ColumnName

            result = True

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Sub LoadListBox(query As String, lb As ListBox, name As String)
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)

            dt = New DataTable(name)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()

            da.Fill(dt)
            ds.Tables.Add(dt)

            lb.DataSource = dt
            lb.DisplayMember = dt.Columns(1).ColumnName
            lb.ValueMember = dt.Columns(0).ColumnName

            result = True

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Sub LoadDatGridView(query As String, dgv As DataGridView, name As String)
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New SqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)

            dgv.DataSource = dt

            result = True

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Function readData(query As String) As SqlDataReader
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)
            rd = cmd.ExecuteReader()
            result = True
            Return rd

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            result = False
            Return Nothing
        Finally
            'con.Close()
            'con.Dispose()
            'cmd.Dispose()
        End Try


    End Function

    Public Sub CloseCon()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Dispose()
            cmd.Dispose()
            rd.Close()
            rd.Dispose()
        End If
    End Sub


    Public Function CreateDatasource(query As String, name As String) As DataTable
        Try
            OpenCon()

            cmd = New SqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New SqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)
            result = True
            Return dt

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            dt = Nothing
            result = False
            Return dt
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()


        End Try

    End Function

End Class
