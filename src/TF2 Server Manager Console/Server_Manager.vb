Public Class Server_Manager

    Public Shared Sub StartServerWithSettings(ByVal Server_Name As String, ByVal startup_map As String, ByVal Folder As String, ByVal Max_Players As Integer, ByVal Server_Port As Integer, ByVal SV_PURE As Integer, ByVal SV_LAN As Integer, ByVal sv_region As Integer, ByVal mp_disable_respawn_times As Integer, ByVal sv_alltalk As Integer)
        Console.Clear()
        Console.WriteLine("========================================")
        Console.WriteLine("= Start Server With Existing Settings  =")
        Console.WriteLine("========================================")
        Console.WriteLine("Starting with the following Settings.")
        Console.WriteLine("Server Name             : " & Server_Name)
        Console.WriteLine("Startup Map             : " & startup_map)
        Console.WriteLine("Max Players             : " & Max_Players.ToString)
        Console.WriteLine("Server Port             : " & Server_Port.ToString)
        Console.WriteLine("sv_pure                 : " & SV_PURE.ToString)
        Console.WriteLine("sv_lan                  : " & SV_LAN.ToString)
        Console.WriteLine("sv_region               : " & sv_region.ToString)
        Console.WriteLine("mp_disable_respawn_times: " & mp_disable_respawn_times.ToString)
        Console.WriteLine("sv_alltalk              : " & sv_alltalk.ToString)
        Console.WriteLine("Folder Location         : " & Folder)
        Console.WriteLine("")
        Module1.Main()
    End Sub

End Class
