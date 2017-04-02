<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInput
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.mkc_split = New mkc_CodeBox.mkc_CodeBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.KryptonNavigator2 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.mkc_tab = New mkc_CodeBox.mkc_CodeBox()
        Me.KryptonPage4 = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonNavigator1.SuspendLayout()
        CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPage1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPage2.SuspendLayout()
        CType(Me.KryptonNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonNavigator2.SuspendLayout()
        CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPage3.SuspendLayout()
        CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonNavigator1
        '
        Me.KryptonNavigator1.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.SlantEqualBoth
        Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonNavigator1.Name = "KryptonNavigator1"
        Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
        Me.KryptonNavigator1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.KryptonNavigator1.SelectedIndex = 0
        Me.KryptonNavigator1.Size = New System.Drawing.Size(1228, 586)
        Me.KryptonNavigator1.TabIndex = 3
        Me.KryptonNavigator1.Text = "KryptonNavigator1"
        '
        'KryptonPage1
        '
        Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.KryptonPage1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPage1.Flags = 65534
        Me.KryptonPage1.LastVisibleSet = True
        Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.KryptonPage1.Name = "KryptonPage1"
        Me.KryptonPage1.Size = New System.Drawing.Size(1226, 560)
        Me.KryptonPage1.Text = "Split View"
        Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.KryptonPage1.UniqueName = "11CB6FCF06F84B3411B151E81F78B1C3"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.mkc_split)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1226, 560)
        Me.KryptonSplitContainer1.SplitterDistance = 554
        Me.KryptonSplitContainer1.TabIndex = 1
        '
        'mkc_split
        '
        Me.mkc_split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mkc_split.Location = New System.Drawing.Point(0, 0)
        Me.mkc_split.Name = "mkc_split"
        Me.mkc_split.SelectedRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033\uc1 }" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.mkc_split.SelectedText = ""
        Me.mkc_split.Sidebar_BackgroundColor = System.Drawing.Color.Gray
        Me.mkc_split.Sidebar_Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.mkc_split.Sidebar_ForeColor = System.Drawing.Color.White
        Me.mkc_split.Sidebar_ShowLineNumbers = True
        Me.mkc_split.Size = New System.Drawing.Size(554, 560)
        Me.mkc_split.TabIndex = 2
        Me.mkc_split.TextEditor_ColorCode = True
        Me.mkc_split.TextEditor_CommentCharacter = "<!--"
        Me.mkc_split.TextEditor_CommentTextColor = System.Drawing.Color.Green
        Me.mkc_split.TextEditor_DetectUrls = True
        Me.mkc_split.TextEditor_Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.mkc_split.TextEditor_KeywordDelimiter = ""
        Me.mkc_split.TextEditor_KeywordList = ""
        Me.mkc_split.TextEditor_KeywordTextColor = System.Drawing.Color.Blue
        Me.mkc_split.TextEditor_NormalTextColor = System.Drawing.Color.Black
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(667, 560)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'KryptonPage2
        '
        Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.KryptonPage2.Controls.Add(Me.KryptonNavigator2)
        Me.KryptonPage2.Flags = 65534
        Me.KryptonPage2.LastVisibleSet = True
        Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.KryptonPage2.Name = "KryptonPage2"
        Me.KryptonPage2.Size = New System.Drawing.Size(1226, 560)
        Me.KryptonPage2.Text = "Tabbed View"
        Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.KryptonPage2.UniqueName = "BF71D3847B7E49B95B988C25FA6A59D3"
        '
        'KryptonNavigator2
        '
        Me.KryptonNavigator2.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote
        Me.KryptonNavigator2.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator2.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.KryptonNavigator2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonNavigator2.Name = "KryptonNavigator2"
        Me.KryptonNavigator2.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage3, Me.KryptonPage4})
        Me.KryptonNavigator2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonNavigator2.SelectedIndex = 0
        Me.KryptonNavigator2.Size = New System.Drawing.Size(1226, 560)
        Me.KryptonNavigator2.TabIndex = 0
        Me.KryptonNavigator2.Text = "KryptonNavigator2"
        '
        'KryptonPage3
        '
        Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.KryptonPage3.Controls.Add(Me.mkc_tab)
        Me.KryptonPage3.Flags = 65534
        Me.KryptonPage3.LastVisibleSet = True
        Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.KryptonPage3.Name = "KryptonPage3"
        Me.KryptonPage3.Size = New System.Drawing.Size(1224, 529)
        Me.KryptonPage3.Text = "Source Code"
        Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.KryptonPage3.UniqueName = "4AC38EBB049B4B907FB30EF2051DE72B"
        '
        'mkc_tab
        '
        Me.mkc_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mkc_tab.Location = New System.Drawing.Point(0, 0)
        Me.mkc_tab.Name = "mkc_tab"
        Me.mkc_tab.SelectedRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033\uc1 }" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.mkc_tab.SelectedText = ""
        Me.mkc_tab.Sidebar_BackgroundColor = System.Drawing.Color.Gray
        Me.mkc_tab.Sidebar_Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.mkc_tab.Sidebar_ForeColor = System.Drawing.Color.White
        Me.mkc_tab.Sidebar_ShowLineNumbers = True
        Me.mkc_tab.Size = New System.Drawing.Size(1224, 529)
        Me.mkc_tab.TabIndex = 3
        Me.mkc_tab.TextEditor_ColorCode = True
        Me.mkc_tab.TextEditor_CommentCharacter = "<!--"
        Me.mkc_tab.TextEditor_CommentTextColor = System.Drawing.Color.Green
        Me.mkc_tab.TextEditor_DetectUrls = True
        Me.mkc_tab.TextEditor_Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.mkc_tab.TextEditor_KeywordDelimiter = ""
        Me.mkc_tab.TextEditor_KeywordList = ""
        Me.mkc_tab.TextEditor_KeywordTextColor = System.Drawing.Color.Blue
        Me.mkc_tab.TextEditor_NormalTextColor = System.Drawing.Color.Black
        '
        'KryptonPage4
        '
        Me.KryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.KryptonPage4.Controls.Add(Me.WebBrowser2)
        Me.KryptonPage4.Flags = 65534
        Me.KryptonPage4.LastVisibleSet = True
        Me.KryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.KryptonPage4.Name = "KryptonPage4"
        Me.KryptonPage4.Size = New System.Drawing.Size(1224, 529)
        Me.KryptonPage4.Text = "WebBrowser Preview"
        Me.KryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.KryptonPage4.UniqueName = "EE06032626994ABE7699BA59546BC98C"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(1224, 529)
        Me.WebBrowser2.TabIndex = 0
        '
        'MainInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonNavigator1)
        Me.Name = "MainInput"
        Me.Size = New System.Drawing.Size(1228, 586)
        CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonNavigator1.ResumeLayout(False)
        CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPage1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPage2.ResumeLayout(False)
        CType(Me.KryptonNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonNavigator2.ResumeLayout(False)
        CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPage3.ResumeLayout(False)
        CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents mkc_split As mkc_CodeBox.mkc_CodeBox
    Friend WithEvents KryptonNavigator2 As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents mkc_tab As mkc_CodeBox.mkc_CodeBox
    Friend WithEvents KryptonPage4 As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser

End Class
