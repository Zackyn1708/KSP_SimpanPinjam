<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        btnExport = New Button()
        btnCetakTop = New Button()
        btnTambahTop = New Button()
        btnCari = New Button()
        cmbFilter = New ComboBox()
        lblFilter = New Label()
        txtSearch = New TextBox()
        dgvAnggota = New DataGridView()
        colFoto = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colAlamat = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        btnKembali = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvAnggota, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(18), CByte(125), CByte(135))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 105)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(15, 0, 0, 0)
        Label1.Size = New Size(982, 105)
        Label1.TabIndex = 0
        Label1.Text = "DATA ANGGOTA"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(btnCetakTop)
        Panel2.Controls.Add(btnTambahTop)
        Panel2.Controls.Add(btnCari)
        Panel2.Controls.Add(cmbFilter)
        Panel2.Controls.Add(lblFilter)
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 105)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(982, 81)
        Panel2.TabIndex = 1
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(870, 14)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(94, 29)
        btnExport.TabIndex = 6
        btnExport.Text = "Export Excel"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnCetakTop
        ' 
        btnCetakTop.Location = New Point(770, 14)
        btnCetakTop.Name = "btnCetakTop"
        btnCetakTop.Size = New Size(94, 29)
        btnCetakTop.TabIndex = 5
        btnCetakTop.Text = "Cetak"
        btnCetakTop.UseVisualStyleBackColor = True
        ' 
        ' btnTambahTop
        ' 
        btnTambahTop.Location = New Point(670, 14)
        btnTambahTop.Name = "btnTambahTop"
        btnTambahTop.Size = New Size(94, 29)
        btnTambahTop.TabIndex = 4
        btnTambahTop.Text = "Tambah"
        btnTambahTop.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(570, 14)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(94, 29)
        btnCari.TabIndex = 3
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' cmbFilter
        ' 
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {"Aktif", "Pasif"})
        cmbFilter.Location = New Point(384, 17)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(150, 28)
        cmbFilter.TabIndex = 2
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(333, 20)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(45, 20)
        lblFilter.TabIndex = 1
        lblFilter.Text = "Filter:"
        ' 
        ' txtSearch
        ' 
        txtSearch.ForeColor = SystemColors.ScrollBar
        txtSearch.Location = New Point(20, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(300, 27)
        txtSearch.TabIndex = 0
        txtSearch.Text = "Search..."
        ' 
        ' dgvAnggota
        ' 
        dgvAnggota.AllowUserToAddRows = False
        dgvAnggota.AllowUserToDeleteRows = False
        dgvAnggota.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAnggota.BackgroundColor = Color.White
        dgvAnggota.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(8), CByte(120), CByte(201))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAnggota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAnggota.ColumnHeadersHeight = 45
        dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAnggota.Columns.AddRange(New DataGridViewColumn() {colFoto, colID, colNama, colAlamat, colStatus})
        dgvAnggota.EnableHeadersVisualStyles = False
        dgvAnggota.Location = New Point(12, 192)
        dgvAnggota.MultiSelect = False
        dgvAnggota.Name = "dgvAnggota"
        dgvAnggota.ReadOnly = True
        dgvAnggota.RowHeadersWidth = 51
        dgvAnggota.RowTemplate.Height = 55
        dgvAnggota.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAnggota.Size = New Size(958, 346)
        dgvAnggota.TabIndex = 2
        ' 
        ' colFoto
        ' 
        colFoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        colFoto.HeaderText = "Foto Anggota"
        colFoto.MinimumWidth = 6
        colFoto.Name = "colFoto"
        colFoto.ReadOnly = True
        colFoto.Width = 155
        ' 
        ' colID
        ' 
        colID.HeaderText = "ID"
        colID.MinimumWidth = 6
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colAlamat
        ' 
        colAlamat.HeaderText = "Alamat"
        colAlamat.MinimumWidth = 6
        colAlamat.Name = "colAlamat"
        colAlamat.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(btnKembali)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Button2)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 528)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(982, 75)
        Panel3.TabIndex = 3
        ' 
        ' btnKembali
        ' 
        btnKembali.AutoSize = True
        btnKembali.Location = New Point(22, 16)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(152, 30)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali ke Beranda"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(876, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Cetak"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(776, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Tambah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(982, 603)
        Controls.Add(Panel3)
        Controls.Add(dgvAnggota)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form Anggota"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvAnggota, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambahTop As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnCetakTop As Button
    Friend WithEvents dgvAnggota As DataGridView
    Friend WithEvents colFoto As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colAlamat As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnKembali As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
