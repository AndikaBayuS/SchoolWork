Imports System.Data
Imports System.Data.OleDb
Public Class FrmBiodata
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim rd As OleDbDataReader
    Dim LokasiDB, Proses As String

    Sub Koneksi()
        LokasiDB = "provider=microsoft.jet.oledb.4.0;data source=C:\Users\Andika Bayu Santoso\Documents\Access\dbBiodata.mdb"
        conn = New OleDbConnection(LokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from tbSiswa", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbSiswa")
        DataGridView1.DataSource = (ds.Tables("tbSiswa"))
    End Sub

    Private Sub FrmBiodata_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Kosong()
        Call KondisiAwal()
    End Sub

    Private Sub tNIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tNIS.KeyPress
        If e.KeyChar = Chr(13) Then
            If tNIS.Text <> "" Then tNama.Focus()
            Call Koneksi()
            Dim Sql = "SELECT * FROM tbSiswa Where NIS='" & tNIS.Text & "'"
            cmd = New OleDbCommand(Sql, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                If Proses = "INPUT" Then
                    MessageBox.Show("Data Sudah Ada", "INPUT", MessageBoxButtons.OK,
MessageBoxIcon.Error)
                    tNIS.Focus()
                    Exit Sub
                Else
                    tNIS.Text = rd.Item(0)
                    tNama.Text = rd.Item(1)
                    cboKelas.Text = rd.Item(2)
                    If Proses = "EDIT" Then
                        tNama.Enabled = True
                        tNama.Focus()
                        Exit Sub
                    Else
                        Dim hapus As String = "delete from tbSiswa where NIS='" &
                       tNIS.Text & "'"
                        cmd = New OleDbCommand(hapus, conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Data berhasil dihapus", "DELETE",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call KondisiAwal()
                        Call Kosong()
                        Exit Sub
                    End If
                End If
            Else
                If Proses = "INPUT" Then
                    tNama.Enabled = True
                    tNama.Focus()
                    Exit Sub
                Else
                    MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information,
                   "Information")
                    tNIS.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Proses = "INPUT"
        tNIS.Enabled = True
        tNIS.Focus()
    End Sub

    Private Sub cboKelas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            If tNIS.Text = "" Or tNama.Text = "" Or cboKelas.Text = "" Then
                MessageBox.Show("Data belum lengkap ! Pastikan Semua di Isi",
               "INPUT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Call Koneksi()
                If Proses = "INPUT" Then
                    Dim simpan As String = "insert into tbSiswa values ('" & tNIS.Text & "','" & tNama.Text & "','" & cboKelas.Text & "')"
                    cmd = New OleDbCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan", "INPUT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call KondisiAwal()
                Else
                    Dim simpan As String = "Update tbSiswa set Nama='" & tNama.Text &
                   "', Kelas='" & cboKelas.Text & "' where NIS='" & tNIS.Text & "'"
                    cmd = New OleDbCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil diupdate", "INPUT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call KondisiAwal()
                End If
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Proses = "EDIT"
        tNIS.Enabled = True
        tNIS.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Proses = "DELETE"
        tNIS.Enabled = True
        tNIS.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub tNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tNama.KeyPress
        If e.KeyChar = Chr(13) Then
            cboKelas.Enabled = True
            cboKelas.Focus()
        End If
    End Sub
    Public Sub Kosong()
        tNIS.Enabled = False
        tNama.Enabled = False
        cboKelas.Enabled = False
        tNIS.Clear()
        tNama.Clear()
        cboKelas.Text = ""
        btnInput.Focus()
    End Sub
End Class