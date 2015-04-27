'Klasse die reine Spiellogik enthält.
Public Class Game
    Dim actPlayer As Integer = 1



    Public fields(6, 6) As Integer
    Public gamePanel As Panel

    Public Sub init()
        paintField()
        actPlayer = 1

        For iColumn As Integer = 0 To 6
            For iRow As Integer = 0 To 6
                fields(iColumn, iRow) = 0
            Next
        Next

    End Sub

    Public Sub paintField()
        Dim graph As Graphics
        Dim Pen As Pen = New Pen(Color.DarkBlue)
        Dim PenWhite As Pen = New Pen(Color.White)
        Dim BrushWhite As Brush = New SolidBrush(Color.White)
        Dim ColumnsWidth As Integer = calcCellWidth()

        graph = gamePanel.CreateGraphics
        graph.Clear(Color.DarkBlue)

        Dim tempMargin As Integer = 0
        For i As Integer = 0 To 6
            graph.DrawLine(PenWhite, tempMargin + ColumnsWidth, 0, tempMargin + ColumnsWidth, gamePanel.Height)
            graph.DrawLine(PenWhite, 0, tempMargin + ColumnsWidth, gamePanel.Width, tempMargin + ColumnsWidth)


            tempMargin = tempMargin + ColumnsWidth
        Next



    End Sub
    Public Sub move(ByVal X As Integer)
        Dim StonePlace As Integer = 0
        Dim Spalte As Integer = calcColumn(X)

        Dim place As Integer = checkStone(Spalte)
        setStone(place, Spalte)
    End Sub
    Private Function calcCellWidth() As Integer
        Dim ColumnWidth As Integer = gamePanel.Width \ 6
        Return ColumnWidth
    End Function

    Private Function calcColumn(ByVal X As Integer) As Integer
        Dim cell As Integer = calcCellWidth()
        Dim aktuelleSpalte As Integer = 0
        Dim gefundeneSpalte As Integer = 1
        Dim isFound As Boolean = False
        Do While isFound = False
            If X > aktuelleSpalte And X < aktuelleSpalte + 100 Then
                isFound = True
            Else
                aktuelleSpalte = aktuelleSpalte + 100
                gefundeneSpalte += 1
            End If

        Loop
        Return gefundeneSpalte
    End Function
    Private Sub changePlayer()
        If actPlayer = 1 Then
            actPlayer = 2
        Else
            actPlayer = 1
        End If

    End Sub
    Private Function checkStone(ByVal column As Integer) As Integer
        Dim isEmpty As Boolean = False
        Dim i As Integer = 6
        While isEmpty = False
            If fields(column, i) = 0 Then
                isEmpty = True
            Else
                i -= 1
            End If
        End While
        Return i
    End Function
    Private Sub setStone(ByVal stonePlace As Integer, ByVal spalte As Integer)
        Dim StoneBrush As SolidBrush
        Dim graph As Graphics
        If actPlayer = 1 Then
            StoneBrush = New SolidBrush(Color.Yellow)
        Else
            StoneBrush = New SolidBrush(Color.Green)
        End If

        graph = gamePanel.CreateGraphics
        Dim loc As Point
        loc.X = spalte * calcCellWidth() - calcCellWidth()
        loc.Y = stonePlace * calcCellWidth() - calcCellWidth()
        Dim s As Size
        s.Width = calcCellWidth()
        s.Height = calcCellWidth()
        Dim Rect As Rectangle = New Rectangle(loc, s)
        graph.FillEllipse(StoneBrush, Rect)


        fields(spalte, stonePlace) = actPlayer
        checkWin(spalte, stonePlace)
        changePlayer()
    End Sub
    Private Sub checkWin(ByVal column As Integer, ByVal row As Integer)
        Dim zaehler As Integer = 1
        Dim isWin As Boolean = False
        Dim i As Integer = column - 1
        'CheckLeft
        If column >= 4 Then
            While i > 1 And isWin = False
                If fields(i, row) = actPlayer Then
                    zaehler += 1
                    If zaehler = 4 Then
                        isWin = True
                    End If
                End If
            End While
        End If
        MsgBox(isWin)

    End Sub
End Class
