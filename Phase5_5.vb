Public Class Phase5_5

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Public Total As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private WithEvents tim As New Timer With {.Interval = 1}
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        tim.Enabled = True
    End Sub

    Dim x As Integer
    Private Sub tim_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tim.Tick
        x -= 50
        Panel2.Location = New Point(119 + x, 86)
        Panel3.Visible = True
        Panel3.Location = New Point(980 + (x - 100), 86)
        If Panel2.Location.X < -600 Then
            tim.Enabled = False
            btn_next.Visible = False
            btn_menu.Visible = True
        End If
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu.Click

        For Each ctl As Windows.Forms.Control In Panel2.Controls
            If TypeOf ctl Is System.Windows.Forms.CheckBox Then
                Dim ck As System.Windows.Forms.CheckBox = ctl
                If ck.Checked = True Then
                    Total += 1
                End If
            End If
        Next

        For Each ctl As Windows.Forms.Control In Panel3.Controls
            If TypeOf ctl Is System.Windows.Forms.CheckBox Then
                Dim ck As System.Windows.Forms.CheckBox = ctl
                If ck.Checked = True Then
                    Total += 1
                End If
            End If
        Next

        Phase4.Show()
        Me.Hide()
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
