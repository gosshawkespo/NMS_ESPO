<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETCURRENTVERSIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePlanetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLANETSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.pbarMain = New System.Windows.Forms.ProgressBar()
        Me.txtMainClock = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EntriesToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowsToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1246, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EntriesToolStripMenuItem
        '
        Me.EntriesToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.EntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SETCURRENTVERSIONToolStripMenuItem, Me.LOGToolStripMenuItem, Me.PRODUCTSToolStripMenuItem, Me.SHIPSToolStripMenuItem, Me.PLANETSToolStripMenuItem, Me.SYSTEMSToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.EntriesToolStripMenuItem.Name = "EntriesToolStripMenuItem"
        Me.EntriesToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EntriesToolStripMenuItem.Text = "Entries"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(231, 22)
        Me.ToolStripMenuItem1.Text = "ACCOUNT / GAME NAME"
        '
        'SETCURRENTVERSIONToolStripMenuItem
        '
        Me.SETCURRENTVERSIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSystemToolStripMenuItem, Me.SavePlanetToolStripMenuItem, Me.SaveAreaToolStripMenuItem})
        Me.SETCURRENTVERSIONToolStripMenuItem.Name = "SETCURRENTVERSIONToolStripMenuItem"
        Me.SETCURRENTVERSIONToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SETCURRENTVERSIONToolStripMenuItem.Text = "SET CURRENT VERSION"
        '
        'SaveSystemToolStripMenuItem
        '
        Me.SaveSystemToolStripMenuItem.Name = "SaveSystemToolStripMenuItem"
        Me.SaveSystemToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveSystemToolStripMenuItem.Text = "Save System"
        '
        'SavePlanetToolStripMenuItem
        '
        Me.SavePlanetToolStripMenuItem.Name = "SavePlanetToolStripMenuItem"
        Me.SavePlanetToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SavePlanetToolStripMenuItem.Text = "Save Planet"
        '
        'SaveAreaToolStripMenuItem
        '
        Me.SaveAreaToolStripMenuItem.Name = "SaveAreaToolStripMenuItem"
        Me.SaveAreaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveAreaToolStripMenuItem.Text = "Save Area"
        '
        'LOGToolStripMenuItem
        '
        Me.LOGToolStripMenuItem.Name = "LOGToolStripMenuItem"
        Me.LOGToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LOGToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.LOGToolStripMenuItem.Text = "LOG VIEW"
        '
        'PRODUCTSToolStripMenuItem
        '
        Me.PRODUCTSToolStripMenuItem.Name = "PRODUCTSToolStripMenuItem"
        Me.PRODUCTSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PRODUCTSToolStripMenuItem.Text = "PRODUCTS"
        '
        'SHIPSToolStripMenuItem
        '
        Me.SHIPSToolStripMenuItem.Name = "SHIPSToolStripMenuItem"
        Me.SHIPSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SHIPSToolStripMenuItem.Text = "SHIPS"
        '
        'PLANETSToolStripMenuItem
        '
        Me.PLANETSToolStripMenuItem.Name = "PLANETSToolStripMenuItem"
        Me.PLANETSToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PLANETSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PLANETSToolStripMenuItem.Text = "PLANETS"
        '
        'SYSTEMSToolStripMenuItem
        '
        Me.SYSTEMSToolStripMenuItem.Name = "SYSTEMSToolStripMenuItem"
        Me.SYSTEMSToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SYSTEMSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SYSTEMSToolStripMenuItem.Text = "SYSTEMS"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantChartToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'GantChartToolStripMenuItem
        '
        Me.GantChartToolStripMenuItem.Name = "GantChartToolStripMenuItem"
        Me.GantChartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GantChartToolStripMenuItem.Text = "Gant Chart"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem, Me.SimpleCalculatorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.CheckOnClick = True
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.CheckOnClick = True
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.DarkToolStripMenuItem.Text = "Dark"
        '
        'SimpleCalculatorToolStripMenuItem
        '
        Me.SimpleCalculatorToolStripMenuItem.Name = "SimpleCalculatorToolStripMenuItem"
        Me.SimpleCalculatorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.SimpleCalculatorToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.SimpleCalculatorToolStripMenuItem.Text = "Simple Calculator"
        '
        'txtMessages
        '
        Me.txtMessages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessages.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtMessages.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessages.ForeColor = System.Drawing.Color.AliceBlue
        Me.txtMessages.Location = New System.Drawing.Point(0, 27)
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.Size = New System.Drawing.Size(1246, 26)
        Me.txtMessages.TabIndex = 1
        '
        'pbarMain
        '
        Me.pbarMain.BackColor = System.Drawing.Color.DarkRed
        Me.pbarMain.ForeColor = System.Drawing.Color.SpringGreen
        Me.pbarMain.Location = New System.Drawing.Point(488, 5)
        Me.pbarMain.Name = "pbarMain"
        Me.pbarMain.Size = New System.Drawing.Size(279, 15)
        Me.pbarMain.TabIndex = 2
        Me.pbarMain.Value = 100
        '
        'txtMainClock
        '
        Me.txtMainClock.BackColor = System.Drawing.Color.Black
        Me.txtMainClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainClock.ForeColor = System.Drawing.Color.Red
        Me.txtMainClock.Location = New System.Drawing.Point(990, -2)
        Me.txtMainClock.Name = "txtMainClock"
        Me.txtMainClock.Size = New System.Drawing.Size(165, 26)
        Me.txtMainClock.TabIndex = 3
        '
        'Timer1
        '
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.TransactionsToolStripMenuItem.Text = "TRANSACTIONS"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1246, 538)
        Me.Controls.Add(Me.txtMainClock)
        Me.Controls.Add(Me.pbarMain)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "No Mans Sky"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHIPSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtMessages As TextBox
    Friend WithEvents SETCURRENTVERSIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbarMain As ProgressBar
    Friend WithEvents txtMainClock As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePlanetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLANETSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SYSTEMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
End Class
