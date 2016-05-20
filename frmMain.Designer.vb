<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblProcessonTime = New System.Windows.Forms.Label()
        Me.lblHaarFaceFile = New System.Windows.Forms.Label()
        Me.lblHaarEyeFile = New System.Windows.Forms.Label()
        Me.lblImageFile = New System.Windows.Forms.Label()
        Me.tbHaarFaceFile = New System.Windows.Forms.TextBox()
        Me.tbOpenImageFile = New System.Windows.Forms.TextBox()
        Me.tbHaarEyeFile = New System.Windows.Forms.TextBox()
        Me.ofdHaarFace = New System.Windows.Forms.OpenFileDialog()
        Me.ofdHaareye = New System.Windows.Forms.OpenFileDialog()
        Me.ofdOpenedImage = New System.Windows.Forms.OpenFileDialog()
        Me.gbSpeed = New System.Windows.Forms.GroupBox()
        Me.rbSlow = New System.Windows.Forms.RadioButton()
        Me.rbBalanced = New System.Windows.Forms.RadioButton()
        Me.rbFast = New System.Windows.Forms.RadioButton()
        Me.ibImage = New Emgu.CV.UI.ImageBox()
        Me.gbSpeed.SuspendLayout()
        CType(Me.ibImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(15, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(569, 52)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Instructions:click on the haar face and eye labels below and choose the correct ." &
    "xml files for them."
        '
        'lblProcessonTime
        '
        Me.lblProcessonTime.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessonTime.Location = New System.Drawing.Point(370, 28)
        Me.lblProcessonTime.Name = "lblProcessonTime"
        Me.lblProcessonTime.Size = New System.Drawing.Size(178, 23)
        Me.lblProcessonTime.TabIndex = 1
        '
        'lblHaarFaceFile
        '
        Me.lblHaarFaceFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaarFaceFile.Location = New System.Drawing.Point(15, 61)
        Me.lblHaarFaceFile.Name = "lblHaarFaceFile"
        Me.lblHaarFaceFile.Size = New System.Drawing.Size(176, 21)
        Me.lblHaarFaceFile.TabIndex = 2
        Me.lblHaarFaceFile.Text = "Choose haar face file:"
        '
        'lblHaarEyeFile
        '
        Me.lblHaarEyeFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaarEyeFile.Location = New System.Drawing.Point(12, 91)
        Me.lblHaarEyeFile.Name = "lblHaarEyeFile"
        Me.lblHaarEyeFile.Size = New System.Drawing.Size(179, 19)
        Me.lblHaarEyeFile.TabIndex = 3
        Me.lblHaarEyeFile.Text = "Choose haar eye file:"
        '
        'lblImageFile
        '
        Me.lblImageFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageFile.Location = New System.Drawing.Point(12, 123)
        Me.lblImageFile.Name = "lblImageFile"
        Me.lblImageFile.Size = New System.Drawing.Size(179, 19)
        Me.lblImageFile.TabIndex = 4
        Me.lblImageFile.Text = "Open image file:"
        '
        'tbHaarFaceFile
        '
        Me.tbHaarFaceFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHaarFaceFile.Location = New System.Drawing.Point(197, 54)
        Me.tbHaarFaceFile.Name = "tbHaarFaceFile"
        Me.tbHaarFaceFile.Size = New System.Drawing.Size(805, 28)
        Me.tbHaarFaceFile.TabIndex = 5
        Me.tbHaarFaceFile.Text = "C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_frontal" &
    "face_default.xml"
        '
        'tbOpenImageFile
        '
        Me.tbOpenImageFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOpenImageFile.Location = New System.Drawing.Point(197, 120)
        Me.tbOpenImageFile.Name = "tbOpenImageFile"
        Me.tbOpenImageFile.Size = New System.Drawing.Size(805, 28)
        Me.tbOpenImageFile.TabIndex = 6
        '
        'tbHaarEyeFile
        '
        Me.tbHaarEyeFile.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHaarEyeFile.Location = New System.Drawing.Point(197, 86)
        Me.tbHaarEyeFile.Name = "tbHaarEyeFile"
        Me.tbHaarEyeFile.Size = New System.Drawing.Size(805, 28)
        Me.tbHaarEyeFile.TabIndex = 7
        Me.tbHaarEyeFile.Text = "C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_eye.xml" &
    ""
        '
        'ofdHaarFace
        '
        Me.ofdHaarFace.FileName = "OpenFileDialog1"
        '
        'ofdHaareye
        '
        Me.ofdHaareye.FileName = "OpenFileDialog2"
        '
        'ofdOpenedImage
        '
        Me.ofdOpenedImage.FileName = "OpenFileDialog3"
        '
        'gbSpeed
        '
        Me.gbSpeed.Controls.Add(Me.rbSlow)
        Me.gbSpeed.Controls.Add(Me.rbBalanced)
        Me.gbSpeed.Controls.Add(Me.rbFast)
        Me.gbSpeed.Location = New System.Drawing.Point(1013, 9)
        Me.gbSpeed.Name = "gbSpeed"
        Me.gbSpeed.Size = New System.Drawing.Size(197, 92)
        Me.gbSpeed.TabIndex = 8
        Me.gbSpeed.TabStop = False
        Me.gbSpeed.Text = "Processing Speed"
        '
        'rbSlow
        '
        Me.rbSlow.AutoSize = True
        Me.rbSlow.Checked = True
        Me.rbSlow.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSlow.Location = New System.Drawing.Point(6, 65)
        Me.rbSlow.Name = "rbSlow"
        Me.rbSlow.Size = New System.Drawing.Size(178, 24)
        Me.rbSlow.TabIndex = 2
        Me.rbSlow.TabStop = True
        Me.rbSlow.Text = "Slow Most Accurate"
        Me.rbSlow.UseVisualStyleBackColor = True
        '
        'rbBalanced
        '
        Me.rbBalanced.AutoSize = True
        Me.rbBalanced.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBalanced.Location = New System.Drawing.Point(6, 42)
        Me.rbBalanced.Name = "rbBalanced"
        Me.rbBalanced.Size = New System.Drawing.Size(93, 24)
        Me.rbBalanced.TabIndex = 1
        Me.rbBalanced.TabStop = True
        Me.rbBalanced.Text = "Balanced"
        Me.rbBalanced.UseVisualStyleBackColor = True
        '
        'rbFast
        '
        Me.rbFast.AutoSize = True
        Me.rbFast.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFast.Location = New System.Drawing.Point(6, 19)
        Me.rbFast.Name = "rbFast"
        Me.rbFast.Size = New System.Drawing.Size(194, 24)
        Me.rbFast.TabIndex = 0
        Me.rbFast.TabStop = True
        Me.rbFast.Text = "Fastest Least Accurate"
        Me.rbFast.UseVisualStyleBackColor = True
        '
        'ibImage
        '
        Me.ibImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ibImage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ibImage.Location = New System.Drawing.Point(0, 154)
        Me.ibImage.Name = "ibImage"
        Me.ibImage.Size = New System.Drawing.Size(1222, 292)
        Me.ibImage.TabIndex = 2
        Me.ibImage.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 446)
        Me.Controls.Add(Me.ibImage)
        Me.Controls.Add(Me.gbSpeed)
        Me.Controls.Add(Me.tbHaarEyeFile)
        Me.Controls.Add(Me.tbOpenImageFile)
        Me.Controls.Add(Me.tbHaarFaceFile)
        Me.Controls.Add(Me.lblImageFile)
        Me.Controls.Add(Me.lblHaarEyeFile)
        Me.Controls.Add(Me.lblHaarFaceFile)
        Me.Controls.Add(Me.lblProcessonTime)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.gbSpeed.ResumeLayout(False)
        Me.gbSpeed.PerformLayout()
        CType(Me.ibImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblProcessonTime As Label
    Friend WithEvents lblHaarFaceFile As Label
    Friend WithEvents lblHaarEyeFile As Label
    Friend WithEvents lblImageFile As Label
    Friend WithEvents tbHaarFaceFile As TextBox
    Friend WithEvents tbOpenImageFile As TextBox
    Friend WithEvents tbHaarEyeFile As TextBox
    Friend WithEvents ofdHaarFace As OpenFileDialog
    Friend WithEvents ofdHaareye As OpenFileDialog
    Friend WithEvents ofdOpenedImage As OpenFileDialog
    Friend WithEvents gbSpeed As GroupBox
    Friend WithEvents rbSlow As RadioButton
    Friend WithEvents rbBalanced As RadioButton
    Friend WithEvents rbFast As RadioButton
    Friend WithEvents ibImage As Emgu.CV.UI.ImageBox
End Class
