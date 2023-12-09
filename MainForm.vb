' MainForm.vb
Public Class MainForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateArea()
    End Sub

    Private Sub CalculateArea()
        Dim length As Double
        Dim width As Double

        If Double.TryParse(txtLength.Text, length) AndAlso Double.TryParse(txtWidth.Text, width) Then
            Dim area As Double = length * width
            lblResult.Text = $"Area: {area}"
        Else
            lblResult.Text = "Invalid input. Please enter valid numbers for length and width."
        End If
    End Sub
End Class
