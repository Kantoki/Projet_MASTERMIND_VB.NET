<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxNomJ = New System.Windows.Forms.ListBox()
        Me.ListBoxnbP1 = New System.Windows.Forms.ListBox()
        Me.ListBoxnbP2 = New System.Windows.Forms.ListBox()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.labelNomJ = New System.Windows.Forms.Label()
        Me.LabelJ1 = New System.Windows.Forms.Label()
        Me.LabelJ2 = New System.Windows.Forms.Label()
        Me.v = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.ListBoxTimer = New System.Windows.Forms.ListBox()
        Me.LabelText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxNomJ
        '
        Me.ListBoxNomJ.FormattingEnabled = True
        Me.ListBoxNomJ.Location = New System.Drawing.Point(42, 198)
        Me.ListBoxNomJ.Name = "ListBoxNomJ"
        Me.ListBoxNomJ.Size = New System.Drawing.Size(179, 316)
        Me.ListBoxNomJ.TabIndex = 0
        '
        'ListBoxnbP1
        '
        Me.ListBoxnbP1.FormattingEnabled = True
        Me.ListBoxnbP1.Location = New System.Drawing.Point(263, 198)
        Me.ListBoxnbP1.Name = "ListBoxnbP1"
        Me.ListBoxnbP1.Size = New System.Drawing.Size(179, 316)
        Me.ListBoxnbP1.TabIndex = 1
        '
        'ListBoxnbP2
        '
        Me.ListBoxnbP2.FormattingEnabled = True
        Me.ListBoxnbP2.Location = New System.Drawing.Point(492, 198)
        Me.ListBoxnbP2.Name = "ListBoxnbP2"
        Me.ListBoxnbP2.Size = New System.Drawing.Size(179, 316)
        Me.ListBoxnbP2.TabIndex = 2
        '
        'ListBoxScore
        '
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.Location = New System.Drawing.Point(712, 198)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(179, 316)
        Me.ListBoxScore.TabIndex = 3
        '
        'labelNomJ
        '
        Me.labelNomJ.AutoSize = True
        Me.labelNomJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelNomJ.Location = New System.Drawing.Point(83, 153)
        Me.labelNomJ.Name = "labelNomJ"
        Me.labelNomJ.Size = New System.Drawing.Size(88, 15)
        Me.labelNomJ.TabIndex = 4
        Me.labelNomJ.Text = "Nom des joueurs"
        '
        'LabelJ1
        '
        Me.LabelJ1.AutoSize = True
        Me.LabelJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelJ1.Location = New System.Drawing.Point(306, 153)
        Me.LabelJ1.Name = "LabelJ1"
        Me.LabelJ1.Size = New System.Drawing.Size(107, 28)
        Me.LabelJ1.TabIndex = 5
        Me.LabelJ1.Text = "Nombre de parties" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en tant que Joueur 1"
        '
        'LabelJ2
        '
        Me.LabelJ2.AutoSize = True
        Me.LabelJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelJ2.Location = New System.Drawing.Point(525, 153)
        Me.LabelJ2.Name = "LabelJ2"
        Me.LabelJ2.Size = New System.Drawing.Size(107, 28)
        Me.LabelJ2.TabIndex = 6
        Me.LabelJ2.Text = "Nombre de parties " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en tant que Joueur 2"
        '
        'v
        '
        Me.v.AutoSize = True
        Me.v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v.Location = New System.Drawing.Point(780, 153)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(37, 15)
        Me.v.TabIndex = 7
        Me.v.Text = "Score"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "STATISTIQUES"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(475, 552)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(226, 54)
        Me.btnRetour.TabIndex = 9
        Me.btnRetour.Text = "Retour à l'accueil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'ListBoxTimer
        '
        Me.ListBoxTimer.FormattingEnabled = True
        Me.ListBoxTimer.Location = New System.Drawing.Point(930, 198)
        Me.ListBoxTimer.Name = "ListBoxTimer"
        Me.ListBoxTimer.Size = New System.Drawing.Size(179, 316)
        Me.ListBoxTimer.TabIndex = 10
        '
        'LabelText
        '
        Me.LabelText.AutoSize = True
        Me.LabelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelText.Location = New System.Drawing.Point(1011, 153)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(35, 15)
        Me.LabelText.TabIndex = 11
        Me.LabelText.Text = "Timer"
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projet.My.Resources.Resources.resize_img_php
        Me.ClientSize = New System.Drawing.Size(1144, 661)
        Me.Controls.Add(Me.LabelText)
        Me.Controls.Add(Me.ListBoxTimer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.LabelJ2)
        Me.Controls.Add(Me.LabelJ1)
        Me.Controls.Add(Me.labelNomJ)
        Me.Controls.Add(Me.ListBoxScore)
        Me.Controls.Add(Me.ListBoxnbP2)
        Me.Controls.Add(Me.ListBoxnbP1)
        Me.Controls.Add(Me.ListBoxNomJ)
        Me.Name = "Statistiques"
        Me.Text = "fh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxNomJ As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnbP1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnbP2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxScore As System.Windows.Forms.ListBox
    Friend WithEvents labelNomJ As System.Windows.Forms.Label
    Friend WithEvents LabelJ1 As System.Windows.Forms.Label
    Friend WithEvents LabelJ2 As System.Windows.Forms.Label
    Friend WithEvents v As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents ListBoxTimer As System.Windows.Forms.ListBox
    Friend WithEvents LabelText As System.Windows.Forms.Label
End Class
