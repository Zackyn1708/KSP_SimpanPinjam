<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        lblJudulAnggota = New Label()
        dgvAnggota = New DataGridView()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnRefresh = New Button()
        btnKembali = New Button()
        pnlSidebar = New Panel()
        btnPembayaran = New Button()
        btnAngsuran = New Button()
        btnPinjaman = New Button()
        btnSimpanan = New Button()
        btnAnggota = New Button()
        btnDashboard = New Button()
        lblJudul = New Label()
        CType(dgvAnggota, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudulAnggota
        ' 
        lblJudulAnggota.AutoSize = True
        lblJudulAnggota.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulAnggota.ForeColor = Color.MidnightBlue
        lblJudulAnggota.Location = New Point(344, 28)
        lblJudulAnggota.Name = "lblJudulAnggota"
        lblJudulAnggota.Size = New Size(405, 46)
        lblJudulAnggota.TabIndex = 0
        lblJudulAnggota.Text = "Data Anggota Koperasi\"
        ' 
        ' dgvAnggota
        ' 
        dgvAnggota.AllowUserToAddRows = False
        dgvAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAnggota.BackgroundColor = Color.White
        dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnggota.Location = New Point(344, 150)
        dgvAnggota.MultiSelect = False
        dgvAnggota.Name = "dgvAnggota"
        dgvAnggota.ReadOnly = True
        dgvAnggota.RowHeadersWidth = 51
        dgvAnggota.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAnggota.Size = New Size(686, 400)
        dgvAnggota.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(344, 95)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 35)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(450, 95)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(100, 35)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(556, 95)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 35)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(662, 95)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 35)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(930, 95)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(100, 35)
        btnKembali.TabIndex = 6
        btnKembali.Text = "Back"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.MidnightBlue
        pnlSidebar.Controls.Add(btnPembayaran)
        pnlSidebar.Controls.Add(btnAngsuran)
        pnlSidebar.Controls.Add(btnPinjaman)
        pnlSidebar.Controls.Add(btnSimpanan)
        pnlSidebar.Controls.Add(btnAnggota)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(lblJudul)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(278, 603)
        pnlSidebar.TabIndex = 7
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.Cursor = Cursors.Hand
        btnPembayaran.FlatStyle = FlatStyle.Flat
        btnPembayaran.ForeColor = Color.White
        btnPembayaran.Location = New Point(20, 330)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(180, 40)
        btnPembayaran.TabIndex = 6
        btnPembayaran.Text = "Pembayaran"
        btnPembayaran.TextAlign = ContentAlignment.MiddleLeft
        btnPembayaran.UseVisualStyleBackColor = True
        ' 
        ' btnAngsuran
        ' 
        btnAngsuran.Cursor = Cursors.Hand
        btnAngsuran.FlatStyle = FlatStyle.Flat
        btnAngsuran.ForeColor = Color.White
        btnAngsuran.Location = New Point(20, 280)
        btnAngsuran.Name = "btnAngsuran"
        btnAngsuran.Size = New Size(180, 40)
        btnAngsuran.TabIndex = 5
        btnAngsuran.Text = "Angsuran"
        btnAngsuran.TextAlign = ContentAlignment.MiddleLeft
        btnAngsuran.UseVisualStyleBackColor = True
        ' 
        ' btnPinjaman
        ' 
        btnPinjaman.Cursor = Cursors.Hand
        btnPinjaman.FlatStyle = FlatStyle.Flat
        btnPinjaman.ForeColor = Color.White
        btnPinjaman.Location = New Point(20, 230)
        btnPinjaman.Name = "btnPinjaman"
        btnPinjaman.Size = New Size(180, 40)
        btnPinjaman.TabIndex = 4
        btnPinjaman.Text = "Pinjaman"
        btnPinjaman.TextAlign = ContentAlignment.MiddleLeft
        btnPinjaman.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanan
        ' 
        btnSimpanan.Cursor = Cursors.Hand
        btnSimpanan.FlatStyle = FlatStyle.Flat
        btnSimpanan.ForeColor = Color.White
        btnSimpanan.Location = New Point(20, 180)
        btnSimpanan.Name = "btnSimpanan"
        btnSimpanan.Size = New Size(180, 40)
        btnSimpanan.TabIndex = 3
        btnSimpanan.Text = "Simpanan"
        btnSimpanan.TextAlign = ContentAlignment.MiddleLeft
        btnSimpanan.UseVisualStyleBackColor = True
        ' 
        ' btnAnggota
        ' 
        btnAnggota.BackColor = Color.RoyalBlue
        btnAnggota.Cursor = Cursors.Hand
        btnAnggota.FlatStyle = FlatStyle.Flat
        btnAnggota.ForeColor = Color.White
        btnAnggota.Location = New Point(20, 130)
        btnAnggota.Name = "btnAnggota"
        btnAnggota.Size = New Size(180, 40)
        btnAnggota.TabIndex = 2
        btnAnggota.Text = "Data Anggota"
        btnAnggota.TextAlign = ContentAlignment.MiddleLeft
        btnAnggota.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.MidnightBlue
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(20, 80)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(180, 40)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(3, 23)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(243, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "KSP SIMPAN PINJAM"
        ' 
        ' FormAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1082, 603)
        Controls.Add(pnlSidebar)
        Controls.Add(btnKembali)
        Controls.Add(btnRefresh)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnTambah)
        Controls.Add(dgvAnggota)
        Controls.Add(lblJudulAnggota)
        Name = "FormAnggota"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Anggota Koperasi"
        CType(dgvAnggota, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulAnggota As Label
    Friend WithEvents dgvAnggota As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnAngsuran As Button
    Friend WithEvents btnPinjaman As Button
    Friend WithEvents btnSimpanan As Button
    Friend WithEvents btnAnggota As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblJudul As Label
End Class
