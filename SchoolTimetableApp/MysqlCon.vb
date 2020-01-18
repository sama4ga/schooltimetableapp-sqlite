Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MysqlCon
    Private con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=maurice5782;port=3308;database=timetable")
    Private cmd As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable
    Public ds As DataSet
    Public rd As MySqlDataReader


    Public Sub ExecuteQuery(query As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
        Finally
            con.Close()
            cmd.Dispose()
            con.Dispose()
        End Try

    End Sub


    Public Function InsertQuery(query As String, ParamValues As List(Of String)) As Long
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)

            'If command.IsPrepared Then
            cmd.Parameters.Clear()
            Dim count = 1
            For Each index In ParamValues
                Dim paramName As String = "@" & count
                cmd.Parameters.AddWithValue(paramName, index)
                count += 1
                'MsgBox(index)
            Next
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            Return cmd.LastInsertedId

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            Return 0
        Finally
            con.Close()
            con.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Sub LoadComboBox(query As String, cmb As ComboBox, name As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New MySqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = dt.Columns(1).ColumnName
            cmb.ValueMember = dt.Columns(0).ColumnName



        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Sub LoadListBox(query As String, lb As ListBox, name As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)

            dt = New DataTable(name)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet()

            da.Fill(dt)
            ds.Tables.Add(dt)

            lb.DataSource = dt
            lb.DisplayMember = dt.Columns(1).ColumnName
            lb.ValueMember = dt.Columns(0).ColumnName



        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Sub LoadDatGridView(query As String, dgv As DataGridView, name As String)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New MySqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)

            dgv.DataSource = dt



        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Sub



    Public Function readData(query As String) As MySqlDataReader
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader()

            Return rd

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
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
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New MySqlCommand(query, con)

            ds = New DataSet()
            dt = New DataTable(name)
            da = New MySqlDataAdapter(cmd)

            da.Fill(dt)
            ds.Tables.Add(dt)

            Return dt

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error executing Query")
            dt = Nothing
            Return dt
        Finally
            con.Close()
            con.Dispose()
            da.Dispose()
            cmd.Dispose()


        End Try

    End Function


End Class
