<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSHU
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
        PanelHeader = New Panel()
        lblJudul = New Label()
        lblBasis = New Label()
        rdIncome = New RadioButton()
        rdLabaBersih = New RadioButton()
        rdArusKas = New RadioButton()
        lblSHU = New Label()
        numSHU = New NumericUpDown()
        btnCalculate = New Button()
        lblYear = New Label()
        numYear = New NumericUpDown()
        dgvSHU = New DataGridView()
        colNama = New DataGridViewTextBoxColumn()
        colAnggota = New DataGridViewTextBoxColumn()
        colKontribusi = New DataGridViewTextBoxColumn()
        colSHUDiterima = New DataGridViewTextBoxColumn()
        btnDistribution = New Button()
        PanelHeader.SuspendLayout()
        CType(numSHU, ComponentModel.ISupportInitialize).BeginInit()
        CType(numYear, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSHU, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.Teal
        PanelHeader.Controls.Add(lblJudul)
        PanelHeader.Location = New Point(10, 10)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(810, 55)
        PanelHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(3, -1)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(437, 54)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Form Pembagian SHU"
        ' 
        ' lblBasis
        ' 
        lblBasis.AutoSize = True
        lblBasis.Font = New Font("Segoe UI", 11F)
        lblBasis.Location = New Point(10, 88)
        lblBasis.Name = "lblBasis"
        lblBasis.Size = New Size(192, 30)
        lblBasis.TabIndex = 1
        lblBasis.Text = "Basis Perhitungan :"
        ' 
        ' rdIncome
        ' 
        rdIncome.AutoSize = True
        rdIncome.Checked = True
        rdIncome.Location = New Point(34, 145)
        rdIncome.Name = "rdIncome"
        rdIncome.Size = New Size(96, 29)
        rdIncome.TabIndex = 2
        rdIncome.TabStop = True
        rdIncome.Text = "Income"
        rdIncome.UseVisualStyleBackColor = True
        ' 
        ' rdLabaBersih
        ' 
        rdLabaBersih.AutoSize = True
        rdLabaBersih.Location = New Point(255, 145)
        rdLabaBersih.Name = "rdLabaBersih"
        rdLabaBersih.Size = New Size(126, 29)
        rdLabaBersih.TabIndex = 3
        rdLabaBersih.TabStop = True
        rdLabaBersih.Text = "Laba Bersih"
        rdLabaBersih.UseVisualStyleBackColor = True
        ' 
        ' rdArusKas
        ' 
        rdArusKas.AutoSize = True
        rdArusKas.Location = New Point(503, 145)
        rdArusKas.Name = "rdArusKas"
        rdArusKas.Size = New Size(105, 29)
        rdArusKas.TabIndex = 4
        rdArusKas.TabStop = True
        rdArusKas.Text = "Arus Kas"
        rdArusKas.UseVisualStyleBackColor = True
        ' 
        ' lblSHU
        ' 
        lblSHU.AutoSize = True
        lblSHU.Location = New Point(54, 208)
        lblSHU.Name = "lblSHU"
        lblSHU.Size = New Size(117, 25)
        lblSHU.TabIndex = 5
        lblSHU.Text = "SHU Amount"
        ' 
        ' numSHU
        ' 
        numSHU.Increment = New Decimal(New Integer() {1000000, 0, 0, 0})
        numSHU.Location = New Point(177, 208)
        numSHU.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numSHU.Name = "numSHU"
        numSHU.Size = New Size(180, 31)
        numSHU.TabIndex = 6
        numSHU.ThousandsSeparator = True
        numSHU.Value = New Decimal(New Integer() {500000000, 0, 0, 0})
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Teal
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(666, 279)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(120, 40)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(67, 279)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(53, 25)
        lblYear.TabIndex = 8
        lblYear.Text = "Year :"
        ' 
        ' numYear
        ' 
        numYear.Location = New Point(177, 273)
        numYear.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        numYear.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        numYear.Name = "numYear"
        numYear.Size = New Size(180, 31)
        numYear.TabIndex = 9
        numYear.Value = New Decimal(New Integer() {2023, 0, 0, 0})
        ' 
        ' dgvSHU
        ' 
        dgvSHU.AllowUserToAddRows = False
        dgvSHU.AllowUserToDeleteRows = False
        dgvSHU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSHU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSHU.Columns.AddRange(New DataGridViewColumn() {colNama, colAnggota, colKontribusi, colSHUDiterima})
        dgvSHU.Location = New Point(34, 350)
        dgvSHU.Name = "dgvSHU"
        dgvSHU.ReadOnly = True
        dgvSHU.RowHeadersWidth = 62
        dgvSHU.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSHU.ShowEditingIcon = False
        dgvSHU.Size = New Size(775, 210)
        dgvSHU.TabIndex = 10
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colAnggota
        ' 
        colAnggota.HeaderText = "Anggota"
        colAnggota.MinimumWidth = 8
        colAnggota.Name = "colAnggota"
        colAnggota.ReadOnly = True
        ' 
        ' colKontribusi
        ' 
        colKontribusi.HeaderText = "Kontribusi"
        colKontribusi.MinimumWidth = 8
        colKontribusi.Name = "colKontribusi"
        colKontribusi.ReadOnly = True
        ' 
        ' colSHUDiterima
        ' 
        colSHUDiterima.HeaderText = "SHU Diterima"
        colSHUDiterima.MinimumWidth = 8
        colSHUDiterima.Name = "colSHUDiterima"
        colSHUDiterima.ReadOnly = True
        ' 
        ' btnDistribution
        ' 
        btnDistribution.BackColor = Color.Teal
        btnDistribution.FlatStyle = FlatStyle.Flat
        btnDistribution.Font = New Font("Segoe UI", 11F)
        btnDistribution.ForeColor = Color.White
        btnDistribution.Location = New Point(642, 587)
        btnDistribution.Name = "btnDistribution"
        btnDistribution.Size = New Size(160, 40)
        btnDistribution.TabIndex = 11
        btnDistribution.Text = "Distribution SHU"
        btnDistribution.UseVisualStyleBackColor = False
        ' 
        ' FormSHU
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1204, 664)
        Controls.Add(btnDistribution)
        Controls.Add(dgvSHU)
        Controls.Add(numYear)
        Controls.Add(lblYear)
        Controls.Add(btnCalculate)
        Controls.Add(numSHU)
        Controls.Add(lblSHU)
        Controls.Add(rdArusKas)
        Controls.Add(rdLabaBersih)
        Controls.Add(rdIncome)
        Controls.Add(lblBasis)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormSHU"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(numSHU, ComponentModel.ISupportInitialize).EndInit()
        CType(numYear, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSHU, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblBasis As Label
    Friend WithEvents rdIncome As RadioButton
    Friend WithEvents rdLabaBersih As RadioButton
    Friend WithEvents rdArusKas As RadioButton
    Friend WithEvents lblSHU As Label
    Friend WithEvents numSHU As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents numYear As NumericUpDown
    Friend WithEvents dgvSHU As DataGridView
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colAnggota As DataGridViewTextBoxColumn
    Friend WithEvents colKontribusi As DataGridViewTextBoxColumn
    Friend WithEvents colSHUDiterima As DataGridViewTextBoxColumn
    Friend WithEvents btnDistribution As Button

End Class
