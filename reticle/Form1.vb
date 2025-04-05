''' Add an upload png dialogbox option '''
''' Add SQLite to save users choices '''

Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Reticle_Window As New Reticle_Window
    Private MySQLite_db As New MySQLite_db

    Private ReticleScreenSelect As Integer = 0

    Private ImgArrowRedUp As Image
    Private ImgArrowRedDown As Image
    Private ImgArrowRedLeft As Image
    Private ImgArrowRedRight As Image

    Private ImgArrowGreenUp As Image
    Private ImgArrowGreenDown As Image
    Private ImgArrowGreenLeft As Image
    Private ImgArrowGreenRight As Image

    Private ImgArrowBlueUp As Image
    Private ImgArrowBlueDown As Image
    Private ImgArrowBlueLeft As Image
    Private ImgArrowBlueRight As Image

    Private ImgFloppyDisc As Image
    Private ImgReset As Image
    Private ImgOpenSave As Image

    Private LoopAction As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reticle_Window.Show()

        ImgArrowRedUp = My.Resources.ArrowRed_small
        ImgArrowRedDown = My.Resources.ArrowRed_small
        ImgArrowRedLeft = My.Resources.ArrowRed_small
        ImgArrowRedRight = My.Resources.ArrowRed_small

        ImgArrowGreenUp = My.Resources.ArrowGreen_small
        ImgArrowGreenDown = My.Resources.ArrowGreen_small
        ImgArrowGreenLeft = My.Resources.ArrowGreen_small
        ImgArrowGreenRight = My.Resources.ArrowGreen_small

        ImgArrowBlueUp = My.Resources.ArrowBlue_small
        ImgArrowBlueDown = My.Resources.ArrowBlue_small
        ImgArrowBlueLeft = My.Resources.ArrowBlue_small
        ImgArrowBlueRight = My.Resources.ArrowBlue_small

        ImgFloppyDisc = My.Resources.floppy_disc
        ImgReset = My.Resources.reset
        ImgOpenSave = My.Resources.load_saved_reticle

        ImgArrowRedDown.RotateFlip(RotateFlipType.Rotate180FlipNone)
        ImgArrowGreenDown.RotateFlip(RotateFlipType.Rotate180FlipNone)
        ImgArrowBlueDown.RotateFlip(RotateFlipType.Rotate180FlipNone)

        ImgArrowRedLeft.RotateFlip(RotateFlipType.Rotate270FlipNone)
        ImgArrowGreenLeft.RotateFlip(RotateFlipType.Rotate270FlipNone)
        ImgArrowBlueLeft.RotateFlip(RotateFlipType.Rotate270FlipNone)

        ImgArrowRedRight.RotateFlip(RotateFlipType.Rotate90FlipNone)
        ImgArrowGreenRight.RotateFlip(RotateFlipType.Rotate90FlipNone)
        ImgArrowBlueRight.RotateFlip(RotateFlipType.Rotate90FlipNone)

        PicBoxMoveUp.Image = ImgArrowBlueUp
        PicBoxMoveDown.Image = ImgArrowBlueDown
        PicBoxMoveLeft.Image = ImgArrowBlueLeft
        PicBoxMoveRight.Image = ImgArrowBlueRight

        BtnLowRed.Image = ImgArrowRedLeft
        BtnLowGreen.Image = ImgArrowGreenLeft
        BtnLowBlue.Image = ImgArrowBlueLeft

        BtnHighRed.Image = ImgArrowRedRight
        BtnHighGreen.Image = ImgArrowGreenRight
        BtnHighBlue.Image = ImgArrowBlueRight

        PicBoxGrow.Image = ImgArrowGreenUp
        PicBoxShink.Image = ImgArrowRedDown

        BtnPreviousReticle.Image = ImgArrowBlueLeft
        BtnNextReticle.Image = ImgArrowBlueRight

        BtnSave.Image = ImgFloppyDisc
        BtnReset.Image = ImgReset
        BtnOpenSaveReticle.Image = ImgOpenSave

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
        PicBoxMoveUp.Image = Change_Img_Color_Matrix(PicBoxMoveUp.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Move Up")
    End Sub

    Private Sub PicBoxMoveUp_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveUp.MouseLeave
        PicBoxMoveUp.Image = ImgArrowBlueUp
    End Sub

    Private Sub PicBoxMoveUp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveUp.MouseDown
        PicBoxMoveUp.Image = Change_Img_Color_Matrix(PicBoxMoveUp.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Move Up"
        Timer1.Start()
    End Sub

    Private Sub PicBoxMoveUp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveUp.MouseUp
        PicBoxMoveUp.Image = ImgArrowBlueUp
        PicBoxMoveUp.Image = Change_Img_Color_Matrix(PicBoxMoveUp.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub

    ''' Move Down Arrow '''
    Private Sub PicBoxMoveDown_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveDown.MouseEnter
        PicBoxMoveDown.Image = Change_Img_Color_Matrix(PicBoxMoveDown.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Move Down")
    End Sub

    Private Sub PicBoxMoveDown_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveDown.MouseLeave
        PicBoxMoveDown.Image = ImgArrowBlueDown
    End Sub

    Private Sub PicBoxMoveDown_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveDown.MouseDown
        PicBoxMoveDown.Image = Change_Img_Color_Matrix(PicBoxMoveDown.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Move Down"
        Timer1.Start()
    End Sub

    Private Sub PicBoxMoveDown_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveDown.MouseUp
        PicBoxMoveDown.Image = ImgArrowBlueDown
        PicBoxMoveDown.Image = Change_Img_Color_Matrix(PicBoxMoveDown.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub



    ''' Move Left Arrow '''
    Private Sub PicBoxMoveLeft_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveLeft.MouseEnter
        PicBoxMoveLeft.Image = Change_Img_Color_Matrix(PicBoxMoveLeft.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Move Left")
    End Sub

    Private Sub PicBoxMoveLeft_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveLeft.MouseLeave
        PicBoxMoveLeft.Image = ImgArrowBlueLeft
    End Sub

    Private Sub PicBoxMoveLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveLeft.MouseDown
        PicBoxMoveLeft.Image = Change_Img_Color_Matrix(PicBoxMoveLeft.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Move Left"
        Timer1.Start()
    End Sub

    Private Sub PicBoxMoveLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveLeft.MouseUp
        PicBoxMoveLeft.Image = ImgArrowBlueLeft
        PicBoxMoveLeft.Image = Change_Img_Color_Matrix(PicBoxMoveLeft.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub



    ''' Move Right Arrow '''
    Private Sub PicBoxMoveRight_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxMoveRight.MouseEnter
        PicBoxMoveRight.Image = Change_Img_Color_Matrix(PicBoxMoveRight.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Move Right")
    End Sub

    Private Sub PicBoxMoveRight_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxMoveRight.MouseLeave
        PicBoxMoveRight.Image = ImgArrowBlueRight
    End Sub

    Private Sub PicBoxMoveRight_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxMoveRight.MouseDown
        PicBoxMoveRight.Image = Change_Img_Color_Matrix(PicBoxMoveRight.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Move Right"
        Timer1.Start()
    End Sub

    Private Sub PicBoxMoveRight_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxMoveRight.MouseUp
        PicBoxMoveRight.Image = ImgArrowBlueRight
        PicBoxMoveRight.Image = Change_Img_Color_Matrix(PicBoxMoveRight.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Grow '''
    Private Sub PicBoxGrow_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxGrow.MouseEnter
        PicBoxGrow.Image = Change_Img_Color_Matrix(PicBoxGrow.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Grow")
    End Sub

    Private Sub PicBoxGrow_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxGrow.MouseLeave
        PicBoxGrow.Image = ImgArrowGreenUp
    End Sub

    Private Sub PicBoxGrow_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxGrow.MouseDown
        PicBoxGrow.Image = Change_Img_Color_Matrix(PicBoxGrow.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Grow"
        Timer1.Start()
    End Sub

    Private Sub PicBoxGrow_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxGrow.MouseUp
        PicBoxGrow.Image = ImgArrowGreenUp
        PicBoxGrow.Image = Change_Img_Color_Matrix(PicBoxGrow.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Shrink '''
    Private Sub PicBoxShink_MouseEnter(sender As Object, e As EventArgs) Handles PicBoxShink.MouseEnter
        PicBoxShink.Image = Change_Img_Color_Matrix(PicBoxShink.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Shrink")
    End Sub

    Private Sub PicBoxShink_MouseLeave(sender As Object, e As EventArgs) Handles PicBoxShink.MouseLeave
        PicBoxShink.Image = ImgArrowRedDown
    End Sub

    Private Sub PicBoxShink_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBoxShink.MouseDown
        PicBoxShink.Image = Change_Img_Color_Matrix(PicBoxShink.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Shrink"
        Timer1.Start()
    End Sub

    Private Sub PicBoxShink_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBoxShink.MouseUp
        PicBoxShink.Image = ImgArrowRedDown
        PicBoxShink.Image = Change_Img_Color_Matrix(PicBoxShink.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub



    ''' Previous Reticle '''
    Private Sub BtnPreviousReticle_MouseEnter(sender As Object, e As EventArgs) Handles BtnPreviousReticle.MouseEnter
        BtnPreviousReticle.Image = Change_Img_Color_Matrix(BtnPreviousReticle.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Previous Reticle")
    End Sub

    Private Sub BtnPreviousReticle_MouseLeave(sender As Object, e As EventArgs) Handles BtnPreviousReticle.MouseLeave
        BtnPreviousReticle.Image = ImgArrowBlueLeft
    End Sub

    Private Sub BtnPreviousReticle_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPreviousReticle.MouseDown
        BtnPreviousReticle.Image = Change_Img_Color_Matrix(BtnPreviousReticle.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Previous Reticle"
        Timer1.Start()
    End Sub

    Private Sub BtnPreviousReticle_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPreviousReticle.MouseUp
        BtnPreviousReticle.Image = ImgArrowBlueLeft
        BtnPreviousReticle.Image = Change_Img_Color_Matrix(BtnPreviousReticle.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Next Reticle '''
    Private Sub BtnNextReticle_MouseEnter(sender As Object, e As EventArgs) Handles BtnNextReticle.MouseEnter
        BtnNextReticle.Image = Change_Img_Color_Matrix(BtnNextReticle.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Next Reticle")
    End Sub

    Private Sub BtnNextReticle_MouseLeave(sender As Object, e As EventArgs) Handles BtnNextReticle.MouseLeave
        BtnNextReticle.Image = ImgArrowBlueRight
    End Sub

    Private Sub BtnNextReticle_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnNextReticle.MouseDown
        BtnNextReticle.Image = Change_Img_Color_Matrix(BtnNextReticle.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Next Reticle"
        Timer1.Start()
    End Sub

    Private Sub BtnNextReticle_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnNextReticle.MouseUp
        BtnNextReticle.Image = ImgArrowBlueRight
        BtnNextReticle.Image = Change_Img_Color_Matrix(BtnNextReticle.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub



    ''' Lower Red '''
    Private Sub BtnLowRed_MouseEnter(sender As Object, e As EventArgs) Handles BtnLowRed.MouseEnter
        BtnLowRed.Image = Change_Img_Color_Matrix(BtnLowRed.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Decrease Red")
    End Sub

    Private Sub BtnLowRed_MouseLeave(sender As Object, e As EventArgs) Handles BtnLowRed.MouseLeave
        BtnLowRed.Image = ImgArrowRedLeft
    End Sub

    Private Sub BtnLowRed_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnLowRed.MouseDown
        BtnLowRed.Image = Change_Img_Color_Matrix(BtnLowRed.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Decrease Red"
        Timer1.Start()
    End Sub

    Private Sub BtnLowRed_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnLowRed.MouseUp
        BtnLowRed.Image = ImgArrowRedLeft
        BtnLowRed.Image = Change_Img_Color_Matrix(BtnLowRed.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Lower Green '''
    Private Sub BtnLowGreen_MouseEnter(sender As Object, e As EventArgs) Handles BtnLowGreen.MouseEnter
        BtnLowGreen.Image = Change_Img_Color_Matrix(BtnLowGreen.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Decrease Green")
    End Sub

    Private Sub BtnLowGreen_MouseLeave(sender As Object, e As EventArgs) Handles BtnLowGreen.MouseLeave
        BtnLowGreen.Image = ImgArrowGreenLeft
    End Sub

    Private Sub BtnLowGreen_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnLowGreen.MouseDown
        BtnLowGreen.Image = Change_Img_Color_Matrix(BtnLowGreen.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Decrease Green"
        Timer1.Start()
    End Sub

    Private Sub BtnLowGreen_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnLowGreen.MouseUp
        BtnLowGreen.Image = ImgArrowGreenLeft
        BtnLowGreen.Image = Change_Img_Color_Matrix(BtnLowGreen.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Lower Blue '''
    Private Sub BtnLowBlue_MouseEnter(sender As Object, e As EventArgs) Handles BtnLowBlue.MouseEnter
        BtnLowBlue.Image = Change_Img_Color_Matrix(BtnLowBlue.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Decrease Blue")
    End Sub

    Private Sub BtnLowBlue_MouseLeave(sender As Object, e As EventArgs) Handles BtnLowBlue.MouseLeave
        BtnLowBlue.Image = ImgArrowBlueLeft
    End Sub

    Private Sub BtnLowBlue_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnLowBlue.MouseDown
        BtnLowBlue.Image = Change_Img_Color_Matrix(BtnLowBlue.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Decrease Blue"
        Timer1.Start()
    End Sub

    Private Sub BtnLowBlue_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnLowBlue.MouseUp
        BtnLowBlue.Image = ImgArrowBlueLeft
        BtnLowBlue.Image = Change_Img_Color_Matrix(BtnLowBlue.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Increase Red '''
    Private Sub BtnHighRed_MouseEnter(sender As Object, e As EventArgs) Handles BtnHighRed.MouseEnter
        BtnHighRed.Image = Change_Img_Color_Matrix(BtnHighRed.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Increase Red")
    End Sub

    Private Sub BtnHighRed_MouseLeave(sender As Object, e As EventArgs) Handles BtnHighRed.MouseLeave
        BtnHighRed.Image = ImgArrowRedRight
    End Sub

    Private Sub BtnHighRed_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnHighRed.MouseDown
        BtnHighRed.Image = Change_Img_Color_Matrix(BtnHighRed.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Increase Red"
        Timer1.Start()
    End Sub

    Private Sub BtnHighRed_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnHighRed.MouseUp
        BtnHighRed.Image = ImgArrowRedRight
        BtnHighRed.Image = Change_Img_Color_Matrix(BtnHighRed.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub


    ''' Increase Green '''
    Private Sub BtnHighGreen_MouseEnter(sender As Object, e As EventArgs) Handles BtnHighGreen.MouseEnter
        BtnHighGreen.Image = Change_Img_Color_Matrix(BtnHighGreen.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Increase Green")
    End Sub

    Private Sub BtnHighGreen_MouseLeave(sender As Object, e As EventArgs) Handles BtnHighGreen.MouseLeave
        BtnHighGreen.Image = ImgArrowGreenRight
    End Sub

    Private Sub BtnHighGreen_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnHighGreen.MouseDown
        BtnHighGreen.Image = Change_Img_Color_Matrix(BtnHighGreen.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Increase Green"
        Timer1.Start()
    End Sub

    Private Sub BtnHighGreen_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnHighGreen.MouseUp
        BtnHighGreen.Image = ImgArrowGreenRight
        BtnHighGreen.Image = Change_Img_Color_Matrix(BtnHighGreen.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub




    ''' Increase Blue '''
    Private Sub BtnHighBlue_MouseEnter(sender As Object, e As EventArgs) Handles BtnHighBlue.MouseEnter
        BtnHighBlue.Image = Change_Img_Color_Matrix(BtnHighBlue.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Increase Blue")
    End Sub

    Private Sub BtnHighBlue_MouseLeave(sender As Object, e As EventArgs) Handles BtnHighBlue.MouseLeave
        BtnHighBlue.Image = ImgArrowBlueRight
    End Sub

    Private Sub BtnHighBlue_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnHighBlue.MouseDown
        BtnHighBlue.Image = Change_Img_Color_Matrix(BtnHighBlue.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        LoopAction = "Increase Blue"
        Timer1.Start()
    End Sub

    Private Sub BtnHighBlue_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnHighBlue.MouseUp
        BtnHighBlue.Image = ImgArrowBlueRight
        BtnHighBlue.Image = Change_Img_Color_Matrix(BtnHighBlue.Image, RedShift:=1.9, GreenShift:=1.5)
        Timer1.Stop()
    End Sub




    ''' Save '''
    Private Sub BtnSave_MouseEnter(sender As Object, e As EventArgs) Handles BtnSave.MouseEnter
        BtnSave.Image = Change_Img_Color_Matrix(BtnSave.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Save")
    End Sub

    Private Sub BtnSave_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.Image = ImgFloppyDisc
    End Sub

    Private Sub BtnSave_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSave.MouseDown
        BtnSave.Image = Change_Img_Color_Matrix(BtnSave.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        Reticle_Window.SaveReticleImage()
    End Sub

    Private Sub BtnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSave.MouseUp
        BtnSave.Image = ImgFloppyDisc
        BtnSave.Image = Change_Img_Color_Matrix(BtnSave.Image, RedShift:=1.9, GreenShift:=1.5)
    End Sub




    ''' Reset '''
    Private Sub BtnReset_MouseEnter(sender As Object, e As EventArgs) Handles BtnReset.MouseEnter
        BtnReset.Image = Change_Img_Color_Matrix(BtnReset.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Reset")
    End Sub

    Private Sub BtnReset_MouseLeave(sender As Object, e As EventArgs) Handles BtnReset.MouseLeave
        BtnReset.Image = ImgReset
    End Sub

    Private Sub BtnReset_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnReset.MouseDown
        BtnReset.Image = Change_Img_Color_Matrix(BtnReset.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        Reticle_Window.ResetReticle()
    End Sub

    Private Sub BtnReset_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnReset.MouseUp
        BtnReset.Image = ImgReset
        BtnReset.Image = Change_Img_Color_Matrix(BtnReset.Image, RedShift:=1.9, GreenShift:=1.5)
    End Sub



    ''' Open Saved Reticle '''
    Private Sub BtnOpenSaveReticle_MouseEnter(sender As Object, e As EventArgs) Handles BtnOpenSaveReticle.MouseEnter
        BtnOpenSaveReticle.Image = Change_Img_Color_Matrix(BtnOpenSaveReticle.Image, RedShift:=1.9, GreenShift:=1.5)
        ToolTip1.SetToolTip(sender, "Load Save")
    End Sub

    Private Sub BtnOpenSaveReticle_MouseLeave(sender As Object, e As EventArgs) Handles BtnOpenSaveReticle.MouseLeave
        BtnOpenSaveReticle.Image = ImgOpenSave
    End Sub

    Private Sub BtnOpenSaveReticle_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnOpenSaveReticle.MouseDown
        BtnOpenSaveReticle.Image = Change_Img_Color_Matrix(BtnOpenSaveReticle.Image, RedShift:=1.9, GreenShift:=1.9, BlueShift:=1.9)
        Reticle_Window.Load_Saved_Reticle()
    End Sub

    Private Sub BtnOpenSaveReticle_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnOpenSaveReticle.MouseUp
        BtnOpenSaveReticle.Image = ImgOpenSave
        BtnOpenSaveReticle.Image = Change_Img_Color_Matrix(BtnOpenSaveReticle.Image, RedShift:=1.9, GreenShift:=1.5)
    End Sub



    ''' Move Speed '''
    Private Sub LblMoveByPxAmount_MouseHover(sender As Object, e As EventArgs) Handles LblMoveByPxAmount.MouseHover
        ToolTip1.SetToolTip(sender, "Move Speed")
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

    Public Function Change_Img_Color_Matrix(
                                  ByVal MyImg As Image,
                                  Optional ByVal RedShift As Single = 1,
                                  Optional ByVal GreenShift As Single = 1,
                                  Optional ByVal BlueShift As Single = 1) As Image

        ' Exit if the input image is null
        If MyImg Is Nothing Then
            Return MyImg
            Exit Function
        End If

        ' Create a new bitmap to hold the modified image
        Dim bmp As New Bitmap(MyImg.Width, MyImg.Height)

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
            g.DrawImage(MyImg,
                    New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, MyImg.Width, MyImg.Height,
                    GraphicsUnit.Pixel,
                    ia)
        End Using

        ' Dispose the old image and replace it with the modified bitmap
        MyImg = bmp

        Return MyImg
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim DecreaseBy As Single = 0.9
        Dim Increaseby As Single = 1.1

        Select Case LoopAction
            Case ""
            Case "Move Up"
                Reticle_Window.Move(False, False)
            Case "Move Down"
                Reticle_Window.Move(False, True)
            Case "Move Left"
                Reticle_Window.Move(True, False)
            Case "Move Right"
                Reticle_Window.Move(True, True)
            Case "Grow"
                Reticle_Window.Grow()
            Case "Shrink"
                Reticle_Window.Shrink()
            Case "Previous Reticle"
                Reticle_Window.Previous_Reticle()
            Case "Next Reticle"
                Reticle_Window.Next_Reticle()
            Case "Decrease Red"
                Reticle_Window.Change_Rticle_Color_Matrix(RedShift:=DecreaseBy)
            Case "Decrease Green"
                Reticle_Window.Change_Rticle_Color_Matrix(GreenShift:=DecreaseBy)
            Case "Decrease Blue"
                Reticle_Window.Change_Rticle_Color_Matrix(BlueShift:=DecreaseBy)
            Case "Increase Red"
                Reticle_Window.Change_Rticle_Color_Matrix(RedShift:=Increaseby)
            Case "Increase Green"
                Reticle_Window.Change_Rticle_Color_Matrix(GreenShift:=Increaseby)
            Case "Increase Blue"
                Reticle_Window.Change_Rticle_Color_Matrix(BlueShift:=Increaseby)
        End Select
    End Sub

End Class
