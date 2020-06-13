<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaypointEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaypointEntry))
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblResourceCoords = New System.Windows.Forms.Label()
        Me.txtWaypointLatitude = New System.Windows.Forms.TextBox()
        Me.txtWaypointLongitude = New System.Windows.Forms.TextBox()
        Me.txtImageFilename = New System.Windows.Forms.TextBox()
        Me.txtImageEXT = New System.Windows.Forms.TextBox()
        Me.pbWaypointPic = New System.Windows.Forms.PictureBox()
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
        Me.txtWaypointID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWaypointCoords = New System.Windows.Forms.Label()
        Me.txtPlanetID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtWaypointName = New System.Windows.Forms.TextBox()
        Me.lblWaypointName = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnImportPicture = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.pnlEntry.SuspendLayout()
        CType(Me.pbWaypointPic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlEntry.Controls.Add(Me.Label12)
        Me.pnlEntry.Controls.Add(Me.lblResourceCoords)
        Me.pnlEntry.Controls.Add(Me.txtWaypointLatitude)
        Me.pnlEntry.Controls.Add(Me.txtWaypointLongitude)
        Me.pnlEntry.Controls.Add(Me.txtImageFilename)
        Me.pnlEntry.Controls.Add(Me.txtImageEXT)
        Me.pnlEntry.Controls.Add(Me.pbWaypointPic)
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
        Me.pnlEntry.Controls.Add(Me.txtWaypointID)
        Me.pnlEntry.Controls.Add(Me.Label3)
        Me.pnlEntry.Controls.Add(Me.lblWaypointCoords)
        Me.pnlEntry.Controls.Add(Me.txtPlanetID)
        Me.pnlEntry.Controls.Add(Me.Label1)
        Me.pnlEntry.Controls.Add(Me.txtAccountID)
        Me.pnlEntry.Controls.Add(Me.lblAccountID)
        Me.pnlEntry.Controls.Add(Me.txtWaypointName)
        Me.pnlEntry.Controls.Add(Me.lblWaypointName)
        Me.pnlEntry.ForeColor = System.Drawing.Color.Transparent
        Me.pnlEntry.Location = New System.Drawing.Point(3, 1)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(1068, 509)
        Me.pnlEntry.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Turquoise
        Me.Label12.Location = New System.Drawing.Point(81, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 19)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "E/W"
        '
        'lblResourceCoords
        '
        Me.lblResourceCoords.AutoSize = True
        Me.lblResourceCoords.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceCoords.ForeColor = System.Drawing.Color.Turquoise
        Me.lblResourceCoords.Location = New System.Drawing.Point(11, 142)
        Me.lblResourceCoords.Name = "lblResourceCoords"
        Me.lblResourceCoords.Size = New System.Drawing.Size(36, 19)
        Me.lblResourceCoords.TabIndex = 151
        Me.lblResourceCoords.Text = "N/S"
        '
        'txtWaypointLatitude
        '
        Me.txtWaypointLatitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtWaypointLatitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaypointLatitude.ForeColor = System.Drawing.Color.Black
        Me.txtWaypointLatitude.Location = New System.Drawing.Point(78, 165)
        Me.txtWaypointLatitude.Name = "txtWaypointLatitude"
        Me.txtWaypointLatitude.Size = New System.Drawing.Size(66, 23)
        Me.txtWaypointLatitude.TabIndex = 3
        Me.txtWaypointLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWaypointLongitude
        '
        Me.txtWaypointLongitude.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtWaypointLongitude.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaypointLongitude.ForeColor = System.Drawing.Color.Black
        Me.txtWaypointLongitude.Location = New System.Drawing.Point(9, 165)
        Me.txtWaypointLongitude.Name = "txtWaypointLongitude"
        Me.txtWaypointLongitude.Size = New System.Drawing.Size(66, 23)
        Me.txtWaypointLongitude.TabIndex = 2
        Me.txtWaypointLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImageFilename
        '
        Me.txtImageFilename.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtImageFilename.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageFilename.ForeColor = System.Drawing.Color.Black
        Me.txtImageFilename.Location = New System.Drawing.Point(9, 297)
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
        Me.txtImageEXT.Location = New System.Drawing.Point(605, 295)
        Me.txtImageEXT.Name = "txtImageEXT"
        Me.txtImageEXT.ReadOnly = True
        Me.txtImageEXT.Size = New System.Drawing.Size(223, 23)
        Me.txtImageEXT.TabIndex = 8
        '
        'pbWaypointPic
        '
        Me.pbWaypointPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbWaypointPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbWaypointPic.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbWaypointPic.Location = New System.Drawing.Point(605, 109)
        Me.pbWaypointPic.Name = "pbWaypointPic"
        Me.pbWaypointPic.Size = New System.Drawing.Size(223, 182)
        Me.pbWaypointPic.TabIndex = 147
        Me.pbWaypointPic.TabStop = False
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastUpdated.BackColor = System.Drawing.Color.MediumBlue
        Me.txtLastUpdated.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.Color.Aqua
        Me.txtLastUpdated.Location = New System.Drawing.Point(659, 12)
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
        Me.Label13.Location = New System.Drawing.Point(553, 12)
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
        Me.imgCalendar_SelectDiscoveryDate.Location = New System.Drawing.Point(324, 222)
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
        Me.txtNumRows.Location = New System.Drawing.Point(871, 9)
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
        Me.Label11.Location = New System.Drawing.Point(817, 9)
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
        Me.txtDefault.Location = New System.Drawing.Point(464, 165)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(120, 23)
        Me.txtDefault.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Turquoise
        Me.Label10.Location = New System.Drawing.Point(467, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Default:"
        '
        'txtDiscoveryDate
        '
        Me.txtDiscoveryDate.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDiscoveryDate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscoveryDate.Location = New System.Drawing.Point(185, 230)
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
        Me.Label8.Location = New System.Drawing.Point(190, 208)
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
        Me.txtNotes.Location = New System.Drawing.Point(6, 348)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(1053, 157)
        Me.txtNotes.TabIndex = 9
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Turquoise
        Me.lblNotes.Location = New System.Drawing.Point(7, 326)
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
        Me.txtDiscoveredBy.Location = New System.Drawing.Point(185, 165)
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
        Me.Label4.Location = New System.Drawing.Point(183, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Discovered By:"
        '
        'txtWaypointID
        '
        Me.txtWaypointID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWaypointID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtWaypointID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaypointID.ForeColor = System.Drawing.Color.Aqua
        Me.txtWaypointID.Location = New System.Drawing.Point(149, 9)
        Me.txtWaypointID.Name = "txtWaypointID"
        Me.txtWaypointID.ReadOnly = True
        Me.txtWaypointID.Size = New System.Drawing.Size(70, 23)
        Me.txtWaypointID.TabIndex = 1
        Me.txtWaypointID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Turquoise
        Me.Label3.Location = New System.Drawing.Point(123, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID:"
        '
        'lblWaypointCoords
        '
        Me.lblWaypointCoords.AutoSize = True
        Me.lblWaypointCoords.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaypointCoords.ForeColor = System.Drawing.Color.Turquoise
        Me.lblWaypointCoords.Location = New System.Drawing.Point(11, 119)
        Me.lblWaypointCoords.Name = "lblWaypointCoords"
        Me.lblWaypointCoords.Size = New System.Drawing.Size(133, 19)
        Me.lblWaypointCoords.TabIndex = 11
        Me.lblWaypointCoords.Text = "Waypoint Coords:"
        '
        'txtPlanetID
        '
        Me.txtPlanetID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPlanetID.BackColor = System.Drawing.Color.MediumBlue
        Me.txtPlanetID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanetID.ForeColor = System.Drawing.Color.Aqua
        Me.txtPlanetID.Location = New System.Drawing.Point(465, 9)
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
        Me.Label1.Location = New System.Drawing.Point(394, 9)
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
        Me.txtAccountID.Location = New System.Drawing.Point(307, 9)
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
        Me.lblAccountID.Location = New System.Drawing.Point(226, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(85, 19)
        Me.lblAccountID.TabIndex = 6
        Me.lblAccountID.Text = "AccountID:"
        '
        'txtWaypointName
        '
        Me.txtWaypointName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWaypointName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtWaypointName.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaypointName.ForeColor = System.Drawing.Color.Black
        Me.txtWaypointName.Location = New System.Drawing.Point(6, 71)
        Me.txtWaypointName.Name = "txtWaypointName"
        Me.txtWaypointName.Size = New System.Drawing.Size(1052, 32)
        Me.txtWaypointName.TabIndex = 1
        Me.txtWaypointName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWaypointName
        '
        Me.lblWaypointName.AutoSize = True
        Me.lblWaypointName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaypointName.ForeColor = System.Drawing.Color.Turquoise
        Me.lblWaypointName.Location = New System.Drawing.Point(7, 49)
        Me.lblWaypointName.Name = "lblWaypointName"
        Me.lblWaypointName.Size = New System.Drawing.Size(165, 19)
        Me.lblWaypointName.TabIndex = 3
        Me.lblWaypointName.Text = "Enter Waypoint Name:"
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnImportPicture)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnSAVE)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 517)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1078, 44)
        Me.pnlButtons.TabIndex = 24
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
        'frmWaypointEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1078, 561)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlEntry)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximumSize = New System.Drawing.Size(1100, 800)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmWaypointEntry"
        Me.Text = "Waypoint Entry"
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        CType(Me.pbWaypointPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendar_SelectDiscoveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEntry As Panel
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
    Friend WithEvents txtWaypointID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWaypointCoords As Label
    Friend WithEvents txtPlanetID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtWaypointName As TextBox
    Friend WithEvents lblWaypointName As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtImageEXT As TextBox
    Friend WithEvents pbWaypointPic As PictureBox
    Friend WithEvents txtImageFilename As TextBox
    Friend WithEvents btnImportPicture As Button
    Friend WithEvents txtWaypointLatitude As TextBox
    Friend WithEvents txtWaypointLongitude As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblResourceCoords As Label
End Class
