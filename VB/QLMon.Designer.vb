<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLMon
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenMon = New System.Windows.Forms.TextBox()
        Me.txtMaMon = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DataSet11 = New VB.DataSet1()
        Me.DMMHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMMHTableAdapter = New VB.DataSet1TableAdapters.DMMHTableAdapter()
        Me.MaMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTietDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtSoTiet = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMMHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(812, 377)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 60)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "Thoát"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(13, 377)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 60)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Thêm"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(284, 377)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 60)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(551, 377)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 60)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Xoá"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(706, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Tên Môn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(706, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Số Tiết:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(706, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Mã Môn:"
        '
        'txtTenMon
        '
        Me.txtTenMon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMMHBindingSource, "TenMH", True))
        Me.txtTenMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenMon.Location = New System.Drawing.Point(799, 170)
        Me.txtTenMon.Multiline = True
        Me.txtTenMon.Name = "txtTenMon"
        Me.txtTenMon.Size = New System.Drawing.Size(166, 45)
        Me.txtTenMon.TabIndex = 71
        '
        'txtMaMon
        '
        Me.txtMaMon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMMHBindingSource, "MaMH", True))
        Me.txtMaMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaMon.Location = New System.Drawing.Point(799, 83)
        Me.txtMaMon.Multiline = True
        Me.txtMaMon.Name = "txtMaMon"
        Me.txtMaMon.Size = New System.Drawing.Size(166, 45)
        Me.txtMaMon.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMHDataGridViewTextBoxColumn, Me.TenMHDataGridViewTextBoxColumn, Me.SoTietDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DMMHBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(666, 338)
        Me.DataGridView1.TabIndex = 77
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT DMMH.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   DMMH"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DMMH] ([MaMH], [TenMH], [SoTiet]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenMH"), New System.Data.OleDb.OleDbParameter("SoTiet", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "SoTiet")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [DMMH] SET [MaMH] = ?, [TenMH] = ?, [SoTiet] = ? WHERE (([MaMH] = ?) AND (" &
    "[TenMH] = ?) AND ((? = 1 AND [SoTiet] IS NULL) OR ([SoTiet] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenMH"), New System.Data.OleDb.OleDbParameter("SoTiet", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "SoTiet"), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoTiet", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoTiet", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoTiet", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoTiet", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [DMMH] WHERE (([MaMH] = ?) AND ([TenMH] = ?) AND ((? = 1 AND [SoTiet]" &
    " IS NULL) OR ([SoTiet] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoTiet", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoTiet", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoTiet", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoTiet", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMMH", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaMH", "MaMH"), New System.Data.Common.DataColumnMapping("TenMH", "TenMH"), New System.Data.Common.DataColumnMapping("SoTiet", "SoTiet")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-IJCO63N\SQLEXPRESS;Persist Security Info=" &
    "True;Password=1234;User ID=sa;Initial Catalog=DoAnVB"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DMMHBindingSource
        '
        Me.DMMHBindingSource.DataMember = "DMMH"
        Me.DMMHBindingSource.DataSource = Me.DataSet11
        '
        'DMMHTableAdapter
        '
        Me.DMMHTableAdapter.ClearBeforeFill = True
        '
        'MaMHDataGridViewTextBoxColumn
        '
        Me.MaMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.HeaderText = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaMHDataGridViewTextBoxColumn.Name = "MaMHDataGridViewTextBoxColumn"
        Me.MaMHDataGridViewTextBoxColumn.Width = 150
        '
        'TenMHDataGridViewTextBoxColumn
        '
        Me.TenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH"
        Me.TenMHDataGridViewTextBoxColumn.HeaderText = "TenMH"
        Me.TenMHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenMHDataGridViewTextBoxColumn.Name = "TenMHDataGridViewTextBoxColumn"
        Me.TenMHDataGridViewTextBoxColumn.Width = 150
        '
        'SoTietDataGridViewTextBoxColumn
        '
        Me.SoTietDataGridViewTextBoxColumn.DataPropertyName = "SoTiet"
        Me.SoTietDataGridViewTextBoxColumn.HeaderText = "SoTiet"
        Me.SoTietDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SoTietDataGridViewTextBoxColumn.Name = "SoTietDataGridViewTextBoxColumn"
        Me.SoTietDataGridViewTextBoxColumn.Width = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtSoTiet
        '
        Me.txtSoTiet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMMHBindingSource, "SoTiet", True))
        Me.txtSoTiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTiet.Location = New System.Drawing.Point(799, 258)
        Me.txtSoTiet.Multiline = True
        Me.txtSoTiet.Name = "txtSoTiet"
        Me.txtSoTiet.Size = New System.Drawing.Size(167, 45)
        Me.txtSoTiet.TabIndex = 79
        '
        'QLMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(978, 467)
        Me.Controls.Add(Me.txtSoTiet)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTenMon)
        Me.Controls.Add(Me.txtMaMon)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "QLMon"
        Me.Text = "QLMon"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMMHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenMon As TextBox
    Friend WithEvents txtMaMon As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DMMHBindingSource As BindingSource
    Friend WithEvents DMMHTableAdapter As DataSet1TableAdapters.DMMHTableAdapter
    Friend WithEvents MaMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoTietDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtSoTiet As TextBox
End Class
