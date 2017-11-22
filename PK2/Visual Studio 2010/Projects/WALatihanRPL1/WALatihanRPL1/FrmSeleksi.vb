Public Class FrmSeleksi

    Private Sub FrmSeleksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Seleksi Kondisi/Percabangan dengab Statemen IF
        'If <Kriteria> Then
        '   <Intruksi Benar>
        'Else
        '   <Intruksi Salah>
        'End If
        Dim Nilai As Integer = 99
        Dim Ket As String
        If Nilai >= 75 Then
            Ket = "Lulus"
        Else
            Ket = "Gagal"
        End If
        Label1.Text = Ket
        'Seleksi Kondiai dengan Statement CASE
        'Select Case <Variable>/Value
        '   Case <Criteria>
        '       <Instruksi Benar>
        '    Case Else
        '       <Instruksi Salah>
        'End Select
        Select Case Nilai
            Case Is >= 75
                Ket = "Selamat Anda Lulus"
            Case Else
                Ket = "Maaf Anda Gagal"
        End Select
        Label2.Text = Ket
        'Seleksi  Banyak Kondisi dengan Statement If
        'if <Instruksi 1> Then
        '   <Instruksi Benar 1>
        'Else If <Kriteria 2>
        '   <Instruksi Benar 2>
        'Else If <Kriteria Salah>
        '   <Instruksi Salah
        'End If
        If Nilai > 90 Then
            Ket = "A"
        ElseIf Nilai > 80 Then
            Ket = "B"
        ElseIf Nilai > 70 Then
            Ket = "C"
        ElseIf Nilai > 50 Then
            Ket = "D"
        Else
            Ket = "E"
        End If
        Label3.Text = "Nilai Huruf : " & Ket
        'Seleksi Banyak Kondisi dengan Statement Case
        Select Ket
            Case "A"
                Ket = "Sangat Baik"
            Case "B"
                Ket = "Baik"
            Case "C"
                Ket = "Cukup"
            Case "D"
                Ket = "Kurang"
        End Select
        Label4.Text = "Predikat Anda : " & Ket
        'Menampilkan Hari (Case)
        Dim Nohari As Integer = Weekday(Now)
        Dim NamaHari As String
        Select Case Nohari
            Case 1
                NamaHari = "Minggu"
            Case 2
                NamaHari = "Senin"
            Case 3
                NamaHari = "Selasa"
            Case 4
                NamaHari = "Rabu"
            Case 5
                NamaHari = "Kamis"
            Case 6
                NamaHari = "Jum'at"
            Case 7
                NamaHari = "Sabtu"
        End Select
        Label5.Text = "Hari ini : " & NamaHari
    End Sub
End Class