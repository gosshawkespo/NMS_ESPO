<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanetEntry_v2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanetEntry_v2))
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOriginalSystemName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.comSystems = New System.Windows.Forms.ComboBox()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.txtCurrentSystem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCurrentSystem = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.dgvPlanets = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinerals = New System.Windows.Forms.Button()
        Me.txtTotalMinerals = New System.Windows.Forms.TextBox()
        Me.btnFlora = New System.Windows.Forms.Button()
        Me.btnFauna = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblPlanetaryNotes = New System.Windows.Forms.Label()
        Me.txtExtremeWeather = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWeather = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSentinalInfo = New System.Windows.Forms.TextBox()
        Me.lblSentinalInfo = New System.Windows.Forms.Label()
        Me.txtResourceNotes = New System.Windows.Forms.TextBox()
        Me.lblResourceNotes = New System.Windows.Forms.Label()
        Me.txtGlyphUnderMouse = New System.Windows.Forms.TextBox()
        Me.btnCreatePlanetCode = New System.Windows.Forms.Button()
        Me.txtGalacticAddress = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscoveryDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDiscoveredBy = New System.Windows.Forms.Label()
        Me.txtDiscoveredBy = New System.Windows.Forms.TextBox()
        Me.lblDateOfDiscovery = New System.Windows.Forms.Label()
        Me.imgCalendar_SelectDiscoveryDate = New System.Windows.Forms.PictureBox()
        Me.txtTotalFlora = New System.Windows.Forms.TextBox()
        Me.txtTotalFauna = New System.Windows.Forms.TextBox()
        Me.Frame_PlanetGlyphSet = New System.Windows.Forms.ScrollableControl()
        Me.Frame_PlanetGlyphPallet = New System.Windows.Forms.ScrollableControl()
        Me.txtPlanetGlyphCode = New System.Windows.Forms.TextBox()
        Me.txtSelectedGlyphIndex = New System.Windows.Forms.TextBox()
        Me.lblSelectGlyph = New System.Windows.Forms.Label()
        Me.pnlPlanetInfo = New System.Windows.Forms.Panel()
        Me.txtOriginalPlanetName = New System.Windows.Forms.TextBox()
        Me.txtGalacticRegion = New System.Windows.Forms.TextBox()
        Me.lblGalacticRegion = New System.Windows.Forms.Label()
        Me.lblOriginalPlanetName = New System.Windows.Forms.Label()
        Me.txtRenamedPlanet = New System.Windows.Forms.TextBox()
        Me.lblCurrentPlanetName = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.btnSaveResourceColumns = New System.Windows.Forms.Button()
        Me.txtTotalResources = New System.Windows.Forms.TextBox()
        Me.lblRESOURCES = New System.Windows.Forms.Label()
        Me.dgvResources = New System.Windows.Forms.DataGridView()
        Me.ResourceContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.comResources = New System.Windows.Forms.ComboBox()
        Me.btnAddResource = New System.Windows.Forms.Button()
        Me.btnRemoveResource = New System.Windows.Forms.Button()
        Me.btnSaveWaypointColumns = New System.Windows.Forms.Button()
        Me.txtTotalWaypoints = New System.Windows.Forms.TextBox()
        Me.comWaypoints = New System.Windows.Forms.ComboBox()
        Me.btnAddWaypoint = New System.Windows.Forms.Button()
        Me.btnRemoveWaypoint = New System.Windows.Forms.Button()
        Me.lblWEYPOINTS = New System.Windows.Forms.Label()
        Me.dgvWaypoints = New System.Windows.Forms.DataGridView()
        Me.WaypointContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteWaypoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.btnSaveStructureColumns = New System.Windows.Forms.Button()
        Me.txtTotalStructures = New System.Windows.Forms.TextBox()
        Me.comStructures = New System.Windows.Forms.ComboBox()
        Me.btnAddStructure = New System.Windows.Forms.Button()
        Me.btnRemoveStructure = New System.Windows.Forms.Button()
        Me.lblSTRUCTURES = New System.Windows.Forms.Label()
        Me.dgvStructures = New System.Windows.Forms.DataGridView()
        Me.StructureContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteStructure = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaveBaseColumns = New System.Windows.Forms.Button()
        Me.comBases = New System.Windows.Forms.ComboBox()
        Me.btnAddBase = New System.Windows.Forms.Button()
        Me.btnRemoveBase = New System.Windows.Forms.Button()
        Me.dgvBases = New System.Windows.Forms.DataGridView()
        Me.BaseContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripAddNewBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripEditBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDeleteBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBASES = New System.Windows.Forms.Label()
        Me.txtTotalBases = New System.Windows.Forms.TextBox()
        Me.lblSystemID = New System.Windows.Forms.Label()
        Me.txtSystemID = New System.Windows.Forms.TextBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.txtDefaultSystem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalAccounts = New System.Windows.Forms.TextBox()
        Me.txtTotalSystems = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalPlanets = New System.Windows.Forms.TextBox()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.glyphList = New System.Windows.Forms.ImageList(Me.components)
        Me.cbOriginalPlanetName = New System.Windows.Forms.CheckBox()
        Me.lblUpdateOptions = New System.Windows.Forms.Label()
        Me.cbNewPlanetName = New System.Windows.Forms.CheckBox()
        Me.pnlAccount.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.dgvPlanets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPlanetInfo.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResourceContextMenu.SuspendLayout()
        CType(Me.dgvWaypoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WaypointContextMenu.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dgvStructures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StructureContextMenu.SuspendLayout()
        CType(Me.dgvBases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseContextMenu.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtTITLE.Size = New System.Drawing.Size(1531, 35)
        Me.txtTITLE.TabIndex = 36
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTITLE2
        '
        Me.txtTITLE2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE2.BackColor = System.Drawing.Color.DarkOrchid
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.Transparent
        Me.txtTITLE2.Location = New System.Drawing.Point(0, 33)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(1531, 32)
        Me.txtTITLE2.TabIndex = 37
        Me.txtTITLE2.Text = "PLANET ENTRY"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlAccount
        '
        Me.pnlAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccount.AutoScroll = True
        Me.pnlAccount.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.pnlAccount.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.pnlAccount.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlAccount.BackgroundImage = CType(resources.GetObject("pnlAccount.BackgroundImage"), System.Drawing.Image)
        Me.pnlAccount.Controls.Add(Me.TextBox1)
        Me.pnlAccount.Controls.Add(Me.Label3)
        Me.pnlAccount.Controls.Add(Me.txtOriginalSystemName)
        Me.pnlAccount.Controls.Add(Me.Label12)
        Me.pnlAccount.Controls.Add(Me.comAccounts)
        Me.pnlAccount.Controls.Add(Me.comSystems)
        Me.pnlAccount.Controls.Add(Me.txtAccountID)
        Me.pnlAccount.Controls.Add(Me.txtCurrentSystem)
        Me.pnlAccount.Controls.Add(Me.Label6)
        Me.pnlAccount.Controls.Add(Me.lblCurrentSystem)
        Me.pnlAccount.Controls.Add(Me.txtVersion)
        Me.pnlAccount.Controls.Add(Me.lblVersion)
        Me.pnlAccount.Controls.Add(Me.txtPlatform)
        Me.pnlAccount.Controls.Add(Me.lblPlatform)
        Me.pnlAccount.Controls.Add(Me.txtAccountName)
        Me.pnlAccount.Controls.Add(Me.lblAccount)
        Me.pnlAccount.Location = New System.Drawing.Point(0, 136)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(1531, 75)
        Me.pnlAccount.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(613, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 25)
        Me.TextBox1.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1101, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Original System:"
        '
        'txtOriginalSystemName
        '
        Me.txtOriginalSystemName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOriginalSystemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOriginalSystemName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalSystemName.ForeColor = System.Drawing.Color.Black
        Me.txtOriginalSystemName.Location = New System.Drawing.Point(1100, 39)
        Me.txtOriginalSystemName.Name = "txtOriginalSystemName"
        Me.txtOriginalSystemName.Size = New System.Drawing.Size(300, 25)
        Me.txtOriginalSystemName.TabIndex = 166
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(545, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "Handle:"
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
        Me.comAccounts.Size = New System.Drawing.Size(227, 23)
        Me.comAccounts.Sorted = True
        Me.comAccounts.TabIndex = 163
        '
        'comSystems
        '
        Me.comSystems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comSystems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.comSystems.BackColor = System.Drawing.Color.SkyBlue
        Me.comSystems.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comSystems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSystems.ForeColor = System.Drawing.Color.Black
        Me.comSystems.FormattingEnabled = True
        Me.comSystems.Location = New System.Drawing.Point(905, 9)
        Me.comSystems.Name = "comSystems"
        Me.comSystems.Size = New System.Drawing.Size(176, 23)
        Me.comSystems.Sorted = True
        Me.comSystems.TabIndex = 162
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
        'txtCurrentSystem
        '
        Me.txtCurrentSystem.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCurrentSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentSystem.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentSystem.Location = New System.Drawing.Point(785, 39)
        Me.txtCurrentSystem.Name = "txtCurrentSystem"
        Me.txtCurrentSystem.Size = New System.Drawing.Size(300, 25)
        Me.txtCurrentSystem.TabIndex = 155
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
        'lblCurrentSystem
        '
        Me.lblCurrentSystem.AutoSize = True
        Me.lblCurrentSystem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSystem.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentSystem.Location = New System.Drawing.Point(785, 11)
        Me.lblCurrentSystem.Name = "lblCurrentSystem"
        Me.lblCurrentSystem.Size = New System.Drawing.Size(108, 17)
        Me.lblCurrentSystem.TabIndex = 158
        Me.lblCurrentSystem.Text = "Current System:"
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
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.MidnightBlue
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Location = New System.Drawing.Point(-4, 212)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1528, 700)
        Me.SplitContainer1.SplitterDistance = 956
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 39
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer5.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer5.Panel1.Controls.Add(Me.dgvPlanets)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer5.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer5.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer5.Panel2.Controls.Add(Me.pnlPlanetInfo)
        Me.SplitContainer5.Size = New System.Drawing.Size(954, 698)
        Me.SplitContainer5.SplitterDistance = 147
        Me.SplitContainer5.SplitterWidth = 10
        Me.SplitContainer5.TabIndex = 0
        '
        'dgvPlanets
        '
        Me.dgvPlanets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanets.Location = New System.Drawing.Point(6, 8)
        Me.dgvPlanets.Name = "dgvPlanets"
        Me.dgvPlanets.Size = New System.Drawing.Size(941, 130)
        Me.dgvPlanets.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnMinerals)
        Me.Panel1.Controls.Add(Me.txtTotalMinerals)
        Me.Panel1.Controls.Add(Me.btnFlora)
        Me.Panel1.Controls.Add(Me.btnFauna)
        Me.Panel1.Controls.Add(Me.txtComments)
        Me.Panel1.Controls.Add(Me.lblPlanetaryNotes)
        Me.Panel1.Controls.Add(Me.txtExtremeWeather)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtWeather)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtSentinalInfo)
        Me.Panel1.Controls.Add(Me.lblSentinalInfo)
        Me.Panel1.Controls.Add(Me.txtResourceNotes)
        Me.Panel1.Controls.Add(Me.lblResourceNotes)
        Me.Panel1.Controls.Add(Me.txtGlyphUnderMouse)
        Me.Panel1.Controls.Add(Me.btnCreatePlanetCode)
        Me.Panel1.Controls.Add(Me.txtGalacticAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDiscoveryDate)
        Me.Panel1.Controls.Add(Me.lblDiscoveredBy)
        Me.Panel1.Controls.Add(Me.txtDiscoveredBy)
        Me.Panel1.Controls.Add(Me.lblDateOfDiscovery)
        Me.Panel1.Controls.Add(Me.imgCalendar_SelectDiscoveryDate)
        Me.Panel1.Controls.Add(Me.txtTotalFlora)
        Me.Panel1.Controls.Add(Me.txtTotalFauna)
        Me.Panel1.Controls.Add(Me.Frame_PlanetGlyphSet)
        Me.Panel1.Controls.Add(Me.Frame_PlanetGlyphPallet)
        Me.Panel1.Controls.Add(Me.txtPlanetGlyphCode)
        Me.Panel1.Controls.Add(Me.txtSelectedGlyphIndex)
        Me.Panel1.Controls.Add(Me.lblSelectGlyph)
        Me.Panel1.Location = New System.Drawing.Point(6, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 400)
        Me.Panel1.TabIndex = 157
        '
        'btnMinerals
        '
        Me.btnMinerals.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMinerals.Location = New System.Drawing.Point(743, 16)
        Me.btnMinerals.Name = "btnMinerals"
        Me.btnMinerals.Size = New System.Drawing.Size(75, 23)
        Me.btnMinerals.TabIndex = 193
        Me.btnMinerals.Text = "Minerals:"
        Me.btnMinerals.UseVisualStyleBackColor = False
        '
        'txtTotalMinerals
        '
        Me.txtTotalMinerals.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalMinerals.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMinerals.ForeColor = System.Drawing.Color.Black
        Me.txtTotalMinerals.Location = New System.Drawing.Point(755, 39)
        Me.txtTotalMinerals.Name = "txtTotalMinerals"
        Me.txtTotalMinerals.Size = New System.Drawing.Size(46, 22)
        Me.txtTotalMinerals.TabIndex = 192
        '
        'btnFlora
        '
        Me.btnFlora.BackColor = System.Drawing.Color.PaleGreen
        Me.btnFlora.Location = New System.Drawing.Point(662, 16)
        Me.btnFlora.Name = "btnFlora"
        Me.btnFlora.Size = New System.Drawing.Size(75, 23)
        Me.btnFlora.TabIndex = 191
        Me.btnFlora.Text = "Flora:"
        Me.btnFlora.UseVisualStyleBackColor = False
        '
        'btnFauna
        '
        Me.btnFauna.BackColor = System.Drawing.Color.PaleGreen
        Me.btnFauna.Location = New System.Drawing.Point(581, 15)
        Me.btnFauna.Name = "btnFauna"
        Me.btnFauna.Size = New System.Drawing.Size(75, 23)
        Me.btnFauna.TabIndex = 190
        Me.btnFauna.Text = "Fauna:"
        Me.btnFauna.UseVisualStyleBackColor = False
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.Gainsboro
        Me.txtComments.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.ForeColor = System.Drawing.Color.Black
        Me.txtComments.Location = New System.Drawing.Point(0, 355)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComments.Size = New System.Drawing.Size(936, 38)
        Me.txtComments.TabIndex = 189
        '
        'lblPlanetaryNotes
        '
        Me.lblPlanetaryNotes.AutoSize = True
        Me.lblPlanetaryNotes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlanetaryNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetaryNotes.ForeColor = System.Drawing.Color.Black
        Me.lblPlanetaryNotes.Location = New System.Drawing.Point(0, 334)
        Me.lblPlanetaryNotes.Name = "lblPlanetaryNotes"
        Me.lblPlanetaryNotes.Size = New System.Drawing.Size(112, 17)
        Me.lblPlanetaryNotes.TabIndex = 188
        Me.lblPlanetaryNotes.Text = "Planetary Notes:"
        '
        'txtExtremeWeather
        '
        Me.txtExtremeWeather.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtExtremeWeather.BackColor = System.Drawing.Color.Gainsboro
        Me.txtExtremeWeather.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtremeWeather.ForeColor = System.Drawing.Color.Black
        Me.txtExtremeWeather.Location = New System.Drawing.Point(902, 255)
        Me.txtExtremeWeather.Name = "txtExtremeWeather"
        Me.txtExtremeWeather.Size = New System.Drawing.Size(37, 22)
        Me.txtExtremeWeather.TabIndex = 187
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(828, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "Extreme? :"
        '
        'txtWeather
        '
        Me.txtWeather.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWeather.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeather.ForeColor = System.Drawing.Color.Black
        Me.txtWeather.Location = New System.Drawing.Point(685, 280)
        Me.txtWeather.Multiline = True
        Me.txtWeather.Name = "txtWeather"
        Me.txtWeather.Size = New System.Drawing.Size(253, 48)
        Me.txtWeather.TabIndex = 185
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(686, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Weather? :"
        '
        'txtSentinalInfo
        '
        Me.txtSentinalInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSentinalInfo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSentinalInfo.ForeColor = System.Drawing.Color.Black
        Me.txtSentinalInfo.Location = New System.Drawing.Point(0, 280)
        Me.txtSentinalInfo.Multiline = True
        Me.txtSentinalInfo.Name = "txtSentinalInfo"
        Me.txtSentinalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSentinalInfo.Size = New System.Drawing.Size(319, 48)
        Me.txtSentinalInfo.TabIndex = 183
        '
        'lblSentinalInfo
        '
        Me.lblSentinalInfo.AutoSize = True
        Me.lblSentinalInfo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSentinalInfo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentinalInfo.ForeColor = System.Drawing.Color.Black
        Me.lblSentinalInfo.Location = New System.Drawing.Point(0, 258)
        Me.lblSentinalInfo.Name = "lblSentinalInfo"
        Me.lblSentinalInfo.Size = New System.Drawing.Size(91, 17)
        Me.lblSentinalInfo.TabIndex = 182
        Me.lblSentinalInfo.Text = "Sentinal Info:"
        '
        'txtResourceNotes
        '
        Me.txtResourceNotes.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResourceNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResourceNotes.ForeColor = System.Drawing.Color.Black
        Me.txtResourceNotes.Location = New System.Drawing.Point(329, 280)
        Me.txtResourceNotes.Multiline = True
        Me.txtResourceNotes.Name = "txtResourceNotes"
        Me.txtResourceNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResourceNotes.Size = New System.Drawing.Size(346, 48)
        Me.txtResourceNotes.TabIndex = 181
        '
        'lblResourceNotes
        '
        Me.lblResourceNotes.AutoSize = True
        Me.lblResourceNotes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblResourceNotes.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceNotes.ForeColor = System.Drawing.Color.Black
        Me.lblResourceNotes.Location = New System.Drawing.Point(329, 258)
        Me.lblResourceNotes.Name = "lblResourceNotes"
        Me.lblResourceNotes.Size = New System.Drawing.Size(109, 17)
        Me.lblResourceNotes.TabIndex = 180
        Me.lblResourceNotes.Text = "Resource Notes:"
        '
        'txtGlyphUnderMouse
        '
        Me.txtGlyphUnderMouse.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGlyphUnderMouse.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlyphUnderMouse.ForeColor = System.Drawing.Color.Black
        Me.txtGlyphUnderMouse.Location = New System.Drawing.Point(63, 128)
        Me.txtGlyphUnderMouse.Name = "txtGlyphUnderMouse"
        Me.txtGlyphUnderMouse.Size = New System.Drawing.Size(34, 25)
        Me.txtGlyphUnderMouse.TabIndex = 179
        '
        'btnCreatePlanetCode
        '
        Me.btnCreatePlanetCode.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCreatePlanetCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCreatePlanetCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePlanetCode.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePlanetCode.Location = New System.Drawing.Point(5, 8)
        Me.btnCreatePlanetCode.Name = "btnCreatePlanetCode"
        Me.btnCreatePlanetCode.Size = New System.Drawing.Size(158, 33)
        Me.btnCreatePlanetCode.TabIndex = 178
        Me.btnCreatePlanetCode.Text = "Create Planet Code"
        Me.btnCreatePlanetCode.UseVisualStyleBackColor = False
        '
        'txtGalacticAddress
        '
        Me.txtGalacticAddress.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGalacticAddress.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticAddress.Location = New System.Drawing.Point(455, 13)
        Me.txtGalacticAddress.Mask = ">AAAA:AAAA:AAAA:AAAA"
        Me.txtGalacticAddress.Name = "txtGalacticAddress"
        Me.txtGalacticAddress.Size = New System.Drawing.Size(120, 25)
        Me.txtGalacticAddress.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Galactic Address:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiscoveryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(410, 128)
        Me.txtDiscoveryDate.Mask = "00/00/0000 90:00"
        Me.txtDiscoveryDate.Name = "txtDiscoveryDate"
        Me.txtDiscoveryDate.Size = New System.Drawing.Size(129, 25)
        Me.txtDiscoveryDate.TabIndex = 175
        Me.txtDiscoveryDate.ValidatingType = GetType(Date)
        '
        'lblDiscoveredBy
        '
        Me.lblDiscoveredBy.AutoSize = True
        Me.lblDiscoveredBy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.lblDiscoveredBy.Location = New System.Drawing.Point(582, 131)
        Me.lblDiscoveredBy.Name = "lblDiscoveredBy"
        Me.lblDiscoveredBy.Size = New System.Drawing.Size(103, 17)
        Me.lblDiscoveredBy.TabIndex = 174
        Me.lblDiscoveredBy.Text = "Discovered By:"
        '
        'txtDiscoveredBy
        '
        Me.txtDiscoveredBy.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(699, 128)
        Me.txtDiscoveredBy.Name = "txtDiscoveredBy"
        Me.txtDiscoveredBy.Size = New System.Drawing.Size(239, 25)
        Me.txtDiscoveredBy.TabIndex = 173
        '
        'lblDateOfDiscovery
        '
        Me.lblDateOfDiscovery.AutoSize = True
        Me.lblDateOfDiscovery.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDateOfDiscovery.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfDiscovery.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfDiscovery.Location = New System.Drawing.Point(280, 131)
        Me.lblDateOfDiscovery.Name = "lblDateOfDiscovery"
        Me.lblDateOfDiscovery.Size = New System.Drawing.Size(124, 17)
        Me.lblDateOfDiscovery.TabIndex = 172
        Me.lblDateOfDiscovery.Text = "Date of Discovery:"
        '
        'imgCalendar_SelectDiscoveryDate
        '
        Me.imgCalendar_SelectDiscoveryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imgCalendar_SelectDiscoveryDate.Image = CType(resources.GetObject("imgCalendar_SelectDiscoveryDate.Image"), System.Drawing.Image)
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(550, 125)
        Me.imgCalendar_SelectDiscoveryDate.Name = "imgCalendar_SelectDiscoveryDate"
        Me.imgCalendar_SelectDiscoveryDate.Size = New System.Drawing.Size(24, 27)
        Me.imgCalendar_SelectDiscoveryDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCalendar_SelectDiscoveryDate.TabIndex = 171
        Me.imgCalendar_SelectDiscoveryDate.TabStop = False
        Me.imgCalendar_SelectDiscoveryDate.Tag = "btn7"
        '
        'txtTotalFlora
        '
        Me.txtTotalFlora.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalFlora.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFlora.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFlora.Location = New System.Drawing.Point(674, 39)
        Me.txtTotalFlora.Name = "txtTotalFlora"
        Me.txtTotalFlora.Size = New System.Drawing.Size(46, 22)
        Me.txtTotalFlora.TabIndex = 170
        '
        'txtTotalFauna
        '
        Me.txtTotalFauna.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalFauna.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFauna.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFauna.Location = New System.Drawing.Point(593, 39)
        Me.txtTotalFauna.Name = "txtTotalFauna"
        Me.txtTotalFauna.Size = New System.Drawing.Size(46, 22)
        Me.txtTotalFauna.TabIndex = 168
        '
        'Frame_PlanetGlyphSet
        '
        Me.Frame_PlanetGlyphSet.AllowDrop = True
        Me.Frame_PlanetGlyphSet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame_PlanetGlyphSet.AutoScroll = True
        Me.Frame_PlanetGlyphSet.BackColor = System.Drawing.Color.Blue
        Me.Frame_PlanetGlyphSet.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_PlanetGlyphSet.ForeColor = System.Drawing.Color.Black
        Me.Frame_PlanetGlyphSet.Location = New System.Drawing.Point(0, 67)
        Me.Frame_PlanetGlyphSet.Name = "Frame_PlanetGlyphSet"
        Me.Frame_PlanetGlyphSet.Size = New System.Drawing.Size(938, 51)
        Me.Frame_PlanetGlyphSet.TabIndex = 166
        Me.Frame_PlanetGlyphSet.Tag = "frm1"
        Me.Frame_PlanetGlyphSet.Text = "ScrollableControl3"
        '
        'Frame_PlanetGlyphPallet
        '
        Me.Frame_PlanetGlyphPallet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame_PlanetGlyphPallet.AutoScroll = True
        Me.Frame_PlanetGlyphPallet.BackColor = System.Drawing.Color.Blue
        Me.Frame_PlanetGlyphPallet.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame_PlanetGlyphPallet.ForeColor = System.Drawing.Color.Black
        Me.Frame_PlanetGlyphPallet.Location = New System.Drawing.Point(0, 159)
        Me.Frame_PlanetGlyphPallet.Name = "Frame_PlanetGlyphPallet"
        Me.Frame_PlanetGlyphPallet.Size = New System.Drawing.Size(941, 89)
        Me.Frame_PlanetGlyphPallet.TabIndex = 165
        Me.Frame_PlanetGlyphPallet.Tag = "frm1"
        Me.Frame_PlanetGlyphPallet.Text = "ScrollableControl3"
        '
        'txtPlanetGlyphCode
        '
        Me.txtPlanetGlyphCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlanetGlyphCode.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetGlyphCode.ForeColor = System.Drawing.Color.Black
        Me.txtPlanetGlyphCode.Location = New System.Drawing.Point(169, 13)
        Me.txtPlanetGlyphCode.Name = "txtPlanetGlyphCode"
        Me.txtPlanetGlyphCode.Size = New System.Drawing.Size(150, 25)
        Me.txtPlanetGlyphCode.TabIndex = 164
        '
        'txtSelectedGlyphIndex
        '
        Me.txtSelectedGlyphIndex.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSelectedGlyphIndex.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedGlyphIndex.ForeColor = System.Drawing.Color.Black
        Me.txtSelectedGlyphIndex.Location = New System.Drawing.Point(232, 128)
        Me.txtSelectedGlyphIndex.Name = "txtSelectedGlyphIndex"
        Me.txtSelectedGlyphIndex.Size = New System.Drawing.Size(34, 25)
        Me.txtSelectedGlyphIndex.TabIndex = 163
        '
        'lblSelectGlyph
        '
        Me.lblSelectGlyph.AutoSize = True
        Me.lblSelectGlyph.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectGlyph.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGlyph.ForeColor = System.Drawing.Color.Black
        Me.lblSelectGlyph.Location = New System.Drawing.Point(103, 131)
        Me.lblSelectGlyph.Name = "lblSelectGlyph"
        Me.lblSelectGlyph.Size = New System.Drawing.Size(127, 17)
        Me.lblSelectGlyph.TabIndex = 162
        Me.lblSelectGlyph.Text = "SELECTED GLYPH:"
        '
        'pnlPlanetInfo
        '
        Me.pnlPlanetInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPlanetInfo.BackgroundImage = CType(resources.GetObject("pnlPlanetInfo.BackgroundImage"), System.Drawing.Image)
        Me.pnlPlanetInfo.Controls.Add(Me.txtOriginalPlanetName)
        Me.pnlPlanetInfo.Controls.Add(Me.txtGalacticRegion)
        Me.pnlPlanetInfo.Controls.Add(Me.lblGalacticRegion)
        Me.pnlPlanetInfo.Controls.Add(Me.lblOriginalPlanetName)
        Me.pnlPlanetInfo.Controls.Add(Me.txtRenamedPlanet)
        Me.pnlPlanetInfo.Controls.Add(Me.lblCurrentPlanetName)
        Me.pnlPlanetInfo.Location = New System.Drawing.Point(6, 8)
        Me.pnlPlanetInfo.Name = "pnlPlanetInfo"
        Me.pnlPlanetInfo.Size = New System.Drawing.Size(941, 121)
        Me.pnlPlanetInfo.TabIndex = 156
        '
        'txtOriginalPlanetName
        '
        Me.txtOriginalPlanetName.BackColor = System.Drawing.Color.Silver
        Me.txtOriginalPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriginalPlanetName.ForeColor = System.Drawing.Color.Black
        Me.txtOriginalPlanetName.Location = New System.Drawing.Point(528, 82)
        Me.txtOriginalPlanetName.Name = "txtOriginalPlanetName"
        Me.txtOriginalPlanetName.Size = New System.Drawing.Size(408, 25)
        Me.txtOriginalPlanetName.TabIndex = 163
        '
        'txtGalacticRegion
        '
        Me.txtGalacticRegion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticRegion.ForeColor = System.Drawing.Color.Black
        Me.txtGalacticRegion.Location = New System.Drawing.Point(1, 28)
        Me.txtGalacticRegion.Name = "txtGalacticRegion"
        Me.txtGalacticRegion.Size = New System.Drawing.Size(311, 25)
        Me.txtGalacticRegion.TabIndex = 156
        '
        'lblGalacticRegion
        '
        Me.lblGalacticRegion.AutoSize = True
        Me.lblGalacticRegion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalacticRegion.ForeColor = System.Drawing.Color.Black
        Me.lblGalacticRegion.Location = New System.Drawing.Point(1, 8)
        Me.lblGalacticRegion.Name = "lblGalacticRegion"
        Me.lblGalacticRegion.Size = New System.Drawing.Size(104, 17)
        Me.lblGalacticRegion.TabIndex = 160
        Me.lblGalacticRegion.Text = "Galactic Region"
        '
        'lblOriginalPlanetName
        '
        Me.lblOriginalPlanetName.AutoSize = True
        Me.lblOriginalPlanetName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblOriginalPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalPlanetName.ForeColor = System.Drawing.Color.Black
        Me.lblOriginalPlanetName.Location = New System.Drawing.Point(528, 62)
        Me.lblOriginalPlanetName.Name = "lblOriginalPlanetName"
        Me.lblOriginalPlanetName.Size = New System.Drawing.Size(193, 17)
        Me.lblOriginalPlanetName.TabIndex = 161
        Me.lblOriginalPlanetName.Text = "Original Planet / Moon Name:"
        '
        'txtRenamedPlanet
        '
        Me.txtRenamedPlanet.BackColor = System.Drawing.Color.Silver
        Me.txtRenamedPlanet.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenamedPlanet.ForeColor = System.Drawing.Color.Black
        Me.txtRenamedPlanet.Location = New System.Drawing.Point(1, 82)
        Me.txtRenamedPlanet.Name = "txtRenamedPlanet"
        Me.txtRenamedPlanet.Size = New System.Drawing.Size(500, 25)
        Me.txtRenamedPlanet.TabIndex = 157
        '
        'lblCurrentPlanetName
        '
        Me.lblCurrentPlanetName.AutoSize = True
        Me.lblCurrentPlanetName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCurrentPlanetName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlanetName.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentPlanetName.Location = New System.Drawing.Point(1, 62)
        Me.lblCurrentPlanetName.Name = "lblCurrentPlanetName"
        Me.lblCurrentPlanetName.Size = New System.Drawing.Size(148, 17)
        Me.lblCurrentPlanetName.TabIndex = 159
        Me.lblCurrentPlanetName.Text = "Current Planet / Moon"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(560, 698)
        Me.SplitContainer2.SplitterDistance = 322
        Me.SplitContainer2.SplitterWidth = 10
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.DodgerBlue
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnSaveResourceColumns)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTotalResources)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblRESOURCES)
        Me.SplitContainer3.Panel1.Controls.Add(Me.dgvResources)
        Me.SplitContainer3.Panel1.Controls.Add(Me.comResources)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAddResource)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnRemoveResource)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnSaveWaypointColumns)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtTotalWaypoints)
        Me.SplitContainer3.Panel2.Controls.Add(Me.comWaypoints)
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnAddWaypoint)
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnRemoveWaypoint)
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblWEYPOINTS)
        Me.SplitContainer3.Panel2.Controls.Add(Me.dgvWaypoints)
        Me.SplitContainer3.Size = New System.Drawing.Size(560, 322)
        Me.SplitContainer3.SplitterDistance = 154
        Me.SplitContainer3.SplitterWidth = 10
        Me.SplitContainer3.TabIndex = 0
        '
        'btnSaveResourceColumns
        '
        Me.btnSaveResourceColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveResourceColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveResourceColumns.BackgroundImage = CType(resources.GetObject("btnSaveResourceColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveResourceColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveResourceColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveResourceColumns.Location = New System.Drawing.Point(382, 5)
        Me.btnSaveResourceColumns.Name = "btnSaveResourceColumns"
        Me.btnSaveResourceColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveResourceColumns.TabIndex = 165
        Me.btnSaveResourceColumns.UseVisualStyleBackColor = False
        '
        'txtTotalResources
        '
        Me.txtTotalResources.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalResources.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalResources.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalResources.ForeColor = System.Drawing.Color.Black
        Me.txtTotalResources.Location = New System.Drawing.Point(470, 4)
        Me.txtTotalResources.Name = "txtTotalResources"
        Me.txtTotalResources.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalResources.TabIndex = 164
        Me.txtTotalResources.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRESOURCES
        '
        Me.lblRESOURCES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRESOURCES.AutoSize = True
        Me.lblRESOURCES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRESOURCES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRESOURCES.ForeColor = System.Drawing.Color.Black
        Me.lblRESOURCES.Location = New System.Drawing.Point(31, 8)
        Me.lblRESOURCES.Name = "lblRESOURCES"
        Me.lblRESOURCES.Size = New System.Drawing.Size(90, 17)
        Me.lblRESOURCES.TabIndex = 163
        Me.lblRESOURCES.Text = "RESOURCES:"
        '
        'dgvResources
        '
        Me.dgvResources.AllowUserToAddRows = False
        Me.dgvResources.AllowUserToDeleteRows = False
        Me.dgvResources.AllowUserToOrderColumns = True
        Me.dgvResources.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResources.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResources.ContextMenuStrip = Me.ResourceContextMenu
        Me.dgvResources.Location = New System.Drawing.Point(5, 28)
        Me.dgvResources.Name = "dgvResources"
        Me.dgvResources.Size = New System.Drawing.Size(510, 120)
        Me.dgvResources.TabIndex = 162
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
        Me.comResources.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comResources.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comResources.BackColor = System.Drawing.Color.SkyBlue
        Me.comResources.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comResources.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comResources.ForeColor = System.Drawing.Color.Black
        Me.comResources.FormattingEnabled = True
        Me.comResources.Location = New System.Drawing.Point(127, 4)
        Me.comResources.Name = "comResources"
        Me.comResources.Size = New System.Drawing.Size(250, 23)
        Me.comResources.Sorted = True
        Me.comResources.TabIndex = 159
        '
        'btnAddResource
        '
        Me.btnAddResource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddResource.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddResource.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddResource.Location = New System.Drawing.Point(410, 5)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Size = New System.Drawing.Size(20, 23)
        Me.btnAddResource.TabIndex = 160
        Me.btnAddResource.Text = "+"
        Me.btnAddResource.UseVisualStyleBackColor = False
        '
        'btnRemoveResource
        '
        Me.btnRemoveResource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveResource.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveResource.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveResource.Location = New System.Drawing.Point(433, 5)
        Me.btnRemoveResource.Name = "btnRemoveResource"
        Me.btnRemoveResource.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveResource.TabIndex = 161
        Me.btnRemoveResource.Text = "-"
        Me.btnRemoveResource.UseVisualStyleBackColor = False
        '
        'btnSaveWaypointColumns
        '
        Me.btnSaveWaypointColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveWaypointColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveWaypointColumns.BackgroundImage = CType(resources.GetObject("btnSaveWaypointColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveWaypointColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveWaypointColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWaypointColumns.Location = New System.Drawing.Point(382, 5)
        Me.btnSaveWaypointColumns.Name = "btnSaveWaypointColumns"
        Me.btnSaveWaypointColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveWaypointColumns.TabIndex = 166
        Me.btnSaveWaypointColumns.UseVisualStyleBackColor = False
        '
        'txtTotalWaypoints
        '
        Me.txtTotalWaypoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalWaypoints.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalWaypoints.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWaypoints.ForeColor = System.Drawing.Color.Black
        Me.txtTotalWaypoints.Location = New System.Drawing.Point(470, 4)
        Me.txtTotalWaypoints.Name = "txtTotalWaypoints"
        Me.txtTotalWaypoints.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalWaypoints.TabIndex = 165
        Me.txtTotalWaypoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comWaypoints
        '
        Me.comWaypoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comWaypoints.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comWaypoints.BackColor = System.Drawing.Color.SkyBlue
        Me.comWaypoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comWaypoints.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comWaypoints.ForeColor = System.Drawing.Color.Black
        Me.comWaypoints.FormattingEnabled = True
        Me.comWaypoints.Location = New System.Drawing.Point(127, 4)
        Me.comWaypoints.Name = "comWaypoints"
        Me.comWaypoints.Size = New System.Drawing.Size(250, 23)
        Me.comWaypoints.Sorted = True
        Me.comWaypoints.TabIndex = 162
        '
        'btnAddWaypoint
        '
        Me.btnAddWaypoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddWaypoint.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddWaypoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWaypoint.Location = New System.Drawing.Point(410, 5)
        Me.btnAddWaypoint.Name = "btnAddWaypoint"
        Me.btnAddWaypoint.Size = New System.Drawing.Size(20, 23)
        Me.btnAddWaypoint.TabIndex = 163
        Me.btnAddWaypoint.Text = "+"
        Me.btnAddWaypoint.UseVisualStyleBackColor = False
        '
        'btnRemoveWaypoint
        '
        Me.btnRemoveWaypoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveWaypoint.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveWaypoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveWaypoint.Location = New System.Drawing.Point(433, 5)
        Me.btnRemoveWaypoint.Name = "btnRemoveWaypoint"
        Me.btnRemoveWaypoint.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveWaypoint.TabIndex = 164
        Me.btnRemoveWaypoint.Text = "-"
        Me.btnRemoveWaypoint.UseVisualStyleBackColor = False
        '
        'lblWEYPOINTS
        '
        Me.lblWEYPOINTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWEYPOINTS.AutoSize = True
        Me.lblWEYPOINTS.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWEYPOINTS.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEYPOINTS.ForeColor = System.Drawing.Color.Black
        Me.lblWEYPOINTS.Location = New System.Drawing.Point(29, 8)
        Me.lblWEYPOINTS.Name = "lblWEYPOINTS"
        Me.lblWEYPOINTS.Size = New System.Drawing.Size(92, 17)
        Me.lblWEYPOINTS.TabIndex = 161
        Me.lblWEYPOINTS.Text = "WAYPOINTS:"
        '
        'dgvWaypoints
        '
        Me.dgvWaypoints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWaypoints.ContextMenuStrip = Me.WaypointContextMenu
        Me.dgvWaypoints.Location = New System.Drawing.Point(5, 28)
        Me.dgvWaypoints.Name = "dgvWaypoints"
        Me.dgvWaypoints.Size = New System.Drawing.Size(510, 103)
        Me.dgvWaypoints.TabIndex = 160
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
        'SplitContainer4
        '
        Me.SplitContainer4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnSaveStructureColumns)
        Me.SplitContainer4.Panel1.Controls.Add(Me.txtTotalStructures)
        Me.SplitContainer4.Panel1.Controls.Add(Me.comStructures)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnAddStructure)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnRemoveStructure)
        Me.SplitContainer4.Panel1.Controls.Add(Me.lblSTRUCTURES)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgvStructures)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnSaveBaseColumns)
        Me.SplitContainer4.Panel2.Controls.Add(Me.comBases)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnAddBase)
        Me.SplitContainer4.Panel2.Controls.Add(Me.btnRemoveBase)
        Me.SplitContainer4.Panel2.Controls.Add(Me.dgvBases)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lblBASES)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtTotalBases)
        Me.SplitContainer4.Size = New System.Drawing.Size(560, 366)
        Me.SplitContainer4.SplitterDistance = 159
        Me.SplitContainer4.SplitterWidth = 10
        Me.SplitContainer4.TabIndex = 0
        '
        'btnSaveStructureColumns
        '
        Me.btnSaveStructureColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveStructureColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveStructureColumns.BackgroundImage = CType(resources.GetObject("btnSaveStructureColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveStructureColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveStructureColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStructureColumns.Location = New System.Drawing.Point(382, 5)
        Me.btnSaveStructureColumns.Name = "btnSaveStructureColumns"
        Me.btnSaveStructureColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveStructureColumns.TabIndex = 167
        Me.btnSaveStructureColumns.UseVisualStyleBackColor = False
        '
        'txtTotalStructures
        '
        Me.txtTotalStructures.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalStructures.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalStructures.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalStructures.ForeColor = System.Drawing.Color.Black
        Me.txtTotalStructures.Location = New System.Drawing.Point(470, 4)
        Me.txtTotalStructures.Name = "txtTotalStructures"
        Me.txtTotalStructures.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalStructures.TabIndex = 166
        Me.txtTotalStructures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comStructures
        '
        Me.comStructures.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comStructures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comStructures.BackColor = System.Drawing.Color.SkyBlue
        Me.comStructures.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comStructures.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comStructures.ForeColor = System.Drawing.Color.Black
        Me.comStructures.FormattingEnabled = True
        Me.comStructures.Location = New System.Drawing.Point(127, 4)
        Me.comStructures.Name = "comStructures"
        Me.comStructures.Size = New System.Drawing.Size(250, 23)
        Me.comStructures.Sorted = True
        Me.comStructures.TabIndex = 163
        '
        'btnAddStructure
        '
        Me.btnAddStructure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddStructure.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddStructure.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStructure.Location = New System.Drawing.Point(410, 5)
        Me.btnAddStructure.Name = "btnAddStructure"
        Me.btnAddStructure.Size = New System.Drawing.Size(20, 23)
        Me.btnAddStructure.TabIndex = 164
        Me.btnAddStructure.Text = "+"
        Me.btnAddStructure.UseVisualStyleBackColor = False
        '
        'btnRemoveStructure
        '
        Me.btnRemoveStructure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveStructure.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveStructure.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveStructure.Location = New System.Drawing.Point(433, 5)
        Me.btnRemoveStructure.Name = "btnRemoveStructure"
        Me.btnRemoveStructure.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveStructure.TabIndex = 165
        Me.btnRemoveStructure.Text = "-"
        Me.btnRemoveStructure.UseVisualStyleBackColor = False
        '
        'lblSTRUCTURES
        '
        Me.lblSTRUCTURES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSTRUCTURES.AutoSize = True
        Me.lblSTRUCTURES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSTRUCTURES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTRUCTURES.ForeColor = System.Drawing.Color.Black
        Me.lblSTRUCTURES.Location = New System.Drawing.Point(29, 8)
        Me.lblSTRUCTURES.Name = "lblSTRUCTURES"
        Me.lblSTRUCTURES.Size = New System.Drawing.Size(99, 17)
        Me.lblSTRUCTURES.TabIndex = 162
        Me.lblSTRUCTURES.Text = "STRUCTURES:"
        '
        'dgvStructures
        '
        Me.dgvStructures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStructures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStructures.ContextMenuStrip = Me.StructureContextMenu
        Me.dgvStructures.Location = New System.Drawing.Point(5, 28)
        Me.dgvStructures.Name = "dgvStructures"
        Me.dgvStructures.Size = New System.Drawing.Size(510, 123)
        Me.dgvStructures.TabIndex = 161
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
        'btnSaveBaseColumns
        '
        Me.btnSaveBaseColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveBaseColumns.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSaveBaseColumns.BackgroundImage = CType(resources.GetObject("btnSaveBaseColumns.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveBaseColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveBaseColumns.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBaseColumns.Location = New System.Drawing.Point(382, 5)
        Me.btnSaveBaseColumns.Name = "btnSaveBaseColumns"
        Me.btnSaveBaseColumns.Size = New System.Drawing.Size(25, 22)
        Me.btnSaveBaseColumns.TabIndex = 168
        Me.btnSaveBaseColumns.UseVisualStyleBackColor = False
        '
        'comBases
        '
        Me.comBases.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comBases.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comBases.BackColor = System.Drawing.Color.SkyBlue
        Me.comBases.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comBases.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBases.ForeColor = System.Drawing.Color.Black
        Me.comBases.FormattingEnabled = True
        Me.comBases.Location = New System.Drawing.Point(127, 4)
        Me.comBases.Name = "comBases"
        Me.comBases.Size = New System.Drawing.Size(250, 23)
        Me.comBases.Sorted = True
        Me.comBases.TabIndex = 165
        '
        'btnAddBase
        '
        Me.btnAddBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBase.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddBase.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBase.Location = New System.Drawing.Point(410, 5)
        Me.btnAddBase.Name = "btnAddBase"
        Me.btnAddBase.Size = New System.Drawing.Size(20, 23)
        Me.btnAddBase.TabIndex = 166
        Me.btnAddBase.Text = "+"
        Me.btnAddBase.UseVisualStyleBackColor = False
        '
        'btnRemoveBase
        '
        Me.btnRemoveBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveBase.BackColor = System.Drawing.Color.Crimson
        Me.btnRemoveBase.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveBase.Location = New System.Drawing.Point(433, 5)
        Me.btnRemoveBase.Name = "btnRemoveBase"
        Me.btnRemoveBase.Size = New System.Drawing.Size(20, 23)
        Me.btnRemoveBase.TabIndex = 167
        Me.btnRemoveBase.Text = "-"
        Me.btnRemoveBase.UseVisualStyleBackColor = False
        '
        'dgvBases
        '
        Me.dgvBases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBases.ContextMenuStrip = Me.BaseContextMenu
        Me.dgvBases.Location = New System.Drawing.Point(5, 28)
        Me.dgvBases.Name = "dgvBases"
        Me.dgvBases.Size = New System.Drawing.Size(510, 143)
        Me.dgvBases.TabIndex = 164
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
        Me.lblBASES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBASES.AutoSize = True
        Me.lblBASES.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblBASES.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBASES.ForeColor = System.Drawing.Color.Black
        Me.lblBASES.Location = New System.Drawing.Point(29, 8)
        Me.lblBASES.Name = "lblBASES"
        Me.lblBASES.Size = New System.Drawing.Size(53, 17)
        Me.lblBASES.TabIndex = 163
        Me.lblBASES.Text = "BASES:"
        '
        'txtTotalBases
        '
        Me.txtTotalBases.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalBases.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalBases.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBases.ForeColor = System.Drawing.Color.Black
        Me.txtTotalBases.Location = New System.Drawing.Point(470, 4)
        Me.txtTotalBases.Name = "txtTotalBases"
        Me.txtTotalBases.Size = New System.Drawing.Size(45, 25)
        Me.txtTotalBases.TabIndex = 162
        Me.txtTotalBases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSystemID
        '
        Me.lblSystemID.AutoSize = True
        Me.lblSystemID.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSystemID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemID.Location = New System.Drawing.Point(974, 11)
        Me.lblSystemID.Name = "lblSystemID"
        Me.lblSystemID.Size = New System.Drawing.Size(75, 17)
        Me.lblSystemID.TabIndex = 165
        Me.lblSystemID.Text = "System ID:"
        '
        'txtSystemID
        '
        Me.txtSystemID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSystemID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSystemID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemID.ForeColor = System.Drawing.Color.Black
        Me.txtSystemID.Location = New System.Drawing.Point(1059, 7)
        Me.txtSystemID.Name = "txtSystemID"
        Me.txtSystemID.Size = New System.Drawing.Size(68, 25)
        Me.txtSystemID.TabIndex = 164
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.BackColor = System.Drawing.Color.RoyalBlue
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.Controls.Add(Me.txtDefaultSystem)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label11)
        Me.pnlTop.Controls.Add(Me.Label10)
        Me.pnlTop.Controls.Add(Me.txtTotalAccounts)
        Me.pnlTop.Controls.Add(Me.lblSystemID)
        Me.pnlTop.Controls.Add(Me.txtTotalSystems)
        Me.pnlTop.Controls.Add(Me.Label9)
        Me.pnlTop.Controls.Add(Me.txtSystemID)
        Me.pnlTop.Controls.Add(Me.txtTotalPlanets)
        Me.pnlTop.Controls.Add(Me.txtPlanetID)
        Me.pnlTop.Controls.Add(Me.Label5)
        Me.pnlTop.Location = New System.Drawing.Point(0, 96)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1531, 41)
        Me.pnlTop.TabIndex = 40
        '
        'txtDefaultSystem
        '
        Me.txtDefaultSystem.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDefaultSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDefaultSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefaultSystem.ForeColor = System.Drawing.Color.Black
        Me.txtDefaultSystem.Location = New System.Drawing.Point(1266, 7)
        Me.txtDefaultSystem.Name = "txtDefaultSystem"
        Me.txtDefaultSystem.Size = New System.Drawing.Size(247, 25)
        Me.txtDefaultSystem.TabIndex = 183
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1154, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "Default System:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(785, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Total Systems:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(591, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Total Accounts:"
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalAccounts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAccounts.Location = New System.Drawing.Point(703, 7)
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.ReadOnly = True
        Me.txtTotalAccounts.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalAccounts.TabIndex = 178
        '
        'txtTotalSystems
        '
        Me.txtTotalSystems.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalSystems.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalSystems.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSystems.ForeColor = System.Drawing.Color.Black
        Me.txtTotalSystems.Location = New System.Drawing.Point(891, 7)
        Me.txtTotalSystems.Name = "txtTotalSystems"
        Me.txtTotalSystems.ReadOnly = True
        Me.txtTotalSystems.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalSystems.TabIndex = 180
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(365, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 177
        Me.Label9.Text = "Total Planets:"
        '
        'txtTotalPlanets
        '
        Me.txtTotalPlanets.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalPlanets.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPlanets.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPlanets.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPlanets.Location = New System.Drawing.Point(464, 7)
        Me.txtTotalPlanets.Name = "txtTotalPlanets"
        Me.txtTotalPlanets.ReadOnly = True
        Me.txtTotalPlanets.Size = New System.Drawing.Size(70, 25)
        Me.txtTotalPlanets.TabIndex = 176
        '
        'txtPlanetID
        '
        Me.txtPlanetID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlanetID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetID.ForeColor = System.Drawing.Color.Black
        Me.txtPlanetID.Location = New System.Drawing.Point(201, 7)
        Me.txtPlanetID.Name = "txtPlanetID"
        Me.txtPlanetID.Size = New System.Drawing.Size(72, 25)
        Me.txtPlanetID.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Planet ID:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.cbNewPlanetName)
        Me.Panel2.Controls.Add(Me.lblUpdateOptions)
        Me.Panel2.Controls.Add(Me.cbOriginalPlanetName)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSAVE)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1531, 32)
        Me.Panel2.TabIndex = 41
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(915, 1)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(84, 27)
        Me.btnRefresh.TabIndex = 88
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(785, 1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 27)
        Me.btnClear.TabIndex = 87
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackColor = System.Drawing.Color.Transparent
        Me.btnSAVE.BackgroundImage = CType(resources.GetObject("btnSAVE.BackgroundImage"), System.Drawing.Image)
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.Location = New System.Drawing.Point(660, 1)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(79, 27)
        Me.btnSAVE.TabIndex = 86
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1392, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 28)
        Me.btnClose.TabIndex = 83
        Me.btnClose.UseVisualStyleBackColor = False
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
        'cbOriginalPlanetName
        '
        Me.cbOriginalPlanetName.AutoSize = True
        Me.cbOriginalPlanetName.Checked = True
        Me.cbOriginalPlanetName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOriginalPlanetName.Location = New System.Drawing.Point(379, 8)
        Me.cbOriginalPlanetName.Name = "cbOriginalPlanetName"
        Me.cbOriginalPlanetName.Size = New System.Drawing.Size(125, 17)
        Me.cbOriginalPlanetName.TabIndex = 89
        Me.cbOriginalPlanetName.Text = "Original Planet Name"
        Me.cbOriginalPlanetName.UseVisualStyleBackColor = True
        '
        'lblUpdateOptions
        '
        Me.lblUpdateOptions.AutoSize = True
        Me.lblUpdateOptions.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblUpdateOptions.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateOptions.ForeColor = System.Drawing.Color.Black
        Me.lblUpdateOptions.Location = New System.Drawing.Point(213, 6)
        Me.lblUpdateOptions.Name = "lblUpdateOptions"
        Me.lblUpdateOptions.Size = New System.Drawing.Size(135, 17)
        Me.lblUpdateOptions.TabIndex = 178
        Me.lblUpdateOptions.Text = "Update Depends On:"
        '
        'cbNewPlanetName
        '
        Me.cbNewPlanetName.AutoSize = True
        Me.cbNewPlanetName.Location = New System.Drawing.Point(517, 8)
        Me.cbNewPlanetName.Name = "cbNewPlanetName"
        Me.cbNewPlanetName.Size = New System.Drawing.Size(112, 17)
        Me.cbNewPlanetName.TabIndex = 179
        Me.cbNewPlanetName.Text = "New Planet Name"
        Me.cbNewPlanetName.UseVisualStyleBackColor = True
        '
        'frmPlanetEntry_v2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.ClientSize = New System.Drawing.Size(1525, 946)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlAccount)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Controls.Add(Me.txtTITLE)
        Me.Name = "frmPlanetEntry_v2"
        Me.Text = "Planet Entry v2.0"
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.dgvPlanets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPlanetInfo.ResumeLayout(False)
        Me.pnlPlanetInfo.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgvResources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResourceContextMenu.ResumeLayout(False)
        CType(Me.dgvWaypoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WaypointContextMenu.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dgvStructures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StructureContextMenu.ResumeLayout(False)
        CType(Me.dgvBases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseContextMenu.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents btnSaveResourceColumns As Button
    Friend WithEvents txtTotalResources As TextBox
    Friend WithEvents lblRESOURCES As Label
    Friend WithEvents dgvResources As DataGridView
    Friend WithEvents comResources As ComboBox
    Friend WithEvents btnAddResource As Button
    Friend WithEvents btnRemoveResource As Button
    Friend WithEvents btnSaveWaypointColumns As Button
    Friend WithEvents txtTotalWaypoints As TextBox
    Friend WithEvents comWaypoints As ComboBox
    Friend WithEvents btnAddWaypoint As Button
    Friend WithEvents btnRemoveWaypoint As Button
    Friend WithEvents lblWEYPOINTS As Label
    Friend WithEvents dgvWaypoints As DataGridView
    Friend WithEvents btnSaveStructureColumns As Button
    Friend WithEvents txtTotalStructures As TextBox
    Friend WithEvents comStructures As ComboBox
    Friend WithEvents btnAddStructure As Button
    Friend WithEvents btnRemoveStructure As Button
    Friend WithEvents lblSTRUCTURES As Label
    Friend WithEvents dgvStructures As DataGridView
    Friend WithEvents btnSaveBaseColumns As Button
    Friend WithEvents comBases As ComboBox
    Friend WithEvents btnAddBase As Button
    Friend WithEvents btnRemoveBase As Button
    Friend WithEvents dgvBases As DataGridView
    Friend WithEvents lblBASES As Label
    Friend WithEvents txtTotalBases As TextBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalAccounts As TextBox
    Friend WithEvents txtTotalSystems As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalPlanets As TextBox
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents dgvPlanets As DataGridView
    Friend WithEvents pnlPlanetInfo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOriginalSystemName As TextBox
    Friend WithEvents lblSystemID As Label
    Friend WithEvents txtSystemID As TextBox
    Friend WithEvents txtOriginalPlanetName As TextBox
    Friend WithEvents comSystems As ComboBox
    Friend WithEvents txtCurrentSystem As TextBox
    Friend WithEvents lblCurrentSystem As Label
    Friend WithEvents txtGalacticRegion As TextBox
    Friend WithEvents lblGalacticRegion As Label
    Friend WithEvents lblOriginalPlanetName As Label
    Friend WithEvents txtRenamedPlanet As TextBox
    Friend WithEvents lblCurrentPlanetName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtGlyphUnderMouse As TextBox
    Friend WithEvents btnCreatePlanetCode As Button
    Friend WithEvents txtGalacticAddress As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiscoveryDate As MaskedTextBox
    Friend WithEvents lblDiscoveredBy As Label
    Friend WithEvents txtDiscoveredBy As TextBox
    Friend WithEvents lblDateOfDiscovery As Label
    Friend WithEvents imgCalendar_SelectDiscoveryDate As PictureBox
    Friend WithEvents txtTotalFlora As TextBox
    Friend WithEvents txtTotalFauna As TextBox
    Friend WithEvents Frame_PlanetGlyphSet As ScrollableControl
    Friend WithEvents Frame_PlanetGlyphPallet As ScrollableControl
    Friend WithEvents txtPlanetGlyphCode As TextBox
    Friend WithEvents txtSelectedGlyphIndex As TextBox
    Friend WithEvents lblSelectGlyph As Label
    Friend WithEvents txtSentinalInfo As TextBox
    Friend WithEvents lblSentinalInfo As Label
    Friend WithEvents txtResourceNotes As TextBox
    Friend WithEvents lblResourceNotes As Label
    Friend WithEvents txtWeather As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtExtremeWeather As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblPlanetaryNotes As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents glyphList As ImageList
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDefaultSystem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMinerals As Button
    Friend WithEvents txtTotalMinerals As TextBox
    Friend WithEvents btnFlora As Button
    Friend WithEvents btnFauna As Button
    Friend WithEvents cbNewPlanetName As CheckBox
    Friend WithEvents lblUpdateOptions As Label
    Friend WithEvents cbOriginalPlanetName As CheckBox
End Class
