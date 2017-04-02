Imports System.Text.RegularExpressions
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Net

'Still need to implement language system!
Public Class Form1
    Public richtextbox As RichTextBox
    Public numberbox As TextBox
    Public webbrowser As WebBrowser
    Public listbox As New ListBox
    Public currentVersion As String = ".2.2"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    'Private Sub RichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress
    '   If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
    '      RichTextBox1.SelectedText = "<br/>" + vbNewLine
    ' End If
    'End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        richtextbox.Text = ""
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateChecker.RunWorkerAsync()
        RunAsAdminClass.RunAsAdmin.runAsAdmin("HTML-IDEx.exe", Command(), Me)
        makeNewTab()
    End Sub

    Sub checkForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.dropbox.com/u/398377/HTML-IDEx/CurrentVersion.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim sourcecode As String = sr.ReadToEnd()

        If sourcecode <> currentVersion Then
            'There is an update available!
            Dim updateResult As DialogResult
            updateResult = MessageBox.Show("There is an update available! Would you like to download it? (This will close out of your work without prompting you to save) ", "Update available!", MessageBoxButtons.YesNo)
            If updateResult = Windows.Forms.DialogResult.Yes Then
                'Download the update
                Try
                    My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/398377/HTML-IDEx/update.exe", My.Application.Info.DirectoryPath + "/update.exe", "", "", False, 99999, True)
                    If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/update.exe") Then
                        'Download of updater executable went fine
                        Process.Start(My.Application.Info.DirectoryPath + "/update.exe")
                        End
                    Else
                        'Download went awry (Wrong word) - Try again
                        checkForUpdates()
                    End If
                Catch ex As Exception
                    MsgBox("Something went wrong when downloading the update!!")
                End Try
            Else
                'Do nothing, user didn't want to update
            End If
        Else
            'No update available! Carry on!!
        End If
    End Sub

    Sub insert(ByVal text As String)
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.SelectedText = text
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.RecolorCode()
    End Sub

    Private Sub BreakLineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BoldBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldBlockToolStripMenuItem.Click

    End Sub

    Private Sub ItalicBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicBlockToolStripMenuItem.Click

    End Sub

    Private Sub UnderlineBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MakeBoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub count_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BoldBlockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldBlockToolStripMenuItem1.Click
        insert("<b></b>")
    End Sub

    Private Sub ItalicBlockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicBlockToolStripMenuItem1.Click
        insert("<i></i>")
    End Sub

    Private Sub UnderlineBlockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineBlockToolStripMenuItem1.Click
        insert("<u></u>")
    End Sub

    Private Sub HTMLBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLBlockToolStripMenuItem.Click
        insert("<html>" & vbNewLine & "</html>")
    End Sub

    Private Sub HeadBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadBlockToolStripMenuItem.Click
        insert("<head>" & vbNewLine & "</head>")
    End Sub

    Private Sub BodyBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BodyBlockToolStripMenuItem.Click
        insert("<body>" & vbNewLine & "</body>")
    End Sub

    Private Sub ParagraphBlockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParagraphBlockToolStripMenuItem1.Click
        insert("<p></p>")
    End Sub

    Private Sub H1SizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1SizeToolStripMenuItem.Click
        insert("<h1></h1>")
    End Sub

    Private Sub H2SizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2SizeToolStripMenuItem.Click
        insert("<h2></h2>")
    End Sub

    Private Sub H3SizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3SizeToolStripMenuItem.Click
        insert("<h3></h3>")
    End Sub

    Private Sub H4SizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4SizeToolStripMenuItem.Click
        insert("<h4></h4>")
    End Sub

    Private Sub BreakLineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BreakLineToolStripMenuItem.Click
        insert("<hr />")
    End Sub



    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

    End Sub

    Sub richtextbox_selectionchanged()
        Dim caretposition As String = richtextbox.SelectionStart
        Dim linenumber As Integer = richtextbox.GetLineFromCharIndex(caretposition)
        numberbox.SelectionStart = numberbox.GetFirstCharIndexFromLine(linenumber)
        numberbox.SelectionLength = CInt(linenumber + 1).ToString.Count
        numberbox.HideSelection = False
        numberbox.ScrollToCaret()
    End Sub
    Sub richtextbox_textchanged()

        Me.Text = "HTML-IDEx : " + webbrowser.DocumentTitle
        webbrowser.DocumentText = richtextbox.Text
        Dim count As Integer = richtextbox.Lines.Count



        highlight()
        richtextbox_selectionchanged()
    End Sub
    Sub masshighlight()
        Dim ss As Integer = richtextbox.SelectionStart
        Dim sl As Integer = richtextbox.SelectionLength

        For Each item In listbox.Items
            FindAll(0, item, richtextbox)
        Next
        richtextbox.SelectionStart = ss
        richtextbox.SelectionLength = sl
        richtextbox.SelectionColor = Color.Black
    End Sub
    Private Sub FindAll(ByVal StartPosition As Integer, ByVal SearchText As String, ByVal rtbText As RichTextBox) 'This sub is borrowed from RunsWithScissors @ VBForums 

        'A holder for the next occuence of the specified text. Default is zero:
        Dim NextInstance As Integer = 0

        'Try to find the next occurence, and use the variable to hold the start position:
        NextInstance = rtbText.Find(SearchText, StartPosition, RichTextBoxFinds.WholeWord)

        'If an occurence of the search text is found, the value of NextInstance will be greater than
        'that of StartPosition:
        If NextInstance > StartPosition Then

            'Increment the value of a class member variable to reflect the count:
            '_Occurences = _Occurences + 1

            'Do something to the occuence of the specified text, if you need:
            rtbText.SelectionColor = Color.Blue

            'Call this Sub recursively:
            Me.FindAll(NextInstance + rtbText.SelectionLength, SearchText, rtbText)
        End If

    End Sub

    Sub highlight()
        Dim ss As Integer = richtextbox.SelectionStart
        Dim sl As Integer = richtextbox.SelectionLength

        For Each item In listbox.Items
            Dim searchString As String = item 'Set the searchString
            Dim cursorPos As Integer = richtextbox.SelectionStart 'Get the position of the Textbox Caret
            If cursorPos < searchString.Length Then Exit Sub 'If the text before the searchString is not long enough to contain it then skip the routine
            Dim TextToSearch As String = richtextbox.Text.Substring(cursorPos - Len(searchString), Len(searchString)) 'Get the 5 letters before the Caret
            'If TextToSearch matches the searchstring then we know the user has just finished typing it
            If TextToSearch = searchString Then
                'Do your highlighting
                richtextbox.SelectionStart = cursorPos - Len(searchString)
                richtextbox.SelectionLength = Len(searchString)
                richtextbox.SelectionColor = Color.Blue
            End If
            richtextbox.SelectionStart = ss
            richtextbox.SelectionLength = sl
            richtextbox.SelectionColor = Color.Black
        Next

    End Sub

    Private Sub NumberedListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberedListToolStripMenuItem.Click
        insert("<ol>" & vbNewLine & "<li>List Item</li>" & vbNewLine & "<li>List Item 2</li>" & vbNewLine & "<li>List Item 3 </li>" & vbNewLine & "</ol>")
    End Sub

    Private Sub BulletedListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletedListToolStripMenuItem.Click
        insert("<ul>" & vbNewLine & "<li>List Item</li>" & vbNewLine & "<li>List Item 2</li>" & vbNewLine & "<li>List Item 3 </li>" & vbNewLine & "</ul>")
    End Sub

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem1.Click
        makeNewTab()
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem1.Click
        Try
            Dim saver As New SaveFileDialog
            saver.ShowDialog()
            Dim writer As New System.IO.StreamWriter(saver.FileName)
            writer.Write(CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Text)
            writer.Close()
            writer.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim opener As New OpenFileDialog
            opener.ShowDialog()
            Dim reader As New System.IO.StreamReader(opener.FileName)
            makeNewTab()
            CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Text = reader.ReadToEnd
            CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).refreshWebbrowser()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim msg As DialogResult
        msg = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo)
        If msg = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RedoToolStripMenuItem_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.SelectAll()
    End Sub




    Private Sub SnX1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SnX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub KryptonPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub KryptonNavigator1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonNavigator1.SelectedPageChanged
        If KryptonNavigator1.SelectedPage.Tag = "new" Then
            makeNewTab()
        End If
    End Sub
    Sub makeNewTab()
        If KryptonNavigator1.SelectedPage.Tag = "new" Then
            Dim page As New ComponentFactory.Krypton.Navigator.KryptonPage
            page.Text = "Page Title"
            Dim MI As Control = New MainInput
            MI.Dock = DockStyle.Fill
            If My.Settings.ViewMode = "split" Then
                CType(MI.Controls.Item(0), ComponentFactory.Krypton.Navigator.KryptonNavigator).SelectedIndex = 0
            ElseIf My.Settings.ViewMode = "tab" Then
                CType(MI.Controls.Item(0), ComponentFactory.Krypton.Navigator.KryptonNavigator).SelectedIndex = 1
            End If
            page.Controls.Add(MI)

            Dim i As Integer = KryptonNavigator1.SelectedIndex
            KryptonNavigator1.Pages.Insert(i, page)
            KryptonNavigator1.SelectedPage = page
        Else


            Dim tab As New ComponentFactory.Krypton.Navigator.KryptonPage
            tab.Text = "Page Title"
            Dim MI As Control = New MainInput
            MI.Dock = DockStyle.Fill
            tab.Controls.Add(MI)
            If My.Settings.ViewMode = "split" Then
                CType(MI.Controls.Item(0), ComponentFactory.Krypton.Navigator.KryptonNavigator).SelectedIndex = 0
            ElseIf My.Settings.ViewMode = "tab" Then
                CType(MI.Controls.Item(0), ComponentFactory.Krypton.Navigator.KryptonNavigator).SelectedIndex = 1
            End If
            Dim i As Integer = getIndexofNewTab() + 1
            KryptonNavigator1.Pages.Insert(i, tab)
            KryptonNavigator1.SelectedPage = tab
            KryptonNavigator1.Pages.RemoveAt(KryptonNavigator1.SelectedIndex - 1)
        End If


    End Sub
    Function getIndexofNewTab() As Integer
        Dim i As Integer = KryptonNavigator1.SelectedIndex
        Dim page As ComponentFactory.Krypton.Navigator.KryptonPage
        For Each page In KryptonNavigator1.Pages
            If page.Tag = "new" Then
                KryptonNavigator1.SelectedPage = page
                Dim ind As Integer = KryptonNavigator1.SelectedIndex
                KryptonNavigator1.SelectedIndex = i
                Return ind
            End If
        Next
        Return 0
    End Function

    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        options.Show()
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        'This little piece of code simply deletes the currently selected tab
        Dim count As Integer = KryptonNavigator1.Pages.Count
        'When the tab is empty.
        If CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getCurrentTextBox.Text = "" Then
            Try
                Dim rmvr As Integer = KryptonNavigator1.SelectedIndex
                KryptonNavigator1.SelectedIndex = rmvr - 1
                KryptonNavigator1.Pages.RemoveAt(rmvr)
                If KryptonNavigator1.Pages.Count = count Then
                    'The tab encountered an error when deleting.
                    KryptonNavigator1.SelectedPage.Visible = False
                    'Simple make the page invisible! -- Doesn't seem to do anything
                End If
            Catch ex As Exception
                Dim rmvr As Integer = KryptonNavigator1.SelectedIndex
                KryptonNavigator1.SelectedIndex = rmvr + 1
                KryptonNavigator1.Pages.RemoveAt(rmvr)
                If KryptonNavigator1.Pages.Count = count Then
                    'The tab encountered an error when deleting.
                    KryptonNavigator1.SelectedPage.Visible = False
                    'Simple make the page invisible! -- Doesn't seem to do anything
                End If
            End Try
        Else
        'When there is still text in the text box
        Dim input As DialogResult
        input = MessageBox.Show("There is still coding in this tab! Would you like to close the tab?", "Are you sure?", MessageBoxButtons.YesNo)
        If input = DialogResult.Yes Then
                Try
                    Dim rmvr As Integer = KryptonNavigator1.SelectedIndex
                    KryptonNavigator1.SelectedIndex = rmvr - 1
                    KryptonNavigator1.Pages.RemoveAt(rmvr)
                    If KryptonNavigator1.Pages.Count = count Then
                        'The tab encountered an error when deleting.
                        KryptonNavigator1.SelectedPage.Visible = False
                        'Simple make the page invisible! -- Doesn't seem to do anything
                    End If
                Catch ex As Exception
                    Dim rmvr As Integer = KryptonNavigator1.SelectedIndex
                    KryptonNavigator1.SelectedIndex = rmvr + 1
                    KryptonNavigator1.Pages.RemoveAt(rmvr)
                    If KryptonNavigator1.Pages.Count = count Then
                        'The tab encountered an error when deleting.
                        KryptonNavigator1.SelectedPage.Visible = False
                        'Simple make the page invisible! -- Doesn't seem to do anything
                    End If
                End Try
            Else
                'Do nothing, user didn't want to close the tab

            End If
        End If
    End Sub

    Private Sub MainInput1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub getDocumentTitle()
        Try
            KryptonNavigator1.SelectedPage.Text = CType(KryptonNavigator1.SelectedPage.Controls.Item(0), MainInput).getDocumentTitle
        Catch e As Exception
            'There is an error... Do nothing!
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        getDocumentTitle()
    End Sub

    Private Sub AppletToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppletToolStripMenuItem.Click
        insert("<applet code = " & Chr(34) & Chr(34) & " width=" & Chr(34) & Chr(34) & " height=" & Chr(34) & Chr(34) & ">")
    End Sub

    Private Sub updateChecker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles updateChecker.DoWork
        checkForUpdates()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class











