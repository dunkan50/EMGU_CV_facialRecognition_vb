
Option Strict On
'Option Explicit On

Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class frmMain

    ''''member variables'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim firstTimeResizeEvent As Boolean = True
    Dim originalFormWidth As Integer = 0
    Dim originalFormHeight As Integer = 0
    Dim originalImageBoxHeight As Integer = 0
    Dim originalImageBoxWidth As Integer = 0

    Dim originalImage As Mat
    ' Dim grayscaleImage As Mat
    Dim blankImage As Mat

    Dim acFace As MCvAvgComp()
    Dim acEye As MCvAvgComp()

    Dim hcFaceDetection As CascadeClassifier
    Dim hcEyeDetction As CascadeClassifier

    Dim swStopWatch As New Stopwatch()
    Dim timeSpan As TimeSpan
    Dim passedTime As String = ""


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ''''''constructor''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Sub New()

        ' This call is required by the designer.
        ' Add any initialization after the InitializeComponent() call.
        InitializeComponent()

        originalFormHeight = Me.Height
        originalFormWidth = Me.Width
        originalImageBoxHeight = ibImage.Height
        originalImageBoxWidth = ibImage.Width


    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'this if statement is to make sure that the constuctor is picked first

        If (firstTimeResizeEvent = True) Then
            firstTimeResizeEvent = False
        Else
            ibImage.Width = Me.Width - (originalFormWidth - originalImageBoxWidth)
            ibImage.Height = Me.Height - (originalFormHeight - originalImageBoxHeight)

        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub tbHaarFaceFile_Click(sender As Object, e As EventArgs) Handles tbHaarFaceFile.Click

        Dim drHaarFace As DialogResult

        drHaarFace = ofdHaarFace.ShowDialog()
        tbHaarFaceFile.Text = ofdHaarFace.FileName

        If (drHaarFace = DialogResult.OK And ofdHaarFace.FileName <> "") Then
            tbHaarFaceFile.Text = ofdHaarFace.FileName

        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub tbHaarEyeFile_Click(sender As Object, e As EventArgs) Handles tbHaarEyeFile.Click

        Dim drHaarEye As DialogResult

        drHaarEye = ofdHaareye.ShowDialog()
        tbHaarEyeFile.Text = ofdHaareye.FileName

        If (drHaarEye = DialogResult.OK And ofdHaareye.FileName <> "") Then
            tbHaarEyeFile.Text = ofdHaareye.FileName

        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub tbOpenImageFile_Click(sender As Object, e As EventArgs) Handles tbOpenImageFile.Click

        Dim drOpenImage As DialogResult

        drOpenImage = ofdOpenedImage.ShowDialog()
        tbOpenImageFile.Text = ofdOpenedImage.FileName

        If (drOpenImage = DialogResult.OK And ofdOpenedImage.FileName <> "") Then
            getAndProcessimage()

        End If


    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub getAndProcessimage()

        'originalImage = New Mat( Of Bgr, Byte)(textiamgefile.text)
        originalImage = New Mat(ofdOpenedImage.FileName, LoadImageType.Color)

        Dim grayscaleImage As New UMat()
        CvInvoke.CvtColor(originalImage, grayscaleImage, CvEnum.ColorConversion.Bgr2Gray)

        'do not have to call the haar files for the thare called at the top

        hcEyeDetction = New CascadeClassifier(tbHaarEyeFile.Text)
        hcFaceDetection = New CascadeClassifier(tbHaarFaceFile.Text)

        lblProcessonTime.Text = " Processing..... "
        ibImage.Image = blankImage
        Application.DoEvents()

        swStopWatch.Start()

        If (rbFast.Checked = True) Then
            'acFace = 
            'hcFaceDetection.DetectMultiScale(grayscaleImage, 1.2, 2, Size.Empty, Size.Empty) As New Rectangle()

            For Each faces As Rectangle In hcFaceDetection.DetectMultiScale(grayscaleImage, 1.2, 2, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, faces, New MCvScalar(0, 255, 0))
            Next

            For Each eyes As Rectangle In hcEyeDetction.DetectMultiScale(grayscaleImage, 1.2, 2, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, eyes, New MCvScalar(255, 0, 0))

            Next



        ElseIf (rbBalanced.Checked = True) Then

            For Each faces As Rectangle In hcFaceDetection.DetectMultiScale(grayscaleImage, 1.1, 3, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, faces, New MCvScalar(0, 255, 0))
            Next

            For Each eyes As Rectangle In hcEyeDetction.DetectMultiScale(grayscaleImage, 1.1, 3, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, eyes, New MCvScalar(255, 0, 0))

            Next

        ElseIf (rbSlow.Checked = True) Then

            For Each faces As Rectangle In hcFaceDetection.DetectMultiScale(grayscaleImage, 1.1, 15, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, faces, New MCvScalar(0, 255, 0))
            Next

            For Each eyes As Rectangle In hcEyeDetction.DetectMultiScale(grayscaleImage, 1.1, 25, New Size(20, 20), Size.Empty)
                CvInvoke.Rectangle(originalImage, eyes, New MCvScalar(255, 0, 0))

            Next

        End If
        swStopWatch.Stop()
        timeSpan = swStopWatch.Elapsed
        'passedTime = timeSpan.ToString("processing time =")

        'lblProcessonTime.Text = passedTime

        swStopWatch.Reset()


        ibImage.Image = originalImage


    End Sub
End Class
