Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1

    Dim path As String = ""
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim ee As New WebClient()
        Dim link = TextUri.Text
        path = TextPath.Text
        Dim site As String = ee.DownloadString(link)
        Dim linhas() As String = Regex.Split(site, "(?=lote-titulo)")


        For Each lista As String In linhas
            If Regex.IsMatch(lista, "lote-titulo") Then
                Dim nmrLote As String = Regex.Match(lista, "Lote\s000[^:]+", RegexOptions.IgnoreCase).Value
                Dim padraoPl As String = "[^A-Z\d][A-Z]{3}\d\w\d{2}[^A-Z\d]"
                Dim rgx As New Regex(padraoPl, RegexOptions.IgnoreCase)
                'Dim lote As String = Regex.Match(lista, "(lote)\s\d{6}[^\""]", RegexOptions.IgnoreCase).Value
                'Dim loteFinal As String = Regex.Match(lote, "(>Lote)\s\d{6}").Value
                Dim caminho As String = TextPath.Text + "\" + nmrLote + ".html"

                Try

                    Dim html As String = Regex.Match(lista, "(\/lotes\/)[^\""]+", RegexOptions.IgnoreCase).Value
                    Dim redir As String = "https://www.euamoleilao.com.br" + html
                    Dim stFinal As String = ee.DownloadString(redir)
                    Dim imagens() As String = Regex.Split(stFinal, "(?=src=""\/leiloes\/lotes[^\""]+)")
                    Dim contador As Integer = 1
                    For Each imgLote As String In imagens
                        criaDir()
                        If Regex.IsMatch(imgLote, "src=""\/leiloes\/lotes[^\""]+") Then
                            Dim imgFinal As String = Regex.Match(imgLote, "\/leiloes\/lotes[^\""]+", RegexOptions.IgnoreCase).Value
                            Dim verifica As String = path & "\img\" & nmrLote.Replace(" ", "") & "(" & contador & ")" & ".jpg"
                            ee.DownloadFile("https://www.euamoleilao.com.br" + imgFinal, verifica)
                        End If
                        contador = contador + 1
                    Next


                    If rgx.IsMatch(stFinal) Then

                        ee.DownloadFile(redir, caminho)

                    Else
                        MsgBox("Erro1")
                        End
                    End If
                Catch
                    MsgBox("Erro2")
                End Try

                'Dim req As String = Regex.Match(html, padraoPl, RegexOptions.IgnoreCase).Value

            End If



        Next








    End Sub
    Public Sub criaDir()
        Dim transforma As New DirectoryInfo(path + "\img")
        If Not transforma.Exists Then
            My.Computer.FileSystem.CreateDirectory(transforma.FullName)
        End If

    End Sub

End Class
