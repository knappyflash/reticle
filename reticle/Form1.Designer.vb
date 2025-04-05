<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblMoveByPxAmount = New System.Windows.Forms.Label()
        Me.PicBoxMoveUp = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveDown = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveRight = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveLeft = New System.Windows.Forms.PictureBox()
        Me.PicBoxShink = New System.Windows.Forms.PictureBox()
        Me.PicBoxGrow = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnShowCenterOfReticle = New System.Windows.Forms.Button()
        Me.BtnHideShow = New System.Windows.Forms.Button()
        Me.BtnCenterReticle = New System.Windows.Forms.Button()
        Me.BtnSwitchToNextScreen = New System.Windows.Forms.Button()
        Me.BtnOpenReticleFolder = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblRed = New System.Windows.Forms.Label()
        Me.LblGreen = New System.Windows.Forms.Label()
        Me.LblBlue = New System.Windows.Forms.Label()
        Me.BtnLowRed = New System.Windows.Forms.PictureBox()
        Me.BtnHighRed = New System.Windows.Forms.PictureBox()
        Me.BtnLowGreen = New System.Windows.Forms.PictureBox()
        Me.BtnHighGreen = New System.Windows.Forms.PictureBox()
        Me.BtnLowBlue = New System.Windows.Forms.PictureBox()
        Me.BtnHighBlue = New System.Windows.Forms.PictureBox()
        Me.BtnPreviousReticle = New System.Windows.Forms.PictureBox()
        Me.BtnNextReticle = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSave = New System.Windows.Forms.PictureBox()
        Me.BtnReset = New System.Windows.Forms.PictureBox()
        Me.BtnOpenSaveReticle = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxMoveUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxShink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxGrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLowRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHighRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLowGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHighGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLowBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHighBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPreviousReticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNextReticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnOpenSaveReticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMoveByPxAmount
        '
        Me.LblMoveByPxAmount.AutoSize = True
        Me.LblMoveByPxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoveByPxAmount.Location = New System.Drawing.Point(83, 87)
        Me.LblMoveByPxAmount.Name = "LblMoveByPxAmount"
        Me.LblMoveByPxAmount.Size = New System.Drawing.Size(52, 20)
        Me.LblMoveByPxAmount.TabIndex = 5
        Me.LblMoveByPxAmount.Text = "50 px"
        '
        'PicBoxMoveUp
        '
        Me.PicBoxMoveUp.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveUp.Location = New System.Drawing.Point(79, 12)
        Me.PicBoxMoveUp.Name = "PicBoxMoveUp"
        Me.PicBoxMoveUp.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveUp.TabIndex = 6
        Me.PicBoxMoveUp.TabStop = False
        '
        'PicBoxMoveDown
        '
        Me.PicBoxMoveDown.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveDown.Location = New System.Drawing.Point(79, 129)
        Me.PicBoxMoveDown.Name = "PicBoxMoveDown"
        Me.PicBoxMoveDown.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveDown.TabIndex = 7
        Me.PicBoxMoveDown.TabStop = False
        '
        'PicBoxMoveRight
        '
        Me.PicBoxMoveRight.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveRight.Location = New System.Drawing.Point(145, 70)
        Me.PicBoxMoveRight.Name = "PicBoxMoveRight"
        Me.PicBoxMoveRight.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveRight.TabIndex = 8
        Me.PicBoxMoveRight.TabStop = False
        '
        'PicBoxMoveLeft
        '
        Me.PicBoxMoveLeft.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveLeft.Location = New System.Drawing.Point(8, 70)
        Me.PicBoxMoveLeft.Name = "PicBoxMoveLeft"
        Me.PicBoxMoveLeft.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveLeft.TabIndex = 9
        Me.PicBoxMoveLeft.TabStop = False
        '
        'PicBoxShink
        '
        Me.PicBoxShink.Image = Global.reticle.My.Resources.Resources.ArrowRed_small
        Me.PicBoxShink.Location = New System.Drawing.Point(252, 129)
        Me.PicBoxShink.Name = "PicBoxShink"
        Me.PicBoxShink.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxShink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxShink.TabIndex = 10
        Me.PicBoxShink.TabStop = False
        '
        'PicBoxGrow
        '
        Me.PicBoxGrow.Image = Global.reticle.My.Resources.Resources.ArrowGreen_small
        Me.PicBoxGrow.Location = New System.Drawing.Point(252, 12)
        Me.PicBoxGrow.Name = "PicBoxGrow"
        Me.PicBoxGrow.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxGrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxGrow.TabIndex = 11
        Me.PicBoxGrow.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Grow/Shrink"
        '
        'BtnShowCenterOfReticle
        '
        Me.BtnShowCenterOfReticle.Location = New System.Drawing.Point(3, 187)
        Me.BtnShowCenterOfReticle.Name = "BtnShowCenterOfReticle"
        Me.BtnShowCenterOfReticle.Size = New System.Drawing.Size(132, 23)
        Me.BtnShowCenterOfReticle.TabIndex = 15
        Me.BtnShowCenterOfReticle.Text = "Show Center of Reticle"
        Me.BtnShowCenterOfReticle.UseVisualStyleBackColor = True
        '
        'BtnHideShow
        '
        Me.BtnHideShow.Location = New System.Drawing.Point(141, 187)
        Me.BtnHideShow.Name = "BtnHideShow"
        Me.BtnHideShow.Size = New System.Drawing.Size(104, 23)
        Me.BtnHideShow.TabIndex = 16
        Me.BtnHideShow.Text = "Hide Reticle"
        Me.BtnHideShow.UseVisualStyleBackColor = True
        '
        'BtnCenterReticle
        '
        Me.BtnCenterReticle.Location = New System.Drawing.Point(251, 187)
        Me.BtnCenterReticle.Name = "BtnCenterReticle"
        Me.BtnCenterReticle.Size = New System.Drawing.Size(93, 23)
        Me.BtnCenterReticle.TabIndex = 17
        Me.BtnCenterReticle.Text = "Center Reticle"
        Me.BtnCenterReticle.UseVisualStyleBackColor = True
        '
        'BtnSwitchToNextScreen
        '
        Me.BtnSwitchToNextScreen.Location = New System.Drawing.Point(350, 187)
        Me.BtnSwitchToNextScreen.Name = "BtnSwitchToNextScreen"
        Me.BtnSwitchToNextScreen.Size = New System.Drawing.Size(149, 23)
        Me.BtnSwitchToNextScreen.TabIndex = 19
        Me.BtnSwitchToNextScreen.Text = "Switch To Next Screen"
        Me.BtnSwitchToNextScreen.UseVisualStyleBackColor = True
        '
        'BtnOpenReticleFolder
        '
        Me.BtnOpenReticleFolder.Location = New System.Drawing.Point(505, 187)
        Me.BtnOpenReticleFolder.Name = "BtnOpenReticleFolder"
        Me.BtnOpenReticleFolder.Size = New System.Drawing.Size(135, 23)
        Me.BtnOpenReticleFolder.TabIndex = 20
        Me.BtnOpenReticleFolder.Text = "Open Reticle Folder"
        Me.BtnOpenReticleFolder.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'LblRed
        '
        Me.LblRed.AutoSize = True
        Me.LblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRed.Location = New System.Drawing.Point(470, 29)
        Me.LblRed.Name = "LblRed"
        Me.LblRed.Size = New System.Drawing.Size(56, 25)
        Me.LblRed.TabIndex = 29
        Me.LblRed.Text = "RED"
        '
        'LblGreen
        '
        Me.LblGreen.AutoSize = True
        Me.LblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGreen.Location = New System.Drawing.Point(449, 86)
        Me.LblGreen.Name = "LblGreen"
        Me.LblGreen.Size = New System.Drawing.Size(86, 25)
        Me.LblGreen.TabIndex = 30
        Me.LblGreen.Text = "GREEN"
        '
        'LblBlue
        '
        Me.LblBlue.AutoSize = True
        Me.LblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlue.Location = New System.Drawing.Point(459, 142)
        Me.LblBlue.Name = "LblBlue"
        Me.LblBlue.Size = New System.Drawing.Size(67, 25)
        Me.LblBlue.TabIndex = 31
        Me.LblBlue.Text = "BLUE"
        '
        'BtnLowRed
        '
        Me.BtnLowRed.Image = Global.reticle.My.Resources.Resources.ArrowRed_small
        Me.BtnLowRed.Location = New System.Drawing.Point(390, 12)
        Me.BtnLowRed.Name = "BtnLowRed"
        Me.BtnLowRed.Size = New System.Drawing.Size(61, 52)
        Me.BtnLowRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLowRed.TabIndex = 32
        Me.BtnLowRed.TabStop = False
        '
        'BtnHighRed
        '
        Me.BtnHighRed.Image = Global.reticle.My.Resources.Resources.ArrowRed_small
        Me.BtnHighRed.Location = New System.Drawing.Point(532, 12)
        Me.BtnHighRed.Name = "BtnHighRed"
        Me.BtnHighRed.Size = New System.Drawing.Size(61, 52)
        Me.BtnHighRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnHighRed.TabIndex = 33
        Me.BtnHighRed.TabStop = False
        '
        'BtnLowGreen
        '
        Me.BtnLowGreen.Image = Global.reticle.My.Resources.Resources.ArrowGreen_small
        Me.BtnLowGreen.Location = New System.Drawing.Point(390, 70)
        Me.BtnLowGreen.Name = "BtnLowGreen"
        Me.BtnLowGreen.Size = New System.Drawing.Size(61, 52)
        Me.BtnLowGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLowGreen.TabIndex = 34
        Me.BtnLowGreen.TabStop = False
        '
        'BtnHighGreen
        '
        Me.BtnHighGreen.Image = Global.reticle.My.Resources.Resources.ArrowGreen_small
        Me.BtnHighGreen.Location = New System.Drawing.Point(532, 70)
        Me.BtnHighGreen.Name = "BtnHighGreen"
        Me.BtnHighGreen.Size = New System.Drawing.Size(61, 52)
        Me.BtnHighGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnHighGreen.TabIndex = 35
        Me.BtnHighGreen.TabStop = False
        '
        'BtnLowBlue
        '
        Me.BtnLowBlue.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.BtnLowBlue.Location = New System.Drawing.Point(390, 128)
        Me.BtnLowBlue.Name = "BtnLowBlue"
        Me.BtnLowBlue.Size = New System.Drawing.Size(61, 52)
        Me.BtnLowBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLowBlue.TabIndex = 36
        Me.BtnLowBlue.TabStop = False
        '
        'BtnHighBlue
        '
        Me.BtnHighBlue.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.BtnHighBlue.Location = New System.Drawing.Point(532, 128)
        Me.BtnHighBlue.Name = "BtnHighBlue"
        Me.BtnHighBlue.Size = New System.Drawing.Size(61, 52)
        Me.BtnHighBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnHighBlue.TabIndex = 37
        Me.BtnHighBlue.TabStop = False
        '
        'BtnPreviousReticle
        '
        Me.BtnPreviousReticle.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.BtnPreviousReticle.Location = New System.Drawing.Point(12, 12)
        Me.BtnPreviousReticle.Name = "BtnPreviousReticle"
        Me.BtnPreviousReticle.Size = New System.Drawing.Size(32, 32)
        Me.BtnPreviousReticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPreviousReticle.TabIndex = 38
        Me.BtnPreviousReticle.TabStop = False
        '
        'BtnNextReticle
        '
        Me.BtnNextReticle.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.BtnNextReticle.Location = New System.Drawing.Point(645, 12)
        Me.BtnNextReticle.Name = "BtnNextReticle"
        Me.BtnNextReticle.Size = New System.Drawing.Size(32, 32)
        Me.BtnNextReticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnNextReticle.TabIndex = 39
        Me.BtnNextReticle.TabStop = False
        '
        'Timer1
        '
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(645, 177)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(32, 32)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSave.TabIndex = 40
        Me.BtnSave.TabStop = False
        '
        'BtnReset
        '
        Me.BtnReset.Image = Global.reticle.My.Resources.Resources.reset
        Me.BtnReset.Location = New System.Drawing.Point(645, 142)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(32, 32)
        Me.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnReset.TabIndex = 41
        Me.BtnReset.TabStop = False
        '
        'BtnOpenSaveReticle
        '
        Me.BtnOpenSaveReticle.Image = Global.reticle.My.Resources.Resources.load_saved_reticle
        Me.BtnOpenSaveReticle.Location = New System.Drawing.Point(645, 104)
        Me.BtnOpenSaveReticle.Name = "BtnOpenSaveReticle"
        Me.BtnOpenSaveReticle.Size = New System.Drawing.Size(32, 32)
        Me.BtnOpenSaveReticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnOpenSaveReticle.TabIndex = 42
        Me.BtnOpenSaveReticle.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 221)
        Me.Controls.Add(Me.BtnOpenSaveReticle)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNextReticle)
        Me.Controls.Add(Me.BtnPreviousReticle)
        Me.Controls.Add(Me.BtnHighBlue)
        Me.Controls.Add(Me.BtnLowBlue)
        Me.Controls.Add(Me.BtnHighGreen)
        Me.Controls.Add(Me.BtnLowGreen)
        Me.Controls.Add(Me.BtnHighRed)
        Me.Controls.Add(Me.BtnLowRed)
        Me.Controls.Add(Me.LblBlue)
        Me.Controls.Add(Me.LblGreen)
        Me.Controls.Add(Me.LblRed)
        Me.Controls.Add(Me.BtnOpenReticleFolder)
        Me.Controls.Add(Me.BtnSwitchToNextScreen)
        Me.Controls.Add(Me.BtnCenterReticle)
        Me.Controls.Add(Me.BtnHideShow)
        Me.Controls.Add(Me.BtnShowCenterOfReticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxGrow)
        Me.Controls.Add(Me.PicBoxShink)
        Me.Controls.Add(Me.PicBoxMoveLeft)
        Me.Controls.Add(Me.PicBoxMoveRight)
        Me.Controls.Add(Me.PicBoxMoveDown)
        Me.Controls.Add(Me.PicBoxMoveUp)
        Me.Controls.Add(Me.LblMoveByPxAmount)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(705, 260)
        Me.MinimumSize = New System.Drawing.Size(705, 260)
        Me.Name = "Form1"
        Me.Text = "reticle"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.PicBoxMoveUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxShink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxGrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLowRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHighRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLowGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHighGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLowBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHighBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPreviousReticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNextReticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnOpenSaveReticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMoveByPxAmount As Label
    Friend WithEvents PicBoxMoveUp As PictureBox
    Friend WithEvents PicBoxMoveDown As PictureBox
    Friend WithEvents PicBoxMoveRight As PictureBox
    Friend WithEvents PicBoxMoveLeft As PictureBox
    Friend WithEvents PicBoxShink As PictureBox
    Friend WithEvents PicBoxGrow As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnShowCenterOfReticle As Button
    Friend WithEvents BtnHideShow As Button
    Friend WithEvents BtnCenterReticle As Button
    Friend WithEvents BtnSwitchToNextScreen As Button
    Friend WithEvents BtnOpenReticleFolder As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LblRed As Label
    Friend WithEvents LblGreen As Label
    Friend WithEvents LblBlue As Label
    Friend WithEvents BtnLowRed As PictureBox
    Friend WithEvents BtnHighRed As PictureBox
    Friend WithEvents BtnLowGreen As PictureBox
    Friend WithEvents BtnHighGreen As PictureBox
    Friend WithEvents BtnLowBlue As PictureBox
    Friend WithEvents BtnHighBlue As PictureBox
    Friend WithEvents BtnPreviousReticle As PictureBox
    Friend WithEvents BtnNextReticle As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnSave As PictureBox
    Friend WithEvents BtnReset As PictureBox
    Friend WithEvents BtnOpenSaveReticle As PictureBox
End Class
