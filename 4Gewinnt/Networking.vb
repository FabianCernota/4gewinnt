Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Public Class Networking

    Public Sub startServer()
       
    End Sub
    Public Function getIpV4() As String
        Dim ipV4 As String
        Dim IPs As IPAddress
        Dim Addresslist() As IPAddress = _
          Net.Dns.GetHostEntry(Dns.GetHostName()).AddressList


        ' alle IP-Adressen auflisten

        For Each IPs In Addresslist
            If IPs.IsIPv6LinkLocal = False Then
                ipV4 = IPs.ToString
                Return ipV4
            End If
        Next IPs
        Return CStr("0.0.0.0")
    End Function
    Public Sub createServer(ByRef gf As gameForm)

        Dim server As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim clientHandler As Socket
        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim ip As IPAddress = IPAddress.Parse("0.0.0.0")
        Dim localEP As New IPEndPoint(ip, 4747)

        Dim data As String = Nothing
        server.Bind(localEP)

        server.Listen(1)
        MsgBox("auf client warten")
        clientHandler = server.Accept()
        Dim networkStream = New NetworkStream(clientHandler, True)

        If networkStream.CanRead Then
            Dim triggerGame As gameForm.dlgStartGame
            triggerGame = New gameForm.dlgStartGame(AddressOf gameForm.start)
            triggerGame.Invoke()

            Dim sr = New StreamReader(networkStream)

            Dim sw = New StreamWriter(networkStream)

            While True
                Dim message As String = sr.ReadLine
                Dim trigger As gameForm.dlgTrigger
                trigger = New gameForm.dlgTrigger(AddressOf gameForm.triggerEvent)

                'Another way of invoking the delegate.
                trigger.Invoke(message)
            End While

        Else
            Console.WriteLine("Sorry.  You cannot read from this NetworkStream.")
        End If




    End Sub



End Class
