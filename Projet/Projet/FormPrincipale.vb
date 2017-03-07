Public Class FormPrincipale

    Dim tab(4) As String
    Dim Cpt As Integer = 0
    Dim Gagner As Boolean
    Dim Seconde As Integer = 0
    Dim Minute As Integer = 0
    Enum Etat_Réponse
        Abs
        Pr
        Pr_Bp
    End Enum
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

    Private Function checkPrésent(ByVal c As String) As Boolean
        For i As Integer = 0 To Me.tab.Length - 1
            If c = Me.tab(i) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function checkValidé(ByVal c As String, ByVal n As Integer) As Etat_Réponse
        If checkPrésent(c) Then
            If c = Me.tab(n) Then
                Return Etat_Réponse.Pr_Bp
            Else
                Return Etat_Réponse.Pr
            End If
        Else
            Return Etat_Réponse.Abs
        End If

    End Function

    Private Function checkFin() As Boolean
        For i As Integer = 0 To Me.getPanel(Cpt).Controls.Count - 1
            If Not (Me.checkValidé(PanelRéponse.Controls(i).Text, i) = Etat_Réponse.Pr_Bp) Then
                Return False
            End If
        Next
        Return True

    End Function
    Private Function getCoupRestant(ByVal i As Integer) As Integer
        Return 15 - i
    End Function
    Public Function addtab(ByVal s As String, ByVal i As Integer)
        tab(i) = s
    End Function

    Private Function getPanel(ByVal i As Integer) As Panel
        Select Case Cpt
            Case 0
                Return Panel1
            Case 1
                Return Panel2
            Case 2
                Return Panel3
            Case 3
                Return Panel4
            Case 4
                Return Panel5
            Case 5
                Return Panel6
            Case 6
                Return Panel7
            Case 7
                Return Panel8
            Case 8
                Return Panel9
            Case 9
                Return Panel10
            Case 10
                Return Panel11
            Case 11
                Return Panel12
            Case 12
                Return Panel13
            Case 13
                Return Panel14
            Case Else
                Return Panel15
        End Select

    End Function

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim Etat As Etat_Réponse
        Dim P As Panel = Me.getPanel(Cpt)

        For i As Integer = 0 To PanelRéponse.Controls.Count - 1
            If PanelRéponse.Controls(i).Text = "" Then
                MsgBox("Veuillez remplir les 5 cases !")
                Exit Sub

            End If
        Next


        For i As Integer = 0 To PanelRéponse.Controls.Count - 1
            Etat = Me.checkValidé(PanelRéponse.Controls(i).Text, i)
            P.Controls(i).Text = PanelRéponse.Controls(i).Text
            Select Case Etat
                Case Etat_Réponse.Abs
                    PanelRéponse.Controls(i).BackColor = Me.LabelAbsent.ForeColor
                    P.Controls(i).ForeColor = Me.LabelAbsent.ForeColor
                Case Etat_Réponse.Pr
                    PanelRéponse.Controls(i).BackColor = Me.LabelPrésent.ForeColor
                    P.Controls(i).ForeColor = Me.LabelPrésent.ForeColor
                Case Etat_Réponse.Pr_Bp
                    PanelRéponse.Controls(i).BackColor = Me.LabelPrésentEtBP.ForeColor
                    P.Controls(i).ForeColor = Me.LabelPrésentEtBP.ForeColor


            End Select

        Next
        P.Visible = True
        If (Me.checkFin) Then
            LabelGG.Text = "Bravo, c'est gagné"
            LabelGG.Visible = True
            ButtonBye.Visible = True
            Me.Gagner = True
            btnGuess.Enabled = False
            Me.Text = "Gagné!"
            Timer1.Stop()
        Else
            Me.Cpt = Cpt + 1
            If Cpt >= 15 Then
                LabelGG.Text = "Désolé mais c'est perdu"
                LabelGG.Visible = True
                ButtonBye.Visible = True
                Me.Gagner = False
                btnGuess.Enabled = False
                Me.Text = "Perdu!"
                Timer1.Stop()
            Else
                Me.Text = "Il vous reste " & getCoupRestant(Cpt) & " coup(s)..."
            End If
        End If


    End Sub

    Private Sub FormPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " & getCoupRestant(Cpt) & " coup(s)..."
        Timer1.Interval = 1000
        Timer1.Start()
        LabelTimer.Text = Minute & " : 0" & Seconde

    End Sub

    Private Sub Essais_Paint(sender As Object, e As PaintEventArgs) Handles Essais.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Seconde += 1
        If (Seconde = 60) Then
            Minute += 1
            Seconde -= 60
            If (Minute = 5) Then
                LabelGG.Text = "Désolé mais c'est perdu"
                LabelGG.Visible = True
                ButtonBye.Visible = True
                Me.Gagner = False
                btnGuess.Enabled = False
                Me.Text = "Perdu!"
                Timer1.Stop()
            End If
        End If

        If (Seconde < 10) Then
            LabelTimer.Text = Minute & " : 0" & Seconde
        Else
            LabelTimer.Text = Minute & " : " & Seconde
        End If




    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonBye.Click

        If (Gagner) Then
            Module1.augmenterScore(MenuGen.ComboBoxJ1.Text, True)
        Else
            Module1.augmenterScore(MenuGen.ComboBoxJ2.Text, False)
        End If


        Dim s As String = MenuGen.ComboBoxJ1.Text
        MenuGen.ComboBoxJ1.Text = MenuGen.ComboBoxJ2.Text

        MenuGen.ComboBoxJ2.Text = s

        Me.Close()
    End Sub

End Class
