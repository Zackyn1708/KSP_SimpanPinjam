<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        PanelSidebar = New Panel()
        btnLaporan = New Button()
        btnTransaksi = New Button()
        btnPinjaman = New Button()
        btnSimpanan = New Button()
        btnAnggota = New Button()
        btnDashboard = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        PanelSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(20), CByte(110), CByte(120))
        PanelSidebar.Controls.Add(btnLaporan)
        PanelSidebar.Controls.Add(btnTransaksi)
        PanelSidebar.Controls.Add(btnPinjaman)
        PanelSidebar.Controls.Add(btnSimpanan)
        PanelSidebar.Controls.Add(btnAnggota)
        PanelSidebar.Controls.Add(btnDashboard)
        PanelSidebar.Controls.Add(PictureBox1)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(255, 653)
        PanelSidebar.TabIndex = 0
        ' 
        ' btnLaporan
        ' 
        btnLaporan.FlatAppearance.BorderSize = 0
        btnLaporan.FlatStyle = FlatStyle.Flat
        btnLaporan.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLaporan.ForeColor = Color.White
        btnLaporan.Location = New Point(12, 496)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(219, 50)
        btnLaporan.TabIndex = 6
        btnLaporan.Text = "Laporan"
        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.FlatAppearance.BorderSize = 0
        btnTransaksi.FlatStyle = FlatStyle.Flat
        btnTransaksi.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTransaksi.ForeColor = Color.White
        btnTransaksi.Location = New Point(12, 429)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Size = New Size(219, 50)
        btnTransaksi.TabIndex = 5
        btnTransaksi.Text = "Transaksi"
        btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnPinjaman
        ' 
        btnPinjaman.BackColor = Color.FromArgb(CByte(20), CByte(110), CByte(120))
        btnPinjaman.FlatAppearance.BorderSize = 0
        btnPinjaman.FlatStyle = FlatStyle.Flat
        btnPinjaman.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPinjaman.ForeColor = Color.White
        btnPinjaman.Location = New Point(12, 361)
        btnPinjaman.Name = "btnPinjaman"
        btnPinjaman.Size = New Size(219, 50)
        btnPinjaman.TabIndex = 4
        btnPinjaman.Text = "Pinjaman"
        btnPinjaman.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPinjaman.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanan
        ' 
        btnSimpanan.FlatAppearance.BorderSize = 0
        btnSimpanan.FlatStyle = FlatStyle.Flat
        btnSimpanan.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpanan.ForeColor = Color.White
        btnSimpanan.Location = New Point(12, 294)
        btnSimpanan.Name = "btnSimpanan"
        btnSimpanan.Size = New Size(219, 50)
        btnSimpanan.TabIndex = 3
        btnSimpanan.Text = "Simpanan"
        btnSimpanan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSimpanan.UseVisualStyleBackColor = True
        ' 
        ' btnAnggota
        ' 
        btnAnggota.BackColor = Color.FromArgb(CByte(20), CByte(110), CByte(120))
        btnAnggota.FlatAppearance.BorderSize = 0
        btnAnggota.FlatStyle = FlatStyle.Flat
        btnAnggota.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAnggota.ForeColor = Color.White
        btnAnggota.Location = New Point(12, 225)
        btnAnggota.Name = "btnAnggota"
        btnAnggota.Size = New Size(219, 50)
        btnAnggota.TabIndex = 2
        btnAnggota.Text = "Anggota"
        btnAnggota.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAnggota.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = SystemColors.ActiveCaption
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(12, 157)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(219, 50)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 114)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(18), CByte(125), CByte(135))
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(255, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(927, 275)
        Panel1.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Location = New Point(612, 188)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(250, 156)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Total Anggota"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(314, 188)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 156)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Total Anggota"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(20, 188)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 156)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(562, 28)
        Label2.TabIndex = 9
        Label2.Text = "Koperasi Simpan Pinjam: Solusi Keuangan Mandiri"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(15, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 35)
        Label1.TabIndex = 8
        Label1.Text = "Selamat Datang"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cooper Black", 48.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-13, -12)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 96)
        Button1.TabIndex = 7
        Button1.Text = "≡"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1182, 653)
        Controls.Add(Panel1)
        Controls.Add(PanelSidebar)
        Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.Window
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Utama"
        PanelSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnSimpanan As Button
    Friend WithEvents btnAnggota As Button
    Friend WithEvents btnPinjaman As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
