Public Class FormReponseMaitre

    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress

        If e.KeyChar = vbBack Then Exit Sub

        e.Handled = True

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar = "#" OrElse e.KeyChar = "$" OrElse e.KeyChar = "£" OrElse e.KeyChar = "%" OrElse e.KeyChar = "@" Then
            e.Handled = False
        End If

    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress

        If e.KeyChar = vbBack Then Exit Sub

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar = "#" OrElse e.KeyChar = "$" OrElse e.KeyChar = "£" OrElse e.KeyChar = "%" OrElse e.KeyChar = "@" Then
            e.Handled = False
        End If

    End Sub

    Private Sub txt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3.KeyPress

        If e.KeyChar = vbBack Then Exit Sub

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar = "#" OrElse e.KeyChar = "$" OrElse e.KeyChar = "£" OrElse e.KeyChar = "%" OrElse e.KeyChar = "@" Then
            e.Handled = False
        End If

    End Sub

    Private Sub txt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4.KeyPress

        If e.KeyChar = vbBack Then Exit Sub

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar = "#" OrElse e.KeyChar = "$" OrElse e.KeyChar = "£" OrElse e.KeyChar = "%" OrElse e.KeyChar = "@" Then
            e.Handled = False
        End If

    End Sub

    Private Sub txt5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5.KeyPress

        If e.KeyChar = vbBack Then Exit Sub

        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar = "#" OrElse e.KeyChar = "$" OrElse e.KeyChar = "£" OrElse e.KeyChar = "%" OrElse e.KeyChar = "@" Then
            e.Handled = False
        End If

    End Sub



    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        FormPrincipale.addtab(txt5.Text, 0)
        FormPrincipale.addtab(txt4.Text, 1)
        FormPrincipale.addtab(txt3.Text, 2)
        FormPrincipale.addtab(txt2.Text, 3)
        FormPrincipale.addtab(txt1.Text, 4)


        If Me.txt1.Text = "" Then
            MsgBox("Veuillez remplir les 5 cases!")
        ElseIf Me.txt2.Text = "" Then
            MsgBox("Veuillez remplir les 5 cases!")
        ElseIf Me.txt3.Text = "" Then
            MsgBox("Veuillez remplir les 5 cases!")
        ElseIf Me.txt4.Text = "" Then
            MsgBox("Veuillez remplir les 5 cases!")
        ElseIf Me.txt5.Text = "" Then
            MsgBox("Veuillez remplir les 5 cases!")
        Else
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txt4.Text = ""
            txt5.Text = ""
            FormPrincipale.Show()
            Me.Hide()

        End If

    End Sub
End Class
