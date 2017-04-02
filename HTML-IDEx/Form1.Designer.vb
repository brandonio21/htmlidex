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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldBlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldBlockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicBlockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderlineBlockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicBlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLBlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeadBlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodyBlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagraphBlockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeaderBlockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.H1SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H2SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H3SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H4SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumberedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulletedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JavaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.updateChecker = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonNavigator1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.InsertToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveAsToolStripMenuItem1, Me.toolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Image = CType(resources.GetObject("NewToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem1.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save &As"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HTMLToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'HTMLToolStripMenuItem
        '
        Me.HTMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoldBlockToolStripMenuItem, Me.ItalicBlockToolStripMenuItem, Me.JavaToolStripMenuItem})
        Me.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        Me.HTMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HTMLToolStripMenuItem.Text = "HTML"
        '
        'BoldBlockToolStripMenuItem
        '
        Me.BoldBlockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoldBlockToolStripMenuItem1, Me.ItalicBlockToolStripMenuItem1, Me.UnderlineBlockToolStripMenuItem1})
        Me.BoldBlockToolStripMenuItem.Name = "BoldBlockToolStripMenuItem"
        Me.BoldBlockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BoldBlockToolStripMenuItem.Text = "Formatting"
        '
        'BoldBlockToolStripMenuItem1
        '
        Me.BoldBlockToolStripMenuItem1.Name = "BoldBlockToolStripMenuItem1"
        Me.BoldBlockToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.BoldBlockToolStripMenuItem1.Text = "Bold Block"
        '
        'ItalicBlockToolStripMenuItem1
        '
        Me.ItalicBlockToolStripMenuItem1.Name = "ItalicBlockToolStripMenuItem1"
        Me.ItalicBlockToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ItalicBlockToolStripMenuItem1.Text = "Italic Block"
        '
        'UnderlineBlockToolStripMenuItem1
        '
        Me.UnderlineBlockToolStripMenuItem1.Name = "UnderlineBlockToolStripMenuItem1"
        Me.UnderlineBlockToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.UnderlineBlockToolStripMenuItem1.Text = "Underline Block"
        '
        'ItalicBlockToolStripMenuItem
        '
        Me.ItalicBlockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HTMLBlockToolStripMenuItem, Me.HeadBlockToolStripMenuItem, Me.BodyBlockToolStripMenuItem, Me.ParagraphBlockToolStripMenuItem1, Me.HeaderBlockToolStripMenuItem1, Me.BreakLineToolStripMenuItem, Me.ListsToolStripMenuItem})
        Me.ItalicBlockToolStripMenuItem.Name = "ItalicBlockToolStripMenuItem"
        Me.ItalicBlockToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItalicBlockToolStripMenuItem.Text = "HTML"
        '
        'HTMLBlockToolStripMenuItem
        '
        Me.HTMLBlockToolStripMenuItem.Name = "HTMLBlockToolStripMenuItem"
        Me.HTMLBlockToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HTMLBlockToolStripMenuItem.Text = "HTML Block"
        '
        'HeadBlockToolStripMenuItem
        '
        Me.HeadBlockToolStripMenuItem.Name = "HeadBlockToolStripMenuItem"
        Me.HeadBlockToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HeadBlockToolStripMenuItem.Text = "Head Block"
        '
        'BodyBlockToolStripMenuItem
        '
        Me.BodyBlockToolStripMenuItem.Name = "BodyBlockToolStripMenuItem"
        Me.BodyBlockToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BodyBlockToolStripMenuItem.Text = "Body Block"
        '
        'ParagraphBlockToolStripMenuItem1
        '
        Me.ParagraphBlockToolStripMenuItem1.Name = "ParagraphBlockToolStripMenuItem1"
        Me.ParagraphBlockToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ParagraphBlockToolStripMenuItem1.Text = "Paragraph Block"
        '
        'HeaderBlockToolStripMenuItem1
        '
        Me.HeaderBlockToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H1SizeToolStripMenuItem, Me.H2SizeToolStripMenuItem, Me.H3SizeToolStripMenuItem, Me.H4SizeToolStripMenuItem})
        Me.HeaderBlockToolStripMenuItem1.Name = "HeaderBlockToolStripMenuItem1"
        Me.HeaderBlockToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.HeaderBlockToolStripMenuItem1.Text = "Header Block"
        '
        'H1SizeToolStripMenuItem
        '
        Me.H1SizeToolStripMenuItem.Name = "H1SizeToolStripMenuItem"
        Me.H1SizeToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.H1SizeToolStripMenuItem.Text = "h1 Size"
        '
        'H2SizeToolStripMenuItem
        '
        Me.H2SizeToolStripMenuItem.Name = "H2SizeToolStripMenuItem"
        Me.H2SizeToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.H2SizeToolStripMenuItem.Text = "h2 Size"
        '
        'H3SizeToolStripMenuItem
        '
        Me.H3SizeToolStripMenuItem.Name = "H3SizeToolStripMenuItem"
        Me.H3SizeToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.H3SizeToolStripMenuItem.Text = "h3 Size"
        '
        'H4SizeToolStripMenuItem
        '
        Me.H4SizeToolStripMenuItem.Name = "H4SizeToolStripMenuItem"
        Me.H4SizeToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.H4SizeToolStripMenuItem.Text = "h4 Size"
        '
        'BreakLineToolStripMenuItem
        '
        Me.BreakLineToolStripMenuItem.Name = "BreakLineToolStripMenuItem"
        Me.BreakLineToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BreakLineToolStripMenuItem.Text = "Break Line"
        '
        'ListsToolStripMenuItem
        '
        Me.ListsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumberedListToolStripMenuItem, Me.BulletedListToolStripMenuItem})
        Me.ListsToolStripMenuItem.Name = "ListsToolStripMenuItem"
        Me.ListsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ListsToolStripMenuItem.Text = "Lists"
        '
        'NumberedListToolStripMenuItem
        '
        Me.NumberedListToolStripMenuItem.Name = "NumberedListToolStripMenuItem"
        Me.NumberedListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NumberedListToolStripMenuItem.Text = "Numbered List"
        '
        'BulletedListToolStripMenuItem
        '
        Me.BulletedListToolStripMenuItem.Name = "BulletedListToolStripMenuItem"
        Me.BulletedListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BulletedListToolStripMenuItem.Text = "Bulleted List"
        '
        'JavaToolStripMenuItem
        '
        Me.JavaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppletToolStripMenuItem})
        Me.JavaToolStripMenuItem.Name = "JavaToolStripMenuItem"
        Me.JavaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JavaToolStripMenuItem.Text = "Java"
        '
        'AppletToolStripMenuItem
        '
        Me.AppletToolStripMenuItem.Name = "AppletToolStripMenuItem"
        Me.AppletToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AppletToolStripMenuItem.Text = "Applet"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'KryptonNavigator1
        '
        Me.KryptonNavigator1.AllowPageReorder = False
        Me.KryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.SquareEqualSmall
        Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 24)
        Me.KryptonNavigator1.Name = "KryptonNavigator1"
        Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage2})
        Me.KryptonNavigator1.SelectedIndex = 0
        Me.KryptonNavigator1.Size = New System.Drawing.Size(1001, 450)
        Me.KryptonNavigator1.TabIndex = 2
        Me.KryptonNavigator1.Text = "KryptonNavigator1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTabToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 48)
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Selected Tab"
        '
        'KryptonPage2
        '
        Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.KryptonPage2.Flags = 65534
        Me.KryptonPage2.LastVisibleSet = True
        Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.KryptonPage2.Name = "KryptonPage2"
        Me.KryptonPage2.Size = New System.Drawing.Size(999, 424)
        Me.KryptonPage2.Tag = "new"
        Me.KryptonPage2.Text = "..."
        Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.KryptonPage2.UniqueName = "0B8D4BFB74EA4C140EACC5079D815F74"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'updateChecker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 474)
        Me.Controls.Add(Me.KryptonNavigator1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HTML-IDEx"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonNavigator1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoldBlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalicBlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoldBlockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalicBlockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnderlineBlockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLBlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeadBlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodyBlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParagraphBlockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeaderBlockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H1SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H2SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H3SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H4SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BreakLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumberedListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BulletedListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents JavaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updateChecker As System.ComponentModel.BackgroundWorker

End Class
