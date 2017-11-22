Imports System.Data.OleDb
Public Class FLogin
    Public DB As OleDbConnection
    Public CMD As OleDbCommand
    Public ADP As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DS As New DataSet
    Dim SQL As String

    Public Sub OpenDB()
        Dim Lokasi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Tugas\Database App\dbStock_Barang.mdb"
        DB = New OleDbConnection(Lokasi)
        If DB.State = ConnectionState.Closed Then
            DB.Open()
        End If
    End Sub

    Private Sub FLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BtnClose.Text = "&Close"
        TxtUsername.Focus()
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        OpenDB()
        CMD = New OleDbCommand("select * from TUser where Username='" & TxtUsername.Text & "'and Password ='" & TxtPassword.Text & "'", DB)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Hide()
            FMenu.Show()
            If DR.GetString(3) = "Admin" Then
                FMenu.MasterToolStripMenuItem.Visible = True
                FMenu.TransaksiToolStripMenuItem.Visible = True
                FMenu.UtilityToolStripMenuItem.Visible = True
                FMenu.LaporanToolStripMenuItem.Visible = True
                FMenu.LoginToolStripMenuItem.Visible = False
                FMenu.LaporanToolStripMenuItem.Visible = True
                FMenu.LogoutToolStripMenuItem.Visible = True
                TxtUsername.Clear()
                TxtPassword.Clear()
            Else
                FMenu.MasterToolStripMenuItem.Visible = True
                FMenu.TransaksiToolStripMenuItem.Visible = True
                FMenu.UtilityToolStripMenuItem.Visible = True
                FMenu.LaporanToolStripMenuItem.Visible = True
                FMenu.LoginToolStripMenuItem.Visible = False
                FMenu.LaporanToolStripMenuItem.Visible = False
                FMenu.LogoutToolStripMenuItem.Visible = True
                TxtUsername.Clear()
                TxtPassword.Clear()
            End If
        Else
            MsgBox("Pastikan Username dan Password Anda benar")
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Select Case BtnClose.Text
            Case "&Close"
                Me.Close()
            Case "&Cancel"
                TxtUsername.Clear()
                TxtPassword.Clear()
                BtnClose.Text = "&Close"
                TxtUsername.Focus()
        End Select
    End Sub

    Private Sub TxtUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUsername.TextChanged
        BtnClose.Text = "&Cancel"
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        Dim Button As Integer = Asc(e.KeyChar)
        TxtPassword.PasswordChar = "*"
        If Button = 13 Then
            BtnLogin.Enabled = True
            BtnLogin.Focus()
        End If
    End Sub
End Class