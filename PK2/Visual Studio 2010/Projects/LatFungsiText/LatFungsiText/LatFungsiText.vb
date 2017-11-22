Public Class LatFungsiText

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Label2.Text = Microsoft.VisualBasic.Left(Label1.Text, 3)
    End Sub

    Private Sub btnright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnright.Click
        Label2.Text = Microsoft.VisualBasic.Right(Label1.Text, 4)
    End Sub

    Private Sub btnMid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMid.Click
        Label2.Text = Microsoft.VisualBasic.Mid(Label1.Text, 5, 6)
    End Sub

    Private Sub btnLen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLen.Click
        Label2.Text = Len(Label1.Text)
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Label2.Text = Replace(Label1.Text, "SMK", "RPL SMK")
    End Sub

    Private Sub btnInstr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstr.Click
        Label2.Text = InStr(Label1.Text, "K")
    End Sub

    Private Sub btnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrim.Click
        Dim Str As String = "   SMK Telkom   "
        Label2.Text = Trim(Str)
    End Sub

    Private Sub btnLength_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLength.Click
        Dim Str As String = Label1.Text
        Label2.Text = Str.Length
    End Sub

    Private Sub btnToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToUpper.Click
        Dim Str As String = Label1.Text
        Label2.Text = Str.ToUpper
    End Sub

    Private Sub btnToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToLower.Click
        Dim Str As String = Label1.Text
        Label2.Text = Str.ToLower
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim Str As String = Label1.Text
        Label2.Text = Str.Insert(4, " BISA !!! SMK ")
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim Str As String = Label1.Text
        Label2.Text = Str.Remove(4, 6)
    End Sub

    Private Sub btnFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormat.Click
        Label1.Text = Format(5000000, " RP ###,###,###.00")
        Label2.Text = Format(Now, "dd/MM/yyyy HH:MM:ss")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Label1.Text = "SMK Telkom Purwokerto"
        Label2.Text = ""
    End Sub
End Class
