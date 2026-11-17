<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saved_Data
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
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHUnit = New System.Windows.Forms.Label()
        Me.lblWUnit = New System.Windows.Forms.Label()
        Me.lblBMIAns = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(316, 113)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(215, 117)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 17)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date entered"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(369, 155)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(132, 22)
        Me.txtHeight.TabIndex = 19
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(369, 208)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(132, 22)
        Me.txtWeight.TabIndex = 20
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(219, 158)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 17)
        Me.lblHeight.TabIndex = 21
        Me.lblHeight.Text = "Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(219, 211)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 22
        Me.lblWeight.Text = "Weight"
        '
        'lblHUnit
        '
        Me.lblHUnit.AutoSize = True
        Me.lblHUnit.Location = New System.Drawing.Point(310, 158)
        Me.lblHUnit.Name = "lblHUnit"
        Me.lblHUnit.Size = New System.Drawing.Size(55, 17)
        Me.lblHUnit.TabIndex = 24
        Me.lblHUnit.Text = "Metres:"
        '
        'lblWUnit
        '
        Me.lblWUnit.AutoSize = True
        Me.lblWUnit.Location = New System.Drawing.Point(291, 211)
        Me.lblWUnit.Name = "lblWUnit"
        Me.lblWUnit.Size = New System.Drawing.Size(74, 17)
        Me.lblWUnit.TabIndex = 26
        Me.lblWUnit.Text = "Kilograms:"
        '
        'lblBMIAns
        '
        Me.lblBMIAns.AllowDrop = True
        Me.lblBMIAns.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBMIAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBMIAns.Location = New System.Drawing.Point(272, 288)
        Me.lblBMIAns.Name = "lblBMIAns"
        Me.lblBMIAns.Size = New System.Drawing.Size(229, 52)
        Me.lblBMIAns.TabIndex = 28
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(214, 289)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(43, 17)
        Me.lblBMI.TabIndex = 27
        Me.lblBMI.Text = "BMI ="
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(391, 366)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(121, 23)
        Me.btnRight.TabIndex = 30
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(230, 366)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(121, 23)
        Me.btnLeft.TabIndex = 29
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(341, 405)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(51, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Saved_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.lblBMIAns)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblWUnit)
        Me.Controls.Add(Me.lblHUnit)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDate)
        Me.Name = "Saved_Data"
        Me.Text = "Saved_Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHUnit As Label
    Friend WithEvents lblWUnit As Label
    Friend WithEvents lblBMIAns As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
