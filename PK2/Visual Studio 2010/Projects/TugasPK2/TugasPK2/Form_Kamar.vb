Public Class Form_Kamar

    Private Sub btnPilih_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        With Form_Checkin
            If rbVIP.Checked = True Then
                .tJenisKamar.Text = rbVIP.Text
                Tarif_Kamar = 750000
            ElseIf rbBisnis.Checked = True Then
                .tJenisKamar.Text = rbBisnis.Text
                Tarif_Kamar = 500000
            ElseIf rbEkonomi.Checked = True Then
                .tJenisKamar.Text = rbEkonomi.Text
                Tarif_Kamar = 300000
            Else
                MessageBox.Show("Anda Belum Memilih Jenis Kamar", "Jenis Kamar", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString()
                rbVIP.Focus()
                Exit Sub
            End If
            If rb1.Checked = True Then
                .tNamaKamar.Text = .tJenisKamar.Text & " " & rb1.Text
            ElseIf rb2.Checked = True Then
                .tNamaKamar.Text = .tJenisKamar.Text & " " & rb2.Text
            ElseIf rb3.Checked = True Then
                .tNamaKamar.Text = .tJenisKamar.Text & " " & rb3.Text
            ElseIf rb4.Checked = True Then
                .tNamaKamar.Text = .tJenisKamar.Text & " " & rb4.Text
            ElseIf rb5.Checked = True Then
                .tNamaKamar.Text = .tJenisKamar.Text & " " & rb5.Text
            Else
                MessageBox.Show("Anda Belum Memilih No Kamar", "No Kamar", MessageBoxButtons.OK, MessageBoxIcon.Warning).ToString()
                rb1.Focus()
                Exit Sub
            End If
            .tTarifKamar.Text = Format(Tarif_Kamar, "RP #,#.00")
            Biaya_Kamar = Tarif_Kamar * Val(.tLama.Text)
            .tBiayaKamar.Text = Format(Biaya_Kamar, "RP #,#.00")
            .Enabled = True
            .gbExtra.Enabled = True
            .rbBed.Focus()
        End With
        Me.Close()
    End Sub

    Private Sub Form_Kamar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        rbVIP.Checked = False
        rbBisnis.Checked = False
        rbEkonomi.Checked = False
        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
    End Sub
End Class
Module MdlVar
    Public Tarif_Kamar, Biaya_Kamar As Single
End Module
