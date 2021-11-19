<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TextBoxPathToWoW = New System.Windows.Forms.TextBox()
        Me.TextBoxOldRealmName = New System.Windows.Forms.TextBox()
        Me.TextBoxNewaRealmName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelOldRealmName = New System.Windows.Forms.Label()
        Me.LabelWoWPath = New System.Windows.Forms.Label()
        Me.LabelNewRealmName = New System.Windows.Forms.Label()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBoxAccountName = New System.Windows.Forms.TextBox()
        Me.LabelAccountName = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.OldCharNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewCharNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPathToWoW
        '
        Me.TextBoxPathToWoW.Location = New System.Drawing.Point(137, 54)
        Me.TextBoxPathToWoW.Name = "TextBoxPathToWoW"
        Me.TextBoxPathToWoW.ReadOnly = True
        Me.TextBoxPathToWoW.Size = New System.Drawing.Size(532, 20)
        Me.TextBoxPathToWoW.TabIndex = 0
        Me.TextBoxPathToWoW.Text = "C:\Program Files (x86)\World of Warcraft"
        '
        'TextBoxOldRealmName
        '
        Me.TextBoxOldRealmName.Location = New System.Drawing.Point(137, 80)
        Me.TextBoxOldRealmName.Name = "TextBoxOldRealmName"
        Me.TextBoxOldRealmName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOldRealmName.TabIndex = 0
        Me.TextBoxOldRealmName.Text = "Heartstriker"
        '
        'TextBoxNewaRealmName
        '
        Me.TextBoxNewaRealmName.Location = New System.Drawing.Point(137, 106)
        Me.TextBoxNewaRealmName.Name = "TextBoxNewaRealmName"
        Me.TextBoxNewaRealmName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNewaRealmName.TabIndex = 0
        Me.TextBoxNewaRealmName.Text = "Herzensbrecher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(267, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WoW Realm Replacer"
        '
        'LabelOldRealmName
        '
        Me.LabelOldRealmName.AutoSize = True
        Me.LabelOldRealmName.Location = New System.Drawing.Point(21, 83)
        Me.LabelOldRealmName.Name = "LabelOldRealmName"
        Me.LabelOldRealmName.Size = New System.Drawing.Size(87, 13)
        Me.LabelOldRealmName.TabIndex = 1
        Me.LabelOldRealmName.Text = "Old Realm Name"
        '
        'LabelWoWPath
        '
        Me.LabelWoWPath.AutoSize = True
        Me.LabelWoWPath.Location = New System.Drawing.Point(21, 57)
        Me.LabelWoWPath.Name = "LabelWoWPath"
        Me.LabelWoWPath.Size = New System.Drawing.Size(72, 13)
        Me.LabelWoWPath.TabIndex = 1
        Me.LabelWoWPath.Text = "Path to WoW"
        '
        'LabelNewRealmName
        '
        Me.LabelNewRealmName.AutoSize = True
        Me.LabelNewRealmName.Location = New System.Drawing.Point(21, 109)
        Me.LabelNewRealmName.Name = "LabelNewRealmName"
        Me.LabelNewRealmName.Size = New System.Drawing.Size(93, 13)
        Me.LabelNewRealmName.TabIndex = 1
        Me.LabelNewRealmName.Text = "New Realm Name"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(675, 52)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(81, 23)
        Me.ButtonBrowse.TabIndex = 2
        Me.ButtonBrowse.Text = "Browse..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'ButtonGo
        '
        Me.ButtonGo.Location = New System.Drawing.Point(681, 130)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGo.TabIndex = 3
        Me.ButtonGo.Text = "Go"
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(594, 130)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'TextBoxAccountName
        '
        Me.TextBoxAccountName.Location = New System.Drawing.Point(137, 132)
        Me.TextBoxAccountName.Name = "TextBoxAccountName"
        Me.TextBoxAccountName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAccountName.TabIndex = 0
        '
        'LabelAccountName
        '
        Me.LabelAccountName.AutoSize = True
        Me.LabelAccountName.Location = New System.Drawing.Point(21, 135)
        Me.LabelAccountName.Name = "LabelAccountName"
        Me.LabelAccountName.Size = New System.Drawing.Size(78, 13)
        Me.LabelAccountName.TabIndex = 1
        Me.LabelAccountName.Text = "Account Name"
        '
        'DGV
        '
        Me.DGV.AllowDrop = True
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OldCharNameColumn, Me.NewCharNameColumn})
        Me.DGV.Location = New System.Drawing.Point(12, 159)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(776, 163)
        Me.DGV.TabIndex = 4
        '
        'OldCharNameColumn
        '
        Me.OldCharNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OldCharNameColumn.FillWeight = 50.0!
        Me.OldCharNameColumn.HeaderText = "Old Char Name"
        Me.OldCharNameColumn.Name = "OldCharNameColumn"
        '
        'NewCharNameColumn
        '
        Me.NewCharNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NewCharNameColumn.FillWeight = 50.0!
        Me.NewCharNameColumn.HeaderText = "New Char Name"
        Me.NewCharNameColumn.Name = "NewCharNameColumn"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(800, 334)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.LabelAccountName)
        Me.Controls.Add(Me.LabelNewRealmName)
        Me.Controls.Add(Me.LabelWoWPath)
        Me.Controls.Add(Me.LabelOldRealmName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAccountName)
        Me.Controls.Add(Me.TextBoxNewaRealmName)
        Me.Controls.Add(Me.TextBoxOldRealmName)
        Me.Controls.Add(Me.TextBoxPathToWoW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(816, 684)
        Me.MinimumSize = New System.Drawing.Size(816, 373)
        Me.Name = "Main"
        Me.Text = "WoW Realm Replacer"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPathToWoW As TextBox
    Friend WithEvents TextBoxOldRealmName As TextBox
    Friend WithEvents TextBoxNewaRealmName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelOldRealmName As Label
    Friend WithEvents LabelWoWPath As Label
    Friend WithEvents LabelNewRealmName As Label
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonGo As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents TextBoxAccountName As TextBox
    Friend WithEvents LabelAccountName As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents OldCharNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewCharNameColumn As DataGridViewTextBoxColumn
End Class
