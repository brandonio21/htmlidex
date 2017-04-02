Public Class Form2

    Private Sub Panel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Do Until Panel1.Size.Height > (Form1.Size.Height - 499)
            If Panel1.Size.Height < (Form1.Size.Height - 500) Then
                Dim pt As New System.Drawing.Point(Panel1.Width, Panel1.Height + i)
                Panel1.Size = pt
                Me.Refresh()
                Panel1.Refresh()
                i = i + 1
                System.Threading.Thread.Sleep(15)

            End If
        Loop

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim i As Integer = 0
        Do Until Panel1.Size.Height < 13
            If Panel1.Size.Height > 12 Then
                Dim pt As New System.Drawing.Point(Panel1.Width, Panel1.Height - i)
                Panel1.Size = pt
                Me.Refresh()
                Panel1.Refresh()
                i = i + 1
                System.Threading.Thread.Sleep(15)
            End If
        Loop
    End Sub

    Private Sub Panel1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.SizeChanged
        If Panel1.Size.Height = 12 Then
            Timer2.Stop()
            Timer2.Enabled = False
        End If
        If Panel1.Size.Height = 100 Then
            Timer1.Stop()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Enabled = True
        Timer2.Start()
    End Sub

    Private Sub Form2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Timer1.Enabled = True
    End Sub

    Private Sub SnX1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        'Timer2.Enabled = False
        'Timer1.Enabled = True
    End Sub

    Private Sub SnX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub SnX1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SnX1.MouseLeave
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub SnX1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SnX1.SelectionChanged

    End Sub

    Private Sub SnX1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnX1.TextChanged
        Dim html As String = SnX1.Text
        html = html.Replace("\r\n", "<br />")
        browser.Navigate("about:blank")
        browser.Document.OpenNew(False)
        browser.Document.Write(html)
        browser.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub


End Class