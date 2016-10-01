<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EC_MAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EC_MAP))
        Me.picBoxOU = New System.Windows.Forms.PictureBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.picBoxOU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxOU
        '
        Me.picBoxOU.Image = CType(resources.GetObject("picBoxOU.Image"), System.Drawing.Image)
        Me.picBoxOU.Location = New System.Drawing.Point(130, 68)
        Me.picBoxOU.Name = "picBoxOU"
        Me.picBoxOU.Size = New System.Drawing.Size(989, 701)
        Me.picBoxOU.TabIndex = 0
        Me.picBoxOU.TabStop = False
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(483, 816)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(331, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "DIRECTIONS TO OU EC"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblTitle.Font = New System.Drawing.Font("SimSun", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(239, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(777, 28)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Directions to Oakland University Engineering Center"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(480, 883)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(327, 45)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^^^^^^^^^^^^^^^^^^^^^" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^^^^^^^^^^^^"
        Me.lblOutput.Visible = False
        '
        'EC_MAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 966)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.picBoxOU)
        Me.Name = "EC_MAP"
        Me.Text = "Form1"
        CType(Me.picBoxOU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBoxOU As System.Windows.Forms.PictureBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
