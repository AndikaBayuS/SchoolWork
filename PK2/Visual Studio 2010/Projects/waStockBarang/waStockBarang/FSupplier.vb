Imports System.Data.OleDb

Public Class FSupplier
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
    Sub TampilRecordS()
        ADP = New OleDbDataAdapter("SELECT * FROM TSupp", DB)
        DS = New DataSet
        ADP.Fill(DS, "TSupp")
        GridSupplier.DataSource = DS.Tables("TSupp")
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
        TKdS.Enabled = False
        TNamaS.Enabled = False
        TAlamatS.Enabled = False
        TNotelS.Enabled = False
        TKdS.Text = ""
        TNamaS.Text = ""
        TAlamatS.Text = ""
        TNotelS.Text = ""
        Call ButtonInput()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenDB()
        Call ClearText()
        Call TampilRecordS()
    End Sub

    Private Sub BtnInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Call ClearText()
        TKdS.Enabled = True
        TKdS.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SQL = "INSERT INTO TSupp(Kd_Supp, Nama_Supp, Alamat_Supp, Notel_Supp)" & _
            "values('" &
      TKdS.Text & "', '" & _
      TNamaS.Text & "', '" & _
      TAlamatS.Text & "', '" & _
      TNotelS.Text & "')"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        CMD.Clone()
        BtnInput.Enabled = True
        BtnInput.Focus()
        Call ClearText()
        Call TampilRecordS()
    End Sub

    Private Sub TKdS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TKdS.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        Dim Kode As String
        If Button = 13 Then

            SQL = "SELECT * FROM TSupp Where Kd_Supp = '" & TKdS.Text & "'"
            CMD = New OleDbCommand(SQL, DB)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                TNamaS.Text = DR.Item(1)
                TAlamatS.Text = DR.Item(2)
                TNotelS.Text = DR.Item(3)
                Call ButtonEdit()
                MsgBox("Data ditemukan!")
            Else
                Kode = TKdS.Text
                TKdS.Text = Kode
                Call ButtonSave()
            End If
            TNamaS.Enabled = True
            TNamaS.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call ClearText()
        TKdS.Focus()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SQL = "DELETE FROM TSupp Where Kd_Supp='" & TKdS.Text & "'"
        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordS()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        SQL = "UPDATE TSupp SET Nama_Supp='" & TNamaS.Text & "'," & _        " Alamat_Supp ='" & TAlamatS.Text & "'," & _
        " Notel_Supp ='" & TNotelS.Text & "'" & _
        " Where Kd_Supp ='" & TKdS.Text & "'"

        CMD = New OleDbCommand(SQL, DB)
        CMD.ExecuteNonQuery()
        Call BtnInput_Click(sender, e)
        Call TampilRecordS()
    End Sub

    Private Sub TNamaS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNamaS.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TNamaS.Text <> "" Then
            TAlamatS.Enabled = True
            TAlamatS.Focus()
        End If
    End Sub

    Private Sub TAlamatS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TAlamatS.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TAlamatS.Text <> "" Then
            TNotelS.Enabled = True
            TNotelS.Focus()
        End If
    End Sub

    Private Sub TNotelS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNotelS.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        If Button = 13 And TNotelS.Text <> "" Then
            If BtnSave.Enabled = True Then
                BtnSave.Focus()
            Else
                BtnEdit.Focus()
            End If
        End If
    End Sub

    Private Sub TKdS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TKdS.TextChanged

    End Sub
End Class