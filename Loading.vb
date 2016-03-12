Public NotInheritable Class Loading

    Dim i As Integer

    Private Sub Loading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        If (i = 6) Then
            Welcome.Show()
            Me.Hide()
        End If
    End Sub

End Class
