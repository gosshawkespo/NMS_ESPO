<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStorageEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStorageEntry))
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comCategories = New System.Windows.Forms.ComboBox()
        Me.txtImageSizeKilobytes = New System.Windows.Forms.TextBox()
        Me.txtImageSizeBytes = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblStorageWidth = New System.Windows.Forms.Label()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.txtColumns = New System.Windows.Forms.TextBox()
        Me.txtImageFilename = New System.Windows.Forms.TextBox()
        Me.txtImageEXT = New System.Windows.Forms.TextBox()
        Me.pbStoragePic = New System.Windows.Forms.PictureBox()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.imgCalendar_SelectDiscoveryDate = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUpdated = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMAXSlots = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrefID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStorageSize = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtStorageName = New System.Windows.Forms.TextBox()
        Me.lblStorageCategory = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnImportPicture = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlEntry.SuspendLayout()
        CType(Me.pbStoragePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEntry
        '
        Me.pnlEntry.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlEntry.BackgroundImage = CType(resources.GetObject("pnlEntry.BackgroundImage"), System.Drawing.Image)
        Me.pnlEntry.Controls.Add(Me.comAccounts)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.comCategories)
        Me.pnlEntry.Controls.Add(Me.txtImageSizeKilobytes)
        Me.pnlEntry.Controls.Add(Me.txtImageSizeBytes)
        Me.pnlEntry.Controls.Add(Me.Label12)
        Me.pnlEntry.Controls.Add(Me.lblStorageWidth)
        Me.pnlEntry.Controls.Add(Me.txtRows)
        Me.pnlEntry.Controls.Add(Me.txtColumns)
        Me.pnlEntry.Controls.Add(Me.txtImageFilename)
        Me.pnlEntry.Controls.Add(Me.txtImageEXT)
        Me.pnlEntry.Controls.Add(Me.pbStoragePic)
        Me.pnlEntry.Controls.Add(Me.txtLastUpdated)
        Me.pnlEntry.Controls.Add(Me.Label13)
        Me.pnlEntry.Controls.Add(Me.imgCalendar_SelectDiscoveryDate)
        Me.pnlEntry.Controls.Add(Me.txtTotal)
        Me.pnlEntry.Controls.Add(Me.Label11)
        Me.pnlEntry.Controls.Add(Me.txtUpdated)
        Me.pnlEntry.Controls.Add(Me.Label8)
        Me.pnlEntry.Controls.Add(Me.txtNotes)
        Me.pnlEntry.Controls.Add(Me.Label7)
        Me.pnlEntry.Controls.Add(Me.txtMAXSlots)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.txtPrefID)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.lblStorageSize)
        Me.pnlEntry.Controls.Add(Me.txtUserID)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.txtAccountID)
        Me.pnlEntry.Controls.Add(Me.lblAccountID)
        Me.pnlEntry.Controls.Add(Me.txtStorageName)
        Me.pnlEntry.Controls.Add(Me.lblStorageCategory)
        Me.pnlEntry.ForeColor = System.Drawing.Color.Transparent
        Me.pnlEntry.Location = New System.Drawing.Point(2, 46)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(840, 565)
        Me.pnlEntry.TabIndex = 18
        '
        'comAccounts
        '
        Me.comAccounts.FormattingEnabled = True
        Me.comAccounts.Items.AddRange(New Object() {"Exosuit General Inventory", "Exosuit Technical Inventory", "Exosuit Cargo Inventory", "Starship General Inventory", "Starship Technical Inventory", "Exocraft General Inventory", "Storage Container"})
        Me.comAccounts.Location = New System.Drawing.Point(185, 72)
        Me.comAccounts.Name = "comAccounts"
        Me.comAccounts.Size = New System.Drawing.Size(282, 21)
        Me.comAccounts.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Turquoise
        Me.Label2.Location = New System.Drawing.Point(68, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Select Account:"
        '
        'comCategories
        '
        Me.comCategories.FormattingEnabled = True
        Me.comCategories.Items.AddRange(New Object() {"Exosuit General Inventory", "Exosuit Technical Inventory", "Exosuit Cargo Inventory", "Starship General Inventory", "Starship Technical Inventory", "Exocraft General Inventory", "Storage Container"})
        Me.comCategories.Location = New System.Drawing.Point(185, 103)
        Me.comCategories.Name = "comCategories"
        Me.comCategories.Size = New System.Drawing.Size(282, 21)
        Me.comCategories.TabIndex = 155
        '
        'txtImageSizeKilobytes
        '
        Me.txtImageSizeKilobytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageSizeKilobytes.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageSizeKilobytes.ForeColor = System.Drawing.Color.Black
        Me.txtImageSizeKilobytes.Location = New System.Drawing.Point(605, 393)
        Me.txtImageSizeKilobytes.Name = "txtImageSizeKilobytes"
        Me.txtImageSizeKilobytes.ReadOnly = True
        Me.txtImageSizeKilobytes.Size = New System.Drawing.Size(223, 20)
        Me.txtImageSizeKilobytes.TabIndex = 154
        '
        'txtImageSizeBytes
        '
        Me.txtImageSizeBytes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageSizeBytes.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageSizeBytes.ForeColor = System.Drawing.Color.Black
        Me.txtImageSizeBytes.Location = New System.Drawing.Point(375, 393)
        Me.txtImageSizeBytes.Name = "txtImageSizeBytes"
        Me.txtImageSizeBytes.ReadOnly = True
        Me.txtImageSizeBytes.Size = New System.Drawing.Size(223, 20)
        Me.txtImageSizeBytes.TabIndex = 153
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Turquoise
        Me.Label12.Location = New System.Drawing.Point(96, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 19)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Rows:"
        '
        'lblStorageWidth
        '
        Me.lblStorageWidth.AutoSize = True
        Me.lblStorageWidth.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStorageWidth.ForeColor = System.Drawing.Color.Turquoise
        Me.lblStorageWidth.Location = New System.Drawing.Point(11, 190)
        Me.lblStorageWidth.Name = "lblStorageWidth"
        Me.lblStorageWidth.Size = New System.Drawing.Size(73, 19)
        Me.lblStorageWidth.TabIndex = 151
        Me.lblStorageWidth.Text = "Columns:"
        '
        'txtRows
        '
        Me.txtRows.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtRows.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRows.ForeColor = System.Drawing.Color.Black
        Me.txtRows.Location = New System.Drawing.Point(94, 213)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(75, 23)
        Me.txtRows.TabIndex = 3
        Me.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtColumns
        '
        Me.txtColumns.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtColumns.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumns.ForeColor = System.Drawing.Color.Black
        Me.txtColumns.Location = New System.Drawing.Point(9, 213)
        Me.txtColumns.Name = "txtColumns"
        Me.txtColumns.Size = New System.Drawing.Size(75, 23)
        Me.txtColumns.TabIndex = 2
        Me.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImageFilename
        '
        Me.txtImageFilename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageFilename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageFilename.ForeColor = System.Drawing.Color.Black
        Me.txtImageFilename.Location = New System.Drawing.Point(9, 368)
        Me.txtImageFilename.Name = "txtImageFilename"
        Me.txtImageFilename.ReadOnly = True
        Me.txtImageFilename.Size = New System.Drawing.Size(589, 20)
        Me.txtImageFilename.TabIndex = 7
        '
        'txtImageEXT
        '
        Me.txtImageEXT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageEXT.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageEXT.ForeColor = System.Drawing.Color.Black
        Me.txtImageEXT.Location = New System.Drawing.Point(605, 366)
        Me.txtImageEXT.Name = "txtImageEXT"
        Me.txtImageEXT.ReadOnly = True
        Me.txtImageEXT.Size = New System.Drawing.Size(223, 23)
        Me.txtImageEXT.TabIndex = 8
        '
        'pbStoragePic
        '
        Me.pbStoragePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbStoragePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbStoragePic.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbStoragePic.Location = New System.Drawing.Point(605, 180)
        Me.pbStoragePic.Name = "pbStoragePic"
        Me.pbStoragePic.Size = New System.Drawing.Size(223, 182)
        Me.pbStoragePic.TabIndex = 147
        Me.pbStoragePic.TabStop = False
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastUpdated.BackColor = System.Drawing.Color.MediumBlue
        Me.txtLastUpdated.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.Color.Aqua
        Me.txtLastUpdated.Location = New System.Drawing.Point(545, 12)
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
        Me.Label13.Location = New System.Drawing.Point(439, 12)
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
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(324, 270)
        Me.imgCalendar_SelectDiscoveryDate.Name = "imgCalendar_SelectDiscoveryDate"
        Me.imgCalendar_SelectDiscoveryDate.Size = New System.Drawing.Size(24, 28)
        Me.imgCalendar_SelectDiscoveryDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCalendar_SelectDiscoveryDate.TabIndex = 138
        Me.imgCalendar_SelectDiscoveryDate.TabStop = False
        Me.imgCalendar_SelectDiscoveryDate.Tag = "btn7"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTotal.BackColor = System.Drawing.Color.MediumBlue
        Me.txtTotal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Aqua
        Me.txtTotal.Location = New System.Drawing.Point(757, 9)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(70, 23)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Turquoise
        Me.Label11.Location = New System.Drawing.Point(703, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUpdated
        '
        Me.txtUpdated.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUpdated.ForeColor = System.Drawing.Color.Black
        Me.txtUpdated.Location = New System.Drawing.Point(185, 278)
        Me.txtUpdated.Mask = "00/00/0000 90:00"
        Me.txtUpdated.Name = "txtUpdated"
        Me.txtUpdated.Size = New System.Drawing.Size(133, 20)
        Me.txtUpdated.TabIndex = 6
        Me.txtUpdated.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Turquoise
        Me.Label8.Location = New System.Drawing.Point(190, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Updated At:"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.Black
        Me.txtNotes.Location = New System.Drawing.Point(6, 419)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(825, 100)
        Me.txtNotes.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Turquoise
        Me.Label7.Location = New System.Drawing.Point(7, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Notes:"
        '
        'txtMAXSlots
        '
        Me.txtMAXSlots.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtMAXSlots.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAXSlots.ForeColor = System.Drawing.Color.Black
        Me.txtMAXSlots.Location = New System.Drawing.Point(183, 213)
        Me.txtMAXSlots.Name = "txtMAXSlots"
        Me.txtMAXSlots.Size = New System.Drawing.Size(97, 23)
        Me.txtMAXSlots.TabIndex = 4
        Me.txtMAXSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.Location = New System.Drawing.Point(183, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "MAX Slots Available:"
        '
        'txtPrefID
        '
        Me.txtPrefID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrefID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtPrefID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefID.ForeColor = System.Drawing.Color.Aqua
        Me.txtPrefID.Location = New System.Drawing.Point(35, 9)
        Me.txtPrefID.Name = "txtPrefID"
        Me.txtPrefID.ReadOnly = True
        Me.txtPrefID.Size = New System.Drawing.Size(70, 23)
        Me.txtPrefID.TabIndex = 1
        Me.txtPrefID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID:"
        '
        'lblStorageSize
        '
        Me.lblStorageSize.AutoSize = True
        Me.lblStorageSize.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStorageSize.ForeColor = System.Drawing.Color.Turquoise
        Me.lblStorageSize.Location = New System.Drawing.Point(11, 167)
        Me.lblStorageSize.Name = "lblStorageSize"
        Me.lblStorageSize.Size = New System.Drawing.Size(93, 19)
        Me.lblStorageSize.TabIndex = 11
        Me.lblStorageSize.Text = "Storage Size"
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUserID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtUserID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.Color.Aqua
        Me.txtUserID.Location = New System.Drawing.Point(351, 9)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(70, 23)
        Me.txtUserID.TabIndex = 1
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "UserID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAccountID
        '
        Me.txtAccountID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAccountID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.ForeColor = System.Drawing.Color.Aqua
        Me.txtAccountID.Location = New System.Drawing.Point(193, 9)
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
        Me.lblAccountID.Location = New System.Drawing.Point(112, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(85, 19)
        Me.lblAccountID.TabIndex = 6
        Me.lblAccountID.Text = "AccountID:"
        '
        'txtStorageName
        '
        Me.txtStorageName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStorageName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtStorageName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStorageName.ForeColor = System.Drawing.Color.Black
        Me.txtStorageName.Location = New System.Drawing.Point(6, 125)
        Me.txtStorageName.Name = "txtStorageName"
        Me.txtStorageName.Size = New System.Drawing.Size(824, 32)
        Me.txtStorageName.TabIndex = 1
        Me.txtStorageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStorageCategory
        '
        Me.lblStorageCategory.AutoSize = True
        Me.lblStorageCategory.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStorageCategory.ForeColor = System.Drawing.Color.Turquoise
        Me.lblStorageCategory.Location = New System.Drawing.Point(7, 103)
        Me.lblStorageCategory.Name = "lblStorageCategory"
        Me.lblStorageCategory.Size = New System.Drawing.Size(174, 19)
        Me.lblStorageCategory.TabIndex = 3
        Me.lblStorageCategory.Text = "Enter Storage Category:"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlButtons.Controls.Add(Me.btnImportPicture)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnSAVE)
        Me.pnlButtons.Location = New System.Drawing.Point(0, 2)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(841, 43)
        Me.pnlButtons.TabIndex = 26
        '
        'btnImportPicture
        '
        Me.btnImportPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportPicture.BackColor = System.Drawing.Color.Transparent
        Me.btnImportPicture.BackgroundImage = CType(resources.GetObject("btnImportPicture.BackgroundImage"), System.Drawing.Image)
        Me.btnImportPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImportPicture.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportPicture.Location = New System.Drawing.Point(570, 2)
        Me.btnImportPicture.Name = "btnImportPicture"
        Me.btnImportPicture.Size = New System.Drawing.Size(104, 35)
        Me.btnImportPicture.TabIndex = 12
        Me.btnImportPicture.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(337, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 35)
        Me.btnClose.TabIndex = 11
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackgroundImage = CType(resources.GetObject("btnSAVE.BackgroundImage"), System.Drawing.Image)
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.Location = New System.Drawing.Point(176, 3)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 32)
        Me.btnSAVE.TabIndex = 10
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'frmStorageEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 612)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlEntry)
        Me.Name = "frmStorageEntry"
        Me.Text = "NMS Storage Entry"
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.pbStoragePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEntry As Panel
    Friend WithEvents txtImageSizeKilobytes As TextBox
    Friend WithEvents txtImageSizeBytes As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblStorageWidth As Label
    Friend WithEvents txtRows As TextBox
    Friend WithEvents txtColumns As TextBox
    Friend WithEvents txtImageFilename As TextBox
    Friend WithEvents txtImageEXT As TextBox
    Friend WithEvents pbStoragePic As PictureBox
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents imgCalendar_SelectDiscoveryDate As PictureBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUpdated As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMAXSlots As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrefID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStorageSize As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtStorageName As TextBox
    Friend WithEvents lblStorageCategory As Label
    Friend WithEvents comCategories As ComboBox
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnImportPicture As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSAVE As Button
End Class
