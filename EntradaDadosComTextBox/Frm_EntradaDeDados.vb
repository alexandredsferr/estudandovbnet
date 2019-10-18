Public Class Frm_EntradaDeDados
    Private Sub Btn_CalcularSoma_Click(sender As Object, e As EventArgs) Handles Btn_CalcularSoma.Click
        Dim number1 As Integer = Txt_Num1.Text
        Dim number2 As Integer = Txt_Num2.Text

        Dim result As Integer = number1 + number2

        Txt_Result.Text = result

    End Sub
End Class
