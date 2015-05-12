<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newGame
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Singleplayer = New System.Windows.Forms.TabPage()
        Me.btnNewGameFormNewGame = New System.Windows.Forms.Button()
        Me.Multiplayer = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnConnectMultiplayer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Singleplayer.SuspendLayout()
        Me.Multiplayer.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Singleplayer)
        Me.TabControl1.Controls.Add(Me.Multiplayer)
        Me.TabControl1.Location = New System.Drawing.Point(-5, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(626, 171)
        Me.TabControl1.TabIndex = 0
        '
        'Singleplayer
        '
        Me.Singleplayer.Controls.Add(Me.btnNewGameFormNewGame)
        Me.Singleplayer.Location = New System.Drawing.Point(4, 22)
        Me.Singleplayer.Name = "Singleplayer"
        Me.Singleplayer.Padding = New System.Windows.Forms.Padding(3)
        Me.Singleplayer.Size = New System.Drawing.Size(618, 145)
        Me.Singleplayer.TabIndex = 0
        Me.Singleplayer.Text = "Singleplayer"
        Me.Singleplayer.UseVisualStyleBackColor = True
        '
        'btnNewGameFormNewGame
        '
        Me.btnNewGameFormNewGame.Location = New System.Drawing.Point(221, 52)
        Me.btnNewGameFormNewGame.Name = "btnNewGameFormNewGame"
        Me.btnNewGameFormNewGame.Size = New System.Drawing.Size(144, 49)
        Me.btnNewGameFormNewGame.TabIndex = 0
        Me.btnNewGameFormNewGame.Text = "Neues Spiel"
        Me.btnNewGameFormNewGame.UseVisualStyleBackColor = True
        '
        'Multiplayer
        '
        Me.Multiplayer.Controls.Add(Me.SplitContainer1)
        Me.Multiplayer.Location = New System.Drawing.Point(4, 22)
        Me.Multiplayer.Name = "Multiplayer"
        Me.Multiplayer.Padding = New System.Windows.Forms.Padding(3)
        Me.Multiplayer.Size = New System.Drawing.Size(618, 145)
        Me.Multiplayer.TabIndex = 1
        Me.Multiplayer.Text = "Multiplayer"
        Me.Multiplayer.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnConnectMultiplayer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblIP)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStartServer)
        Me.SplitContainer1.Size = New System.Drawing.Size(612, 139)
        Me.SplitContainer1.SplitterDistance = 301
        Me.SplitContainer1.TabIndex = 0
        '
        'btnConnectMultiplayer
        '
        Me.btnConnectMultiplayer.Location = New System.Drawing.Point(11, 73)
        Me.btnConnectMultiplayer.Name = "btnConnectMultiplayer"
        Me.btnConnectMultiplayer.Size = New System.Drawing.Size(276, 23)
        Me.btnConnectMultiplayer.TabIndex = 2
        Me.btnConnectMultiplayer.Text = "Verbinden"
        Me.btnConnectMultiplayer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 0
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(4, 49)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(0, 13)
        Me.lblIP.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP:"
        '
        'btnStartServer
        '
        Me.btnStartServer.Location = New System.Drawing.Point(3, 73)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(301, 23)
        Me.btnStartServer.TabIndex = 0
        Me.btnStartServer.Text = "Server starten"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'newGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 171)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "newGame"
        Me.Text = "newGame"
        Me.TabControl1.ResumeLayout(False)
        Me.Singleplayer.ResumeLayout(False)
        Me.Multiplayer.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Singleplayer As System.Windows.Forms.TabPage
    Friend WithEvents btnNewGameFormNewGame As System.Windows.Forms.Button
    Friend WithEvents Multiplayer As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnConnectMultiplayer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStartServer As System.Windows.Forms.Button
End Class
