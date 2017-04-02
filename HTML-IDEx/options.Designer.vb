<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_cfg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_word = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_preferredViewMode = New System.Windows.Forms.Label()
        Me.radio_splitView = New System.Windows.Forms.RadioButton()
        Me.radio_tabbedView = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_delete)
        Me.TabPage1.Controls.Add(Me.btn_cfg)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(495, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Syntax"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.Location = New System.Drawing.Point(157, 143)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(127, 23)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Delete Selected Entry"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_cfg
        '
        Me.btn_cfg.Location = New System.Drawing.Point(375, 143)
        Me.btn_cfg.Name = "btn_cfg"
        Me.btn_cfg.Size = New System.Drawing.Size(114, 23)
        Me.btn_cfg.TabIndex = 4
        Me.btn_cfg.Text = "Open CFG File"
        Me.btn_cfg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.txt_word)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a syntax keyword"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(54, 62)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(184, 23)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add Keyword"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_word
        '
        Me.txt_word.Location = New System.Drawing.Point(69, 23)
        Me.txt_word.Name = "txt_word"
        Me.txt_word.Size = New System.Drawing.Size(235, 20)
        Me.txt_word.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Keyword : "
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 147)
        Me.ListBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Syntax Keywords"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(503, 200)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.radio_tabbedView)
        Me.TabPage2.Controls.Add(Me.radio_splitView)
        Me.TabPage2.Controls.Add(Me.lbl_preferredViewMode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(495, 174)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_preferredViewMode
        '
        Me.lbl_preferredViewMode.AutoSize = True
        Me.lbl_preferredViewMode.Location = New System.Drawing.Point(12, 13)
        Me.lbl_preferredViewMode.Name = "lbl_preferredViewMode"
        Me.lbl_preferredViewMode.Size = New System.Drawing.Size(123, 13)
        Me.lbl_preferredViewMode.TabIndex = 0
        Me.lbl_preferredViewMode.Text = "Preferred Viewing Mode:"
        '
        'radio_splitView
        '
        Me.radio_splitView.AutoSize = True
        Me.radio_splitView.Location = New System.Drawing.Point(45, 41)
        Me.radio_splitView.Name = "radio_splitView"
        Me.radio_splitView.Size = New System.Drawing.Size(71, 17)
        Me.radio_splitView.TabIndex = 1
        Me.radio_splitView.TabStop = True
        Me.radio_splitView.Text = "Split View"
        Me.radio_splitView.UseVisualStyleBackColor = True
        '
        'radio_tabbedView
        '
        Me.radio_tabbedView.AutoSize = True
        Me.radio_tabbedView.Location = New System.Drawing.Point(45, 64)
        Me.radio_tabbedView.Name = "radio_tabbedView"
        Me.radio_tabbedView.Size = New System.Drawing.Size(132, 17)
        Me.radio_tabbedView.TabIndex = 2
        Me.radio_tabbedView.TabStop = True
        Me.radio_tabbedView.Text = "Tabbed Viewing Mode"
        Me.radio_tabbedView.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 224)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "options"
        Me.Text = "HTML-IDEx Options"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_word As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cfg As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents radio_tabbedView As System.Windows.Forms.RadioButton
    Friend WithEvents radio_splitView As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_preferredViewMode As System.Windows.Forms.Label
End Class
