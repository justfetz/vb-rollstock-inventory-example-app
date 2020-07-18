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
        Me.components = New System.ComponentModel.Container()
        Me.lstTargetID = New System.Windows.Forms.ListBox()
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.lstWorkDays = New System.Windows.Forms.ListBox()
        Me.lstTons = New System.Windows.Forms.ListBox()
        Me.btnAddForm1 = New System.Windows.Forms.Button()
        Me.btnDeleteForm1 = New System.Windows.Forms.Button()
        Me.BQMESILBP132DataSet = New RollStockExampleApp.BQMESILBP132DataSet()
        Me.RollstockTargetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RollstockTargetTableAdapter = New RollStockExampleApp.BQMESILBP132DataSetTableAdapters.RollstockTargetTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridButton = New System.Windows.Forms.Button()
        CType(Me.BQMESILBP132DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockTargetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTargetID
        '
        Me.lstTargetID.FormattingEnabled = True
        Me.lstTargetID.ItemHeight = 20
        Me.lstTargetID.Location = New System.Drawing.Point(41, 53)
        Me.lstTargetID.Name = "lstTargetID"
        Me.lstTargetID.Size = New System.Drawing.Size(121, 264)
        Me.lstTargetID.TabIndex = 0
        '
        'lstDate
        '
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.ItemHeight = 20
        Me.lstDate.Location = New System.Drawing.Point(217, 53)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(121, 264)
        Me.lstDate.TabIndex = 1
        '
        'lstWorkDays
        '
        Me.lstWorkDays.FormattingEnabled = True
        Me.lstWorkDays.ItemHeight = 20
        Me.lstWorkDays.Location = New System.Drawing.Point(375, 53)
        Me.lstWorkDays.Name = "lstWorkDays"
        Me.lstWorkDays.Size = New System.Drawing.Size(121, 264)
        Me.lstWorkDays.TabIndex = 2
        '
        'lstTons
        '
        Me.lstTons.FormattingEnabled = True
        Me.lstTons.ItemHeight = 20
        Me.lstTons.Location = New System.Drawing.Point(549, 53)
        Me.lstTons.Name = "lstTons"
        Me.lstTons.Size = New System.Drawing.Size(121, 264)
        Me.lstTons.TabIndex = 3
        '
        'btnAddForm1
        '
        Me.btnAddForm1.Location = New System.Drawing.Point(41, 355)
        Me.btnAddForm1.Name = "btnAddForm1"
        Me.btnAddForm1.Size = New System.Drawing.Size(121, 58)
        Me.btnAddForm1.TabIndex = 4
        Me.btnAddForm1.Text = "Add"
        Me.btnAddForm1.UseVisualStyleBackColor = True
        '
        'btnDeleteForm1
        '
        Me.btnDeleteForm1.Location = New System.Drawing.Point(549, 355)
        Me.btnDeleteForm1.Name = "btnDeleteForm1"
        Me.btnDeleteForm1.Size = New System.Drawing.Size(121, 58)
        Me.btnDeleteForm1.TabIndex = 5
        Me.btnDeleteForm1.Text = "Delete"
        Me.btnDeleteForm1.UseVisualStyleBackColor = True
        '
        'BQMESILBP132DataSet
        '
        Me.BQMESILBP132DataSet.DataSetName = "BQMESILBP132DataSet"
        Me.BQMESILBP132DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RollstockTargetBindingSource
        '
        Me.RollstockTargetBindingSource.DataMember = "RollstockTarget"
        Me.RollstockTargetBindingSource.DataSource = Me.BQMESILBP132DataSet
        '
        'RollstockTargetTableAdapter
        '
        Me.RollstockTargetTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 58)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 36)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 32)
        Me.ToolStripMenuItem1.Text = "Delete This?"
        '
        'gridButton
        '
        Me.gridButton.Location = New System.Drawing.Point(375, 355)
        Me.gridButton.Name = "gridButton"
        Me.gridButton.Size = New System.Drawing.Size(121, 58)
        Me.gridButton.TabIndex = 7
        Me.gridButton.Text = "Show In C1 Grid"
        Me.gridButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 450)
        Me.Controls.Add(Me.gridButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDeleteForm1)
        Me.Controls.Add(Me.btnAddForm1)
        Me.Controls.Add(Me.lstTons)
        Me.Controls.Add(Me.lstWorkDays)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.lstTargetID)
        Me.Name = "Form1"
        Me.Text = "Inventory"
        CType(Me.BQMESILBP132DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockTargetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTargetID As ListBox
    Friend WithEvents lstDate As ListBox
    Friend WithEvents lstWorkDays As ListBox
    Friend WithEvents lstTons As ListBox
    Friend WithEvents btnAddForm1 As Button
    Friend WithEvents btnDeleteForm1 As Button
    Friend WithEvents BQMESILBP132DataSet As BQMESILBP132DataSet
    Friend WithEvents RollstockTargetBindingSource As BindingSource
    Friend WithEvents RollstockTargetTableAdapter As BQMESILBP132DataSetTableAdapters.RollstockTargetTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents gridButton As Button
End Class
