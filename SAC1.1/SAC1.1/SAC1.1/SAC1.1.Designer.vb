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
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblBMIAns = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.cbUnits = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(231, 130)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(132, 22)
        Me.txtHeight.TabIndex = 0
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(231, 183)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(132, 22)
        Me.txtWeight.TabIndex = 1
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(85, 135)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(86, 17)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = "Height (m/ft)"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(84, 188)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(132, 17)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight (kg/pounds)"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(85, 234)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(43, 17)
        Me.lblBMI.TabIndex = 5
        Me.lblBMI.Text = "BMI ="
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTitle.Location = New System.Drawing.Point(83, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 29)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "BMI CALCULATOR"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(84, 306)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(279, 54)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblBMIAns
        '
        Me.lblBMIAns.AllowDrop = True
        Me.lblBMIAns.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBMIAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBMIAns.Location = New System.Drawing.Point(134, 234)
        Me.lblBMIAns.Name = "lblBMIAns"
        Me.lblBMIAns.Size = New System.Drawing.Size(229, 52)
        Me.lblBMIAns.TabIndex = 8
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(84, 80)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(44, 17)
        Me.lblUnit.TabIndex = 9
        Me.lblUnit.Text = "Units:"
        '
        'cbUnits
        '
        Me.cbUnits.AllowDrop = True
        Me.cbUnits.FormattingEnabled = True
        Me.cbUnits.Items.AddRange(New Object() {"Metric", "Imperial"})
        Me.cbUnits.Location = New System.Drawing.Point(231, 80)
        Me.cbUnits.Name = "cbUnits"
        Me.cbUnits.Size = New System.Drawing.Size(132, 24)
        Me.cbUnits.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 450)
        Me.Controls.Add(Me.cbUnits)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblBMIAns)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblBMIAns As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents cbUnits As ComboBox
End Class
