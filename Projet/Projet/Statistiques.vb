Public Class Statistiques


    Private Sub Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Affiche 0 dans la ListboxP1 et ListBoxP2
        Module1.lectureFichier("fichierJoueur.txt")
        Dim j As Module1.Joueur
        For i As Integer = 0 To getNbJoueur()
            j = getListeJoueur(i)
            ListBoxnbP1.Items.Add(j.nbDePartieJ1)
            ListBoxnbP2.Items.Add(j.nbDePartieJ2)
            ListBoxNomJ.Items.Add(j.nomJ)
            ListBoxScore.Items.Add(j.score)
            ListBoxTimer.Items.Add(j.tempsJouer)
        Next
    End Sub


    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub
End Class