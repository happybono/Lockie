<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.NumLockIconDialog = New System.Windows.Forms.OpenFileDialog()
        Me.CapsLockIconDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ScrollLockIconDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumIconLocationTextBox = New System.Windows.Forms.TextBox()
        Me.ScrollLockIconPreview = New System.Windows.Forms.PictureBox()
        Me.NumLockBrowseButton = New System.Windows.Forms.Button()
        Me.CapsLockIconPreview = New System.Windows.Forms.PictureBox()
        Me.CapsLockBrowseButton = New System.Windows.Forms.Button()
        Me.NumLockIconPreview = New System.Windows.Forms.PictureBox()
        Me.ScrollLockBrowseButton = New System.Windows.Forms.Button()
        Me.ScrollIconLocationTextBox = New System.Windows.Forms.TextBox()
        Me.CapsIconLocationTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LockieTrayNotifyCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefreshNotificationAreaIconsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ManageNotificationAreaIconsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ScrollLockIconPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapsLockIconPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLockIconPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Reset_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(216, 333)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(230, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(70, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "Save"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(156, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(70, 23)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Reset_Button
        '
        Me.Reset_Button.BackColor = System.Drawing.Color.Transparent
        Me.Reset_Button.Location = New System.Drawing.Point(79, 3)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(70, 23)
        Me.Reset_Button.TabIndex = 5
        Me.Reset_Button.Text = "Default"
        Me.Reset_Button.UseVisualStyleBackColor = False
        '
        'NumLockIconDialog
        '
        Me.NumLockIconDialog.DefaultExt = "*.ico"
        Me.NumLockIconDialog.Filter = "Icon Files|*.ico"
        Me.NumLockIconDialog.Title = "Num Lock Icon Customization"
        '
        'CapsLockIconDialog
        '
        Me.CapsLockIconDialog.DefaultExt = "*.ico"
        Me.CapsLockIconDialog.Filter = "Icon Files|*.ico"
        Me.CapsLockIconDialog.Title = "Caps Lock Icon Customization"
        '
        'ScrollLockIconDialog
        '
        Me.ScrollLockIconDialog.DefaultExt = "*.ico"
        Me.ScrollLockIconDialog.Filter = "Icon Files|*.ico"
        Me.ScrollLockIconDialog.Title = "Scroll Lock Icon Customization"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Customization"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(87, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "(.ico format required, 16 x 16 px. maximum.) "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(20, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Num Lock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(87, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "(.ico format required, 16 x 16 px. maximum.) "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(87, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "(.ico format required, 16 x 16 px. maximum.) "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(20, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Caps Lock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(20, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Scroll Lock"
        '
        'NumIconLocationTextBox
        '
        Me.NumIconLocationTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumIconLocationTextBox.Location = New System.Drawing.Point(23, 181)
        Me.NumIconLocationTextBox.Name = "NumIconLocationTextBox"
        Me.NumIconLocationTextBox.ReadOnly = True
        Me.NumIconLocationTextBox.Size = New System.Drawing.Size(318, 23)
        Me.NumIconLocationTextBox.TabIndex = 0
        Me.NumIconLocationTextBox.TabStop = False
        '
        'ScrollLockIconPreview
        '
        Me.ScrollLockIconPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.ScrollLockIconPreview.ErrorImage = CType(resources.GetObject("ScrollLockIconPreview.ErrorImage"), System.Drawing.Image)
        Me.ScrollLockIconPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ScrollLockIconPreview.Location = New System.Drawing.Point(346, 247)
        Me.ScrollLockIconPreview.Name = "ScrollLockIconPreview"
        Me.ScrollLockIconPreview.Size = New System.Drawing.Size(16, 16)
        Me.ScrollLockIconPreview.TabIndex = 28
        Me.ScrollLockIconPreview.TabStop = False
        '
        'NumLockBrowseButton
        '
        Me.NumLockBrowseButton.BackColor = System.Drawing.Color.Transparent
        Me.NumLockBrowseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumLockBrowseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NumLockBrowseButton.Location = New System.Drawing.Point(367, 181)
        Me.NumLockBrowseButton.Name = "NumLockBrowseButton"
        Me.NumLockBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.NumLockBrowseButton.TabIndex = 1
        Me.NumLockBrowseButton.Text = "Browse"
        Me.NumLockBrowseButton.UseVisualStyleBackColor = False
        '
        'CapsLockIconPreview
        '
        Me.CapsLockIconPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.CapsLockIconPreview.ErrorImage = CType(resources.GetObject("CapsLockIconPreview.ErrorImage"), System.Drawing.Image)
        Me.CapsLockIconPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CapsLockIconPreview.Location = New System.Drawing.Point(346, 122)
        Me.CapsLockIconPreview.Name = "CapsLockIconPreview"
        Me.CapsLockIconPreview.Size = New System.Drawing.Size(16, 16)
        Me.CapsLockIconPreview.TabIndex = 27
        Me.CapsLockIconPreview.TabStop = False
        '
        'CapsLockBrowseButton
        '
        Me.CapsLockBrowseButton.BackColor = System.Drawing.Color.Transparent
        Me.CapsLockBrowseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CapsLockBrowseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CapsLockBrowseButton.Location = New System.Drawing.Point(367, 119)
        Me.CapsLockBrowseButton.Name = "CapsLockBrowseButton"
        Me.CapsLockBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.CapsLockBrowseButton.TabIndex = 2
        Me.CapsLockBrowseButton.Text = "Browse"
        Me.CapsLockBrowseButton.UseVisualStyleBackColor = False
        '
        'NumLockIconPreview
        '
        Me.NumLockIconPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.NumLockIconPreview.ErrorImage = CType(resources.GetObject("NumLockIconPreview.ErrorImage"), System.Drawing.Image)
        Me.NumLockIconPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NumLockIconPreview.Location = New System.Drawing.Point(346, 184)
        Me.NumLockIconPreview.Name = "NumLockIconPreview"
        Me.NumLockIconPreview.Size = New System.Drawing.Size(16, 16)
        Me.NumLockIconPreview.TabIndex = 26
        Me.NumLockIconPreview.TabStop = False
        '
        'ScrollLockBrowseButton
        '
        Me.ScrollLockBrowseButton.BackColor = System.Drawing.Color.Transparent
        Me.ScrollLockBrowseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ScrollLockBrowseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ScrollLockBrowseButton.Location = New System.Drawing.Point(367, 243)
        Me.ScrollLockBrowseButton.Name = "ScrollLockBrowseButton"
        Me.ScrollLockBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.ScrollLockBrowseButton.TabIndex = 3
        Me.ScrollLockBrowseButton.Text = "Browse"
        Me.ScrollLockBrowseButton.UseVisualStyleBackColor = False
        '
        'ScrollIconLocationTextBox
        '
        Me.ScrollIconLocationTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ScrollIconLocationTextBox.Location = New System.Drawing.Point(23, 243)
        Me.ScrollIconLocationTextBox.Name = "ScrollIconLocationTextBox"
        Me.ScrollIconLocationTextBox.ReadOnly = True
        Me.ScrollIconLocationTextBox.Size = New System.Drawing.Size(318, 23)
        Me.ScrollIconLocationTextBox.TabIndex = 0
        Me.ScrollIconLocationTextBox.TabStop = False
        '
        'CapsIconLocationTextBox
        '
        Me.CapsIconLocationTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CapsIconLocationTextBox.Location = New System.Drawing.Point(23, 119)
        Me.CapsIconLocationTextBox.Name = "CapsIconLocationTextBox"
        Me.CapsIconLocationTextBox.ReadOnly = True
        Me.CapsIconLocationTextBox.Size = New System.Drawing.Size(318, 23)
        Me.CapsIconLocationTextBox.TabIndex = 0
        Me.CapsIconLocationTextBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 3)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LockieTrayNotifyCheckBox
        '
        Me.LockieTrayNotifyCheckBox.AutoSize = True
        Me.LockieTrayNotifyCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockieTrayNotifyCheckBox.Location = New System.Drawing.Point(23, 281)
        Me.LockieTrayNotifyCheckBox.Name = "LockieTrayNotifyCheckBox"
        Me.LockieTrayNotifyCheckBox.Size = New System.Drawing.Size(266, 19)
        Me.LockieTrayNotifyCheckBox.TabIndex = 41
        Me.LockieTrayNotifyCheckBox.Text = "Always show Lockie icon on notification area."
        Me.LockieTrayNotifyCheckBox.UseVisualStyleBackColor = True
        '
        'RefreshNotificationAreaIconsLinkLabel
        '
        Me.RefreshNotificationAreaIconsLinkLabel.AutoSize = True
        Me.RefreshNotificationAreaIconsLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshNotificationAreaIconsLinkLabel.Location = New System.Drawing.Point(45, 348)
        Me.RefreshNotificationAreaIconsLinkLabel.Name = "RefreshNotificationAreaIconsLinkLabel"
        Me.RefreshNotificationAreaIconsLinkLabel.Size = New System.Drawing.Size(164, 15)
        Me.RefreshNotificationAreaIconsLinkLabel.TabIndex = 42
        Me.RefreshNotificationAreaIconsLinkLabel.TabStop = True
        Me.RefreshNotificationAreaIconsLinkLabel.Text = "Refresh Notification Icons List"
        '
        'ManageNotificationAreaIconsLinkLabel
        '
        Me.ManageNotificationAreaIconsLinkLabel.AutoSize = True
        Me.ManageNotificationAreaIconsLinkLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageNotificationAreaIconsLinkLabel.Location = New System.Drawing.Point(45, 326)
        Me.ManageNotificationAreaIconsLinkLabel.Name = "ManageNotificationAreaIconsLinkLabel"
        Me.ManageNotificationAreaIconsLinkLabel.Size = New System.Drawing.Size(168, 15)
        Me.ManageNotificationAreaIconsLinkLabel.TabIndex = 43
        Me.ManageNotificationAreaIconsLinkLabel.TabStop = True
        Me.ManageNotificationAreaIconsLinkLabel.Text = "Manage Notification Icons List"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 324)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 345)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'FrmSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(467, 380)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ManageNotificationAreaIconsLinkLabel)
        Me.Controls.Add(Me.RefreshNotificationAreaIconsLinkLabel)
        Me.Controls.Add(Me.LockieTrayNotifyCheckBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumIconLocationTextBox)
        Me.Controls.Add(Me.ScrollLockIconPreview)
        Me.Controls.Add(Me.NumLockIconPreview)
        Me.Controls.Add(Me.ScrollLockBrowseButton)
        Me.Controls.Add(Me.ScrollIconLocationTextBox)
        Me.Controls.Add(Me.CapsIconLocationTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.NumLockBrowseButton)
        Me.Controls.Add(Me.CapsLockIconPreview)
        Me.Controls.Add(Me.CapsLockBrowseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customization"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ScrollLockIconPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapsLockIconPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLockIconPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NumLockIconDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CapsLockIconDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ScrollLockIconDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumIconLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScrollLockIconPreview As System.Windows.Forms.PictureBox
    Friend WithEvents NumLockBrowseButton As System.Windows.Forms.Button
    Friend WithEvents CapsLockIconPreview As System.Windows.Forms.PictureBox
    Friend WithEvents CapsLockBrowseButton As System.Windows.Forms.Button
    Friend WithEvents NumLockIconPreview As System.Windows.Forms.PictureBox
    Friend WithEvents ScrollLockBrowseButton As System.Windows.Forms.Button
    Friend WithEvents ScrollIconLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapsIconLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Reset_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LockieTrayNotifyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RefreshNotificationAreaIconsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ManageNotificationAreaIconsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
