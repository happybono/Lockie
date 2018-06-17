Imports System.Windows.Forms
Imports System.IO
Imports System.Globalization
Imports System.Diagnostics

Public Class FrmSettings
    Dim OSCulture As CultureInfo = CultureInfo.InstalledUICulture

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        SaveSettings()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveSettings()

        Dim NumIconFileName As String = String.Empty
        Dim NumIconFilePath As String = String.Empty
        Dim CapsIconFileName As String = String.Empty
        Dim CapsIconFilePath As String = String.Empty
        Dim ScrollIconFileName As String = String.Empty
        Dim ScrollIconFilePath As String = String.Empty

        If LockieTrayNotifyCheckBox.Checked = True Then
            My.Settings.LockieTray = True
            My.Settings.Save()
            MainForm.LockieTray.Visible = True

        ElseIf LockieTrayNotifyCheckBox.Checked = False Then
            My.Settings.LockieTray = False
            My.Settings.Save()
            MainForm.LockieTray.Visible = False

        End If

        If NumIconLocationTextBox.Text.Length > 0 Then

            If Not My.Settings.NumLockIconURL = Nothing Then

                If File.Exists(My.Settings.NumLockIconURL) = True Then
                    File.Delete(My.Settings.NumLockIconURL)

                    If File.Exists(NumIconLocationTextBox.Text) = True Then
                        NumIconFileName = Path.GetFileName(NumIconLocationTextBox.Text)
                        NumIconFilePath = Application.StartupPath & "\LockieNumLock.ico"
                        File.Copy(NumIconLocationTextBox.Text, NumIconFilePath, True)

                        My.Settings.NumLockIconURL = NumIconFilePath
                        MainForm.NumLockTray.Icon = New Icon(My.Settings.NumLockIconURL, New Size(16, 16))

                        Dim NumIconFileInfo As New FileInfo(NumIconFilePath)
                        NumIconFileInfo.Attributes = FileAttributes.Hidden

                        My.Settings.Save()
                    End If
                End If
            Else
                If File.Exists(NumIconLocationTextBox.Text) = True Then
                    NumIconFileName = Path.GetFileName(NumIconLocationTextBox.Text)

                    NumIconFilePath = Application.StartupPath & "\LockieNumLock.ico"
                    File.Copy(NumIconLocationTextBox.Text, NumIconFilePath, True)

                    My.Settings.NumLockIconURL = NumIconFilePath
                    MainForm.NumLockTray.Icon = New Icon(My.Settings.NumLockIconURL, New Size(16, 16))

                    Dim NumIconFileInfo As New FileInfo(NumIconFilePath)
                    NumIconFileInfo.Attributes = FileAttributes.Hidden

                    My.Settings.Save()
                End If
            End If
        End If

        If CapsIconLocationTextBox.Text.Length > 0 Then

            If Not My.Settings.CapsLockIconURL = Nothing Then

                If File.Exists(My.Settings.CapsLockIconURL) = True Then
                    File.Delete(My.Settings.CapsLockIconURL)

                    If File.Exists(CapsIconLocationTextBox.Text) = True Then
                        CapsIconFileName = Path.GetFileName(CapsIconLocationTextBox.Text)

                        CapsIconFilePath = Application.StartupPath & "\LockieCapsLock.ico"
                        File.Copy(CapsIconLocationTextBox.Text, CapsIconFilePath, True)

                        My.Settings.CapsLockIconURL = CapsIconFilePath
                        MainForm.CapsLockTray.Icon = New Icon(My.Settings.CapsLockIconURL, New Size(16, 16))

                        Dim CapsIconFileInfo As New FileInfo(CapsIconFilePath)
                        CapsIconFileInfo.Attributes = FileAttributes.Hidden

                        My.Settings.Save()
                    End If
                End If
            Else
                If File.Exists(CapsIconLocationTextBox.Text) = True Then
                    CapsIconFileName = Path.GetFileName(CapsIconLocationTextBox.Text)

                    CapsIconFilePath = Application.StartupPath & "\LockieCapsLock.ico"
                    File.Copy(CapsIconLocationTextBox.Text, CapsIconFilePath, True)

                    My.Settings.CapsLockIconURL = CapsIconFilePath
                    MainForm.CapsLockTray.Icon = New Icon(My.Settings.CapsLockIconURL, New Size(16, 16))

                    Dim CapsIconFileInfo As New FileInfo(CapsIconFilePath)
                    CapsIconFileInfo.Attributes = FileAttributes.Hidden

                    My.Settings.Save()
                End If
            End If
        End If

        If ScrollIconLocationTextBox.Text.Length > 0 Then

            If Not My.Settings.ScrollLockIconURL = Nothing Then

                If File.Exists(My.Settings.ScrollLockIconURL) = True Then
                    File.Delete(My.Settings.ScrollLockIconURL)

                    If File.Exists(ScrollIconLocationTextBox.Text) = True Then
                        ScrollIconFileName = Path.GetFileName(ScrollIconLocationTextBox.Text)

                        ScrollIconFilePath = Application.StartupPath & "\LockieScrollLock.ico"
                        File.Copy(ScrollIconLocationTextBox.Text, ScrollIconFilePath, True)

                        My.Settings.ScrollLockIconURL = ScrollIconFilePath
                        MainForm.ScrollLockTray.Icon = New Icon(My.Settings.ScrollLockIconURL, New Size(16, 16))

                        Dim ScrollIconFileInfo As New FileInfo(ScrollIconFilePath)
                        ScrollIconFileInfo.Attributes = FileAttributes.Hidden

                        My.Settings.Save()
                    End If
                End If
            Else
                If File.Exists(ScrollIconLocationTextBox.Text) = True Then
                    ScrollIconFileName = Path.GetFileName(ScrollIconLocationTextBox.Text)

                    ScrollIconFilePath = Application.StartupPath & "\LockieScrollLock.ico"
                    File.Copy(ScrollIconLocationTextBox.Text, ScrollIconFilePath, True)

                    My.Settings.ScrollLockIconURL = ScrollIconFilePath
                    MainForm.ScrollLockTray.Icon = New Icon(My.Settings.ScrollLockIconURL, New Size(16, 16))

                    Dim ScrollIconFileInfo As New FileInfo(ScrollIconFilePath)
                    ScrollIconFileInfo.Attributes = FileAttributes.Hidden

                    My.Settings.Save()
                End If
            End If
        End If
    End Sub

    Private Sub NumLockIconDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumLockIconDialog.FileOk
        Try
            NumIconLocationTextBox.Text = NumLockIconDialog.FileName
            NumLockIconPreview.Image = System.Drawing.Image.FromFile(NumIconLocationTextBox.Text)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Lockie cannot open the file specified." & vbCrLf & vbCrLf & "The icon (.ico) file" & " " & NumLockIconDialog.FileName & " " & "is invalid." & vbCrLf & vbCrLf & ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End Try
    End Sub

    Private Sub CapsLockIconDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CapsLockIconDialog.FileOk
        Try
            CapsIconLocationTextBox.Text = CapsLockIconDialog.FileName
            CapsLockIconPreview.Image = System.Drawing.Image.FromFile(CapsIconLocationTextBox.Text)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Lockie cannot open the file specified." & vbCrLf & vbCrLf & "The icon (.ico) file" & " " & CapsLockIconDialog.FileName & " " & "is invalid." & vbCrLf & vbCrLf & ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End Try
    End Sub

    Private Sub ScrollLockIconDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ScrollLockIconDialog.FileOk
        Try
            ScrollIconLocationTextBox.Text = ScrollLockIconDialog.FileName
            ScrollLockIconPreview.Image = System.Drawing.Image.FromFile(ScrollIconLocationTextBox.Text)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Lockie cannot open the file specified." & vbCrLf & vbCrLf & "The icon (.ico) file" & " " & ScrollLockIconDialog.FileName & " " & "is invalid." & vbCrLf & vbCrLf & ex.Message.ToString, "Lockie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End Try
    End Sub

    Private Sub FrmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        NumIconLocationTextBox.Text = String.Empty
        CapsIconLocationTextBox.Text = String.Empty
        ScrollIconLocationTextBox.Text = String.Empty

        NumLockIconDialog.FileName = String.Empty
        CapsLockIconDialog.FileName = String.Empty
        ScrollLockIconDialog.FileName = String.Empty

        NumLockIconPreview.Image = Nothing
        CapsLockIconPreview.Image = Nothing
        ScrollLockIconPreview.Image = Nothing
    End Sub

    Private Sub NumLockBrowseButton_Click(sender As Object, e As EventArgs) Handles NumLockBrowseButton.Click
        NumLockIconDialog.ShowDialog()
    End Sub

    Private Sub CapsLockBrowseButton_Click(sender As Object, e As EventArgs) Handles CapsLockBrowseButton.Click
        CapsLockIconDialog.ShowDialog()
    End Sub

    Private Sub ScrollLockBrowseButton_Click(sender As Object, e As EventArgs) Handles ScrollLockBrowseButton.Click
        ScrollLockIconDialog.ShowDialog()
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click

        Select Case MessageBox.Show("Default settings for Tray Icons will be restored." & vbCrLf & "All custom Tray Icons will be removed." & vbCrLf & vbCrLf & "Continue?", "Lockie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case Windows.Forms.DialogResult.Yes
                If Not My.Settings.NumLockIconURL = Nothing Then
                    If File.Exists(My.Settings.NumLockIconURL) = True Then
                        MainForm.NumLockTray.Icon = My.Resources.LockieNumLock
                        File.Delete(My.Settings.NumLockIconURL)
                        My.Settings.NumLockIconURL = Nothing
                    End If
                End If

                If Not My.Settings.CapsLockIconURL = Nothing Then
                    If File.Exists(My.Settings.CapsLockIconURL) = True Then
                        MainForm.CapsLockTray.Icon = My.Resources.LockieCapsLock
                        File.Delete(My.Settings.CapsLockIconURL)
                        My.Settings.CapsLockIconURL = Nothing
                    End If
                End If

                If Not My.Settings.ScrollLockIconURL = Nothing Then
                    If File.Exists(My.Settings.ScrollLockIconURL) = True Then
                        MainForm.ScrollLockTray.Icon = My.Resources.LockieScrollLock
                        File.Delete(My.Settings.ScrollLockIconURL)
                        My.Settings.ScrollLockIconURL = Nothing
                    End If
                End If

                LockieTrayNotifyCheckBox.CheckState = CheckState.Unchecked
                My.Settings.LockieTray = False

                My.Settings.Save()
                Me.Close()
                Exit Sub

            Case Windows.Forms.DialogResult.No
                'Cancel the form closing event
                Exit Sub
        End Select
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.LockieTray = True Then
            LockieTrayNotifyCheckBox.CheckState = CheckState.Unchecked
        Else
            LockieTrayNotifyCheckBox.CheckState = CheckState.Checked
        End If

        CapsLockBrowseButton.Select()
    End Sub

    Private Sub RefreshNotificationAreaIconsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RefreshNotificationAreaIconsLinkLabel.LinkClicked
        Dim BinaryData As Byte() = {0}

        Try

            Select Case MessageBox.Show("You must restart your computer to apply these settings. Before restarting, please save any open files and close all programs. Do you want to restart your computer now?", "Lockie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes

                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).DeleteValue("IconStreams")
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).DeleteValue("PastIconsStream")

                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("IconStreams", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("PastIconsStream", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)

                    MainForm.Restarter.Enabled = True
                    MainForm.Restarter.Start()

                    System.Diagnostics.Process.Start("shutdown.exe", "-f -r -t 60")

                Case Windows.Forms.DialogResult.No
                    'Cancel the form closing event
                    MainForm.RestartRequired = True
                    Exit Sub
            End Select

        Catch ex As Exception

            Select Case MessageBox.Show("You must restart your computer to apply these settings. Before restarting, please save any open files and close all programs. Do you want to restart your computer now?", "Lockie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Case Windows.Forms.DialogResult.Yes
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("IconStreams", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\TrayNotify", True).SetValue("PastIconsStream", BinaryData, Microsoft.Win32.RegistryValueKind.Binary)

                    MainForm.Restarter.Enabled = True
                    MainForm.Restarter.Start()

                    System.Diagnostics.Process.Start("shutdown.exe", "-f -r -t 60")


                Case Windows.Forms.DialogResult.No
                    'Cancel the form closing event
                    MainForm.RestartRequired = True
                    Exit Sub
            End Select
        End Try
    End Sub

    Private Sub ManageNotificationAreaIconsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ManageNotificationAreaIconsLinkLabel.LinkClicked
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
End Class
