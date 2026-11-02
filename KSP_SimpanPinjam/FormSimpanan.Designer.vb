<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimpanan
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
        pnlSidebar = New Panel()
        btnPembayaran = New Button()
        btnAngsuran = New Button()
        btnPinjaman = New Button()
        btnSimpanan = New Button()
        btnAnggota = New Button()
        btnDashboard = New Button()
        lblJudul = New Label()
        pnlSidebar.SuspendLayout()
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
        pnlSidebar.Size = New Size(278, 537)
        pnlSidebar.TabIndex = 8
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
        btnSimpanan.BackColor = Color.RoyalBlue
        btnSimpanan.Cursor = Cursors.Hand
        btnSimpanan.FlatStyle = FlatStyle.Flat
        btnSimpanan.ForeColor = Color.White
        btnSimpanan.Location = New Point(20, 180)
        btnSimpanan.Name = "btnSimpanan"
        btnSimpanan.Size = New Size(180, 40)
        btnSimpanan.TabIndex = 3
        btnSimpanan.Text = "Simpanan"
        btnSimpanan.TextAlign = ContentAlignment.MiddleLeft
        btnSimpanan.UseVisualStyleBackColor = False
        ' 
        ' btnAnggota
        ' 
        btnAnggota.BackColor = Color.MidnightBlue
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
        ' FormSimpanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1268, 537)
        Controls.Add(pnlSidebar)
        Name = "FormSimpanan"
        Text = "FormSimpanan"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnAngsuran As Button
    Friend WithEvents btnPinjaman As Button
    Friend WithEvents btnSimpanan As Button
    Friend WithEvents btnAnggota As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblJudul As Label
End Class
