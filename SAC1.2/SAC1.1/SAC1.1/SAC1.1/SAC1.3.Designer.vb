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
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtBMIAns = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
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
        Me.lblHeight.Location = New System.Drawing.Point(81, 133)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 17)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = "Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(81, 186)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(428, 152)
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
        Me.btnCalculate.Location = New System.Drawing.Point(88, 229)
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
        Me.lblBMIAns.Location = New System.Drawing.Point(486, 151)
        Me.lblBMIAns.Name = "lblBMIAns"
        Me.lblBMIAns.Size = New System.Drawing.Size(229, 52)
        Me.lblBMIAns.TabIndex = 8
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(231, 155)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(132, 22)
        Me.txtInches.TabIndex = 11
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(486, 75)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(99, 23)
        Me.btnView.TabIndex = 19
        Me.btnView.Text = "View Data"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(616, 75)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(99, 23)
        Me.btnSettings.TabIndex = 20
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(486, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(229, 54)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add To Data"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBMIAns
        '
        Me.txtBMIAns.Location = New System.Drawing.Point(486, 126)
        Me.txtBMIAns.Name = "txtBMIAns"
        Me.txtBMIAns.Size = New System.Drawing.Size(100, 22)
        Me.txtBMIAns.TabIndex = 22
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(592, 126)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 22)
        Me.txtDOB.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 354)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtBMIAns)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtInches)
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
    Friend WithEvents txtInches As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtBMIAns As TextBox
    Friend WithEvents txtDOB As TextBox
End Class
