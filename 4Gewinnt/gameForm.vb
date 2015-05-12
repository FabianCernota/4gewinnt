Public Class gameForm
    Public game As Game = New Game

#Region "Painting_gamePanel"

  
    Private Sub gamePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gamePanel.Paint
        game.gamePanel = gamePanel
        game.lblWinner = lblWinner
        game.lblActPlayer = lblActPlayer

        game.paintField()

    End Sub
#End Region

    
    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

        Dim newGame = New newGame()
        newGame.gf = Me

        newGame.Show()

    End Sub
    Public Sub startSinglePlayerGame()
        game.init()
    End Sub
    Private Sub gamePanel_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gamePanel.MouseClick
        If game.isWinner() = False And game.isGame = True Then
            game.move(e.X)
        End If
    End Sub

    Private Sub gameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newGame = New newGame()
        newGame.gf = Me
        newGame.Show()
    End Sub
    Public Delegate Sub dlgStartGame()
    Public Sub start()
        game.gamePanel = gamePanel
        game.lblWinner = lblWinner
        game.lblActPlayer = lblActPlayer

        game.paintField()

        game.init()
    End Sub
    Public Delegate Sub dlgTrigger(ByVal message As String)
    Public Sub triggerEvent(ByVal message As String)
        If message.StartsWith("sendstone") Then

            Dim wordArr As String() = message.Split(CChar(";"))
            Dim result As String = wordArr(1)
            game.moveWithColumn(CInt(result))
            MsgBox(result)
        End If
    End Sub
End Class
