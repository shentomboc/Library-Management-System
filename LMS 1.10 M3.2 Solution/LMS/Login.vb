Public Class Login
    Dim toggle As Boolean = True
    Private Sub username_Enter(sender As Object, e As EventArgs) Handles idnumber.Enter
        If idnumber.Text = "ID Number" Then
            idnumber.Clear()
        End If
    End Sub
    Private Sub username_Leave(sender As Object, e As EventArgs) Handles idnumber.Leave
        If idnumber.Text.Length = 0 Then
            idnumber.Text = "ID Number"
        End If
    End Sub

    Private Sub password_Enter(sender As Object, e As EventArgs) Handles password.Enter
        If password.Text = "Password" Then
            password.Clear()
            password.PasswordChar = "•"
        End If
    End Sub

    Private Sub password_Leave(sender As Object, e As EventArgs) Handles password.Leave
        If password.Text.Length = 0 Then
            password.Text = "Password"
            password.PasswordChar = ""
        End If
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        query = "Select fldidnumber from tblusers where fldidnumber = '" & idnumber.Text & "' "
        exec()
        Timer1.Enabled = True
        If cnt = 0 Then
            unerr.Visible = True
            idnumber.Focus()
        Else
            query = "Select fldpassword from tblusers where fldidnumber = '" & idnumber.Text & "' and fldpassword = '" & password.Text & "' "
            exec()
            If cnt = 0 Then
                passerr.Visible = True
                password.Focus()
            Else
                query = "Select fldusertype from tblusers where fldidnumber = '" & idnumber.Text & "' "
                exec()
                For Each r As DataRow In dt.Rows
                    If r(0) = "admin" Then
                        Form1.Show()
                    Else
                        User.Show()
                    End If
                    idnumber.Text = "ID Number"
                    password.Text = "Password"
                    password.PasswordChar = ""
                    Me.Hide()
                Next
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        unerr.Visible = False
        passerr.Visible = False
    End Sub
End Class