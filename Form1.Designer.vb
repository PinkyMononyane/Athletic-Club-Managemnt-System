<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditExistingMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyExistingEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventMaintenanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditExistingResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberMaintenanceToolStripMenuItem, Me.EventMaintenanceToolStripMenuItem, Me.EventMaintenanceToolStripMenuItem1, Me.CloseAllToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MemberMaintenanceToolStripMenuItem
        '
        Me.MemberMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewMemberToolStripMenuItem, Me.EditExistingMemberToolStripMenuItem, Me.DeleteMemberToolStripMenuItem})
        Me.MemberMaintenanceToolStripMenuItem.Name = "MemberMaintenanceToolStripMenuItem"
        Me.MemberMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.MemberMaintenanceToolStripMenuItem.Text = "&Member Maintenance"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AddNewMemberToolStripMenuItem.Text = "&Add New Member"
        '
        'EditExistingMemberToolStripMenuItem
        '
        Me.EditExistingMemberToolStripMenuItem.Name = "EditExistingMemberToolStripMenuItem"
        Me.EditExistingMemberToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.EditExistingMemberToolStripMenuItem.Text = "&Edit Existing Member"
        '
        'DeleteMemberToolStripMenuItem
        '
        Me.DeleteMemberToolStripMenuItem.Name = "DeleteMemberToolStripMenuItem"
        Me.DeleteMemberToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.DeleteMemberToolStripMenuItem.Text = "&Delete Member"
        '
        'EventMaintenanceToolStripMenuItem
        '
        Me.EventMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEventToolStripMenuItem, Me.ModifyExistingEventToolStripMenuItem, Me.DeleteEventToolStripMenuItem})
        Me.EventMaintenanceToolStripMenuItem.Name = "EventMaintenanceToolStripMenuItem"
        Me.EventMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.EventMaintenanceToolStripMenuItem.Text = "&Event Maintenance"
        '
        'AddNewEventToolStripMenuItem
        '
        Me.AddNewEventToolStripMenuItem.Name = "AddNewEventToolStripMenuItem"
        Me.AddNewEventToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.AddNewEventToolStripMenuItem.Text = "&Add New Event"
        '
        'ModifyExistingEventToolStripMenuItem
        '
        Me.ModifyExistingEventToolStripMenuItem.Name = "ModifyExistingEventToolStripMenuItem"
        Me.ModifyExistingEventToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.ModifyExistingEventToolStripMenuItem.Text = "&Modify Existing Event"
        '
        'DeleteEventToolStripMenuItem
        '
        Me.DeleteEventToolStripMenuItem.Name = "DeleteEventToolStripMenuItem"
        Me.DeleteEventToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.DeleteEventToolStripMenuItem.Text = "&Delete Event"
        '
        'EventMaintenanceToolStripMenuItem1
        '
        Me.EventMaintenanceToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterResultsToolStripMenuItem, Me.EditExistingResultsToolStripMenuItem, Me.DeleteResultsToolStripMenuItem})
        Me.EventMaintenanceToolStripMenuItem1.Name = "EventMaintenanceToolStripMenuItem1"
        Me.EventMaintenanceToolStripMenuItem1.Size = New System.Drawing.Size(223, 24)
        Me.EventMaintenanceToolStripMenuItem1.Text = "Event &Results"
        '
        'EnterResultsToolStripMenuItem
        '
        Me.EnterResultsToolStripMenuItem.Name = "EnterResultsToolStripMenuItem"
        Me.EnterResultsToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.EnterResultsToolStripMenuItem.Text = "Enter Results"
        '
        'EditExistingResultsToolStripMenuItem
        '
        Me.EditExistingResultsToolStripMenuItem.Name = "EditExistingResultsToolStripMenuItem"
        Me.EditExistingResultsToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.EditExistingResultsToolStripMenuItem.Text = "Edit Existing Results"
        '
        'DeleteResultsToolStripMenuItem
        '
        Me.DeleteResultsToolStripMenuItem.Name = "DeleteResultsToolStripMenuItem"
        Me.DeleteResultsToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.DeleteResultsToolStripMenuItem.Text = "Delete Results"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.CloseAllToolStripMenuItem.Text = "&Close All"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 361)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Athletic Club Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditExistingMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyExistingEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventMaintenanceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditExistingResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
