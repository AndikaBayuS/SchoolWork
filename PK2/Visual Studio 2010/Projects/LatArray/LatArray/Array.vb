Public Class Array

    Dim ArrayProv() As String = {"Jawa Barat", "Banten", "Jawa Tengah"}
    Dim ArrayKotaJabar() As String = {"Bandung", "Cimahi"}
    Dim ArrayKotaBanten() As String = {"Cilegon", "Serang"}
    Dim ArrayKotaJateng() As String = {"Brebes", "Semarang"}
    Dim ArrayKecBandung() As String = {"Antapani", "Babakanciparay"}
    Dim ArrayKecCimahi() As String = {"Cimahi Utara", "Cimahi Tengah"}
    Dim ArrayKecCilegon() As String = {"Cibeber", "Gerogol"}
    Dim ArrayKecSerang() As String = {"Curug", "Kasemen"}
    Dim ArrayKecBrebes() As String = {"Losari", "Salem"}
    Dim ArrayKecSemarang() As String = {"Banyumanik", "Mijen"}

    Private Sub LatArray_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbProv.Items.AddRange(ArrayProv)
    End Sub

    Private Sub cmbProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProv.SelectedIndexChanged
        If cmbProv.SelectedIndex = 0 Then
            cmbKota.Items.Clear()
            cmbKota.Items.AddRange(ArrayKotaJabar)
        ElseIf cmbProv.SelectedIndex = 1 Then
            cmbKota.Items.Clear()
            cmbKota.Items.AddRange(ArrayKotaBanten)
        ElseIf cmbProv.SelectedIndex = 2 Then
            cmbKota.Items.Clear()
            cmbKota.Items.AddRange(ArrayKotaJateng)
        End If
    End Sub

    Private Sub cmbKota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKota.SelectedIndexChanged
        If cmbKota.SelectedItem = "Bandung" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecBandung)
        ElseIf cmbKota.SelectedItem = "Cimahi" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecCimahi)
        ElseIf cmbKota.SelectedItem = "Cilegon" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecCilegon)
        ElseIf cmbKota.SelectedItem = "Serang" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecSerang)
        ElseIf cmbKota.SelectedItem = "Brebes" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecBrebes)
        ElseIf cmbKota.SelectedItem = "Semarang" Then
            cmbKecamatan.Items.Clear()
            cmbKecamatan.Items.AddRange(ArrayKecSemarang)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        If cmbProv.SelectedItem = "" Then
            MsgBox("Belum Pilih Provinsi")
        ElseIf cmbKota.SelectedItem = "" Then
            MsgBox("Belum Pilih Kota")
        ElseIf cmbKecamatan.SelectedItem = "" Then
            MsgBox("Belum Pilih Kecamatan")
        Else
            lstTampil.Items.Clear()
            lstTampil.Items.Add("Provinsi Yang Dipilih " + cmbProv.SelectedItem)
            lstTampil.Items.Add("Kota Yang Dipilih " + cmbKota.SelectedItem)
            lstTampil.Items.Add("Kecamatan Yang Dipilih " + cmbKecamatan.SelectedItem)
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstTampil.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class