Imports System.IO
Imports System.Runtime.InteropServices
Public Class Reticle_Window

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)

        ' Make the form layered and transparent to mouse events
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

    Public Property ReticleWidthHeight As Long
        Get
            Return _ReticleWidthHeight
        End Get
        Set(value As Long)
            If value <= 2 Then
                value = 3
            ElseIf value >= 10000 Then
                value = 9999
            End If

            ''' Keep the reticle centered '''
            ReticleCenterX = CInt(ReticleTopLeftX + (_ReticleWidthHeight / 2))
            ReticleCenterY = CInt(ReticleTopLeftY + (_ReticleWidthHeight / 2))

            _ReticleWidthHeight = value

            ReticleTopLeftX = ReticleCenterX - (ReticleWidthHeight / 2)
            ReticleTopLeftY = ReticleCenterY - (ReticleWidthHeight / 2)

            Me.Invalidate()
        End Set
    End Property

    Private Const GWL_EXSTYLE As Integer = -20
    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Private Const WS_EX_LAYERED As Integer = &H80000
    Private Const DefaultReticleWidthHeight As Long = 30

    Private _ReticleWidthHeight As Long = DefaultReticleWidthHeight
    Private ReticleImages() As Image
    Private ReticleImage As Image
    Private ReticleTopLeftX As Long
    Private ReticleTopLeftY As Long
    Private ReticleCenterX As Long
    Private ReticleCenterY As Long
    Private _MoveByPxAmount As Integer = 50
    Private ReticleId As Integer = 0
    Private _ShowCenterOfReticle As Boolean = False
    Private _ShowReticle As Boolean = True

    Private Sub Reticle_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Images()
        Set_Full_Screen()
    End Sub

    Private Sub Reticle_Window_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Icon = My.Resources.icon
        Me.DoubleBuffered = True
    End Sub

    Private Sub Reticle_Window_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        If Not ShowReticle Then Exit Sub
        e.Graphics.DrawImage(ReticleImage, ReticleTopLeftX, ReticleTopLeftY, ReticleWidthHeight, ReticleWidthHeight)

        If ShowCenterOfReticle = True Then
            e.Graphics.FillRectangle(
                New SolidBrush(Color.Blue),
                CInt(ReticleTopLeftX + (ReticleWidthHeight / 2) - 2),
                CInt(ReticleTopLeftY + (ReticleWidthHeight / 2) - 2),
                5,
                5
            )
        End If

    End Sub

    Public Sub Next_Reticle()
        ReticleId = ReticleId + 1
        If ReticleId >= ReticleImages.Count Then ReticleId = 0
        ReticleImage = ReticleImages(ReticleId)
        Me.Invalidate()
    End Sub

    Public Sub Previous_Reticle()
        ReticleId = ReticleId - 1
        If ReticleId < 0 Then ReticleId = ReticleImages.Count - 1
        ReticleImage = ReticleImages(ReticleId)
        Me.Invalidate()
    End Sub

    Public Sub Move(ByVal AlongX As Boolean, ByVal ShouldIncrease As Boolean)

        If (ReticleTopLeftX + _MoveByPxAmount) > (Me.Width + (ReticleWidthHeight * 2)) Then Center_Reticle()
        If (ReticleTopLeftY + _MoveByPxAmount) > (Me.Height + (ReticleWidthHeight * 2)) Then Center_Reticle()
        If (ReticleTopLeftY - _MoveByPxAmount) < (0 - (ReticleWidthHeight * 2)) Then Center_Reticle()
        If (ReticleTopLeftX - _MoveByPxAmount) < (0 - (ReticleWidthHeight * 2)) Then Center_Reticle()

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
        ReticleWidthHeight = ReticleWidthHeight * 1.25
    End Sub

    Public Sub Shrink()
        ReticleWidthHeight = ReticleWidthHeight * 0.75
    End Sub

    Private Sub Load_Images()
        Dim FolderPath As String = $"{Application.StartupPath}\reticle_images"
        Try
            Dim ImageFiles As String() = Directory.GetFiles(FolderPath, "*.png").ToArray()
            ReticleImages = ImageFiles.Select(Function(file) Image.FromFile(file)).ToArray()
            ReticleImage = ReticleImages(0)
        Catch ex As Exception
            MsgBox($"No .png files were found in reticle_images folder: {FolderPath}!!! Closing app!", MsgBoxStyle.Critical, "Error MsgBox")
            End
        End Try
    End Sub

    Private Sub Set_Full_Screen()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        Me.Bounds = Screen.PrimaryScreen.Bounds
        Center_Reticle()

    End Sub

    Public Sub Center_Reticle()
        ReticleTopLeftX = (Me.Width / 2) - (ReticleWidthHeight / 2)
        ReticleTopLeftY = (Me.Height / 2) - (ReticleWidthHeight / 2)
        Me.Invalidate()
    End Sub

End Class