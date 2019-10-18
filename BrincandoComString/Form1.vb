Public Class Frm_BrincandoComString

    Dim linguagens As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_AddLinguagem.Click

        linguagens = Txt_LinguagemDigitada.Text
        Txt_ListaDeLinguagens.Text += linguagens.ToString + vbCrLf

    End Sub
End Class
