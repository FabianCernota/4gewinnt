﻿Public Class gameForm
    Dim game As Game = New Game

#Region "Painting_gamePanel"

  
    Private Sub gamePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gamePanel.Paint
        game.gamePanel = gamePanel

        game.paintField()

    End Sub
#End Region

    
    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        game.init()
    End Sub
    Private Sub gamePanel_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gamePanel.MouseClick
        game.move(e.X)
    End Sub
End Class