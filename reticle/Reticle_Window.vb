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

    Public Property MoveByPxAmount
        Get
            Return _MoveByPxAmount
        End Get
        Set(value)
            _MoveByPxAmount = value
        End Set
    End Property

    Public Enum DecreaseOrIncrease
        Decrease = 0
        Increase = 1
    End Enum

    Private ReticleImages() As Image
    Private ReticleImage As Image
    Private ReticleX As Long
    Private ReticleY As Long
    Private ReticleWidth As Long = 30
    Private ReticleHeight As Long = 30
    Private _MoveByPxAmount As Integer = 50
    Private ReticleId As Integer = 0

    Private Sub Reticle_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Images()
        Set_Full_Screen()
    End Sub

    Private Sub Reticle_Window_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Icon = My.Resources.icon
    End Sub

    Private Sub Reticle_Window_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Console.WriteLine($"Painted Window {Now}")
        e.Graphics.DrawImage(ReticleImage, ReticleX, ReticleY, ReticleWidth, ReticleHeight)
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
                ReticleX = (ReticleX - _MoveByPxAmount)
            Case DecreaseOrIncrease.Increase
                ReticleX = (ReticleX + _MoveByPxAmount)
        End Select
        Me.Invalidate()
    End Sub

    Public Sub MoveY(ByVal DecreaseOrIncrease As DecreaseOrIncrease)
        Select Case DecreaseOrIncrease
            Case DecreaseOrIncrease.Decrease
                ReticleY = (ReticleY - _MoveByPxAmount)
            Case DecreaseOrIncrease.Increase
                ReticleY = (ReticleY + _MoveByPxAmount)
        End Select
        Me.Invalidate()
    End Sub

    Public Sub Grow()
        ReticleWidth = ReticleWidth + 5
        ReticleHeight = ReticleHeight + 5
        Me.Invalidate()
    End Sub

    Public Sub Shrink()
        ReticleWidth = ReticleWidth - 5
        ReticleHeight = ReticleHeight - 5
        Me.Invalidate()
    End Sub

    Private Sub Load_Images()
        Dim FolderPath As String = $"{Application.StartupPath}\reticle_images"
        Dim ImageFiles As String() = Directory.GetFiles(FolderPath, "*.*").ToArray()

        ReticleImages = ImageFiles.Select(Function(file) Image.FromFile(file)).ToArray()



        ReticleImage = ReticleImages(0)
    End Sub

    Private Sub Set_Full_Screen()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

        ' Optional: Ensure the form matches the screen resolution
        Me.Bounds = Screen.PrimaryScreen.Bounds
        ReticleX = (Me.Width / 2) - (ReticleWidth / 2)
        ReticleY = (Me.Height / 2) - (ReticleHeight / 2)
    End Sub

End Class