<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server_Manager_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ServerDetails = New System.Windows.Forms.TabPage()
        Me.MaxPlayers_TxTBox = New System.Windows.Forms.TextBox()
        Me.MaxPlayersLBL = New System.Windows.Forms.Label()
        Me.StartupMap_SelectMap = New System.Windows.Forms.ComboBox()
        Me.StartupMap_lbl = New System.Windows.Forms.Label()
        Me.ServerName_TXT_Box = New System.Windows.Forms.TextBox()
        Me.ServerName_lbl = New System.Windows.Forms.Label()
        Me.ServerConfig = New System.Windows.Forms.TabPage()
        Me.sv_lan_dropdown = New System.Windows.Forms.ComboBox()
        Me.sv_lan_lbl = New System.Windows.Forms.Label()
        Me.sv_pure_dropdown = New System.Windows.Forms.ComboBox()
        Me.sv_pure_lbl = New System.Windows.Forms.Label()
        Me.Srv_Port_TxTBox = New System.Windows.Forms.TextBox()
        Me.Srv_Port_LbL = New System.Windows.Forms.Label()
        Me.SettingsPage = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mp_disable_respawn_times_DropDown = New System.Windows.Forms.ComboBox()
        Me.mp_disable_respawn_times_LBL = New System.Windows.Forms.Label()
        Me.QuestionMark_SV_Lan = New System.Windows.Forms.LinkLabel()
        Me.Export_Settings_Dialog = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.ServerDetails.SuspendLayout()
        Me.ServerConfig.SuspendLayout()
        Me.SettingsPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ServerDetails)
        Me.TabControl1.Controls.Add(Me.ServerConfig)
        Me.TabControl1.Controls.Add(Me.SettingsPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(584, 461)
        Me.TabControl1.TabIndex = 0
        '
        'ServerDetails
        '
        Me.ServerDetails.Controls.Add(Me.Label1)
        Me.ServerDetails.Controls.Add(Me.TextBox1)
        Me.ServerDetails.Controls.Add(Me.MaxPlayers_TxTBox)
        Me.ServerDetails.Controls.Add(Me.MaxPlayersLBL)
        Me.ServerDetails.Controls.Add(Me.StartupMap_SelectMap)
        Me.ServerDetails.Controls.Add(Me.StartupMap_lbl)
        Me.ServerDetails.Controls.Add(Me.ServerName_TXT_Box)
        Me.ServerDetails.Controls.Add(Me.ServerName_lbl)
        Me.ServerDetails.Location = New System.Drawing.Point(4, 24)
        Me.ServerDetails.Name = "ServerDetails"
        Me.ServerDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.ServerDetails.Size = New System.Drawing.Size(576, 433)
        Me.ServerDetails.TabIndex = 0
        Me.ServerDetails.Text = "Server Details"
        Me.ServerDetails.UseVisualStyleBackColor = True
        '
        'MaxPlayers_TxTBox
        '
        Me.MaxPlayers_TxTBox.Location = New System.Drawing.Point(6, 119)
        Me.MaxPlayers_TxTBox.MaxLength = 2
        Me.MaxPlayers_TxTBox.Name = "MaxPlayers_TxTBox"
        Me.MaxPlayers_TxTBox.Size = New System.Drawing.Size(268, 21)
        Me.MaxPlayers_TxTBox.TabIndex = 5
        Me.MaxPlayers_TxTBox.Text = "24"
        '
        'MaxPlayersLBL
        '
        Me.MaxPlayersLBL.AutoSize = True
        Me.MaxPlayersLBL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxPlayersLBL.Location = New System.Drawing.Point(6, 97)
        Me.MaxPlayersLBL.Name = "MaxPlayersLBL"
        Me.MaxPlayersLBL.Size = New System.Drawing.Size(101, 19)
        Me.MaxPlayersLBL.TabIndex = 4
        Me.MaxPlayersLBL.Text = "Max Players"
        '
        'StartupMap_SelectMap
        '
        Me.StartupMap_SelectMap.AutoCompleteCustomSource.AddRange(New String() {"arena_badlands", "arena_byre", "arena_granary", "arena_lumberyard", "arena_nucleus", "arena_offblast_final", "arena_ravine", "arena_sawmill", "arena_watchtower", "arena_well", "background01", "cp_5gorge", "cp_badlands", "cp_cloak", "cp_coldfront", "cp_degrootkeep", "cp_dustbowl", "cp_egypt_final", "cp_fastlane", "cp_foundry", "cp_freight_final1", "cp_gorge", "cp_gorge_event", "cp_granary", "cp_gravelpit", "cp_gullywash", "cp_gullywash_final1", "cp_junction_final", "cp_manor_event", "cp_mercenarypark", "cp_metalworks", "cp_mossrock", "cp_mountainlab", "cp_powerhouse", "cp_process_final", "cp_snakewater_final1", "cp_snowplow", "cp_standin_final", "cp_steel", "cp_sunshine", "cp_sunshine_event", "cp_vanguard", "cp_well", "cp_yukon_final", "ctf_2fort", "ctf_2fort_invasion", "ctf_doublecross", "ctf_foundry", "ctf_gorge", "ctf_hellfire", "ctf_landfall", "ctf_sawmill", "ctf_thundermountain", "ctf_turbine", "ctf_well", "itemtest", "koth_badlands", "koth_bagel_event", "koth_brazil", "koth_harvest_event", "koth_harvest_final", "koth_highpass", "koth_king", "koth_lakeside_event", "koth_lakeside_final", "koth_lazarus", "koth_maple_ridge_event", "koth_moonshine_event", "koth_nucleus", "koth_probed", "koth_sawmill", "koth_slasher", "koth_slaughter_event", "koth_suijin", "koth_viaduct", "koth_viaduct_event", "mvm_bigrock", "mvm_coaltown", "mvm_decoy", "mvm_ghost_town", "mvm_mannhattan", "mvm_mannworks", "mvm_rottenburg", "pass_brickyard", "pass_district", "pass_timbertown", "pd_cursed_cove_event", "pd_monster_bash", "pd_pit_of_death_event", "pd_watergate", "pl_badwater", "pl_barnblitz", "pl_borneo", "pl_cactuscanyon", "pl_enclosure_final", "pl_fifthcurve_event", "pl_frontier_final", "pl_goldrush", "pl_hoodoo_final", "pl_millstone_event", "pl_precipice_event_final", "pl_rumble_event", "pl_snowycoast", "pl_swiftwater_final1", "pl_thundermountain", "pl_upward", "plr_bananabay", "plr_hightower", "plr_hightower_event", "plr_nightfall_final", "plr_pipeline", "rd_asteroid", "sd_doomsday", "sd_doomsday_event", "tc_hydro", "tr_dustbowl", "tr_target"})
        Me.StartupMap_SelectMap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StartupMap_SelectMap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StartupMap_SelectMap.FormattingEnabled = True
        Me.StartupMap_SelectMap.Items.AddRange(New Object() {"arena_badlands", "arena_byre", "arena_granary", "arena_lumberyard", "arena_nucleus", "arena_offblast_final", "arena_ravine", "arena_sawmill", "arena_watchtower", "arena_well", "background01", "cp_5gorge", "cp_badlands", "cp_cloak", "cp_coldfront", "cp_degrootkeep", "cp_dustbowl", "cp_egypt_final", "cp_fastlane", "cp_foundry", "cp_freight_final1", "cp_gorge", "cp_gorge_event", "cp_granary", "cp_gravelpit", "cp_gullywash", "cp_gullywash_final1", "cp_junction_final", "cp_manor_event", "cp_mercenarypark", "cp_metalworks", "cp_mossrock", "cp_mountainlab", "cp_powerhouse", "cp_process_final", "cp_snakewater_final1", "cp_snowplow", "cp_standin_final", "cp_steel", "cp_sunshine", "cp_sunshine_event", "cp_vanguard", "cp_well", "cp_yukon_final", "ctf_2fort", "ctf_2fort_invasion", "ctf_doublecross", "ctf_foundry", "ctf_gorge", "ctf_hellfire", "ctf_landfall", "ctf_sawmill", "ctf_thundermountain", "ctf_turbine", "ctf_well", "itemtest", "koth_badlands", "koth_bagel_event", "koth_brazil", "koth_harvest_event", "koth_harvest_final", "koth_highpass", "koth_king", "koth_lakeside_event", "koth_lakeside_final", "koth_lazarus", "koth_maple_ridge_event", "koth_moonshine_event", "koth_nucleus", "koth_probed", "koth_sawmill", "koth_slasher", "koth_slaughter_event", "koth_suijin", "koth_viaduct", "koth_viaduct_event", "mvm_bigrock", "mvm_coaltown", "mvm_decoy", "mvm_ghost_town", "mvm_mannhattan", "mvm_mannworks", "mvm_rottenburg", "pass_brickyard", "pass_district", "pass_timbertown", "pd_cursed_cove_event", "pd_monster_bash", "pd_pit_of_death_event", "pd_watergate", "pl_badwater", "pl_barnblitz", "pl_borneo", "pl_cactuscanyon", "pl_enclosure_final", "pl_fifthcurve_event", "pl_frontier_final", "pl_goldrush", "pl_hoodoo_final", "pl_millstone_event", "pl_precipice_event_final", "pl_rumble_event", "pl_snowycoast", "pl_swiftwater_final1", "pl_thundermountain", "pl_upward", "plr_bananabay", "plr_hightower", "plr_hightower_event", "plr_nightfall_final", "plr_pipeline", "rd_asteroid", "sd_doomsday", "sd_doomsday_event", "tc_hydro", "tr_dustbowl", "tr_target"})
        Me.StartupMap_SelectMap.Location = New System.Drawing.Point(6, 71)
        Me.StartupMap_SelectMap.Name = "StartupMap_SelectMap"
        Me.StartupMap_SelectMap.Size = New System.Drawing.Size(268, 23)
        Me.StartupMap_SelectMap.TabIndex = 3
        '
        'StartupMap_lbl
        '
        Me.StartupMap_lbl.AutoSize = True
        Me.StartupMap_lbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartupMap_lbl.Location = New System.Drawing.Point(6, 49)
        Me.StartupMap_lbl.Name = "StartupMap_lbl"
        Me.StartupMap_lbl.Size = New System.Drawing.Size(227, 19)
        Me.StartupMap_lbl.TabIndex = 2
        Me.StartupMap_lbl.Text = "Startup Map (can be custom)"
        '
        'ServerName_TXT_Box
        '
        Me.ServerName_TXT_Box.Location = New System.Drawing.Point(6, 25)
        Me.ServerName_TXT_Box.MaxLength = 255
        Me.ServerName_TXT_Box.Name = "ServerName_TXT_Box"
        Me.ServerName_TXT_Box.Size = New System.Drawing.Size(268, 21)
        Me.ServerName_TXT_Box.TabIndex = 1
        Me.ServerName_TXT_Box.Text = "TF2 Server - using TF2 Server Manager"
        '
        'ServerName_lbl
        '
        Me.ServerName_lbl.AutoSize = True
        Me.ServerName_lbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerName_lbl.Location = New System.Drawing.Point(6, 3)
        Me.ServerName_lbl.Name = "ServerName_lbl"
        Me.ServerName_lbl.Size = New System.Drawing.Size(107, 19)
        Me.ServerName_lbl.TabIndex = 0
        Me.ServerName_lbl.Text = "Server Name"
        '
        'ServerConfig
        '
        Me.ServerConfig.Controls.Add(Me.QuestionMark_SV_Lan)
        Me.ServerConfig.Controls.Add(Me.mp_disable_respawn_times_DropDown)
        Me.ServerConfig.Controls.Add(Me.mp_disable_respawn_times_LBL)
        Me.ServerConfig.Controls.Add(Me.sv_lan_dropdown)
        Me.ServerConfig.Controls.Add(Me.sv_lan_lbl)
        Me.ServerConfig.Controls.Add(Me.sv_pure_dropdown)
        Me.ServerConfig.Controls.Add(Me.sv_pure_lbl)
        Me.ServerConfig.Controls.Add(Me.Srv_Port_TxTBox)
        Me.ServerConfig.Controls.Add(Me.Srv_Port_LbL)
        Me.ServerConfig.Location = New System.Drawing.Point(4, 24)
        Me.ServerConfig.Name = "ServerConfig"
        Me.ServerConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.ServerConfig.Size = New System.Drawing.Size(576, 433)
        Me.ServerConfig.TabIndex = 1
        Me.ServerConfig.Text = "Config"
        Me.ServerConfig.UseVisualStyleBackColor = True
        '
        'sv_lan_dropdown
        '
        Me.sv_lan_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sv_lan_dropdown.FormattingEnabled = True
        Me.sv_lan_dropdown.Items.AddRange(New Object() {"Internet", "LAN"})
        Me.sv_lan_dropdown.Location = New System.Drawing.Point(8, 119)
        Me.sv_lan_dropdown.Name = "sv_lan_dropdown"
        Me.sv_lan_dropdown.Size = New System.Drawing.Size(268, 23)
        Me.sv_lan_dropdown.TabIndex = 7
        '
        'sv_lan_lbl
        '
        Me.sv_lan_lbl.AutoSize = True
        Me.sv_lan_lbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sv_lan_lbl.Location = New System.Drawing.Point(8, 97)
        Me.sv_lan_lbl.Name = "sv_lan_lbl"
        Me.sv_lan_lbl.Size = New System.Drawing.Size(59, 19)
        Me.sv_lan_lbl.TabIndex = 6
        Me.sv_lan_lbl.Text = "sv_lan"
        '
        'sv_pure_dropdown
        '
        Me.sv_pure_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sv_pure_dropdown.FormattingEnabled = True
        Me.sv_pure_dropdown.Items.AddRange(New Object() {"Allow Anything", "Allow Limited", "Allow Steam Only"})
        Me.sv_pure_dropdown.Location = New System.Drawing.Point(8, 71)
        Me.sv_pure_dropdown.Name = "sv_pure_dropdown"
        Me.sv_pure_dropdown.Size = New System.Drawing.Size(268, 23)
        Me.sv_pure_dropdown.TabIndex = 5
        '
        'sv_pure_lbl
        '
        Me.sv_pure_lbl.AutoSize = True
        Me.sv_pure_lbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sv_pure_lbl.Location = New System.Drawing.Point(8, 49)
        Me.sv_pure_lbl.Name = "sv_pure_lbl"
        Me.sv_pure_lbl.Size = New System.Drawing.Size(71, 19)
        Me.sv_pure_lbl.TabIndex = 4
        Me.sv_pure_lbl.Text = "sv_pure"
        '
        'Srv_Port_TxTBox
        '
        Me.Srv_Port_TxTBox.Enabled = False
        Me.Srv_Port_TxTBox.Location = New System.Drawing.Point(8, 25)
        Me.Srv_Port_TxTBox.MaxLength = 5
        Me.Srv_Port_TxTBox.Name = "Srv_Port_TxTBox"
        Me.Srv_Port_TxTBox.Size = New System.Drawing.Size(268, 21)
        Me.Srv_Port_TxTBox.TabIndex = 3
        Me.Srv_Port_TxTBox.Text = "27015"
        '
        'Srv_Port_LbL
        '
        Me.Srv_Port_LbL.AutoSize = True
        Me.Srv_Port_LbL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Srv_Port_LbL.Location = New System.Drawing.Point(8, 3)
        Me.Srv_Port_LbL.Name = "Srv_Port_LbL"
        Me.Srv_Port_LbL.Size = New System.Drawing.Size(95, 19)
        Me.Srv_Port_LbL.TabIndex = 2
        Me.Srv_Port_LbL.Text = "Server Port"
        '
        'SettingsPage
        '
        Me.SettingsPage.Controls.Add(Me.Button1)
        Me.SettingsPage.Location = New System.Drawing.Point(4, 24)
        Me.SettingsPage.Name = "SettingsPage"
        Me.SettingsPage.Size = New System.Drawing.Size(576, 433)
        Me.SettingsPage.TabIndex = 2
        Me.SettingsPage.Text = "Settings"
        Me.SettingsPage.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(428, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Export Server Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mp_disable_respawn_times_DropDown
        '
        Me.mp_disable_respawn_times_DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mp_disable_respawn_times_DropDown.FormattingEnabled = True
        Me.mp_disable_respawn_times_DropDown.Items.AddRange(New Object() {"True", "False"})
        Me.mp_disable_respawn_times_DropDown.Location = New System.Drawing.Point(8, 167)
        Me.mp_disable_respawn_times_DropDown.Name = "mp_disable_respawn_times_DropDown"
        Me.mp_disable_respawn_times_DropDown.Size = New System.Drawing.Size(268, 23)
        Me.mp_disable_respawn_times_DropDown.TabIndex = 9
        '
        'mp_disable_respawn_times_LBL
        '
        Me.mp_disable_respawn_times_LBL.AutoSize = True
        Me.mp_disable_respawn_times_LBL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mp_disable_respawn_times_LBL.Location = New System.Drawing.Point(8, 145)
        Me.mp_disable_respawn_times_LBL.Name = "mp_disable_respawn_times_LBL"
        Me.mp_disable_respawn_times_LBL.Size = New System.Drawing.Size(222, 19)
        Me.mp_disable_respawn_times_LBL.TabIndex = 8
        Me.mp_disable_respawn_times_LBL.Text = "mp_disable_respawn_times"
        '
        'QuestionMark_SV_Lan
        '
        Me.QuestionMark_SV_Lan.AutoSize = True
        Me.QuestionMark_SV_Lan.Location = New System.Drawing.Point(73, 101)
        Me.QuestionMark_SV_Lan.Name = "QuestionMark_SV_Lan"
        Me.QuestionMark_SV_Lan.Size = New System.Drawing.Size(14, 15)
        Me.QuestionMark_SV_Lan.TabIndex = 10
        Me.QuestionMark_SV_Lan.TabStop = True
        Me.QuestionMark_SV_Lan.Text = "?"
        '
        'Export_Settings_Dialog
        '
        Me.Export_Settings_Dialog.CheckFileExists = True
        Me.Export_Settings_Dialog.Filter = "TF2 Server Manger Settings (*.tf2smset)|*.tf2smset"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 165)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 21)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "C:\Server Manager\GUI\Servers\TF2\"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Server Folder Location"
        '
        'Server_Manager_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Server_Manager_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TF2 Server Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.ServerDetails.ResumeLayout(False)
        Me.ServerDetails.PerformLayout()
        Me.ServerConfig.ResumeLayout(False)
        Me.ServerConfig.PerformLayout()
        Me.SettingsPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ServerDetails As TabPage
    Friend WithEvents ServerName_TXT_Box As TextBox
    Friend WithEvents ServerName_lbl As Label
    Friend WithEvents ServerConfig As TabPage
    Friend WithEvents StartupMap_lbl As Label
    Friend WithEvents StartupMap_SelectMap As ComboBox
    Friend WithEvents MaxPlayers_TxTBox As TextBox
    Friend WithEvents MaxPlayersLBL As Label
    Friend WithEvents Srv_Port_TxTBox As TextBox
    Friend WithEvents Srv_Port_LbL As Label
    Friend WithEvents sv_pure_dropdown As ComboBox
    Friend WithEvents sv_pure_lbl As Label
    Friend WithEvents sv_lan_dropdown As ComboBox
    Friend WithEvents sv_lan_lbl As Label
    Friend WithEvents SettingsPage As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents mp_disable_respawn_times_DropDown As ComboBox
    Friend WithEvents mp_disable_respawn_times_LBL As Label
    Friend WithEvents QuestionMark_SV_Lan As LinkLabel
    Friend WithEvents Export_Settings_Dialog As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
