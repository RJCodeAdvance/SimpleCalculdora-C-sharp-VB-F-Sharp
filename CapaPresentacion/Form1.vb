
Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Variables
        Dim x = txtNum1.Text
        Dim y = txtNum2.Text

        'Calcular operacion desde C#
        Dim objetoCSharp As New CapaDominioCSharp.ClaseOperacion_CSharp() 'Instancia
        Dim reCSharp = objetoCSharp.Calcular(x, y, cmbOperacion.Text)
        lblResultadoCSharp.Text = "El Resultado es: " &
            reCSharp.ToString() & vbNewLine &
            "Respuesta desde C#."

        'Calcular operacion desde F#
        Dim reFSharp = Operacion_FSharp.Calcular(x, y, cmbOperacion.Text)
        lblResultadoFSharp.Text = "El Resultado es: " &
            reFSharp.ToString() & vbNewLine &
            "Respuesta desde F#."
    End Sub
End Class
