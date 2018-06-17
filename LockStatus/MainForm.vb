Imports System.IO
Imports System.Globalization
Imports System.Management
Imports System.IO.IsolatedStorage
Imports LockStatus.My.MySettings


Public Class MainForm
    Declare Function GetKeyState Lib "user32" Alias "GetKeyState" (ByVal KeyState As Int32) As Int16

    Public Shared RestartRequired As Boolean = False

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    Private Const VK_NumLock As Integer = &H90
    Private Const VK_CapsLock As Integer = &H14
    Private Const VK_ScrollLock As Integer = &H91

    Private Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Private Const KEYEVENTF_KEYUP As Integer = &H2

    Dim ComputerName As String
    Dim ComputerManufacturer As String
    Dim ComputerModel As String
    Dim OSName As String
    Dim OSVersion As String
    Dim ApplicationVersion As String
    Dim ApplicationType As String
    Dim SystemType As String
    Dim TotalPhysicalMemory As String
    Dim WindowsDirectory As String
    Dim CPUName As String
    Dim NumberOfCores As String
    Dim NumberOfLogicalProcessors As String
    Dim MaxClockSpeed As String
    Dim OSCulture As CultureInfo = CultureInfo.InstalledUICulture

    Protected Overrides Sub SetVisibleCore(value As Boolean)
        If Not Me.IsHandleCreated Then
            Me.CreateHandle()
            value = False
        End If

        MyBase.SetVisibleCore(value)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Not My.Settings.LockieTray = True Then
            LockieTray.Visible = False
        Else
            LockieTray.Visible = True
        End If

        'Mechanical Keyboard operating frequency = 1000Hz per 1 Second : 1 millisecond.
        Timer.Interval = 1
        KeyIndicator()
    End Sub

    Private Sub KeyIndicator()
        'When the Num-Lock Key is ON, Caps-Lock Key is ON, Scroll-Lock Key is ON.
        If GetKeyState(VK_NumLock) = 1 And GetKeyState(VK_CapsLock) = 1 And GetKeyState(VK_ScrollLock) = 1 Then
            NumLockTray.Visible = True
            CapsLockTray.Visible = True
            ScrollLockTray.Visible = True

            'When the Num-Lock Key is ON, Caps-Lock Key is ON, Scroll-Lock Key is OFF.
        ElseIf GetKeyState(VK_NumLock) = 1 And GetKeyState(VK_CapsLock) = 1 And GetKeyState(VK_ScrollLock) <> 1 Then
            NumLockTray.Visible = True
            CapsLockTray.Visible = True
            ScrollLockTray.Visible = False

            'When the Num-Lock Key is OFF, Caps-Lock Key is ON, Scroll-Lock Key is ON.
        ElseIf GetKeyState(VK_NumLock) <> 1 And GetKeyState(VK_CapsLock) = 1 And GetKeyState(VK_ScrollLock) = 1 Then
            NumLockTray.Visible = False
            CapsLockTray.Visible = True
            ScrollLockTray.Visible = True

            'When the Num-Lock Key is ON, Caps-Lock Key is OFF, Scroll-Lock Key is ON.
        ElseIf GetKeyState(VK_NumLock) = 1 And GetKeyState(VK_CapsLock) <> 1 And GetKeyState(VK_ScrollLock) = 1 Then
            NumLockTray.Visible = True
            CapsLockTray.Visible = False
            ScrollLockTray.Visible = True

            'When the Num-Lock Key is ON, Caps-Lock Key is OFF, Scroll-Lock Key is OFF.
        ElseIf GetKeyState(VK_NumLock) = 1 And GetKeyState(VK_CapsLock) <> 1 And GetKeyState(VK_ScrollLock) <> 1 Then
            NumLockTray.Visible = True
            CapsLockTray.Visible = False
            ScrollLockTray.Visible = False

            'When the Num-Lock Key is OFF, Caps-Lock Key is ON, Scroll-Lock Key is OFF.
        ElseIf GetKeyState(VK_NumLock) <> 1 And GetKeyState(VK_CapsLock) = 1 And GetKeyState(VK_ScrollLock) <> 1 Then
            NumLockTray.Visible = False
            CapsLockTray.Visible = True
            ScrollLockTray.Visible = False

            'When the Num-Lock Key is OFF, Caps-Lock Key is OFF, Scroll-Lock Key is ON.
        ElseIf GetKeyState(VK_NumLock) <> 1 And GetKeyState(VK_CapsLock) <> 1 And GetKeyState(VK_ScrollLock) = 1 Then
            NumLockTray.Visible = False
            CapsLockTray.Visible = False
            ScrollLockTray.Visible = True

            'When the Num-Lock Key is OFF, Caps-Lock Key is OFF, Scroll-Lock Key is OFF.
        ElseIf GetKeyState(VK_NumLock) <> 1 And GetKeyState(VK_CapsLock) <> 1 And GetKeyState(VK_ScrollLock) <> 1 Then
            NumLockTray.Visible = False
            CapsLockTray.Visible = False
            ScrollLockTray.Visible = False
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim BinaryData As Byte() = {0}

        'When the user closes the form.
        If e.CloseReason = CloseReason.UserClosing Then
            'Show a messagebox to users to confirm.
            Select Case MessageBox.Show("Are you sure you want to quit ""Lockie""?", "Lockie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    'Exit the application
                    Application.Exit()
                    Exit Sub
                Case Windows.Forms.DialogResult.No
                    'Cancel the form closing event
                    e.Cancel = True
                    Exit Sub
            End Select
        End If

        If e.CloseReason = CloseReason.WindowsShutDown Then
            If RestartRequired = True Then
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).DeleteValue("IconStreams")
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).DeleteValue("PastIconsStream")

                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("IconStreams", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("PastIconsStream", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)

                Restarter.Enabled = True
                Restarter.Interval = 10
                Restarter.Start()
                Exit Sub
            Else
                Application.Exit()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MainForm_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Try
            System.Diagnostics.Process.Start("Lockie for Keyboards Software End-User License Agreement.pdf")
            Exit Sub

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplicationVersionLabel.Text = Application.ProductVersion
        InvisibleButton.Select()

        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName, String.Empty) Is String.Empty Then
            StartupCheckBox.Checked = True
            My.Settings.Startup = True
        Else
            StartupCheckBox.Checked = False
            My.Settings.Startup = False
        End If

        If Not My.Settings.Startup = True Then
            StartupCheckBox.Checked = False
            Exit Sub
        Else
            StartupCheckBox.Checked = True
            Exit Sub
        End If
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        If FrmSettings.Visible = True Then
            FrmSettings.TopMost = True
        Else
            FrmSettings.TopMost = False
            FrmSettings.ShowDialog()
            FrmSettings.Activate()
        End If
    End Sub

    Private Sub SupportButton_Click(sender As Object, e As EventArgs) Handles SupportButton.Click
        GetSystemInfo()
        System.Diagnostics.Process.Start("mailto:hellosurfy@outlook.com?subject=Feedback for Lockie Application" + "&body=" + "Hello, I have a question / proposal regarding Lockie Application." & "%0D%0A" & "%0D%0A" & "%0D%0A" & "Thanks :)" & "%0D%0A" & "%0D%0A" & "%0D%0A" & "< System Information >" & "%0D%0A" & ComputerName & "%0D%0A" & ComputerManufacturer & "%0D%0A" & ComputerModel & "%0D%0A" & ApplicationVersion & "%0D%0A" & OSName & "%0D%0A" & OSVersion & "%0D%0A" & "OS Language" & " " & ":" & " " & OSCulture.Name & "%0D%0A" & SystemType & "%0D%0A" & CPUName & "%0D%0A" & NumberOfCores & "%0D%0A" & NumberOfLogicalProcessors & "%0D%0A" & MaxClockSpeed & "%0D%0A" & TotalPhysicalMemory & "%0D%0A" & WindowsDirectory)
        ClearSystemInfo()
    End Sub

    Private Sub ClearSystemInfo()
        ComputerName = String.Empty
        ComputerManufacturer = String.Empty
        ComputerModel = String.Empty
        OSName = String.Empty
        OSVersion = String.Empty
        ApplicationVersion = String.Empty
        SystemType = String.Empty
        CPUName = String.Empty
        NumberOfCores = String.Empty
        NumberOfLogicalProcessors = String.Empty
        MaxClockSpeed = String.Empty
        TotalPhysicalMemory = String.Empty
        WindowsDirectory = String.Empty
    End Sub

    Private Sub GetSystemInfo()
        Dim objWMI As New clsWMI()

        With objWMI
            ComputerName = ("Computer Name" & " " & ":" & " " & .ComputerName)
            ComputerManufacturer = ("Computer Manufacturer" & " " & ":" & " " & .Manufacturer)
            ComputerModel = ("Computer Model" & " " & ":" & " " & .Model)
            OSName = ("OS Name" & " " & ":" & " " & .OsName)
            OSVersion = ("OS Version" & " " & ":" & " " & .OsVersion)
            ApplicationVersion = ("Application Version" & " " & ":" & " " & Application.ProductVersion)
            SystemType = ("System Type" & " " & ":" & " " & .SystemType)
            CPUName = ("CPU Name" & " " & ":" & " " & .CPUName)
            NumberOfCores = ("Number of Cores" & " " & ":" & " " & .NumberOfCores)
            NumberOfLogicalProcessors = ("Number of Logical Processors" & " " & ":" & " " & .NumberOfLogicalProcessors)
            MaxClockSpeed = ("Max Clock Speed" & " " & ":" & " " & .MaxClockSpeed & "GHz")
            TotalPhysicalMemory = ("Total Physical Memory" & " " & ":" & " " & .TotalPhysicalMemory.ToString & "MB")
            WindowsDirectory = ("Windows Directory" & " " & ":" & " " & .WindowsDirectory)
        End With
    End Sub

    Private Sub InvisibleButton_Click(sender As Object, e As EventArgs) Handles InvisibleButton.Click
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run", Application.ProductName, String.Empty) Is String.Empty Then
            If StartupCheckBox.Checked = True Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                My.Settings.Startup = True
                My.Settings.Save()
                Me.Visible = False
                Exit Sub
            ElseIf StartupCheckBox.Checked = False Then
                My.Settings.Startup = False
                My.Settings.Save()
                Me.Visible = False
                Exit Sub
            End If
        Else
            If StartupCheckBox.Checked = True Then
                My.Settings.Startup = True
                My.Settings.Save()
                Me.Visible = False
                Exit Sub
            ElseIf StartupCheckBox.Checked = False Then
                Try
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    Me.Visible = False
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show("Failed to Update System Registry.", "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                    StartupCheckBox.Checked = True
                    My.Settings.Startup = False
                    My.Settings.Save()
                    Me.Visible = False
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub LinkHappyBono_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHappyBono.LinkClicked
        System.Diagnostics.Process.Start("http://www.happybono.net/")
    End Sub

    Private Sub NumLockTray_MouseUp(sender As Object, e As MouseEventArgs) Handles NumLockTray.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Visible = True Then
                Me.Visible = False
            ElseIf Me.Visible = False Then
                Me.Visible = True
                Me.Activate()
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Middle Then
            keybd_event(VK_NumLock, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
            keybd_event(VK_NumLock, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Options.Show()
        End If
    End Sub

    Private Sub CapsLockTray_MouseUp(sender As Object, e As MouseEventArgs) Handles CapsLockTray.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Visible = True Then
                Me.Visible = False
            ElseIf Me.Visible = False Then
                Me.Visible = True
                Me.Activate()
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Middle Then
            keybd_event(VK_CapsLock, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
            keybd_event(VK_CapsLock, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Options.Show()
        End If
    End Sub

    Private Sub ScrollLockTray_MouseUp(sender As Object, e As MouseEventArgs) Handles ScrollLockTray.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Visible = True Then
                Me.Visible = False
            ElseIf Me.Visible = False Then
                Me.Visible = True
                Me.Activate()
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Middle Then
            keybd_event(VK_ScrollLock, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
            keybd_event(VK_ScrollLock, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Options.Show()
        End If
    End Sub

    Private Sub ToolStripMenuCustomize_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCustomize.Click
        If FrmSettings.Visible = True Then
            FrmSettings.Activate()
        Else
            FrmSettings.ShowDialog()
            FrmSettings.Activate()
        End If
    End Sub

    Private Sub ToolStripMenuExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuExit.Click
        Select Case MessageBox.Show("Are you sure you want to quit ""Lockie""?", "Lockie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                'Exit the application
                Application.Exit()
                Exit Sub
            Case Windows.Forms.DialogResult.No
                'Cancel the form closing event
                Exit Sub
        End Select
    End Sub

    Private Sub ToolStripMenuKeyboardSettings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuKeyboardSettings.Click

        Try
            System.Diagnostics.Process.Start("control.exe", "main.cpl" & " " & "keyboard")
            Exit Sub
        Catch
            Try
                System.Diagnostics.Process.Start("control.exe", "main.cpl")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Try

    End Sub

    Private Sub ToolStripMenuAccessibilitySettings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAccessibilitySettings.Click
        Dim Accessibility = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString & "\Packages\windows.immersivecontrolpanel_cw5n1h2txyewy\LocalState\Indexed\Settings\" & OSCulture.Name & "\AAA_SettingsPageEaseOfAccessKeyboard.settingcontent-ms")

        If Environment.OSVersion.Version >= New Version(6, 2, 9200, 0) Then
            Try
                System.Diagnostics.Process.Start(Accessibility)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        ElseIf Environment.OSVersion.Version < New Version(6, 2, 9200, 0) Then
            Try
                System.Diagnostics.Process.Start("control.exe", "access.cpl")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Visible = True
        Me.Activate()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not My.Settings.NumLockIconURL = String.Empty Then
            Try
                NumLockTray.Icon = New Icon(My.Settings.NumLockIconURL, New Size(16, 16))
            Catch ex As Exception
                My.Settings.NumLockIconURL = String.Empty
                My.Settings.Save()
            End Try
        End If

        If Not My.Settings.CapsLockIconURL = String.Empty Then
            Try
                CapsLockTray.Icon = New Icon(My.Settings.CapsLockIconURL, New Size(16, 16))
            Catch ex As Exception
                My.Settings.CapsLockIconURL = String.Empty
                My.Settings.Save()
            End Try
        End If

        If Not My.Settings.ScrollLockIconURL = String.Empty Then
            Try
                ScrollLockTray.Icon = New Icon(My.Settings.ScrollLockIconURL, New Size(16, 16))
            Catch ex As Exception
                My.Settings.ScrollLockIconURL = String.Empty
                My.Settings.Save()
            End Try
        End If
    End Sub

    Private Sub ManageNotificationIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageNotificationIconsToolStripMenuItem.Click
        Dim Notifications = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString & "\Packages\windows.immersivecontrolpanel_cw5n1h2txyewy\LocalState\Indexed\Settings\" & OSCulture.Name & "\AAA_SystemSettings_Notifications_SelectIconsToAppearOnTaskbar.settingcontent-ms")

        Try
            System.Diagnostics.Process.Start(Notifications)
        Catch ex1 As Exception
            Try
                System.Diagnostics.Process.Start("control.exe", "/name" & " " & "Microsoft.NotificationAreaIcons")
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Try
    End Sub

    Private Sub ToolStripMenuBluetoothSettings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuBluetoothSettings.Click
        Dim Bluetooth = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString & "\Packages\windows.immersivecontrolpanel_cw5n1h2txyewy\LocalState\Indexed\Settings\" & OSCulture.Name & "\AAA_SettingsPagePCSystemBluetooth.settingcontent-ms")

        If Environment.OSVersion.Version > New Version(6, 2, 9200, 0) Then
            Try
                System.Diagnostics.Process.Start(Bluetooth)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        ElseIf Environment.OSVersion.Version <= New Version(6, 2, 9200, 0) Then
            Try
                System.Diagnostics.Process.Start("control.exe", "bthprops.cpl")
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub LockieTray_MouseUp(sender As Object, e As MouseEventArgs) Handles LockieTray.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.Visible = True Then
                Me.Visible = False
            ElseIf Me.Visible = False Then
                Me.Visible = True
                Me.Activate()
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Options.Show()
        End If
    End Sub

    Private Sub Restarter_Tick(sender As Object, e As EventArgs) Handles Restarter.Tick
        System.Diagnostics.Process.Start("taskkill.exe", "/F /IM explorer.exe")
        Timer.Stop()
        Timer.Enabled = False
        Application.Exit()
    End Sub
End Class
