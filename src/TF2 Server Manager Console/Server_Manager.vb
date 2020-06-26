Imports DownloadFile.Downloader

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
        Console.WriteLine("")
        If My.Computer.FileSystem.FileExists("C:\Server Manager\SteamCMD\SteamCMD.exe") Then
            Try
                Server_Runner.Run(Server_Name, startup_map, Folder, Max_Players, Server_Port, SV_PURE, SV_LAN, sv_region, mp_disable_respawn_times, sv_alltalk)
            Catch ex As Exception
                Console.WriteLine("Failed.")
                Console.WriteLine("")
                Console.WriteLine(ex)
                Module1.Menu()
            End Try
        Else
            Console.WriteLine("SteamCMD was not found on your system. Would you like to download it? (Internet required)")
            Console.WriteLine("")
            Console.Write("Enter a selection [Y/n] = ")
            Dim SteamCMDDownloader As String = Console.ReadLine()
            SteamCMDDownloader = SteamCMDDownloader.ToLower
            If SteamCMDDownloader = "y" Then
                Console.WriteLine("Okay. Downloading SteamCMD...")
                Try
                    SteamCMD_DL("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("Downloaded. Unzipping SteamCMD...")
                Try
                    Unzip("steamcmd")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("SteamCMD installed! Erasing zip file...")
                Try
                    My.Computer.FileSystem.DeleteFile("C:\Server Manager\SteamCMD\steamcmd.zip")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("Done.")
                Try
                    Server_Runner.Run(Server_Name, startup_map, Folder, Max_Players, Server_Port, SV_PURE, SV_LAN, sv_region, mp_disable_respawn_times, sv_alltalk)
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
            ElseIf SteamCMDDownloader = "n" Then
                Console.WriteLine("Okay, Not downloading SteamCMD. Operation will now cancel.")
            End If
        End If
        Module1.Menu()
    End Sub

    Public Shared Sub StartServerWithNewSettings()
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
        Console.WriteLine("========================================")
        Console.WriteLine("= Start Server With New Settings       =")
        Console.WriteLine("========================================")
        Console.WriteLine("Starting with the following Settings.")
        Console.WriteLine("")
        Console.Write("Server Name             : ")
        Server_Name = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Startup Map             : ")
        Startup_Map = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Max Players             : ")
        Max_Players = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Server Port             : ")
        Server_Port = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_pure                 : ")
        SV_PURE = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_lan                  : ")
        SV_LAN = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_region               : ")
        sv_region = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("mp_disable_respawn_times: ")
        mp_disable_respawn_times = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_alltalk              : ")
        sv_alltalk = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Folder Location         : ")
        folder = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Saving Settings...")
        My.Settings.Save()
        Console.WriteLine("Settings Saved")
        If My.Computer.FileSystem.FileExists("C:\Server Manager\SteamCMD\SteamCMD.exe") Then
            Try
                Server_Runner.Run(Server_Name, Startup_Map, folder, Max_Players, Server_Port, SV_PURE, SV_LAN, sv_region, mp_disable_respawn_times, sv_alltalk)
            Catch ex As Exception
                Console.WriteLine("Failed.")
                Console.WriteLine("")
                Console.WriteLine(ex)
                Module1.Menu()
            End Try
        Else
            Console.WriteLine("SteamCMD was not found on your system. Would you like to download it? (Internet required)")
            Console.WriteLine("")
            Console.Write("Enter a selection [Y/n] = ")
            Dim SteamCMDDownloader As String = Console.ReadLine()
            SteamCMDDownloader = SteamCMDDownloader.ToLower
            If SteamCMDDownloader = "y" Then
                Console.WriteLine("Okay. Downloading SteamCMD...")
                Try
                    SteamCMD_DL("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("Downloaded. Unzipping SteamCMD...")
                Try
                    Unzip("steamcmd")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("SteamCMD installed! Erasing zip file...")
                Try
                    My.Computer.FileSystem.DeleteFile("C:\Server Manager\SteamCMD\steamcmd.zip")
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
                Console.WriteLine("Done.")
                Try
                    Server_Runner.Run(Server_Name, Startup_Map, folder, Max_Players, Server_Port, SV_PURE, SV_LAN, sv_region, mp_disable_respawn_times, sv_alltalk)
                Catch ex As Exception
                    Console.WriteLine("Failed.")
                    Console.WriteLine("")
                    Console.WriteLine(ex)
                    Module1.Menu()
                End Try
            ElseIf SteamCMDDownloader = "n" Then
                Console.WriteLine("Okay, Not downloading SteamCMD. Operation will now cancel.")
            End If
        End If
        Module1.Menu()
    End Sub

    Public Shared Sub SettingsNoStart()
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
        Console.WriteLine("========================================")
        Console.WriteLine("= Start Server With New Settings       =")
        Console.WriteLine("========================================")
        Console.WriteLine("Starting with the following Settings.")
        Console.WriteLine("")
        Console.Write("Server Name             : ")
        Server_Name = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Startup Map             : ")
        Startup_Map = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Max Players             : ")
        Max_Players = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Server Port             : ")
        Server_Port = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_pure                 : ")
        SV_PURE = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_lan                  : ")
        SV_LAN = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_region               : ")
        sv_region = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("mp_disable_respawn_times: ")
        mp_disable_respawn_times = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("sv_alltalk              : ")
        sv_alltalk = Console.ReadLine()
        Console.WriteLine("")
        Console.Write("Folder Location         : ")
        folder = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Saving Settings...")
        My.Settings.Save()
        Console.WriteLine("Settings Saved")
        Module1.Menu()
    End Sub

End Class
