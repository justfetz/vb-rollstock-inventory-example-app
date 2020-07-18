<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridForm))
        Me.RollstockForecastBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RsDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RsData = New RollStockExampleApp.rsData()
        Me.RollstockTargetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BQMESILBP132DataSet = New RollStockExampleApp.BQMESILBP132DataSet()
        Me.RollstockTargetTableAdapter = New RollStockExampleApp.BQMESILBP132DataSetTableAdapters.RollstockTargetTableAdapter()
        Me.RollstockForecastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RollstockForecastTableAdapter = New RollStockExampleApp.rsDataTableAdapters.RollstockForecastTableAdapter()
        Me.RollstockForecastBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.RollstockForecastBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RollstockForecastBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RollstockForecastBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.RollstockForecastBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RsDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockTargetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BQMESILBP132DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockForecastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockForecastBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockForecastBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockForecastBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollstockForecastBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RollstockForecastBindingSource1
        '
        Me.RollstockForecastBindingSource1.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource1.DataSource = Me.RsDataBindingSource
        '
        'RsDataBindingSource
        '
        Me.RsDataBindingSource.DataSource = Me.RsData
        Me.RsDataBindingSource.Position = 0
        '
        'RsData
        '
        Me.RsData.DataSetName = "rsData"
        Me.RsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RollstockTargetBindingSource
        '
        Me.RollstockTargetBindingSource.DataMember = "RollstockTarget"
        Me.RollstockTargetBindingSource.DataSource = Me.BQMESILBP132DataSet
        '
        'BQMESILBP132DataSet
        '
        Me.BQMESILBP132DataSet.DataSetName = "BQMESILBP132DataSet"
        Me.BQMESILBP132DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RollstockTargetTableAdapter
        '
        Me.RollstockTargetTableAdapter.ClearBeforeFill = True
        '
        'RollstockForecastBindingSource
        '
        Me.RollstockForecastBindingSource.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource.DataSource = Me.RsDataBindingSource
        '
        'RollstockForecastTableAdapter
        '
        Me.RollstockForecastTableAdapter.ClearBeforeFill = True
        '
        'RollstockForecastBindingSource2
        '
        Me.RollstockForecastBindingSource2.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource2.DataSource = Me.RsDataBindingSource
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.RollstockForecastBindingSource5
        Me.C1FlexGrid1.Location = New System.Drawing.Point(21, 58)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Size = New System.Drawing.Size(866, 373)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(173, 457)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(556, 36)
        Me.C1Button1.TabIndex = 1
        Me.C1Button1.Text = "Close"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'RollstockForecastBindingSource3
        '
        Me.RollstockForecastBindingSource3.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource3.DataSource = Me.RsDataBindingSource
        '
        'RollstockForecastBindingSource4
        '
        Me.RollstockForecastBindingSource4.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource4.DataSource = Me.RsDataBindingSource
        '
        'RollstockForecastBindingSource5
        '
        Me.RollstockForecastBindingSource5.DataMember = "RollstockForecast"
        Me.RollstockForecastBindingSource5.DataSource = Me.RsDataBindingSource
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(907, 38)
        Me.FillByToolStrip.TabIndex = 2
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(175, 33)
        Me.FillByToolStripButton.Text = "Show This Year Only"
        '
        'GridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 520)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Name = "GridForm"
        Me.Text = "GridForm"
        CType(Me.RollstockForecastBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RsDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockTargetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BQMESILBP132DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockForecastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockForecastBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockForecastBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockForecastBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollstockForecastBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BQMESILBP132DataSet As BQMESILBP132DataSet
    Friend WithEvents RollstockTargetBindingSource As BindingSource
    Friend WithEvents RollstockTargetTableAdapter As BQMESILBP132DataSetTableAdapters.RollstockTargetTableAdapter
    Friend WithEvents RsDataBindingSource As BindingSource
    Friend WithEvents RsData As rsData
    Friend WithEvents RollstockForecastBindingSource As BindingSource
    Friend WithEvents RollstockForecastTableAdapter As rsDataTableAdapters.RollstockForecastTableAdapter
    Friend WithEvents RollstockForecastBindingSource1 As BindingSource
    Friend WithEvents RollstockForecastBindingSource2 As BindingSource
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents RollstockForecastBindingSource3 As BindingSource
    Friend WithEvents RollstockForecastBindingSource4 As BindingSource
    Friend WithEvents RollstockForecastBindingSource5 As BindingSource
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
