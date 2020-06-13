<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemEntry))
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSetDefault = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAccountCreated = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalAccounts = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDefault = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalSystems = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvSystems = New System.Windows.Forms.DataGridView()
        Me.txtGalaxyName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMoonsInSystem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtNextSystem = New System.Windows.Forms.TextBox()
        Me.lblGlyphCode = New System.Windows.Forms.Label()
        Me.txtDiscoveryDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDiscoveryDate = New System.Windows.Forms.Label()
        Me.txtDiscoveredBy = New System.Windows.Forms.TextBox()
        Me.lblDiscoveredBy = New System.Windows.Forms.Label()
        Me.txtRenamedSystem = New System.Windows.Forms.TextBox()
        Me.lblRenamed = New System.Windows.Forms.Label()
        Me.txtDominatedBy = New System.Windows.Forms.TextBox()
        Me.lblDominatedBy = New System.Windows.Forms.Label()
        Me.txtSystemName = New System.Windows.Forms.TextBox()
        Me.lblSystemName = New System.Windows.Forms.Label()
        Me.txtGalacticRegion = New System.Windows.Forms.TextBox()
        Me.lblGalacticRegion = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtDistanceFromCore = New System.Windows.Forms.TextBox()
        Me.lblDistanceFromCore = New System.Windows.Forms.Label()
        Me.txtPlanetsInSystem = New System.Windows.Forms.TextBox()
        Me.lblNoOfPlanets = New System.Windows.Forms.Label()
        Me.txtSystemType = New System.Windows.Forms.TextBox()
        Me.lblSystemType = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.rXBOX = New System.Windows.Forms.RadioButton()
        Me.rbPS4 = New System.Windows.Forms.RadioButton()
        Me.rbPC = New System.Windows.Forms.RadioButton()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.btnGetDefaultAccount = New System.Windows.Forms.Button()
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.txtSystemID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnResetSystems = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAccountFilter = New System.Windows.Forms.CheckBox()
        Me.ssSystemStrip = New System.Windows.Forms.StatusStrip()
        Me.ssSystemStripLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlButtons.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvSystems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssSystemStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Controls.Add(Me.btnSetDefault)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Location = New System.Drawing.Point(1, 92)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1527, 49)
        Me.pnlButtons.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Green
        Me.btnClear.Location = New System.Drawing.Point(710, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 43)
        Me.btnClear.TabIndex = 10
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSetDefault
        '
        Me.btnSetDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnSetDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSetDefault.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetDefault.ForeColor = System.Drawing.Color.Green
        Me.btnSetDefault.Location = New System.Drawing.Point(9, 3)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(165, 43)
        Me.btnSetDefault.TabIndex = 9
        Me.btnSetDefault.Text = "Set Default"
        Me.btnSetDefault.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Green
        Me.btnSave.Location = New System.Drawing.Point(393, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 43)
        Me.btnSave.TabIndex = 7
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Green
        Me.btnClose.Location = New System.Drawing.Point(1407, 50)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 33)
        Me.btnClose.TabIndex = 8
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackgroundImage = CType(resources.GetObject("pnlMain.BackgroundImage"), System.Drawing.Image)
        Me.pnlMain.Controls.Add(Me.txtUserID)
        Me.pnlMain.Controls.Add(Me.Label9)
        Me.pnlMain.Controls.Add(Me.txtAccountCreated)
        Me.pnlMain.Controls.Add(Me.Label8)
        Me.pnlMain.Controls.Add(Me.txtTotalAccounts)
        Me.pnlMain.Controls.Add(Me.Label7)
        Me.pnlMain.Controls.Add(Me.txtDefault)
        Me.pnlMain.Controls.Add(Me.Label6)
        Me.pnlMain.Controls.Add(Me.txtTotalSystems)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.dgvSystems)
        Me.pnlMain.Controls.Add(Me.txtGalaxyName)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.txtMoonsInSystem)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.txtAccountID)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Controls.Add(Me.txtLocation)
        Me.pnlMain.Controls.Add(Me.lblLocation)
        Me.pnlMain.Controls.Add(Me.txtNextSystem)
        Me.pnlMain.Controls.Add(Me.lblGlyphCode)
        Me.pnlMain.Controls.Add(Me.txtDiscoveryDate)
        Me.pnlMain.Controls.Add(Me.lblDiscoveryDate)
        Me.pnlMain.Controls.Add(Me.txtDiscoveredBy)
        Me.pnlMain.Controls.Add(Me.lblDiscoveredBy)
        Me.pnlMain.Controls.Add(Me.txtRenamedSystem)
        Me.pnlMain.Controls.Add(Me.lblRenamed)
        Me.pnlMain.Controls.Add(Me.txtDominatedBy)
        Me.pnlMain.Controls.Add(Me.lblDominatedBy)
        Me.pnlMain.Controls.Add(Me.txtSystemName)
        Me.pnlMain.Controls.Add(Me.lblSystemName)
        Me.pnlMain.Controls.Add(Me.txtGalacticRegion)
        Me.pnlMain.Controls.Add(Me.lblGalacticRegion)
        Me.pnlMain.Controls.Add(Me.txtComments)
        Me.pnlMain.Controls.Add(Me.lblComment)
        Me.pnlMain.Controls.Add(Me.txtDistanceFromCore)
        Me.pnlMain.Controls.Add(Me.lblDistanceFromCore)
        Me.pnlMain.Controls.Add(Me.txtPlanetsInSystem)
        Me.pnlMain.Controls.Add(Me.lblNoOfPlanets)
        Me.pnlMain.Controls.Add(Me.txtSystemType)
        Me.pnlMain.Controls.Add(Me.lblSystemType)
        Me.pnlMain.Controls.Add(Me.txtVersion)
        Me.pnlMain.Controls.Add(Me.lblVersion)
        Me.pnlMain.Controls.Add(Me.rXBOX)
        Me.pnlMain.Controls.Add(Me.rbPS4)
        Me.pnlMain.Controls.Add(Me.rbPC)
        Me.pnlMain.Controls.Add(Me.txtPlatform)
        Me.pnlMain.Controls.Add(Me.lblPlatform)
        Me.pnlMain.Controls.Add(Me.txtAccountName)
        Me.pnlMain.Controls.Add(Me.lblAccount)
        Me.pnlMain.Location = New System.Drawing.Point(1, 142)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1527, 629)
        Me.pnlMain.TabIndex = 7
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtUserID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(935, 235)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(48, 25)
        Me.txtUserID.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(863, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "User ID:"
        '
        'txtAccountCreated
        '
        Me.txtAccountCreated.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountCreated.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccountCreated.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountCreated.Location = New System.Drawing.Point(935, 267)
        Me.txtAccountCreated.Name = "txtAccountCreated"
        Me.txtAccountCreated.Size = New System.Drawing.Size(157, 25)
        Me.txtAccountCreated.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(863, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Created:"
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccounts.Location = New System.Drawing.Point(803, 235)
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.Size = New System.Drawing.Size(48, 25)
        Me.txtTotalAccounts.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(688, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Total Accounts:"
        '
        'txtDefault
        '
        Me.txtDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDefault.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDefault.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefault.Location = New System.Drawing.Point(914, 461)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(157, 25)
        Me.txtDefault.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(842, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Default:"
        '
        'txtTotalSystems
        '
        Me.txtTotalSystems.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalSystems.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSystems.Location = New System.Drawing.Point(188, 3)
        Me.txtTotalSystems.Name = "txtTotalSystems"
        Me.txtTotalSystems.Size = New System.Drawing.Size(83, 25)
        Me.txtTotalSystems.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Total Systems Entered:"
        '
        'dgvSystems
        '
        Me.dgvSystems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSystems.Location = New System.Drawing.Point(32, 34)
        Me.dgvSystems.Name = "dgvSystems"
        Me.dgvSystems.Size = New System.Drawing.Size(1479, 195)
        Me.dgvSystems.TabIndex = 51
        '
        'txtGalaxyName
        '
        Me.txtGalaxyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGalaxyName.BackColor = System.Drawing.Color.SteelBlue
        Me.txtGalaxyName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalaxyName.ForeColor = System.Drawing.Color.Yellow
        Me.txtGalaxyName.Location = New System.Drawing.Point(120, 344)
        Me.txtGalaxyName.Name = "txtGalaxyName"
        Me.txtGalaxyName.Size = New System.Drawing.Size(709, 25)
        Me.txtGalaxyName.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Galaxy Name:"
        '
        'txtMoonsInSystem
        '
        Me.txtMoonsInSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMoonsInSystem.BackColor = System.Drawing.Color.AliceBlue
        Me.txtMoonsInSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoonsInSystem.Location = New System.Drawing.Point(239, 416)
        Me.txtMoonsInSystem.Name = "txtMoonsInSystem"
        Me.txtMoonsInSystem.Size = New System.Drawing.Size(45, 25)
        Me.txtMoonsInSystem.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Moons:"
        '
        'txtAccountID
        '
        Me.txtAccountID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.Location = New System.Drawing.Point(562, 267)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(57, 25)
        Me.txtAccountID.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Account ID:"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.BackColor = System.Drawing.Color.AliceBlue
        Me.txtLocation.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(671, 375)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(157, 25)
        Me.txtLocation.TabIndex = 43
        '
        'lblLocation
        '
        Me.lblLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblLocation.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(599, 379)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(67, 17)
        Me.lblLocation.TabIndex = 44
        Me.lblLocation.Text = "Location:"
        '
        'txtNextSystem
        '
        Me.txtNextSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNextSystem.BackColor = System.Drawing.Color.AliceBlue
        Me.txtNextSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextSystem.Location = New System.Drawing.Point(527, 461)
        Me.txtNextSystem.Name = "txtNextSystem"
        Me.txtNextSystem.Size = New System.Drawing.Size(301, 25)
        Me.txtNextSystem.TabIndex = 41
        '
        'lblGlyphCode
        '
        Me.lblGlyphCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGlyphCode.AutoSize = True
        Me.lblGlyphCode.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGlyphCode.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGlyphCode.Location = New System.Drawing.Point(336, 465)
        Me.lblGlyphCode.Name = "lblGlyphCode"
        Me.lblGlyphCode.Size = New System.Drawing.Size(189, 17)
        Me.lblGlyphCode.TabIndex = 42
        Me.lblGlyphCode.Text = "Next System (closer to core):"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDiscoveryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(121, 375)
        Me.txtDiscoveryDate.Mask = "00/00/0000 90:00"
        Me.txtDiscoveryDate.Name = "txtDiscoveryDate"
        Me.txtDiscoveryDate.Size = New System.Drawing.Size(123, 25)
        Me.txtDiscoveryDate.TabIndex = 40
        Me.txtDiscoveryDate.ValidatingType = GetType(Date)
        '
        'lblDiscoveryDate
        '
        Me.lblDiscoveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiscoveryDate.AutoSize = True
        Me.lblDiscoveryDate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveryDate.Location = New System.Drawing.Point(36, 379)
        Me.lblDiscoveryDate.Name = "lblDiscoveryDate"
        Me.lblDiscoveryDate.Size = New System.Drawing.Size(83, 17)
        Me.lblDiscoveryDate.TabIndex = 39
        Me.lblDiscoveryDate.Text = "Discovered:"
        '
        'txtDiscoveredBy
        '
        Me.txtDiscoveredBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDiscoveredBy.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveredBy.ForeColor = System.Drawing.Color.Yellow
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(290, 375)
        Me.txtDiscoveredBy.Name = "txtDiscoveredBy"
        Me.txtDiscoveredBy.Size = New System.Drawing.Size(303, 25)
        Me.txtDiscoveredBy.TabIndex = 36
        Me.txtDiscoveredBy.Text = "UNKNOWN"
        '
        'lblDiscoveredBy
        '
        Me.lblDiscoveredBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDiscoveredBy.AutoSize = True
        Me.lblDiscoveredBy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveredBy.Location = New System.Drawing.Point(259, 379)
        Me.lblDiscoveredBy.Name = "lblDiscoveredBy"
        Me.lblDiscoveredBy.Size = New System.Drawing.Size(29, 17)
        Me.lblDiscoveredBy.TabIndex = 37
        Me.lblDiscoveredBy.Text = "By:"
        '
        'txtRenamedSystem
        '
        Me.txtRenamedSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRenamedSystem.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtRenamedSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenamedSystem.ForeColor = System.Drawing.Color.Yellow
        Me.txtRenamedSystem.Location = New System.Drawing.Point(914, 3)
        Me.txtRenamedSystem.Name = "txtRenamedSystem"
        Me.txtRenamedSystem.Size = New System.Drawing.Size(430, 25)
        Me.txtRenamedSystem.TabIndex = 34
        Me.txtRenamedSystem.Text = "NEW SYSTEM NAME"
        '
        'lblRenamed
        '
        Me.lblRenamed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRenamed.AutoSize = True
        Me.lblRenamed.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRenamed.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenamed.Location = New System.Drawing.Point(842, 6)
        Me.lblRenamed.Name = "lblRenamed"
        Me.lblRenamed.Size = New System.Drawing.Size(70, 17)
        Me.lblRenamed.TabIndex = 35
        Me.lblRenamed.Text = "Renamed:"
        '
        'txtDominatedBy
        '
        Me.txtDominatedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDominatedBy.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDominatedBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDominatedBy.Location = New System.Drawing.Point(949, 416)
        Me.txtDominatedBy.Name = "txtDominatedBy"
        Me.txtDominatedBy.Size = New System.Drawing.Size(122, 25)
        Me.txtDominatedBy.TabIndex = 32
        '
        'lblDominatedBy
        '
        Me.lblDominatedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDominatedBy.AutoSize = True
        Me.lblDominatedBy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDominatedBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDominatedBy.Location = New System.Drawing.Point(842, 419)
        Me.lblDominatedBy.Name = "lblDominatedBy"
        Me.lblDominatedBy.Size = New System.Drawing.Size(101, 17)
        Me.lblDominatedBy.TabIndex = 33
        Me.lblDominatedBy.Text = "Dominated By:"
        '
        'txtSystemName
        '
        Me.txtSystemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSystemName.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtSystemName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemName.ForeColor = System.Drawing.Color.Yellow
        Me.txtSystemName.Location = New System.Drawing.Point(431, 3)
        Me.txtSystemName.Name = "txtSystemName"
        Me.txtSystemName.Size = New System.Drawing.Size(401, 25)
        Me.txtSystemName.TabIndex = 4
        Me.txtSystemName.Text = "SYSTEM NAME"
        '
        'lblSystemName
        '
        Me.lblSystemName.AutoSize = True
        Me.lblSystemName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSystemName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemName.Location = New System.Drawing.Point(280, 6)
        Me.lblSystemName.Name = "lblSystemName"
        Me.lblSystemName.Size = New System.Drawing.Size(149, 17)
        Me.lblSystemName.TabIndex = 27
        Me.lblSystemName.Text = "Original System Name:"
        '
        'txtGalacticRegion
        '
        Me.txtGalacticRegion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGalacticRegion.BackColor = System.Drawing.Color.SteelBlue
        Me.txtGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticRegion.ForeColor = System.Drawing.Color.Yellow
        Me.txtGalacticRegion.Location = New System.Drawing.Point(120, 313)
        Me.txtGalacticRegion.Name = "txtGalacticRegion"
        Me.txtGalacticRegion.Size = New System.Drawing.Size(158, 25)
        Me.txtGalacticRegion.TabIndex = 6
        Me.txtGalacticRegion.Text = "REGION"
        '
        'lblGalacticRegion
        '
        Me.lblGalacticRegion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGalacticRegion.AutoSize = True
        Me.lblGalacticRegion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalacticRegion.Location = New System.Drawing.Point(6, 316)
        Me.lblGalacticRegion.Name = "lblGalacticRegion"
        Me.lblGalacticRegion.Size = New System.Drawing.Size(108, 17)
        Me.lblGalacticRegion.TabIndex = 25
        Me.lblGalacticRegion.Text = "Galactic Region:"
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtComments.BackColor = System.Drawing.Color.AliceBlue
        Me.txtComments.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(121, 507)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(1236, 101)
        Me.txtComments.TabIndex = 13
        '
        'lblComment
        '
        Me.lblComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblComment.AutoSize = True
        Me.lblComment.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblComment.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(47, 510)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(72, 17)
        Me.lblComment.TabIndex = 21
        Me.lblComment.Text = "Comment:"
        '
        'txtDistanceFromCore
        '
        Me.txtDistanceFromCore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDistanceFromCore.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDistanceFromCore.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistanceFromCore.Location = New System.Drawing.Point(180, 461)
        Me.txtDistanceFromCore.Name = "txtDistanceFromCore"
        Me.txtDistanceFromCore.Size = New System.Drawing.Size(146, 25)
        Me.txtDistanceFromCore.TabIndex = 9
        '
        'lblDistanceFromCore
        '
        Me.lblDistanceFromCore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDistanceFromCore.AutoSize = True
        Me.lblDistanceFromCore.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDistanceFromCore.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistanceFromCore.Location = New System.Drawing.Point(12, 465)
        Me.lblDistanceFromCore.Name = "lblDistanceFromCore"
        Me.lblDistanceFromCore.Size = New System.Drawing.Size(162, 17)
        Me.lblDistanceFromCore.TabIndex = 15
        Me.lblDistanceFromCore.Text = "Distance from Core (LY):"
        '
        'txtPlanetsInSystem
        '
        Me.txtPlanetsInSystem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlanetsInSystem.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlanetsInSystem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetsInSystem.Location = New System.Drawing.Point(121, 416)
        Me.txtPlanetsInSystem.Name = "txtPlanetsInSystem"
        Me.txtPlanetsInSystem.Size = New System.Drawing.Size(45, 25)
        Me.txtPlanetsInSystem.TabIndex = 7
        '
        'lblNoOfPlanets
        '
        Me.lblNoOfPlanets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNoOfPlanets.AutoSize = True
        Me.lblNoOfPlanets.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblNoOfPlanets.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfPlanets.Location = New System.Drawing.Point(21, 419)
        Me.lblNoOfPlanets.Name = "lblNoOfPlanets"
        Me.lblNoOfPlanets.Size = New System.Drawing.Size(98, 17)
        Me.lblNoOfPlanets.TabIndex = 13
        Me.lblNoOfPlanets.Text = "No. of Planets:"
        '
        'txtSystemType
        '
        Me.txtSystemType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSystemType.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSystemType.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemType.Location = New System.Drawing.Point(393, 416)
        Me.txtSystemType.Name = "txtSystemType"
        Me.txtSystemType.Size = New System.Drawing.Size(435, 25)
        Me.txtSystemType.TabIndex = 8
        '
        'lblSystemType
        '
        Me.lblSystemType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSystemType.AutoSize = True
        Me.lblSystemType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSystemType.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemType.Location = New System.Drawing.Point(299, 419)
        Me.lblSystemType.Name = "lblSystemType"
        Me.lblSystemType.Size = New System.Drawing.Size(92, 17)
        Me.lblSystemType.TabIndex = 9
        Me.lblSystemType.Text = "System Type:"
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.BackColor = System.Drawing.Color.AliceBlue
        Me.txtVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.Location = New System.Drawing.Point(693, 267)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(158, 25)
        Me.txtVersion.TabIndex = 2
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(625, 272)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(59, 17)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version:"
        '
        'rXBOX
        '
        Me.rXBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rXBOX.AutoSize = True
        Me.rXBOX.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rXBOX.Location = New System.Drawing.Point(386, 271)
        Me.rXBOX.Name = "rXBOX"
        Me.rXBOX.Size = New System.Drawing.Size(54, 17)
        Me.rXBOX.TabIndex = 6
        Me.rXBOX.TabStop = True
        Me.rXBOX.Text = "XBOX"
        Me.rXBOX.UseVisualStyleBackColor = False
        '
        'rbPS4
        '
        Me.rbPS4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbPS4.AutoSize = True
        Me.rbPS4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPS4.Location = New System.Drawing.Point(333, 271)
        Me.rbPS4.Name = "rbPS4"
        Me.rbPS4.Size = New System.Drawing.Size(45, 17)
        Me.rbPS4.TabIndex = 5
        Me.rbPS4.TabStop = True
        Me.rbPS4.Text = "PS4"
        Me.rbPS4.UseVisualStyleBackColor = False
        '
        'rbPC
        '
        Me.rbPC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbPC.AutoSize = True
        Me.rbPC.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPC.Location = New System.Drawing.Point(288, 271)
        Me.rbPC.Name = "rbPC"
        Me.rbPC.Size = New System.Drawing.Size(39, 17)
        Me.rbPC.TabIndex = 4
        Me.rbPC.TabStop = True
        Me.rbPC.Text = "PC"
        Me.rbPC.UseVisualStyleBackColor = False
        '
        'txtPlatform
        '
        Me.txtPlatform.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlatform.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.Location = New System.Drawing.Point(120, 267)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(158, 25)
        Me.txtPlatform.TabIndex = 3
        '
        'lblPlatform
        '
        Me.lblPlatform.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(50, 271)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(68, 17)
        Me.lblPlatform.TabIndex = 2
        Me.lblPlatform.Text = "Platform:"
        '
        'txtAccountName
        '
        Me.txtAccountName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountName.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccountName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(120, 235)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(320, 25)
        Me.txtAccountName.TabIndex = 1
        '
        'lblAccount
        '
        Me.lblAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAccount.AutoSize = True
        Me.lblAccount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAccount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(54, 240)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(64, 17)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account:"
        '
        'comAccounts
        '
        Me.comAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comAccounts.BackColor = System.Drawing.Color.AliceBlue
        Me.comAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comAccounts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccounts.ForeColor = System.Drawing.SystemColors.WindowText
        Me.comAccounts.FormattingEnabled = True
        Me.comAccounts.Location = New System.Drawing.Point(215, 53)
        Me.comAccounts.Name = "comAccounts"
        Me.comAccounts.Size = New System.Drawing.Size(299, 23)
        Me.comAccounts.Sorted = True
        Me.comAccounts.TabIndex = 31
        '
        'btnGetDefaultAccount
        '
        Me.btnGetDefaultAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetDefaultAccount.BackColor = System.Drawing.Color.Gray
        Me.btnGetDefaultAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGetDefaultAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetDefaultAccount.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDefaultAccount.ForeColor = System.Drawing.Color.Black
        Me.btnGetDefaultAccount.Location = New System.Drawing.Point(1321, 53)
        Me.btnGetDefaultAccount.Name = "btnGetDefaultAccount"
        Me.btnGetDefaultAccount.Size = New System.Drawing.Size(66, 26)
        Me.btnGetDefaultAccount.TabIndex = 52
        Me.btnGetDefaultAccount.Text = "Get Default"
        Me.btnGetDefaultAccount.UseVisualStyleBackColor = False
        '
        'txtTITLE2
        '
        Me.txtTITLE2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE2.BackColor = System.Drawing.Color.Black
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE2.Location = New System.Drawing.Point(1, 45)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(1535, 41)
        Me.txtTITLE2.TabIndex = 5
        Me.txtTITLE2.Text = "SYSTEM ENTRY"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTITLE
        '
        Me.txtTITLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE.BackColor = System.Drawing.Color.Brown
        Me.txtTITLE.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE.Location = New System.Drawing.Point(1, 1)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(1535, 41)
        Me.txtTITLE.TabIndex = 6
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSystemID
        '
        Me.txtSystemID.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSystemID.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemID.Location = New System.Drawing.Point(65, 53)
        Me.txtSystemID.Name = "txtSystemID"
        Me.txtSystemID.Size = New System.Drawing.Size(57, 25)
        Me.txtSystemID.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ID:"
        '
        'btnResetSystems
        '
        Me.btnResetSystems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetSystems.BackColor = System.Drawing.Color.Gray
        Me.btnResetSystems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResetSystems.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResetSystems.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSystems.ForeColor = System.Drawing.Color.Black
        Me.btnResetSystems.Location = New System.Drawing.Point(1246, 53)
        Me.btnResetSystems.Name = "btnResetSystems"
        Me.btnResetSystems.Size = New System.Drawing.Size(66, 26)
        Me.btnResetSystems.TabIndex = 53
        Me.btnResetSystems.Text = "Get All"
        Me.btnResetSystems.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Account:"
        '
        'cbAccountFilter
        '
        Me.cbAccountFilter.AutoSize = True
        Me.cbAccountFilter.BackColor = System.Drawing.Color.AliceBlue
        Me.cbAccountFilter.Checked = True
        Me.cbAccountFilter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAccountFilter.Location = New System.Drawing.Point(526, 57)
        Me.cbAccountFilter.Name = "cbAccountFilter"
        Me.cbAccountFilter.Size = New System.Drawing.Size(48, 17)
        Me.cbAccountFilter.TabIndex = 63
        Me.cbAccountFilter.Text = "Filter"
        Me.cbAccountFilter.UseVisualStyleBackColor = False
        '
        'ssSystemStrip
        '
        Me.ssSystemStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssSystemStripLabel1})
        Me.ssSystemStrip.Location = New System.Drawing.Point(0, 756)
        Me.ssSystemStrip.Name = "ssSystemStrip"
        Me.ssSystemStrip.Size = New System.Drawing.Size(1536, 22)
        Me.ssSystemStrip.TabIndex = 64
        '
        'ssSystemStripLabel1
        '
        Me.ssSystemStripLabel1.Name = "ssSystemStripLabel1"
        Me.ssSystemStripLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'frmSystemEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1536, 778)
        Me.Controls.Add(Me.ssSystemStrip)
        Me.Controls.Add(Me.cbAccountFilter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.comAccounts)
        Me.Controls.Add(Me.btnResetSystems)
        Me.Controls.Add(Me.btnGetDefaultAccount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtSystemID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.txtTITLE)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Name = "frmSystemEntry"
        Me.Text = "SYSTEM ENTRY"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.dgvSystems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssSystemStrip.ResumeLayout(False)
        Me.ssSystemStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents txtSystemName As TextBox
    Friend WithEvents lblSystemName As Label
    Friend WithEvents txtGalacticRegion As TextBox
    Friend WithEvents lblGalacticRegion As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtDistanceFromCore As TextBox
    Friend WithEvents lblDistanceFromCore As Label
    Friend WithEvents txtPlanetsInSystem As TextBox
    Friend WithEvents lblNoOfPlanets As Label
    Friend WithEvents txtSystemType As TextBox
    Friend WithEvents lblSystemType As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents rXBOX As RadioButton
    Friend WithEvents rbPS4 As RadioButton
    Friend WithEvents rbPC As RadioButton
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents txtDominatedBy As TextBox
    Friend WithEvents lblDominatedBy As Label
    Friend WithEvents txtRenamedSystem As TextBox
    Friend WithEvents lblRenamed As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtNextSystem As TextBox
    Friend WithEvents lblGlyphCode As Label
    Friend WithEvents txtDiscoveryDate As MaskedTextBox
    Friend WithEvents lblDiscoveryDate As Label
    Friend WithEvents txtDiscoveredBy As TextBox
    Friend WithEvents lblDiscoveredBy As Label
    Friend WithEvents btnSetDefault As Button
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSystemID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMoonsInSystem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGalaxyName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvSystems As DataGridView
    Friend WithEvents btnGetDefaultAccount As Button
    Friend WithEvents btnResetSystems As Button
    Friend WithEvents txtTotalSystems As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDefault As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalAccounts As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtAccountCreated As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAccountFilter As CheckBox
    Friend WithEvents ssSystemStrip As StatusStrip
    Friend WithEvents ssSystemStripLabel1 As ToolStripStatusLabel
End Class
