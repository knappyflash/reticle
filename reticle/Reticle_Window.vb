Imports System.IO
Imports System.Runtime.InteropServices
Imports reticle.Reticle_Window
Public Class Reticle_Window

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function

    Private Const GWL_EXSTYLE As Integer = -20
    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Private Const WS_EX_LAYERED As Integer = &H80000

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)

        ' Make the form layered and transparent to mouse events
        Dim exStyle As Integer = GetWindowLong(Me.Handle, GWL_EXSTYLE)
        SetWindowLong(Me.Handle, GWL_EXSTYLE, exStyle Or WS_EX_TRANSPARENT Or WS_EX_LAYERED)
    End Sub

    Public Property MoveByPxAmount As Long
        Get
            Return _MoveByPxAmount
        End Get
        Set(value As Long)
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

    Public Enum DecreaseOrIncrease
        Decrease = 0
        Increase = 1
    End Enum

    Private ReticleImages() As Image
    Private ReticleImage As Image
    Private ReticleTopLeftX As Long
    Private ReticleTopLeftY As Long
    Private ReticleCenterX As Long
    Private ReticleCenterY As Long
    Private ReticleWidthHeight As Long = 30
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
        Console.WriteLine($"Painted Window {Now}")
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

    Public Sub MoveX(ByVal DecreaseOrIncrease As DecreaseOrIncrease)
        Select Case DecreaseOrIncrease
            Case DecreaseOrIncrease.Decrease
                If (ReticleTopLeftX - _MoveByPxAmount) < (0 - (ReticleWidthHeight * 2)) Then Exit Sub
                ReticleTopLeftX = (ReticleTopLeftX - _MoveByPxAmount)
            Case DecreaseOrIncrease.Increase
                If (ReticleTopLeftX + _MoveByPxAmount) > (Me.Width + (ReticleWidthHeight * 2)) Then Exit Sub
                ReticleTopLeftX = (ReticleTopLeftX + _MoveByPxAmount)
        End Select
        Me.Invalidate()
    End Sub

    Public Sub MoveY(ByVal DecreaseOrIncrease As DecreaseOrIncrease)
        Select Case DecreaseOrIncrease
            Case DecreaseOrIncrease.Decrease
                If (ReticleTopLeftY - _MoveByPxAmount) < (0 - (ReticleWidthHeight * 2)) Then Exit Sub
                ReticleTopLeftY = (ReticleTopLeftY - _MoveByPxAmount)
            Case DecreaseOrIncrease.Increase
                If (ReticleTopLeftY + _MoveByPxAmount) > (Me.Height + (ReticleWidthHeight * 2)) Then Exit Sub
                ReticleTopLeftY = (ReticleTopLeftY + _MoveByPxAmount)
        End Select
        Me.Invalidate()
    End Sub

    Public Sub Grow()
        Debug.Print(ReticleWidthHeight)
        Debug.Print(ReticleWidthHeight * 1.25)
        If ReticleWidthHeight * 1.25 > 10000 Then Exit Sub
        ReticleCenterX = CInt(ReticleTopLeftX + (ReticleWidthHeight / 2))
        ReticleCenterY = CInt(ReticleTopLeftY + (ReticleWidthHeight / 2))
        ReticleWidthHeight = ReticleWidthHeight * 1.25
        ReticleTopLeftX = ReticleCenterX - (ReticleWidthHeight / 2)
        ReticleTopLeftY = ReticleCenterY - (ReticleWidthHeight / 2)
        Me.Invalidate()
    End Sub

    Public Sub Shrink()
        Debug.Print(ReticleWidthHeight * 0.75)
        If (ReticleWidthHeight * 0.75) / 2 <= 2 Then Exit Sub
        ReticleCenterX = CInt(ReticleTopLeftX + (ReticleWidthHeight / 2))
        ReticleCenterY = CInt(ReticleTopLeftY + (ReticleWidthHeight / 2))
        ReticleWidthHeight = ReticleWidthHeight * 0.75
        ReticleTopLeftX = ReticleCenterX - (ReticleWidthHeight / 2)
        ReticleTopLeftY = ReticleCenterY - (ReticleWidthHeight / 2)
        Me.Invalidate()
    End Sub

    Private Sub Load_Images()
        Dim FolderPath As String = $"{Application.StartupPath}\reticle_images"
        Dim ImageFiles As String() = Directory.GetFiles(FolderPath, "*.png").ToArray()
        ReticleImages = ImageFiles.Select(Function(file) Image.FromFile(file)).ToArray()
        ReticleImage = ReticleImages(0)
    End Sub

    Private Sub Set_Full_Screen()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        ' Optional: Ensure the form matches the screen resolution
        Me.Bounds = Screen.PrimaryScreen.Bounds
        ReticleTopLeftX = (Me.Width / 2) - (ReticleWidthHeight / 2)
        ReticleTopLeftY = (Me.Height / 2) - (ReticleWidthHeight / 2)
    End Sub

End Class