<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SV
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataSet2 = New VB.DataSet2()
        Me.XemDiemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XemDiemTableAdapter = New VB.DataSet2TableAdapters.XemDiemTableAdapter()
        Me.HoTenSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemT4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemT10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XemDiemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoTenSVDataGridViewTextBoxColumn, Me.TenMHDataGridViewTextBoxColumn, Me.DiemT4DataGridViewTextBoxColumn, Me.DiemChuDataGridViewTextBoxColumn, Me.DiemT10DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.XemDiemBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1248, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(5, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 461)
        Me.Panel1.TabIndex = 2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XemDiemBindingSource
        '
        Me.XemDiemBindingSource.DataMember = "XemDiem"
        Me.XemDiemBindingSource.DataSource = Me.DataSet2
        '
        'XemDiemTableAdapter
        '
        Me.XemDiemTableAdapter.ClearBeforeFill = True
        '
        'HoTenSVDataGridViewTextBoxColumn
        '
        Me.HoTenSVDataGridViewTextBoxColumn.DataPropertyName = "HoTenSV"
        Me.HoTenSVDataGridViewTextBoxColumn.HeaderText = "Họ và tên"
        Me.HoTenSVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HoTenSVDataGridViewTextBoxColumn.Name = "HoTenSVDataGridViewTextBoxColumn"
        Me.HoTenSVDataGridViewTextBoxColumn.Width = 150
        '
        'TenMHDataGridViewTextBoxColumn
        '
        Me.TenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH"
        Me.TenMHDataGridViewTextBoxColumn.HeaderText = "Tên Môn học"
        Me.TenMHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenMHDataGridViewTextBoxColumn.Name = "TenMHDataGridViewTextBoxColumn"
        Me.TenMHDataGridViewTextBoxColumn.Width = 150
        '
        'DiemT4DataGridViewTextBoxColumn
        '
        Me.DiemT4DataGridViewTextBoxColumn.DataPropertyName = "DiemT4"
        Me.DiemT4DataGridViewTextBoxColumn.HeaderText = "Điểm thang 4"
        Me.DiemT4DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemT4DataGridViewTextBoxColumn.Name = "DiemT4DataGridViewTextBoxColumn"
        Me.DiemT4DataGridViewTextBoxColumn.Width = 150
        '
        'DiemChuDataGridViewTextBoxColumn
        '
        Me.DiemChuDataGridViewTextBoxColumn.DataPropertyName = "DiemChu"
        Me.DiemChuDataGridViewTextBoxColumn.HeaderText = "Điểm chữ"
        Me.DiemChuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemChuDataGridViewTextBoxColumn.Name = "DiemChuDataGridViewTextBoxColumn"
        Me.DiemChuDataGridViewTextBoxColumn.Width = 150
        '
        'DiemT10DataGridViewTextBoxColumn
        '
        Me.DiemT10DataGridViewTextBoxColumn.DataPropertyName = "DiemT10"
        Me.DiemT10DataGridViewTextBoxColumn.HeaderText = "Điểm thang 10"
        Me.DiemT10DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemT10DataGridViewTextBoxColumn.Name = "DiemT10DataGridViewTextBoxColumn"
        Me.DiemT10DataGridViewTextBoxColumn.Width = 150
        '
        'SV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1272, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SV"
        Me.Text = "SV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XemDiemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents XemDiemBindingSource As BindingSource
    Friend WithEvents XemDiemTableAdapter As DataSet2TableAdapters.XemDiemTableAdapter
    Friend WithEvents HoTenSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemT4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemT10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
