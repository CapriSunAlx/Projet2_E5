Public Class Form1

    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub Enable_False()
        btnTic1.Enabled = False
        btnTic2.Enabled = False
        btnTic3.Enabled = False
        btnTic4.Enabled = False
        btnTic5.Enabled = False
        btnTic6.Enabled = False
        btnTic7.Enabled = False
        btnTic8.Enabled = False
        btnTic9.Enabled = False

    End Sub

    Private Sub Score()
        If (btnTic1.Text = "X" And btnTic2.Text = "X" And btnTic3.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.PowderBlue
            btnTic2.BackColor = System.Drawing.Color.PowderBlue
            btnTic3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic1.Text = "X" And btnTic4.Text = "X" And btnTic7.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Pink
            btnTic4.BackColor = System.Drawing.Color.Pink
            btnTic7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic1.Text = "X" And btnTic5.Text = "X" And btnTic9.Text = "X") Then
            btnTic1.BackColor = System.Drawing.Color.Crimson
            btnTic5.BackColor = System.Drawing.Color.Crimson
            btnTic9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic3.Text = "X" And btnTic5.Text = "X" And btnTic7.Text = "X") Then
            btnTic3.BackColor = System.Drawing.Color.CadetBlue
            btnTic5.BackColor = System.Drawing.Color.CadetBlue
            btnTic7.BackColor = System.Drawing.Color.CadetBlue
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic2.Text = "X" And btnTic5.Text = "X" And btnTic8.Text = "X") Then
            btnTic2.BackColor = System.Drawing.Color.SlateBlue
            btnTic5.BackColor = System.Drawing.Color.SlateBlue
            btnTic8.BackColor = System.Drawing.Color.SlateBlue
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic3.Text = "X" And btnTic6.Text = "X" And btnTic9.Text = "X") Then
            btnTic3.BackColor = System.Drawing.Color.Violet
            btnTic6.BackColor = System.Drawing.Color.Violet
            btnTic9.BackColor = System.Drawing.Color.Violet
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic4.Text = "X" And btnTic5.Text = "X" And btnTic6.Text = "X") Then
            btnTic4.BackColor = System.Drawing.Color.DarkSlateBlue
            btnTic5.BackColor = System.Drawing.Color.DarkSlateBlue
            btnTic6.BackColor = System.Drawing.Color.DarkSlateBlue
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic7.Text = "X" And btnTic8.Text = "X" And btnTic9.Text = "X") Then
            btnTic7.BackColor = System.Drawing.Color.Azure
            btnTic8.BackColor = System.Drawing.Color.Azure
            btnTic9.BackColor = System.Drawing.Color.Azure
            MessageBox.Show("Le vainqueur est le Joueur X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        '=========================

        If (btnTic1.Text = "O" And btnTic2.Text = "O" And btnTic3.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.AliceBlue
            btnTic2.BackColor = System.Drawing.Color.AliceBlue
            btnTic3.BackColor = System.Drawing.Color.AliceBlue
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic1.Text = "O" And btnTic4.Text = "O" And btnTic7.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.LemonChiffon
            btnTic4.BackColor = System.Drawing.Color.LemonChiffon
            btnTic7.BackColor = System.Drawing.Color.LemonChiffon
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic1.Text = "O" And btnTic5.Text = "O" And btnTic9.Text = "O") Then
            btnTic1.BackColor = System.Drawing.Color.BlueViolet
            btnTic5.BackColor = System.Drawing.Color.BlueViolet
            btnTic9.BackColor = System.Drawing.Color.BlueViolet
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic3.Text = "O" And btnTic5.Text = "O" And btnTic7.Text = "O") Then
            btnTic3.BackColor = System.Drawing.Color.NavajoWhite
            btnTic5.BackColor = System.Drawing.Color.NavajoWhite
            btnTic7.BackColor = System.Drawing.Color.NavajoWhite
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic2.Text = "O" And btnTic5.Text = "O" And btnTic8.Text = "O") Then
            btnTic2.BackColor = System.Drawing.Color.SandyBrown
            btnTic5.BackColor = System.Drawing.Color.SandyBrown
            btnTic8.BackColor = System.Drawing.Color.SandyBrown
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic3.Text = "O" And btnTic6.Text = "O" And btnTic9.Text = "O") Then
            btnTic3.BackColor = System.Drawing.Color.SeaGreen
            btnTic6.BackColor = System.Drawing.Color.SeaGreen
            btnTic9.BackColor = System.Drawing.Color.SeaGreen
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic4.Text = "O" And btnTic5.Text = "O" And btnTic6.Text = "O") Then
            btnTic4.BackColor = System.Drawing.Color.Azure
            btnTic5.BackColor = System.Drawing.Color.Azure
            btnTic6.BackColor = System.Drawing.Color.Azure
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTic7.Text = "O" And btnTic8.Text = "O" And btnTic9.Text = "O") Then
            btnTic7.BackColor = System.Drawing.Color.DarkBlue
            btnTic8.BackColor = System.Drawing.Color.DarkBlue
            btnTic9.BackColor = System.Drawing.Color.DarkBlue
            MessageBox.Show("Le vainqueur est le Joueur O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTic1_Click(sender As Object, e As EventArgs) Handles btnTic1.Click
        If (checker = False) Then
            btnTic1.Text = "X"
            checker = True
        Else
            btnTic1.Text = "O"
            checker = False
        End If
        Score()
        btnTic1.Enabled = False
    End Sub

    Private Sub BtnTic2_Click(sender As Object, e As EventArgs) Handles btnTic2.Click
        If (checker = False) Then
            btnTic2.Text = "X"
            checker = True
        Else
            btnTic2.Text = "O"
            checker = False
        End If
        Score()
        btnTic2.Enabled = False
    End Sub

    Private Sub BtnTic3_Click(sender As Object, e As EventArgs) Handles btnTic3.Click
        If (checker = False) Then
            btnTic3.Text = "X"
            checker = True
        Else
            btnTic3.Text = "O"
            checker = False
        End If
        Score()
        btnTic3.Enabled = False
    End Sub

    Private Sub BtnTic4_Click(sender As Object, e As EventArgs) Handles btnTic4.Click
        If (checker = False) Then
            btnTic4.Text = "X"
            checker = True
        Else
            btnTic4.Text = "O"
            checker = False
        End If
        Score()
        btnTic4.Enabled = False
    End Sub

    Private Sub BtnTic5_Click(sender As Object, e As EventArgs) Handles btnTic5.Click
        If (checker = False) Then
            btnTic5.Text = "X"
            checker = True
        Else
            btnTic5.Text = "O"
            checker = False
        End If
        Score()
        btnTic5.Enabled = False
    End Sub

    Private Sub BtnTic6_Click(sender As Object, e As EventArgs) Handles btnTic6.Click
        If (checker = False) Then
            btnTic6.Text = "X"
            checker = True
        Else
            btnTic6.Text = "O"
            checker = False
        End If
        Score()
        btnTic6.Enabled = False
    End Sub

    Private Sub BtnTic7_Click(sender As Object, e As EventArgs) Handles btnTic7.Click
        If (checker = False) Then
            btnTic7.Text = "X"
            checker = True
        Else
            btnTic7.Text = "O"
            checker = False
        End If
        Score()
        btnTic7.Enabled = False
    End Sub

    Private Sub BtnTic8_Click(sender As Object, e As EventArgs) Handles btnTic8.Click
        If (checker = False) Then
            btnTic8.Text = "X"
            checker = True
        Else
            btnTic8.Text = "O"
            checker = False
        End If
        Score()
        btnTic8.Enabled = False
    End Sub

    Private Sub BtnTic9_Click(sender As Object, e As EventArgs) Handles btnTic9.Click
        If (checker = False) Then
            btnTic9.Text = "X"
            checker = True
        Else
            btnTic9.Text = "O"
            checker = False
        End If
        Score()
        btnTic9.Enabled = False
    End Sub

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btnTic1.Enabled = True
        btnTic2.Enabled = True
        btnTic3.Enabled = True
        btnTic4.Enabled = True
        btnTic5.Enabled = True
        btnTic6.Enabled = True
        btnTic7.Enabled = True
        btnTic8.Enabled = True
        btnTic9.Enabled = True

        btnTic1.Text = ""
        btnTic2.Text = ""
        btnTic3.Text = ""
        btnTic4.Text = ""
        btnTic5.Text = ""
        btnTic6.Text = ""
        btnTic7.Text = ""
        btnTic8.Text = ""
        btnTic9.Text = ""

        lblPlayerX.Text = "0"
        lblPlayerO.Text = "0"

        btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        btnTic2.BackColor = Color.WhiteSmoke
        btnTic3.BackColor = Color.WhiteSmoke
        btnTic4.BackColor = Color.WhiteSmoke
        btnTic5.BackColor = Color.WhiteSmoke
        btnTic6.BackColor = Color.WhiteSmoke
        btnTic7.BackColor = Color.WhiteSmoke
        btnTic8.BackColor = Color.WhiteSmoke
        btnTic9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnTic1.Enabled = True
        btnTic2.Enabled = True
        btnTic3.Enabled = True
        btnTic4.Enabled = True
        btnTic5.Enabled = True
        btnTic6.Enabled = True
        btnTic7.Enabled = True
        btnTic8.Enabled = True
        btnTic9.Enabled = True

        btnTic1.Text = ""
        btnTic2.Text = ""
        btnTic3.Text = ""
        btnTic4.Text = ""
        btnTic5.Text = ""
        btnTic6.Text = ""
        btnTic7.Text = ""
        btnTic8.Text = ""
        btnTic9.Text = ""

        btnNewGame.Enabled = True

        btnTic1.BackColor = System.Drawing.Color.WhiteSmoke
        btnTic2.BackColor = Color.WhiteSmoke
        btnTic3.BackColor = Color.WhiteSmoke
        btnTic4.BackColor = Color.WhiteSmoke
        btnTic5.BackColor = Color.WhiteSmoke
        btnTic6.BackColor = Color.WhiteSmoke
        btnTic7.BackColor = Color.WhiteSmoke
        btnTic8.BackColor = Color.WhiteSmoke
        btnTic9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Voulez vous vraiment quittez ?", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
