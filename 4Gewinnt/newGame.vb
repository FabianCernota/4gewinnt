﻿Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Threading

Public Class newGame
    Dim thr As Thread
    Private Sub btnNewGameFormNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGameFormNewGame.Click
        gameForm.startSinglePlayerGame()
        Me.Hide()
    End Sub

    Private Sub btnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartServer.Click
        Dim net = New Networking
        lblIP.Text = net.getIpV4
        thr = New Thread(AddressOf net.createServer)
        thr.IsBackground = True
        thr.Start()
    End Sub
End Class