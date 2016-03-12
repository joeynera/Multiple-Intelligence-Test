Imports System.Data.OleDb
Public Class Phase6

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Dim Track As String
    Dim a As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Phase6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Phase5_1.Total
        Label3.Text = Phase5_2.Total
        Label5.Text = Phase5_3.Total
        Label6.Text = Phase5_4.Total
        Label7.Text = Phase5_5.Total
        Label8.Text = Phase5_6.Total
        Label9.Text = Phase5_7.Total
        Label10.Text = Phase5_8.Total

        Dim lst As Integer() = {Phase5_1.Total, Phase5_2.Total, Phase5_3.Total, Phase5_4.Total, Phase5_5.Total, Phase5_6.Total, Phase5_7.Total, Phase5_8.Total}
        Dim max As Integer = lst.Max()

        If (max <> 0) Then
            If (Phase5_1.Total = max Or Phase5_7.Total = max Or Phase5_8.Total = max) Then
                Track = "Academic"
                a = " & "
            End If
            If (Phase5_2.Total = max Or Phase5_6.Total = max) Then
                Track = Track & a & "Technical-Vocational-Livelihood"
                a = " & "
            End If
            If (Phase5_3.Total = max) Then
                Track = Track & a & "Sports"
            End If
            If (Phase5_4.Total = max Or Phase5_5.Total = max) Then
                Track = Track & a & "Arts & Design"
                a = " & "
            End If
            txt_remarks.Text = Track & " Track/s is highly recommended for you… GOODLUCK!"
        Else
            txt_remarks.Text = "No Track recommended for you…"
        End If

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

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_home.Click

        Phase5_1.Close()
        Phase5_2.Close()
        Phase5_3.Close()
        Phase5_4.Close()
        Phase5_5.Close()
        Phase5_6.Close()
        Phase5_7.Close()
        Phase5_8.Close()
        Welcome.Close()
        Phase2.Close()
        Welcome.Show()
        Me.Close()
    End Sub

End Class
