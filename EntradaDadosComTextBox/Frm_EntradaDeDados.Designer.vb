<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EntradaDeDados
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Num1 = New System.Windows.Forms.TextBox()
        Me.Txt_Num2 = New System.Windows.Forms.TextBox()
        Me.Lbl_PrimeiroNum = New System.Windows.Forms.Label()
        Me.Lbl_SegundoNum = New System.Windows.Forms.Label()
        Me.Btn_CalcularSoma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Somando Números"
        '
        'Txt_Num1
        '
        Me.Txt_Num1.Location = New System.Drawing.Point(15, 52)
        Me.Txt_Num1.Name = "Txt_Num1"
        Me.Txt_Num1.Size = New System.Drawing.Size(156, 20)
        Me.Txt_Num1.TabIndex = 1
        '
        'Txt_Num2
        '
        Me.Txt_Num2.Location = New System.Drawing.Point(15, 93)
        Me.Txt_Num2.Name = "Txt_Num2"
        Me.Txt_Num2.Size = New System.Drawing.Size(156, 20)
        Me.Txt_Num2.TabIndex = 2
        '
        'Lbl_PrimeiroNum
        '
        Me.Lbl_PrimeiroNum.AutoSize = True
        Me.Lbl_PrimeiroNum.Location = New System.Drawing.Point(12, 36)
        Me.Lbl_PrimeiroNum.Name = "Lbl_PrimeiroNum"
        Me.Lbl_PrimeiroNum.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_PrimeiroNum.TabIndex = 3
        Me.Lbl_PrimeiroNum.Text = "Primeiro Número"
        '
        'Lbl_SegundoNum
        '
        Me.Lbl_SegundoNum.AutoSize = True
        Me.Lbl_SegundoNum.Location = New System.Drawing.Point(12, 77)
        Me.Lbl_SegundoNum.Name = "Lbl_SegundoNum"
        Me.Lbl_SegundoNum.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_SegundoNum.TabIndex = 4
        Me.Lbl_SegundoNum.Text = "Segundo Número"
        '
        'Btn_CalcularSoma
        '
        Me.Btn_CalcularSoma.Location = New System.Drawing.Point(15, 128)
        Me.Btn_CalcularSoma.Name = "Btn_CalcularSoma"
        Me.Btn_CalcularSoma.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CalcularSoma.TabIndex = 5
        Me.Btn_CalcularSoma.Text = "Calcular"
        Me.Btn_CalcularSoma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resultado: "
        '
        'Txt_Result
        '
        Me.Txt_Result.Location = New System.Drawing.Point(209, 93)
        Me.Txt_Result.Name = "Txt_Result"
        Me.Txt_Result.Size = New System.Drawing.Size(156, 20)
        Me.Txt_Result.TabIndex = 7
        '
        'Frm_EntradaDeDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 173)
        Me.Controls.Add(Me.Txt_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_CalcularSoma)
        Me.Controls.Add(Me.Lbl_SegundoNum)
        Me.Controls.Add(Me.Lbl_PrimeiroNum)
        Me.Controls.Add(Me.Txt_Num2)
        Me.Controls.Add(Me.Txt_Num1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_EntradaDeDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Dados com TextBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Num1 As TextBox
    Friend WithEvents Txt_Num2 As TextBox
    Friend WithEvents Lbl_PrimeiroNum As Label
    Friend WithEvents Lbl_SegundoNum As Label
    Friend WithEvents Btn_CalcularSoma As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Result As TextBox
End Class
