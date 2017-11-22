Imports System.Data.OleDb

Public Class FPelanggan
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
    Sub TampilRecordP()
        ADP = New OleDbDataAdapter("SELECT * FROM TPelanggan", DB)
        DS = New DataSet
        ADP.Fill(DS, "TPelanggan")
        GridPelanggan.DataSource = DS.Tables("TPelanggan")
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
        TKdP.Enabled = False
        TNamaP.Enabled = False
        TAlamat.Enabled = False
        TNoTel.Enabled = False
        TKdP.Text = ""
        TNamaP.Text = ""
        TAlamat.Text = ""
        TNoTel.Text = ""
        Call ButtonInput()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenDB()
        Call ClearText()
        Call TampilRecordP()
    End Sub

    Private Sub BtnInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Call ClearText()
        TKdP.Enabled = True
        TKdP.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SQL = "INSERT INTO TPelanggan(Kd_Pelanggan, Nama_Pelanggan, Alamat, Notel)" & _
            "values('" &
      TKdP.Text & "', '" & _
      TNamaP.Text & "', '" & _
      TAlamat.Text & "', '" & _
      TNoTel.Text & "')"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        CMD.Clone()
        BtnInput.Enabled = True
        BtnInput.Focus()
        Call ClearText()
        Call TampilRecordP()
    End Sub

    Private Sub TKdP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKdP.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        Dim Kode As String
        If Button = 13 Then

            SQL = "SELECT * FROM TPelanggan Where KD_Pelanggan = '" & TKdP.Text & "'"
            CMD = New OleDbCommand(SQL, DB)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                TNamaP.Text = DR.Item(1)
                TAlamat.Text = DR.Item(2)
                TNoTel.Text = DR.Item(3)
                Call ButtonEdit()
                MsgBox("Data ditemukan!")
            Else
                Kode = TKdP.Text
                TKdP.Text = Kode
                Call ButtonSave()
            End If
            TNamaP.Enabled = True
            TNamaP.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call ClearText()
        TKdP.Focus()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SQL = "DELETE FROM TPelanggan Where Kd_Pelanggan='" & TKdP.Text & "'"
        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordP()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        SQL = "UPDATE TPelanggan SET Nama_Pelanggan='" & TNamaP.Text & "'," & _        " Alamat ='" & TAlamat.Text & "'," & _
        " Notel ='" & TNoTel.Text & "'" & _
        " Where Kd_Pelanggan ='" & TKdP.Text & "'"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordP()
    End Sub

    Private Sub TNamaP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNamaP.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TNamaP.Text <> "" Then
            TAlamat.Enabled = True
            TAlamat.Focus()
        End If
    End Sub

    Private Sub TAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TAlamat.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TAlamat.Text <> "" Then
            TNoTel.Enabled = True
            TNoTel.Focus()
        End If
    End Sub

    Private Sub TNoTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNoTel.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TNoTel.Text <> "" Then
            If BtnSave.Enabled = True Then
                BtnSave.Focus()
            Else
                BtnEdit.Focus()
            End If
        End If
    End Sub

    Private Sub TKdP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TKdP.TextChanged

    End Sub
End Class