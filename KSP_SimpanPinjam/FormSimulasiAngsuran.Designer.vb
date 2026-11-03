<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblTitle
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
        panelHeader = New Panel()
        lblJudul = New Label()
        txtAmount = New TextBox()
        lblJumlahPinjaman = New Label()
        lblJangkaWaktu = New Label()
        NumericUpDown1 = New NumericUpDown()
        lblSukuBunga = New Label()
        numInterest = New NumericUpDown()
        dgvAngsuran = New DataGridView()
        colBulan = New DataGridViewTextBoxColumn()
        colAngsuranPokok = New DataGridViewTextBoxColumn()
        colAngsuranBunga = New DataGridViewTextBoxColumn()
        colTotalAngsuran = New DataGridViewTextBoxColumn()
        colSisaPinjaman = New DataGridViewTextBoxColumn()
        panelHeader.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(numInterest, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAngsuran, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.Teal
        panelHeader.Controls.Add(lblJudul)
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(885, 85)
        panelHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(469, 73)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Simulasi Angsuran"
        lblJudul.UseCompatibleTextRendering = True
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 12F)
        txtAmount.Location = New Point(250, 108)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(553, 39)
        txtAmount.TabIndex = 2
        txtAmount.Text = "500000"
        ' 
        ' lblJumlahPinjaman
        ' 
        lblJumlahPinjaman.AutoSize = True
        lblJumlahPinjaman.Font = New Font("Segoe UI", 12F)
        lblJumlahPinjaman.Location = New Point(27, 108)
        lblJumlahPinjaman.Name = "lblJumlahPinjaman"
        lblJumlahPinjaman.Size = New Size(195, 32)
        lblJumlahPinjaman.TabIndex = 3
        lblJumlahPinjaman.Text = "Jumlah Pinjaman"
        ' 
        ' lblJangkaWaktu
        ' 
        lblJangkaWaktu.AutoSize = True
        lblJangkaWaktu.Font = New Font("Segoe UI", 12F)
        lblJangkaWaktu.Location = New Point(27, 159)
        lblJangkaWaktu.Name = "lblJangkaWaktu"
        lblJangkaWaktu.Size = New Size(161, 32)
        lblJangkaWaktu.TabIndex = 4
        lblJangkaWaktu.Text = "Jangka Waktu"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(250, 160)
        NumericUpDown1.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(553, 31)
        NumericUpDown1.TabIndex = 5
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblSukuBunga
        ' 
        lblSukuBunga.AutoSize = True
        lblSukuBunga.Font = New Font("Segoe UI", 12F)
        lblSukuBunga.Location = New Point(27, 217)
        lblSukuBunga.Name = "lblSukuBunga"
        lblSukuBunga.Size = New Size(142, 32)
        lblSukuBunga.TabIndex = 6
        lblSukuBunga.Text = "Suku Bunga"
        ' 
        ' numInterest
        ' 
        numInterest.DecimalPlaces = 1
        numInterest.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        numInterest.Location = New Point(250, 217)
        numInterest.Name = "numInterest"
        numInterest.Size = New Size(553, 31)
        numInterest.TabIndex = 7
        ' 
        ' dgvAngsuran
        ' 
        dgvAngsuran.AllowUserToAddRows = False
        dgvAngsuran.AllowUserToDeleteRows = False
        dgvAngsuran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAngsuran.BackgroundColor = Color.White
        dgvAngsuran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAngsuran.Columns.AddRange(New DataGridViewColumn() {colBulan, colAngsuranPokok, colAngsuranBunga, colTotalAngsuran, colSisaPinjaman})
        dgvAngsuran.Location = New Point(12, 284)
        dgvAngsuran.Name = "dgvAngsuran"
        dgvAngsuran.ReadOnly = True
        dgvAngsuran.RowHeadersVisible = False
        dgvAngsuran.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvAngsuran.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAngsuran.Size = New Size(835, 290)
        dgvAngsuran.TabIndex = 8
        ' 
        ' colBulan
        ' 
        colBulan.HeaderText = "Bulan"
        colBulan.MinimumWidth = 8
        colBulan.Name = "colBulan"
        colBulan.ReadOnly = True
        ' 
        ' colAngsuranPokok
        ' 
        colAngsuranPokok.HeaderText = "Angsuran Pokok"
        colAngsuranPokok.MinimumWidth = 8
        colAngsuranPokok.Name = "colAngsuranPokok"
        colAngsuranPokok.ReadOnly = True
        ' 
        ' colAngsuranBunga
        ' 
        colAngsuranBunga.HeaderText = "Angsuran Bunga"
        colAngsuranBunga.MinimumWidth = 8
        colAngsuranBunga.Name = "colAngsuranBunga"
        colAngsuranBunga.ReadOnly = True
        ' 
        ' colTotalAngsuran
        ' 
        colTotalAngsuran.HeaderText = "Total Angsuran"
        colTotalAngsuran.MinimumWidth = 8
        colTotalAngsuran.Name = "colTotalAngsuran"
        colTotalAngsuran.ReadOnly = True
        ' 
        ' colSisaPinjaman
        ' 
        colSisaPinjaman.HeaderText = "Sisa Pinjaman"
        colSisaPinjaman.MinimumWidth = 8
        colSisaPinjaman.Name = "colSisaPinjaman"
        colSisaPinjaman.ReadOnly = True
        ' 
        ' lblTitle
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(884, 624)
        Controls.Add(dgvAngsuran)
        Controls.Add(numInterest)
        Controls.Add(lblSukuBunga)
        Controls.Add(NumericUpDown1)
        Controls.Add(lblJangkaWaktu)
        Controls.Add(lblJumlahPinjaman)
        Controls.Add(txtAmount)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "lblTitle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Simulation App"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(numInterest, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAngsuran, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblJumlahPinjaman As Label
    Friend WithEvents lblJangkaWaktu As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblSukuBunga As Label
    Friend WithEvents numInterest As NumericUpDown
    Friend WithEvents dgvAngsuran As DataGridView
    Friend WithEvents colBulan As DataGridViewTextBoxColumn
    Friend WithEvents colAngsuranPokok As DataGridViewTextBoxColumn
    Friend WithEvents colAngsuranBunga As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAngsuran As DataGridViewTextBoxColumn
    Friend WithEvents colSisaPinjaman As DataGridViewTextBoxColumn
End Class
