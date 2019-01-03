Public Class diaggerMain
    Private Sub btn7zLocation_Click(sender As Object, e As EventArgs) Handles btn7zLocation.Click
        If ofd7zLocation.ShowDialog = DialogResult.OK Then
            txt7zLocation.Text = ofd7zLocation.FileName
        End If
    End Sub
    Private Sub btnCustFileLocation_Click(sender As Object, e As EventArgs) Handles btnCustFileLocation.Click
        If fbdCustFileLocation.ShowDialog = DialogResult.OK Then
            txtCustFileLocation.Text = fbdCustFileLocation.SelectedPath
        End If
    End Sub
    Private Sub btnDiagLocation_Click(sender As Object, e As EventArgs) Handles btnDiagLocation.Click
        ofdDiagLocation.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString + "\Downloads"
        If ofdDiagLocation.ShowDialog = DialogResult.OK Then
            txtDiagLocation.Text = ofdDiagLocation.FileName
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        stsStatusBar.Text = "Processesing, please wait..."
        'Create the new location for the Diag file
        My.Computer.FileSystem.CreateDirectory(txtCustFileLocation.Text + "\" + mtxtCaseNumber.Text)
        Dim DiagArray1() As String = Split(txtDiagLocation.Text, Delimiter:="\")
        Dim NewDiagLocation As String = txtCustFileLocation.Text + "\" + mtxtCaseNumber.Text + "\" + DiagArray1.Last

        'Check to see if file exists in new location already
        If Dir(NewDiagLocation) <> "" Then
            'File already exists, do skip moving
        Else
            'File not present, move the file
            My.Computer.FileSystem.MoveFile(txtDiagLocation.Text, NewDiagLocation)
        End If

        'Unzip the Diagfile using 7-zip
        Dim pinfo As New ProcessStartInfo()
        pinfo.FileName = txt7zLocation.Text
        pinfo.Arguments = "x " + NewDiagLocation + " -o" + txtCustFileLocation.Text + "\" + mtxtCaseNumber.Text + "\"
        Dim p As Process = Process.Start(pinfo)
        p.WaitForExit()

        'Figure out the path to the tar file after 7-Zip decompresses the file
        Dim DiagArray2() As String = Split(NewDiagLocation, Delimiter:=".")
        Dim TarPath As String = ""
        For i As Integer = 0 To DiagArray2.Length - 2
            TarPath = TarPath + DiagArray2(i) + "."
        Next
        TarPath = TarPath + "tar"

        'Use 7-Zip to untar the Diagfile
        Dim pinfo1 As New ProcessStartInfo()
        pinfo1.FileName = txt7zLocation.Text
        pinfo1.Arguments = "x " + TarPath + " -o" + txtCustFileLocation.Text + "\" + mtxtCaseNumber.Text + "\"
        Dim p1 As Process = Process.Start(pinfo1)
        p1.WaitForExit()
        stsStatusBar.Text = "Process complete, untarred Diafile located: " + txtCustFileLocation.Text + "\" + mtxtCaseNumber.Text + "\"
    End Sub
End Class
