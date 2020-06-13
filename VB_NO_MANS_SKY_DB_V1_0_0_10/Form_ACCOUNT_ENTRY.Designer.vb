<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.lblEnterVersion = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtPlatform = New System.Windows.Forms.TextBox()
        Me.lblPlatform = New System.Windows.Forms.Label()
        Me.rXBOX = New System.Windows.Forms.RadioButton()
        Me.rbPS4 = New System.Windows.Forms.RadioButton()
        Me.rbPC = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.pnlAccountsGrid = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtNumRows = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSetDefault = New System.Windows.Forms.Button()
        Me.txtDefault = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.txtGameHandle = New System.Windows.Forms.TextBox()
        Me.lblGameHandle = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccountCreated = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.pnlAccountsGrid.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEnterVersion
        '
        Me.lblEnterVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEnterVersion.AutoSize = True
        Me.lblEnterVersion.BackColor = System.Drawing.Color.SkyBlue
        Me.lblEnterVersion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterVersion.Location = New System.Drawing.Point(31, 414)
        Me.lblEnterVersion.Name = "lblEnterVersion"
        Me.lblEnterVersion.Size = New System.Drawing.Size(150, 19)
        Me.lblEnterVersion.TabIndex = 0
        Me.lblEnterVersion.Text = "Enter Game Version:"
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.Location = New System.Drawing.Point(32, 436)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(149, 20)
        Me.txtVersion.TabIndex = 14
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtComment.Location = New System.Drawing.Point(32, 486)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(391, 74)
        Me.txtComment.TabIndex = 16
        '
        'lblComment
        '
        Me.lblComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblComment.AutoSize = True
        Me.lblComment.BackColor = System.Drawing.Color.SkyBlue
        Me.lblComment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(31, 464)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(78, 19)
        Me.lblComment.TabIndex = 2
        Me.lblComment.Text = "Comment:"
        '
        'txtPlatform
        '
        Me.txtPlatform.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlatform.Location = New System.Drawing.Point(32, 282)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(274, 20)
        Me.txtPlatform.TabIndex = 8
        '
        'lblPlatform
        '
        Me.lblPlatform.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.SkyBlue
        Me.lblPlatform.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(31, 260)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(112, 19)
        Me.lblPlatform.TabIndex = 4
        Me.lblPlatform.Text = "Enter Platform:"
        '
        'rXBOX
        '
        Me.rXBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rXBOX.AutoSize = True
        Me.rXBOX.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rXBOX.Location = New System.Drawing.Point(252, 262)
        Me.rXBOX.Name = "rXBOX"
        Me.rXBOX.Size = New System.Drawing.Size(54, 17)
        Me.rXBOX.TabIndex = 7
        Me.rXBOX.TabStop = True
        Me.rXBOX.Text = "XBOX"
        Me.rXBOX.UseVisualStyleBackColor = False
        '
        'rbPS4
        '
        Me.rbPS4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbPS4.AutoSize = True
        Me.rbPS4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPS4.Location = New System.Drawing.Point(199, 262)
        Me.rbPS4.Name = "rbPS4"
        Me.rbPS4.Size = New System.Drawing.Size(45, 17)
        Me.rbPS4.TabIndex = 6
        Me.rbPS4.TabStop = True
        Me.rbPS4.Text = "PS4"
        Me.rbPS4.UseVisualStyleBackColor = False
        '
        'rbPC
        '
        Me.rbPC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbPC.AutoSize = True
        Me.rbPC.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.rbPC.Location = New System.Drawing.Point(154, 261)
        Me.rbPC.Name = "rbPC"
        Me.rbPC.Size = New System.Drawing.Size(39, 17)
        Me.rbPC.TabIndex = 5
        Me.rbPC.TabStop = True
        Me.rbPC.Text = "PC"
        Me.rbPC.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSubmit.Location = New System.Drawing.Point(195, 568)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtAccountName
        '
        Me.txtAccountName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountName.Location = New System.Drawing.Point(32, 336)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(391, 20)
        Me.txtAccountName.TabIndex = 11
        '
        'lblAccountName
        '
        Me.lblAccountName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.BackColor = System.Drawing.Color.SkyBlue
        Me.lblAccountName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(31, 314)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(381, 19)
        Me.lblAccountName.TabIndex = 11
        Me.lblAccountName.Text = "Unique Account Name for DB Entries for THIS version:"
        '
        'pnlAccountsGrid
        '
        Me.pnlAccountsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccountsGrid.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlAccountsGrid.Controls.Add(Me.txtTitle)
        Me.pnlAccountsGrid.Controls.Add(Me.dgvAccounts)
        Me.pnlAccountsGrid.Location = New System.Drawing.Point(32, 12)
        Me.pnlAccountsGrid.Name = "pnlAccountsGrid"
        Me.pnlAccountsGrid.Size = New System.Drawing.Size(992, 222)
        Me.pnlAccountsGrid.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtTitle.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Cyan
        Me.txtTitle.Location = New System.Drawing.Point(3, 14)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(986, 32)
        Me.txtTitle.TabIndex = 2
        Me.txtTitle.Text = "Enter Account Details"
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AllowUserToOrderColumns = True
        Me.dgvAccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Location = New System.Drawing.Point(3, 50)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.Size = New System.Drawing.Size(986, 169)
        Me.dgvAccounts.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(946, 568)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtNumRows
        '
        Me.txtNumRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumRows.Location = New System.Drawing.Point(349, 282)
        Me.txtNumRows.Name = "txtNumRows"
        Me.txtNumRows.ReadOnly = True
        Me.txtNumRows.Size = New System.Drawing.Size(74, 20)
        Me.txtNumRows.TabIndex = 9
        Me.txtNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "#Accounts:"
        '
        'btnSetDefault
        '
        Me.btnSetDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetDefault.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSetDefault.Location = New System.Drawing.Point(32, 568)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnSetDefault.TabIndex = 17
        Me.btnSetDefault.Text = "Set Default"
        Me.btnSetDefault.UseVisualStyleBackColor = False
        '
        'txtDefault
        '
        Me.txtDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDefault.Location = New System.Drawing.Point(274, 436)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.ReadOnly = True
        Me.txtDefault.Size = New System.Drawing.Size(149, 20)
        Me.txtDefault.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Default Account ?"
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUserID.Location = New System.Drawing.Point(480, 282)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(92, 20)
        Me.txtUserID.TabIndex = 10
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(482, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "User ID"
        '
        'lblAccountID
        '
        Me.lblAccountID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.BackColor = System.Drawing.Color.SkyBlue
        Me.lblAccountID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.Location = New System.Drawing.Point(482, 314)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(90, 19)
        Me.lblAccountID.TabIndex = 23
        Me.lblAccountID.Text = "Account ID:"
        '
        'txtAccountID
        '
        Me.txtAccountID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountID.Location = New System.Drawing.Point(480, 336)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.ReadOnly = True
        Me.txtAccountID.Size = New System.Drawing.Size(92, 20)
        Me.txtAccountID.TabIndex = 12
        Me.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGameHandle
        '
        Me.txtGameHandle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGameHandle.Location = New System.Drawing.Point(32, 387)
        Me.txtGameHandle.Name = "txtGameHandle"
        Me.txtGameHandle.Size = New System.Drawing.Size(391, 20)
        Me.txtGameHandle.TabIndex = 13
        '
        'lblGameHandle
        '
        Me.lblGameHandle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGameHandle.AutoSize = True
        Me.lblGameHandle.BackColor = System.Drawing.Color.SkyBlue
        Me.lblGameHandle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameHandle.Location = New System.Drawing.Point(31, 365)
        Me.lblGameHandle.Name = "lblGameHandle"
        Me.lblGameHandle.Size = New System.Drawing.Size(253, 19)
        Me.lblGameHandle.TabIndex = 24
        Me.lblGameHandle.Text = "Game Handle (used for discoveries):"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.SpringGreen
        Me.btnNew.Location = New System.Drawing.Point(348, 568)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Account Created:"
        '
        'txtAccountCreated
        '
        Me.txtAccountCreated.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAccountCreated.Location = New System.Drawing.Point(480, 436)
        Me.txtAccountCreated.Name = "txtAccountCreated"
        Me.txtAccountCreated.ReadOnly = True
        Me.txtAccountCreated.Size = New System.Drawing.Size(128, 20)
        Me.txtAccountCreated.TabIndex = 25
        Me.txtAccountCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(482, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Last Updated:"
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLastUpdated.Location = New System.Drawing.Point(480, 486)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(128, 20)
        Me.txtLastUpdated.TabIndex = 27
        Me.txtLastUpdated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1036, 601)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLastUpdated)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAccountCreated)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtGameHandle)
        Me.Controls.Add(Me.lblGameHandle)
        Me.Controls.Add(Me.lblAccountID)
        Me.Controls.Add(Me.txtAccountID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtDefault)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSetDefault)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumRows)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlAccountsGrid)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rXBOX)
        Me.Controls.Add(Me.rbPS4)
        Me.Controls.Add(Me.rbPC)
        Me.Controls.Add(Me.txtPlatform)
        Me.Controls.Add(Me.lblPlatform)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.lblEnterVersion)
        Me.Name = "frmAccounts"
        Me.Text = "Enter Account Information"
        Me.pnlAccountsGrid.ResumeLayout(False)
        Me.pnlAccountsGrid.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterVersion As Label
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtPlatform As TextBox
    Friend WithEvents lblPlatform As Label
    Friend WithEvents rXBOX As RadioButton
    Friend WithEvents rbPS4 As RadioButton
    Friend WithEvents rbPC As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents lblAccountName As Label
    Friend WithEvents pnlAccountsGrid As Panel
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents txtNumRows As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSetDefault As Button
    Friend WithEvents txtDefault As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAccountID As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents txtGameHandle As TextBox
    Friend WithEvents lblGameHandle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccountCreated As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastUpdated As TextBox
End Class
