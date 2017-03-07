<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGen
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
        Me.ComboBoxJ1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxJ2 = New System.Windows.Forms.ComboBox()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.labelJoueur1 = New System.Windows.Forms.Label()
        Me.labelJoueur2 = New System.Windows.Forms.Label()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxJ1
        '
        Me.ComboBoxJ1.FormattingEnabled = True
        Me.ComboBoxJ1.Location = New System.Drawing.Point(119, 73)
        Me.ComboBoxJ1.Name = "ComboBoxJ1"
        Me.ComboBoxJ1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxJ1.TabIndex = 0
        '
        'ComboBoxJ2
        '
        Me.ComboBoxJ2.FormattingEnabled = True
        Me.ComboBoxJ2.Location = New System.Drawing.Point(119, 136)
        Me.ComboBoxJ2.Name = "ComboBoxJ2"
        Me.ComboBoxJ2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxJ2.TabIndex = 1
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(119, 199)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(144, 23)
        Me.btnJouer.TabIndex = 2
        Me.btnJouer.Text = "JOUER"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'labelJoueur1
        '
        Me.labelJoueur1.AutoSize = True
        Me.labelJoueur1.Location = New System.Drawing.Point(49, 76)
        Me.labelJoueur1.Name = "labelJoueur1"
        Me.labelJoueur1.Size = New System.Drawing.Size(48, 13)
        Me.labelJoueur1.TabIndex = 4
        Me.labelJoueur1.Text = "Joueur 1"
        '
        'labelJoueur2
        '
        Me.labelJoueur2.AutoSize = True
        Me.labelJoueur2.Location = New System.Drawing.Point(49, 139)
        Me.labelJoueur2.Name = "labelJoueur2"
        Me.labelJoueur2.Size = New System.Drawing.Size(48, 13)
        Me.labelJoueur2.TabIndex = 5
        Me.labelJoueur2.Text = "Joueur 2"
        '
        'ButtonScore
        '
        Me.ButtonScore.Location = New System.Drawing.Point(119, 248)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(144, 23)
        Me.ButtonScore.TabIndex = 6
        Me.ButtonScore.Text = "Afficher Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(119, 319)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(144, 23)
        Me.ButtonQuitter.TabIndex = 7
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'MenuGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projet.My.Resources.Resources.resize_img_php
        Me.ClientSize = New System.Drawing.Size(371, 363)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.labelJoueur2)
        Me.Controls.Add(Me.labelJoueur1)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.ComboBoxJ2)
        Me.Controls.Add(Me.ComboBoxJ1)
        Me.Name = "MenuGen"
        Me.Text = "MenuGen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxJ1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxJ2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnJouer As System.Windows.Forms.Button
    Friend WithEvents labelJoueur1 As System.Windows.Forms.Label
    Friend WithEvents labelJoueur2 As System.Windows.Forms.Label
    Friend WithEvents ButtonScore As Button
    Friend WithEvents ButtonQuitter As Button
End Class
