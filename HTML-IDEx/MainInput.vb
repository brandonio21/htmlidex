
Public Class MainInput

    Private Sub SnX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub SnX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub SnX1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        refreshWebbrowser()

    End Sub

    Private Sub SnX1_MultilineChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SnX1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SnX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub SnX_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
    Public Sub refreshWebbrowser()
        getCurrentWebBrowser.DocumentText = getCurrentTextBox.Text
    End Sub
    Public Function getDocumentTitle() As String
        Return getCurrentWebBrowser.DocumentTitle
    End Function

    Private Sub SnX1_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mkc_split.KeyUp
        refreshWebbrowser()
    End Sub


    Private Sub Mkc_CodeBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkc_split.Load

    End Sub
    Function getCurrentTextBox() As mkc_CodeBox.mkc_CodeBox
        If KryptonNavigator1.SelectedIndex = 0 Then
            Return mkc_split
        Else
            Return mkc_tab
        End If
    End Function
    Function getCurrentWebBrowser() As WebBrowser
        If KryptonNavigator1.SelectedIndex = 0 Then
            Return WebBrowser1
        Else
            Return WebBrowser2
        End If
    End Function
    Sub syncTabs()
        If KryptonNavigator1.SelectedIndex = 0 Then
            mkc_split.Text = mkc_tab.Text
            mkc_split.RecolorCode()
            WebBrowser1.DocumentText = WebBrowser2.DocumentText
            Me.Refresh()
        Else
            mkc_tab.Text = mkc_split.Text
            mkc_tab.RecolorCode()
            WebBrowser2.DocumentText = WebBrowser1.DocumentText
            Me.Refresh()
        End If
    End Sub

    Private Sub mkc_tab_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mkc_tab.KeyUp
        refreshWebbrowser()
    End Sub

    Private Sub mkc_tab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkc_tab.Load

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

    End Sub

    Private Sub KryptonNavigator1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonNavigator1.SelectedPageChanged
        syncTabs()
    End Sub

    Private Sub MainInput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/syntax.txt") Then
            Dim reader As New System.IO.StreamReader(My.Application.Info.DirectoryPath + "/syntax.txt")
            Dim syntax As String = reader.ReadToEnd
            mkc_split.TextEditor_KeywordList = syntax
            mkc_split.TextEditor_KeywordDelimiter = "|"
            mkc_tab.TextEditor_KeywordList = syntax
            mkc_split.TextEditor_KeywordDelimiter = "|"
        End If
    End Sub
End Class
