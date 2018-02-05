<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_Address = New System.Windows.Forms.TextBox()
        Me.B_Landmark = New System.Windows.Forms.TextBox()
        Me.B_City = New System.Windows.Forms.TextBox()
        Me.B_State = New System.Windows.Forms.ComboBox()
        Me.S_State = New System.Windows.Forms.ComboBox()
        Me.S_City = New System.Windows.Forms.TextBox()
        Me.S_Landmark = New System.Windows.Forms.TextBox()
        Me.S_Address = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.S_name = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.MaskedTextBox()
        Me.B_ZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.NewRecord = New System.Windows.Forms.Button()
        Me.S_ZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtFaxNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Details"
        '
        'B_name
        '
        Me.B_name.Location = New System.Drawing.Point(346, 140)
        Me.B_name.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_name.Name = "B_name"
        Me.B_name.Size = New System.Drawing.Size(542, 30)
        Me.B_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "*Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 340)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "*City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 277)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Landmark"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 406)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 31)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "*State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(88, 473)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 31)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "*Zip/Post Code"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1314, 79)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(271, 29)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Same as Billing Address"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1018, 71)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 43)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Shipping Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1020, 662)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Distributor ID"
        '
        'B_Address
        '
        Me.B_Address.Location = New System.Drawing.Point(346, 206)
        Me.B_Address.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_Address.Name = "B_Address"
        Me.B_Address.Size = New System.Drawing.Size(542, 30)
        Me.B_Address.TabIndex = 2
        '
        'B_Landmark
        '
        Me.B_Landmark.Location = New System.Drawing.Point(346, 271)
        Me.B_Landmark.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_Landmark.Name = "B_Landmark"
        Me.B_Landmark.Size = New System.Drawing.Size(542, 30)
        Me.B_Landmark.TabIndex = 3
        '
        'B_City
        '
        Me.B_City.Location = New System.Drawing.Point(346, 335)
        Me.B_City.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_City.Name = "B_City"
        Me.B_City.Size = New System.Drawing.Size(284, 30)
        Me.B_City.TabIndex = 4
        '
        'B_State
        '
        Me.B_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.B_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.B_State.FormattingEnabled = True
        Me.B_State.Items.AddRange(New Object() {"Kuala Lumpur", "Labuan", "Putrajaya", "Johor", "Kedah", "Kelantan", "Malacca", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Penang", "Sabah", "Sarawak", "Selangor", "Terengganu"})
        Me.B_State.Location = New System.Drawing.Point(346, 398)
        Me.B_State.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_State.Name = "B_State"
        Me.B_State.Size = New System.Drawing.Size(380, 33)
        Me.B_State.TabIndex = 5
        '
        'S_State
        '
        Me.S_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.S_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.S_State.FormattingEnabled = True
        Me.S_State.Items.AddRange(New Object() {"Kuala Lumpur", "Labuan", "Putrajaya", "Johor", "Kedah", "Kelantan", "Malacca", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Penang", "Sabah", "Sarawak", "Selangor", "Terengganu"})
        Me.S_State.Location = New System.Drawing.Point(1280, 398)
        Me.S_State.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_State.Name = "S_State"
        Me.S_State.Size = New System.Drawing.Size(398, 33)
        Me.S_State.TabIndex = 13
        '
        'S_City
        '
        Me.S_City.Location = New System.Drawing.Point(1280, 335)
        Me.S_City.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_City.Name = "S_City"
        Me.S_City.Size = New System.Drawing.Size(284, 30)
        Me.S_City.TabIndex = 12
        '
        'S_Landmark
        '
        Me.S_Landmark.Location = New System.Drawing.Point(1280, 271)
        Me.S_Landmark.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_Landmark.Name = "S_Landmark"
        Me.S_Landmark.Size = New System.Drawing.Size(542, 30)
        Me.S_Landmark.TabIndex = 11
        '
        'S_Address
        '
        Me.S_Address.Location = New System.Drawing.Point(1280, 206)
        Me.S_Address.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_Address.Name = "S_Address"
        Me.S_Address.Size = New System.Drawing.Size(542, 30)
        Me.S_Address.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1022, 473)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "*Zip/Post Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1022, 406)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 31)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "*State"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1022, 277)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 31)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Landmark"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1022, 340)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 31)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "*City"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1022, 212)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 31)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "*Address"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1022, 142)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 31)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "*Name"
        '
        'S_name
        '
        Me.S_name.Location = New System.Drawing.Point(1280, 140)
        Me.S_name.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_name.Name = "S_name"
        Me.S_name.Size = New System.Drawing.Size(542, 30)
        Me.S_name.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightGray
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1020, 585)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(282, 43)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Additional Details"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1020, 731)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 31)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Phone"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1020, 796)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 31)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Email"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1016, 869)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 31)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "*Mobile No."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1020, 942)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 31)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Fax No."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1022, 1008)
        Me.Label23.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 31)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Notes"
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Location = New System.Drawing.Point(1280, 662)
        Me.txtCustomerNo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.ReadOnly = True
        Me.txtCustomerNo.Size = New System.Drawing.Size(212, 30)
        Me.txtCustomerNo.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(1280, 796)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(448, 30)
        Me.txtEmail.TabIndex = 17
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(1280, 1008)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(498, 125)
        Me.txtNotes.TabIndex = 20
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(1280, 863)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMobileNo.Mask = "000-00000000"
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(196, 30)
        Me.txtMobileNo.TabIndex = 18
        '
        'B_ZipCode
        '
        Me.B_ZipCode.Location = New System.Drawing.Point(346, 467)
        Me.B_ZipCode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.B_ZipCode.Mask = "00000"
        Me.B_ZipCode.Name = "B_ZipCode"
        Me.B_ZipCode.Size = New System.Drawing.Size(144, 30)
        Me.B_ZipCode.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.Update_Record)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Controls.Add(Me.NewRecord)
        Me.GroupBox2.Location = New System.Drawing.Point(1918, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(268, 342)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(32, 256)
        Me.Delete.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(198, 56)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Update_Record
        '
        Me.Update_Record.Enabled = False
        Me.Update_Record.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Record.Location = New System.Drawing.Point(32, 188)
        Me.Update_Record.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(198, 56)
        Me.Update_Record.TabIndex = 2
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(32, 121)
        Me.Save.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(198, 56)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NewRecord
        '
        Me.NewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRecord.Location = New System.Drawing.Point(32, 54)
        Me.NewRecord.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NewRecord.Name = "NewRecord"
        Me.NewRecord.Size = New System.Drawing.Size(198, 56)
        Me.NewRecord.TabIndex = 0
        Me.NewRecord.Text = "&New"
        Me.NewRecord.UseVisualStyleBackColor = True
        '
        'S_ZipCode
        '
        Me.S_ZipCode.Location = New System.Drawing.Point(1280, 467)
        Me.S_ZipCode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.S_ZipCode.Mask = "00000"
        Me.S_ZipCode.Name = "S_ZipCode"
        Me.S_ZipCode.Size = New System.Drawing.Size(144, 30)
        Me.S_ZipCode.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1532, 658)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 40)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(1280, 731)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(234, 30)
        Me.txtPhone.TabIndex = 16
        '
        'txtFaxNo
        '
        Me.txtFaxNo.Location = New System.Drawing.Point(1280, 937)
        Me.txtFaxNo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(234, 30)
        Me.txtFaxNo.TabIndex = 19
        '
        'frmCustomer
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(2216, 1163)
        Me.Controls.Add(Me.txtFaxNo)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.S_ZipCode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.B_ZipCode)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCustomerNo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.S_State)
        Me.Controls.Add(Me.S_City)
        Me.Controls.Add(Me.S_Landmark)
        Me.Controls.Add(Me.S_Address)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.S_name)
        Me.Controls.Add(Me.B_State)
        Me.Controls.Add(Me.B_City)
        Me.Controls.Add(Me.B_Landmark)
        Me.Controls.Add(Me.B_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_name)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Super Distributor Details"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents B_Address As System.Windows.Forms.TextBox
    Friend WithEvents B_Landmark As System.Windows.Forms.TextBox
    Friend WithEvents B_City As System.Windows.Forms.TextBox
    Friend WithEvents B_State As System.Windows.Forms.ComboBox
    Friend WithEvents S_State As System.Windows.Forms.ComboBox
    Friend WithEvents S_City As System.Windows.Forms.TextBox
    Friend WithEvents S_Landmark As System.Windows.Forms.TextBox
    Friend WithEvents S_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents S_name As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents B_ZipCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Update_Record As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NewRecord As System.Windows.Forms.Button
    Friend WithEvents S_ZipCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNo As System.Windows.Forms.TextBox
End Class
