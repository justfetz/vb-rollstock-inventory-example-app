<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.DaysTextDetail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TonsTextDetail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.monthTextDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idTextDetail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DaysTextDetail
        '
        Me.DaysTextDetail.Location = New System.Drawing.Point(124, 186)
        Me.DaysTextDetail.Name = "DaysTextDetail"
        Me.DaysTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.DaysTextDetail.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Days"
        '
        'TonsTextDetail
        '
        Me.TonsTextDetail.Location = New System.Drawing.Point(124, 132)
        Me.TonsTextDetail.Name = "TonsTextDetail"
        Me.TonsTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.TonsTextDetail.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tons"
        '
        'monthTextDetail
        '
        Me.monthTextDetail.Location = New System.Drawing.Point(124, 78)
        Me.monthTextDetail.Name = "monthTextDetail"
        Me.monthTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.monthTextDetail.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Month"
        '
        'idTextDetail
        '
        Me.idTextDetail.Location = New System.Drawing.Point(124, 28)
        Me.idTextDetail.Name = "idTextDetail"
        Me.idTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.idTextDetail.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(51, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(146, 61)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(324, 253)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(137, 61)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 336)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DaysTextDetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TonsTextDetail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.monthTextDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idTextDetail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DaysTextDetail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TonsTextDetail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents monthTextDetail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idTextDetail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
