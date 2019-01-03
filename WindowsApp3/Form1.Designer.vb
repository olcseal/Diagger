<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class diaggerMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(diaggerMain))
        Me.btn7zLocation = New System.Windows.Forms.Button()
        Me.ofd7zLocation = New System.Windows.Forms.OpenFileDialog()
        Me.lblCaseNumber = New System.Windows.Forms.Label()
        Me.mtxtCaseNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txt7zLocation = New System.Windows.Forms.TextBox()
        Me.lbl7zLocation = New System.Windows.Forms.Label()
        Me.fbdCustFileLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnCustFileLocation = New System.Windows.Forms.Button()
        Me.txtCustFileLocation = New System.Windows.Forms.TextBox()
        Me.lblCustFileLocation = New System.Windows.Forms.Label()
        Me.ofdDiagLocation = New System.Windows.Forms.OpenFileDialog()
        Me.txtDiagLocation = New System.Windows.Forms.TextBox()
        Me.btnDiagLocation = New System.Windows.Forms.Button()
        Me.lblDiagLocation = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsStatusBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn7zLocation
        '
        Me.btn7zLocation.Image = CType(resources.GetObject("btn7zLocation.Image"), System.Drawing.Image)
        Me.btn7zLocation.Location = New System.Drawing.Point(338, 49)
        Me.btn7zLocation.Name = "btn7zLocation"
        Me.btn7zLocation.Size = New System.Drawing.Size(22, 20)
        Me.btn7zLocation.TabIndex = 2
        Me.btn7zLocation.UseVisualStyleBackColor = True
        '
        'ofd7zLocation
        '
        Me.ofd7zLocation.FileName = "OpenFileDialog1"
        Me.ofd7zLocation.Filter = """Executable files|*.exe|All files|*.*"""
        Me.ofd7zLocation.InitialDirectory = "C:\Program Files\7-Zip\"
        Me.ofd7zLocation.Title = "Locate 7zip Executable"
        '
        'lblCaseNumber
        '
        Me.lblCaseNumber.AutoSize = True
        Me.lblCaseNumber.Location = New System.Drawing.Point(67, 26)
        Me.lblCaseNumber.Name = "lblCaseNumber"
        Me.lblCaseNumber.Size = New System.Drawing.Size(71, 13)
        Me.lblCaseNumber.TabIndex = 3
        Me.lblCaseNumber.Text = "Case Number"
        '
        'mtxtCaseNumber
        '
        Me.mtxtCaseNumber.Location = New System.Drawing.Point(144, 23)
        Me.mtxtCaseNumber.Mask = "######-######"
        Me.mtxtCaseNumber.Name = "mtxtCaseNumber"
        Me.mtxtCaseNumber.Size = New System.Drawing.Size(83, 20)
        Me.mtxtCaseNumber.TabIndex = 0
        '
        'txt7zLocation
        '
        Me.txt7zLocation.Location = New System.Drawing.Point(144, 49)
        Me.txt7zLocation.Name = "txt7zLocation"
        Me.txt7zLocation.Size = New System.Drawing.Size(188, 20)
        Me.txt7zLocation.TabIndex = 1
        Me.txt7zLocation.Text = "C:\Program Files\7-Zip\7z.exe"
        '
        'lbl7zLocation
        '
        Me.lbl7zLocation.AutoSize = True
        Me.lbl7zLocation.Location = New System.Drawing.Point(12, 52)
        Me.lbl7zLocation.Name = "lbl7zLocation"
        Me.lbl7zLocation.Size = New System.Drawing.Size(126, 13)
        Me.lbl7zLocation.TabIndex = 6
        Me.lbl7zLocation.Text = "7zip Executable Location"
        '
        'fbdCustFileLocation
        '
        Me.fbdCustFileLocation.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.fbdCustFileLocation.SelectedPath = "E:\custfiles"
        '
        'btnCustFileLocation
        '
        Me.btnCustFileLocation.Image = CType(resources.GetObject("btnCustFileLocation.Image"), System.Drawing.Image)
        Me.btnCustFileLocation.Location = New System.Drawing.Point(338, 74)
        Me.btnCustFileLocation.Name = "btnCustFileLocation"
        Me.btnCustFileLocation.Size = New System.Drawing.Size(22, 20)
        Me.btnCustFileLocation.TabIndex = 4
        Me.btnCustFileLocation.UseVisualStyleBackColor = True
        '
        'txtCustFileLocation
        '
        Me.txtCustFileLocation.Location = New System.Drawing.Point(144, 75)
        Me.txtCustFileLocation.Name = "txtCustFileLocation"
        Me.txtCustFileLocation.Size = New System.Drawing.Size(188, 20)
        Me.txtCustFileLocation.TabIndex = 3
        Me.txtCustFileLocation.Text = "E:\custfiles"
        '
        'lblCustFileLocation
        '
        Me.lblCustFileLocation.AutoSize = True
        Me.lblCustFileLocation.Location = New System.Drawing.Point(24, 78)
        Me.lblCustFileLocation.Name = "lblCustFileLocation"
        Me.lblCustFileLocation.Size = New System.Drawing.Size(114, 13)
        Me.lblCustFileLocation.TabIndex = 7
        Me.lblCustFileLocation.Text = "Customer File Location"
        '
        'ofdDiagLocation
        '
        Me.ofdDiagLocation.FileName = "OpenFileDialog1"
        Me.ofdDiagLocation.Filter = "Tar Zip files (*.tar.gz;*.tgz;*.tar.bz2;*.tbz2)|*.tar.gz;*.tgz;*.tar.bz2;*.tbz2|A" &
    "ll files|*.*"
        Me.ofdDiagLocation.InitialDirectory = "Downloads"
        '
        'txtDiagLocation
        '
        Me.txtDiagLocation.Location = New System.Drawing.Point(144, 101)
        Me.txtDiagLocation.Name = "txtDiagLocation"
        Me.txtDiagLocation.Size = New System.Drawing.Size(188, 20)
        Me.txtDiagLocation.TabIndex = 1
        '
        'btnDiagLocation
        '
        Me.btnDiagLocation.Image = CType(resources.GetObject("btnDiagLocation.Image"), System.Drawing.Image)
        Me.btnDiagLocation.Location = New System.Drawing.Point(338, 101)
        Me.btnDiagLocation.Name = "btnDiagLocation"
        Me.btnDiagLocation.Size = New System.Drawing.Size(22, 20)
        Me.btnDiagLocation.TabIndex = 2
        Me.btnDiagLocation.UseVisualStyleBackColor = True
        '
        'lblDiagLocation
        '
        Me.lblDiagLocation.AutoSize = True
        Me.lblDiagLocation.Location = New System.Drawing.Point(57, 104)
        Me.lblDiagLocation.Name = "lblDiagLocation"
        Me.lblDiagLocation.Size = New System.Drawing.Size(81, 13)
        Me.lblDiagLocation.TabIndex = 8
        Me.lblDiagLocation.Text = "Select Diag File"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(257, 127)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 10
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsStatusBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 461)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(745, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsStatusBar
        '
        Me.stsStatusBar.Name = "stsStatusBar"
        Me.stsStatusBar.Size = New System.Drawing.Size(0, 17)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 161)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(721, 297)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(737, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'diaggerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 483)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblDiagLocation)
        Me.Controls.Add(Me.lblCustFileLocation)
        Me.Controls.Add(Me.lbl7zLocation)
        Me.Controls.Add(Me.txtCustFileLocation)
        Me.Controls.Add(Me.txtDiagLocation)
        Me.Controls.Add(Me.txt7zLocation)
        Me.Controls.Add(Me.mtxtCaseNumber)
        Me.Controls.Add(Me.lblCaseNumber)
        Me.Controls.Add(Me.btnCustFileLocation)
        Me.Controls.Add(Me.btnDiagLocation)
        Me.Controls.Add(Me.btn7zLocation)
        Me.Name = "diaggerMain"
        Me.Text = "ATAC Diagger"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn7zLocation As Button
    Friend WithEvents ofd7zLocation As OpenFileDialog
    Friend WithEvents lblCaseNumber As Label
    Friend WithEvents mtxtCaseNumber As MaskedTextBox
    Friend WithEvents txt7zLocation As TextBox
    Friend WithEvents lbl7zLocation As Label
    Friend WithEvents fbdCustFileLocation As FolderBrowserDialog
    Friend WithEvents btnCustFileLocation As Button
    Friend WithEvents txtCustFileLocation As TextBox
    Friend WithEvents lblCustFileLocation As Label
    Friend WithEvents ofdDiagLocation As OpenFileDialog
    Friend WithEvents txtDiagLocation As TextBox
    Friend WithEvents btnDiagLocation As Button
    Friend WithEvents lblDiagLocation As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsStatusBar As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
