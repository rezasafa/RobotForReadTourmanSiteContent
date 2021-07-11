Imports System.Threading
Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        current_page = 0
        For i As Integer = nudEnd.Value To nudStart.Value Step -1
            Dim frm As New frmShowWeb
            With frm
                current_page = i
                lblCurrent.Text = current_page
                frm.Text = "http://tourman.ir/tour/" & i & "/1"
                frm.ShowDialog()
                frm.Close()
            End With
            'Dim Chrome() As Process = Process.GetProcessesByName("chrome")
            'For Each Process As Process In Chrome
            '    Process.Kill()
            'Next
            'Thread.Sleep(2000)
        Next
    End Sub
End Class
