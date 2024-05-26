<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPlayerO = New System.Windows.Forms.Label()
        Me.lblPlayerX = New System.Windows.Forms.Label()
        Me.lblJoueurO = New System.Windows.Forms.Label()
        Me.lblJoueurX = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTic9 = New System.Windows.Forms.Button()
        Me.btnTic8 = New System.Windows.Forms.Button()
        Me.btnTic7 = New System.Windows.Forms.Button()
        Me.btnTic6 = New System.Windows.Forms.Button()
        Me.btnTic5 = New System.Windows.Forms.Button()
        Me.btnTic4 = New System.Windows.Forms.Button()
        Me.btnTic3 = New System.Windows.Forms.Button()
        Me.btnTic2 = New System.Windows.Forms.Button()
        Me.btnTic1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(27, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(196, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(452, 39)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Jeu du Morpion/TicTacToe"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(27, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 396)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblPlayerO)
        Me.Panel4.Controls.Add(Me.lblPlayerX)
        Me.Panel4.Controls.Add(Me.lblJoueurO)
        Me.Panel4.Controls.Add(Me.lblJoueurX)
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Controls.Add(Me.btnNewGame)
        Me.Panel4.Controls.Add(Me.btnReset)
        Me.Panel4.Location = New System.Drawing.Point(496, 14)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 357)
        Me.Panel4.TabIndex = 2
        '
        'lblPlayerO
        '
        Me.lblPlayerO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayerO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerO.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerO.Location = New System.Drawing.Point(165, 74)
        Me.lblPlayerO.Name = "lblPlayerO"
        Me.lblPlayerO.Size = New System.Drawing.Size(126, 39)
        Me.lblPlayerO.TabIndex = 15
        Me.lblPlayerO.Text = "0"
        Me.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerX
        '
        Me.lblPlayerX.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerX.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerX.Location = New System.Drawing.Point(165, 16)
        Me.lblPlayerX.Name = "lblPlayerX"
        Me.lblPlayerX.Size = New System.Drawing.Size(126, 39)
        Me.lblPlayerX.TabIndex = 14
        Me.lblPlayerX.Text = "0"
        Me.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJoueurO
        '
        Me.lblJoueurO.AutoSize = True
        Me.lblJoueurO.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueurO.Location = New System.Drawing.Point(3, 75)
        Me.lblJoueurO.Name = "lblJoueurO"
        Me.lblJoueurO.Size = New System.Drawing.Size(167, 39)
        Me.lblJoueurO.TabIndex = 13
        Me.lblJoueurO.Text = "Joueur O"
        '
        'lblJoueurX
        '
        Me.lblJoueurX.AutoSize = True
        Me.lblJoueurX.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoueurX.Location = New System.Drawing.Point(3, 16)
        Me.lblJoueurX.Name = "lblJoueurX"
        Me.lblJoueurX.Size = New System.Drawing.Size(163, 39)
        Me.lblJoueurX.TabIndex = 12
        Me.lblJoueurX.Text = "Joueur X"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(172, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 62)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Quitter"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(13, 215)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(302, 62)
        Me.btnNewGame.TabIndex = 10
        Me.btnNewGame.Text = "Nouvelle partie"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(13, 283)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 62)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reinitialiser"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnTic9)
        Me.Panel3.Controls.Add(Me.btnTic8)
        Me.Panel3.Controls.Add(Me.btnTic7)
        Me.Panel3.Controls.Add(Me.btnTic6)
        Me.Panel3.Controls.Add(Me.btnTic5)
        Me.Panel3.Controls.Add(Me.btnTic4)
        Me.Panel3.Controls.Add(Me.btnTic3)
        Me.Panel3.Controls.Add(Me.btnTic2)
        Me.Panel3.Controls.Add(Me.btnTic1)
        Me.Panel3.Location = New System.Drawing.Point(12, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 357)
        Me.Panel3.TabIndex = 1
        '
        'btnTic9
        '
        Me.btnTic9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic9.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic9.Location = New System.Drawing.Point(309, 248)
        Me.btnTic9.Name = "btnTic9"
        Me.btnTic9.Size = New System.Drawing.Size(134, 97)
        Me.btnTic9.TabIndex = 8
        Me.btnTic9.UseVisualStyleBackColor = False
        '
        'btnTic8
        '
        Me.btnTic8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic8.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic8.Location = New System.Drawing.Point(165, 248)
        Me.btnTic8.Name = "btnTic8"
        Me.btnTic8.Size = New System.Drawing.Size(134, 97)
        Me.btnTic8.TabIndex = 7
        Me.btnTic8.UseVisualStyleBackColor = False
        '
        'btnTic7
        '
        Me.btnTic7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic7.Location = New System.Drawing.Point(25, 248)
        Me.btnTic7.Name = "btnTic7"
        Me.btnTic7.Size = New System.Drawing.Size(134, 97)
        Me.btnTic7.TabIndex = 6
        Me.btnTic7.UseVisualStyleBackColor = False
        '
        'btnTic6
        '
        Me.btnTic6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic6.Location = New System.Drawing.Point(309, 133)
        Me.btnTic6.Name = "btnTic6"
        Me.btnTic6.Size = New System.Drawing.Size(134, 97)
        Me.btnTic6.TabIndex = 5
        Me.btnTic6.UseVisualStyleBackColor = False
        '
        'btnTic5
        '
        Me.btnTic5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic5.Location = New System.Drawing.Point(165, 133)
        Me.btnTic5.Name = "btnTic5"
        Me.btnTic5.Size = New System.Drawing.Size(134, 97)
        Me.btnTic5.TabIndex = 4
        Me.btnTic5.UseVisualStyleBackColor = False
        '
        'btnTic4
        '
        Me.btnTic4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic4.Location = New System.Drawing.Point(25, 133)
        Me.btnTic4.Name = "btnTic4"
        Me.btnTic4.Size = New System.Drawing.Size(134, 97)
        Me.btnTic4.TabIndex = 3
        Me.btnTic4.UseVisualStyleBackColor = False
        '
        'btnTic3
        '
        Me.btnTic3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic3.Location = New System.Drawing.Point(309, 16)
        Me.btnTic3.Name = "btnTic3"
        Me.btnTic3.Size = New System.Drawing.Size(134, 97)
        Me.btnTic3.TabIndex = 2
        Me.btnTic3.UseVisualStyleBackColor = False
        '
        'btnTic2
        '
        Me.btnTic2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic2.Location = New System.Drawing.Point(165, 16)
        Me.btnTic2.Name = "btnTic2"
        Me.btnTic2.Size = New System.Drawing.Size(134, 97)
        Me.btnTic2.TabIndex = 1
        Me.btnTic2.UseVisualStyleBackColor = False
        '
        'btnTic1
        '
        Me.btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTic1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTic1.Location = New System.Drawing.Point(25, 16)
        Me.btnTic1.Name = "btnTic1"
        Me.btnTic1.Size = New System.Drawing.Size(134, 97)
        Me.btnTic1.TabIndex = 0
        Me.btnTic1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BackgroundImage = Global.Morpion.My.Resources.Resources.JoJo_s_Bizarre_Adventure_Background_02
        Me.ClientSize = New System.Drawing.Size(893, 578)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTic1 As Button
    Friend WithEvents btnTic9 As Button
    Friend WithEvents btnTic8 As Button
    Friend WithEvents btnTic7 As Button
    Friend WithEvents btnTic6 As Button
    Friend WithEvents btnTic5 As Button
    Friend WithEvents btnTic4 As Button
    Friend WithEvents btnTic3 As Button
    Friend WithEvents btnTic2 As Button
    Friend WithEvents lblPlayerO As Label
    Friend WithEvents lblPlayerX As Label
    Friend WithEvents lblJoueurO As Label
    Friend WithEvents lblJoueurX As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label5 As Label
End Class
