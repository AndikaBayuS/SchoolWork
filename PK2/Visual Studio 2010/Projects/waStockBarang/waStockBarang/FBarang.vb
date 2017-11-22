Imports System.Data.OleDb

Public Class FBarang
    Public DB As OleDbConnection
    Public CMD As OleDbCommand
    Public ADP As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DS As New DataSet
    Dim SQL As String
    Public Sub OpenDB()
        Dim LOKASI = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Tugas\Database App\dbStock_Barang.mdb"
        DB = New OleDbConnection(LOKASI)
        If DB.State = ConnectionState.Closed Then
            DB.Open()
        End If
    End Sub
    Sub TampilRecordBarang()
        'PERINTAH SELECT
        ADP = New OleDbDataAdapter("SELECT * FROM TBarang", DB)
        DS = New DataSet
        ADP.Fill(DS, "TBarang")
        GridBarang.DataSource = DS.Tables("TBarang")
    End Sub
    Sub ButtonInput()
        BtnInput.Enabled = True
        BtnSave.Enabled = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnCancel.Enabled = False
        BtnClose.Enabled = True
    End Sub
    Sub ButtonEdit()
        BtnInput.Enabled = False
        BtnSave.Enabled = False
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        BtnCancel.Enabled = True
        BtnClose.Enabled = True
    End Sub
    Sub ButtonSave()
        BtnInput.Enabled = False
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnCancel.Enabled = True
        BtnClose.Enabled = False
    End Sub
    Sub ClearText()
        txtkdbarang.Enabled = False
        txtnama.Enabled = False
        txtmerk.Enabled = False
        txtsatuan.Enabled = False
        txtjml.Enabled = False
        txtharga.Enabled = False
        txtkdbarang.Text = ""
        txtnama.Text = ""
        txtmerk.Text = ""
        txtsatuan.Text = ""
        txtjml.Text = ""
        txtharga.Text = ""
        Call ButtonInput()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenDB()
        Call ClearText()
        Call TampilRecordBarang()
    End Sub

    Private Sub BtnInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Call ClearText()
        txtkdbarang.Enabled = True
        txtkdbarang.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SQL = "INSERT INTO TBarang(Kd_Barang, Nama_Barang, Merk, Satuan, Jml, Harga)" & _
            "values('" & txtkdbarang.Text & "', '" & _
      txtnama.Text & "', '" & _
      txtmerk.Text & "', '" & _
      txtsatuan.Text & "', '" & _
      txtjml.Text & "', '" & _
      txtharga.Text & "')"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        CMD.Clone()
        BtnInput.Enabled = True
        BtnInput.Focus()
        Call ClearText()
        Call TampilRecordBarang()
    End Sub

    Private Sub txtkdbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkdbarang.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        Dim xkode As String
        If Button = 13 Then

            'PERINTAH KONEKSI
            SQL = "SELECT * FROM TBarang Where KD_Barang = '" & txtkdbarang.Text & "'"
            CMD = New OleDbCommand(SQL, DB)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                txtnama.Text = DR.Item(1)
                txtmerk.Text = DR.Item(2)
                txtsatuan.Text = DR.Item(3)
                txtjml.Text = DR.Item(4)
                txtharga.Text = DR.Item(5)
                Call ButtonEdit()
                MsgBox("Data ditemukan!")
            Else
                xkode = txtkdbarang.Text
                txtkdbarang.Text = xkode
                Call ButtonSave()
            End If
            txtnama.Enabled = True
            txtnama.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call ClearText()
        txtkdbarang.Focus()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SQL = "DELETE FROM TBarang Where Kd_Barang='" & txtkdbarang.Text & "'"
        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordBarang()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        SQL = "UPDATE TBarang SET Nama_Barang='" & txtnama.Text & "'," & _        " Merk ='" & txtmerk.Text & "'," & _
        " Satuan ='" & txtsatuan.Text & "'," & _
        " Jml ='" & txtjml.Text & "'," & _
        " Harga ='" & txtharga.Text & "'" & _
        " Where Kd_Barang ='" & txtkdbarang.Text & "'"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordBarang()
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And txtnama.Text <> "" Then
            txtmerk.Enabled = True
            txtmerk.Focus()
        End If
    End Sub

    Private Sub txtmerk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmerk.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And txtmerk.Text <> "" Then
            txtsatuan.Enabled = True
            txtsatuan.Focus()
        End If
    End Sub

    Private Sub txtsatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsatuan.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And txtsatuan.Text <> "" Then
            txtjml.Enabled = True
            txtjml.Focus()
        End If
    End Sub

    Private Sub txtjml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And txtjml.Text <> "" Then
            txtharga.Enabled = True
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtharga.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And txtharga.Text <> "" Then
            If BtnSave.Enabled = True Then
                BtnSave.Focus()
            Else
                BtnEdit.Focus()
            End If
        End If
    End Sub

    Private Sub txtkdbarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtkdbarang.TextChanged

    End Sub
End Class
