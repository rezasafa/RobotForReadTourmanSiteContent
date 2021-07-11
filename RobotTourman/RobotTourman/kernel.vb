Imports System.IO
Imports System.Data.SqlClient
Imports System.Globalization
Module kernel
    Public current_page As Integer = 0

End Module

Public Class mykernel
    Dim Con As New SqlConnection           'Connection to Database
    Dim Com As New SqlCommand              'Command For Database
    Dim dAdapter As New SqlDataAdapter     'Data Adapter
    Dim dReader As SqlDataReader           'Serach & Read From Database
    Dim dSet As New DataSet                'Data Set

    Dim pdp As String = String.Format("Data Source=safasoftco;Initial Catalog=Tourman;User ID=sa;Password=951753")

    Public Sub Connection(ByVal constring As String)
        If Not Con Is Nothing Then Con.Close()
        'Con.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Con.Close()
        '----
        Try
            Con.ConnectionString = constring
            Con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Source + vbCrLf + ex.Message)
            System.Windows.Forms.Application.Exit()
        End Try
    End Sub
    Public Sub Command(ByVal sqlCommand As String, ByVal TableName As String)
        Try
            'stop_out_box()
            'pardazesh()

            Connection(pdp)
            dSet.Clear()
            '----
            Com.Connection = Con
            Com.CommandText = sqlCommand
            Com.CommandTimeout = 0
            '----
            dAdapter.SelectCommand = Com

            'If Len(sqlCommand) > 100 Then
            '    Dim s As New System.Windows.Forms.TextBox
            '    Dim f As New System.Windows.Forms.Form
            '    f.Controls.Add(s)
            '    s.Show()
            '    s.Multiline = True
            '    s.Dock = DockStyle.Fill
            '    s.Text = sqlCommand
            '    f.WindowState = FormWindowState.Maximized
            '    f.ShowDialog()
            '    f.Close()
            'End If

            dAdapter.Fill(dSet, TableName)
            'amadeh()
        Catch ex As Exception
            'amadeh()
            ' MessageBox.Show(ex.Source + vbCrLf + ex.Message)
        End Try
    End Sub
    Public Sub ExecuteCommand(ByVal sqlCommand As String)
        Try
            'stop_out_box()
            'pardazesh()

            dSet.Clear()
            '----      
            Connection(pdp)

            Com.Connection = Con
            Com.CommandText = sqlCommand
            Com.CommandTimeout = 0
            Com.ExecuteReader()

            Con.Close()
            'amadeh()
        Catch ex As Exception
            'amadeh()
            Con.Close()
            'MessageBox.Show(ex.Source + vbCrLf + ex.Message)
        End Try
    End Sub
    Public Function Get_ExecuteCommand(ByVal sqlCommand As String) As String

        Try
            'stop_out_box()

            'pardazesh()

            dSet.Clear()
            '----      
            Connection(pdp)

            Com.Connection = Con
            Com.CommandText = sqlCommand
            Com.CommandTimeout = 0

            Dim strVal As String = ""

            strVal = Com.ExecuteScalar.ToString

            'If strVal Is DBNull.Value Then strVal = "0"
            If strVal Is "" Then strVal = "0"

            'Start_out_box()
            Con.Close()
            'amadeh()
            Return strVal
        Catch ex As Exception
            'amadeh()
            Con.Close()
            MessageBox.Show(ex.Source + vbCrLf + ex.Message)
        End Try

    End Function

End Class
