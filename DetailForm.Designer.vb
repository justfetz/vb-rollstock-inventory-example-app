<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idTextDetail = New System.Windows.Forms.TextBox()
        Me.monthTextDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TonsTextDetail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DaysTextDetail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PaperForecastText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaperUsageText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.paperTypeText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.paperIdText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'idTextDetail
        '
        Me.idTextDetail.Location = New System.Drawing.Point(99, 32)
        Me.idTextDetail.Name = "idTextDetail"
        Me.idTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.idTextDetail.TabIndex = 1
        '
        'monthTextDetail
        '
        Me.monthTextDetail.Location = New System.Drawing.Point(99, 82)
        Me.monthTextDetail.Name = "monthTextDetail"
        Me.monthTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.monthTextDetail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Month"
        '
        'TonsTextDetail
        '
        Me.TonsTextDetail.Location = New System.Drawing.Point(99, 136)
        Me.TonsTextDetail.Name = "TonsTextDetail"
        Me.TonsTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.TonsTextDetail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tons"
        '
        'DaysTextDetail
        '
        Me.DaysTextDetail.Location = New System.Drawing.Point(99, 190)
        Me.DaysTextDetail.Name = "DaysTextDetail"
        Me.DaysTextDetail.Size = New System.Drawing.Size(337, 26)
        Me.DaysTextDetail.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Days"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaperForecastText)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PaperUsageText)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.paperTypeText)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.paperIdText)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 248)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paper Details"
        '
        'PaperForecastText
        '
        Me.PaperForecastText.Location = New System.Drawing.Point(95, 196)
        Me.PaperForecastText.Name = "PaperForecastText"
        Me.PaperForecastText.Size = New System.Drawing.Size(337, 26)
        Me.PaperForecastText.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Forecast"
        '
        'PaperUsageText
        '
        Me.PaperUsageText.Location = New System.Drawing.Point(95, 142)
        Me.PaperUsageText.Name = "PaperUsageText"
        Me.PaperUsageText.Size = New System.Drawing.Size(337, 26)
        Me.PaperUsageText.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Usage"
        '
        'paperTypeText
        '
        Me.paperTypeText.Location = New System.Drawing.Point(95, 88)
        Me.paperTypeText.Name = "paperTypeText"
        Me.paperTypeText.Size = New System.Drawing.Size(337, 26)
        Me.paperTypeText.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PType"
        '
        'paperIdText
        '
        Me.paperIdText.Location = New System.Drawing.Point(95, 38)
        Me.paperIdText.Name = "paperIdText"
        Me.paperIdText.Size = New System.Drawing.Size(337, 26)
        Me.paperIdText.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ID"
        '
        'DetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DaysTextDetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TonsTextDetail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.monthTextDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idTextDetail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailForm"
        Me.Text = "DetailForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents idTextDetail As TextBox
    Friend WithEvents monthTextDetail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TonsTextDetail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DaysTextDetail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PaperForecastText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PaperUsageText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents paperTypeText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents paperIdText As TextBox
    Friend WithEvents Label8 As Label
End Class
