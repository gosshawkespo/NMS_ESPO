<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseEntry))
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.txtBaseDescription = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPowerUsed = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtImage2SizeBytes = New System.Windows.Forms.TextBox()
        Me.txtImageSizeBytes = New System.Windows.Forms.TextBox()
        Me.txtImage2SizeKilobytes = New System.Windows.Forms.TextBox()
        Me.txtImageSizeKilobytes = New System.Windows.Forms.TextBox()
        Me.btnRemovePart = New System.Windows.Forms.Button()
        Me.btnAddPart = New System.Windows.Forms.Button()
        Me.dgvBaseParts = New System.Windows.Forms.DataGridView()
        Me.txtImage2Filename = New System.Windows.Forms.TextBox()
        Me.txtImage2Ext = New System.Windows.Forms.TextBox()
        Me.pbBasePic2 = New System.Windows.Forms.PictureBox()
        Me.txtDiscoveredBy = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNewBaseName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBaseLatitude = New System.Windows.Forms.TextBox()
        Me.txtBaseLongitude = New System.Windows.Forms.TextBox()
        Me.txtImageEXT = New System.Windows.Forms.TextBox()
        Me.txtImageFilename = New System.Windows.Forms.TextBox()
        Me.pbBasePic1 = New System.Windows.Forms.PictureBox()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.imgCalendar_SelectDiscoveryDate = New System.Windows.Forms.PictureBox()
        Me.txtNumRows = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDefault = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiscoveryDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBaseSize = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPowerToBase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBaseID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResourceCoords = New System.Windows.Forms.Label()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtOriginalBaseName = New System.Windows.Forms.TextBox()
        Me.lblResourceName = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnImportPicture2 = New System.Windows.Forms.Button()
        Me.btnImportPicture = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlEntry.SuspendLayout()
        CType(Me.dgvBaseParts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBasePic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBasePic1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlEntry.Controls.Add(Me.txtBaseDescription)
        Me.pnlEntry.Controls.Add(Me.Label16)
        Me.pnlEntry.Controls.Add(Me.txtPowerUsed)
        Me.pnlEntry.Controls.Add(Me.Label15)
        Me.pnlEntry.Controls.Add(Me.txtImage2SizeBytes)
        Me.pnlEntry.Controls.Add(Me.txtImageSizeBytes)
        Me.pnlEntry.Controls.Add(Me.txtImage2SizeKilobytes)
        Me.pnlEntry.Controls.Add(Me.txtImageSizeKilobytes)
        Me.pnlEntry.Controls.Add(Me.btnRemovePart)
        Me.pnlEntry.Controls.Add(Me.btnAddPart)
        Me.pnlEntry.Controls.Add(Me.dgvBaseParts)
        Me.pnlEntry.Controls.Add(Me.txtImage2Filename)
        Me.pnlEntry.Controls.Add(Me.txtImage2Ext)
        Me.pnlEntry.Controls.Add(Me.pbBasePic2)
        Me.pnlEntry.Controls.Add(Me.txtDiscoveredBy)
        Me.pnlEntry.Controls.Add(Me.Label14)
        Me.pnlEntry.Controls.Add(Me.txtNewBaseName)
        Me.pnlEntry.Controls.Add(Me.Label9)
        Me.pnlEntry.Controls.Add(Me.Label12)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.txtBaseLatitude)
        Me.pnlEntry.Controls.Add(Me.txtBaseLongitude)
        Me.pnlEntry.Controls.Add(Me.txtImageEXT)
        Me.pnlEntry.Controls.Add(Me.txtImageFilename)
        Me.pnlEntry.Controls.Add(Me.pbBasePic1)
        Me.pnlEntry.Controls.Add(Me.txtLastUpdated)
        Me.pnlEntry.Controls.Add(Me.Label13)
        Me.pnlEntry.Controls.Add(Me.imgCalendar_SelectDiscoveryDate)
        Me.pnlEntry.Controls.Add(Me.txtNumRows)
        Me.pnlEntry.Controls.Add(Me.Label11)
        Me.pnlEntry.Controls.Add(Me.txtDefault)
        Me.pnlEntry.Controls.Add(Me.Label10)
        Me.pnlEntry.Controls.Add(Me.txtDiscoveryDate)
        Me.pnlEntry.Controls.Add(Me.Label8)
        Me.pnlEntry.Controls.Add(Me.txtNotes)
        Me.pnlEntry.Controls.Add(Me.Label7)
        Me.pnlEntry.Controls.Add(Me.Label6)
        Me.pnlEntry.Controls.Add(Me.txtBaseSize)
        Me.pnlEntry.Controls.Add(Me.Label5)
        Me.pnlEntry.Controls.Add(Me.txtPowerToBase)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.txtBaseID)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.lblResourceCoords)
        Me.pnlEntry.Controls.Add(Me.txtPlanetID)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.txtAccountID)
        Me.pnlEntry.Controls.Add(Me.lblAccountID)
        Me.pnlEntry.Controls.Add(Me.txtOriginalBaseName)
        Me.pnlEntry.Controls.Add(Me.lblResourceName)
        Me.pnlEntry.ForeColor = System.Drawing.Color.Transparent
        Me.pnlEntry.Location = New System.Drawing.Point(1, 2)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(1078, 752)
        Me.pnlEntry.TabIndex = 16
        '
        'txtBaseDescription
        '
        Me.txtBaseDescription.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBaseDescription.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseDescription.ForeColor = System.Drawing.Color.Black
        Me.txtBaseDescription.Location = New System.Drawing.Point(6, 520)
        Me.txtBaseDescription.Multiline = True
        Me.txtBaseDescription.Name = "txtBaseDescription"
        Me.txtBaseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBaseDescription.Size = New System.Drawing.Size(1064, 86)
        Me.txtBaseDescription.TabIndex = 165
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Turquoise
        Me.Label16.Location = New System.Drawing.Point(7, 495)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 19)
        Me.Label16.TabIndex = 166
        Me.Label16.Text = "Base Description:"
        '
        'txtPowerUsed
        '
        Me.txtPowerUsed.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPowerUsed.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerUsed.ForeColor = System.Drawing.Color.Black
        Me.txtPowerUsed.Location = New System.Drawing.Point(352, 214)
        Me.txtPowerUsed.Name = "txtPowerUsed"
        Me.txtPowerUsed.Size = New System.Drawing.Size(131, 23)
        Me.txtPowerUsed.TabIndex = 163
        Me.txtPowerUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Turquoise
        Me.Label15.Location = New System.Drawing.Point(353, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 19)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "Total Power Used"
        '
        'txtImage2SizeBytes
        '
        Me.txtImage2SizeBytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImage2SizeBytes.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage2SizeBytes.ForeColor = System.Drawing.Color.Black
        Me.txtImage2SizeBytes.Location = New System.Drawing.Point(909, 462)
        Me.txtImage2SizeBytes.Name = "txtImage2SizeBytes"
        Me.txtImage2SizeBytes.ReadOnly = True
        Me.txtImage2SizeBytes.Size = New System.Drawing.Size(105, 23)
        Me.txtImage2SizeBytes.TabIndex = 162
        '
        'txtImageSizeBytes
        '
        Me.txtImageSizeBytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageSizeBytes.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageSizeBytes.ForeColor = System.Drawing.Color.Black
        Me.txtImageSizeBytes.Location = New System.Drawing.Point(909, 436)
        Me.txtImageSizeBytes.Name = "txtImageSizeBytes"
        Me.txtImageSizeBytes.ReadOnly = True
        Me.txtImageSizeBytes.Size = New System.Drawing.Size(105, 23)
        Me.txtImageSizeBytes.TabIndex = 161
        '
        'txtImage2SizeKilobytes
        '
        Me.txtImage2SizeKilobytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImage2SizeKilobytes.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage2SizeKilobytes.ForeColor = System.Drawing.Color.Black
        Me.txtImage2SizeKilobytes.Location = New System.Drawing.Point(1020, 462)
        Me.txtImage2SizeKilobytes.Name = "txtImage2SizeKilobytes"
        Me.txtImage2SizeKilobytes.ReadOnly = True
        Me.txtImage2SizeKilobytes.Size = New System.Drawing.Size(50, 23)
        Me.txtImage2SizeKilobytes.TabIndex = 160
        Me.txtImage2SizeKilobytes.Text = "k"
        '
        'txtImageSizeKilobytes
        '
        Me.txtImageSizeKilobytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageSizeKilobytes.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageSizeKilobytes.ForeColor = System.Drawing.Color.Black
        Me.txtImageSizeKilobytes.Location = New System.Drawing.Point(1020, 436)
        Me.txtImageSizeKilobytes.Name = "txtImageSizeKilobytes"
        Me.txtImageSizeKilobytes.ReadOnly = True
        Me.txtImageSizeKilobytes.Size = New System.Drawing.Size(50, 23)
        Me.txtImageSizeKilobytes.TabIndex = 159
        Me.txtImageSizeKilobytes.Text = "k"
        '
        'btnRemovePart
        '
        Me.btnRemovePart.BackColor = System.Drawing.Color.Transparent
        Me.btnRemovePart.BackgroundImage = CType(resources.GetObject("btnRemovePart.BackgroundImage"), System.Drawing.Image)
        Me.btnRemovePart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemovePart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemovePart.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePart.Location = New System.Drawing.Point(752, 245)
        Me.btnRemovePart.Name = "btnRemovePart"
        Me.btnRemovePart.Size = New System.Drawing.Size(75, 32)
        Me.btnRemovePart.TabIndex = 158
        Me.btnRemovePart.UseVisualStyleBackColor = False
        '
        'btnAddPart
        '
        Me.btnAddPart.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPart.BackgroundImage = CType(resources.GetObject("btnAddPart.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddPart.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPart.Location = New System.Drawing.Point(630, 245)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(75, 32)
        Me.btnAddPart.TabIndex = 157
        Me.btnAddPart.UseVisualStyleBackColor = False
        '
        'dgvBaseParts
        '
        Me.dgvBaseParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaseParts.Location = New System.Drawing.Point(530, 282)
        Me.dgvBaseParts.Name = "dgvBaseParts"
        Me.dgvBaseParts.Size = New System.Drawing.Size(540, 150)
        Me.dgvBaseParts.TabIndex = 156
        '
        'txtImage2Filename
        '
        Me.txtImage2Filename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImage2Filename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage2Filename.ForeColor = System.Drawing.Color.Black
        Me.txtImage2Filename.Location = New System.Drawing.Point(6, 464)
        Me.txtImage2Filename.Name = "txtImage2Filename"
        Me.txtImage2Filename.ReadOnly = True
        Me.txtImage2Filename.Size = New System.Drawing.Size(897, 20)
        Me.txtImage2Filename.TabIndex = 155
        '
        'txtImage2Ext
        '
        Me.txtImage2Ext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImage2Ext.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage2Ext.ForeColor = System.Drawing.Color.Black
        Me.txtImage2Ext.Location = New System.Drawing.Point(185, 409)
        Me.txtImage2Ext.Name = "txtImage2Ext"
        Me.txtImage2Ext.ReadOnly = True
        Me.txtImage2Ext.Size = New System.Drawing.Size(150, 23)
        Me.txtImage2Ext.TabIndex = 154
        '
        'pbBasePic2
        '
        Me.pbBasePic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBasePic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBasePic2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbBasePic2.Location = New System.Drawing.Point(185, 253)
        Me.pbBasePic2.Name = "pbBasePic2"
        Me.pbBasePic2.Size = New System.Drawing.Size(150, 150)
        Me.pbBasePic2.TabIndex = 153
        Me.pbBasePic2.TabStop = False
        '
        'txtDiscoveredBy
        '
        Me.txtDiscoveredBy.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtDiscoveredBy.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(854, 214)
        Me.txtDiscoveredBy.Name = "txtDiscoveredBy"
        Me.txtDiscoveredBy.Size = New System.Drawing.Size(216, 23)
        Me.txtDiscoveredBy.TabIndex = 152
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Turquoise
        Me.Label14.Location = New System.Drawing.Point(856, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 19)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Discovered By;"
        '
        'txtNewBaseName
        '
        Me.txtNewBaseName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNewBaseName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewBaseName.ForeColor = System.Drawing.Color.Black
        Me.txtNewBaseName.Location = New System.Drawing.Point(6, 131)
        Me.txtNewBaseName.Name = "txtNewBaseName"
        Me.txtNewBaseName.Size = New System.Drawing.Size(821, 32)
        Me.txtNewBaseName.TabIndex = 148
        Me.txtNewBaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Turquoise
        Me.Label9.Location = New System.Drawing.Point(7, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Renamed As:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Turquoise
        Me.Label12.Location = New System.Drawing.Point(77, 192)
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
        Me.Label2.Location = New System.Drawing.Point(7, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Base Coords:"
        '
        'txtBaseLatitude
        '
        Me.txtBaseLatitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBaseLatitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseLatitude.ForeColor = System.Drawing.Color.Black
        Me.txtBaseLatitude.Location = New System.Drawing.Point(75, 214)
        Me.txtBaseLatitude.Name = "txtBaseLatitude"
        Me.txtBaseLatitude.Size = New System.Drawing.Size(66, 23)
        Me.txtBaseLatitude.TabIndex = 3
        Me.txtBaseLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBaseLongitude
        '
        Me.txtBaseLongitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBaseLongitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseLongitude.ForeColor = System.Drawing.Color.Black
        Me.txtBaseLongitude.Location = New System.Drawing.Point(6, 214)
        Me.txtBaseLongitude.Name = "txtBaseLongitude"
        Me.txtBaseLongitude.Size = New System.Drawing.Size(66, 23)
        Me.txtBaseLongitude.TabIndex = 2
        Me.txtBaseLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImageEXT
        '
        Me.txtImageEXT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageEXT.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageEXT.ForeColor = System.Drawing.Color.Black
        Me.txtImageEXT.Location = New System.Drawing.Point(6, 409)
        Me.txtImageEXT.Name = "txtImageEXT"
        Me.txtImageEXT.ReadOnly = True
        Me.txtImageEXT.Size = New System.Drawing.Size(150, 23)
        Me.txtImageEXT.TabIndex = 14
        '
        'txtImageFilename
        '
        Me.txtImageFilename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageFilename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageFilename.ForeColor = System.Drawing.Color.Black
        Me.txtImageFilename.Location = New System.Drawing.Point(6, 438)
        Me.txtImageFilename.Name = "txtImageFilename"
        Me.txtImageFilename.ReadOnly = True
        Me.txtImageFilename.Size = New System.Drawing.Size(897, 20)
        Me.txtImageFilename.TabIndex = 13
        '
        'pbBasePic1
        '
        Me.pbBasePic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBasePic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBasePic1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbBasePic1.Location = New System.Drawing.Point(6, 253)
        Me.pbBasePic1.Name = "pbBasePic1"
        Me.pbBasePic1.Size = New System.Drawing.Size(150, 150)
        Me.pbBasePic1.TabIndex = 145
        Me.pbBasePic1.TabStop = False
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastUpdated.BackColor = System.Drawing.Color.MediumBlue
        Me.txtLastUpdated.Enabled = False
        Me.txtLastUpdated.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.Color.Aqua
        Me.txtLastUpdated.Location = New System.Drawing.Point(664, 12)
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
        Me.Label13.Location = New System.Drawing.Point(558, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 19)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "Last Updated:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgCalendar_SelectDiscoveryDate
        '
        Me.imgCalendar_SelectDiscoveryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgCalendar_SelectDiscoveryDate.Image = CType(resources.GetObject("imgCalendar_SelectDiscoveryDate.Image"), System.Drawing.Image)
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(993, 123)
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
        Me.txtNumRows.Location = New System.Drawing.Point(876, 9)
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
        Me.Label11.Location = New System.Drawing.Point(822, 9)
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
        Me.txtDefault.Location = New System.Drawing.Point(854, 71)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(120, 23)
        Me.txtDefault.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Turquoise
        Me.Label10.Location = New System.Drawing.Point(856, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Default:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDiscoveryDate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(854, 131)
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
        Me.Label8.Location = New System.Drawing.Point(856, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Discovery Date:"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.Black
        Me.txtNotes.Location = New System.Drawing.Point(6, 640)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(1064, 102)
        Me.txtNotes.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Turquoise
        Me.Label7.Location = New System.Drawing.Point(7, 615)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Notes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Turquoise
        Me.Label6.Location = New System.Drawing.Point(531, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Parts Used:"
        '
        'txtBaseSize
        '
        Me.txtBaseSize.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBaseSize.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseSize.ForeColor = System.Drawing.Color.Black
        Me.txtBaseSize.Location = New System.Drawing.Point(530, 214)
        Me.txtBaseSize.Name = "txtBaseSize"
        Me.txtBaseSize.Size = New System.Drawing.Size(120, 23)
        Me.txtBaseSize.TabIndex = 5
        Me.txtBaseSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Turquoise
        Me.Label5.Location = New System.Drawing.Point(531, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Base Size:"
        '
        'txtPowerToBase
        '
        Me.txtPowerToBase.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPowerToBase.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPowerToBase.ForeColor = System.Drawing.Color.Black
        Me.txtPowerToBase.Location = New System.Drawing.Point(185, 214)
        Me.txtPowerToBase.Name = "txtPowerToBase"
        Me.txtPowerToBase.Size = New System.Drawing.Size(150, 23)
        Me.txtPowerToBase.TabIndex = 4
        Me.txtPowerToBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.Location = New System.Drawing.Point(186, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total Power To Base"
        '
        'txtBaseID
        '
        Me.txtBaseID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBaseID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtBaseID.Enabled = False
        Me.txtBaseID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseID.ForeColor = System.Drawing.Color.Aqua
        Me.txtBaseID.Location = New System.Drawing.Point(154, 9)
        Me.txtBaseID.Name = "txtBaseID"
        Me.txtBaseID.ReadOnly = True
        Me.txtBaseID.Size = New System.Drawing.Size(70, 23)
        Me.txtBaseID.TabIndex = 1
        Me.txtBaseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(128, 12)
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
        Me.lblResourceCoords.Location = New System.Drawing.Point(7, 191)
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
        Me.txtPlanetID.Location = New System.Drawing.Point(470, 9)
        Me.txtPlanetID.Name = "txtPlanetID"
        Me.txtPlanetID.ReadOnly = True
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
        Me.Label1.Location = New System.Drawing.Point(399, 9)
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
        Me.txtAccountID.Location = New System.Drawing.Point(312, 9)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.ReadOnly = True
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
        Me.lblAccountID.Location = New System.Drawing.Point(231, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(85, 19)
        Me.lblAccountID.TabIndex = 6
        Me.lblAccountID.Text = "AccountID:"
        '
        'txtOriginalBaseName
        '
        Me.txtOriginalBaseName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtOriginalBaseName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalBaseName.ForeColor = System.Drawing.Color.Black
        Me.txtOriginalBaseName.Location = New System.Drawing.Point(6, 71)
        Me.txtOriginalBaseName.Name = "txtOriginalBaseName"
        Me.txtOriginalBaseName.Size = New System.Drawing.Size(821, 32)
        Me.txtOriginalBaseName.TabIndex = 1
        Me.txtOriginalBaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResourceName
        '
        Me.lblResourceName.AutoSize = True
        Me.lblResourceName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceName.ForeColor = System.Drawing.Color.Turquoise
        Me.lblResourceName.Location = New System.Drawing.Point(7, 49)
        Me.lblResourceName.Name = "lblResourceName"
        Me.lblResourceName.Size = New System.Drawing.Size(190, 19)
        Me.lblResourceName.TabIndex = 3
        Me.lblResourceName.Text = "Enter Original Base Name:"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlButtons.Controls.Add(Me.btnImportPicture2)
        Me.pnlButtons.Controls.Add(Me.btnImportPicture)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnSAVE)
        Me.pnlButtons.ForeColor = System.Drawing.Color.Black
        Me.pnlButtons.Location = New System.Drawing.Point(1, 754)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1080, 44)
        Me.pnlButtons.TabIndex = 24
        '
        'btnImportPicture2
        '
        Me.btnImportPicture2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportPicture2.BackgroundImage = CType(resources.GetObject("btnImportPicture2.BackgroundImage"), System.Drawing.Image)
        Me.btnImportPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportPicture2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportPicture2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportPicture2.Location = New System.Drawing.Point(221, 7)
        Me.btnImportPicture2.Name = "btnImportPicture2"
        Me.btnImportPicture2.Size = New System.Drawing.Size(75, 32)
        Me.btnImportPicture2.TabIndex = 19
        Me.btnImportPicture2.UseVisualStyleBackColor = True
        '
        'btnImportPicture
        '
        Me.btnImportPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportPicture.BackgroundImage = CType(resources.GetObject("btnImportPicture.BackgroundImage"), System.Drawing.Image)
        Me.btnImportPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportPicture.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportPicture.Location = New System.Drawing.Point(37, 7)
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
        Me.btnClose.Location = New System.Drawing.Point(682, 6)
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
        Me.btnSAVE.Location = New System.Drawing.Point(521, 7)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 32)
        Me.btnSAVE.TabIndex = 17
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'frmBaseEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1081, 800)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlEntry)
        Me.Name = "frmBaseEntry"
        Me.Text = "Base Entry"
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.dgvBaseParts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBasePic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBasePic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEntry As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBaseLatitude As TextBox
    Friend WithEvents txtBaseLongitude As TextBox
    Friend WithEvents txtImageEXT As TextBox
    Friend WithEvents txtImageFilename As TextBox
    Friend WithEvents pbBasePic1 As PictureBox
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents imgCalendar_SelectDiscoveryDate As PictureBox
    Friend WithEvents txtNumRows As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDefault As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDiscoveryDate As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBaseSize As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPowerToBase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBaseID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResourceCoords As Label
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtOriginalBaseName As TextBox
    Friend WithEvents lblResourceName As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnImportPicture As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtNewBaseName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDiscoveredBy As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtImage2Filename As TextBox
    Friend WithEvents txtImage2Ext As TextBox
    Friend WithEvents pbBasePic2 As PictureBox
    Friend WithEvents btnRemovePart As Button
    Friend WithEvents btnAddPart As Button
    Friend WithEvents dgvBaseParts As DataGridView
    Friend WithEvents txtImage2SizeKilobytes As TextBox
    Friend WithEvents txtImageSizeKilobytes As TextBox
    Friend WithEvents txtImage2SizeBytes As TextBox
    Friend WithEvents txtImageSizeBytes As TextBox
    Friend WithEvents txtPowerUsed As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnImportPicture2 As Button
    Friend WithEvents txtBaseDescription As TextBox
    Friend WithEvents Label16 As Label
End Class
