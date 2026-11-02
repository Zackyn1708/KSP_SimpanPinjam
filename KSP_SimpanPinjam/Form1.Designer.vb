<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlSidebar = New Panel()
        btnPembayaran = New Button()
        btnAngsuran = New Button()
        btnPinjaman = New Button()
        btnSimpanan = New Button()
        btnAnggota = New Button()
        btnDashboard = New Button()
        lblJudul = New Label()
        pnlKonten = New Panel()
        pnlCardAngsuran = New Panel()
        lblAngkaAngsuran = New Label()
        lblTotalAngsuran = New Label()
        pnlCardPinjaman = New Panel()
        lblAngkaPinjaman = New Label()
        lblTotalPinjaman = New Label()
        pnlCardSimpanan = New Panel()
        lblAngkaSimpanan = New Label()
        lblTotalSimpanan = New Label()
        pnlCardAnggota = New Panel()
        lblAngkaAnggota = New Label()
        lblTotalAnggota = New Label()
        lblDeskripsi = New Label()
        lblDashboard = New Label()
        pnlSidebar.SuspendLayout()
        pnlKonten.SuspendLayout()
        pnlCardAngsuran.SuspendLayout()
        pnlCardPinjaman.SuspendLayout()
        pnlCardSimpanan.SuspendLayout()
        pnlCardAnggota.SuspendLayout()
        SuspendLayout()
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
        pnlSidebar.Size = New Size(278, 553)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.Cursor = Cursors.Hand
        btnPembayaran.FlatStyle = FlatStyle.Flat
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
        btnAnggota.Cursor = Cursors.Hand
        btnAnggota.FlatStyle = FlatStyle.Flat
        btnAnggota.Location = New Point(20, 130)
        btnAnggota.Name = "btnAnggota"
        btnAnggota.Size = New Size(180, 40)
        btnAnggota.TabIndex = 2
        btnAnggota.Text = "Data Anggota"
        btnAnggota.TextAlign = ContentAlignment.MiddleLeft
        btnAnggota.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.RoyalBlue
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
        ' pnlKonten
        ' 
        pnlKonten.AutoSize = True
        pnlKonten.Controls.Add(pnlCardAngsuran)
        pnlKonten.Controls.Add(pnlCardPinjaman)
        pnlKonten.Controls.Add(pnlCardSimpanan)
        pnlKonten.Controls.Add(pnlCardAnggota)
        pnlKonten.Controls.Add(lblDeskripsi)
        pnlKonten.Controls.Add(lblDashboard)
        pnlKonten.Dock = DockStyle.Fill
        pnlKonten.Location = New Point(278, 0)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Size = New Size(1104, 553)
        pnlKonten.TabIndex = 1
        ' 
        ' pnlCardAngsuran
        ' 
        pnlCardAngsuran.BackColor = Color.Lavender
        pnlCardAngsuran.Controls.Add(lblAngkaAngsuran)
        pnlCardAngsuran.Controls.Add(lblTotalAngsuran)
        pnlCardAngsuran.Location = New Point(805, 120)
        pnlCardAngsuran.Name = "pnlCardAngsuran"
        pnlCardAngsuran.Size = New Size(220, 120)
        pnlCardAngsuran.TabIndex = 5
        ' 
        ' lblAngkaAngsuran
        ' 
        lblAngkaAngsuran.AutoSize = True
        lblAngkaAngsuran.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngkaAngsuran.ForeColor = Color.DarkSlateBlue
        lblAngkaAngsuran.Location = New Point(15, 45)
        lblAngkaAngsuran.Name = "lblAngkaAngsuran"
        lblAngkaAngsuran.Size = New Size(46, 54)
        lblAngkaAngsuran.TabIndex = 2
        lblAngkaAngsuran.Text = "0"
        ' 
        ' lblTotalAngsuran
        ' 
        lblTotalAngsuran.AutoSize = True
        lblTotalAngsuran.BackColor = Color.DarkSlateBlue
        lblTotalAngsuran.ForeColor = Color.White
        lblTotalAngsuran.Location = New Point(15, 15)
        lblTotalAngsuran.Name = "lblTotalAngsuran"
        lblTotalAngsuran.Size = New Size(153, 23)
        lblTotalAngsuran.TabIndex = 0
        lblTotalAngsuran.Text = "TOTAL ANGSURAN"
        ' 
        ' pnlCardPinjaman
        ' 
        pnlCardPinjaman.BackColor = Color.LemonChiffon
        pnlCardPinjaman.Controls.Add(lblAngkaPinjaman)
        pnlCardPinjaman.Controls.Add(lblTotalPinjaman)
        pnlCardPinjaman.Location = New Point(541, 120)
        pnlCardPinjaman.Name = "pnlCardPinjaman"
        pnlCardPinjaman.Size = New Size(220, 120)
        pnlCardPinjaman.TabIndex = 4
        ' 
        ' lblAngkaPinjaman
        ' 
        lblAngkaPinjaman.AutoSize = True
        lblAngkaPinjaman.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngkaPinjaman.ForeColor = Color.DarkGoldenrod
        lblAngkaPinjaman.Location = New Point(15, 45)
        lblAngkaPinjaman.Name = "lblAngkaPinjaman"
        lblAngkaPinjaman.Size = New Size(119, 54)
        lblAngkaPinjaman.TabIndex = 2
        lblAngkaPinjaman.Text = "Rp. 0"
        ' 
        ' lblTotalPinjaman
        ' 
        lblTotalPinjaman.AutoSize = True
        lblTotalPinjaman.BackColor = Color.DarkGoldenrod
        lblTotalPinjaman.ForeColor = Color.White
        lblTotalPinjaman.Location = New Point(15, 15)
        lblTotalPinjaman.Name = "lblTotalPinjaman"
        lblTotalPinjaman.Size = New Size(146, 23)
        lblTotalPinjaman.TabIndex = 0
        lblTotalPinjaman.Text = "TOTAL PINJAMAN"
        ' 
        ' pnlCardSimpanan
        ' 
        pnlCardSimpanan.BackColor = Color.Honeydew
        pnlCardSimpanan.Controls.Add(lblAngkaSimpanan)
        pnlCardSimpanan.Controls.Add(lblTotalSimpanan)
        pnlCardSimpanan.Location = New Point(281, 120)
        pnlCardSimpanan.Name = "pnlCardSimpanan"
        pnlCardSimpanan.Size = New Size(220, 120)
        pnlCardSimpanan.TabIndex = 3
        ' 
        ' lblAngkaSimpanan
        ' 
        lblAngkaSimpanan.AutoSize = True
        lblAngkaSimpanan.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngkaSimpanan.ForeColor = Color.DarkGoldenrod
        lblAngkaSimpanan.Location = New Point(15, 45)
        lblAngkaSimpanan.Name = "lblAngkaSimpanan"
        lblAngkaSimpanan.Size = New Size(119, 54)
        lblAngkaSimpanan.TabIndex = 2
        lblAngkaSimpanan.Text = "Rp. 0"
        ' 
        ' lblTotalSimpanan
        ' 
        lblTotalSimpanan.AutoSize = True
        lblTotalSimpanan.BackColor = Color.DarkGoldenrod
        lblTotalSimpanan.ForeColor = Color.White
        lblTotalSimpanan.Location = New Point(15, 15)
        lblTotalSimpanan.Name = "lblTotalSimpanan"
        lblTotalSimpanan.Size = New Size(148, 23)
        lblTotalSimpanan.TabIndex = 0
        lblTotalSimpanan.Text = "TOTAL SIMPANAN"
        ' 
        ' pnlCardAnggota
        ' 
        pnlCardAnggota.BackColor = Color.AliceBlue
        pnlCardAnggota.Controls.Add(lblAngkaAnggota)
        pnlCardAnggota.Controls.Add(lblTotalAnggota)
        pnlCardAnggota.Location = New Point(30, 120)
        pnlCardAnggota.Name = "pnlCardAnggota"
        pnlCardAnggota.Size = New Size(220, 120)
        pnlCardAnggota.TabIndex = 2
        ' 
        ' lblAngkaAnggota
        ' 
        lblAngkaAnggota.AutoSize = True
        lblAngkaAnggota.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngkaAnggota.ForeColor = Color.MidnightBlue
        lblAngkaAnggota.Location = New Point(15, 45)
        lblAngkaAnggota.Name = "lblAngkaAnggota"
        lblAngkaAnggota.Size = New Size(46, 54)
        lblAngkaAnggota.TabIndex = 1
        lblAngkaAnggota.Text = "5"
        ' 
        ' lblTotalAnggota
        ' 
        lblTotalAnggota.AutoSize = True
        lblTotalAnggota.BackColor = Color.MidnightBlue
        lblTotalAnggota.Location = New Point(13, 17)
        lblTotalAnggota.Name = "lblTotalAnggota"
        lblTotalAnggota.Size = New Size(141, 23)
        lblTotalAnggota.TabIndex = 0
        lblTotalAnggota.Text = "TOTAL ANGGOTA"
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.BackColor = SystemColors.Window
        lblDeskripsi.ForeColor = Color.DimGray
        lblDeskripsi.Location = New Point(30, 67)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(347, 23)
        lblDeskripsi.TabIndex = 1
        lblDeskripsi.Text = "Ringkasan informasi koperasi simpan pinjam"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboard.ForeColor = Color.MidnightBlue
        lblDashboard.Location = New Point(30, 25)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(341, 46)
        lblDashboard.TabIndex = 0
        lblDashboard.Text = "Dashboard Koperasi"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1382, 553)
        Controls.Add(pnlKonten)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Location = New Point(20, 80)
        MinimumSize = New Size(1400, 600)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Informasi Koperasi Simpan Pinjam"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlKonten.ResumeLayout(False)
        pnlKonten.PerformLayout()
        pnlCardAngsuran.ResumeLayout(False)
        pnlCardAngsuran.PerformLayout()
        pnlCardPinjaman.ResumeLayout(False)
        pnlCardPinjaman.PerformLayout()
        pnlCardSimpanan.ResumeLayout(False)
        pnlCardSimpanan.PerformLayout()
        pnlCardAnggota.ResumeLayout(False)
        pnlCardAnggota.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAnggota As Button
    Friend WithEvents btnSimpanan As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnAngsuran As Button
    Friend WithEvents btnPinjaman As Button
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents pnlCardAnggota As Panel
    Friend WithEvents lblTotalAnggota As Label
    Friend WithEvents pnlCardSimpanan As Panel
    Friend WithEvents lblTotalSimpanan As Label
    Friend WithEvents lblAngkaAnggota As Label
    Friend WithEvents pnlCardPinjaman As Panel
    Friend WithEvents lblAngkaPinjaman As Label
    Friend WithEvents lblTotalPinjaman As Label
    Friend WithEvents lblAngkaSimpanan As Label
    Friend WithEvents pnlCardAngsuran As Panel
    Friend WithEvents lblAngkaAngsuran As Label
    Friend WithEvents lblTotalAngsuran As Label

End Class
