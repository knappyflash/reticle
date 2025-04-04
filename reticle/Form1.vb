''' Add an upload png dialogbox option '''
''' Add SQLite to save users choices '''

Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Reticle_Window As New Reticle_Window

    Private ReticleScreenSelect As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reticle_Window.Show()

        ''' PicBoxMoveUp Is Up '''
        PicBoxMoveDown.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        PicBoxMoveLeft.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PicBoxMoveRight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PicBoxShink.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Icon = My.Resources.icon
    End Sub

    Private Sub LblMoveByPxAmount_Click(sender As Object, e As EventArgs) Handles LblMoveByPxAmount.Click
        Select Case LblMoveByPxAmount.Text
            Case "50 px"
                LblMoveByPxAmount.Text = "20 px"
                Reticle_Window.MoveByPxAmount = 20
            Case "20 px"
                LblMoveByPxAmount.Text = "5 px"
                Reticle_Window.MoveByPxAmount = 5
            Case "5 px"
                LblMoveByPxAmount.Text = "1 px"
                Reticle_Window.MoveByPxAmount = 1
            Case "1 px"
                LblMoveByPxAmount.Text = "50 px"
                Reticle_Window.MoveByPxAmount = 50
        End Select
    End Sub

    ''' Move Up Arrow '''
    Private Sub PicBoxMoveUp_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveUp.MouseEnter
        PicBoxMoveUp.Image = My.Resources.ArrowBlue_small_hover
    End Sub

    Private Sub PicBoxMoveUp_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveUp.MouseLeave
        PicBoxMoveUp.Image = My.Resources.ArrowBlue_small
    End Sub

    Private Sub PicBoxMoveUp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveUp.MouseDown
        PicBoxMoveUp.Image = My.Resources.ArrowBlue_small_click
    End Sub

    Private Sub PicBoxMoveUp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveUp.MouseUp
        PicBoxMoveUp.Image = My.Resources.ArrowBlue_small_hover
        Reticle_Window.Move(False, False)
    End Sub

    ''' Move Down Arrow '''
    Private Sub PicBoxMoveDown_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveDown.MouseEnter
        PicBoxMoveDown.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveDown.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxMoveDown_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveDown.MouseLeave
        PicBoxMoveDown.Image = My.Resources.ArrowBlue_small
        PicBoxMoveDown.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxMoveDown_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveDown.MouseDown
        PicBoxMoveDown.Image = My.Resources.ArrowBlue_small_click
        PicBoxMoveDown.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxMoveDown_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveDown.MouseUp
        PicBoxMoveDown.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveDown.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        Reticle_Window.Move(False, True)
    End Sub

    ''' Move Left Arrow '''
    Private Sub PicBoxMoveLeft_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveLeft.MouseEnter
        PicBoxMoveLeft.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveLeft.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub PicBoxMoveLeft_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveLeft.MouseLeave
        PicBoxMoveLeft.Image = My.Resources.ArrowBlue_small
        PicBoxMoveLeft.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub PicBoxMoveLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveLeft.MouseDown
        PicBoxMoveLeft.Image = My.Resources.ArrowBlue_small_click
        PicBoxMoveLeft.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub PicBoxMoveLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveLeft.MouseUp
        PicBoxMoveLeft.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveLeft.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        Reticle_Window.Move(True, False)
    End Sub


    ''' Move Right Arrow '''
    Private Sub PicBoxMoveRight_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveRight.MouseEnter
        PicBoxMoveRight.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveRight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub PicBoxMoveRight_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveRight.MouseLeave
        PicBoxMoveRight.Image = My.Resources.ArrowBlue_small
        PicBoxMoveRight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub PicBoxMoveRight_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveRight.MouseDown
        PicBoxMoveRight.Image = My.Resources.ArrowBlue_small_click
        PicBoxMoveRight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub PicBoxMoveRight_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveRight.MouseUp
        PicBoxMoveRight.Image = My.Resources.ArrowBlue_small_hover
        PicBoxMoveRight.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Reticle_Window.Move(True, True)
    End Sub



    ''' Grow '''
    Private Sub PicBoxGrow_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxGrow.MouseEnter
        PicBoxGrow.Image = My.Resources.ArrowGreen_small_Hover
    End Sub

    Private Sub PicBoxGrow_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxGrow.MouseLeave
        PicBoxGrow.Image = My.Resources.ArrowGreen_small
    End Sub

    Private Sub PicBoxGrow_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxGrow.MouseDown
        PicBoxGrow.Image = My.Resources.ArrowGreen_small_Click
    End Sub

    Private Sub PicBoxGrow_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxGrow.MouseUp
        PicBoxGrow.Image = My.Resources.ArrowGreen_small_Hover
        Reticle_Window.Grow()
    End Sub



    ''' Shrink '''
    Private Sub PicBoxShink_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxShink.MouseEnter
        PicBoxShink.Image = My.Resources.ArrowRed_small_Hover
        PicBoxShink.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxShink_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxShink.MouseLeave
        PicBoxShink.Image = My.Resources.ArrowRed_small
        PicBoxShink.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxShink_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxShink.MouseDown
        PicBoxShink.Image = My.Resources.ArrowRed_small_Click
        PicBoxShink.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub PicBoxShink_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxShink.MouseUp
        Reticle_Window.Shrink()
        PicBoxShink.Image = My.Resources.ArrowRed_small_Hover
        PicBoxShink.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub BtnNextReticle_Click(sender As Object, e As EventArgs) Handles BtnNextReticle.Click
        Reticle_Window.Next_Reticle()
    End Sub

    Private Sub BtnPreviousReticle_Click(sender As Object, e As EventArgs) Handles BtnPreviousReticle.Click
        Reticle_Window.Previous_Reticle()
    End Sub

    Private Sub BtnShowCenterOfReticle_Click(sender As Object, e As EventArgs) Handles BtnShowCenterOfReticle.Click
        If BtnShowCenterOfReticle.Text = "Show Center of Reticle" Then
            BtnShowCenterOfReticle.Text = "Hide Center of Reticle"
            Reticle_Window.ShowCenterOfReticle = True
        Else
            BtnShowCenterOfReticle.Text = "Show Center of Reticle"
            Reticle_Window.ShowCenterOfReticle = False
        End If
    End Sub

    Private Sub BtnHideShow_Click(sender As Object, e As EventArgs) Handles BtnHideShow.Click
        If BtnHideShow.Text = "Show Reticle" Then
            BtnHideShow.Text = "Hide Reticle"
            Reticle_Window.ShowReticle = True
            For Each control As Control In Me.Controls
                control.Enabled = True
            Next
        Else
            BtnHideShow.Text = "Show Reticle"
            Reticle_Window.ShowReticle = False
            For Each control As Control In Me.Controls
                If control.Name <> "BtnHideShow" Then
                    control.Enabled = False
                End If

            Next
        End If
    End Sub

    Private Sub BtnCenterReticle_Click(sender As Object, e As EventArgs) Handles BtnCenterReticle.Click
        Reticle_Window.Center_Reticle()
    End Sub

    Private Sub BtnSwitchToNextScreen_Click(sender As Object, e As EventArgs) Handles BtnSwitchToNextScreen.Click
        Reticle_Window.SwitchToNextScreen()
    End Sub

    Private Sub BtnOpenReticleFolder_Click(sender As Object, e As EventArgs) Handles BtnOpenReticleFolder.Click
        Dim FolderPath As String = $"{Application.StartupPath}\reticle_images"

        ' Check if the folder exists before trying to open it
        If IO.Directory.Exists(FolderPath) Then
            ' Open the folder
            Process.Start(FolderPath)
        Else
            Console.WriteLine("The folder does not exist.")
        End If
    End Sub

    Private Sub BtnQuickTest_Click(sender As Object, e As EventArgs) Handles BtnQuickTest.Click
        Reticle_Window.Change_Rticle_Hue_Color(TboxQuickTestR.Text, TboxQuickTestG.Text, TboxQuickTestB.Text, TboxQuickTestHue.Text)
    End Sub

End Class
