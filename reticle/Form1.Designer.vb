﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblMoveByPxAmount = New System.Windows.Forms.Label()
        Me.PicBoxMoveUp = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveDown = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveRight = New System.Windows.Forms.PictureBox()
        Me.PicBoxMoveLeft = New System.Windows.Forms.PictureBox()
        Me.PicBoxShink = New System.Windows.Forms.PictureBox()
        Me.PicBoxGrow = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNextReticle = New System.Windows.Forms.Button()
        Me.BtnPreviousReticle = New System.Windows.Forms.Button()
        Me.BtnShowCenterOfReticle = New System.Windows.Forms.Button()
        CType(Me.PicBoxMoveUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxMoveLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxShink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxGrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMoveByPxAmount
        '
        Me.LblMoveByPxAmount.AutoSize = True
        Me.LblMoveByPxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoveByPxAmount.Location = New System.Drawing.Point(97, 141)
        Me.LblMoveByPxAmount.Name = "LblMoveByPxAmount"
        Me.LblMoveByPxAmount.Size = New System.Drawing.Size(52, 20)
        Me.LblMoveByPxAmount.TabIndex = 5
        Me.LblMoveByPxAmount.Text = "50 px"
        '
        'PicBoxMoveUp
        '
        Me.PicBoxMoveUp.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveUp.Location = New System.Drawing.Point(93, 66)
        Me.PicBoxMoveUp.Name = "PicBoxMoveUp"
        Me.PicBoxMoveUp.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveUp.TabIndex = 6
        Me.PicBoxMoveUp.TabStop = False
        '
        'PicBoxMoveDown
        '
        Me.PicBoxMoveDown.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveDown.Location = New System.Drawing.Point(93, 183)
        Me.PicBoxMoveDown.Name = "PicBoxMoveDown"
        Me.PicBoxMoveDown.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveDown.TabIndex = 7
        Me.PicBoxMoveDown.TabStop = False
        '
        'PicBoxMoveRight
        '
        Me.PicBoxMoveRight.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveRight.Location = New System.Drawing.Point(159, 124)
        Me.PicBoxMoveRight.Name = "PicBoxMoveRight"
        Me.PicBoxMoveRight.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveRight.TabIndex = 8
        Me.PicBoxMoveRight.TabStop = False
        '
        'PicBoxMoveLeft
        '
        Me.PicBoxMoveLeft.Image = Global.reticle.My.Resources.Resources.ArrowBlue_small
        Me.PicBoxMoveLeft.Location = New System.Drawing.Point(22, 124)
        Me.PicBoxMoveLeft.Name = "PicBoxMoveLeft"
        Me.PicBoxMoveLeft.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxMoveLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxMoveLeft.TabIndex = 9
        Me.PicBoxMoveLeft.TabStop = False
        '
        'PicBoxShink
        '
        Me.PicBoxShink.Image = Global.reticle.My.Resources.Resources.ArrowRed_small
        Me.PicBoxShink.Location = New System.Drawing.Point(305, 183)
        Me.PicBoxShink.Name = "PicBoxShink"
        Me.PicBoxShink.Size = New System.Drawing.Size(61, 52)
        Me.PicBoxShink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBoxShink.TabIndex = 10
        Me.PicBoxShink.TabStop = False
        '
        'PicBoxGrow
        '
        Me.PicBoxGrow.Image = Global.reticle.My.Resources.Resources.ArrowGreen_small
        Me.PicBoxGrow.Location = New System.Drawing.Point(305, 66)
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
        Me.Label1.Location = New System.Drawing.Point(270, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Grow/Shrink"
        '
        'BtnNextReticle
        '
        Me.BtnNextReticle.Location = New System.Drawing.Point(621, 124)
        Me.BtnNextReticle.Name = "BtnNextReticle"
        Me.BtnNextReticle.Size = New System.Drawing.Size(93, 23)
        Me.BtnNextReticle.TabIndex = 13
        Me.BtnNextReticle.Text = "Next Reticle"
        Me.BtnNextReticle.UseVisualStyleBackColor = True
        '
        'BtnPreviousReticle
        '
        Me.BtnPreviousReticle.Location = New System.Drawing.Point(511, 124)
        Me.BtnPreviousReticle.Name = "BtnPreviousReticle"
        Me.BtnPreviousReticle.Size = New System.Drawing.Size(104, 23)
        Me.BtnPreviousReticle.TabIndex = 14
        Me.BtnPreviousReticle.Text = "Previous Reticle"
        Me.BtnPreviousReticle.UseVisualStyleBackColor = True
        '
        'BtnShowCenterOfReticle
        '
        Me.BtnShowCenterOfReticle.Location = New System.Drawing.Point(511, 153)
        Me.BtnShowCenterOfReticle.Name = "BtnShowCenterOfReticle"
        Me.BtnShowCenterOfReticle.Size = New System.Drawing.Size(203, 23)
        Me.BtnShowCenterOfReticle.TabIndex = 15
        Me.BtnShowCenterOfReticle.Text = "Show Center of Reticle"
        Me.BtnShowCenterOfReticle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnShowCenterOfReticle)
        Me.Controls.Add(Me.BtnPreviousReticle)
        Me.Controls.Add(Me.BtnNextReticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxGrow)
        Me.Controls.Add(Me.PicBoxShink)
        Me.Controls.Add(Me.PicBoxMoveLeft)
        Me.Controls.Add(Me.PicBoxMoveRight)
        Me.Controls.Add(Me.PicBoxMoveDown)
        Me.Controls.Add(Me.PicBoxMoveUp)
        Me.Controls.Add(Me.LblMoveByPxAmount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "reticle"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.PicBoxMoveUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxMoveLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxShink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxGrow, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnNextReticle As Button
    Friend WithEvents BtnPreviousReticle As Button
    Friend WithEvents BtnShowCenterOfReticle As Button
End Class
