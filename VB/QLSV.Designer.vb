<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLSV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLSV))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiSinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DMSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New VB.DataSet1()
        Me.pnsv2 = New System.Windows.Forms.Panel()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoiSinh = New System.Windows.Forms.TextBox()
        Me.rdNu = New System.Windows.Forms.RadioButton()
        Me.rdNam = New System.Windows.Forms.RadioButton()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtTenSV = New System.Windows.Forms.TextBox()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DMSVTableAdapter = New VB.DataSet1TableAdapters.DMSVTableAdapter()
        Me.DataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnsv2.SuspendLayout()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.HoTenSVDataGridViewTextBoxColumn, Me.PhaiDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.NoiSinhDataGridViewTextBoxColumn, Me.LopDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DMSVBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1054, 460)
        Me.DataGridView1.TabIndex = 0
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.Width = 150
        '
        'HoTenSVDataGridViewTextBoxColumn
        '
        Me.HoTenSVDataGridViewTextBoxColumn.DataPropertyName = "HoTenSV"
        Me.HoTenSVDataGridViewTextBoxColumn.HeaderText = "HoTenSV"
        Me.HoTenSVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HoTenSVDataGridViewTextBoxColumn.Name = "HoTenSVDataGridViewTextBoxColumn"
        Me.HoTenSVDataGridViewTextBoxColumn.Width = 150
        '
        'PhaiDataGridViewTextBoxColumn
        '
        Me.PhaiDataGridViewTextBoxColumn.DataPropertyName = "Phai"
        Me.PhaiDataGridViewTextBoxColumn.HeaderText = "Phai"
        Me.PhaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhaiDataGridViewTextBoxColumn.Name = "PhaiDataGridViewTextBoxColumn"
        Me.PhaiDataGridViewTextBoxColumn.Width = 150
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 150
        '
        'NoiSinhDataGridViewTextBoxColumn
        '
        Me.NoiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh"
        Me.NoiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh"
        Me.NoiSinhDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NoiSinhDataGridViewTextBoxColumn.Name = "NoiSinhDataGridViewTextBoxColumn"
        Me.NoiSinhDataGridViewTextBoxColumn.Width = 150
        '
        'LopDataGridViewTextBoxColumn
        '
        Me.LopDataGridViewTextBoxColumn.DataPropertyName = "Lop"
        Me.LopDataGridViewTextBoxColumn.HeaderText = "Lop"
        Me.LopDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LopDataGridViewTextBoxColumn.Name = "LopDataGridViewTextBoxColumn"
        Me.LopDataGridViewTextBoxColumn.Width = 150
        '
        'DMSVBindingSource
        '
        Me.DMSVBindingSource.DataMember = "DMSV"
        Me.DMSVBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnsv2
        '
        Me.pnsv2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnsv2.Controls.Add(Me.txtLop)
        Me.pnsv2.Controls.Add(Me.Button4)
        Me.pnsv2.Controls.Add(Me.Button3)
        Me.pnsv2.Controls.Add(Me.Button2)
        Me.pnsv2.Controls.Add(Me.Button1)
        Me.pnsv2.Controls.Add(Me.Label9)
        Me.pnsv2.Controls.Add(Me.Label8)
        Me.pnsv2.Controls.Add(Me.Label7)
        Me.pnsv2.Controls.Add(Me.Label6)
        Me.pnsv2.Controls.Add(Me.Label5)
        Me.pnsv2.Controls.Add(Me.Label4)
        Me.pnsv2.Controls.Add(Me.txtNoiSinh)
        Me.pnsv2.Controls.Add(Me.rdNu)
        Me.pnsv2.Controls.Add(Me.rdNam)
        Me.pnsv2.Controls.Add(Me.txtNgaySinh)
        Me.pnsv2.Controls.Add(Me.txtTenSV)
        Me.pnsv2.Controls.Add(Me.txtMaSV)
        Me.pnsv2.Location = New System.Drawing.Point(3, 479)
        Me.pnsv2.Name = "pnsv2"
        Me.pnsv2.Size = New System.Drawing.Size(1063, 240)
        Me.pnsv2.TabIndex = 3
        '
        'txtLop
        '
        Me.txtLop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMSVBindingSource, "Lop", True))
        Me.txtLop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLop.Location = New System.Drawing.Point(603, 188)
        Me.txtLop.Multiline = True
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(148, 40)
        Me.txtLop.TabIndex = 69
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(923, 178)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 50)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "Thoát"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(923, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 50)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Thêm"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(923, 60)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 50)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(923, 118)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 50)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Xoá"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(487, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 25)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Lớp:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Ngày sinh:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(487, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Giới tính:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nơi sinh:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tên SV:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mã SV:"
        '
        'txtNoiSinh
        '
        Me.txtNoiSinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMSVBindingSource, "NoiSinh", True))
        Me.txtNoiSinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoiSinh.Location = New System.Drawing.Point(156, 188)
        Me.txtNoiSinh.Multiline = True
        Me.txtNoiSinh.Name = "txtNoiSinh"
        Me.txtNoiSinh.Size = New System.Drawing.Size(188, 40)
        Me.txtNoiSinh.TabIndex = 6
        '
        'rdNu
        '
        Me.rdNu.AutoSize = True
        Me.rdNu.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DMSVBindingSource, "Phai", True))
        Me.rdNu.Location = New System.Drawing.Point(702, 28)
        Me.rdNu.Name = "rdNu"
        Me.rdNu.Size = New System.Drawing.Size(54, 24)
        Me.rdNu.TabIndex = 5
        Me.rdNu.TabStop = True
        Me.rdNu.Text = "Nữ"
        Me.rdNu.UseVisualStyleBackColor = True
        '
        'rdNam
        '
        Me.rdNam.AutoSize = True
        Me.rdNam.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DMSVBindingSource, "Phai", True))
        Me.rdNam.Location = New System.Drawing.Point(614, 27)
        Me.rdNam.Name = "rdNam"
        Me.rdNam.Size = New System.Drawing.Size(67, 24)
        Me.rdNam.TabIndex = 4
        Me.rdNam.TabStop = True
        Me.rdNam.Text = "Nam"
        Me.rdNam.UseVisualStyleBackColor = True
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMSVBindingSource, "NgaySinh", True))
        Me.txtNgaySinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgaySinh.Location = New System.Drawing.Point(603, 102)
        Me.txtNgaySinh.Multiline = True
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(148, 40)
        Me.txtNgaySinh.TabIndex = 2
        '
        'txtTenSV
        '
        Me.txtTenSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMSVBindingSource, "HoTenSV", True))
        Me.txtTenSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSV.Location = New System.Drawing.Point(156, 102)
        Me.txtTenSV.Multiline = True
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(188, 40)
        Me.txtTenSV.TabIndex = 1
        '
        'txtMaSV
        '
        Me.txtMaSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DMSVBindingSource, "MaSV", True))
        Me.txtMaSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSV.Location = New System.Drawing.Point(156, 19)
        Me.txtMaSV.Multiline = True
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(188, 40)
        Me.txtMaSV.TabIndex = 0
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT DMSV.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   DMSV"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-IJCO63N\SQLEXPRESS;Persist Security Info=" &
    "True;Password=1234;User ID=sa;Initial Catalog=DoAnVB"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DMSV] ([MaSV], [HoTenSV], [Phai], [NgaySinh], [NoiSinh], [Lop]) VALU" &
    "ES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoTenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoTenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.VarWChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoTenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoTenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.VarWChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop"), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoTenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoTenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Lop", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoTenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoTenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Lop", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMSV", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSV", "MaSV"), New System.Data.Common.DataColumnMapping("HoTenSV", "HoTenSV"), New System.Data.Common.DataColumnMapping("Phai", "Phai"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("NoiSinh", "NoiSinh"), New System.Data.Common.DataColumnMapping("Lop", "Lop")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DMSVTableAdapter
        '
        Me.DMSVTableAdapter.ClearBeforeFill = True
        '
        'DataSet11BindingSource
        '
        Me.DataSet11BindingSource.DataSource = Me.DataSet11
        Me.DataSet11BindingSource.Position = 0
        '
        'QLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1078, 722)
        Me.Controls.Add(Me.pnsv2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "QLSV"
        Me.Text = "QLSV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnsv2.ResumeLayout(False)
        Me.pnsv2.PerformLayout()
        CType(Me.DataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnsv2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoiSinh As TextBox
    Friend WithEvents rdNu As RadioButton
    Friend WithEvents rdNam As RadioButton
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtTenSV As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DMSVBindingSource As BindingSource
    Friend WithEvents DMSVTableAdapter As DataSet1TableAdapters.DMSVTableAdapter
    Friend WithEvents DataSet11BindingSource As BindingSource
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoiSinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtLop As TextBox
End Class
