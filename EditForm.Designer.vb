<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DaysTextDetail
        '
        Me.DaysTextDetail.Location = New System.Drawing.Point(101, 257)
        Me.DaysTextDetail.Name = "DaysTextDetail"
        Me.DaysTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.DaysTextDetail.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Days"
        '
        'TonsTextDetail
        '
        Me.TonsTextDetail.Location = New System.Drawing.Point(101, 203)
        Me.TonsTextDetail.Name = "TonsTextDetail"
        Me.TonsTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.TonsTextDetail.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tons"
        '
        'monthTextDetail
        '
        Me.monthTextDetail.Location = New System.Drawing.Point(101, 161)
        Me.monthTextDetail.Name = "monthTextDetail"
        Me.monthTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.monthTextDetail.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Month"
        '
        'idTextDetail
        '
        Me.idTextDetail.Location = New System.Drawing.Point(101, 99)
        Me.idTextDetail.Name = "idTextDetail"
        Me.idTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.idTextDetail.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "The Edit Form"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 46)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 46)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Please use format: 'YYYY-MM-DD'"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 375)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DaysTextDetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TonsTextDetail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.monthTextDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idTextDetail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditForm"
        Me.Text = "EditForm"
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
