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
        Console.WriteLine("==============================")
        Console.WriteLine("= TF2 Server Manager Console =")
        Console.WriteLine("= By TheCrafters001          =")
        Console.WriteLine("==============================")
        Menu()
    End Sub

    Sub Menu()
        Console.WriteLine("")
        Console.WriteLine("Select an option")
        Console.WriteLine("1. Start Server With Saved Settings")
        Console.WriteLine("2. Start Server With New Settings  ")
        Console.WriteLine("3. Select Settings to Save         ")
        Console.WriteLine("4. About                           ")
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
                Server_Manager.StartServerWithNewSettings()
            ElseIf MenuSelect = 3 Then
                Server_Manager.SettingsNoStart()
            ElseIf MenuSelect = 4 Then
                About()
                Console.WriteLine("")
                Menu()
            End If
        Catch ex As Exception
            Console.Clear()
            Console.WriteLine("The following error happened.")
            Console.WriteLine("")
            Console.WriteLine(ex)
            Console.WriteLine("")
            Menu()
        End Try
    End Sub

    Private Sub About()
        Console.WriteLine("A Simple TF2 Server Manager.")
        Console.WriteLine("Copyright (C) 2020 TheCrafters001")
        Console.WriteLine("")
        Console.WriteLine("This program is free software: you can redistribute it and/or modify")
        Console.WriteLine("it under the terms of the GNU General Public License as published by")
        Console.WriteLine("the Free Software Foundation, either version 3 of the License, or")
        Console.WriteLine("(at your option) any later version.")
        Console.WriteLine("")
        Console.WriteLine("This program is distributed in the hope that it will be useful,")
        Console.WriteLine("but WITHOUT ANY WARRANTY; without even the implied warranty of")
        Console.WriteLine("MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the")
        Console.WriteLine("GNU General Public License for more details.")
        Console.WriteLine("")
        Console.WriteLine("You should have received a copy of the GNU General Public License")
        Console.WriteLine("along with this program.  If not, see <https://www.gnu.org/licenses/>.")
        Console.WriteLine("")
        '
        ' Display full license. DO NOT REMOVE
        '
    End Sub

End Module
