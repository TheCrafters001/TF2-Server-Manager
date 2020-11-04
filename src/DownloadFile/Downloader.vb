Imports System.IO
Imports System.IO.Compression
Imports System.HttpStyleUriParser
Imports System.Net
Imports System.Net.Http

Public Class Downloader
    'This will NOT download anything harmful to your computer.
    'All Files Downloaded will come from VALVe. Meaning there
    'is nothing to worry about!

    'Please do NOT alter these files, as they are required, and
    'I don't want to be blamed for any wrong doing. Any pull request (PRs)
    'Will be ignored and closed.
    '
    '- TheCrafters001
    Public Shared Sub SteamCMD_DL(ByVal fileURL As String, ByVal fileOutput As String, ByVal Folder As String)
        If (Not System.IO.Directory.Exists(Folder)) Then
            System.IO.Directory.CreateDirectory(Folder)
        End If
        Using client = New WebClient()
            client.DownloadFile(New Uri(fileURL), Folder & fileOutput)
        End Using
    End Sub

    Public Shared Sub Unzip(ByVal zipName As String, ByVal folder As String)
        Dim startPath As String = folder
        Dim zipPath As String = folder & zipName & ".zip"
        Dim extractPath As String = folder
        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub

End Class
