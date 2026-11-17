<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.rdImperial = New System.Windows.Forms.RadioButton()
        Me.rdMetric = New System.Windows.Forms.RadioButton()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdImperial
        '
        Me.rdImperial.AutoSize = True
        Me.rdImperial.Location = New System.Drawing.Point(236, 96)
        Me.rdImperial.Name = "rdImperial"
        Me.rdImperial.Size = New System.Drawing.Size(78, 21)
        Me.rdImperial.TabIndex = 20
        Me.rdImperial.Text = "Imperial"
        Me.rdImperial.UseVisualStyleBackColor = True
        '
        'rdMetric
        '
        Me.rdMetric.AutoSize = True
        Me.rdMetric.Checked = True
        Me.rdMetric.Location = New System.Drawing.Point(236, 69)
        Me.rdMetric.Name = "rdMetric"
        Me.rdMetric.Size = New System.Drawing.Size(67, 21)
        Me.rdMetric.TabIndex = 19
        Me.rdMetric.TabStop = True
        Me.rdMetric.Text = "Metric"
        Me.rdMetric.UseVisualStyleBackColor = True
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(86, 87)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(44, 17)
        Me.lblUnit.TabIndex = 18
        Me.lblUnit.Text = "Units:"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(214, 149)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 22)
        Me.txtDOB.TabIndex = 21
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(148, 149)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(38, 17)
        Me.lblDOB.TabIndex = 22
        Me.lblDOB.Text = "DOB"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(214, 177)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 23
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(147, 180)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 17)
        Me.lblHeight.TabIndex = 24
        Me.lblHeight.Text = "Height"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(89, 221)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(225, 42)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save and exit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 353)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.rdImperial)
        Me.Controls.Add(Me.rdMetric)
        Me.Controls.Add(Me.lblUnit)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdImperial As RadioButton
    Friend WithEvents rdMetric As RadioButton
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents btnSave As Button
End Class
