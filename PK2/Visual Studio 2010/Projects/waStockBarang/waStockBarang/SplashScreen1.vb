Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        End
    End Sub

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            FLogin.StartPosition = FormStartPosition.CenterScreen
            FLogin.Show()
        End If
    End Sub
End Class
