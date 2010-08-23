Public Class Form1
    Public IPSWLocation As String
    Public PayloadSaveLocation As String
    Public cmdline As String
    Public temppath As String
    Private Declare Auto Function GetSystemMenu Lib "user32.dll" ( _
ByVal hWnd As IntPtr, _
ByVal bRevert As Int32 _
) As IntPtr

    Private Declare Auto Function GetMenuItemCount Lib "user32.dll" ( _
    ByVal hMenu As IntPtr _
    ) As Int32

    Private Declare Auto Function DrawMenuBar Lib "user32.dll" ( _
    ByVal hWnd As IntPtr _
    ) As Int32

    Private Declare Auto Function RemoveMenu Lib "user32.dll" ( _
    ByVal hMenu As IntPtr, _
    ByVal nPosition As Int32, _
    ByVal wFlags As Int32 _
    ) As Int32

    Private Const MF_BYPOSITION As Int32 = &H400
    Private Const MF_REMOVE As Int32 = &H1000

    Private Sub RemoveCloseButton(ByVal frmForm As Form)
        Dim hMenu As IntPtr, n As Int32
        hMenu = GetSystemMenu(frmForm.Handle, 0)
        If Not hMenu.Equals(IntPtr.Zero) Then
            n = GetMenuItemCount(hMenu)
            If n > 0 Then
                RemoveMenu(hMenu, n - 1, MF_BYPOSITION Or MF_REMOVE)
                RemoveMenu(hMenu, n - 2, MF_BYPOSITION Or MF_REMOVE)
                DrawMenuBar(frmForm.Handle)
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Preparing..."
        temppath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        Folder_Delete(temppath)
        Create_Directory(tempPath)
        cmdline = "cmd /c RD " & Quote.Text & temppath & "\ipsw-pwner" & Quote.Text & " /S /Q"
        ExecCmd(cmdline, True)
        Button1.Text = "Browse for 3.1.2 IPSW..."
        MsgBox("Browse for iPhone 3G[S] 3.1.2 ipsw.")
        find312.ShowDialog()
        If find312.FileName = "" Then
            MsgBox("No IPSW was Selected.")
            Button1.Enabled = True
            Button1.Text = "Pwn 3.1.2 iBoot"
            Exit Sub
        Else
            IPSWLocation = Quote.Text & find312.FileName & Quote.Text
            Button1.Text = "Unzipping IPSW..."
            Delay(1)
            UnZip(find312.FileName, temppath & "\ipsw-pwner\", 4096)
            SaveToDisk("iboot2g.patch", temppath & "\ipsw-pwner\iboot2g.patch")
            SaveToDisk("iboot3g.patch", temppath & "\ipsw-pwner\iboot3g.patch")
            SaveToDisk("iboot3gs.patch", temppath & "\ipsw-pwner\iboot3gs.patch")
            Button1.Text = "Select a Save Location for your Payloads."
            FolderBrowserDialog1.ShowDialog()
            If FolderBrowserDialog1.SelectedPath = "" Then
                MsgBox("No Save Path was Selected. Aborting...")
                Button1.Enabled = True
                Button1.Text = "Pwn 3.1.2 iBoot"
                Exit Sub
            Else
                PayloadSaveLocation = Quote.Text & FolderBrowserDialog1.SelectedPath & Quote.Text
                'iBoot
                Button1.Text = "Pwning iBoot..."
                cmdline = "xpwntool.exe " & Quote.Text & temppath & "\ipsw-pwner\Firmware\all_flash\all_flash.n88ap.production\iBoot.n88ap.RELEASE.img3" & Quote.Text & " " & Quote.Text & temppath & "\ipsw-pwner\iboot.d" & Quote.Text & " -iv 127aa60e77da219961ee70707f44cbd4 -k c72ab4aae971f3a9ec356dfe555e4aef72d8e96c480698445ac236904e6a3443"
                ExecCmd(cmdline, True)
                cmdline = "bspatch.exe " & Quote.Text & temppath & "\ipsw-pwner\iboot.d" & Quote.Text & " " & Quote.Text & FolderBrowserDialog1.SelectedPath & "\iboot.payload" & Quote.Text & " " & Quote.Text & temppath & "\ipsw-pwner\iboot3gs.patch"
                ExecCmd(cmdline, True)
                cmdline = "cmd /c DEL iboot.d /S /Q"
                ExecCmd(cmdline, True)
                Button1.Text = "Cleaning Up..."
                ExecCmd(cmdline, True)
                cmdline = "cmd /c RD " & Quote.Text & temppath & "\ipsw-pwner" & Quote.Text & " /S /Q"
                ExecCmd(cmdline, True)
                MsgBox("Your iBoot payload should be located in the saving location you specified!" & Chr(13) & Chr(13) & "Copy it to the directory iBooty is in.")
                Button1.Enabled = True
                Button1.Text = "Pwn 3.1.2 iBoot"
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemoveCloseButton(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
