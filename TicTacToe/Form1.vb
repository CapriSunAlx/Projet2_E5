Public Class Form1
    Private gameButtons(8) As Button
    Private board(8) As String
    Private currentPlayer As String = "X"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGameButtons()
        ResetGame()
    End Sub

    Private Sub InitializeGameButtons()
        For i As Integer = 1 To 9
            Dim buttonName As String = "btnCase" & i.ToString()
            Dim gameButton As Button = TryCast(Me.Controls(buttonName), Button)
            If gameButton IsNot Nothing Then
                AddHandler gameButton.Click, AddressOf Me.ButtonClick
                gameButtons(i - 1) = gameButton
                gameButtons(i - 1).Tag = i - 1 ' Stocker l'index comme Tag
            Else
                MessageBox.Show($"Le bouton {buttonName} n'a pas été trouvé.")
            End If
        Next
    End Sub



    Private Sub ButtonClick(sender As Object, e As EventArgs)
        Dim buttonClicked As Button = DirectCast(sender, Button)
        Dim caseIndex As Integer = Convert.ToInt32(buttonClicked.Tag) - 1

        If board(caseIndex) Is Nothing Then
            board(caseIndex) = currentPlayer
            buttonClicked.Text = currentPlayer
            If CheckVictory(currentPlayer) Then
                MessageBox.Show("Joueur " & currentPlayer & " gagne !")
                ResetGame()
            Else
                TogglePlayer()
            End If
        End If
    End Sub


    Private Sub TogglePlayer()
        If currentPlayer = "X" Then
            currentPlayer = "O"
        Else
            currentPlayer = "X"
        End If
    End Sub

    Private Sub ResetGame()
        For i As Integer = 0 To 8
            board(i) = Nothing
            gameButtons(i).Text = ""
        Next
        currentPlayer = "X"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetGame()
    End Sub
    Private Function CheckVictory(player As String) As Boolean
        ' Vérifier les lignes
        For i As Integer = 0 To 6 Step 3
            If board(i) = player AndAlso board(i + 1) = player AndAlso board(i + 2) = player Then
                Return True
            End If
        Next

        ' Vérifier les colonnes
        For i As Integer = 0 To 2
            If board(i) = player AndAlso board(i + 3) = player AndAlso board(i + 6) = player Then
                Return True
            End If
        Next

        ' Vérifier les diagonales
        If board(0) = player AndAlso board(4) = player AndAlso board(8) = player Then
            Return True
        End If
        If board(2) = player AndAlso board(4) = player AndAlso board(6) = player Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnCase2_Click(sender As Object, e As EventArgs) Handles btnCase2.Click

    End Sub
End Class
