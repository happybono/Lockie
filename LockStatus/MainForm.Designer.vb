<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot String.Empty Then
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.NumLockTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Options = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuBluetoothSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuAccessibilitySettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuKeyboardSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ManageNotificationIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapsLockTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScrollLockTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ApplicationVersionLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.SupportButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InvisibleButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartupCheckBox = New System.Windows.Forms.CheckBox()
        Me.LinkHappyBono = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LockieTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Restarter = New System.Windows.Forms.Timer(Me.components)
        Me.Options.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumLockTray
        '
        Me.NumLockTray.ContextMenuStrip = Me.Options
        Me.NumLockTray.Icon = CType(resources.GetObject("NumLockTray.Icon"), System.Drawing.Icon)
        Me.NumLockTray.Text = "Num Lock : On"
        '
        'Options
        '
        Me.Options.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuBluetoothSettings, Me.ToolStripMenuAccessibilitySettings, Me.ToolStripSeparator2, Me.ToolStripMenuKeyboardSettings, Me.ToolStripSeparator1, Me.ManageNotificationIconsToolStripMenuItem, Me.ToolStripSeparator, Me.ToolStripMenuCustomize, Me.AboutToolStripMenuItem, Me.ToolStripMenuExit})
        Me.Options.Name = "ContextMenuStrip"
        Me.Options.Size = New System.Drawing.Size(215, 176)
        '
        'ToolStripMenuBluetoothSettings
        '
        Me.ToolStripMenuBluetoothSettings.Image = CType(resources.GetObject("ToolStripMenuBluetoothSettings.Image"), System.Drawing.Image)
        Me.ToolStripMenuBluetoothSettings.Name = "ToolStripMenuBluetoothSettings"
        Me.ToolStripMenuBluetoothSettings.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuBluetoothSettings.Text = "Bluetooth Settings"
        '
        'ToolStripMenuAccessibilitySettings
        '
        Me.ToolStripMenuAccessibilitySettings.Image = CType(resources.GetObject("ToolStripMenuAccessibilitySettings.Image"), System.Drawing.Image)
        Me.ToolStripMenuAccessibilitySettings.Name = "ToolStripMenuAccessibilitySettings"
        Me.ToolStripMenuAccessibilitySettings.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuAccessibilitySettings.Text = "Accessibility Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(211, 6)
        '
        'ToolStripMenuKeyboardSettings
        '
        Me.ToolStripMenuKeyboardSettings.Image = CType(resources.GetObject("ToolStripMenuKeyboardSettings.Image"), System.Drawing.Image)
        Me.ToolStripMenuKeyboardSettings.Name = "ToolStripMenuKeyboardSettings"
        Me.ToolStripMenuKeyboardSettings.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuKeyboardSettings.Text = "Keyboard Properties"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(211, 6)
        '
        'ManageNotificationIconsToolStripMenuItem
        '
        Me.ManageNotificationIconsToolStripMenuItem.Image = CType(resources.GetObject("ManageNotificationIconsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageNotificationIconsToolStripMenuItem.Name = "ManageNotificationIconsToolStripMenuItem"
        Me.ManageNotificationIconsToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ManageNotificationIconsToolStripMenuItem.Text = "Manage Notification Icons"
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        Me.ToolStripSeparator.Size = New System.Drawing.Size(211, 6)
        '
        'ToolStripMenuCustomize
        '
        Me.ToolStripMenuCustomize.Image = CType(resources.GetObject("ToolStripMenuCustomize.Image"), System.Drawing.Image)
        Me.ToolStripMenuCustomize.Name = "ToolStripMenuCustomize"
        Me.ToolStripMenuCustomize.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuCustomize.Text = "Customize"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuExit
        '
        Me.ToolStripMenuExit.Image = CType(resources.GetObject("ToolStripMenuExit.Image"), System.Drawing.Image)
        Me.ToolStripMenuExit.Name = "ToolStripMenuExit"
        Me.ToolStripMenuExit.Size = New System.Drawing.Size(214, 22)
        Me.ToolStripMenuExit.Text = "Exit"
        '
        'CapsLockTray
        '
        Me.CapsLockTray.ContextMenuStrip = Me.Options
        Me.CapsLockTray.Icon = CType(resources.GetObject("CapsLockTray.Icon"), System.Drawing.Icon)
        Me.CapsLockTray.Text = "Caps Lock : On"
        Me.CapsLockTray.Visible = True
        '
        'ScrollLockTray
        '
        Me.ScrollLockTray.ContextMenuStrip = Me.Options
        Me.ScrollLockTray.Icon = CType(resources.GetObject("ScrollLockTray.Icon"), System.Drawing.Icon)
        Me.ScrollLockTray.Text = "Scroll Lock : On"
        Me.ScrollLockTray.Visible = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version :"
        '
        'ApplicationVersionLabel
        '
        Me.ApplicationVersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplicationVersionLabel.AutoSize = True
        Me.ApplicationVersionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationVersionLabel.Location = New System.Drawing.Point(362, 29)
        Me.ApplicationVersionLabel.Name = "ApplicationVersionLabel"
        Me.ApplicationVersionLabel.Size = New System.Drawing.Size(16, 17)
        Me.ApplicationVersionLabel.TabIndex = 2
        Me.ApplicationVersionLabel.Text = "  "
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SettingsButton.Location = New System.Drawing.Point(11, 301)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(129, 23)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Customize"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'SupportButton
        '
        Me.SupportButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupportButton.BackColor = System.Drawing.Color.Transparent
        Me.SupportButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupportButton.Location = New System.Drawing.Point(146, 301)
        Me.SupportButton.Name = "SupportButton"
        Me.SupportButton.Size = New System.Drawing.Size(129, 23)
        Me.SupportButton.TabIndex = 3
        Me.SupportButton.Text = "Contact Support"
        Me.SupportButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(111, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Copyright "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(169, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ⓒ"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(189, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = " 2015  HappyBono.  All  Rights  Reserved."
        '
        'InvisibleButton
        '
        Me.InvisibleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvisibleButton.BackColor = System.Drawing.Color.Transparent
        Me.InvisibleButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InvisibleButton.Location = New System.Drawing.Point(281, 301)
        Me.InvisibleButton.Name = "InvisibleButton"
        Me.InvisibleButton.Size = New System.Drawing.Size(129, 23)
        Me.InvisibleButton.TabIndex = 4
        Me.InvisibleButton.Text = "OK"
        Me.InvisibleButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(21, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 68)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 103)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(17, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(386, 51)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lockie for Keyboards is a free and open-source utility released" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "under Microsoft " & _
    "Reciprocal License (Ms-RL) and the source code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is freely available from the"
        '
        'StartupCheckBox
        '
        Me.StartupCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartupCheckBox.AutoSize = True
        Me.StartupCheckBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.StartupCheckBox.Location = New System.Drawing.Point(11, 278)
        Me.StartupCheckBox.Name = "StartupCheckBox"
        Me.StartupCheckBox.Size = New System.Drawing.Size(204, 17)
        Me.StartupCheckBox.TabIndex = 1
        Me.StartupCheckBox.Text = "Start Lockie when I start Windows."
        Me.StartupCheckBox.UseVisualStyleBackColor = True
        '
        'LinkHappyBono
        '
        Me.LinkHappyBono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkHappyBono.AutoSize = True
        Me.LinkHappyBono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkHappyBono.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LinkHappyBono.Location = New System.Drawing.Point(175, 241)
        Me.LinkHappyBono.Name = "LinkHappyBono"
        Me.LinkHappyBono.Size = New System.Drawing.Size(55, 17)
        Me.LinkHappyBono.TabIndex = 13
        Me.LinkHappyBono.TabStop = True
        Me.LinkHappyBono.Text = "website."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lockie for Keyboards"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 3)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LockieTray
        '
        Me.LockieTray.ContextMenuStrip = Me.Options
        Me.LockieTray.Icon = CType(resources.GetObject("LockieTray.Icon"), System.Drawing.Icon)
        Me.LockieTray.Text = "Lockie"
        '
        'Restarter
        '
        Me.Restarter.Interval = 59000
        '
        'MainForm
        '
        Me.AcceptButton = Me.InvisibleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 351)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StartupCheckBox)
        Me.Controls.Add(Me.InvisibleButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupportButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.ApplicationVersionLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkHappyBono)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lockie"
        Me.Options.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumLockTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents CapsLockTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScrollLockTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ApplicationVersionLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents SupportButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InvisibleButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StartupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LinkHappyBono As System.Windows.Forms.LinkLabel
    Friend WithEvents Options As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuKeyboardSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuAccessibilitySettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageNotificationIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuBluetoothSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LockieTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents Restarter As System.Windows.Forms.Timer

End Class
