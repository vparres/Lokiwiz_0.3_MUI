Public Class home
    Private Sub BT_LAUNCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LAUNCH.Click
        LokiwizEN.Show()
    End Sub

    Private Sub BT_LANCER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LANCER.Click
        LokiwizFR.Show()
    End Sub

    Private Sub BT_EXIT_HOME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_EXIT_HOME.Click
        End
    End Sub

    Private Sub BT_ABOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ABOUT.Click
        About.Show()
    End Sub
End Class