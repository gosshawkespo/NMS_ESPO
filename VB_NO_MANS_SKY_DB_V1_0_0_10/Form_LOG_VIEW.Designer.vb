<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imgLineDivider1 = New System.Windows.Forms.PictureBox()
        Me.lblCurrentSystem = New System.Windows.Forms.Label()
        Me.lblPlanetName = New System.Windows.Forms.Label()
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.pnlLogDetails = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFrigateModules = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtLastSaved = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOriginalPlanetName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOriginalSystemName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtImageSize = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.rtbComment = New System.Windows.Forms.RichTextBox()
        Me.rtbFurtherComment = New System.Windows.Forms.RichTextBox()
        Me.txtCoords = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPlanet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSystem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQuicksilver = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblComment2 = New System.Windows.Forms.Label()
        Me.lblComment1 = New System.Windows.Forms.Label()
        Me.txtBrief = New System.Windows.Forms.TextBox()
        Me.txtEntryDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEntryDate = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblCurrentNanites = New System.Windows.Forms.Label()
        Me.lblCurrentUnits = New System.Windows.Forms.Label()
        Me.txtNanites = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLogID = New System.Windows.Forms.TextBox()
        Me.dgvLOG = New System.Windows.Forms.DataGridView()
        Me.GridContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEDIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDELETE = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtFilterComment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbReverseSort = New System.Windows.Forms.CheckBox()
        Me.txtTotalEntries = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFilterBrief = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFilterPlanet = New System.Windows.Forms.TextBox()
        Me.lblEnterPlanet = New System.Windows.Forms.Label()
        Me.txtFilterSystem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFilterDateTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilterDateFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.tabAccountSelect = New System.Windows.Forms.TabPage()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbSelectOriginalNames = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblUseOriginalNames = New System.Windows.Forms.Label()
        Me.cbUseOriginalNames = New System.Windows.Forms.CheckBox()
        Me.txtGamerHandle = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalAccounts = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.tabSort = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearSorts = New System.Windows.Forms.Button()
        Me.cbReverseSort2 = New System.Windows.Forms.CheckBox()
        Me.cbReverseSort1 = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.comSortFields2 = New System.Windows.Forms.ComboBox()
        Me.comSortFields = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnSortGrid = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtSalvagedData = New System.Windows.Forms.TextBox()
        CType(Me.imgLineDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogDetails.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLOG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridContextMenu.SuspendLayout()
        Me.pnlFilters.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.tabAccountSelect.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        Me.tabSort.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgLineDivider1
        '
        Me.imgLineDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgLineDivider1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgLineDivider1.Image = CType(resources.GetObject("imgLineDivider1.Image"), System.Drawing.Image)
        Me.imgLineDivider1.Location = New System.Drawing.Point(0, 69)
        Me.imgLineDivider1.Name = "imgLineDivider1"
        Me.imgLineDivider1.Size = New System.Drawing.Size(1108, 10)
        Me.imgLineDivider1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLineDivider1.TabIndex = 92
        Me.imgLineDivider1.TabStop = False
        Me.imgLineDivider1.Tag = "img6"
        '
        'lblCurrentSystem
        '
        Me.lblCurrentSystem.AutoSize = True
        Me.lblCurrentSystem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSystem.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentSystem.Location = New System.Drawing.Point(-289, 122)
        Me.lblCurrentSystem.Name = "lblCurrentSystem"
        Me.lblCurrentSystem.Size = New System.Drawing.Size(108, 17)
        Me.lblCurrentSystem.TabIndex = 85
        Me.lblCurrentSystem.Text = "Current System:"
        '
        'lblPlanetName
        '
        Me.lblPlanetName.AutoSize = True
        Me.lblPlanetName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetName.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetName.Location = New System.Drawing.Point(-289, 174)
        Me.lblPlanetName.Name = "lblPlanetName"
        Me.lblPlanetName.Size = New System.Drawing.Size(225, 17)
        Me.lblPlanetName.TabIndex = 86
        Me.lblPlanetName.Text = "Enter Original Planet\Moon Name:"
        '
        'txtTITLE2
        '
        Me.txtTITLE2.BackColor = System.Drawing.Color.DarkOrchid
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.Transparent
        Me.txtTITLE2.Location = New System.Drawing.Point(0, 35)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(1108, 35)
        Me.txtTITLE2.TabIndex = 93
        Me.txtTITLE2.Text = "LOG VIEW"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTITLE
        '
        Me.txtTITLE.BackColor = System.Drawing.Color.Black
        Me.txtTITLE.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE.Location = New System.Drawing.Point(0, 1)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(1108, 35)
        Me.txtTITLE.TabIndex = 94
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlLogDetails
        '
        Me.pnlLogDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLogDetails.AutoScroll = True
        Me.pnlLogDetails.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.pnlLogDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLogDetails.Controls.Add(Me.Label33)
        Me.pnlLogDetails.Controls.Add(Me.txtSalvagedData)
        Me.pnlLogDetails.Controls.Add(Me.Label29)
        Me.pnlLogDetails.Controls.Add(Me.txtFrigateModules)
        Me.pnlLogDetails.Controls.Add(Me.txtUsername)
        Me.pnlLogDetails.Controls.Add(Me.Label27)
        Me.pnlLogDetails.Controls.Add(Me.txtLastSaved)
        Me.pnlLogDetails.Controls.Add(Me.Label19)
        Me.pnlLogDetails.Controls.Add(Me.txtOriginalPlanetName)
        Me.pnlLogDetails.Controls.Add(Me.Label18)
        Me.pnlLogDetails.Controls.Add(Me.txtOriginalSystemName)
        Me.pnlLogDetails.Controls.Add(Me.Label17)
        Me.pnlLogDetails.Controls.Add(Me.Label16)
        Me.pnlLogDetails.Controls.Add(Me.txtImageSize)
        Me.pnlLogDetails.Controls.Add(Me.Label15)
        Me.pnlLogDetails.Controls.Add(Me.txtFilename)
        Me.pnlLogDetails.Controls.Add(Me.txtAccount)
        Me.pnlLogDetails.Controls.Add(Me.Label14)
        Me.pnlLogDetails.Controls.Add(Me.pb1)
        Me.pnlLogDetails.Controls.Add(Me.rtbComment)
        Me.pnlLogDetails.Controls.Add(Me.rtbFurtherComment)
        Me.pnlLogDetails.Controls.Add(Me.txtCoords)
        Me.pnlLogDetails.Controls.Add(Me.Label11)
        Me.pnlLogDetails.Controls.Add(Me.txtArea)
        Me.pnlLogDetails.Controls.Add(Me.Label10)
        Me.pnlLogDetails.Controls.Add(Me.txtPlanet)
        Me.pnlLogDetails.Controls.Add(Me.Label9)
        Me.pnlLogDetails.Controls.Add(Me.txtSystem)
        Me.pnlLogDetails.Controls.Add(Me.Label8)
        Me.pnlLogDetails.Controls.Add(Me.txtQuicksilver)
        Me.pnlLogDetails.Controls.Add(Me.Label4)
        Me.pnlLogDetails.Controls.Add(Me.lblComment2)
        Me.pnlLogDetails.Controls.Add(Me.lblComment1)
        Me.pnlLogDetails.Controls.Add(Me.txtBrief)
        Me.pnlLogDetails.Controls.Add(Me.txtEntryDate)
        Me.pnlLogDetails.Controls.Add(Me.Label3)
        Me.pnlLogDetails.Controls.Add(Me.lblEntryDate)
        Me.pnlLogDetails.Controls.Add(Me.txtUnits)
        Me.pnlLogDetails.Controls.Add(Me.lblCurrentNanites)
        Me.pnlLogDetails.Controls.Add(Me.lblCurrentUnits)
        Me.pnlLogDetails.Controls.Add(Me.txtNanites)
        Me.pnlLogDetails.Location = New System.Drawing.Point(2, 291)
        Me.pnlLogDetails.Name = "pnlLogDetails"
        Me.pnlLogDetails.Size = New System.Drawing.Size(1105, 529)
        Me.pnlLogDetails.TabIndex = 95
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label29.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(537, 156)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 17)
        Me.Label29.TabIndex = 120
        Me.Label29.Text = "FM:"
        '
        'txtFrigateModules
        '
        Me.txtFrigateModules.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFrigateModules.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrigateModules.Location = New System.Drawing.Point(536, 175)
        Me.txtFrigateModules.Name = "txtFrigateModules"
        Me.txtFrigateModules.Size = New System.Drawing.Size(55, 23)
        Me.txtFrigateModules.TabIndex = 119
        Me.txtFrigateModules.Text = "0"
        Me.txtFrigateModules.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUsername.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(3, 73)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(248, 23)
        Me.txtUsername.TabIndex = 117
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label27.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 17)
        Me.Label27.TabIndex = 118
        Me.Label27.Text = "Entered By:"
        '
        'txtLastSaved
        '
        Me.txtLastSaved.BackColor = System.Drawing.Color.AliceBlue
        Me.txtLastSaved.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastSaved.Location = New System.Drawing.Point(260, 73)
        Me.txtLastSaved.Name = "txtLastSaved"
        Me.txtLastSaved.Size = New System.Drawing.Size(158, 23)
        Me.txtLastSaved.TabIndex = 115
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label19.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(260, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 17)
        Me.Label19.TabIndex = 116
        Me.Label19.Text = "Last Saved:"
        '
        'txtOriginalPlanetName
        '
        Me.txtOriginalPlanetName.BackColor = System.Drawing.Color.AliceBlue
        Me.txtOriginalPlanetName.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalPlanetName.Location = New System.Drawing.Point(3, 175)
        Me.txtOriginalPlanetName.Name = "txtOriginalPlanetName"
        Me.txtOriginalPlanetName.Size = New System.Drawing.Size(248, 23)
        Me.txtOriginalPlanetName.TabIndex = 113
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label18.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 17)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "Original Planet Name:"
        '
        'txtOriginalSystemName
        '
        Me.txtOriginalSystemName.BackColor = System.Drawing.Color.AliceBlue
        Me.txtOriginalSystemName.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalSystemName.Location = New System.Drawing.Point(427, 73)
        Me.txtOriginalSystemName.Name = "txtOriginalSystemName"
        Me.txtOriginalSystemName.Size = New System.Drawing.Size(485, 23)
        Me.txtOriginalSystemName.TabIndex = 111
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label17.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(427, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 17)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "Original System:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label16.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(892, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 17)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Size:"
        '
        'txtImageSize
        '
        Me.txtImageSize.BackColor = System.Drawing.Color.AliceBlue
        Me.txtImageSize.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageSize.Location = New System.Drawing.Point(892, 175)
        Me.txtImageSize.Name = "txtImageSize"
        Me.txtImageSize.Size = New System.Drawing.Size(92, 23)
        Me.txtImageSize.TabIndex = 109
        Me.txtImageSize.Text = "0"
        Me.txtImageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label15.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(671, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Filename:"
        '
        'txtFilename
        '
        Me.txtFilename.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilename.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilename.Location = New System.Drawing.Point(671, 175)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(212, 23)
        Me.txtFilename.TabIndex = 107
        '
        'txtAccount
        '
        Me.txtAccount.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccount.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(3, 28)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(248, 23)
        Me.txtAccount.TabIndex = 105
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Account:"
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(937, 6)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(150, 150)
        Me.pb1.TabIndex = 104
        Me.pb1.TabStop = False
        '
        'rtbComment
        '
        Me.rtbComment.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbComment.Location = New System.Drawing.Point(3, 302)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.Size = New System.Drawing.Size(1095, 95)
        Me.rtbComment.TabIndex = 103
        Me.rtbComment.Text = ""
        '
        'rtbFurtherComment
        '
        Me.rtbFurtherComment.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbFurtherComment.Location = New System.Drawing.Point(3, 421)
        Me.rtbFurtherComment.Name = "rtbFurtherComment"
        Me.rtbFurtherComment.Size = New System.Drawing.Size(1095, 95)
        Me.rtbFurtherComment.TabIndex = 41
        Me.rtbFurtherComment.Text = ""
        '
        'txtCoords
        '
        Me.txtCoords.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCoords.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoords.Location = New System.Drawing.Point(613, 123)
        Me.txtCoords.Name = "txtCoords"
        Me.txtCoords.Size = New System.Drawing.Size(153, 23)
        Me.txtCoords.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(613, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "COORDS:"
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.AliceBlue
        Me.txtArea.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(260, 123)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(343, 23)
        Me.txtArea.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(260, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Area:"
        '
        'txtPlanet
        '
        Me.txtPlanet.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlanet.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanet.Location = New System.Drawing.Point(3, 123)
        Me.txtPlanet.Name = "txtPlanet"
        Me.txtPlanet.Size = New System.Drawing.Size(248, 23)
        Me.txtPlanet.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "New Planet:"
        '
        'txtSystem
        '
        Me.txtSystem.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSystem.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystem.Location = New System.Drawing.Point(427, 28)
        Me.txtSystem.Name = "txtSystem"
        Me.txtSystem.Size = New System.Drawing.Size(485, 23)
        Me.txtSystem.TabIndex = 33
        Me.txtSystem.Text = "NEW SYSTEM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(427, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "New System Name:"
        '
        'txtQuicksilver
        '
        Me.txtQuicksilver.BackColor = System.Drawing.Color.AliceBlue
        Me.txtQuicksilver.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuicksilver.Location = New System.Drawing.Point(469, 175)
        Me.txtQuicksilver.Name = "txtQuicksilver"
        Me.txtQuicksilver.Size = New System.Drawing.Size(55, 23)
        Me.txtQuicksilver.TabIndex = 31
        Me.txtQuicksilver.Text = "0"
        Me.txtQuicksilver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "QS:"
        '
        'lblComment2
        '
        Me.lblComment2.AutoSize = True
        Me.lblComment2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblComment2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment2.Location = New System.Drawing.Point(3, 401)
        Me.lblComment2.Name = "lblComment2"
        Me.lblComment2.Size = New System.Drawing.Size(123, 17)
        Me.lblComment2.TabIndex = 23
        Me.lblComment2.Text = "Further Comment:"
        '
        'lblComment1
        '
        Me.lblComment1.AutoSize = True
        Me.lblComment1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblComment1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment1.Location = New System.Drawing.Point(3, 282)
        Me.lblComment1.Name = "lblComment1"
        Me.lblComment1.Size = New System.Drawing.Size(72, 17)
        Me.lblComment1.TabIndex = 21
        Me.lblComment1.Text = "Comment:"
        '
        'txtBrief
        '
        Me.txtBrief.BackColor = System.Drawing.Color.AliceBlue
        Me.txtBrief.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrief.Location = New System.Drawing.Point(3, 221)
        Me.txtBrief.Multiline = True
        Me.txtBrief.Name = "txtBrief"
        Me.txtBrief.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBrief.Size = New System.Drawing.Size(1095, 56)
        Me.txtBrief.TabIndex = 12
        '
        'txtEntryDate
        '
        Me.txtEntryDate.BackColor = System.Drawing.Color.AliceBlue
        Me.txtEntryDate.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryDate.Location = New System.Drawing.Point(260, 28)
        Me.txtEntryDate.Name = "txtEntryDate"
        Me.txtEntryDate.Size = New System.Drawing.Size(158, 23)
        Me.txtEntryDate.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Brief:"
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblEntryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.Location = New System.Drawing.Point(260, 9)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(80, 17)
        Me.lblEntryDate.TabIndex = 9
        Me.lblEntryDate.Text = "Entry Date:"
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUnits.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(350, 175)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(113, 23)
        Me.txtUnits.TabIndex = 11
        Me.txtUnits.Text = "0"
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCurrentNanites
        '
        Me.lblCurrentNanites.AutoSize = True
        Me.lblCurrentNanites.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentNanites.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentNanites.Location = New System.Drawing.Point(262, 156)
        Me.lblCurrentNanites.Name = "lblCurrentNanites"
        Me.lblCurrentNanites.Size = New System.Drawing.Size(59, 17)
        Me.lblCurrentNanites.TabIndex = 17
        Me.lblCurrentNanites.Text = "Nanites:"
        '
        'lblCurrentUnits
        '
        Me.lblCurrentUnits.AutoSize = True
        Me.lblCurrentUnits.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentUnits.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUnits.Location = New System.Drawing.Point(351, 156)
        Me.lblCurrentUnits.Name = "lblCurrentUnits"
        Me.lblCurrentUnits.Size = New System.Drawing.Size(45, 17)
        Me.lblCurrentUnits.TabIndex = 19
        Me.lblCurrentUnits.Text = "Units:"
        '
        'txtNanites
        '
        Me.txtNanites.BackColor = System.Drawing.Color.AliceBlue
        Me.txtNanites.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNanites.Location = New System.Drawing.Point(262, 175)
        Me.txtNanites.Name = "txtNanites"
        Me.txtNanites.Size = New System.Drawing.Size(82, 23)
        Me.txtNanites.TabIndex = 10
        Me.txtNanites.Text = "0"
        Me.txtNanites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label13.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(319, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 22)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "ID:"
        '
        'txtLogID
        '
        Me.txtLogID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtLogID.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogID.Location = New System.Drawing.Point(358, 41)
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.Size = New System.Drawing.Size(61, 22)
        Me.txtLogID.TabIndex = 101
        Me.txtLogID.Text = "0"
        Me.txtLogID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvLOG
        '
        Me.dgvLOG.AllowUserToAddRows = False
        Me.dgvLOG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLOG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLOG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOG.ContextMenuStrip = Me.GridContextMenu
        Me.dgvLOG.Location = New System.Drawing.Point(1, 180)
        Me.dgvLOG.Name = "dgvLOG"
        Me.dgvLOG.RowHeadersWidth = 62
        Me.dgvLOG.Size = New System.Drawing.Size(1106, 106)
        Me.dgvLOG.TabIndex = 96
        '
        'GridContextMenu
        '
        Me.GridContextMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GridContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripADD, Me.ToolStripEDIT, Me.ToolStripSeparator1, Me.ToolStripDELETE})
        Me.GridContextMenu.Name = "ContextMenuStrip1"
        Me.GridContextMenu.Size = New System.Drawing.Size(138, 76)
        '
        'ToolStripADD
        '
        Me.ToolStripADD.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripADD.ForeColor = System.Drawing.Color.Black
        Me.ToolStripADD.Name = "ToolStripADD"
        Me.ToolStripADD.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripADD.Text = "New Entry"
        '
        'ToolStripEDIT
        '
        Me.ToolStripEDIT.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripEDIT.Name = "ToolStripEDIT"
        Me.ToolStripEDIT.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripEDIT.Text = "Edit Entry"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'ToolStripDELETE
        '
        Me.ToolStripDELETE.BackColor = System.Drawing.Color.Red
        Me.ToolStripDELETE.Name = "ToolStripDELETE"
        Me.ToolStripDELETE.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripDELETE.Text = "Delete Entry"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1012, 37)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 31)
        Me.btnClose.TabIndex = 98
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlFilters.Controls.Add(Me.Label28)
        Me.pnlFilters.Controls.Add(Me.txtFilterComment)
        Me.pnlFilters.Controls.Add(Me.Label12)
        Me.pnlFilters.Controls.Add(Me.cbReverseSort)
        Me.pnlFilters.Controls.Add(Me.txtTotalEntries)
        Me.pnlFilters.Controls.Add(Me.Label7)
        Me.pnlFilters.Controls.Add(Me.btnSearch)
        Me.pnlFilters.Controls.Add(Me.txtFilterBrief)
        Me.pnlFilters.Controls.Add(Me.Label6)
        Me.pnlFilters.Controls.Add(Me.txtFilterPlanet)
        Me.pnlFilters.Controls.Add(Me.lblEnterPlanet)
        Me.pnlFilters.Controls.Add(Me.txtFilterSystem)
        Me.pnlFilters.Controls.Add(Me.Label5)
        Me.pnlFilters.Controls.Add(Me.txtFilterDateTo)
        Me.pnlFilters.Controls.Add(Me.Label2)
        Me.pnlFilters.Controls.Add(Me.txtFilterDateFrom)
        Me.pnlFilters.Controls.Add(Me.Label1)
        Me.pnlFilters.Location = New System.Drawing.Point(6, 6)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(1090, 63)
        Me.pnlFilters.TabIndex = 99
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label28.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(806, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 17)
        Me.Label28.TabIndex = 105
        Me.Label28.Text = "By Comment:"
        '
        'txtFilterComment
        '
        Me.txtFilterComment.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterComment.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterComment.Location = New System.Drawing.Point(807, 25)
        Me.txtFilterComment.Name = "txtFilterComment"
        Me.txtFilterComment.Size = New System.Drawing.Size(140, 22)
        Me.txtFilterComment.TabIndex = 104
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label12.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(227, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 12)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Reverse Sort:"
        '
        'cbReverseSort
        '
        Me.cbReverseSort.AutoSize = True
        Me.cbReverseSort.Checked = True
        Me.cbReverseSort.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbReverseSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReverseSort.ForeColor = System.Drawing.Color.Black
        Me.cbReverseSort.Location = New System.Drawing.Point(294, 9)
        Me.cbReverseSort.Name = "cbReverseSort"
        Me.cbReverseSort.Size = New System.Drawing.Size(15, 14)
        Me.cbReverseSort.TabIndex = 102
        Me.cbReverseSort.UseVisualStyleBackColor = True
        '
        'txtTotalEntries
        '
        Me.txtTotalEntries.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalEntries.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEntries.Location = New System.Drawing.Point(1026, 25)
        Me.txtTotalEntries.Name = "txtTotalEntries"
        Me.txtTotalEntries.Size = New System.Drawing.Size(56, 22)
        Me.txtTotalEntries.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1026, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Total:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(957, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 41)
        Me.btnSearch.TabIndex = 99
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtFilterBrief
        '
        Me.txtFilterBrief.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterBrief.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterBrief.Location = New System.Drawing.Point(656, 25)
        Me.txtFilterBrief.Name = "txtFilterBrief"
        Me.txtFilterBrief.Size = New System.Drawing.Size(140, 22)
        Me.txtFilterBrief.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(653, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "By Brief:"
        '
        'txtFilterPlanet
        '
        Me.txtFilterPlanet.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterPlanet.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterPlanet.Location = New System.Drawing.Point(489, 25)
        Me.txtFilterPlanet.Name = "txtFilterPlanet"
        Me.txtFilterPlanet.Size = New System.Drawing.Size(158, 22)
        Me.txtFilterPlanet.TabIndex = 16
        '
        'lblEnterPlanet
        '
        Me.lblEnterPlanet.AutoSize = True
        Me.lblEnterPlanet.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblEnterPlanet.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterPlanet.Location = New System.Drawing.Point(489, 5)
        Me.lblEnterPlanet.Name = "lblEnterPlanet"
        Me.lblEnterPlanet.Size = New System.Drawing.Size(72, 17)
        Me.lblEnterPlanet.TabIndex = 17
        Me.lblEnterPlanet.Text = "By Planet:"
        '
        'txtFilterSystem
        '
        Me.txtFilterSystem.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterSystem.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterSystem.Location = New System.Drawing.Point(322, 25)
        Me.txtFilterSystem.Name = "txtFilterSystem"
        Me.txtFilterSystem.Size = New System.Drawing.Size(158, 22)
        Me.txtFilterSystem.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "By System:"
        '
        'txtFilterDateTo
        '
        Me.txtFilterDateTo.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterDateTo.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterDateTo.Location = New System.Drawing.Point(157, 25)
        Me.txtFilterDateTo.Name = "txtFilterDateTo"
        Me.txtFilterDateTo.Size = New System.Drawing.Size(150, 22)
        Me.txtFilterDateTo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Date To:"
        '
        'txtFilterDateFrom
        '
        Me.txtFilterDateFrom.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFilterDateFrom.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilterDateFrom.Location = New System.Drawing.Point(3, 25)
        Me.txtFilterDateFrom.Name = "txtFilterDateFrom"
        Me.txtFilterDateFrom.Size = New System.Drawing.Size(145, 22)
        Me.txtFilterDateFrom.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Filter Date From:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(4, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 30)
        Me.btnAdd.TabIndex = 100
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(92, 35)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 35)
        Me.btnEdit.TabIndex = 101
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnCopy.BackgroundImage = CType(resources.GetObject("btnCopy.BackgroundImage"), System.Drawing.Image)
        Me.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCopy.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.Black
        Me.btnCopy.Location = New System.Drawing.Point(180, 36)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(94, 32)
        Me.btnCopy.TabIndex = 102
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(766, 39)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 29)
        Me.btnRefresh.TabIndex = 103
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSearch)
        Me.TabControl1.Controls.Add(Me.tabAccountSelect)
        Me.TabControl1.Controls.Add(Me.tabSort)
        Me.TabControl1.Location = New System.Drawing.Point(0, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1107, 100)
        Me.TabControl1.TabIndex = 104
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.pnlFilters)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabSearch.Size = New System.Drawing.Size(1099, 74)
        Me.tabSearch.TabIndex = 0
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'tabAccountSelect
        '
        Me.tabAccountSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tabAccountSelect.Controls.Add(Me.pnlAccount)
        Me.tabAccountSelect.Location = New System.Drawing.Point(4, 22)
        Me.tabAccountSelect.Name = "tabAccountSelect"
        Me.tabAccountSelect.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabAccountSelect.Size = New System.Drawing.Size(1099, 74)
        Me.tabAccountSelect.TabIndex = 1
        Me.tabAccountSelect.Text = "Account Select"
        Me.tabAccountSelect.UseVisualStyleBackColor = True
        '
        'pnlAccount
        '
        Me.pnlAccount.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlAccount.Controls.Add(Me.txtUserID)
        Me.pnlAccount.Controls.Add(Me.Label20)
        Me.pnlAccount.Controls.Add(Me.cbSelectOriginalNames)
        Me.pnlAccount.Controls.Add(Me.Label21)
        Me.pnlAccount.Controls.Add(Me.lblUseOriginalNames)
        Me.pnlAccount.Controls.Add(Me.cbUseOriginalNames)
        Me.pnlAccount.Controls.Add(Me.txtGamerHandle)
        Me.pnlAccount.Controls.Add(Me.Label22)
        Me.pnlAccount.Controls.Add(Me.txtTotalAccounts)
        Me.pnlAccount.Controls.Add(Me.Label23)
        Me.pnlAccount.Controls.Add(Me.txtAccountID)
        Me.pnlAccount.Controls.Add(Me.Label24)
        Me.pnlAccount.Controls.Add(Me.comAccounts)
        Me.pnlAccount.Controls.Add(Me.txtVersion)
        Me.pnlAccount.Controls.Add(Me.lblVersion)
        Me.pnlAccount.Controls.Add(Me.txtPlatform)
        Me.pnlAccount.Controls.Add(Me.lblPlatform)
        Me.pnlAccount.Controls.Add(Me.txtAccountName)
        Me.pnlAccount.Controls.Add(Me.lblAccount)
        Me.pnlAccount.Location = New System.Drawing.Point(2, 1)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(1095, 76)
        Me.pnlAccount.TabIndex = 33
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUserID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.Color.Black
        Me.txtUserID.Location = New System.Drawing.Point(934, 7)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(44, 25)
        Me.txtUserID.TabIndex = 52
        Me.txtUserID.Text = "0"
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label20.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(872, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "User ID:"
        '
        'cbSelectOriginalNames
        '
        Me.cbSelectOriginalNames.AutoSize = True
        Me.cbSelectOriginalNames.Location = New System.Drawing.Point(963, 46)
        Me.cbSelectOriginalNames.Name = "cbSelectOriginalNames"
        Me.cbSelectOriginalNames.Size = New System.Drawing.Size(15, 14)
        Me.cbSelectOriginalNames.TabIndex = 51
        Me.cbSelectOriginalNames.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label21.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(810, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 17)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Select Original Names:"
        '
        'lblUseOriginalNames
        '
        Me.lblUseOriginalNames.AutoSize = True
        Me.lblUseOriginalNames.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblUseOriginalNames.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUseOriginalNames.Location = New System.Drawing.Point(652, 43)
        Me.lblUseOriginalNames.Name = "lblUseOriginalNames"
        Me.lblUseOriginalNames.Size = New System.Drawing.Size(133, 17)
        Me.lblUseOriginalNames.TabIndex = 49
        Me.lblUseOriginalNames.Text = "Use Original Names:"
        '
        'cbUseOriginalNames
        '
        Me.cbUseOriginalNames.AutoSize = True
        Me.cbUseOriginalNames.Location = New System.Drawing.Point(790, 46)
        Me.cbUseOriginalNames.Name = "cbUseOriginalNames"
        Me.cbUseOriginalNames.Size = New System.Drawing.Size(15, 14)
        Me.cbUseOriginalNames.TabIndex = 48
        Me.cbUseOriginalNames.UseVisualStyleBackColor = True
        '
        'txtGamerHandle
        '
        Me.txtGamerHandle.BackColor = System.Drawing.Color.AliceBlue
        Me.txtGamerHandle.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGamerHandle.ForeColor = System.Drawing.Color.Black
        Me.txtGamerHandle.Location = New System.Drawing.Point(708, 8)
        Me.txtGamerHandle.Name = "txtGamerHandle"
        Me.txtGamerHandle.Size = New System.Drawing.Size(158, 25)
        Me.txtGamerHandle.TabIndex = 46
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label22.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(652, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 17)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Handle:"
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAccounts.Location = New System.Drawing.Point(587, 40)
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.Size = New System.Drawing.Size(52, 25)
        Me.txtTotalAccounts.TabIndex = 45
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label23.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(570, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 17)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "#"
        '
        'txtAccountID
        '
        Me.txtAccountID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.ForeColor = System.Drawing.Color.Black
        Me.txtAccountID.Location = New System.Drawing.Point(508, 40)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(52, 25)
        Me.txtAccountID.TabIndex = 43
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label24.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(481, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 17)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "ID:"
        '
        'comAccounts
        '
        Me.comAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comAccounts.BackColor = System.Drawing.Color.SkyBlue
        Me.comAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comAccounts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccounts.ForeColor = System.Drawing.Color.Black
        Me.comAccounts.FormattingEnabled = True
        Me.comAccounts.Location = New System.Drawing.Point(369, 9)
        Me.comAccounts.Name = "comAccounts"
        Me.comAccounts.Size = New System.Drawing.Size(269, 23)
        Me.comAccounts.Sorted = True
        Me.comAccounts.TabIndex = 41
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.Color.AliceBlue
        Me.txtVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.ForeColor = System.Drawing.Color.Black
        Me.txtVersion.Location = New System.Drawing.Point(313, 40)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(158, 25)
        Me.txtVersion.TabIndex = 34
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(254, 43)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(59, 17)
        Me.lblVersion.TabIndex = 40
        Me.lblVersion.Text = "Version:"
        '
        'txtPlatform
        '
        Me.txtPlatform.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.ForeColor = System.Drawing.Color.Black
        Me.txtPlatform.Location = New System.Drawing.Point(74, 40)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(170, 25)
        Me.txtPlatform.TabIndex = 36
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(6, 43)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(68, 17)
        Me.lblPlatform.TabIndex = 35
        Me.lblPlatform.Text = "Platform:"
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccountName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.ForeColor = System.Drawing.Color.Black
        Me.txtAccountName.Location = New System.Drawing.Point(74, 8)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(285, 25)
        Me.txtAccountName.TabIndex = 33
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAccount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(11, 11)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(64, 17)
        Me.lblAccount.TabIndex = 32
        Me.lblAccount.Text = "Account:"
        '
        'tabSort
        '
        Me.tabSort.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tabSort.Controls.Add(Me.Panel1)
        Me.tabSort.Location = New System.Drawing.Point(4, 22)
        Me.tabSort.Name = "tabSort"
        Me.tabSort.Size = New System.Drawing.Size(1099, 74)
        Me.tabSort.TabIndex = 2
        Me.tabSort.Text = "Sort"
        Me.tabSort.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.btnClearSorts)
        Me.Panel1.Controls.Add(Me.cbReverseSort2)
        Me.Panel1.Controls.Add(Me.cbReverseSort1)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.comSortFields2)
        Me.Panel1.Controls.Add(Me.comSortFields)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.btnSortGrid)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Location = New System.Drawing.Point(4, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1090, 53)
        Me.Panel1.TabIndex = 100
        '
        'btnClearSorts
        '
        Me.btnClearSorts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearSorts.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClearSorts.BackgroundImage = CType(resources.GetObject("btnClearSorts.BackgroundImage"), System.Drawing.Image)
        Me.btnClearSorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearSorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearSorts.ForeColor = System.Drawing.Color.Black
        Me.btnClearSorts.Location = New System.Drawing.Point(488, 6)
        Me.btnClearSorts.Name = "btnClearSorts"
        Me.btnClearSorts.Size = New System.Drawing.Size(114, 41)
        Me.btnClearSorts.TabIndex = 109
        Me.btnClearSorts.UseVisualStyleBackColor = False
        '
        'cbReverseSort2
        '
        Me.cbReverseSort2.AutoSize = True
        Me.cbReverseSort2.Checked = True
        Me.cbReverseSort2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbReverseSort2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReverseSort2.ForeColor = System.Drawing.Color.Black
        Me.cbReverseSort2.Location = New System.Drawing.Point(298, 9)
        Me.cbReverseSort2.Name = "cbReverseSort2"
        Me.cbReverseSort2.Size = New System.Drawing.Size(15, 14)
        Me.cbReverseSort2.TabIndex = 102
        Me.cbReverseSort2.UseVisualStyleBackColor = True
        '
        'cbReverseSort1
        '
        Me.cbReverseSort1.AutoSize = True
        Me.cbReverseSort1.Checked = True
        Me.cbReverseSort1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbReverseSort1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReverseSort1.ForeColor = System.Drawing.Color.Black
        Me.cbReverseSort1.Location = New System.Drawing.Point(136, 9)
        Me.cbReverseSort1.Name = "cbReverseSort1"
        Me.cbReverseSort1.Size = New System.Drawing.Size(15, 14)
        Me.cbReverseSort1.TabIndex = 107
        Me.cbReverseSort1.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label32.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(92, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 12)
        Me.Label32.TabIndex = 108
        Me.Label32.Text = "Reverse:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label30.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(163, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 17)
        Me.Label30.TabIndex = 106
        Me.Label30.Text = "And By:"
        '
        'comSortFields2
        '
        Me.comSortFields2.FormattingEnabled = True
        Me.comSortFields2.Location = New System.Drawing.Point(162, 26)
        Me.comSortFields2.Name = "comSortFields2"
        Me.comSortFields2.Size = New System.Drawing.Size(150, 21)
        Me.comSortFields2.TabIndex = 105
        '
        'comSortFields
        '
        Me.comSortFields.FormattingEnabled = True
        Me.comSortFields.Location = New System.Drawing.Point(2, 25)
        Me.comSortFields.Name = "comSortFields"
        Me.comSortFields.Size = New System.Drawing.Size(150, 21)
        Me.comSortFields.TabIndex = 104
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label25.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(253, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 12)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = "Reverse:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(947, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 25)
        Me.TextBox1.TabIndex = 100
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label26.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(947, 5)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 17)
        Me.Label26.TabIndex = 101
        Me.Label26.Text = "Total Entries:"
        '
        'btnSortGrid
        '
        Me.btnSortGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSortGrid.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSortGrid.BackgroundImage = CType(resources.GetObject("btnSortGrid.BackgroundImage"), System.Drawing.Image)
        Me.btnSortGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSortGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSortGrid.ForeColor = System.Drawing.Color.Black
        Me.btnSortGrid.Location = New System.Drawing.Point(363, 6)
        Me.btnSortGrid.Name = "btnSortGrid"
        Me.btnSortGrid.Size = New System.Drawing.Size(114, 41)
        Me.btnSortGrid.TabIndex = 99
        Me.btnSortGrid.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label31.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 5)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 17)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Sort Grid By:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label33.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(604, 156)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 17)
        Me.Label33.TabIndex = 122
        Me.Label33.Text = "SD:"
        '
        'txtSalvagedData
        '
        Me.txtSalvagedData.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSalvagedData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalvagedData.Location = New System.Drawing.Point(603, 175)
        Me.txtSalvagedData.Name = "txtSalvagedData"
        Me.txtSalvagedData.Size = New System.Drawing.Size(55, 23)
        Me.txtSalvagedData.TabIndex = 121
        Me.txtSalvagedData.Text = "0"
        Me.txtSalvagedData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmLogView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1108, 826)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtLogID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvLOG)
        Me.Controls.Add(Me.pnlLogDetails)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Controls.Add(Me.txtTITLE)
        Me.Controls.Add(Me.imgLineDivider1)
        Me.Controls.Add(Me.lblCurrentSystem)
        Me.Controls.Add(Me.lblPlanetName)
        Me.Name = "frmLogView"
        Me.Text = "NO MANS SKY DATABASE - LOG VIEW"
        CType(Me.imgLineDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogDetails.ResumeLayout(False)
        Me.pnlLogDetails.PerformLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLOG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridContextMenu.ResumeLayout(False)
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.tabAccountSelect.ResumeLayout(False)
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.tabSort.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLineDivider1 As PictureBox
    Friend WithEvents lblCurrentSystem As Label
    Friend WithEvents lblPlanetName As Label
    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents pnlLogDetails As Panel
    Friend WithEvents txtQuicksilver As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblComment2 As Label
    Friend WithEvents lblComment1 As Label
    Friend WithEvents txtBrief As TextBox
    Friend WithEvents txtEntryDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEntryDate As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblCurrentNanites As Label
    Friend WithEvents lblCurrentUnits As Label
    Friend WithEvents txtNanites As TextBox
    Friend WithEvents dgvLOG As DataGridView
    Friend WithEvents GridContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripADD As ToolStripMenuItem
    Friend WithEvents ToolStripEDIT As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripDELETE As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents txtFilterPlanet As TextBox
    Friend WithEvents lblEnterPlanet As Label
    Friend WithEvents txtFilterSystem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFilterDateTo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFilterDateFrom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFilterBrief As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalEntries As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCoords As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPlanet As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSystem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbReverseSort As CheckBox
    Friend WithEvents rtbFurtherComment As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLogID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents rtbComment As RichTextBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtImageSize As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents txtOriginalPlanetName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOriginalSystemName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtLastSaved As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabSearch As TabPage
    Friend WithEvents tabAccountSelect As TabPage
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbSelectOriginalNames As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblUseOriginalNames As Label
    Friend WithEvents cbUseOriginalNames As CheckBox
    Friend WithEvents txtGamerHandle As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTotalAccounts As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents tabSort As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbReverseSort2 As CheckBox
    Friend WithEvents cbReverseSort1 As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents comSortFields2 As ComboBox
    Friend WithEvents comSortFields As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnSortGrid As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents btnClearSorts As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtFilterComment As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtFrigateModules As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtSalvagedData As TextBox
End Class
