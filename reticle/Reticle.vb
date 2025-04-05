Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Public Class Reticle

    ''' These are to allow mouse clicks through the form
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        Set_Window()
    End Sub

    Private Sub Set_Window()
        Dim exStyle As Integer = GetWindowLong(Me.Handle, GWL_EXSTYLE)
        SetWindowLong(Me.Handle, GWL_EXSTYLE, exStyle Or WS_EX_TRANSPARENT Or WS_EX_LAYERED)
    End Sub

    Public Property MoveByPxAmount As Integer
        Get
            Return _MoveByPxAmount
        End Get
        Set(value As Integer)
            _MoveByPxAmount = value
        End Set
    End Property

    Public Property ShowCenterOfReticle As Boolean
        Get
            Return _ShowCenterOfReticle
        End Get
        Set(value As Boolean)
            _ShowCenterOfReticle = value
            Me.Invalidate()
        End Set
    End Property

    Public Property ShowReticle As Boolean
        Get
            Return _ShowReticle
        End Get
        Set(value As Boolean)
            _ShowReticle = value
            Me.Invalidate()
        End Set
    End Property

    Public Property Size As Long
        Get
            Return _Size
        End Get
        Set(value As Long)
            If value <= 2 Then
                value = 3
            ElseIf value >= 10000 Then
                value = 9999
            End If

            Dim ReticleCenterX As Long
            Dim ReticleCenterY As Long

            ''' Keep the reticle centered '''
            ReticleCenterX = CInt(ReticleTopLeftX + (_Size / 2))
            ReticleCenterY = CInt(ReticleTopLeftY + (_Size / 2))

            _Size = value

            ReticleTopLeftX = ReticleCenterX - (_Size / 2)
            ReticleTopLeftY = ReticleCenterY - (_Size / 2)

            Me.Invalidate()
        End Set
    End Property

    Public Property X As Long
        Get
            Return ReticleTopLeftX
        End Get
        Set(value As Long)
            ReticleTopLeftX = value
        End Set
    End Property

    Public Property Y As Long
        Get
            Return ReticleTopLeftY
        End Get
        Set(value As Long)
            ReticleTopLeftY = value
        End Set
    End Property

    Public Property ScreenIndex As Integer
        Get
            Return Get_Screen_Index()
        End Get
        Set(value As Integer)
            SwitchToNextScreen(value)
        End Set
    End Property



    Private Const GWL_EXSTYLE As Integer = -20
    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Private Const WS_EX_LAYERED As Integer = &H80000

    Private Const DefaultSize As Long = 200

    Private _Size As Long = DefaultSize
    Private Reticles As New Dictionary(Of String, Image)
    Public ReticleKey As String
    Private ReticleImage As Image
    Private ReticleTopLeftX As Long
    Private ReticleTopLeftY As Long
    Private _MoveByPxAmount As Integer = 50
    Private ReticleId As Integer = 0
    Private _ShowCenterOfReticle As Boolean = False
    Private _ShowReticle As Boolean = True

    Private Sub Reticle_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Images()
        Set_Full_Screen()
    End Sub

    Private Sub Reticle_Window_ReSize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Icon = My.Resources.icon
        Me.DoubleBuffered = True
    End Sub

    Private Sub Reticle_Window_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        If Not ShowReticle Then Exit Sub
        e.Graphics.DrawImage(ReticleImage, ReticleTopLeftX, ReticleTopLeftY, Size, Size)

        If ShowCenterOfReticle = True Then
            e.Graphics.FillRectangle(
                New SolidBrush(Color.Blue),
                CInt(ReticleTopLeftX + (Size / 2) - 2),
                CInt(ReticleTopLeftY + (Size / 2) - 2),
                5,
                5
            )
        End If

    End Sub

    Public Sub Next_Reticle()

        If ReticleKey = Reticles.Last.Key Then
            ReticleImage = Reticles.First.Value
            ReticleKey = Reticles.First.Key
            Me.Invalidate()
            Exit Sub
        End If

        Dim FoundCurrentReticle As Boolean = False
        For Each kvp As KeyValuePair(Of String, Image) In Reticles
            If FoundCurrentReticle Then
                ReticleImage = kvp.Value
                ReticleKey = kvp.Key
                Me.Invalidate()
                Exit Sub
            End If
            If kvp.Key = ReticleKey Then FoundCurrentReticle = True
        Next

    End Sub

    Public Sub Previous_Reticle()

        If ReticleKey = Reticles.First.Key Then
            ReticleImage = Reticles.Last.Value
            ReticleKey = Reticles.Last.Key
            Me.Invalidate()
            Exit Sub
        End If

        Dim FoundCurrentReticle As Boolean = False
        Dim TempImage As Image
        Dim TempKey As String
        For Each kvp As KeyValuePair(Of String, Image) In Reticles
            If kvp.Key = ReticleKey Then FoundCurrentReticle = True
            If FoundCurrentReticle Then
                ReticleImage = TempImage
                ReticleKey = TempKey
                Me.Invalidate()
                Exit Sub
            End If
            TempImage = kvp.Value
            TempKey = kvp.Key
        Next

    End Sub

    Public Sub Move(ByVal AlongX As Boolean, ByVal ShouldIncrease As Boolean)

        If (ReticleTopLeftX + _MoveByPxAmount) > (Me.Width + (Size * 2)) Then Center_Reticle()
        If (ReticleTopLeftY + _MoveByPxAmount) > (Me.Height + (Size * 2)) Then Center_Reticle()
        If (ReticleTopLeftY - _MoveByPxAmount) < (0 - (Size * 2)) Then Center_Reticle()
        If (ReticleTopLeftX - _MoveByPxAmount) < (0 - (Size * 2)) Then Center_Reticle()

        If AlongX Then
            If ShouldIncrease Then
                ReticleTopLeftX = (ReticleTopLeftX + _MoveByPxAmount)
            Else
                ReticleTopLeftX = (ReticleTopLeftX - _MoveByPxAmount)
            End If
        Else
            If ShouldIncrease Then
                ReticleTopLeftY = (ReticleTopLeftY + _MoveByPxAmount)
            Else
                ReticleTopLeftY = (ReticleTopLeftY - _MoveByPxAmount)
            End If
        End If

        Me.Invalidate()

    End Sub

    Public Sub Grow()
        Size = Size * 1.25
    End Sub

    Public Sub Shrink()
        Size = Size * 0.75
    End Sub

    Public Sub Change_Rticle_Color_Matrix(
                                      Optional ByVal RedShift As Single = 1,
                                      Optional ByVal GreenShift As Single = 1,
                                      Optional ByVal BlueShift As Single = 1)

        ' Exit if the input image is null
        If ReticleImage Is Nothing Then Exit Sub

        ' Create a new bitmap to hold the modified image
        Dim bmp As New Bitmap(ReticleImage.Width, ReticleImage.Height)

        ' Create a ColorMatrix with scaling for Red, Green, and Blue
        Dim cm As New ColorMatrix(New Single()() {
        New Single() {RedShift, 0, 0, 0, 0}, ' Shift Red
        New Single() {0, GreenShift, 0, 0, 0}, ' Shift Green
        New Single() {0, 0, BlueShift, 0, 0}, ' Shift Blue
        New Single() {0, 0, 0, 1, 0}, ' Shift Alpha
        New Single() {0, 0, 0, 0, 1}  ' Translation (no shift)
    })

        ' Use Graphics to draw the image with the ColorMatrix applied
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim ia As New ImageAttributes()
            ia.SetColorMatrix(cm) ' Apply the ColorMatrix to ImageAttributes
            g.DrawImage(ReticleImage,
                    New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, ReticleImage.Width, ReticleImage.Height,
                    GraphicsUnit.Pixel,
                    ia)
        End Using

        ' Dispose the old image and replace it with the modified bitmap
        ReticleImage = bmp

        ' Optionally refresh the UI (if needed in a form application)
        Me.Invalidate() ' Refresh the window to show the updated image
    End Sub

    Public Sub Load_Images()
        Dim FolderPath As String = $"{Application.StartupPath}\reticle_images"
        Try
            ' Get all PNG files in the specified folder.
            Dim ImageFiles As String() = Directory.GetFiles(FolderPath, "*.png").ToArray()

            ' Load images into the dictionary.
            For Each file As String In ImageFiles
                Dim fileName As String = Path.GetFileNameWithoutExtension(file) ' Use the file name as the dictionary key.
                Reticles(fileName) = Image.FromFile(file) ' Load the image and save it in the dictionary.
            Next

            ' Optionally, set the first image as the active ReticleImage.
            If Reticles.Count > 0 Then
                ReticleImage = Reticles.First().Value
                ReticleKey = Reticles.First().Key
            End If

        Catch ex As Exception
            MsgBox($"No .png files were found in reticle_images folder: {FolderPath}!!! Closing app!", MsgBoxStyle.Critical, "Error MsgBox")
            End
        End Try
    End Sub

    Private Sub Set_Full_Screen()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        Me.Bounds = Screen.AllScreens(0).Bounds
        Center_Reticle()

    End Sub

    Public Sub Center_Reticle()
        ReticleTopLeftX = (Me.Width / 2) - (Size / 2)
        ReticleTopLeftY = (Me.Height / 2) - (Size / 2)
        Me.Invalidate()
    End Sub

    Public Sub SwitchToNextScreen(Optional ByVal ScreenIndex As Integer = -1)
        Me.WindowState = FormWindowState.Normal

        Dim currentScreen As Screen = Screen.FromControl(Me)
        Dim screens() As Screen = Screen.AllScreens
        Dim currentIndex As Integer = Array.IndexOf(screens, currentScreen)

        Dim nextIndex As Integer = (currentIndex + 1) Mod screens.Length

        If ScreenIndex <> -1 Then nextIndex = ScreenIndex
        Console.WriteLine($"Switching to Screen: {nextIndex}")
        Dim nextScreen As Screen = screens(nextIndex)

        Me.Bounds = nextScreen.Bounds
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        Me.Center_Reticle()

        Set_Window()

    End Sub

    Private Function Get_Screen_Index() As Integer
        Dim currentScreen As Screen = Screen.FromControl(Me)
        Dim screens() As Screen = Screen.AllScreens
        Dim currentIndex As Integer = Array.IndexOf(screens, currentScreen)
        Return currentIndex
    End Function


    Public Sub ResetReticle()
        Next_Reticle()
        Previous_Reticle()
        _Size = DefaultSize
        Center_Reticle()
        Me.Invalidate()
    End Sub

    Public Sub SaveReticleImage()
        Dim filePath As String = $"{Application.StartupPath}\current_reticle\current_reticle.png"
        ReticleImage.Save(filePath, ImageFormat.Png)
    End Sub

    Public Sub Load_Saved_Reticle()
        Dim filePath As String = $"{Application.StartupPath}\current_reticle\current_reticle.png"
        Try
            If File.Exists(filePath) Then
                Using TempImg As Image = Image.FromFile(filePath)
                    ' Create a copy of the image to release the file handle
                    ReticleImage = New Bitmap(TempImg)
                End Using
                ' Refresh the UI to reflect the loaded image
                Me.Invalidate()
            Else
                Console.WriteLine("File not found: " & filePath)
            End If
        Catch ex As Exception
            Console.WriteLine("Error loading image: " & ex.Message)
        End Try
    End Sub

End Class
