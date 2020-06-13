<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EnterFauna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EnterFauna))
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnImportPicture = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.txtFaunaNewName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImageFilename = New System.Windows.Forms.TextBox()
        Me.txtImageEXT = New System.Windows.Forms.TextBox()
        Me.pbFaunaPic = New System.Windows.Forms.PictureBox()
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
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtDiscoveredBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFaunaID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtFaunaOriginalName = New System.Windows.Forms.TextBox()
        Me.lblFaunaOriginalName = New System.Windows.Forms.Label()
        Me.pnlButtons.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        CType(Me.pbFaunaPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnImportPicture)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnSAVE)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 502)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1078, 44)
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
        Me.btnImportPicture.Location = New System.Drawing.Point(727, 3)
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
        Me.btnClose.Location = New System.Drawing.Point(494, 3)
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
        Me.btnSAVE.Location = New System.Drawing.Point(333, 4)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(75, 32)
        Me.btnSAVE.TabIndex = 10
        Me.btnSAVE.UseVisualStyleBackColor = True
        '
        'pnlEntry
        '
        Me.pnlEntry.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlEntry.BackgroundImage = CType(resources.GetObject("pnlEntry.BackgroundImage"), System.Drawing.Image)
        Me.pnlEntry.Controls.Add(Me.txtFaunaNewName)
        Me.pnlEntry.Controls.Add(Me.Label2)
        Me.pnlEntry.Controls.Add(Me.txtImageFilename)
        Me.pnlEntry.Controls.Add(Me.txtImageEXT)
        Me.pnlEntry.Controls.Add(Me.pbFaunaPic)
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
        Me.pnlEntry.Controls.Add(Me.lblNotes)
        Me.pnlEntry.Controls.Add(Me.txtDiscoveredBy)
        Me.pnlEntry.Controls.Add(Me.Label4)
        Me.pnlEntry.Controls.Add(Me.txtFaunaID)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.txtPlanetID)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.txtAccountID)
        Me.pnlEntry.Controls.Add(Me.lblAccountID)
        Me.pnlEntry.Controls.Add(Me.txtFaunaOriginalName)
        Me.pnlEntry.Controls.Add(Me.lblFaunaOriginalName)
        Me.pnlEntry.ForeColor = System.Drawing.Color.Transparent
        Me.pnlEntry.Location = New System.Drawing.Point(3, 1)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(1075, 499)
        Me.pnlEntry.TabIndex = 25
        '
        'txtFaunaNewName
        '
        Me.txtFaunaNewName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFaunaNewName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtFaunaNewName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaunaNewName.ForeColor = System.Drawing.Color.Black
        Me.txtFaunaNewName.Location = New System.Drawing.Point(7, 133)
        Me.txtFaunaNewName.Name = "txtFaunaNewName"
        Me.txtFaunaNewName.Size = New System.Drawing.Size(1059, 32)
        Me.txtFaunaNewName.TabIndex = 153
        Me.txtFaunaNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Turquoise
        Me.Label2.Location = New System.Drawing.Point(8, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 19)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Enter Fauna NEW Name:"
        '
        'txtImageFilename
        '
        Me.txtImageFilename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageFilename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageFilename.ForeColor = System.Drawing.Color.Black
        Me.txtImageFilename.Location = New System.Drawing.Point(9, 359)
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
        Me.txtImageEXT.Location = New System.Drawing.Point(605, 357)
        Me.txtImageEXT.Name = "txtImageEXT"
        Me.txtImageEXT.ReadOnly = True
        Me.txtImageEXT.Size = New System.Drawing.Size(223, 23)
        Me.txtImageEXT.TabIndex = 8
        '
        'pbFaunaPic
        '
        Me.pbFaunaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFaunaPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFaunaPic.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbFaunaPic.Location = New System.Drawing.Point(605, 171)
        Me.pbFaunaPic.Name = "pbFaunaPic"
        Me.pbFaunaPic.Size = New System.Drawing.Size(223, 182)
        Me.pbFaunaPic.TabIndex = 147
        Me.pbFaunaPic.TabStop = False
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastUpdated.BackColor = System.Drawing.Color.MediumBlue
        Me.txtLastUpdated.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.Color.Aqua
        Me.txtLastUpdated.Location = New System.Drawing.Point(662, 12)
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
        Me.Label13.Location = New System.Drawing.Point(556, 12)
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
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(324, 284)
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
        Me.txtNumRows.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRows.ForeColor = System.Drawing.Color.Aqua
        Me.txtNumRows.Location = New System.Drawing.Point(874, 9)
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
        Me.Label11.Location = New System.Drawing.Point(820, 9)
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
        Me.txtDefault.Location = New System.Drawing.Point(464, 227)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(120, 23)
        Me.txtDefault.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Turquoise
        Me.Label10.Location = New System.Drawing.Point(467, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Default:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDiscoveryDate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(185, 292)
        Me.txtDiscoveryDate.Mask = "00/00/0000 90:00"
        Me.txtDiscoveryDate.Name = "txtDiscoveryDate"
        Me.txtDiscoveryDate.Size = New System.Drawing.Size(133, 20)
        Me.txtDiscoveryDate.TabIndex = 6
        Me.txtDiscoveryDate.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Turquoise
        Me.Label8.Location = New System.Drawing.Point(190, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Discovery Date:"
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.Black
        Me.txtNotes.Location = New System.Drawing.Point(6, 410)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(1060, 85)
        Me.txtNotes.TabIndex = 9
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Turquoise
        Me.lblNotes.Location = New System.Drawing.Point(3, 388)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(53, 19)
        Me.lblNotes.TabIndex = 21
        Me.lblNotes.Text = "Notes:"
        '
        'txtDiscoveredBy
        '
        Me.txtDiscoveredBy.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtDiscoveredBy.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscoveredBy.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(185, 227)
        Me.txtDiscoveredBy.Name = "txtDiscoveredBy"
        Me.txtDiscoveredBy.Size = New System.Drawing.Size(184, 23)
        Me.txtDiscoveredBy.TabIndex = 4
        Me.txtDiscoveredBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.Location = New System.Drawing.Point(183, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Discovered By:"
        '
        'txtFaunaID
        '
        Me.txtFaunaID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFaunaID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtFaunaID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaunaID.ForeColor = System.Drawing.Color.Aqua
        Me.txtFaunaID.Location = New System.Drawing.Point(152, 9)
        Me.txtFaunaID.Name = "txtFaunaID"
        Me.txtFaunaID.ReadOnly = True
        Me.txtFaunaID.Size = New System.Drawing.Size(70, 23)
        Me.txtFaunaID.TabIndex = 1
        Me.txtFaunaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(78, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fauna ID:"
        '
        'txtPlanetID
        '
        Me.txtPlanetID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPlanetID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtPlanetID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetID.ForeColor = System.Drawing.Color.Aqua
        Me.txtPlanetID.Location = New System.Drawing.Point(468, 9)
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
        Me.Label1.Location = New System.Drawing.Point(397, 9)
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
        Me.txtAccountID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.ForeColor = System.Drawing.Color.Aqua
        Me.txtAccountID.Location = New System.Drawing.Point(310, 9)
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
        Me.lblAccountID.Location = New System.Drawing.Point(229, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(85, 19)
        Me.lblAccountID.TabIndex = 6
        Me.lblAccountID.Text = "AccountID:"
        '
        'txtFaunaOriginalName
        '
        Me.txtFaunaOriginalName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFaunaOriginalName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtFaunaOriginalName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaunaOriginalName.ForeColor = System.Drawing.Color.Black
        Me.txtFaunaOriginalName.Location = New System.Drawing.Point(6, 71)
        Me.txtFaunaOriginalName.Name = "txtFaunaOriginalName"
        Me.txtFaunaOriginalName.Size = New System.Drawing.Size(1059, 32)
        Me.txtFaunaOriginalName.TabIndex = 1
        Me.txtFaunaOriginalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFaunaOriginalName
        '
        Me.lblFaunaOriginalName.AutoSize = True
        Me.lblFaunaOriginalName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaunaOriginalName.ForeColor = System.Drawing.Color.Turquoise
        Me.lblFaunaOriginalName.Location = New System.Drawing.Point(7, 49)
        Me.lblFaunaOriginalName.Name = "lblFaunaOriginalName"
        Me.lblFaunaOriginalName.Size = New System.Drawing.Size(199, 19)
        Me.lblFaunaOriginalName.TabIndex = 3
        Me.lblFaunaOriginalName.Text = "Enter Fauna Original Name:"
        '
        'Form_EnterFauna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 546)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlEntry)
        Me.Name = "Form_EnterFauna"
        Me.Text = "Form_EnterFauna"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.pbFaunaPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnImportPicture As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents pnlEntry As Panel
    Friend WithEvents txtImageFilename As TextBox
    Friend WithEvents txtImageEXT As TextBox
    Friend WithEvents pbFaunaPic As PictureBox
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
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtDiscoveredBy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFaunaID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtFaunaOriginalName As TextBox
    Friend WithEvents lblFaunaOriginalName As Label
    Friend WithEvents txtFaunaNewName As TextBox
    Friend WithEvents Label2 As Label
End Class
