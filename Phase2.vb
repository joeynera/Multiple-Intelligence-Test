Public Class Phase2

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Public Gender As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        femalepanel.BackColor = Color.White
        malepanel.BackColor = Color.White
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub male_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles male.Click
        malepanel.BackColor = Color.RoyalBlue
        femalepanel.BackColor = Color.White
        Gender = "Male"
    End Sub

    Private Sub female_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles female.Click
        femalepanel.BackColor = Color.Magenta
        malepanel.BackColor = Color.White
        Gender = "Female"
    End Sub

    Private Sub lbl_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_start.Click
        If (malepanel.BackColor = Color.White And femalepanel.BackColor = Color.White) Then
            MsgBox("Choose a character")
        Else
            Phase3_1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
