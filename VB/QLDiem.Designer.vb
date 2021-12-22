<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLDiem
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemT4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemT10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New VB.DataSet1()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet11 = New VB.DataSet1()
        Me.DiemTableAdapter = New VB.DataSet1TableAdapters.DiemTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMaMon = New System.Windows.Forms.TextBox()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtDiemChu = New System.Windows.Forms.TextBox()
        Me.txtDiemT4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDiemT10 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.MaMHDataGridViewTextBoxColumn, Me.DiemT4DataGridViewTextBoxColumn, Me.DiemChuDataGridViewTextBoxColumn, Me.DiemT10DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DiemBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1012, 392)
        Me.DataGridView1.TabIndex = 0
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.Width = 120
        '
        'MaMHDataGridViewTextBoxColumn
        '
        Me.MaMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.HeaderText = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaMHDataGridViewTextBoxColumn.Name = "MaMHDataGridViewTextBoxColumn"
        Me.MaMHDataGridViewTextBoxColumn.Width = 120
        '
        'DiemT4DataGridViewTextBoxColumn
        '
        Me.DiemT4DataGridViewTextBoxColumn.DataPropertyName = "DiemT4"
        Me.DiemT4DataGridViewTextBoxColumn.HeaderText = "DiemT4"
        Me.DiemT4DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemT4DataGridViewTextBoxColumn.Name = "DiemT4DataGridViewTextBoxColumn"
        Me.DiemT4DataGridViewTextBoxColumn.Width = 120
        '
        'DiemChuDataGridViewTextBoxColumn
        '
        Me.DiemChuDataGridViewTextBoxColumn.DataPropertyName = "DiemChu"
        Me.DiemChuDataGridViewTextBoxColumn.HeaderText = "DiemChu"
        Me.DiemChuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemChuDataGridViewTextBoxColumn.Name = "DiemChuDataGridViewTextBoxColumn"
        Me.DiemChuDataGridViewTextBoxColumn.Width = 120
        '
        'DiemT10DataGridViewTextBoxColumn
        '
        Me.DiemT10DataGridViewTextBoxColumn.DataPropertyName = "DiemT10"
        Me.DiemT10DataGridViewTextBoxColumn.HeaderText = "DiemT10"
        Me.DiemT10DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiemT10DataGridViewTextBoxColumn.Name = "DiemT10DataGridViewTextBoxColumn"
        Me.DiemT10DataGridViewTextBoxColumn.Width = 120
        '
        'DiemBindingSource
        '
        Me.DiemBindingSource.DataMember = "Diem"
        Me.DiemBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Diem.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Diem"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-IJCO63N\SQLEXPRESS;Persist Security Info=" &
    "True;Password=1234;User ID=sa;Initial Catalog=DoAnVB"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Diem] ([MaSV], [MaMH], [DiemT4], [DiemChu], [DiemT10]) VALUES (?, ?," &
    " ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("DiemT4", System.Data.OleDb.OleDbType.[Double], 0, "DiemT4"), New System.Data.OleDb.OleDbParameter("DiemChu", System.Data.OleDb.OleDbType.VarChar, 0, "DiemChu"), New System.Data.OleDb.OleDbParameter("DiemT10", System.Data.OleDb.OleDbType.[Double], 0, "DiemT10")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Diem] SET [MaSV] = ?, [MaMH] = ?, [DiemT4] = ?, [DiemChu] = ?, [DiemT10] " &
    "= ? WHERE (([MaSV] = ?) AND ([MaMH] = ?) AND ([DiemT4] = ?) AND ([DiemChu] = ?) " &
    "AND ([DiemT10] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("DiemT4", System.Data.OleDb.OleDbType.[Double], 0, "DiemT4"), New System.Data.OleDb.OleDbParameter("DiemChu", System.Data.OleDb.OleDbType.VarChar, 0, "DiemChu"), New System.Data.OleDb.OleDbParameter("DiemT10", System.Data.OleDb.OleDbType.[Double], 0, "DiemT10"), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemT4", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemT4", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemChu", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemChu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemT10", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemT10", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Diem] WHERE (([MaSV] = ?) AND ([MaMH] = ?) AND ([DiemT4] = ?) AND ([" &
    "DiemChu] = ?) AND ([DiemT10] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemT4", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemT4", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemChu", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemChu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemT10", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemT10", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Diem", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSV", "MaSV"), New System.Data.Common.DataColumnMapping("MaMH", "MaMH"), New System.Data.Common.DataColumnMapping("DiemT4", "DiemT4"), New System.Data.Common.DataColumnMapping("DiemChu", "DiemChu"), New System.Data.Common.DataColumnMapping("DiemT10", "DiemT10")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiemTableAdapter
        '
        Me.DiemTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 229)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 25)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Điểm thang 10:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(426, 60)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 25)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Điểm thang 4:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(426, 148)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 25)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Điểm chữ:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 25)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 25)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Mã môn học:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 121)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 25)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Mã Sv:"
        '
        'txtMaMon
        '
        Me.txtMaMon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiemBindingSource, "MaMH", True))
        Me.txtMaMon.Location = New System.Drawing.Point(150, 25)
        Me.txtMaMon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaMon.Multiline = True
        Me.txtMaMon.Name = "txtMaMon"
        Me.txtMaMon.Size = New System.Drawing.Size(200, 45)
        Me.txtMaMon.TabIndex = 56
        '
        'txtMaSV
        '
        Me.txtMaSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiemBindingSource, "MaSV", True))
        Me.txtMaSV.Location = New System.Drawing.Point(150, 118)
        Me.txtMaSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaSV.Multiline = True
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(200, 45)
        Me.txtMaSV.TabIndex = 57
        '
        'txtDiemChu
        '
        Me.txtDiemChu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiemBindingSource, "DiemChu", True))
        Me.txtDiemChu.Location = New System.Drawing.Point(572, 143)
        Me.txtDiemChu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiemChu.Multiline = True
        Me.txtDiemChu.Name = "txtDiemChu"
        Me.txtDiemChu.Size = New System.Drawing.Size(169, 45)
        Me.txtDiemChu.TabIndex = 58
        '
        'txtDiemT4
        '
        Me.txtDiemT4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiemBindingSource, "DiemT4", True))
        Me.txtDiemT4.Location = New System.Drawing.Point(572, 40)
        Me.txtDiemT4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiemT4.Multiline = True
        Me.txtDiemT4.Name = "txtDiemT4"
        Me.txtDiemT4.Size = New System.Drawing.Size(170, 45)
        Me.txtDiemT4.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(854, 148)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 60)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Xoá"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(854, 78)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 60)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(854, 9)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 60)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "Thêm"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtDiemT10
        '
        Me.txtDiemT10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiemBindingSource, "DiemT10", True))
        Me.txtDiemT10.Location = New System.Drawing.Point(150, 218)
        Me.txtDiemT10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiemT10.Multiline = True
        Me.txtDiemT10.Name = "txtDiemT10"
        Me.txtDiemT10.Size = New System.Drawing.Size(200, 45)
        Me.txtDiemT10.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.txtDiemT10)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtDiemT4)
        Me.Panel2.Controls.Add(Me.txtDiemChu)
        Me.Panel2.Controls.Add(Me.txtMaSV)
        Me.Panel2.Controls.Add(Me.txtMaMon)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(22, 420)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 280)
        Me.Panel2.TabIndex = 38
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(855, 218)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 60)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Thoát"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'QLDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1048, 713)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "QLDiem"
        Me.Text = "Quản lý Điểm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DiemBindingSource As BindingSource
    Friend WithEvents DiemTableAdapter As DataSet1TableAdapters.DiemTableAdapter
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemT4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemT10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMaMon As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtDiemChu As TextBox
    Friend WithEvents txtDiemT4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtDiemT10 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
End Class
