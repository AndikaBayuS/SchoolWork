Public Class FrmInputBox
    Dim vNama As String
    Dim vGajiPokok As Single
    Dim vGaji As Single
    Dim vPajak As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Nama As String
        Dim Gaji As Single
        Nama = InputBox("Masukan Nama Anda : ", "Input Nama")
        Gaji = InputBox("Masukan Gaji Anda : ", "Input Gaji")
        vNama = Nama
        vGajiPokok = Gaji
        vPajak = Gaji * 0.1
        vGaji = Gaji - vPajak
        Label1.Visible = True
        Label1.Text = "Nama Anda : " & vNama
        Label2.Visible = True
        Label2.Text = "Gaji Pokok : RP." & vGajiPokok
        Label3.Visible = True
        Label3.Text = "Pajak Penghasilan : RP." & vPajak
        Label4.Visible = True
        Label4.Text = "Gaji bersih : RP." & vGaji

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class