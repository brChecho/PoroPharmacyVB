Public Class Home
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim medicine = New Medicine
        medicine.Show()
    End Sub
End Class