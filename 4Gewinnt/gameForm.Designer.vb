<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameForm
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
        Me.gamePanel = New System.Windows.Forms.Panel()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gamePanel
        '
        Me.gamePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gamePanel.Location = New System.Drawing.Point(2, 57)
        Me.gamePanel.Name = "gamePanel"
        Me.gamePanel.Size = New System.Drawing.Size(600, 600)
        Me.gamePanel.TabIndex = 0
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(609, 57)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(106, 23)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "Neues Spiel"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'gameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 659)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.gamePanel)
        Me.Name = "gameForm"
        Me.Text = " 4Gewinnt "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gamePanel As System.Windows.Forms.Panel
    Friend WithEvents btn_new As System.Windows.Forms.Button

End Class
