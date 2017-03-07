<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReponseMaitre
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.labelCaracPoss = New System.Windows.Forms.Label()
        Me.labelListCarac = New System.Windows.Forms.Label()
        Me.labelTitreJeu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(52, 75)
        Me.txt1.MaxLength = 1
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(50, 20)
        Me.txt1.TabIndex = 0
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(108, 75)
        Me.txt2.MaxLength = 1
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(50, 20)
        Me.txt2.TabIndex = 1
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(164, 75)
        Me.txt3.MaxLength = 1
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(50, 20)
        Me.txt3.TabIndex = 2
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(220, 75)
        Me.txt4.MaxLength = 1
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(50, 20)
        Me.txt4.TabIndex = 3
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(276, 75)
        Me.txt5.MaxLength = 1
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(50, 20)
        Me.txt5.TabIndex = 4
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(351, 74)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(74, 20)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'labelCaracPoss
        '
        Me.labelCaracPoss.AutoSize = True
        Me.labelCaracPoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaracPoss.Location = New System.Drawing.Point(301, 115)
        Me.labelCaracPoss.Name = "labelCaracPoss"
        Me.labelCaracPoss.Size = New System.Drawing.Size(124, 13)
        Me.labelCaracPoss.TabIndex = 6
        Me.labelCaracPoss.Text = "Caractères possibles"
        '
        'labelListCarac
        '
        Me.labelListCarac.AutoSize = True
        Me.labelListCarac.Location = New System.Drawing.Point(306, 137)
        Me.labelListCarac.Name = "labelListCarac"
        Me.labelListCarac.Size = New System.Drawing.Size(57, 13)
        Me.labelListCarac.TabIndex = 7
        Me.labelListCarac.Text = "# $ £ % @"
        '
        'labelTitreJeu
        '
        Me.labelTitreJeu.AutoSize = True
        Me.labelTitreJeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitreJeu.Location = New System.Drawing.Point(163, 25)
        Me.labelTitreJeu.Name = "labelTitreJeu"
        Me.labelTitreJeu.Size = New System.Drawing.Size(107, 20)
        Me.labelTitreJeu.TabIndex = 8
        Me.labelTitreJeu.Text = "Master Mind"
        '
        'FormReponseMaitre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projet.My.Resources.Resources.resize_img_php
        Me.ClientSize = New System.Drawing.Size(454, 171)
        Me.Controls.Add(Me.labelTitreJeu)
        Me.Controls.Add(Me.labelListCarac)
        Me.Controls.Add(Me.labelCaracPoss)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormReponseMaitre"
        Me.Text = "Pattern à deviner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents labelCaracPoss As System.Windows.Forms.Label
    Friend WithEvents labelListCarac As System.Windows.Forms.Label
    Friend WithEvents labelTitreJeu As System.Windows.Forms.Label

End Class
