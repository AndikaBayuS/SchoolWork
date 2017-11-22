Public Class FrmVariabel
    Dim vNama As String
    Dim vGajiPokok As Single
    Dim vPajak As Single
    Dim vTotalGaji As Single

    Private Sub FrmVariabel_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        vNama = "Andika"
        vGajiPokok = 5000000
        vPajak = vGajiPokok * 0.1
        vTotalGaji = vGajiPokok - vPajak
        Label1.Text = "Nama Anda : " & vNama
        Label2.Text = "Gaji Pokok : " & vGajiPokok
        Label3.Text = "Pajak Penghasilan : " & vPajak
        Label4.Text = "Total Gaji : " & vTotalGaji

    End Sub

    Private Sub BtnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Dim Nama As String
        Nama = InputBox("Masukkan Nama Anda : ", "Input Nama")
        Label5.Text = Nama
    End Sub
End Class
