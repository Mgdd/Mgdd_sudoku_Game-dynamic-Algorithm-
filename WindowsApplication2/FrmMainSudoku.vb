Public Class FrmMainSudoku

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        FrmGameList.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim SAPI
        'SAPI = CreateObject("SAPI.spvoice")
        'SAPI.speak("welcome my freind")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        FrmMouseMaze.Show()
        Me.Hide()
    End Sub
End Class
