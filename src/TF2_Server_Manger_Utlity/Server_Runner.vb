Public Class Server_Runner

    Public Shared Sub Run(ByVal Server_Name As String, ByVal startup_map As String, ByVal Folder As String, ByVal Max_Players As Integer, ByVal Server_Port As Integer, ByVal SV_PURE As Integer, ByVal SV_LAN As Integer, ByVal sv_region As Integer, ByVal mp_disable_respawn_times As Integer, ByVal sv_alltalk As Integer)
        Console.WriteLine("Starting SteamCMD...")
        Console.WriteLine("Executing Command: " & "C:\Server Manager\SteamCMD\steamcmd.exe +login anonymous +force_install_dir" & Folder & " +app_update 232250 validate +quit")
        Debug.WriteLine("Starting SteamCMD...")
        Debug.WriteLine("Executing Command: " & "C:\Server Manager\SteamCMD\steamcmd.exe +login anonymous +force_install_dir" & Folder & " +app_update 232250 validate +quit")
        Dim SteamCMD As New ProcessStartInfo
        SteamCMD.FileName = "C:\Server Manager\SteamCMD\steamcmd.exe"
        SteamCMD.Arguments = "+login anonymous +force_install_dir " & Folder & " +app_update 232250 validate +quit"
        SteamCMD.UseShellExecute = True
        SteamCMD.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(SteamCMD)
        proc.WaitForExit()
        Console.WriteLine("Server Updated...")
        Console.WriteLine("Starting Server...")
        Console.WriteLine("Executing Command: " & Folder & "srcds.exe -console -game tf -port " & Server_Port.ToString & " +sv_pure " & SV_PURE.ToString & " +maxplayers " & Max_Players.ToString & " +hostname " & Server_Name & " +sv_lan " & SV_LAN.ToString & " +sv_region " & sv_region.ToString & " +mp_disable_respawn_times " & mp_disable_respawn_times.ToString & " +sv_alltalk " & sv_alltalk & " +map " & startup_map)
        Debug.WriteLine("Server Updated...")
        Debug.WriteLine("Starting Server...")
        Debug.WriteLine("Executing Command: " & Folder & "srcds.exe -console -game tf -port " & Server_Port.ToString & " +sv_pure " & SV_PURE.ToString & " +maxplayers " & Max_Players.ToString & " +hostname " & Server_Name & " +sv_lan " & SV_LAN.ToString & " +sv_region " & sv_region.ToString & " +mp_disable_respawn_times " & mp_disable_respawn_times.ToString & " +sv_alltalk " & sv_alltalk & " +map " & startup_map)
        Dim srcds As New ProcessStartInfo
        srcds.FileName = Folder & "srcds.exe"
        srcds.Arguments = "-console -game tf -port " & Server_Port.ToString & " +sv_pure " & SV_PURE.ToString & " +maxplayers " & Max_Players.ToString & " +hostname " & Server_Name & " +sv_lan " & SV_LAN.ToString & " +sv_region " & sv_region.ToString & " +mp_disable_respawn_times " & mp_disable_respawn_times.ToString & " +sv_alltalk " & sv_alltalk & " +map " & startup_map
        srcds.UseShellExecute = True
        srcds.WindowStyle = ProcessWindowStyle.Normal
        Dim proc2 As Process = Process.Start(srcds)
        proc2.WaitForExit()
    End Sub
End Class
