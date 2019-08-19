<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultadoCSharp = New System.Windows.Forms.Label()
        Me.lblResultadoFSharp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(94, 14)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(165, 24)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(94, 46)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(165, 24)
        Me.txtNum2.TabIndex = 1
        '
        'cmbOperacion
        '
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Sumar", "Restar", "Multiplicar", "Dividir"})
        Me.cmbOperacion.Location = New System.Drawing.Point(94, 77)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(165, 26)
        Me.cmbOperacion.TabIndex = 2
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Location = New System.Drawing.Point(16, 121)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(243, 38)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numero 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Operacion:"
        '
        'lblResultadoCSharp
        '
        Me.lblResultadoCSharp.AutoSize = True
        Me.lblResultadoCSharp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoCSharp.ForeColor = System.Drawing.Color.Tomato
        Me.lblResultadoCSharp.Location = New System.Drawing.Point(285, 14)
        Me.lblResultadoCSharp.Name = "lblResultadoCSharp"
        Me.lblResultadoCSharp.Size = New System.Drawing.Size(130, 25)
        Me.lblResultadoCSharp.TabIndex = 7
        Me.lblResultadoCSharp.Text = "Resultado C#"
        '
        'lblResultadoFSharp
        '
        Me.lblResultadoFSharp.AutoSize = True
        Me.lblResultadoFSharp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoFSharp.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblResultadoFSharp.Location = New System.Drawing.Point(285, 80)
        Me.lblResultadoFSharp.Name = "lblResultadoFSharp"
        Me.lblResultadoFSharp.Size = New System.Drawing.Size(127, 25)
        Me.lblResultadoFSharp.TabIndex = 8
        Me.lblResultadoFSharp.Text = "Resultado F#"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 175)
        Me.Controls.Add(Me.lblResultadoFSharp)
        Me.Controls.Add(Me.lblResultadoCSharp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cmbOperacion)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultadoCSharp As Label
    Friend WithEvents lblResultadoFSharp As Label
End Class
