<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavedData
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
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(258, 86)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Height(m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Weight(kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BMI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Category"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(258, 135)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 5
        '
        'txtBMI
        '
        Me.txtBMI.Location = New System.Drawing.Point(258, 186)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(100, 22)
        Me.txtBMI.TabIndex = 6
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(258, 230)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 22)
        Me.txtCategory.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(258, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(339, 318)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 9
        Me.btnForward.Text = ">"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(177, 318)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(258, 347)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'SavedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeight)
        Me.Name = "SavedData"
        Me.Text = "SavedData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
End Class
