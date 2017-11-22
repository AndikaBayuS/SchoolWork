Public Class Form1
    Dim Panjang As Integer
    Dim Lebar As Integer
    Dim Tinggi As Integer
    Dim Hasil As Integer
    Dim Panjang2 As String
    Dim Tinggi2 As String
    Dim Lebar2 As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panjang2 = TextBox1.Text
        Panjang = Integer.Parse(Panjang2)
        Lebar2 = TextBox2.Text
        Lebar = Integer.Parse(Lebar2)
        Tinggi2 = TextBox3.Text
        Tinggi = Integer.Parse(Tinggi2)
        Hasil = Panjang * Lebar * Tinggi
        Label5.Text = Hasil
        Label5.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
