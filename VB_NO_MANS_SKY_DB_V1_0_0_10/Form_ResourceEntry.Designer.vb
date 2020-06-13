<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourceEntry))
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPowerGridLatitude = New System.Windows.Forms.TextBox()
        Me.txtPowerGridLongitude = New System.Windows.Forms.TextBox()
        Me.txtResourceLatitude = New System.Windows.Forms.TextBox()
        Me.txtResourceLongitude = New System.Windows.Forms.TextBox()
        Me.txtImageEXT = New System.Windows.Forms.TextBox()
        Me.txtImageFilename = New System.Windows.Forms.TextBox()
        Me.pbResourcePic = New System.Windows.Forms.PictureBox()
        Me.rbDeposit = New System.Windows.Forms.RadioButton()
        Me.rbExtracted = New System.Windows.Forms.RadioButton()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPowerGridCoords = New System.Windows.Forms.Label()
        Me.imgCalendar_SelectDiscoveryDate = New System.Windows.Forms.PictureBox()
        Me.txtNumRows = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDefault = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAmountExtracted = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiscoveryDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResourceType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResourceYield = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPowerYield = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResourceID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResourceCoords = New System.Windows.Forms.Label()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtResourceName = New System.Windows.Forms.TextBox()
        Me.lblResourceName = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnImportPicture = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlEntry.SuspendLayout()
        CType(Me.pbResourcePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEntry
        '
        Me.pnlEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEntry.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlEntry.BackgroundImage = CType(resources.GetObject("pnlEntry.BackgroundImage"), System.Drawing.Image)
        Me.pnlEntry.Controls.Add(Me.Label14)
        Me.pnlEntry.Controls.Add(Me.Label15)
        Me.pnlEntry.Controls.Add(Me.Label12)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.txtPowerGridLatitude)
        Me.pnlEntry.Controls.Add(Me.txtPowerGridLongitude)
        Me.pnlEntry.Controls.Add(Me.txtResourceLatitude)
        Me.pnlEntry.Controls.Add(Me.txtResourceLongitude)
        Me.pnlEntry.Controls.Add(Me.txtImageEXT)
        Me.pnlEntry.Controls.Add(Me.txtImageFilename)
        Me.pnlEntry.Controls.Add(Me.pbResourcePic)
        Me.pnlEntry.Controls.Add(Me.rbDeposit)
        Me.pnlEntry.Controls.Add(Me.rbExtracted)
        Me.pnlEntry.Controls.Add(Me.txtLastUpdated)
        Me.pnlEntry.Controls.Add(Me.Label13)
        Me.pnlEntry.Controls.Add(Me.lblPowerGridCoords)
        Me.pnlEntry.Controls.Add(Me.imgCalendar_SelectDiscoveryDate)
        Me.pnlEntry.Controls.Add(Me.txtNumRows)
        Me.pnlEntry.Controls.Add(Me.Label11)
        Me.pnlEntry.Controls.Add(Me.txtDefault)
        Me.pnlEntry.Controls.Add(Me.Label10)
        Me.pnlEntry.Controls.Add(Me.CheckBox1)
        Me.pnlEntry.Controls.Add(Me.txtAmountExtracted)
        Me.pnlEntry.Controls.Add(Me.Label9)
        Me.pnlEntry.Controls.Add(Me.txtDiscoveryDate)
        Me.pnlEntry.Controls.Add(Me.Label8)
        Me.pnlEntry.Controls.Add(Me.txtNotes)
        Me.pnlEntry.Controls.Add(Me.Label7)
        Me.pnlEntry.Controls.Add(Me.txtResourceType)
        Me.pnlEntry.Controls.Add(Me.Label6)
        Me.pnlEntry.Controls.Add(Me.txtResourceYield)
        Me.pnlEntry.Controls.Add(Me.Label5)
        Me.pnlEntry.Controls.Add(Me.txtPowerYield)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.txtResourceID)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.lblResourceCoords)
        Me.pnlEntry.Controls.Add(Me.txtPlanetID)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.txtAccountID)
        Me.pnlEntry.Controls.Add(Me.lblAccountID)
        Me.pnlEntry.Controls.Add(Me.txtResourceName)
        Me.pnlEntry.Controls.Add(Me.lblResourceName)
        Me.pnlEntry.ForeColor = System.Drawing.Color.Transparent
        Me.pnlEntry.Location = New System.Drawing.Point(0, 3)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(1084, 457)
        Me.pnlEntry.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Turquoise
        Me.Label14.Location = New System.Drawing.Point(77, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 19)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "E/W"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Turquoise
        Me.Label15.Location = New System.Drawing.Point(7, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 19)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "N/S"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Turquoise
        Me.Label12.Location = New System.Drawing.Point(77, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 19)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "E/W"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Turquoise
        Me.Label2.Location = New System.Drawing.Point(7, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Resource Coords:"
        '
        'txtPowerGridLatitude
        '
        Me.txtPowerGridLatitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPowerGridLatitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerGridLatitude.ForeColor = System.Drawing.Color.Black
        Me.txtPowerGridLatitude.Location = New System.Drawing.Point(75, 255)
        Me.txtPowerGridLatitude.Name = "txtPowerGridLatitude"
        Me.txtPowerGridLatitude.Size = New System.Drawing.Size(66, 23)
        Me.txtPowerGridLatitude.TabIndex = 8
        Me.txtPowerGridLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPowerGridLongitude
        '
        Me.txtPowerGridLongitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPowerGridLongitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerGridLongitude.ForeColor = System.Drawing.Color.Black
        Me.txtPowerGridLongitude.Location = New System.Drawing.Point(6, 255)
        Me.txtPowerGridLongitude.Name = "txtPowerGridLongitude"
        Me.txtPowerGridLongitude.Size = New System.Drawing.Size(66, 23)
        Me.txtPowerGridLongitude.TabIndex = 7
        Me.txtPowerGridLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResourceLatitude
        '
        Me.txtResourceLatitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResourceLatitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceLatitude.ForeColor = System.Drawing.Color.Black
        Me.txtResourceLatitude.Location = New System.Drawing.Point(75, 161)
        Me.txtResourceLatitude.Name = "txtResourceLatitude"
        Me.txtResourceLatitude.Size = New System.Drawing.Size(66, 23)
        Me.txtResourceLatitude.TabIndex = 3
        Me.txtResourceLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResourceLongitude
        '
        Me.txtResourceLongitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResourceLongitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceLongitude.ForeColor = System.Drawing.Color.Black
        Me.txtResourceLongitude.Location = New System.Drawing.Point(6, 161)
        Me.txtResourceLongitude.Name = "txtResourceLongitude"
        Me.txtResourceLongitude.Size = New System.Drawing.Size(66, 23)
        Me.txtResourceLongitude.TabIndex = 2
        Me.txtResourceLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImageEXT
        '
        Me.txtImageEXT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageEXT.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageEXT.ForeColor = System.Drawing.Color.Black
        Me.txtImageEXT.Location = New System.Drawing.Point(849, 282)
        Me.txtImageEXT.Name = "txtImageEXT"
        Me.txtImageEXT.ReadOnly = True
        Me.txtImageEXT.Size = New System.Drawing.Size(223, 23)
        Me.txtImageEXT.TabIndex = 14
        '
        'txtImageFilename
        '
        Me.txtImageFilename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageFilename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageFilename.ForeColor = System.Drawing.Color.Black
        Me.txtImageFilename.Location = New System.Drawing.Point(6, 282)
        Me.txtImageFilename.Name = "txtImageFilename"
        Me.txtImageFilename.ReadOnly = True
        Me.txtImageFilename.Size = New System.Drawing.Size(816, 20)
        Me.txtImageFilename.TabIndex = 13
        '
        'pbResourcePic
        '
        Me.pbResourcePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbResourcePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbResourcePic.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbResourcePic.Location = New System.Drawing.Point(849, 96)
        Me.pbResourcePic.Name = "pbResourcePic"
        Me.pbResourcePic.Size = New System.Drawing.Size(223, 182)
        Me.pbResourcePic.TabIndex = 145
        Me.pbResourcePic.TabStop = False
        '
        'rbDeposit
        '
        Me.rbDeposit.AutoSize = True
        Me.rbDeposit.Location = New System.Drawing.Point(611, 184)
        Me.rbDeposit.Name = "rbDeposit"
        Me.rbDeposit.Size = New System.Drawing.Size(61, 17)
        Me.rbDeposit.TabIndex = 144
        Me.rbDeposit.TabStop = True
        Me.rbDeposit.Text = "Deposit"
        Me.rbDeposit.UseVisualStyleBackColor = True
        '
        'rbExtracted
        '
        Me.rbExtracted.AutoSize = True
        Me.rbExtracted.Location = New System.Drawing.Point(535, 185)
        Me.rbExtracted.Name = "rbExtracted"
        Me.rbExtracted.Size = New System.Drawing.Size(70, 17)
        Me.rbExtracted.TabIndex = 143
        Me.rbExtracted.TabStop = True
        Me.rbExtracted.Text = "Extracted"
        Me.rbExtracted.UseVisualStyleBackColor = True
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastUpdated.BackColor = System.Drawing.Color.MediumBlue
        Me.txtLastUpdated.Enabled = False
        Me.txtLastUpdated.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.Color.Aqua
        Me.txtLastUpdated.Location = New System.Drawing.Point(667, 12)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(142, 23)
        Me.txtLastUpdated.TabIndex = 1
        Me.txtLastUpdated.Text = "01/01/1970 23:59:00"
        Me.txtLastUpdated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Turquoise
        Me.Label13.Location = New System.Drawing.Point(561, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 19)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "Last Updated:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPowerGridCoords
        '
        Me.lblPowerGridCoords.AutoSize = True
        Me.lblPowerGridCoords.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPowerGridCoords.ForeColor = System.Drawing.Color.Turquoise
        Me.lblPowerGridCoords.Location = New System.Drawing.Point(7, 210)
        Me.lblPowerGridCoords.Name = "lblPowerGridCoords"
        Me.lblPowerGridCoords.Size = New System.Drawing.Size(146, 19)
        Me.lblPowerGridCoords.TabIndex = 139
        Me.lblPowerGridCoords.Text = "Power Grid Coords:"
        '
        'imgCalendar_SelectDiscoveryDate
        '
        Me.imgCalendar_SelectDiscoveryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgCalendar_SelectDiscoveryDate.Image = CType(resources.GetObject("imgCalendar_SelectDiscoveryDate.Image"), System.Drawing.Image)
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(324, 247)
        Me.imgCalendar_SelectDiscoveryDate.Name = "imgCalendar_SelectDiscoveryDate"
        Me.imgCalendar_SelectDiscoveryDate.Size = New System.Drawing.Size(24, 28)
        Me.imgCalendar_SelectDiscoveryDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCalendar_SelectDiscoveryDate.TabIndex = 138
        Me.imgCalendar_SelectDiscoveryDate.TabStop = False
        Me.imgCalendar_SelectDiscoveryDate.Tag = "btn7"
        '
        'txtNumRows
        '
        Me.txtNumRows.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumRows.BackColor = System.Drawing.Color.MediumBlue
        Me.txtNumRows.Enabled = False
        Me.txtNumRows.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRows.ForeColor = System.Drawing.Color.Aqua
        Me.txtNumRows.Location = New System.Drawing.Point(879, 9)
        Me.txtNumRows.Name = "txtNumRows"
        Me.txtNumRows.ReadOnly = True
        Me.txtNumRows.Size = New System.Drawing.Size(70, 23)
        Me.txtNumRows.TabIndex = 1
        Me.txtNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Turquoise
        Me.Label11.Location = New System.Drawing.Point(825, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDefault
        '
        Me.txtDefault.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtDefault.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefault.ForeColor = System.Drawing.Color.Black
        Me.txtDefault.Location = New System.Drawing.Point(626, 255)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(120, 23)
        Me.txtDefault.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Turquoise
        Me.Label10.Location = New System.Drawing.Point(629, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Default:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(543, 260)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "ALL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAmountExtracted
        '
        Me.txtAmountExtracted.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtAmountExtracted.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountExtracted.ForeColor = System.Drawing.Color.Black
        Me.txtAmountExtracted.Location = New System.Drawing.Point(388, 255)
        Me.txtAmountExtracted.Name = "txtAmountExtracted"
        Me.txtAmountExtracted.Size = New System.Drawing.Size(137, 23)
        Me.txtAmountExtracted.TabIndex = 10
        Me.txtAmountExtracted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Turquoise
        Me.Label9.Location = New System.Drawing.Point(387, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Amount Extracted:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDiscoveryDate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(185, 255)
        Me.txtDiscoveryDate.Mask = "00/00/0000 90:00"
        Me.txtDiscoveryDate.Name = "txtDiscoveryDate"
        Me.txtDiscoveryDate.Size = New System.Drawing.Size(133, 20)
        Me.txtDiscoveryDate.TabIndex = 9
        Me.txtDiscoveryDate.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Turquoise
        Me.Label8.Location = New System.Drawing.Point(190, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Discovery Date:"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.Black
        Me.txtNotes.Location = New System.Drawing.Point(6, 340)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(1066, 102)
        Me.txtNotes.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Turquoise
        Me.Label7.Location = New System.Drawing.Point(7, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Notes:"
        '
        'txtResourceType
        '
        Me.txtResourceType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResourceType.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceType.ForeColor = System.Drawing.Color.Black
        Me.txtResourceType.Location = New System.Drawing.Point(532, 161)
        Me.txtResourceType.Name = "txtResourceType"
        Me.txtResourceType.Size = New System.Drawing.Size(295, 23)
        Me.txtResourceType.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Turquoise
        Me.Label6.Location = New System.Drawing.Point(535, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Resource Type (extracted / deposit etc)"
        '
        'txtResourceYield
        '
        Me.txtResourceYield.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResourceYield.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceYield.ForeColor = System.Drawing.Color.Black
        Me.txtResourceYield.Location = New System.Drawing.Point(388, 161)
        Me.txtResourceYield.Name = "txtResourceYield"
        Me.txtResourceYield.Size = New System.Drawing.Size(120, 23)
        Me.txtResourceYield.TabIndex = 5
        Me.txtResourceYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Turquoise
        Me.Label5.Location = New System.Drawing.Point(392, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Resource Yield:"
        '
        'txtPowerYield
        '
        Me.txtPowerYield.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPowerYield.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerYield.ForeColor = System.Drawing.Color.Black
        Me.txtPowerYield.Location = New System.Drawing.Point(185, 161)
        Me.txtPowerYield.Name = "txtPowerYield"
        Me.txtPowerYield.Size = New System.Drawing.Size(184, 23)
        Me.txtPowerYield.TabIndex = 4
        Me.txtPowerYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.Location = New System.Drawing.Point(183, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Power Yield (Power Grid)"
        '
        'txtResourceID
        '
        Me.txtResourceID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtResourceID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtResourceID.Enabled = False
        Me.txtResourceID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceID.ForeColor = System.Drawing.Color.Aqua
        Me.txtResourceID.Location = New System.Drawing.Point(157, 9)
        Me.txtResourceID.Name = "txtResourceID"
        Me.txtResourceID.ReadOnly = True
        Me.txtResourceID.Size = New System.Drawing.Size(70, 23)
        Me.txtResourceID.TabIndex = 1
        Me.txtResourceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(131, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID:"
        '
        'lblResourceCoords
        '
        Me.lblResourceCoords.AutoSize = True
        Me.lblResourceCoords.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceCoords.ForeColor = System.Drawing.Color.Turquoise
        Me.lblResourceCoords.Location = New System.Drawing.Point(7, 138)
        Me.lblResourceCoords.Name = "lblResourceCoords"
        Me.lblResourceCoords.Size = New System.Drawing.Size(36, 19)
        Me.lblResourceCoords.TabIndex = 11
        Me.lblResourceCoords.Text = "N/S"
        '
        'txtPlanetID
        '
        Me.txtPlanetID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPlanetID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtPlanetID.Enabled = False
        Me.txtPlanetID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetID.ForeColor = System.Drawing.Color.Aqua
        Me.txtPlanetID.Location = New System.Drawing.Point(473, 9)
        Me.txtPlanetID.Name = "txtPlanetID"
        Me.txtPlanetID.Size = New System.Drawing.Size(70, 23)
        Me.txtPlanetID.TabIndex = 1
        Me.txtPlanetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(402, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PlanetID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAccountID
        '
        Me.txtAccountID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAccountID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtAccountID.Enabled = False
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.ForeColor = System.Drawing.Color.Aqua
        Me.txtAccountID.Location = New System.Drawing.Point(315, 9)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(70, 23)
        Me.txtAccountID.TabIndex = 1
        Me.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAccountID
        '
        Me.lblAccountID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.ForeColor = System.Drawing.Color.Turquoise
        Me.lblAccountID.Location = New System.Drawing.Point(234, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(85, 19)
        Me.lblAccountID.TabIndex = 6
        Me.lblAccountID.Text = "AccountID:"
        '
        'txtResourceName
        '
        Me.txtResourceName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtResourceName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceName.ForeColor = System.Drawing.Color.Black
        Me.txtResourceName.Location = New System.Drawing.Point(6, 71)
        Me.txtResourceName.Name = "txtResourceName"
        Me.txtResourceName.Size = New System.Drawing.Size(821, 32)
        Me.txtResourceName.TabIndex = 1
        Me.txtResourceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResourceName
        '
        Me.lblResourceName.AutoSize = True
        Me.lblResourceName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceName.ForeColor = System.Drawing.Color.Turquoise
        Me.lblResourceName.Location = New System.Drawing.Point(7, 49)
        Me.lblResourceName.Name = "lblResourceName"
        Me.lblResourceName.Size = New System.Drawing.Size(164, 19)
        Me.lblResourceName.TabIndex = 3
        Me.lblResourceName.Text = "Enter Resource Name:"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.pnlButtons.Controls.Add(Me.btnImportPicture)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnSAVE)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 465)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1084, 44)
        Me.pnlButtons.TabIndex = 23
        '
        'btnImportPicture
        '
        Me.btnImportPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportPicture.BackgroundImage = CType(resources.GetObject("btnImportPicture.BackgroundImage"), System.Drawing.Image)
        Me.btnImportPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportPicture.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportPicture.Location = New System.Drawing.Point(372, 7)
        Me.btnImportPicture.Name = "btnImportPicture"
        Me.btnImportPicture.Size = New System.Drawing.Size(75, 32)
        Me.btnImportPicture.TabIndex = 16
        Me.btnImportPicture.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(686, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 35)
        Me.btnClose.TabIndex = 18
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackgroundImage = CType(resources.GetObject("btnSAVE.BackgroundImage"), System.Drawing.Image)
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.Location = New System.Drawing.Point(525, 7)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 32)
        Me.btnSAVE.TabIndex = 17
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'frmResourceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 509)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlEntry)
        Me.MaximumSize = New System.Drawing.Size(1100, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "frmResourceEntry"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Resource Entry"
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.pbResourcePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlEntry As Panel
    Friend WithEvents txtResourceName As TextBox
    Friend WithEvents lblResourceName As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtResourceType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtResourceYield As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPowerYield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResourceID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResourceCoords As Label
    Friend WithEvents txtDiscoveryDate As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtAmountExtracted As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDefault As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNumRows As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents imgCalendar_SelectDiscoveryDate As PictureBox
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPowerGridCoords As Label
    Friend WithEvents rbDeposit As RadioButton
    Friend WithEvents rbExtracted As RadioButton
    Friend WithEvents btnImportPicture As Button
    Friend WithEvents pbResourcePic As PictureBox
    Friend WithEvents txtImageFilename As TextBox
    Friend WithEvents txtImageEXT As TextBox
    Friend WithEvents txtPowerGridLatitude As TextBox
    Friend WithEvents txtPowerGridLongitude As TextBox
    Friend WithEvents txtResourceLatitude As TextBox
    Friend WithEvents txtResourceLongitude As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
End Class
