<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.UserName = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_record = New System.Windows.Forms.Button()
        Me.GetDetails = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ContactNo)
        Me.GroupBox1.Controls.Add(Me.UserName)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(60, 119)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(676, 388)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'ContactNo
        '
        Me.ContactNo.Location = New System.Drawing.Point(252, 281)
        Me.ContactNo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ContactNo.Mask = "000-00000000"
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Size = New System.Drawing.Size(194, 38)
        Me.ContactNo.TabIndex = 3
        '
        'UserName
        '
        Me.UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UserName.FormattingEnabled = True
        Me.UserName.Location = New System.Drawing.Point(252, 73)
        Me.UserName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(362, 39)
        Me.UserName.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(252, 212)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(362, 38)
        Me.txtName.TabIndex = 2
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(252, 144)
        Me.Password.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(362, 38)
        Me.Password.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 287)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 34)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 34)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Name"
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(28, 35)
        Me.NewRecord.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(188, 52)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(28, 98)
        Me.Save.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(188, 52)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(28, 162)
        Me.Delete.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(188, 52)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update_record
        '
        Me.Update_record.Enabled = False
        Me.Update_record.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_record.Location = New System.Drawing.Point(28, 225)
        Me.Update_record.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Update_record.Name = "Update_record"
        Me.Update_record.Size = New System.Drawing.Size(188, 52)
        Me.Update_record.TabIndex = 3
        Me.Update_record.Text = "&Update"
        Me.Update_record.UseVisualStyleBackColor = True
        '
        'GetDetails
        '
        Me.GetDetails.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetDetails.Location = New System.Drawing.Point(28, 288)
        Me.GetDetails.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GetDetails.Name = "GetDetails"
        Me.GetDetails.Size = New System.Drawing.Size(188, 54)
        Me.GetDetails.TabIndex = 4
        Me.GetDetails.Text = "&Get Data"
        Me.GetDetails.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.GetDetails)
        Me.panel1.Controls.Add(Me.Update_record)
        Me.panel1.Controls.Add(Me.Delete)
        Me.panel1.Controls.Add(Me.Save)
        Me.panel1.Controls.Add(Me.NewRecord)
        Me.panel1.Location = New System.Drawing.Point(764, 135)
        Me.panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(244, 371)
        Me.panel1.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(64, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 43)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "User Registration"
        '
        'frmRegistration
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1060, 563)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents NewRecord As System.Windows.Forms.Button
    Public WithEvents Save As System.Windows.Forms.Button
    Public WithEvents Delete As System.Windows.Forms.Button
    Public WithEvents Update_record As System.Windows.Forms.Button
    Public WithEvents GetDetails As System.Windows.Forms.Button
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents UserName As System.Windows.Forms.ComboBox
    Friend WithEvents ContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
