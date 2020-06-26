Module Module1
    ' Define Settings
    Dim Server_Name As String
    Dim Startup_Map As String
    Dim Max_Players As Integer
    Dim Server_Port As Integer
    Dim SV_PURE As Integer
    Dim SV_LAN As Integer
    Dim sv_region As Integer
    Dim mp_disable_respawn_times As Integer
    Dim sv_alltalk As Integer
    Dim folder As String

    Sub Main()
        Menu()
    End Sub

    Sub Menu()
        Console.WriteLine("==============================")
        Console.WriteLine("= TF2 Server Manager Console =")
        Console.WriteLine("= By TheCrafters001          =")
        Console.WriteLine("==============================")
        Console.WriteLine("")
        Console.WriteLine("Select an option")
        Console.WriteLine("1. Start Server With Saved Settings")
        Console.WriteLine("2. Start Server With New Settings  ")
        Console.WriteLine("3. Select Settings to Save         ")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.Write("Select a Number: ")
        Try
            Dim MenuSelect As Integer = Console.ReadLine()
            If MenuSelect = 1 Then
                Server_Name = My.Settings.Server_Name
                Startup_Map = My.Settings.Startup_Map
                folder = My.Settings.folder
                Max_Players = My.Settings.Max_Players
                Server_Port = My.Settings.Server_Port
                SV_PURE = My.Settings.SV_PURE
                SV_LAN = My.Settings.SV_LAN
                sv_region = My.Settings.sv_region
                mp_disable_respawn_times = My.Settings.mp_disable_respawn_times
                sv_alltalk = My.Settings.sv_alltalk
                Server_Manager.StartServerWithSettings(Server_Name, Startup_Map, folder, Max_Players, Server_Port, SV_PURE, SV_LAN, sv_region, mp_disable_respawn_times, sv_alltalk)
            ElseIf MenuSelect = 2 Then

            ElseIf MenuSelect = 3 Then

            End If
        Catch ex As Exception
            Console.Clear()
            Console.WriteLine("The following error happened.")
            Console.WriteLine("")
            Console.WriteLine(ex)
            Console.WriteLine("")
            Main()
        End Try
    End Sub

End Module
