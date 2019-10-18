Public Class Frm_TelaPrincipal
    Private Sub Btn_Clique_Click(sender As Object, e As EventArgs) Handles Btn_Inteiro.Click
        'Variavel do tipo inteiro
        Dim age As Integer = 21
        MsgBox("Sua idade é " + age.ToString, MsgBoxStyle.Information, "Resultado do Clique")
    End Sub

    Private Sub Btn_Flutuante_Click(sender As Object, e As EventArgs) Handles Btn_Flutuante.Click
        'Variavel do tipo flutuante
        Dim height As Double = 1.78
        MsgBox("Sua altura é " + height.ToString, MsgBoxStyle.Information, "Resultado do Clique")

    End Sub

    Private Sub Btn_String_Click(sender As Object, e As EventArgs) Handles Btn_String.Click
        'Variavel do tipo String 
        Dim name As String = "Alexandre"
        MsgBox("Seu nome é " + name, MsgBoxStyle.Information, "Resultado do Clique")
    End Sub

    Private Sub Btn_Char_Click(sender As Object, e As EventArgs) Handles Btn_Char.Click
        Dim vogal As Char = "A"
        MsgBox("Primeira letra das vogais é " + vogal, MsgBoxStyle.Information, "Resultado do Clique")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim married As Boolean = True
        MsgBox("Casado? " + married.ToString, MsgBoxStyle.Information, "Resultado do Clique")
    End Sub

End Class
