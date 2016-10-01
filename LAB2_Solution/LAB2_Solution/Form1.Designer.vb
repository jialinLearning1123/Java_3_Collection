<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnComputeStats = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpBoxScores1 = New System.Windows.Forms.GroupBox()
        Me.txtTestScore1 = New System.Windows.Forms.TextBox()
        Me.txtTestScore2 = New System.Windows.Forms.TextBox()
        Me.txtTestScore3 = New System.Windows.Forms.TextBox()
        Me.txtTestScore4 = New System.Windows.Forms.TextBox()
        Me.txtTestScore5 = New System.Windows.Forms.TextBox()
        Me.grpBoxScores2 = New System.Windows.Forms.GroupBox()
        Me.txtTestScore10 = New System.Windows.Forms.TextBox()
        Me.txtTestScore9 = New System.Windows.Forms.TextBox()
        Me.txtTestScore8 = New System.Windows.Forms.TextBox()
        Me.txtTestScore7 = New System.Windows.Forms.TextBox()
        Me.txtTestScore6 = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtSD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpBoxScores1.SuspendLayout()
        Me.grpBoxScores2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(234, 327)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(289, 23)
        Me.btnRandom.TabIndex = 0
        Me.btnRandom.Text = "Fill Random Test Scores"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnComputeStats
        '
        Me.btnComputeStats.Location = New System.Drawing.Point(75, 470)
        Me.btnComputeStats.Name = "btnComputeStats"
        Me.btnComputeStats.Size = New System.Drawing.Size(164, 44)
        Me.btnComputeStats.TabIndex = 0
        Me.btnComputeStats.Text = "Calculate STATES"
        Me.btnComputeStats.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(274, 467)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(210, 50)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear Test Scores and States"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(519, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 50)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Test Score 8:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Score 9:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Test Score 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Test Score 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Test Score 5:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Test Score 7:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Test Score 10:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Test Score 2:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Test Score 4:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Test Score 6:"
        '
        'grpBoxScores1
        '
        Me.grpBoxScores1.Controls.Add(Me.Label3)
        Me.grpBoxScores1.Controls.Add(Me.Label8)
        Me.grpBoxScores1.Controls.Add(Me.Label9)
        Me.grpBoxScores1.Controls.Add(Me.Label4)
        Me.grpBoxScores1.Controls.Add(Me.Label5)
        Me.grpBoxScores1.Controls.Add(Me.txtTestScore1)
        Me.grpBoxScores1.Controls.Add(Me.txtTestScore2)
        Me.grpBoxScores1.Controls.Add(Me.txtTestScore3)
        Me.grpBoxScores1.Controls.Add(Me.txtTestScore4)
        Me.grpBoxScores1.Controls.Add(Me.txtTestScore5)
        Me.grpBoxScores1.Location = New System.Drawing.Point(36, 47)
        Me.grpBoxScores1.Name = "grpBoxScores1"
        Me.grpBoxScores1.Size = New System.Drawing.Size(347, 257)
        Me.grpBoxScores1.TabIndex = 2
        Me.grpBoxScores1.TabStop = False
        Me.grpBoxScores1.Text = "Test Scores Ranging Between 50 - 100"
        '
        'txtTestScore1
        '
        Me.txtTestScore1.Location = New System.Drawing.Point(157, 38)
        Me.txtTestScore1.Name = "txtTestScore1"
        Me.txtTestScore1.ReadOnly = True
        Me.txtTestScore1.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore1.TabIndex = 4
        '
        'txtTestScore2
        '
        Me.txtTestScore2.Location = New System.Drawing.Point(157, 84)
        Me.txtTestScore2.Name = "txtTestScore2"
        Me.txtTestScore2.ReadOnly = True
        Me.txtTestScore2.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore2.TabIndex = 4
        '
        'txtTestScore3
        '
        Me.txtTestScore3.Location = New System.Drawing.Point(157, 123)
        Me.txtTestScore3.Name = "txtTestScore3"
        Me.txtTestScore3.ReadOnly = True
        Me.txtTestScore3.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore3.TabIndex = 4
        '
        'txtTestScore4
        '
        Me.txtTestScore4.Location = New System.Drawing.Point(157, 165)
        Me.txtTestScore4.Name = "txtTestScore4"
        Me.txtTestScore4.ReadOnly = True
        Me.txtTestScore4.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore4.TabIndex = 4
        '
        'txtTestScore5
        '
        Me.txtTestScore5.Location = New System.Drawing.Point(157, 203)
        Me.txtTestScore5.Name = "txtTestScore5"
        Me.txtTestScore5.ReadOnly = True
        Me.txtTestScore5.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore5.TabIndex = 4
        '
        'grpBoxScores2
        '
        Me.grpBoxScores2.Controls.Add(Me.txtTestScore10)
        Me.grpBoxScores2.Controls.Add(Me.Label10)
        Me.grpBoxScores2.Controls.Add(Me.txtTestScore9)
        Me.grpBoxScores2.Controls.Add(Me.Label6)
        Me.grpBoxScores2.Controls.Add(Me.txtTestScore8)
        Me.grpBoxScores2.Controls.Add(Me.Label7)
        Me.grpBoxScores2.Controls.Add(Me.txtTestScore7)
        Me.grpBoxScores2.Controls.Add(Me.Label1)
        Me.grpBoxScores2.Controls.Add(Me.Label2)
        Me.grpBoxScores2.Controls.Add(Me.txtTestScore6)
        Me.grpBoxScores2.Location = New System.Drawing.Point(397, 47)
        Me.grpBoxScores2.Name = "grpBoxScores2"
        Me.grpBoxScores2.Size = New System.Drawing.Size(318, 257)
        Me.grpBoxScores2.TabIndex = 3
        Me.grpBoxScores2.TabStop = False
        Me.grpBoxScores2.Text = "Test Scores Ranging Between 30 - 100"
        '
        'txtTestScore10
        '
        Me.txtTestScore10.Location = New System.Drawing.Point(155, 206)
        Me.txtTestScore10.Name = "txtTestScore10"
        Me.txtTestScore10.ReadOnly = True
        Me.txtTestScore10.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore10.TabIndex = 4
        '
        'txtTestScore9
        '
        Me.txtTestScore9.Location = New System.Drawing.Point(155, 165)
        Me.txtTestScore9.Name = "txtTestScore9"
        Me.txtTestScore9.ReadOnly = True
        Me.txtTestScore9.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore9.TabIndex = 4
        '
        'txtTestScore8
        '
        Me.txtTestScore8.Location = New System.Drawing.Point(155, 123)
        Me.txtTestScore8.Name = "txtTestScore8"
        Me.txtTestScore8.ReadOnly = True
        Me.txtTestScore8.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore8.TabIndex = 4
        '
        'txtTestScore7
        '
        Me.txtTestScore7.Location = New System.Drawing.Point(155, 84)
        Me.txtTestScore7.Name = "txtTestScore7"
        Me.txtTestScore7.ReadOnly = True
        Me.txtTestScore7.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore7.TabIndex = 4
        '
        'txtTestScore6
        '
        Me.txtTestScore6.Location = New System.Drawing.Point(155, 38)
        Me.txtTestScore6.Name = "txtTestScore6"
        Me.txtTestScore6.ReadOnly = True
        Me.txtTestScore6.Size = New System.Drawing.Size(100, 25)
        Me.txtTestScore6.TabIndex = 4
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(355, 382)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.ReadOnly = True
        Me.txtMean.Size = New System.Drawing.Size(100, 25)
        Me.txtMean.TabIndex = 4
        '
        'txtSD
        '
        Me.txtSD.Location = New System.Drawing.Point(355, 426)
        Me.txtSD.Name = "txtSD"
        Me.txtSD.ReadOnly = True
        Me.txtSD.Size = New System.Drawing.Size(100, 25)
        Me.txtSD.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(160, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Standard Deviation:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(271, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 24)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Mean:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 532)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSD)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.grpBoxScores2)
        Me.Controls.Add(Me.grpBoxScores1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeStats)
        Me.Controls.Add(Me.btnRandom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpBoxScores1.ResumeLayout(False)
        Me.grpBoxScores1.PerformLayout()
        Me.grpBoxScores2.ResumeLayout(False)
        Me.grpBoxScores2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnComputeStats As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpBoxScores1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxScores2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTestScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore10 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore9 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore8 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore7 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore6 As System.Windows.Forms.TextBox
    Friend WithEvents txtMean As System.Windows.Forms.TextBox
    Friend WithEvents txtSD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
