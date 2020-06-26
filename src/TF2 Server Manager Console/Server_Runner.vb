﻿Public Class Server_Runner

    Public Shared Sub Run(ByVal Server_Name As String, ByVal startup_map As String, ByVal Folder As String, ByVal Max_Players As Integer, ByVal Server_Port As Integer, ByVal SV_PURE As Integer, ByVal SV_LAN As Integer, ByVal sv_region As Integer, ByVal mp_disable_respawn_times As Integer, ByVal sv_alltalk As Integer)
        Console.WriteLine("Starting SteamCMD...")
        Console.WriteLine("Executing Command: " & "C:\Server Manager\SteamCMD\steamcmd.exe +login anonymous +force_install_dir" & Folder & " +app_update 232250 validate +quit")
        Process.Start("C:\Server Manager\SteamCMD\steamcmd.exe +login anonymous +force_install_dir" & Folder & " +app_update 232250 validate +quit")
        Console.WriteLine("Server Updated...")
        Console.WriteLine("Starting Server...")
        Console.WriteLine("Executing Command: " & Folder & "srcds.exe -console -game tf -port " & Server_Port.ToString & " +sv_pure " & SV_PURE.ToString & " +maxplayers " & Max_Players.ToString & " +hostname " & Server_Name & " +sv_lan " & SV_LAN.ToString & " +sv_region " & sv_region.ToString & " +mp_disable_respawn_times " & mp_disable_respawn_times.ToString & " +sv_alltalk " & sv_alltalk & " +map " & startup_map)
        Process.Start(Folder & "srcds.exe -console -game tf -port " & Server_Port.ToString & " +sv_pure " & SV_PURE.ToString & " +maxplayers " & Max_Players.ToString & " +hostname " & Server_Name & " +sv_lan " & SV_LAN.ToString & " +sv_region " & sv_region.ToString & " +mp_disable_respawn_times " & mp_disable_respawn_times.ToString & " +sv_alltalk " & sv_alltalk & " +map " & startup_map)
    End Sub
End Class