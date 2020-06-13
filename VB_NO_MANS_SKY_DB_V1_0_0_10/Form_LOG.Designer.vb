<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTITLE = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExportToCSV = New System.Windows.Forms.Button()
        Me.txtTITLE2 = New System.Windows.Forms.TextBox()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvLOG = New System.Windows.Forms.DataGridView()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.lblTotalRows = New System.Windows.Forms.Label()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvLOG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.Controls.Add(Me.Panel2)
        Me.pnlTop.Controls.Add(Me.txtTITLE)
        Me.pnlTop.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTop.Location = New System.Drawing.Point(2, 1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1216, 49)
        Me.pnlTop.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-1, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 38)
        Me.Panel2.TabIndex = 1
        '
        'txtTITLE
        '
        Me.txtTITLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE.BackColor = System.Drawing.Color.Brown
        Me.txtTITLE.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE.Location = New System.Drawing.Point(1, 4)
        Me.txtTITLE.Name = "txtTITLE"
        Me.txtTITLE.Size = New System.Drawing.Size(1215, 41)
        Me.txtTITLE.TabIndex = 0
        Me.txtTITLE.Text = "NO MAN'S SKY DATABASE"
        Me.txtTITLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.BackColor = System.Drawing.Color.DarkRed
        Me.pnlButtons.Controls.Add(Me.btnEDIT)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Controls.Add(Me.btnExportToCSV)
        Me.pnlButtons.Location = New System.Drawing.Point(3, 89)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1215, 67)
        Me.pnlButtons.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Green
        Me.btnClose.Location = New System.Drawing.Point(1096, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnExportToCSV
        '
        Me.btnExportToCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExportToCSV.BackColor = System.Drawing.Color.Transparent
        Me.btnExportToCSV.BackgroundImage = CType(resources.GetObject("btnExportToCSV.BackgroundImage"), System.Drawing.Image)
        Me.btnExportToCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExportToCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportToCSV.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToCSV.ForeColor = System.Drawing.Color.Green
        Me.btnExportToCSV.Location = New System.Drawing.Point(200, 12)
        Me.btnExportToCSV.Name = "btnExportToCSV"
        Me.btnExportToCSV.Size = New System.Drawing.Size(186, 43)
        Me.btnExportToCSV.TabIndex = 0
        Me.btnExportToCSV.UseVisualStyleBackColor = False
        '
        'txtTITLE2
        '
        Me.txtTITLE2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTITLE2.BackColor = System.Drawing.Color.Brown
        Me.txtTITLE2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITLE2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtTITLE2.Location = New System.Drawing.Point(2, 46)
        Me.txtTITLE2.Name = "txtTITLE2"
        Me.txtTITLE2.Size = New System.Drawing.Size(1215, 41)
        Me.txtTITLE2.TabIndex = 0
        Me.txtTITLE2.Text = "LOG"
        Me.txtTITLE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlGrid
        '
        Me.pnlGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGrid.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnlGrid.Controls.Add(Me.lblTotalRows)
        Me.pnlGrid.Controls.Add(Me.txtRows)
        Me.pnlGrid.Controls.Add(Me.dgvLOG)
        Me.pnlGrid.Controls.Add(Me.btnSearch)
        Me.pnlGrid.Controls.Add(Me.txtSearch)
        Me.pnlGrid.Controls.Add(Me.lblSearch)
        Me.pnlGrid.Controls.Add(Me.Label1)
        Me.pnlGrid.Controls.Add(Me.txtDateTo)
        Me.pnlGrid.Controls.Add(Me.lblDateFrom)
        Me.pnlGrid.Controls.Add(Me.txtDateFrom)
        Me.pnlGrid.Location = New System.Drawing.Point(2, 162)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1215, 330)
        Me.pnlGrid.TabIndex = 2
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFrom.ForeColor = System.Drawing.Color.Lime
        Me.lblDateFrom.Location = New System.Drawing.Point(358, 20)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(78, 17)
        Me.lblDateFrom.TabIndex = 1
        Me.lblDateFrom.Text = "Date From:"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDateFrom.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Location = New System.Drawing.Point(436, 18)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(182, 25)
        Me.txtDateFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(639, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date To:"
        '
        'txtDateTo
        '
        Me.txtDateTo.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDateTo.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Location = New System.Drawing.Point(700, 20)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(182, 25)
        Me.txtDateTo.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Lime
        Me.lblSearch.Location = New System.Drawing.Point(24, 22)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(54, 17)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSearch.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(80, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(182, 25)
        Me.txtSearch.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Green
        Me.btnSearch.Location = New System.Drawing.Point(911, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(105, 43)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvLOG
        '
        Me.dgvLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOG.Location = New System.Drawing.Point(27, 61)
        Me.dgvLOG.Name = "dgvLOG"
        Me.dgvLOG.Size = New System.Drawing.Size(1175, 253)
        Me.dgvLOG.TabIndex = 7
        '
        'txtRows
        '
        Me.txtRows.BackColor = System.Drawing.Color.AliceBlue
        Me.txtRows.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRows.Location = New System.Drawing.Point(1118, 19)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(84, 25)
        Me.txtRows.TabIndex = 8
        '
        'lblTotalRows
        '
        Me.lblTotalRows.AutoSize = True
        Me.lblTotalRows.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRows.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalRows.Location = New System.Drawing.Point(1072, 23)
        Me.lblTotalRows.Name = "lblTotalRows"
        Me.lblTotalRows.Size = New System.Drawing.Size(47, 17)
        Me.lblTotalRows.TabIndex = 9
        Me.lblTotalRows.Text = "Rows:"
        '
        'btnEDIT
        '
        Me.btnEDIT.BackColor = System.Drawing.Color.Transparent
        Me.btnEDIT.BackgroundImage = CType(resources.GetObject("btnEDIT.BackgroundImage"), System.Drawing.Image)
        Me.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEDIT.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDIT.ForeColor = System.Drawing.Color.Green
        Me.btnEDIT.Location = New System.Drawing.Point(555, 12)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(105, 43)
        Me.btnEDIT.TabIndex = 2
        Me.btnEDIT.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 531)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.txtTITLE2)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "Form1"
        Me.Text = "No Man's Sky - LOG"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.dgvLOG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTITLE As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExportToCSV As Button
    Friend WithEvents txtTITLE2 As TextBox
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents txtDateFrom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateTo As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnEDIT As Button
    Friend WithEvents lblTotalRows As Label
    Friend WithEvents txtRows As TextBox
    Friend WithEvents dgvLOG As DataGridView
End Class
