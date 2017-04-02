<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SnX1 = New HTML_IDEx.SnX()
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SnX1)
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 12)
        Me.Panel1.TabIndex = 1
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'SnX1
        '
        Me.SnX1.AcceptsTab = True
        Me.SnX1.CaseSensitive = False
        Me.SnX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SnX1.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.SnX1.Location = New System.Drawing.Point(0, 0)
        Me.SnX1.Name = "SnX1"
        Me.SnX1.Size = New System.Drawing.Size(927, 12)
        Me.SnX1.TabIndex = 1
        Me.SnX1.Text = ""
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(12, 48)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(927, 405)
        Me.browser.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.browser)
        Me.Name = "Form2"
        Me.Text = "HTML-IDEx "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SnX1 As HTML_IDEx.SnX
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
End Class
