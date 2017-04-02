Public Class options

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem <> Nothing Then
            btn_delete.Enabled = True
        Else
            btn_delete.Enabled = False
        End If
    End Sub

    Private Sub options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshwords()
        If My.Settings.ViewMode = "tab" Then radio_tabbedView.Checked = True
        If My.Settings.ViewMode = "split" Then radio_splitView.Checked = True
    End Sub
    Sub refreshwords()
        ListBox1.Items.Clear()
        Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath + "/syntax.txt")
        Dim i As Integer = 0
        For Each item In reader.ReadToEnd.Split("|")
            ListBox1.Items.Add(item)
        Next
        reader.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim writer As New System.IO.StreamWriter(My.Application.Info.DirectoryPath + "/syntax.txt", True)
        writer.Write("|" + txt_word.Text)
        writer.Close()
        refreshwords()
        MsgBox("HTML-IDEx Must be restarted to see any changes that have occured!")
    End Sub

    Private Sub btn_cfg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cfg.Click
        Process.Start(My.Application.Info.DirectoryPath + "/syntax.txt")
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim save As New RichTextBox 'Create textbox to do editing in
        Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath + "/syntax.txt") 'Retrieve Syntax words
        save.Text = reader.ReadToEnd 'Fill Textbox
        reader.Close() ' Close the streamreader
        save.Text = save.Text.Replace("|" & ListBox1.SelectedItem, "") ' Replace the selected entry with nothing
        Dim writer As New System.IO.StreamWriter(My.Application.Info.DirectoryPath + "/syntax.txt", False) 'Rewrite File
        writer.Write(save.Text) 'Still rewriting
        writer.Close()
        refreshwords() 'Refresh the list of keywords
        MsgBox("HTML-IDEx Must be restarted to see any changes that have occured!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If radio_splitView.Checked = True Then
            My.Settings.ViewMode = "split"
        Else
            If radio_tabbedView.Checked = True Then
                My.Settings.ViewMode = "tab"
            End If
        End If
        MsgBox("Settings have been applied!")
    End Sub
End Class