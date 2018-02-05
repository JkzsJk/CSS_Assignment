<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.username_cbbox = New System.Windows.Forms.ComboBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Logo_pic = New System.Windows.Forms.PictureBox()
        CType(Me.Logo_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 28.08791!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 323)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 84)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Imperial Golf Club Malaysia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 22.15385!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 448)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 68)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 22.15385!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 546)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 68)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password:"
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(610, 567)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.password_txt.Multiline = True
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(380, 37)
        Me.password_txt.TabIndex = 1
        '
        'username_cbbox
        '
        Me.username_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.username_cbbox.FormattingEnabled = True
        Me.username_cbbox.Location = New System.Drawing.Point(610, 469)
        Me.username_cbbox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.username_cbbox.Name = "username_cbbox"
        Me.username_cbbox.Size = New System.Drawing.Size(380, 33)
        Me.username_cbbox.TabIndex = 4
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(396, 663)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(212, 88)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(782, 663)
        Me.quit_btn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(212, 88)
        Me.quit_btn.TabIndex = 6
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.Location = New System.Drawing.Point(1226, 37)
        Me.currentTime_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(59, 25)
        Me.currentTime_lbl.TabIndex = 28
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.Location = New System.Drawing.Point(1098, 37)
        Me.currentDate_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(57, 25)
        Me.currentDate_lbl.TabIndex = 27
        Me.currentDate_lbl.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Logo_pic
        '
        Me.Logo_pic.Image = Global.CSS_ASSIGNMENT.My.Resources.Resources.Logo_picture
        Me.Logo_pic.Location = New System.Drawing.Point(542, 10)
        Me.Logo_pic.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Logo_pic.Name = "Logo_pic"
        Me.Logo_pic.Size = New System.Drawing.Size(338, 308)
        Me.Logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_pic.TabIndex = 29
        Me.Logo_pic.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 800)
        Me.Controls.Add(Me.Logo_pic)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.username_cbbox)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Golf Club Membership Management System"
        CType(Me.Logo_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents username_cbbox As System.Windows.Forms.ComboBox
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents quit_btn As System.Windows.Forms.Button
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Logo_pic As System.Windows.Forms.PictureBox

End Class
