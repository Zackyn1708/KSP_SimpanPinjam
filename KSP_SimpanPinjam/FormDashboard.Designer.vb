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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PanelSidebar = New Panel()
        btnLaporan = New Button()
        btnTransaksi = New Button()
        btnPinjaman = New Button()
        btnSimpanan = New Button()
        btnAnggota = New Button()
        btnDashboard = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label12 = New Label()
        Label11 = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label3 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Panel2 = New Panel()
        lblAngkaAnggota = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        lblAngkaSimpanan = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        lblAngkaPinjaman = New Label()
        Label6 = New Label()
        Panel5 = New Panel()
        Label9 = New Label()
        Chart2 = New DataVisualization.Charting.Chart()
        Panel6 = New Panel()
        Label7 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        PanelSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(FlowLayoutPanel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(255, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(927, 171)
        Panel1.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label12.Location = New Point(802, 21)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 20)
        Label12.TabIndex = 11
        Label12.Text = "Petugas 07"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(697, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 20)
        Label11.TabIndex = 10
        Label11.Text = "Pengguna:"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.White
        FlowLayoutPanel3.Location = New Point(623, 177)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(220, 138)
        FlowLayoutPanel3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(562, 28)
        Label2.TabIndex = 9
        Label2.Text = "Koperasi Simpan Pinjam: Solusi Keuangan Mandiri"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 35)
        Label1.TabIndex = 8
        Label1.Text = "Selamat Datang"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-13, -12)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 96)
        Button1.TabIndex = 7
        Button1.Text = "≡"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.None
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Controls.Add(Label3)
        FlowLayoutPanel1.Location = New Point(281, 177)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(0, 0)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 21)
        Label3.TabIndex = 0
        Label3.Text = "Total Anggota"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = Color.White
        FlowLayoutPanel2.Location = New Point(576, 177)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(0, 0)
        FlowLayoutPanel2.TabIndex = 3
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.BackColor = Color.White
        FlowLayoutPanel4.Location = New Point(878, 177)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(0, 0)
        FlowLayoutPanel4.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblAngkaAnggota)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(271, 190)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 138)
        Panel2.TabIndex = 4
        ' 
        ' lblAngkaAnggota
        ' 
        lblAngkaAnggota.AutoSize = True
        lblAngkaAnggota.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblAngkaAnggota.ForeColor = Color.DarkGoldenrod
        lblAngkaAnggota.Location = New Point(22, 64)
        lblAngkaAnggota.Name = "lblAngkaAnggota"
        lblAngkaAnggota.Size = New Size(40, 46)
        lblAngkaAnggota.TabIndex = 2
        lblAngkaAnggota.Text = "4"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(22, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 1
        Label8.Text = "Label8"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.ImageAlign = ContentAlignment.BottomRight
        Label4.Location = New Point(13, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 20)
        Label4.TabIndex = 0
        Label4.Text = "Total Anggota"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblAngkaSimpanan)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(566, 190)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(267, 138)
        Panel3.TabIndex = 5
        ' 
        ' lblAngkaSimpanan
        ' 
        lblAngkaSimpanan.AutoSize = True
        lblAngkaSimpanan.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblAngkaSimpanan.ForeColor = Color.DarkGoldenrod
        lblAngkaSimpanan.Location = New Point(10, 72)
        lblAngkaSimpanan.Name = "lblAngkaSimpanan"
        lblAngkaSimpanan.Size = New Size(210, 46)
        lblAngkaSimpanan.TabIndex = 3
        lblAngkaSimpanan.Text = "Rp. 400.000"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(24, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 20)
        Label5.TabIndex = 0
        Label5.Text = "Total Simpanan"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(lblAngkaPinjaman)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(861, 190)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(267, 138)
        Panel4.TabIndex = 5
        ' 
        ' lblAngkaPinjaman
        ' 
        lblAngkaPinjaman.AutoSize = True
        lblAngkaPinjaman.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblAngkaPinjaman.ForeColor = Color.DarkGoldenrod
        lblAngkaPinjaman.Location = New Point(27, 71)
        lblAngkaPinjaman.Name = "lblAngkaPinjaman"
        lblAngkaPinjaman.Size = New Size(101, 46)
        lblAngkaPinjaman.TabIndex = 4
        lblAngkaPinjaman.Text = "Rp. 0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(17, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 20)
        Label6.TabIndex = 0
        Label6.Text = "Total Pinjaman"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(Chart2)
        Panel5.Location = New Point(271, 361)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(399, 265)
        Panel5.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label9.Location = New Point(35, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(224, 20)
        Label9.TabIndex = 5
        Label9.Text = "Total Pinjaman Bulan Ini"
        ' 
        ' Chart2
        ' 
        Chart2.BorderlineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Chart2.Legends.Add(Legend3)
        Chart2.Location = New Point(3, 58)
        Chart2.Name = "Chart2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Chart2.Series.Add(Series3)
        Chart2.Size = New Size(393, 199)
        Chart2.TabIndex = 1
        Chart2.Text = "Pemasukan Bulan Ini"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Chart1)
        Panel6.Location = New Point(731, 361)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(404, 265)
        Panel6.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(14, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(192, 20)
        Label7.TabIndex = 4
        Label7.Text = "Pemasukan Bulan Ini"
        ' 
        ' Chart1
        ' 
        Chart1.BorderlineDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea4.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Chart1.Legends.Add(Legend4)
        Chart1.Location = New Point(65, 12)
        Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Chart1.Series.Add(Series4)
        Chart1.Size = New Size(284, 250)
        Chart1.TabIndex = 0
        Chart1.Text = "Pemasukan Bulan Ini"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1182, 653)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(FlowLayoutPanel4)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(Panel1)
        Controls.Add(PanelSidebar)
        Controls.Add(FlowLayoutPanel1)
        Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.Window
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "x"
        PanelSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAngkaAnggota As Label
    Friend WithEvents lblAngkaSimpanan As Label
    Friend WithEvents lblAngkaPinjaman As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
