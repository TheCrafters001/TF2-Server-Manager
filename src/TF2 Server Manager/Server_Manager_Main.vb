Imports TF2_Server_Manger_Utility

Public Class Server_Manager_Main
    Private Sub Server_Manager_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartupMap_SelectMap.SelectedIndex = 105
        sv_pure_dropdown.SelectedIndex = 0
        sv_lan_dropdown.SelectedIndex = 1
        mp_disable_respawn_times_DropDown.SelectedIndex = 0
        sv_alltalk_dropdown.selectedindex = 1
    End Sub

    Private Sub QuestionMark_SV_Lan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles QuestionMark_SV_Lan.LinkClicked
        MessageBox.Show("sv_lan lets you put your server on the Internet, or just have a local server. By default it is set to LAN. If you set the server to Internet, you will need to setup port forwarding.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
