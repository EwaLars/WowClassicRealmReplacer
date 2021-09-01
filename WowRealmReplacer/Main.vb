
Imports System
Imports System.IO
Public Class Main
    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim odd As New FolderBrowserDialog
        If odd.ShowDialog = DialogResult.OK Then
            Me.TextBoxPathToWoW.Text = odd.SelectedPath
        End If
    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        Dim wowDir As New DirectoryInfo(Me.TextBoxPathToWoW.Text)

        Dim wtfPath As String = Path.Combine(Me.TextBoxPathToWoW.Text, "_classic_", "WTF", "Account", Me.TextBoxAccountName.Text)

        Dim oldRealmFolder As String = Path.Combine(wtfPath, Me.TextBoxOldRealmName.Text)
        Dim newRealmFolder As String = Path.Combine(wtfPath, Me.TextBoxNewaRealmName.Text)
        Dim newRealmFolderBackup As String = Path.Combine(wtfPath, Me.TextBoxNewaRealmName.Text & "_" & Now.Ticks)

        '>>> check if _classic_ folder exists
        If Directory.Exists(Path.Combine(Me.TextBoxPathToWoW.Text, "_classic_")) Then
            '>>> Rename New Realm Folder if already exists
            If Directory.Exists(newRealmFolder) Then
                Directory.Move(newRealmFolder, newRealmFolderBackup)
            End If

            '>>> create new realm folder
            Directory.CreateDirectory(newRealmFolder)
            '>>> copy directories
            For Each dirPath In Directory.GetDirectories(oldRealmFolder, "*", SearchOption.AllDirectories)
                Directory.CreateDirectory(dirPath.Replace(oldRealmFolder, newRealmFolder))
            Next
            '>>> copy files
            For Each newPath In Directory.GetFiles(oldRealmFolder, "*.*", SearchOption.AllDirectories)
                File.Copy(newPath, newPath.Replace(oldRealmFolder, newRealmFolder), True)
            Next
            '>>> change realm name in lua files
            For Each newPath In Directory.GetFiles(newRealmFolder, "*.lua", SearchOption.AllDirectories)
                Dim filecontent As String = File.ReadAllText(newPath)
                filecontent = filecontent.Replace(Me.TextBoxOldRealmName.Text, Me.TextBoxNewaRealmName.Text)
                File.WriteAllText(newPath, filecontent)
            Next
        Else
            MsgBox("No '_classic_' folder found")
        End If
    End Sub
End Class
