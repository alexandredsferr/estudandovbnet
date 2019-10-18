<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BrincandoComString
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
        Me.Lbl_InfTitulo = New System.Windows.Forms.Label()
        Me.Txt_LinguagemDigitada = New System.Windows.Forms.TextBox()
        Me.Lbl_InfDigite = New System.Windows.Forms.Label()
        Me.Btn_AddLinguagem = New System.Windows.Forms.Button()
        Me.Txt_ListaDeLinguagens = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_InfTitulo
        '
        Me.Lbl_InfTitulo.AutoSize = True
        Me.Lbl_InfTitulo.Location = New System.Drawing.Point(12, 25)
        Me.Lbl_InfTitulo.Name = "Lbl_InfTitulo"
        Me.Lbl_InfTitulo.Size = New System.Drawing.Size(183, 13)
        Me.Lbl_InfTitulo.TabIndex = 0
        Me.Lbl_InfTitulo.Text = "Adicione Suas Linguagens Preferidas"
        '
        'Txt_LinguagemDigitada
        '
        Me.Txt_LinguagemDigitada.Location = New System.Drawing.Point(15, 68)
        Me.Txt_LinguagemDigitada.Name = "Txt_LinguagemDigitada"
        Me.Txt_LinguagemDigitada.Size = New System.Drawing.Size(223, 20)
        Me.Txt_LinguagemDigitada.TabIndex = 1
        '
        'Lbl_InfDigite
        '
        Me.Lbl_InfDigite.AutoSize = True
        Me.Lbl_InfDigite.Location = New System.Drawing.Point(12, 52)
        Me.Lbl_InfDigite.Name = "Lbl_InfDigite"
        Me.Lbl_InfDigite.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_InfDigite.TabIndex = 2
        Me.Lbl_InfDigite.Text = "Digite o nome"
        '
        'Btn_AddLinguagem
        '
        Me.Btn_AddLinguagem.Location = New System.Drawing.Point(15, 104)
        Me.Btn_AddLinguagem.Name = "Btn_AddLinguagem"
        Me.Btn_AddLinguagem.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AddLinguagem.TabIndex = 3
        Me.Btn_AddLinguagem.Text = "Adicionar"
        Me.Btn_AddLinguagem.UseVisualStyleBackColor = True
        '
        'Txt_ListaDeLinguagens
        '
        Me.Txt_ListaDeLinguagens.Location = New System.Drawing.Point(15, 151)
        Me.Txt_ListaDeLinguagens.Multiline = True
        Me.Txt_ListaDeLinguagens.Name = "Txt_ListaDeLinguagens"
        Me.Txt_ListaDeLinguagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ListaDeLinguagens.Size = New System.Drawing.Size(309, 95)
        Me.Txt_ListaDeLinguagens.TabIndex = 4
        '
        'Frm_BrincandoComString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 268)
        Me.Controls.Add(Me.Txt_ListaDeLinguagens)
        Me.Controls.Add(Me.Btn_AddLinguagem)
        Me.Controls.Add(Me.Lbl_InfDigite)
        Me.Controls.Add(Me.Txt_LinguagemDigitada)
        Me.Controls.Add(Me.Lbl_InfTitulo)
        Me.Name = "Frm_BrincandoComString"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brincando com Strings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_InfTitulo As Label
    Friend WithEvents Txt_LinguagemDigitada As TextBox
    Friend WithEvents Lbl_InfDigite As Label
    Friend WithEvents Btn_AddLinguagem As Button
    Friend WithEvents Txt_ListaDeLinguagens As TextBox
End Class
