<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanetEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanetEntry))
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.pnlPlanetDetails = New System.Windows.Forms.Panel()
        Me.imgLineDivider4 = New System.Windows.Forms.PictureBox()
        Me.txtGlyphUnderMouse = New System.Windows.Forms.TextBox()
        Me.txtWeather = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtExtremeWeather = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvPlanets = New System.Windows.Forms.DataGridView()
        Me.pnlPlanetInfo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDefaultSystem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSystemID = New System.Windows.Forms.TextBox()
        Me.txtRenamedPlanet = New System.Windows.Forms.TextBox()
        Me.comSystems = New System.Windows.Forms.ComboBox()
        Me.txtCurrentSystem = New System.Windows.Forms.TextBox()
        Me.lblCurrentSystem = New System.Windows.Forms.Label()
        Me.txtGalacticRegion = New System.Windows.Forms.TextBox()
        Me.lblGalacticRegion = New System.Windows.Forms.Label()
        Me.lblRenamedPlanet = New System.Windows.Forms.Label()
        Me.txtPlanetName = New System.Windows.Forms.TextBox()
        Me.lblPlanetName = New System.Windows.Forms.Label()
        Me.btnCreatePlanetCode = New System.Windows.Forms.Button()
        Me.txtGalacticAddress = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSentinalInfo = New System.Windows.Forms.TextBox()
        Me.lblSentinalInfo = New System.Windows.Forms.Label()
        Me.txtResourceNotes = New System.Windows.Forms.TextBox()
        Me.lblResourceNotes = New System.Windows.Forms.Label()
        Me.txtDiscoveryDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDiscoveredBy = New System.Windows.Forms.Label()
        Me.txtDiscoveredBy = New System.Windows.Forms.TextBox()
        Me.lblDateOfDiscovery = New System.Windows.Forms.Label()
        Me.Frame_PlanetInfo = New System.Windows.Forms.ScrollableControl()
        Me.btnSaveBaseColumns = New System.Windows.Forms.Button()
        Me.btnSaveStructureColumns = New System.Windows.Forms.Button()
        Me.btnSaveWaypointColumns = New System.Windows.Forms.Button()
        Me.btnSaveResourceColumns = New System.Windows.Forms.Button()
        Me.txtTotalResources = New System.Windows.Forms.TextBox()
        Me.txtTotalWaypoints = New System.Windows.Forms.TextBox()
        Me.txtTotalStructures = New System.Windows.Forms.TextBox()
        Me.comBases = New System.Windows.Forms.ComboBox()
        Me.btnAddBase = New System.Windows.Forms.Button()
        Me.btnRemoveBase = New System.Windows.Forms.Button()
        Me.comStructures = New System.Windows.Forms.ComboBox()
        Me.btnAddStructure = New System.Windows.Forms.Button()
        Me.btnRemoveStructure = New System.Windows.Forms.Button()
        Me.comWaypoints = New System.Windows.Forms.ComboBox()
        Me.btnAddWaypoint = New System.Windows.Forms.Button()
        Me.btnRemoveWaypoint = New System.Windows.Forms.Button()
        Me.dgvBases = New System.Windows.Forms.DataGridView()
        Me.BaseContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddNewBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBASES = New System.Windows.Forms.Label()
        Me.lblSTRUCTURES = New System.Windows.Forms.Label()
        Me.dgvStructures = New System.Windows.Forms.DataGridView()
        Me.StructureContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWEYPOINTS = New System.Windows.Forms.Label()
        Me.dgvWaypoints = New System.Windows.Forms.DataGridView()
        Me.WaypointContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRESOURCES = New System.Windows.Forms.Label()
        Me.dgvResources = New System.Windows.Forms.DataGridView()
        Me.ResourceContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.comResources = New System.Windows.Forms.ComboBox()
        Me.btnAddResource = New System.Windows.Forms.Button()
        Me.txtTotalBases = New System.Windows.Forms.TextBox()
        Me.btnRemoveResource = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblPlanetaryNotes = New System.Windows.Forms.Label()
        Me.imgCalendar_SelectDiscoveryDate = New System.Windows.Forms.PictureBox()
        Me.txtTotalFlora = New System.Windows.Forms.TextBox()
        Me.lblTotalFauna = New System.Windows.Forms.Label()
        Me.txtTotalFauna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame_PlanetGlyphSet = New System.Windows.Forms.ScrollableControl()
        Me.Frame_PlanetGlyphPallet = New System.Windows.Forms.ScrollableControl()
        Me.txtPlanetGlyphCode = New System.Windows.Forms.TextBox()
        Me.txtSelectedGlyphIndex = New System.Windows.Forms.TextBox()
        Me.lblSelectGlyph = New System.Windows.Forms.Label()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.glyphList = New System.Windows.Forms.ImageList(Me.components)
        Me.imgLineDivider1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalPlanets = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalAccounts = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalSystems = New System.Windows.Forms.TextBox()
        Me.pnlPlanetDetails.SuspendLayout()
        CType(Me.imgLineDivider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlanets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPlanetInfo.SuspendLayout()
        Me.Frame_PlanetInfo.SuspendLayout()
        CType(Me.dgvBases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseContextMenu.SuspendLayout()
        CType(Me.dgvStructures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StructureContextMenu.SuspendLayout()
        CType(Me.dgvWaypoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WaypointContextMenu.SuspendLayout()
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResourceContextMenu.SuspendLayout()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccount.SuspendLayout()
        CType(Me.imgLineDivider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTITLE2
        '
        Me.txtTITLE2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE2.BackColor = System.Drawing.Color.DarkOrchid
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.Transparent
        Me.txtTITLE2.Location = New System.Drawing.Point(0, 33)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(1469, 35)
        Me.txtTITLE2.TabIndex = 34
        Me.txtTITLE2.Text = "PLANET ENTRY"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTITLE
        '
        Me.txtTITLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE.BackColor = System.Drawing.Color.Black
        Me.txtTITLE.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE.Location = New System.Drawing.Point(0, 0)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(1467, 35)
        Me.txtTITLE.TabIndex = 35
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlPlanetDetails
        '
        Me.pnlPlanetDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPlanetDetails.BackColor = System.Drawing.Color.Blue
        Me.pnlPlanetDetails.BackgroundImage = CType(resources.GetObject("pnlPlanetDetails.BackgroundImage"), System.Drawing.Image)
        Me.pnlPlanetDetails.Controls.Add(Me.imgLineDivider4)
        Me.pnlPlanetDetails.Controls.Add(Me.txtGlyphUnderMouse)
        Me.pnlPlanetDetails.Controls.Add(Me.txtWeather)
        Me.pnlPlanetDetails.Controls.Add(Me.Label8)
        Me.pnlPlanetDetails.Controls.Add(Me.txtExtremeWeather)
        Me.pnlPlanetDetails.Controls.Add(Me.Label7)
        Me.pnlPlanetDetails.Controls.Add(Me.PictureBox1)
        Me.pnlPlanetDetails.Controls.Add(Me.dgvPlanets)
        Me.pnlPlanetDetails.Controls.Add(Me.pnlPlanetInfo)
        Me.pnlPlanetDetails.Controls.Add(Me.btnCreatePlanetCode)
        Me.pnlPlanetDetails.Controls.Add(Me.txtGalacticAddress)
        Me.pnlPlanetDetails.Controls.Add(Me.Label1)
        Me.pnlPlanetDetails.Controls.Add(Me.txtSentinalInfo)
        Me.pnlPlanetDetails.Controls.Add(Me.lblSentinalInfo)
        Me.pnlPlanetDetails.Controls.Add(Me.txtResourceNotes)
        Me.pnlPlanetDetails.Controls.Add(Me.lblResourceNotes)
        Me.pnlPlanetDetails.Controls.Add(Me.txtDiscoveryDate)
        Me.pnlPlanetDetails.Controls.Add(Me.lblDiscoveredBy)
        Me.pnlPlanetDetails.Controls.Add(Me.txtDiscoveredBy)
        Me.pnlPlanetDetails.Controls.Add(Me.lblDateOfDiscovery)
        Me.pnlPlanetDetails.Controls.Add(Me.Frame_PlanetInfo)
        Me.pnlPlanetDetails.Controls.Add(Me.txtComments)
        Me.pnlPlanetDetails.Controls.Add(Me.lblPlanetaryNotes)
        Me.pnlPlanetDetails.Controls.Add(Me.imgCalendar_SelectDiscoveryDate)
        Me.pnlPlanetDetails.Controls.Add(Me.txtTotalFlora)
        Me.pnlPlanetDetails.Controls.Add(Me.lblTotalFauna)
        Me.pnlPlanetDetails.Controls.Add(Me.txtTotalFauna)
        Me.pnlPlanetDetails.Controls.Add(Me.Label4)
        Me.pnlPlanetDetails.Controls.Add(Me.Frame_PlanetGlyphSet)
        Me.pnlPlanetDetails.Controls.Add(Me.Frame_PlanetGlyphPallet)
        Me.pnlPlanetDetails.Controls.Add(Me.txtPlanetGlyphCode)
        Me.pnlPlanetDetails.Controls.Add(Me.txtSelectedGlyphIndex)
        Me.pnlPlanetDetails.Controls.Add(Me.lblSelectGlyph)
        Me.pnlPlanetDetails.ForeColor = System.Drawing.Color.Black
        Me.pnlPlanetDetails.Location = New System.Drawing.Point(0, 157)
        Me.pnlPlanetDetails.Name = "pnlPlanetDetails"
        Me.pnlPlanetDetails.Size = New System.Drawing.Size(1469, 722)
        Me.pnlPlanetDetails.TabIndex = 37
        '
        'imgLineDivider4
        '
        Me.imgLineDivider4.AccessibleName = "0, 112, 192"
        Me.imgLineDivider4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgLineDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgLineDivider4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgLineDivider4.Image = CType(resources.GetObject("imgLineDivider4.Image"), System.Drawing.Image)
        Me.imgLineDivider4.Location = New System.Drawing.Point(1015, -9)
        Me.imgLineDivider4.Name = "imgLineDivider4"
        Me.imgLineDivider4.Size = New System.Drawing.Size(10, 734)
        Me.imgLineDivider4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLineDivider4.TabIndex = 130
        Me.imgLineDivider4.TabStop = False
        Me.imgLineDivider4.Tag = "img4"
        '
        'txtGlyphUnderMouse
        '
        Me.txtGlyphUnderMouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGlyphUnderMouse.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGlyphUnderMouse.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlyphUnderMouse.ForeColor = System.Drawing.Color.Black
        Me.txtGlyphUnderMouse.Location = New System.Drawing.Point(63, 369)
        Me.txtGlyphUnderMouse.Name = "txtGlyphUnderMouse"
        Me.txtGlyphUnderMouse.Size = New System.Drawing.Size(34, 25)
        Me.txtGlyphUnderMouse.TabIndex = 161
        '
        'txtWeather
        '
        Me.txtWeather.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWeather.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWeather.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeather.ForeColor = System.Drawing.Color.Black
        Me.txtWeather.Location = New System.Drawing.Point(506, 607)
        Me.txtWeather.Name = "txtWeather"
        Me.txtWeather.Size = New System.Drawing.Size(484, 25)
        Me.txtWeather.TabIndex = 160
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(426, 612)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Weather? :"
        '
        'txtExtremeWeather
        '
        Me.txtExtremeWeather.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtExtremeWeather.BackColor = System.Drawing.Color.Gainsboro
        Me.txtExtremeWeather.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtremeWeather.ForeColor = System.Drawing.Color.Black
        Me.txtExtremeWeather.Location = New System.Drawing.Point(280, 609)
        Me.txtExtremeWeather.Name = "txtExtremeWeather"
        Me.txtExtremeWeather.Size = New System.Drawing.Size(135, 25)
        Me.txtExtremeWeather.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(144, 614)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 17)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Extreme Weather? :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 245)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 156
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "img6"
        '
        'dgvPlanets
        '
        Me.dgvPlanets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanets.Location = New System.Drawing.Point(4, 7)
        Me.dgvPlanets.Name = "dgvPlanets"
        Me.dgvPlanets.Size = New System.Drawing.Size(988, 112)
        Me.dgvPlanets.TabIndex = 61
        '
        'pnlPlanetInfo
        '
        Me.pnlPlanetInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlPlanetInfo.BackgroundImage = CType(resources.GetObject("pnlPlanetInfo.BackgroundImage"), System.Drawing.Image)
        Me.pnlPlanetInfo.Controls.Add(Me.Label3)
        Me.pnlPlanetInfo.Controls.Add(Me.txtDefaultSystem)
        Me.pnlPlanetInfo.Controls.Add(Me.Label2)
        Me.pnlPlanetInfo.Controls.Add(Me.txtSystemID)
        Me.pnlPlanetInfo.Controls.Add(Me.txtRenamedPlanet)
        Me.pnlPlanetInfo.Controls.Add(Me.comSystems)
        Me.pnlPlanetInfo.Controls.Add(Me.txtCurrentSystem)
        Me.pnlPlanetInfo.Controls.Add(Me.lblCurrentSystem)
        Me.pnlPlanetInfo.Controls.Add(Me.txtGalacticRegion)
        Me.pnlPlanetInfo.Controls.Add(Me.lblGalacticRegion)
        Me.pnlPlanetInfo.Controls.Add(Me.lblRenamedPlanet)
        Me.pnlPlanetInfo.Controls.Add(Me.txtPlanetName)
        Me.pnlPlanetInfo.Controls.Add(Me.lblPlanetName)
        Me.pnlPlanetInfo.Location = New System.Drawing.Point(3, 130)
        Me.pnlPlanetInfo.Name = "pnlPlanetInfo"
        Me.pnlPlanetInfo.Size = New System.Drawing.Size(1011, 111)
        Me.pnlPlanetInfo.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(318, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Default System:"
        '
        'txtDefaultSystem
        '
        Me.txtDefaultSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDefaultSystem.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDefaultSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDefaultSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefaultSystem.ForeColor = System.Drawing.Color.Black
        Me.txtDefaultSystem.Location = New System.Drawing.Point(318, 32)
        Me.txtDefaultSystem.Name = "txtDefaultSystem"
        Me.txtDefaultSystem.ReadOnly = True
        Me.txtDefaultSystem.Size = New System.Drawing.Size(300, 25)
        Me.txtDefaultSystem.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "ID:"
        '
        'txtSystemID
        '
        Me.txtSystemID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSystemID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSystemID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemID.ForeColor = System.Drawing.Color.Black
        Me.txtSystemID.Location = New System.Drawing.Point(433, 59)
        Me.txtSystemID.Name = "txtSystemID"
        Me.txtSystemID.Size = New System.Drawing.Size(68, 25)
        Me.txtSystemID.TabIndex = 164
        '
        'txtRenamedPlanet
        '
        Me.txtRenamedPlanet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRenamedPlanet.BackColor = System.Drawing.Color.Silver
        Me.txtRenamedPlanet.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenamedPlanet.ForeColor = System.Drawing.Color.Black
        Me.txtRenamedPlanet.Location = New System.Drawing.Point(528, 85)
        Me.txtRenamedPlanet.Name = "txtRenamedPlanet"
        Me.txtRenamedPlanet.Size = New System.Drawing.Size(461, 25)
        Me.txtRenamedPlanet.TabIndex = 163
        '
        'comSystems
        '
        Me.comSystems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comSystems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comSystems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.comSystems.BackColor = System.Drawing.Color.SkyBlue
        Me.comSystems.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comSystems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSystems.ForeColor = System.Drawing.Color.Black
        Me.comSystems.FormattingEnabled = True
        Me.comSystems.Location = New System.Drawing.Point(123, 4)
        Me.comSystems.Name = "comSystems"
        Me.comSystems.Size = New System.Drawing.Size(176, 23)
        Me.comSystems.Sorted = True
        Me.comSystems.TabIndex = 162
        '
        'txtCurrentSystem
        '
        Me.txtCurrentSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentSystem.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCurrentSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentSystem.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentSystem.Location = New System.Drawing.Point(1, 32)
        Me.txtCurrentSystem.Name = "txtCurrentSystem"
        Me.txtCurrentSystem.ReadOnly = True
        Me.txtCurrentSystem.Size = New System.Drawing.Size(300, 25)
        Me.txtCurrentSystem.TabIndex = 155
        '
        'lblCurrentSystem
        '
        Me.lblCurrentSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentSystem.AutoSize = True
        Me.lblCurrentSystem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSystem.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentSystem.Location = New System.Drawing.Point(1, 9)
        Me.lblCurrentSystem.Name = "lblCurrentSystem"
        Me.lblCurrentSystem.Size = New System.Drawing.Size(108, 17)
        Me.lblCurrentSystem.TabIndex = 158
        Me.lblCurrentSystem.Text = "Current System:"
        '
        'txtGalacticRegion
        '
        Me.txtGalacticRegion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGalacticRegion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticRegion.ForeColor = System.Drawing.Color.Black
        Me.txtGalacticRegion.Location = New System.Drawing.Point(633, 32)
        Me.txtGalacticRegion.Name = "txtGalacticRegion"
        Me.txtGalacticRegion.ReadOnly = True
        Me.txtGalacticRegion.Size = New System.Drawing.Size(356, 25)
        Me.txtGalacticRegion.TabIndex = 156
        '
        'lblGalacticRegion
        '
        Me.lblGalacticRegion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGalacticRegion.AutoSize = True
        Me.lblGalacticRegion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalacticRegion.ForeColor = System.Drawing.Color.Black
        Me.lblGalacticRegion.Location = New System.Drawing.Point(635, 9)
        Me.lblGalacticRegion.Name = "lblGalacticRegion"
        Me.lblGalacticRegion.Size = New System.Drawing.Size(104, 17)
        Me.lblGalacticRegion.TabIndex = 160
        Me.lblGalacticRegion.Text = "Galactic Region"
        '
        'lblRenamedPlanet
        '
        Me.lblRenamedPlanet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRenamedPlanet.AutoSize = True
        Me.lblRenamedPlanet.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRenamedPlanet.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenamedPlanet.ForeColor = System.Drawing.Color.Black
        Me.lblRenamedPlanet.Location = New System.Drawing.Point(530, 65)
        Me.lblRenamedPlanet.Name = "lblRenamedPlanet"
        Me.lblRenamedPlanet.Size = New System.Drawing.Size(88, 17)
        Me.lblRenamedPlanet.TabIndex = 161
        Me.lblRenamedPlanet.Text = "Renamed As:"
        '
        'txtPlanetName
        '
        Me.txtPlanetName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlanetName.BackColor = System.Drawing.Color.Silver
        Me.txtPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetName.ForeColor = System.Drawing.Color.Black
        Me.txtPlanetName.Location = New System.Drawing.Point(1, 85)
        Me.txtPlanetName.Name = "txtPlanetName"
        Me.txtPlanetName.Size = New System.Drawing.Size(500, 25)
        Me.txtPlanetName.TabIndex = 157
        '
        'lblPlanetName
        '
        Me.lblPlanetName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPlanetName.AutoSize = True
        Me.lblPlanetName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetName.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetName.Location = New System.Drawing.Point(1, 65)
        Me.lblPlanetName.Name = "lblPlanetName"
        Me.lblPlanetName.Size = New System.Drawing.Size(225, 17)
        Me.lblPlanetName.TabIndex = 159
        Me.lblPlanetName.Text = "Enter Original Planet\Moon Name:"
        '
        'btnCreatePlanetCode
        '
        Me.btnCreatePlanetCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreatePlanetCode.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCreatePlanetCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreatePlanetCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePlanetCode.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePlanetCode.Location = New System.Drawing.Point(5, 268)
        Me.btnCreatePlanetCode.Name = "btnCreatePlanetCode"
        Me.btnCreatePlanetCode.Size = New System.Drawing.Size(158, 34)
        Me.btnCreatePlanetCode.TabIndex = 153
        Me.btnCreatePlanetCode.Text = "Create Planet Code"
        Me.btnCreatePlanetCode.UseVisualStyleBackColor = False
        '
        'txtGalacticAddress
        '
        Me.txtGalacticAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGalacticAddress.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGalacticAddress.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticAddress.Location = New System.Drawing.Point(455, 273)
        Me.txtGalacticAddress.Mask = ">AAAA:AAAA:AAAA:AAAA"
        Me.txtGalacticAddress.Name = "txtGalacticAddress"
        Me.txtGalacticAddress.Size = New System.Drawing.Size(120, 25)
        Me.txtGalacticAddress.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Galactic Address:"
        '
        'txtSentinalInfo
        '
        Me.txtSentinalInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSentinalInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSentinalInfo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSentinalInfo.ForeColor = System.Drawing.Color.Black
        Me.txtSentinalInfo.Location = New System.Drawing.Point(3, 527)
        Me.txtSentinalInfo.Multiline = True
        Me.txtSentinalInfo.Name = "txtSentinalInfo"
        Me.txtSentinalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSentinalInfo.Size = New System.Drawing.Size(412, 69)
        Me.txtSentinalInfo.TabIndex = 150
        '
        'lblSentinalInfo
        '
        Me.lblSentinalInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSentinalInfo.AutoSize = True
        Me.lblSentinalInfo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSentinalInfo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentinalInfo.ForeColor = System.Drawing.Color.Black
        Me.lblSentinalInfo.Location = New System.Drawing.Point(3, 503)
        Me.lblSentinalInfo.Name = "lblSentinalInfo"
        Me.lblSentinalInfo.Size = New System.Drawing.Size(91, 17)
        Me.lblSentinalInfo.TabIndex = 149
        Me.lblSentinalInfo.Text = "Sentinal Info:"
        '
        'txtResourceNotes
        '
        Me.txtResourceNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtResourceNotes.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResourceNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceNotes.ForeColor = System.Drawing.Color.Black
        Me.txtResourceNotes.Location = New System.Drawing.Point(425, 527)
        Me.txtResourceNotes.Multiline = True
        Me.txtResourceNotes.Name = "txtResourceNotes"
        Me.txtResourceNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResourceNotes.Size = New System.Drawing.Size(565, 69)
        Me.txtResourceNotes.TabIndex = 148
        '
        'lblResourceNotes
        '
        Me.lblResourceNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResourceNotes.AutoSize = True
        Me.lblResourceNotes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblResourceNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceNotes.ForeColor = System.Drawing.Color.Black
        Me.lblResourceNotes.Location = New System.Drawing.Point(425, 503)
        Me.lblResourceNotes.Name = "lblResourceNotes"
        Me.lblResourceNotes.Size = New System.Drawing.Size(109, 17)
        Me.lblResourceNotes.TabIndex = 147
        Me.lblResourceNotes.Text = "Resource Notes:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiscoveryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(410, 369)
        Me.txtDiscoveryDate.Mask = "00/00/0000 90:00"
        Me.txtDiscoveryDate.Name = "txtDiscoveryDate"
        Me.txtDiscoveryDate.Size = New System.Drawing.Size(129, 25)
        Me.txtDiscoveryDate.TabIndex = 145
        Me.txtDiscoveryDate.ValidatingType = GetType(Date)
        '
        'lblDiscoveredBy
        '
        Me.lblDiscoveredBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiscoveredBy.AutoSize = True
        Me.lblDiscoveredBy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.lblDiscoveredBy.Location = New System.Drawing.Point(582, 372)
        Me.lblDiscoveredBy.Name = "lblDiscoveredBy"
        Me.lblDiscoveredBy.Size = New System.Drawing.Size(103, 17)
        Me.lblDiscoveredBy.TabIndex = 144
        Me.lblDiscoveredBy.Text = "Discovered By:"
        '
        'txtDiscoveredBy
        '
        Me.txtDiscoveredBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDiscoveredBy.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(699, 369)
        Me.txtDiscoveredBy.Name = "txtDiscoveredBy"
        Me.txtDiscoveredBy.Size = New System.Drawing.Size(292, 25)
        Me.txtDiscoveredBy.TabIndex = 143
        '
        'lblDateOfDiscovery
        '
        Me.lblDateOfDiscovery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDateOfDiscovery.AutoSize = True
        Me.lblDateOfDiscovery.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDateOfDiscovery.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfDiscovery.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfDiscovery.Location = New System.Drawing.Point(280, 372)
        Me.lblDateOfDiscovery.Name = "lblDateOfDiscovery"
        Me.lblDateOfDiscovery.Size = New System.Drawing.Size(124, 17)
        Me.lblDateOfDiscovery.TabIndex = 141
        Me.lblDateOfDiscovery.Text = "Date of Discovery:"
        '
        'Frame_PlanetInfo
        '
        Me.Frame_PlanetInfo.AutoScroll = True
        Me.Frame_PlanetInfo.BackColor = System.Drawing.Color.Blue
        Me.Frame_PlanetInfo.Controls.Add(Me.btnSaveBaseColumns)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnSaveStructureColumns)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnSaveWaypointColumns)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnSaveResourceColumns)
        Me.Frame_PlanetInfo.Controls.Add(Me.txtTotalResources)
        Me.Frame_PlanetInfo.Controls.Add(Me.txtTotalWaypoints)
        Me.Frame_PlanetInfo.Controls.Add(Me.txtTotalStructures)
        Me.Frame_PlanetInfo.Controls.Add(Me.comBases)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnAddBase)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnRemoveBase)
        Me.Frame_PlanetInfo.Controls.Add(Me.comStructures)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnAddStructure)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnRemoveStructure)
        Me.Frame_PlanetInfo.Controls.Add(Me.comWaypoints)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnAddWaypoint)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnRemoveWaypoint)
        Me.Frame_PlanetInfo.Controls.Add(Me.dgvBases)
        Me.Frame_PlanetInfo.Controls.Add(Me.lblBASES)
        Me.Frame_PlanetInfo.Controls.Add(Me.lblSTRUCTURES)
        Me.Frame_PlanetInfo.Controls.Add(Me.dgvStructures)
        Me.Frame_PlanetInfo.Controls.Add(Me.lblWEYPOINTS)
        Me.Frame_PlanetInfo.Controls.Add(Me.dgvWaypoints)
        Me.Frame_PlanetInfo.Controls.Add(Me.lblRESOURCES)
        Me.Frame_PlanetInfo.Controls.Add(Me.dgvResources)
        Me.Frame_PlanetInfo.Controls.Add(Me.comResources)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnAddResource)
        Me.Frame_PlanetInfo.Controls.Add(Me.txtTotalBases)
        Me.Frame_PlanetInfo.Controls.Add(Me.btnRemoveResource)
        Me.Frame_PlanetInfo.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_PlanetInfo.ForeColor = System.Drawing.Color.Black
        Me.Frame_PlanetInfo.Location = New System.Drawing.Point(1027, 4)
        Me.Frame_PlanetInfo.Name = "Frame_PlanetInfo"
        Me.Frame_PlanetInfo.Size = New System.Drawing.Size(418, 715)
        Me.Frame_PlanetInfo.TabIndex = 140
        Me.Frame_PlanetInfo.Tag = "frm1"
        Me.Frame_PlanetInfo.Text = "ScrollableControl3"
        '
        'btnSaveBaseColumns
        '
        Me.btnSaveBaseColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveBaseColumns.BackgroundImage = CType(resources.GetObject("btnSaveBaseColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveBaseColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveBaseColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBaseColumns.Location = New System.Drawing.Point(282, 558)
        Me.btnSaveBaseColumns.Name = "btnSaveBaseColumns"
        Me.btnSaveBaseColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveBaseColumns.TabIndex = 161
        Me.btnSaveBaseColumns.UseVisualStyleBackColor = False
        '
        'btnSaveStructureColumns
        '
        Me.btnSaveStructureColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveStructureColumns.BackgroundImage = CType(resources.GetObject("btnSaveStructureColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveStructureColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveStructureColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStructureColumns.Location = New System.Drawing.Point(282, 376)
        Me.btnSaveStructureColumns.Name = "btnSaveStructureColumns"
        Me.btnSaveStructureColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveStructureColumns.TabIndex = 160
        Me.btnSaveStructureColumns.UseVisualStyleBackColor = False
        '
        'btnSaveWaypointColumns
        '
        Me.btnSaveWaypointColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveWaypointColumns.BackgroundImage = CType(resources.GetObject("btnSaveWaypointColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveWaypointColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveWaypointColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWaypointColumns.Location = New System.Drawing.Point(282, 196)
        Me.btnSaveWaypointColumns.Name = "btnSaveWaypointColumns"
        Me.btnSaveWaypointColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveWaypointColumns.TabIndex = 159
        Me.btnSaveWaypointColumns.UseVisualStyleBackColor = False
        '
        'btnSaveResourceColumns
        '
        Me.btnSaveResourceColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveResourceColumns.BackgroundImage = CType(resources.GetObject("btnSaveResourceColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveResourceColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveResourceColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveResourceColumns.Location = New System.Drawing.Point(282, 13)
        Me.btnSaveResourceColumns.Name = "btnSaveResourceColumns"
        Me.btnSaveResourceColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveResourceColumns.TabIndex = 158
        Me.btnSaveResourceColumns.UseVisualStyleBackColor = False
        '
        'txtTotalResources
        '
        Me.txtTotalResources.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalResources.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalResources.ForeColor = System.Drawing.Color.Black
        Me.txtTotalResources.Location = New System.Drawing.Point(364, 12)
        Me.txtTotalResources.Name = "txtTotalResources"
        Me.txtTotalResources.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalResources.TabIndex = 157
        Me.txtTotalResources.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalWaypoints
        '
        Me.txtTotalWaypoints.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalWaypoints.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWaypoints.ForeColor = System.Drawing.Color.Black
        Me.txtTotalWaypoints.Location = New System.Drawing.Point(364, 194)
        Me.txtTotalWaypoints.Name = "txtTotalWaypoints"
        Me.txtTotalWaypoints.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalWaypoints.TabIndex = 156
        Me.txtTotalWaypoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalStructures
        '
        Me.txtTotalStructures.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalStructures.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalStructures.ForeColor = System.Drawing.Color.Black
        Me.txtTotalStructures.Location = New System.Drawing.Point(364, 376)
        Me.txtTotalStructures.Name = "txtTotalStructures"
        Me.txtTotalStructures.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalStructures.TabIndex = 155
        Me.txtTotalStructures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comBases
        '
        Me.comBases.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comBases.BackColor = System.Drawing.Color.SkyBlue
        Me.comBases.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comBases.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBases.ForeColor = System.Drawing.Color.Black
        Me.comBases.FormattingEnabled = True
        Me.comBases.Location = New System.Drawing.Point(108, 558)
        Me.comBases.Name = "comBases"
        Me.comBases.Size = New System.Drawing.Size(170, 23)
        Me.comBases.Sorted = True
        Me.comBases.TabIndex = 152
        '
        'btnAddBase
        '
        Me.btnAddBase.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddBase.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBase.Location = New System.Drawing.Point(310, 558)
        Me.btnAddBase.Name = "btnAddBase"
        Me.btnAddBase.Size = New System.Drawing.Size(20, 23)
        Me.btnAddBase.TabIndex = 153
        Me.btnAddBase.Text = "+"
        Me.btnAddBase.UseVisualStyleBackColor = False
        '
        'btnRemoveBase
        '
        Me.btnRemoveBase.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveBase.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBase.Location = New System.Drawing.Point(333, 558)
        Me.btnRemoveBase.Name = "btnRemoveBase"
        Me.btnRemoveBase.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveBase.TabIndex = 154
        Me.btnRemoveBase.Text = "-"
        Me.btnRemoveBase.UseVisualStyleBackColor = False
        '
        'comStructures
        '
        Me.comStructures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comStructures.BackColor = System.Drawing.Color.SkyBlue
        Me.comStructures.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comStructures.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comStructures.ForeColor = System.Drawing.Color.Black
        Me.comStructures.FormattingEnabled = True
        Me.comStructures.Location = New System.Drawing.Point(108, 377)
        Me.comStructures.Name = "comStructures"
        Me.comStructures.Size = New System.Drawing.Size(170, 23)
        Me.comStructures.Sorted = True
        Me.comStructures.TabIndex = 148
        '
        'btnAddStructure
        '
        Me.btnAddStructure.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddStructure.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStructure.Location = New System.Drawing.Point(310, 376)
        Me.btnAddStructure.Name = "btnAddStructure"
        Me.btnAddStructure.Size = New System.Drawing.Size(20, 23)
        Me.btnAddStructure.TabIndex = 149
        Me.btnAddStructure.Text = "+"
        Me.btnAddStructure.UseVisualStyleBackColor = False
        '
        'btnRemoveStructure
        '
        Me.btnRemoveStructure.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveStructure.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveStructure.Location = New System.Drawing.Point(333, 376)
        Me.btnRemoveStructure.Name = "btnRemoveStructure"
        Me.btnRemoveStructure.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveStructure.TabIndex = 150
        Me.btnRemoveStructure.Text = "-"
        Me.btnRemoveStructure.UseVisualStyleBackColor = False
        '
        'comWaypoints
        '
        Me.comWaypoints.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comWaypoints.BackColor = System.Drawing.Color.SkyBlue
        Me.comWaypoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comWaypoints.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comWaypoints.ForeColor = System.Drawing.Color.Black
        Me.comWaypoints.FormattingEnabled = True
        Me.comWaypoints.Location = New System.Drawing.Point(108, 196)
        Me.comWaypoints.Name = "comWaypoints"
        Me.comWaypoints.Size = New System.Drawing.Size(170, 23)
        Me.comWaypoints.Sorted = True
        Me.comWaypoints.TabIndex = 145
        '
        'btnAddWaypoint
        '
        Me.btnAddWaypoint.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddWaypoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWaypoint.Location = New System.Drawing.Point(310, 196)
        Me.btnAddWaypoint.Name = "btnAddWaypoint"
        Me.btnAddWaypoint.Size = New System.Drawing.Size(20, 23)
        Me.btnAddWaypoint.TabIndex = 146
        Me.btnAddWaypoint.Text = "+"
        Me.btnAddWaypoint.UseVisualStyleBackColor = False
        '
        'btnRemoveWaypoint
        '
        Me.btnRemoveWaypoint.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveWaypoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveWaypoint.Location = New System.Drawing.Point(333, 196)
        Me.btnRemoveWaypoint.Name = "btnRemoveWaypoint"
        Me.btnRemoveWaypoint.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveWaypoint.TabIndex = 147
        Me.btnRemoveWaypoint.Text = "-"
        Me.btnRemoveWaypoint.UseVisualStyleBackColor = False
        '
        'dgvBases
        '
        Me.dgvBases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBases.ContextMenuStrip = Me.BaseContextMenu
        Me.dgvBases.Location = New System.Drawing.Point(5, 585)
        Me.dgvBases.Name = "dgvBases"
        Me.dgvBases.Size = New System.Drawing.Size(404, 127)
        Me.dgvBases.TabIndex = 144
        '
        'BaseContextMenu
        '
        Me.BaseContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAddNewBase, Me.ToolStripEditBase, Me.ToolStripDeleteBase})
        Me.BaseContextMenu.Name = "ResourceContextMenu"
        Me.BaseContextMenu.Size = New System.Drawing.Size(151, 70)
        '
        'ToolStripAddNewBase
        '
        Me.ToolStripAddNewBase.Name = "ToolStripAddNewBase"
        Me.ToolStripAddNewBase.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripAddNewBase.Text = "Add New Base"
        '
        'ToolStripEditBase
        '
        Me.ToolStripEditBase.Enabled = False
        Me.ToolStripEditBase.Name = "ToolStripEditBase"
        Me.ToolStripEditBase.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripEditBase.Text = "Edit Base"
        '
        'ToolStripDeleteBase
        '
        Me.ToolStripDeleteBase.Enabled = False
        Me.ToolStripDeleteBase.Name = "ToolStripDeleteBase"
        Me.ToolStripDeleteBase.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripDeleteBase.Text = "Remove Base"
        '
        'lblBASES
        '
        Me.lblBASES.AutoSize = True
        Me.lblBASES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblBASES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBASES.ForeColor = System.Drawing.Color.Black
        Me.lblBASES.Location = New System.Drawing.Point(5, 562)
        Me.lblBASES.Name = "lblBASES"
        Me.lblBASES.Size = New System.Drawing.Size(53, 17)
        Me.lblBASES.TabIndex = 143
        Me.lblBASES.Text = "BASES:"
        '
        'lblSTRUCTURES
        '
        Me.lblSTRUCTURES.AutoSize = True
        Me.lblSTRUCTURES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSTRUCTURES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTRUCTURES.ForeColor = System.Drawing.Color.Black
        Me.lblSTRUCTURES.Location = New System.Drawing.Point(5, 380)
        Me.lblSTRUCTURES.Name = "lblSTRUCTURES"
        Me.lblSTRUCTURES.Size = New System.Drawing.Size(99, 17)
        Me.lblSTRUCTURES.TabIndex = 142
        Me.lblSTRUCTURES.Text = "STRUCTURES:"
        '
        'dgvStructures
        '
        Me.dgvStructures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStructures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStructures.ContextMenuStrip = Me.StructureContextMenu
        Me.dgvStructures.Location = New System.Drawing.Point(5, 404)
        Me.dgvStructures.Name = "dgvStructures"
        Me.dgvStructures.Size = New System.Drawing.Size(404, 150)
        Me.dgvStructures.TabIndex = 141
        '
        'StructureContextMenu
        '
        Me.StructureContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAddStructure, Me.ToolStripEditStructure, Me.ToolStripDeleteStructure})
        Me.StructureContextMenu.Name = "ResourceContextMenu"
        Me.StructureContextMenu.Size = New System.Drawing.Size(169, 70)
        '
        'ToolStripAddStructure
        '
        Me.ToolStripAddStructure.Name = "ToolStripAddStructure"
        Me.ToolStripAddStructure.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripAddStructure.Text = "Add Structure"
        '
        'ToolStripEditStructure
        '
        Me.ToolStripEditStructure.Enabled = False
        Me.ToolStripEditStructure.Name = "ToolStripEditStructure"
        Me.ToolStripEditStructure.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripEditStructure.Text = "Edit Structure"
        '
        'ToolStripDeleteStructure
        '
        Me.ToolStripDeleteStructure.Enabled = False
        Me.ToolStripDeleteStructure.Name = "ToolStripDeleteStructure"
        Me.ToolStripDeleteStructure.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripDeleteStructure.Text = "Remove Structure"
        '
        'lblWEYPOINTS
        '
        Me.lblWEYPOINTS.AutoSize = True
        Me.lblWEYPOINTS.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWEYPOINTS.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEYPOINTS.ForeColor = System.Drawing.Color.Black
        Me.lblWEYPOINTS.Location = New System.Drawing.Point(5, 199)
        Me.lblWEYPOINTS.Name = "lblWEYPOINTS"
        Me.lblWEYPOINTS.Size = New System.Drawing.Size(92, 17)
        Me.lblWEYPOINTS.TabIndex = 140
        Me.lblWEYPOINTS.Text = "WAYPOINTS:"
        '
        'dgvWaypoints
        '
        Me.dgvWaypoints.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWaypoints.ContextMenuStrip = Me.WaypointContextMenu
        Me.dgvWaypoints.Location = New System.Drawing.Point(5, 222)
        Me.dgvWaypoints.Name = "dgvWaypoints"
        Me.dgvWaypoints.Size = New System.Drawing.Size(404, 150)
        Me.dgvWaypoints.TabIndex = 139
        '
        'WaypointContextMenu
        '
        Me.WaypointContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAddWaypoint, Me.ToolStripEditWaypoint, Me.ToolStripDeleteWaypoint})
        Me.WaypointContextMenu.Name = "ResourceContextMenu"
        Me.WaypointContextMenu.Size = New System.Drawing.Size(172, 70)
        '
        'ToolStripAddWaypoint
        '
        Me.ToolStripAddWaypoint.Name = "ToolStripAddWaypoint"
        Me.ToolStripAddWaypoint.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripAddWaypoint.Text = "Add Waypoint"
        '
        'ToolStripEditWaypoint
        '
        Me.ToolStripEditWaypoint.Enabled = False
        Me.ToolStripEditWaypoint.Name = "ToolStripEditWaypoint"
        Me.ToolStripEditWaypoint.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripEditWaypoint.Text = "Edit Waypoint"
        '
        'ToolStripDeleteWaypoint
        '
        Me.ToolStripDeleteWaypoint.Enabled = False
        Me.ToolStripDeleteWaypoint.Name = "ToolStripDeleteWaypoint"
        Me.ToolStripDeleteWaypoint.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripDeleteWaypoint.Text = "Remove Waypoint"
        '
        'lblRESOURCES
        '
        Me.lblRESOURCES.AutoSize = True
        Me.lblRESOURCES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRESOURCES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESOURCES.ForeColor = System.Drawing.Color.Black
        Me.lblRESOURCES.Location = New System.Drawing.Point(5, 16)
        Me.lblRESOURCES.Name = "lblRESOURCES"
        Me.lblRESOURCES.Size = New System.Drawing.Size(90, 17)
        Me.lblRESOURCES.TabIndex = 138
        Me.lblRESOURCES.Text = "RESOURCES:"
        '
        'dgvResources
        '
        Me.dgvResources.AllowUserToAddRows = False
        Me.dgvResources.AllowUserToDeleteRows = False
        Me.dgvResources.AllowUserToOrderColumns = True
        Me.dgvResources.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResources.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResources.ContextMenuStrip = Me.ResourceContextMenu
        Me.dgvResources.Location = New System.Drawing.Point(5, 40)
        Me.dgvResources.Name = "dgvResources"
        Me.dgvResources.Size = New System.Drawing.Size(404, 150)
        Me.dgvResources.TabIndex = 137
        '
        'ResourceContextMenu
        '
        Me.ResourceContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAddResource, Me.ToolStripEditResource, Me.ToolStripDeleteResource})
        Me.ResourceContextMenu.Name = "ResourceContextMenu"
        Me.ResourceContextMenu.Size = New System.Drawing.Size(169, 70)
        '
        'ToolStripAddResource
        '
        Me.ToolStripAddResource.Name = "ToolStripAddResource"
        Me.ToolStripAddResource.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripAddResource.Text = "Add Resource"
        '
        'ToolStripEditResource
        '
        Me.ToolStripEditResource.Enabled = False
        Me.ToolStripEditResource.Name = "ToolStripEditResource"
        Me.ToolStripEditResource.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripEditResource.Text = "Edit Resource"
        '
        'ToolStripDeleteResource
        '
        Me.ToolStripDeleteResource.Enabled = False
        Me.ToolStripDeleteResource.Name = "ToolStripDeleteResource"
        Me.ToolStripDeleteResource.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripDeleteResource.Text = "Remove Resource"
        '
        'comResources
        '
        Me.comResources.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comResources.BackColor = System.Drawing.Color.SkyBlue
        Me.comResources.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comResources.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comResources.ForeColor = System.Drawing.Color.Black
        Me.comResources.FormattingEnabled = True
        Me.comResources.Location = New System.Drawing.Point(108, 12)
        Me.comResources.Name = "comResources"
        Me.comResources.Size = New System.Drawing.Size(170, 23)
        Me.comResources.Sorted = True
        Me.comResources.TabIndex = 55
        '
        'btnAddResource
        '
        Me.btnAddResource.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddResource.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddResource.Location = New System.Drawing.Point(310, 13)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Size = New System.Drawing.Size(20, 23)
        Me.btnAddResource.TabIndex = 56
        Me.btnAddResource.Text = "+"
        Me.btnAddResource.UseVisualStyleBackColor = False
        '
        'txtTotalBases
        '
        Me.txtTotalBases.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalBases.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBases.ForeColor = System.Drawing.Color.Black
        Me.txtTotalBases.Location = New System.Drawing.Point(364, 556)
        Me.txtTotalBases.Name = "txtTotalBases"
        Me.txtTotalBases.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalBases.TabIndex = 48
        Me.txtTotalBases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemoveResource
        '
        Me.btnRemoveResource.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveResource.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveResource.Location = New System.Drawing.Point(333, 13)
        Me.btnRemoveResource.Name = "btnRemoveResource"
        Me.btnRemoveResource.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveResource.TabIndex = 57
        Me.btnRemoveResource.Text = "-"
        Me.btnRemoveResource.UseVisualStyleBackColor = False
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtComments.BackColor = System.Drawing.Color.Gainsboro
        Me.txtComments.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.ForeColor = System.Drawing.Color.Black
        Me.txtComments.Location = New System.Drawing.Point(4, 635)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComments.Size = New System.Drawing.Size(986, 85)
        Me.txtComments.TabIndex = 139
        '
        'lblPlanetaryNotes
        '
        Me.lblPlanetaryNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPlanetaryNotes.AutoSize = True
        Me.lblPlanetaryNotes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlanetaryNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetaryNotes.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetaryNotes.Location = New System.Drawing.Point(4, 614)
        Me.lblPlanetaryNotes.Name = "lblPlanetaryNotes"
        Me.lblPlanetaryNotes.Size = New System.Drawing.Size(112, 17)
        Me.lblPlanetaryNotes.TabIndex = 138
        Me.lblPlanetaryNotes.Text = "Planetary Notes:"
        '
        'imgCalendar_SelectDiscoveryDate
        '
        Me.imgCalendar_SelectDiscoveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgCalendar_SelectDiscoveryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgCalendar_SelectDiscoveryDate.Image = CType(resources.GetObject("imgCalendar_SelectDiscoveryDate.Image"), System.Drawing.Image)
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(550, 366)
        Me.imgCalendar_SelectDiscoveryDate.Name = "imgCalendar_SelectDiscoveryDate"
        Me.imgCalendar_SelectDiscoveryDate.Size = New System.Drawing.Size(24, 28)
        Me.imgCalendar_SelectDiscoveryDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCalendar_SelectDiscoveryDate.TabIndex = 137
        Me.imgCalendar_SelectDiscoveryDate.TabStop = False
        Me.imgCalendar_SelectDiscoveryDate.Tag = "btn7"
        '
        'txtTotalFlora
        '
        Me.txtTotalFlora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalFlora.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalFlora.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFlora.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFlora.Location = New System.Drawing.Point(868, 273)
        Me.txtTotalFlora.Name = "txtTotalFlora"
        Me.txtTotalFlora.Size = New System.Drawing.Size(46, 25)
        Me.txtTotalFlora.TabIndex = 127
        '
        'lblTotalFauna
        '
        Me.lblTotalFauna.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFauna.AutoSize = True
        Me.lblTotalFauna.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotalFauna.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFauna.ForeColor = System.Drawing.Color.Black
        Me.lblTotalFauna.Location = New System.Drawing.Point(779, 276)
        Me.lblTotalFauna.Name = "lblTotalFauna"
        Me.lblTotalFauna.Size = New System.Drawing.Size(80, 17)
        Me.lblTotalFauna.TabIndex = 126
        Me.lblTotalFauna.Text = "Total Flora:"
        '
        'txtTotalFauna
        '
        Me.txtTotalFauna.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalFauna.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalFauna.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFauna.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFauna.Location = New System.Drawing.Point(722, 273)
        Me.txtTotalFauna.Name = "txtTotalFauna"
        Me.txtTotalFauna.Size = New System.Drawing.Size(46, 25)
        Me.txtTotalFauna.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(633, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Total Fauna:"
        '
        'Frame_PlanetGlyphSet
        '
        Me.Frame_PlanetGlyphSet.AllowDrop = True
        Me.Frame_PlanetGlyphSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Frame_PlanetGlyphSet.AutoScroll = True
        Me.Frame_PlanetGlyphSet.BackColor = System.Drawing.Color.Blue
        Me.Frame_PlanetGlyphSet.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_PlanetGlyphSet.ForeColor = System.Drawing.Color.Black
        Me.Frame_PlanetGlyphSet.Location = New System.Drawing.Point(0, 308)
        Me.Frame_PlanetGlyphSet.Name = "Frame_PlanetGlyphSet"
        Me.Frame_PlanetGlyphSet.Size = New System.Drawing.Size(991, 52)
        Me.Frame_PlanetGlyphSet.TabIndex = 123
        Me.Frame_PlanetGlyphSet.Tag = "frm1"
        Me.Frame_PlanetGlyphSet.Text = "ScrollableControl3"
        '
        'Frame_PlanetGlyphPallet
        '
        Me.Frame_PlanetGlyphPallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Frame_PlanetGlyphPallet.AutoScroll = True
        Me.Frame_PlanetGlyphPallet.BackColor = System.Drawing.Color.Blue
        Me.Frame_PlanetGlyphPallet.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_PlanetGlyphPallet.ForeColor = System.Drawing.Color.Black
        Me.Frame_PlanetGlyphPallet.Location = New System.Drawing.Point(0, 400)
        Me.Frame_PlanetGlyphPallet.Name = "Frame_PlanetGlyphPallet"
        Me.Frame_PlanetGlyphPallet.Size = New System.Drawing.Size(991, 90)
        Me.Frame_PlanetGlyphPallet.TabIndex = 122
        Me.Frame_PlanetGlyphPallet.Tag = "frm1"
        Me.Frame_PlanetGlyphPallet.Text = "ScrollableControl3"
        '
        'txtPlanetGlyphCode
        '
        Me.txtPlanetGlyphCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlanetGlyphCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlanetGlyphCode.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetGlyphCode.ForeColor = System.Drawing.Color.Black
        Me.txtPlanetGlyphCode.Location = New System.Drawing.Point(169, 273)
        Me.txtPlanetGlyphCode.Name = "txtPlanetGlyphCode"
        Me.txtPlanetGlyphCode.Size = New System.Drawing.Size(150, 25)
        Me.txtPlanetGlyphCode.TabIndex = 59
        '
        'txtSelectedGlyphIndex
        '
        Me.txtSelectedGlyphIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedGlyphIndex.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSelectedGlyphIndex.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedGlyphIndex.ForeColor = System.Drawing.Color.Black
        Me.txtSelectedGlyphIndex.Location = New System.Drawing.Point(232, 369)
        Me.txtSelectedGlyphIndex.Name = "txtSelectedGlyphIndex"
        Me.txtSelectedGlyphIndex.Size = New System.Drawing.Size(34, 25)
        Me.txtSelectedGlyphIndex.TabIndex = 58
        '
        'lblSelectGlyph
        '
        Me.lblSelectGlyph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSelectGlyph.AutoSize = True
        Me.lblSelectGlyph.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectGlyph.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGlyph.ForeColor = System.Drawing.Color.Black
        Me.lblSelectGlyph.Location = New System.Drawing.Point(103, 372)
        Me.lblSelectGlyph.Name = "lblSelectGlyph"
        Me.lblSelectGlyph.Size = New System.Drawing.Size(127, 17)
        Me.lblSelectGlyph.TabIndex = 44
        Me.lblSelectGlyph.Text = "SELECTED GLYPH:"
        '
        'pnlAccount
        '
        Me.pnlAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccount.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlAccount.BackgroundImage = CType(resources.GetObject("pnlAccount.BackgroundImage"), System.Drawing.Image)
        Me.pnlAccount.Controls.Add(Me.comAccounts)
        Me.pnlAccount.Controls.Add(Me.txtAccountID)
        Me.pnlAccount.Controls.Add(Me.Label6)
        Me.pnlAccount.Controls.Add(Me.txtVersion)
        Me.pnlAccount.Controls.Add(Me.lblVersion)
        Me.pnlAccount.Controls.Add(Me.txtPlatform)
        Me.pnlAccount.Controls.Add(Me.lblPlatform)
        Me.pnlAccount.Controls.Add(Me.txtAccountName)
        Me.pnlAccount.Controls.Add(Me.lblAccount)
        Me.pnlAccount.Location = New System.Drawing.Point(0, 70)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(1469, 76)
        Me.pnlAccount.TabIndex = 36
        '
        'comAccounts
        '
        Me.comAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.comAccounts.BackColor = System.Drawing.Color.SkyBlue
        Me.comAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comAccounts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccounts.ForeColor = System.Drawing.Color.Black
        Me.comAccounts.FormattingEnabled = True
        Me.comAccounts.Location = New System.Drawing.Point(544, 9)
        Me.comAccounts.Name = "comAccounts"
        Me.comAccounts.Size = New System.Drawing.Size(378, 23)
        Me.comAccounts.Sorted = True
        Me.comAccounts.TabIndex = 163
        '
        'txtAccountID
        '
        Me.txtAccountID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.ForeColor = System.Drawing.Color.Black
        Me.txtAccountID.Location = New System.Drawing.Point(41, 7)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(72, 25)
        Me.txtAccountID.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "ID:"
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.ForeColor = System.Drawing.Color.Black
        Me.txtVersion.Location = New System.Drawing.Point(376, 39)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(158, 25)
        Me.txtVersion.TabIndex = 34
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(308, 42)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(59, 17)
        Me.lblVersion.TabIndex = 40
        Me.lblVersion.Text = "Version:"
        '
        'txtPlatform
        '
        Me.txtPlatform.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.ForeColor = System.Drawing.Color.Black
        Me.txtPlatform.Location = New System.Drawing.Point(82, 38)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(217, 25)
        Me.txtPlatform.TabIndex = 36
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(6, 42)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(68, 17)
        Me.lblPlatform.TabIndex = 35
        Me.lblPlatform.Text = "Platform:"
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAccountName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.ForeColor = System.Drawing.Color.Black
        Me.txtAccountName.Location = New System.Drawing.Point(201, 7)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(333, 25)
        Me.txtAccountName.TabIndex = 33
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAccount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(125, 11)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(64, 17)
        Me.lblAccount.TabIndex = 32
        Me.lblAccount.Text = "Account:"
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackColor = System.Drawing.Color.Transparent
        Me.btnSAVE.BackgroundImage = CType(resources.GetObject("btnSAVE.BackgroundImage"), System.Drawing.Image)
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.Location = New System.Drawing.Point(477, 891)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(79, 34)
        Me.btnSAVE.TabIndex = 57
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'glyphList
        '
        Me.glyphList.ImageStream = CType(resources.GetObject("glyphList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.glyphList.TransparentColor = System.Drawing.Color.Transparent
        Me.glyphList.Images.SetKeyName(0, "SUNSET_0_57x57.png")
        Me.glyphList.Images.SetKeyName(1, "BIRD_1_57x57.png")
        Me.glyphList.Images.SetKeyName(2, "FACE_2_57x57.png")
        Me.glyphList.Images.SetKeyName(3, "DIPLO_3_57x57.png")
        Me.glyphList.Images.SetKeyName(4, "ECLIPSE_4_57x57.png")
        Me.glyphList.Images.SetKeyName(5, "BALLOON_5_57x57.png")
        Me.glyphList.Images.SetKeyName(6, "BOAT_6_57x57.png")
        Me.glyphList.Images.SetKeyName(7, "BUG_7_57x57.png")
        Me.glyphList.Images.SetKeyName(8, "DRAGONFLY_8_57x57.png")
        Me.glyphList.Images.SetKeyName(9, "GALAXY_9_57x57.png")
        Me.glyphList.Images.SetKeyName(10, "VOXEL_A_57x57.png")
        Me.glyphList.Images.SetKeyName(11, "FISH_B_57x57.png")
        Me.glyphList.Images.SetKeyName(12, "TENT_C_57x57.png")
        Me.glyphList.Images.SetKeyName(13, "ROCKET_D_57x57.png")
        Me.glyphList.Images.SetKeyName(14, "TREE_E_57x57.png")
        Me.glyphList.Images.SetKeyName(15, "ATLAS_F_57x57.png")
        Me.glyphList.Images.SetKeyName(16, "BLANK_57x57.png")
        '
        'imgLineDivider1
        '
        Me.imgLineDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLineDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgLineDivider1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgLineDivider1.Image = CType(resources.GetObject("imgLineDivider1.Image"), System.Drawing.Image)
        Me.imgLineDivider1.Location = New System.Drawing.Point(0, 148)
        Me.imgLineDivider1.Name = "imgLineDivider1"
        Me.imgLineDivider1.Size = New System.Drawing.Size(1441, 10)
        Me.imgLineDivider1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLineDivider1.TabIndex = 81
        Me.imgLineDivider1.TabStop = False
        Me.imgLineDivider1.Tag = "img6"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1388, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 28)
        Me.btnClose.TabIndex = 82
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtPlanetID
        '
        Me.txtPlanetID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlanetID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetID.ForeColor = System.Drawing.Color.Black
        Me.txtPlanetID.Location = New System.Drawing.Point(82, 41)
        Me.txtPlanetID.Name = "txtPlanetID"
        Me.txtPlanetID.ReadOnly = True
        Me.txtPlanetID.Size = New System.Drawing.Size(72, 25)
        Me.txtPlanetID.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Planet ID:"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(602, 891)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 34)
        Me.btnClear.TabIndex = 85
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(198, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Total Planets:"
        '
        'txtTotalPlanets
        '
        Me.txtTotalPlanets.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalPlanets.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPlanets.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPlanets.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPlanets.Location = New System.Drawing.Point(297, 41)
        Me.txtTotalPlanets.Name = "txtTotalPlanets"
        Me.txtTotalPlanets.ReadOnly = True
        Me.txtTotalPlanets.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalPlanets.TabIndex = 168
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(374, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "Total Accounts:"
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalAccounts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAccounts.Location = New System.Drawing.Point(486, 41)
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.ReadOnly = True
        Me.txtTotalAccounts.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalAccounts.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(940, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Total Systems:"
        '
        'txtTotalSystems
        '
        Me.txtTotalSystems.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalSystems.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalSystems.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSystems.ForeColor = System.Drawing.Color.Black
        Me.txtTotalSystems.Location = New System.Drawing.Point(1046, 41)
        Me.txtTotalSystems.Name = "txtTotalSystems"
        Me.txtTotalSystems.ReadOnly = True
        Me.txtTotalSystems.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalSystems.TabIndex = 172
        '
        'frmPlanetEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1471, 936)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalAccounts)
        Me.Controls.Add(Me.txtTotalSystems)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalPlanets)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPlanetID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.imgLineDivider1)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Controls.Add(Me.txtTITLE)
        Me.Controls.Add(Me.pnlPlanetDetails)
        Me.Controls.Add(Me.pnlAccount)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmPlanetEntry"
        Me.Text = "NMS DATABASE: PLANET ENTRY"
        Me.pnlPlanetDetails.ResumeLayout(False)
        Me.pnlPlanetDetails.PerformLayout()
        CType(Me.imgLineDivider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlanets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPlanetInfo.ResumeLayout(False)
        Me.pnlPlanetInfo.PerformLayout()
        Me.Frame_PlanetInfo.ResumeLayout(False)
        Me.Frame_PlanetInfo.PerformLayout()
        CType(Me.dgvBases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseContextMenu.ResumeLayout(False)
        CType(Me.dgvStructures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StructureContextMenu.ResumeLayout(False)
        CType(Me.dgvWaypoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WaypointContextMenu.ResumeLayout(False)
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResourceContextMenu.ResumeLayout(False)
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        CType(Me.imgLineDivider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents pnlPlanetDetails As Panel
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblSelectGlyph As Label
    Friend WithEvents txtTotalBases As TextBox
    Friend WithEvents btnRemoveResource As Button
    Friend WithEvents btnAddResource As Button
    Friend WithEvents comResources As ComboBox
    Friend WithEvents btnSAVE As Button
    Friend WithEvents glyphList As ImageList
    Friend WithEvents txtSelectedGlyphIndex As TextBox
    Friend WithEvents txtPlanetGlyphCode As TextBox
    Friend WithEvents Frame_PlanetGlyphPallet As ScrollableControl
    Friend WithEvents imgLineDivider1 As PictureBox
    Friend WithEvents Frame_PlanetGlyphSet As ScrollableControl
    Friend WithEvents txtTotalFlora As TextBox
    Friend WithEvents lblTotalFauna As Label
    Friend WithEvents txtTotalFauna As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents imgLineDivider4 As PictureBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblPlanetaryNotes As Label
    Friend WithEvents imgCalendar_SelectDiscoveryDate As PictureBox
    Friend WithEvents Frame_PlanetInfo As ScrollableControl
    Friend WithEvents lblSTRUCTURES As Label
    Friend WithEvents dgvStructures As DataGridView
    Friend WithEvents lblWEYPOINTS As Label
    Friend WithEvents dgvWaypoints As DataGridView
    Friend WithEvents lblRESOURCES As Label
    Friend WithEvents dgvResources As DataGridView
    Friend WithEvents dgvBases As DataGridView
    Friend WithEvents lblBASES As Label
    Friend WithEvents comStructures As ComboBox
    Friend WithEvents btnAddStructure As Button
    Friend WithEvents btnRemoveStructure As Button
    Friend WithEvents comWaypoints As ComboBox
    Friend WithEvents btnAddWaypoint As Button
    Friend WithEvents btnRemoveWaypoint As Button
    Friend WithEvents comBases As ComboBox
    Friend WithEvents btnAddBase As Button
    Friend WithEvents btnRemoveBase As Button
    Friend WithEvents txtTotalResources As TextBox
    Friend WithEvents txtTotalWaypoints As TextBox
    Friend WithEvents txtTotalStructures As TextBox
    Friend WithEvents lblDiscoveredBy As Label
    Friend WithEvents txtDiscoveredBy As TextBox
    Friend WithEvents lblDateOfDiscovery As Label
    Friend WithEvents txtDiscoveryDate As MaskedTextBox
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ResourceContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripAddResource As ToolStripMenuItem
    Friend WithEvents ToolStripEditResource As ToolStripMenuItem
    Friend WithEvents ToolStripDeleteResource As ToolStripMenuItem
    Friend WithEvents WaypointContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripAddWaypoint As ToolStripMenuItem
    Friend WithEvents ToolStripEditWaypoint As ToolStripMenuItem
    Friend WithEvents ToolStripDeleteWaypoint As ToolStripMenuItem
    Friend WithEvents StructureContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripAddStructure As ToolStripMenuItem
    Friend WithEvents ToolStripEditStructure As ToolStripMenuItem
    Friend WithEvents ToolStripDeleteStructure As ToolStripMenuItem
    Friend WithEvents BaseContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripAddNewBase As ToolStripMenuItem
    Friend WithEvents ToolStripEditBase As ToolStripMenuItem
    Friend WithEvents ToolStripDeleteBase As ToolStripMenuItem
    Friend WithEvents txtResourceNotes As TextBox
    Friend WithEvents lblResourceNotes As Label
    Friend WithEvents txtSentinalInfo As TextBox
    Friend WithEvents lblSentinalInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGalacticAddress As MaskedTextBox
    Friend WithEvents btnCreatePlanetCode As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlPlanetInfo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSystemID As TextBox
    Friend WithEvents txtRenamedPlanet As TextBox
    Friend WithEvents comSystems As ComboBox
    Friend WithEvents txtCurrentSystem As TextBox
    Friend WithEvents lblCurrentSystem As Label
    Friend WithEvents txtGalacticRegion As TextBox
    Friend WithEvents lblGalacticRegion As Label
    Friend WithEvents lblRenamedPlanet As Label
    Friend WithEvents txtPlanetName As TextBox
    Friend WithEvents lblPlanetName As Label
    Friend WithEvents dgvPlanets As DataGridView
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDefaultSystem As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtWeather As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtExtremeWeather As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalPlanets As TextBox
    Friend WithEvents txtGlyphUnderMouse As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalAccounts As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalSystems As TextBox
    Friend WithEvents btnSaveBaseColumns As Button
    Friend WithEvents btnSaveStructureColumns As Button
    Friend WithEvents btnSaveWaypointColumns As Button
    Friend WithEvents btnSaveResourceColumns As Button
End Class
