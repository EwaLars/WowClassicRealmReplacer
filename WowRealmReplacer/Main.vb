
Imports System.IO
Imports System.Text

Public Class Main
    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim odd As New FolderBrowserDialog
        If odd.ShowDialog = DialogResult.OK Then
            Me.TextBoxPathToWoW.Text = odd.SelectedPath
        End If
    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        Dim classicPath As String = Path.Combine(Me.TextBoxPathToWoW.Text, "_classic_")
        Dim wtfPath As String = Path.Combine(Me.TextBoxPathToWoW.Text, "_classic_", "WTF")
        Dim accountPath As String = Path.Combine(wtfPath, "Account", Me.TextBoxAccountName.Text)
        Dim savedVariablesPath As String = Path.Combine(accountPath, "SavedVariables")
        Dim savedVariablesPathBackup As String = Path.Combine(accountPath, "SavedVariables" & "_" & Now.Ticks)
        Dim oldRealmFolder As String = Path.Combine(accountPath, Me.TextBoxOldRealmName.Text)
        Dim newRealmFolder As String = Path.Combine(accountPath, Me.TextBoxNewaRealmName.Text)
        Dim newRealmFolderBackup As String = Path.Combine(accountPath, Me.TextBoxNewaRealmName.Text & "_" & Now.Ticks)
        '>>> check if account name is set
        If String.IsNullOrWhiteSpace(Me.TextBoxAccountName.Text) Then
            MsgBox("account name blank is not allowed")
            Exit Sub
        End If
        '>>> check if account folder exists
        If Not Directory.Exists(oldRealmFolder) Then
            MsgBox($"couldn't find account folder '{oldRealmFolder}'")
            Exit Sub
        End If
        '>>> check if _classic_ folder exists
        If Not Directory.Exists(classicPath) Then
            MsgBox("No '_classic_' folder found")
            Exit Sub
        End If
        '>>> S T A R T
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
        '>>> change realm name and char name in lua files
        For Each newPath In Directory.GetFiles(newRealmFolder, "*.lua", SearchOption.AllDirectories)
            Dim filecontent As String = File.ReadAllText(newPath, Encoding.UTF8)
            filecontent = filecontent.Replace(Me.TextBoxOldRealmName.Text, Me.TextBoxNewaRealmName.Text)
            '>>> renaming chars
            For Each row As DataGridViewRow In DGV.Rows
                If row.Cells.Item(NewCharNameColumn.Name).Value IsNot Nothing AndAlso row.Cells.Item(OldCharNameColumn.Name).Value IsNot Nothing Then
                    Dim newCharName As String = row.Cells.Item(NewCharNameColumn.Name).Value.ToString
                    Dim oldCharName As String = row.Cells.Item(OldCharNameColumn.Name).Value.ToString
                    filecontent = filecontent.Replace(oldCharName, newCharName)
                End If
            Next
            File.WriteAllText(newPath, filecontent, Encoding.UTF8)
        Next
        '>>> renaming character folders
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells.Item(NewCharNameColumn.Name).Value IsNot Nothing AndAlso row.Cells.Item(OldCharNameColumn.Name).Value IsNot Nothing Then
                Dim newCharName As String = row.Cells.Item(NewCharNameColumn.Name).Value.ToString
                Dim oldCharName As String = row.Cells.Item(OldCharNameColumn.Name).Value.ToString
                Dim oldCharFolder As String = Path.Combine(newRealmFolder, oldCharName)
                Dim newCharFolder As String = Path.Combine(newRealmFolder, newCharName)
                If Directory.Exists(oldCharFolder) Then
                    Directory.Move(oldCharFolder, newCharFolder)
                End If
            End If
        Next
        '>>> change realm name and char name in saved variables lua files
        If Directory.Exists(savedVariablesPath) Then
            Directory.CreateDirectory(savedVariablesPathBackup)
            '>>> copy files
            For Each newPath In Directory.GetFiles(savedVariablesPath, "*.*", SearchOption.AllDirectories)
                File.Copy(newPath, newPath.Replace(savedVariablesPath, savedVariablesPathBackup), True)
            Next
            For Each newPath In Directory.GetFiles(savedVariablesPath, "*.lua", SearchOption.AllDirectories)
                Dim filecontent As String = File.ReadAllText(newPath, Encoding.UTF8)
                filecontent = filecontent.Replace(Me.TextBoxOldRealmName.Text, Me.TextBoxNewaRealmName.Text)
                '>>> renaming chars
                For Each row As DataGridViewRow In DGV.Rows
                    If row.Cells.Item(NewCharNameColumn.Name).Value IsNot Nothing AndAlso row.Cells.Item(OldCharNameColumn.Name).Value IsNot Nothing Then
                        Dim newCharName As String = row.Cells.Item(NewCharNameColumn.Name).Value.ToString
                        Dim oldCharName As String = row.Cells.Item(OldCharNameColumn.Name).Value.ToString
                        filecontent = filecontent.Replace(oldCharName, newCharName)
                    End If
                Next
                File.WriteAllText(newPath, filecontent, Encoding.UTF8)
            Next
        End If
        '>>> D O N E
        MsgBox("Replacement done")
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        MsgBox($"This tool is in experimental state{Environment.NewLine}Be sure to backup your WTF folder before you begin!{Environment.NewLine}Use at your own risk!")
    End Sub


End Class
