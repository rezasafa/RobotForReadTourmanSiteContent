Imports System.Text.RegularExpressions
Public Class frmShowWeb

    Private Sub insert_data(Title, Fasl, Gheymat, havazamin, modat, keshvar, shahr, aj, tel, Emails, website, adrs, Body1, body2, picimg)
        'Select Case id,Title,Fasl,Gheymat,havazamin,modat,keshvar,shahr,aj,tel,Emails,website,adrs,Body1,body2,picimg  FROM Tours
        Dim k As New mykernel
        Dim s As String = "INSERT INTO Tours " &
            "(Title,Fasl,Gheymat,havazamin,modat,keshvar,shahr,aj,tel,Emails,website,adrs,Body1,body2,picimg) VALUES " &
            "(N'" & Title & "',N'" & Fasl & "'," & Gheymat &
            ", N'" & havazamin & "',N'" & modat & "'," &
            " N'" & keshvar & "',N'" & shahr & "', N'" & aj & "',N'" & tel & "', N'" & Emails & "',N'" & website & "'," &
            " N'" & adrs & "',N'" & Body1 & "', N'" & body2 & "',N'" & picimg & "')"

        k.ExecuteCommand(s)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'MsgBox("ok")

        'RichTextBox1.Text = WebBrowser1.DocumentText
        'RichTextBox1.SaveFile("1.txt")
        'MsgBox(.Document.GetElementById("restaurant-page").InnerText)
        'MsgBox(.Document.GetElementById("restaurant-page").Children.Count)
        'MsgBox(.Document.GetElementById("restaurant-page").Children.Item(0).InnerText)
        '
        'Dim n As String
        'Dim b As String
        'Dim t As String
        'Dim a As String
        'Dim w As String
        'Dim REZA As Date = Date.Now
        'Dim DT As String = REZA.ToString("yyyy/MM/dd")
        'Dim TM As String = REZA.ToString("hh:mm")
        Dim title As String = ""
        Dim ajans As String = ""
        Dim tel As String = ""
        Dim email As String = ""
        Dim web As String = ""
        Dim adrs As String = ""
        Dim aks As String = ""

        Dim modat1 As String = ""
        Dim modat2 As String = ""

        Dim body1 As String = ""
        Dim body2 As String = ""

        Dim keshvar As String = ""

        Dim GHEYMAT As String = ""

        Dim valid As Boolean = True

        Try
            With WebBrowser1.Document.Body.Children.Item(3).Children.Item(0).Children.Item(1)

            End With
        Catch ex As Exception
            valid = False
        End Try

        Dim fn As Integer = FreeFile()

        If valid = True Then
            With WebBrowser1.Document.Body.Children.Item(3).Children.Item(0).Children.Item(1)
                'MsgBox(.Children.Item(0).InnerHtml)
                Try
                    aks = (.Children.Item(0).Children.Item(1).Children.Item(0).GetAttribute("src"))
                Catch ex As Exception

                End Try

                Try
                    ajans = (.Children.Item(0).Children.Item(1).Children.Item(1).Children.Item(0).Children.Item(0).Children.Item(1).InnerHtml)
                Catch ex As Exception

                End Try

                Try
                    tel = (.Children.Item(0).Children.Item(1).Children.Item(1).Children.Item(0).Children.Item(2).Children.Item(1).InnerHtml)
                Catch ex As Exception

                End Try

                Try
                    email = (.Children.Item(0).Children.Item(1).Children.Item(1).Children.Item(0).Children.Item(4).Children.Item(1).InnerHtml)
                Catch ex As Exception

                End Try

                Try
                    web = (.Children.Item(0).Children.Item(1).Children.Item(1).Children.Item(0).Children.Item(6).Children.Item(1).Children.Item(0).GetAttribute("href"))
                Catch ex As Exception

                End Try

                Try
                    adrs = (.Children.Item(0).Children.Item(1).Children.Item(1).Children.Item(0).Children.Item(8).Children.Item(1).InnerHtml)
                Catch ex As Exception

                End Try

                Try
                    title = (.Children.Item(0).Children.Item(2).Children.Item(0).Children.Item(0).InnerHtml)
                Catch ex As Exception

                End Try


                Try
                    'modat1 = (.Children.Item(0).Children.Item(2).Children.Item(2).InnerHtml)
                    modat2 = (.Children.Item(0).Children.Item(2).Children.Item(2).InnerText)
                Catch ex As Exception

                End Try

                Try
                    GHEYMAT = (.Children.Item(0).Children.Item(2).Children.Item(3).Children.Item(1).InnerText)
                Catch ex As Exception

                End Try


                Try
                    keshvar = (.Children.Item(0).Children.Item(2).Children.Item(4).InnerText)
                    keshvar &= vbCrLf & (.Children.Item(0).Children.Item(2).Children.Item(5).InnerText)
                Catch ex As Exception

                End Try

                Try
                    'body1 = (WebBrowser1.Document.GetElementById("summary").Children.Item(0).InnerHtml)
                    body2 = (WebBrowser1.Document.GetElementById("summary").Children.Item(0).InnerText)
                Catch ex As Exception

                End Try

            End With
            Try
                My.Computer.Network.DownloadFile(aks, "tr" & current_page & ".jpg")
            Catch ex As Exception

            End Try

            Dim price As Long = 0
            Try
                price = CType(Regex.Replace(GHEYMAT, "[^\d]", ""), Long)
            Catch ex As Exception
                price = 0
            End Try


            insert_data(title, "", price, modat1, modat2, keshvar, "", ajans, tel, email, web, adrs, body1, body2, "tr" & current_page & ".jpg")


            FileOpen(fn, "tedad.txt", OpenMode.Random)
            FilePut(fn, Text, current_page)
            FileClose(fn)

            Close()
        Else

            FileOpen(fn, "nashod.txt", OpenMode.Random)
            FilePut(fn, Text, current_page)
            FileClose(fn)

            Close()
        End If
    End Sub

    Private Sub frmShowWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WebBrowser1.DocumentText = RichTextBox1.Text
        WebBrowser1.Navigate(Text) '6870 "http://tourman.ir/tour/6870/1"
        'WebBrowser1.Navigate("http://tourman.ir/tour/545/1") '545 ""
    End Sub
End Class