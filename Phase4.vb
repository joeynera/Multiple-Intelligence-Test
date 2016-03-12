Public Class Phase4

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Dim Done1, Done2, Done3, Done4, Done5, Done6, Done7, Done8 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If (Done1 <> "" And Done2 <> "" And Done3 <> "" And Done4 <> "" And Done5 <> "" And Done6 <> "" And Done7 <> "" And Done8 <> "") Then
            Phase6.Show()
            Done1 = ""
            Done2 = ""
            Done3 = ""
            Done4 = ""
            Done5 = ""
            Done6 = ""
            Done7 = ""
            Done8 = ""
            gray1.Visible = False
            gray2.Visible = False
            gray3.Visible = False
            gray4.Visible = False
            gray5.Visible = False
            gray6.Visible = False
            gray7.Visible = False
            gray8.Visible = False
            Me.Hide()
        End If
        lbl_error.Text = ""
    End Sub

    Private Sub Phase4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gray1.Visible = False
        gray2.Visible = False
        gray3.Visible = False
        gray4.Visible = False
        gray5.Visible = False
        gray6.Visible = False
        gray7.Visible = False
        gray8.Visible = False
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


    Private Sub Pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic1.Click, gray1.Click
        If (Done1 <> "done") Then
            Phase5_1.Show()
            Done1 = "done"
            gray1.Visible = True
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2.Click, gray2.Click
        If (Done2 <> "done") Then
            Phase5_2.Show()
            gray2.Visible = True
            Done2 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic3.Click, gray3.Click
        If (Done3 <> "done") Then
            Phase5_3.Show()
            gray3.Visible = True
            Done3 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic4.Click, gray4.Click
        If (Done4 <> "done") Then
            Phase5_4.Show()
            gray4.Visible = True
            Done4 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic5.Click, gray5.Click
        If (Done5 <> "done") Then
            Phase5_5.Show()
            gray5.Visible = True
            Done5 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic6.Click, gray6.Click
        If (Done6 <> "done") Then
            Phase5_6.Show()
            gray6.Visible = True
            Done6 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic7.Click, gray7.Click
        If (Done7 <> "done") Then
            Phase5_7.Show()
            gray7.Visible = True
            Done7 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub Pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic8.Click, gray8.Click
        If (Done8 <> "done") Then
            Phase5_8.Show()
            gray8.Visible = True
            Done8 = "done"
            Me.Hide()
        Else
            lbl_error.Text = "*Category Already Finished, Please Choose Another.."
        End If
    End Sub

    Private Sub btn_minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
