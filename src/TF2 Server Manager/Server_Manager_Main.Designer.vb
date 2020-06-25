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
        Me.ServerConfig = New System.Windows.Forms.TabPage()
        Me.ServerName_lbl = New System.Windows.Forms.Label()
        Me.ServerName_TXT_Box = New System.Windows.Forms.TextBox()
        Me.StartupMap_lbl = New System.Windows.Forms.Label()
        Me.StartupMap_SelectMap = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.ServerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ServerDetails)
        Me.TabControl1.Controls.Add(Me.ServerConfig)
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
        'ServerConfig
        '
        Me.ServerConfig.Location = New System.Drawing.Point(4, 22)
        Me.ServerConfig.Name = "ServerConfig"
        Me.ServerConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.ServerConfig.Size = New System.Drawing.Size(576, 535)
        Me.ServerConfig.TabIndex = 1
        Me.ServerConfig.Text = "Config"
        Me.ServerConfig.UseVisualStyleBackColor = True
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
        'ServerName_TXT_Box
        '
        Me.ServerName_TXT_Box.Location = New System.Drawing.Point(6, 25)
        Me.ServerName_TXT_Box.MaxLength = 255
        Me.ServerName_TXT_Box.Name = "ServerName_TXT_Box"
        Me.ServerName_TXT_Box.Size = New System.Drawing.Size(268, 21)
        Me.ServerName_TXT_Box.TabIndex = 1
        Me.ServerName_TXT_Box.Text = "TF2 Server - using TF2 Server Manager"
        '
        'StartupMap_lbl
        '
        Me.StartupMap_lbl.AutoSize = True
        Me.StartupMap_lbl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartupMap_lbl.Location = New System.Drawing.Point(7, 49)
        Me.StartupMap_lbl.Name = "StartupMap_lbl"
        Me.StartupMap_lbl.Size = New System.Drawing.Size(227, 19)
        Me.StartupMap_lbl.TabIndex = 2
        Me.StartupMap_lbl.Text = "Startup Map (can be custom)"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ServerDetails As TabPage
    Friend WithEvents ServerName_TXT_Box As TextBox
    Friend WithEvents ServerName_lbl As Label
    Friend WithEvents ServerConfig As TabPage
    Friend WithEvents StartupMap_lbl As Label
    Friend WithEvents StartupMap_SelectMap As ComboBox
End Class
