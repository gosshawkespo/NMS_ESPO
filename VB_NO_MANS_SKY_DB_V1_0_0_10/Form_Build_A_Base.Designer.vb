<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuildBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildBase))
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblDiscoveryDate = New System.Windows.Forms.Label()
        Me.txtFromCore = New System.Windows.Forms.TextBox()
        Me.lblDiscoveredBy = New System.Windows.Forms.Label()
        Me.txtSystemName = New System.Windows.Forms.TextBox()
        Me.lblRenamed = New System.Windows.Forms.Label()
        Me.comAccounts = New System.Windows.Forms.ComboBox()
        Me.txtBaseName = New System.Windows.Forms.TextBox()
        Me.lblSystemName = New System.Windows.Forms.Label()
        Me.txtGalacticRegion = New System.Windows.Forms.TextBox()
        Me.lblGalacticRegion = New System.Windows.Forms.Label()
        Me.lblNoOfPlanets = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.rXBOX = New System.Windows.Forms.RadioButton()
        Me.rbPS4 = New System.Windows.Forms.RadioButton()
        Me.rbPC = New System.Windows.Forms.RadioButton()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlBaseDetails = New System.Windows.Forms.Panel()
        Me.dgvBaseDetails = New System.Windows.Forms.DataGridView()
        Me.pnlBuildBase = New System.Windows.Forms.Panel()
        Me.lblSelectMaterial = New System.Windows.Forms.Label()
        Me.comMaterial = New System.Windows.Forms.ComboBox()
        Me.lblSelectBuildItem = New System.Windows.Forms.Label()
        Me.lstBuildItems = New System.Windows.Forms.ListBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblResourceNeeded = New System.Windows.Forms.Label()
        Me.lblSelectTool = New System.Windows.Forms.Label()
        Me.comTools = New System.Windows.Forms.ComboBox()
        Me.lstResourcesNeeded = New System.Windows.Forms.ListBox()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.txtTotalValue = New System.Windows.Forms.TextBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlBaseDetails.SuspendLayout()
        CType(Me.dgvBaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuildBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTITLE2
        '
        Me.txtTITLE2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE2.BackColor = System.Drawing.Color.Black
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE2.Location = New System.Drawing.Point(0, 47)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(894, 41)
        Me.txtTITLE2.TabIndex = 7
        Me.txtTITLE2.Text = "BUILD-A-BASE"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTITLE
        '
        Me.txtTITLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE.BackColor = System.Drawing.Color.Brown
        Me.txtTITLE.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE.Location = New System.Drawing.Point(0, 3)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(894, 41)
        Me.txtTITLE.TabIndex = 8
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlMain.BackgroundImage = CType(resources.GetObject("pnlMain.BackgroundImage"), System.Drawing.Image)
        Me.pnlMain.Controls.Add(Me.pnlBuildBase)
        Me.pnlMain.Controls.Add(Me.TextBox1)
        Me.pnlMain.Controls.Add(Me.lblDiscoveryDate)
        Me.pnlMain.Controls.Add(Me.txtFromCore)
        Me.pnlMain.Controls.Add(Me.lblDiscoveredBy)
        Me.pnlMain.Controls.Add(Me.txtSystemName)
        Me.pnlMain.Controls.Add(Me.lblRenamed)
        Me.pnlMain.Controls.Add(Me.comAccounts)
        Me.pnlMain.Controls.Add(Me.txtBaseName)
        Me.pnlMain.Controls.Add(Me.lblSystemName)
        Me.pnlMain.Controls.Add(Me.txtGalacticRegion)
        Me.pnlMain.Controls.Add(Me.lblGalacticRegion)
        Me.pnlMain.Controls.Add(Me.lblNoOfPlanets)
        Me.pnlMain.Controls.Add(Me.txtVersion)
        Me.pnlMain.Controls.Add(Me.lblVersion)
        Me.pnlMain.Controls.Add(Me.rXBOX)
        Me.pnlMain.Controls.Add(Me.rbPS4)
        Me.pnlMain.Controls.Add(Me.rbPC)
        Me.pnlMain.Controls.Add(Me.txtPlatform)
        Me.pnlMain.Controls.Add(Me.lblPlatform)
        Me.pnlMain.Controls.Add(Me.txtAccount)
        Me.pnlMain.Controls.Add(Me.lblAccount)
        Me.pnlMain.Location = New System.Drawing.Point(3, 94)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(891, 455)
        Me.pnlMain.TabIndex = 9
        '
        'lblDiscoveryDate
        '
        Me.lblDiscoveryDate.AutoSize = True
        Me.lblDiscoveryDate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveryDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveryDate.Location = New System.Drawing.Point(11, 152)
        Me.lblDiscoveryDate.Name = "lblDiscoveryDate"
        Me.lblDiscoveryDate.Size = New System.Drawing.Size(73, 17)
        Me.lblDiscoveryDate.TabIndex = 39
        Me.lblDiscoveryDate.Text = "On Planet:"
        '
        'txtFromCore
        '
        Me.txtFromCore.BackColor = System.Drawing.Color.SteelBlue
        Me.txtFromCore.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromCore.ForeColor = System.Drawing.Color.Yellow
        Me.txtFromCore.Location = New System.Drawing.Point(671, 118)
        Me.txtFromCore.Name = "txtFromCore"
        Me.txtFromCore.Size = New System.Drawing.Size(158, 25)
        Me.txtFromCore.TabIndex = 36
        Me.txtFromCore.Text = "UNKNOWN"
        '
        'lblDiscoveredBy
        '
        Me.lblDiscoveredBy.AutoSize = True
        Me.lblDiscoveredBy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblDiscoveredBy.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscoveredBy.Location = New System.Drawing.Point(558, 121)
        Me.lblDiscoveredBy.Name = "lblDiscoveredBy"
        Me.lblDiscoveredBy.Size = New System.Drawing.Size(78, 17)
        Me.lblDiscoveredBy.TabIndex = 37
        Me.lblDiscoveredBy.Text = "From Core:"
        '
        'txtSystemName
        '
        Me.txtSystemName.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtSystemName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemName.ForeColor = System.Drawing.Color.Yellow
        Me.txtSystemName.Location = New System.Drawing.Point(120, 118)
        Me.txtSystemName.Name = "txtSystemName"
        Me.txtSystemName.Size = New System.Drawing.Size(430, 25)
        Me.txtSystemName.TabIndex = 34
        Me.txtSystemName.Text = "SYSTEM NAME"
        '
        'lblRenamed
        '
        Me.lblRenamed.AutoSize = True
        Me.lblRenamed.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRenamed.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenamed.Location = New System.Drawing.Point(11, 121)
        Me.lblRenamed.Name = "lblRenamed"
        Me.lblRenamed.Size = New System.Drawing.Size(83, 17)
        Me.lblRenamed.TabIndex = 35
        Me.lblRenamed.Text = "IN SYSTEM:"
        '
        'comAccounts
        '
        Me.comAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.comAccounts.BackColor = System.Drawing.Color.SkyBlue
        Me.comAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comAccounts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAccounts.FormattingEnabled = True
        Me.comAccounts.Location = New System.Drawing.Point(266, 19)
        Me.comAccounts.Name = "comAccounts"
        Me.comAccounts.Size = New System.Drawing.Size(91, 23)
        Me.comAccounts.Sorted = True
        Me.comAccounts.TabIndex = 31
        '
        'txtBaseName
        '
        Me.txtBaseName.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtBaseName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseName.ForeColor = System.Drawing.Color.Yellow
        Me.txtBaseName.Location = New System.Drawing.Point(121, 87)
        Me.txtBaseName.Name = "txtBaseName"
        Me.txtBaseName.Size = New System.Drawing.Size(429, 25)
        Me.txtBaseName.TabIndex = 4
        Me.txtBaseName.Text = "BASE NAME"
        '
        'lblSystemName
        '
        Me.lblSystemName.AutoSize = True
        Me.lblSystemName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSystemName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemName.Location = New System.Drawing.Point(12, 90)
        Me.lblSystemName.Name = "lblSystemName"
        Me.lblSystemName.Size = New System.Drawing.Size(80, 17)
        Me.lblSystemName.TabIndex = 27
        Me.lblSystemName.Text = "Base Name:"
        '
        'txtGalacticRegion
        '
        Me.txtGalacticRegion.BackColor = System.Drawing.Color.SteelBlue
        Me.txtGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGalacticRegion.ForeColor = System.Drawing.Color.Yellow
        Me.txtGalacticRegion.Location = New System.Drawing.Point(671, 88)
        Me.txtGalacticRegion.Name = "txtGalacticRegion"
        Me.txtGalacticRegion.Size = New System.Drawing.Size(158, 25)
        Me.txtGalacticRegion.TabIndex = 6
        Me.txtGalacticRegion.Text = "REGION"
        '
        'lblGalacticRegion
        '
        Me.lblGalacticRegion.AutoSize = True
        Me.lblGalacticRegion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblGalacticRegion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalacticRegion.Location = New System.Drawing.Point(557, 91)
        Me.lblGalacticRegion.Name = "lblGalacticRegion"
        Me.lblGalacticRegion.Size = New System.Drawing.Size(104, 17)
        Me.lblGalacticRegion.TabIndex = 25
        Me.lblGalacticRegion.Text = "Galactic Region"
        '
        'lblNoOfPlanets
        '
        Me.lblNoOfPlanets.AutoSize = True
        Me.lblNoOfPlanets.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblNoOfPlanets.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfPlanets.Location = New System.Drawing.Point(12, 201)
        Me.lblNoOfPlanets.Name = "lblNoOfPlanets"
        Me.lblNoOfPlanets.Size = New System.Drawing.Size(0, 17)
        Me.lblNoOfPlanets.TabIndex = 13
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.Color.AliceBlue
        Me.txtVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.Location = New System.Drawing.Point(442, 17)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(158, 25)
        Me.txtVersion.TabIndex = 2
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(366, 21)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(59, 17)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version:"
        '
        'rXBOX
        '
        Me.rXBOX.AutoSize = True
        Me.rXBOX.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rXBOX.Location = New System.Drawing.Point(365, 52)
        Me.rXBOX.Name = "rXBOX"
        Me.rXBOX.Size = New System.Drawing.Size(54, 17)
        Me.rXBOX.TabIndex = 6
        Me.rXBOX.TabStop = True
        Me.rXBOX.Text = "XBOX"
        Me.rXBOX.UseVisualStyleBackColor = False
        '
        'rbPS4
        '
        Me.rbPS4.AutoSize = True
        Me.rbPS4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPS4.Location = New System.Drawing.Point(312, 52)
        Me.rbPS4.Name = "rbPS4"
        Me.rbPS4.Size = New System.Drawing.Size(45, 17)
        Me.rbPS4.TabIndex = 5
        Me.rbPS4.TabStop = True
        Me.rbPS4.Text = "PS4"
        Me.rbPS4.UseVisualStyleBackColor = False
        '
        'rbPC
        '
        Me.rbPC.AutoSize = True
        Me.rbPC.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPC.Location = New System.Drawing.Point(267, 51)
        Me.rbPC.Name = "rbPC"
        Me.rbPC.Size = New System.Drawing.Size(39, 17)
        Me.rbPC.TabIndex = 4
        Me.rbPC.TabStop = True
        Me.rbPC.Text = "PC"
        Me.rbPC.UseVisualStyleBackColor = False
        '
        'txtPlatform
        '
        Me.txtPlatform.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.Location = New System.Drawing.Point(99, 47)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(158, 25)
        Me.txtPlatform.TabIndex = 3
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPlatform.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(23, 51)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(68, 17)
        Me.lblPlatform.TabIndex = 2
        Me.lblPlatform.Text = "Platform:"
        '
        'txtAccount
        '
        Me.txtAccount.BackColor = System.Drawing.Color.AliceBlue
        Me.txtAccount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(99, 16)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(158, 25)
        Me.txtAccount.TabIndex = 1
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblAccount.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(23, 20)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(64, 17)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox1.Location = New System.Drawing.Point(121, 149)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(430, 25)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "PLANET NAME"
        '
        'pnlBaseDetails
        '
        Me.pnlBaseDetails.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlBaseDetails.BackgroundImage = CType(resources.GetObject("pnlBaseDetails.BackgroundImage"), System.Drawing.Image)
        Me.pnlBaseDetails.Controls.Add(Me.dgvBaseDetails)
        Me.pnlBaseDetails.Location = New System.Drawing.Point(0, 556)
        Me.pnlBaseDetails.Name = "pnlBaseDetails"
        Me.pnlBaseDetails.Size = New System.Drawing.Size(894, 174)
        Me.pnlBaseDetails.TabIndex = 10
        '
        'dgvBaseDetails
        '
        Me.dgvBaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaseDetails.Location = New System.Drawing.Point(12, 45)
        Me.dgvBaseDetails.Name = "dgvBaseDetails"
        Me.dgvBaseDetails.Size = New System.Drawing.Size(866, 126)
        Me.dgvBaseDetails.TabIndex = 0
        '
        'pnlBuildBase
        '
        Me.pnlBuildBase.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlBuildBase.Controls.Add(Me.btnSAVE)
        Me.pnlBuildBase.Controls.Add(Me.txtTotalValue)
        Me.pnlBuildBase.Controls.Add(Me.lblTotalValue)
        Me.pnlBuildBase.Controls.Add(Me.lstResourcesNeeded)
        Me.pnlBuildBase.Controls.Add(Me.comTools)
        Me.pnlBuildBase.Controls.Add(Me.lblSelectTool)
        Me.pnlBuildBase.Controls.Add(Me.lblResourceNeeded)
        Me.pnlBuildBase.Controls.Add(Me.txtQuantity)
        Me.pnlBuildBase.Controls.Add(Me.lblQuantity)
        Me.pnlBuildBase.Controls.Add(Me.lstBuildItems)
        Me.pnlBuildBase.Controls.Add(Me.lblSelectBuildItem)
        Me.pnlBuildBase.Controls.Add(Me.comMaterial)
        Me.pnlBuildBase.Controls.Add(Me.lblSelectMaterial)
        Me.pnlBuildBase.Location = New System.Drawing.Point(6, 201)
        Me.pnlBuildBase.Name = "pnlBuildBase"
        Me.pnlBuildBase.Size = New System.Drawing.Size(866, 246)
        Me.pnlBuildBase.TabIndex = 46
        '
        'lblSelectMaterial
        '
        Me.lblSelectMaterial.AutoSize = True
        Me.lblSelectMaterial.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectMaterial.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectMaterial.Location = New System.Drawing.Point(8, 15)
        Me.lblSelectMaterial.Name = "lblSelectMaterial"
        Me.lblSelectMaterial.Size = New System.Drawing.Size(100, 17)
        Me.lblSelectMaterial.TabIndex = 8
        Me.lblSelectMaterial.Text = "Select Material"
        '
        'comMaterial
        '
        Me.comMaterial.BackColor = System.Drawing.Color.AliceBlue
        Me.comMaterial.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comMaterial.FormattingEnabled = True
        Me.comMaterial.Location = New System.Drawing.Point(115, 11)
        Me.comMaterial.Name = "comMaterial"
        Me.comMaterial.Size = New System.Drawing.Size(133, 25)
        Me.comMaterial.TabIndex = 9
        '
        'lblSelectBuildItem
        '
        Me.lblSelectBuildItem.AutoSize = True
        Me.lblSelectBuildItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectBuildItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectBuildItem.Location = New System.Drawing.Point(271, 15)
        Me.lblSelectBuildItem.Name = "lblSelectBuildItem"
        Me.lblSelectBuildItem.Size = New System.Drawing.Size(117, 17)
        Me.lblSelectBuildItem.TabIndex = 10
        Me.lblSelectBuildItem.Text = "Select Build Item:"
        '
        'lstBuildItems
        '
        Me.lstBuildItems.BackColor = System.Drawing.Color.AliceBlue
        Me.lstBuildItems.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBuildItems.ForeColor = System.Drawing.Color.Black
        Me.lstBuildItems.FormattingEnabled = True
        Me.lstBuildItems.ItemHeight = 17
        Me.lstBuildItems.Location = New System.Drawing.Point(403, 15)
        Me.lstBuildItems.Name = "lstBuildItems"
        Me.lstBuildItems.Size = New System.Drawing.Size(249, 89)
        Me.lstBuildItems.TabIndex = 11
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblQuantity.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(666, 15)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(67, 17)
        Me.lblQuantity.TabIndex = 12
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.AliceBlue
        Me.txtQuantity.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(737, 11)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(89, 25)
        Me.txtQuantity.TabIndex = 47
        '
        'lblResourceNeeded
        '
        Me.lblResourceNeeded.AutoSize = True
        Me.lblResourceNeeded.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblResourceNeeded.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceNeeded.Location = New System.Drawing.Point(8, 115)
        Me.lblResourceNeeded.Name = "lblResourceNeeded"
        Me.lblResourceNeeded.Size = New System.Drawing.Size(126, 17)
        Me.lblResourceNeeded.TabIndex = 48
        Me.lblResourceNeeded.Text = "Resources Needed:"
        '
        'lblSelectTool
        '
        Me.lblSelectTool.AutoSize = True
        Me.lblSelectTool.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectTool.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectTool.Location = New System.Drawing.Point(8, 50)
        Me.lblSelectTool.Name = "lblSelectTool"
        Me.lblSelectTool.Size = New System.Drawing.Size(139, 17)
        Me.lblSelectTool.TabIndex = 52
        Me.lblSelectTool.Text = "Select Tool / Facility:"
        '
        'comTools
        '
        Me.comTools.BackColor = System.Drawing.Color.AliceBlue
        Me.comTools.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comTools.ForeColor = System.Drawing.Color.Black
        Me.comTools.FormattingEnabled = True
        Me.comTools.Location = New System.Drawing.Point(153, 47)
        Me.comTools.Name = "comTools"
        Me.comTools.Size = New System.Drawing.Size(235, 25)
        Me.comTools.TabIndex = 53
        '
        'lstResourcesNeeded
        '
        Me.lstResourcesNeeded.BackColor = System.Drawing.Color.AliceBlue
        Me.lstResourcesNeeded.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResourcesNeeded.ForeColor = System.Drawing.Color.Black
        Me.lstResourcesNeeded.FormattingEnabled = True
        Me.lstResourcesNeeded.ItemHeight = 17
        Me.lstResourcesNeeded.Location = New System.Drawing.Point(153, 115)
        Me.lstResourcesNeeded.MultiColumn = True
        Me.lstResourcesNeeded.Name = "lstResourcesNeeded"
        Me.lstResourcesNeeded.Size = New System.Drawing.Size(500, 89)
        Me.lstResourcesNeeded.Sorted = True
        Me.lstResourcesNeeded.TabIndex = 54
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotalValue.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValue.Location = New System.Drawing.Point(666, 115)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(81, 17)
        Me.lblTotalValue.TabIndex = 55
        Me.lblTotalValue.Text = "Total Value:"
        '
        'txtTotalValue
        '
        Me.txtTotalValue.BackColor = System.Drawing.Color.AliceBlue
        Me.txtTotalValue.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalValue.Location = New System.Drawing.Point(753, 112)
        Me.txtTotalValue.Name = "txtTotalValue"
        Me.txtTotalValue.ReadOnly = True
        Me.txtTotalValue.Size = New System.Drawing.Size(89, 25)
        Me.txtTotalValue.TabIndex = 56
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.Transparent
        Me.btnSAVE.BackgroundImage = CType(resources.GetObject("btnSAVE.BackgroundImage"), System.Drawing.Image)
        Me.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSAVE.ForeColor = System.Drawing.Color.Black
        Me.btnSAVE.Location = New System.Drawing.Point(403, 210)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 33)
        Me.btnSAVE.TabIndex = 57
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(797, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 33)
        Me.btnClose.TabIndex = 58
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmBuildBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 784)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlBaseDetails)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Controls.Add(Me.txtTITLE)
        Me.Name = "frmBuildBase"
        Me.Text = "Form6"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlBaseDetails.ResumeLayout(False)
        CType(Me.dgvBaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuildBase.ResumeLayout(False)
        Me.pnlBuildBase.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblDiscoveryDate As Label
    Friend WithEvents txtFromCore As TextBox
    Friend WithEvents lblDiscoveredBy As Label
    Friend WithEvents txtSystemName As TextBox
    Friend WithEvents lblRenamed As Label
    Friend WithEvents comAccounts As ComboBox
    Friend WithEvents txtBaseName As TextBox
    Friend WithEvents lblSystemName As Label
    Friend WithEvents txtGalacticRegion As TextBox
    Friend WithEvents lblGalacticRegion As Label
    Friend WithEvents lblNoOfPlanets As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents rXBOX As RadioButton
    Friend WithEvents rbPS4 As RadioButton
    Friend WithEvents rbPC As RadioButton
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents pnlBuildBase As Panel
    Friend WithEvents lstBuildItems As ListBox
    Friend WithEvents lblSelectBuildItem As Label
    Friend WithEvents comMaterial As ComboBox
    Friend WithEvents lblSelectMaterial As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlBaseDetails As Panel
    Friend WithEvents dgvBaseDetails As DataGridView
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblResourceNeeded As Label
    Friend WithEvents lstResourcesNeeded As ListBox
    Friend WithEvents comTools As ComboBox
    Friend WithEvents lblSelectTool As Label
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtTotalValue As TextBox
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents btnClose As Button
End Class
