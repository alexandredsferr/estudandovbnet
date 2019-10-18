<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal
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
        Me.Lbl_Inteiro = New System.Windows.Forms.Label()
        Me.Btn_Inteiro = New System.Windows.Forms.Button()
        Me.Lbl_Flutuante = New System.Windows.Forms.Label()
        Me.Btn_Flutuante = New System.Windows.Forms.Button()
        Me.Lbl_String = New System.Windows.Forms.Label()
        Me.Btn_String = New System.Windows.Forms.Button()
        Me.Lbl_Char = New System.Windows.Forms.Label()
        Me.Btn_Char = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Inteiro
        '
        Me.Lbl_Inteiro.AutoSize = True
        Me.Lbl_Inteiro.Location = New System.Drawing.Point(12, 29)
        Me.Lbl_Inteiro.Name = "Lbl_Inteiro"
        Me.Lbl_Inteiro.Size = New System.Drawing.Size(102, 13)
        Me.Lbl_Inteiro.TabIndex = 0
        Me.Lbl_Inteiro.Text = "Tipo Inteiro - Integer"
        '
        'Btn_Inteiro
        '
        Me.Btn_Inteiro.Location = New System.Drawing.Point(24, 55)
        Me.Btn_Inteiro.Name = "Btn_Inteiro"
        Me.Btn_Inteiro.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Inteiro.TabIndex = 1
        Me.Btn_Inteiro.Text = "Inteiro"
        Me.Btn_Inteiro.UseVisualStyleBackColor = True
        '
        'Lbl_Flutuante
        '
        Me.Lbl_Flutuante.AutoSize = True
        Me.Lbl_Flutuante.Location = New System.Drawing.Point(140, 29)
        Me.Lbl_Flutuante.Name = "Lbl_Flutuante"
        Me.Lbl_Flutuante.Size = New System.Drawing.Size(165, 13)
        Me.Lbl_Flutuante.TabIndex = 2
        Me.Lbl_Flutuante.Text = "Tipo Flutuante - Double ou Single"
        '
        'Btn_Flutuante
        '
        Me.Btn_Flutuante.Location = New System.Drawing.Point(185, 55)
        Me.Btn_Flutuante.Name = "Btn_Flutuante"
        Me.Btn_Flutuante.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Flutuante.TabIndex = 3
        Me.Btn_Flutuante.Text = "Flutuante"
        Me.Btn_Flutuante.UseVisualStyleBackColor = True
        '
        'Lbl_String
        '
        Me.Lbl_String.AutoSize = True
        Me.Lbl_String.Location = New System.Drawing.Point(332, 29)
        Me.Lbl_String.Name = "Lbl_String"
        Me.Lbl_String.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_String.TabIndex = 4
        Me.Lbl_String.Text = "Tipo Caractere - String"
        '
        'Btn_String
        '
        Me.Btn_String.Location = New System.Drawing.Point(355, 55)
        Me.Btn_String.Name = "Btn_String"
        Me.Btn_String.Size = New System.Drawing.Size(75, 23)
        Me.Btn_String.TabIndex = 5
        Me.Btn_String.Text = "String"
        Me.Btn_String.UseVisualStyleBackColor = True
        '
        'Lbl_Char
        '
        Me.Lbl_Char.AutoSize = True
        Me.Lbl_Char.Location = New System.Drawing.Point(12, 116)
        Me.Lbl_Char.Name = "Lbl_Char"
        Me.Lbl_Char.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_Char.TabIndex = 6
        Me.Lbl_Char.Text = "Tipo Caractere - Char"
        '
        'Btn_Char
        '
        Me.Btn_Char.Location = New System.Drawing.Point(24, 147)
        Me.Btn_Char.Name = "Btn_Char"
        Me.Btn_Char.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Char.TabIndex = 7
        Me.Btn_Char.Text = "Char"
        Me.Btn_Char.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo Verdade ou False "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Boolean"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Char)
        Me.Controls.Add(Me.Lbl_Char)
        Me.Controls.Add(Me.Btn_String)
        Me.Controls.Add(Me.Lbl_String)
        Me.Controls.Add(Me.Btn_Flutuante)
        Me.Controls.Add(Me.Lbl_Flutuante)
        Me.Controls.Add(Me.Btn_Inteiro)
        Me.Controls.Add(Me.Lbl_Inteiro)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprendendo Variáveis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Inteiro As Label
    Friend WithEvents Btn_Inteiro As Button
    Friend WithEvents Lbl_Flutuante As Label
    Friend WithEvents Btn_Flutuante As Button
    Friend WithEvents Lbl_String As Label
    Friend WithEvents Btn_String As Button
    Friend WithEvents Lbl_Char As Label
    Friend WithEvents Btn_Char As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
