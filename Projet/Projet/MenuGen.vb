Public Class MenuGen


    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click

        If (ComboBoxJ1.Text = "" Or ComboBoxJ2.Text = "") Then
            MsgBox("Veuillez entrer le nom des deux joueurs")

        ElseIf (ComboBoxJ1.Text = ComboBoxJ2.Text) Then
            MsgBox("Les deux joueurs ont le même nom")
        Else
            If Not (ComboBoxJ1.Items.Contains(ComboBoxJ1.Text)) Then
                ComboBoxJ1.Items.Add(ComboBoxJ1.Text)
            End If
            If Not (ComboBoxJ1.Items.Contains(ComboBoxJ2.Text)) Then
                ComboBoxJ1.Items.Add(ComboBoxJ2.Text)
            End If
            If Not (ComboBoxJ2.Items.Contains(ComboBoxJ1.Text)) Then
                ComboBoxJ2.Items.Add(ComboBoxJ1.Text)
            End If

            If Not (ComboBoxJ2.Items.Contains(ComboBoxJ2.Text)) Then
                ComboBoxJ2.Items.Add(ComboBoxJ2.Text)
            End If

            Module1.écrireFichierJoueurs()
            Module1.Debut(ComboBoxJ1.Text, True)
            Module1.Debut(ComboBoxJ2.Text, False)
            FormReponseMaitre.Show()

        End If



    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click

        If (MsgBox("Voulez-vous vraiment quitter ?", vbYesNo + vbCritical, "Quitter") = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBoxJ2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxJ2.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBoxJ1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxJ1.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Statistiques.Show()

    End Sub
End Class