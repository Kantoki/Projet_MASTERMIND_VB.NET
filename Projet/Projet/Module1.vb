Imports System.IO

Module Module1

    Public Structure Joueur

        Public nomJ As String
        Public score As Integer
        Public nbDePartieJ1 As Integer
        Public nbDePartieJ2 As Integer
        Public tempsJouer As Double

    End Structure

    Dim j As Joueur
    Dim joueurs(2) As Joueur
    Dim nbJ As Integer = 0
    Dim nbDePartieJ1 As Integer = 0
    Dim nbDePartieJ2 As Integer = 0

    Function Debut(ByVal Nom As String, ByVal b As Boolean)
        Dim j As Joueur
        j.nomJ = Nom
        If (b) Then
            j.nbDePartieJ1 += 1
            ajouterJoueur(j)
        Else
            j.nbDePartieJ2 += 1
            ajouterJoueur(j)
        End If

    End Function

    Function ajouterJoueur(ByVal j)
        'Ne fonctionne pas à completer
        Dim PAS As Integer = 2
        If (joueurs.Length <> 0) Then
            For i As Integer = 0 To joueurs.Length - 1
                If (joueurs(i).nomJ = j.nomJ) Then
                    joueurs(i).score += j.score
                    joueurs(i).nbDePartieJ1 += j.nbDePartieJ1
                    joueurs(i).nbDePartieJ2 += j.nbDePartieJ2
                    joueurs(i).tempsJouer += j.tempsJouer
                    Exit Function
                End If

            Next
        End If
        If nbJ >= UBound(joueurs) + 1 Then
            ReDim Preserve joueurs(UBound(joueurs) + PAS)
        End If

        joueurs(nbJ) = j
        nbJ += 1

    End Function
    Public Function getListeJoueur(i)
        Return joueurs(i)
    End Function

    Public Function getNbJoueur() As Integer
        Return joueurs.Length - 1
    End Function


    Private Sub ajouterJoueurLigne(ByVal ligne As String)

        Dim tab() As String = Split(ligne, " ")

        With j
            .nomJ = tab(0)
            .score = tab(1)
            .nbDePartieJ1 = tab(2)
            .nbDePartieJ2 = tab(3)
            .tempsJouer = tab(4)
        End With
        ajouterJoueur(j)
    End Sub

    Sub lectureFichier(ByVal fichier As String)
        'Ne fonctionne pas à completer

        Dim fichierJoueur As StreamReader = New StreamReader("fichierJoueur.txt")
        Dim joueur As String
        Dim nbJoueur As Integer

        'Lecture de toutes les lignes et affichage de chacune sur la page
        While fichierJoueur.Peek <> -1

            nbJoueur += 1
            joueur = fichierJoueur.ReadLine()
            'MsgBox("Joueur numéro " & nbJoueur & " : " & joueur)

        End While

        'MsgBox("Nombre de joueurs enregistrés = " & nbJoueur)

        'Fermeture du StreamReader (attention très important)
        fichierJoueur.Close()

    End Sub

    Private Function écrireJoueurLigne(ByVal j As Joueur) As String

        Return j.nomJ & " " & j.score & " " & j.nbDePartieJ1 & " " & j.nbDePartieJ2 & " " & j.tempsJouer

    End Function

    Sub écrireFichierJoueurs()
        'Ne fonctionne pas à completer
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, "fichierJoueur.txt", OpenMode.Output)
        FileClose(fileNumber)

        Dim f = My.Computer.FileSystem.OpenTextFileWriter("fichierJoueur.txt", False)

        For i As Integer = 0 To UBound(joueurs)
            f.WriteLine(écrireJoueurLigne(joueurs(i)))
        Next

        f.Close()
    End Sub
    Sub augmenterScore(ByVal nom As String, ByVal b As Boolean)

        For i As Integer = 0 To joueurs.Length - 1
            If (joueurs(i).nomJ = j.nomJ) Then
                If (b) Then
                    j.nbDePartieJ1 += 1
                Else
                    j.nbDePartieJ2 += 1
                End If
            End If
        Next
    End Sub

End Module