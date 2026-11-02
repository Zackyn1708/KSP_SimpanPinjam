<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaranAngsuran
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        RadioButton2 = New RadioButton()
        JumlahBayar = New TextBox()
        RadioButton1 = New RadioButton()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TipeDenda = New RadioButton()
        TipeBunga = New RadioButton()
        TipePokok = New RadioButton()
        Label4 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        KontrakID = New DataGridViewTextBoxColumn()
        KontrakStatus = New DataGridViewTextBoxColumn()
        KontrakMB = New DataGridViewTextBoxColumn()
        KontrakJT = New DataGridViewTextBoxColumn()
        KontrakAnggota = New DataGridViewTextBoxColumn()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label8 = New Label()
        btnsubmit = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Teal
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1237, 85)
        Label1.TabIndex = 0
        Label1.Text = "Pembayaran Angsuran"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F)
        Label2.Location = New Point(14, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 31)
        Label2.TabIndex = 1
        Label2.Text = "No Kontrak"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(JumlahBayar)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TipeDenda)
        GroupBox1.Controls.Add(TipeBunga)
        GroupBox1.Controls.Add(TipePokok)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 10F)
        GroupBox1.Location = New Point(14, 185)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1211, 216)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Angsuran"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Checked = False
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(163, 163)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(270, 30)
        DateTimePicker1.TabIndex = 10
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(253, 126)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 27)
        RadioButton2.TabIndex = 9
        RadioButton2.Text = "Transfer"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' JumlahBayar
        ' 
        JumlahBayar.Location = New Point(163, 80)
        JumlahBayar.Name = "JumlahBayar"
        JumlahBayar.Size = New Size(211, 30)
        JumlahBayar.TabIndex = 7
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(164, 126)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(73, 27)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Tunai"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 168)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 23)
        Label7.TabIndex = 6
        Label7.Text = "Tanggal Bayar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 23)
        Label6.TabIndex = 5
        Label6.Text = "Metode Bayar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 23)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Bayar"
        ' 
        ' TipeDenda
        ' 
        TipeDenda.AutoSize = True
        TipeDenda.Location = New Point(422, 36)
        TipeDenda.Name = "TipeDenda"
        TipeDenda.Size = New Size(81, 27)
        TipeDenda.TabIndex = 3
        TipeDenda.Text = "Denda"
        TipeDenda.UseVisualStyleBackColor = True
        ' 
        ' TipeBunga
        ' 
        TipeBunga.AutoSize = True
        TipeBunga.Location = New Point(285, 36)
        TipeBunga.Name = "TipeBunga"
        TipeBunga.Size = New Size(80, 27)
        TipeBunga.TabIndex = 2
        TipeBunga.Text = "Bunga"
        TipeBunga.UseVisualStyleBackColor = True
        ' 
        ' TipePokok
        ' 
        TipePokok.AutoSize = True
        TipePokok.Checked = True
        TipePokok.Location = New Point(165, 36)
        TipePokok.Name = "TipePokok"
        TipePokok.Size = New Size(76, 27)
        TipePokok.TabIndex = 1
        TipePokok.TabStop = True
        TipePokok.Text = "Pokok"
        TipePokok.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 23)
        Label4.TabIndex = 0
        Label4.Text = "Tipe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F)
        Label3.Location = New Point(14, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 31)
        Label3.TabIndex = 4
        Label3.Text = "Member Info"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 13.8F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox1.Location = New Point(177, 98)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(257, 39)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Pilih Kontrak"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {KontrakID, KontrakStatus, KontrakMB, KontrakJT, KontrakAnggota})
        DataGridView1.Location = New Point(14, 418)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 31
        DataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1076, 216)
        DataGridView1.TabIndex = 6
        ' 
        ' KontrakID
        ' 
        KontrakID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        KontrakID.HeaderText = "No Kontrak"
        KontrakID.MinimumWidth = 6
        KontrakID.Name = "KontrakID"
        KontrakID.ReadOnly = True
        KontrakID.Width = 126
        ' 
        ' KontrakStatus
        ' 
        KontrakStatus.HeaderText = "Status"
        KontrakStatus.MinimumWidth = 6
        KontrakStatus.Name = "KontrakStatus"
        KontrakStatus.ReadOnly = True
        ' 
        ' KontrakMB
        ' 
        KontrakMB.HeaderText = "Metode Bayar"
        KontrakMB.MinimumWidth = 6
        KontrakMB.Name = "KontrakMB"
        KontrakMB.ReadOnly = True
        ' 
        ' KontrakJT
        ' 
        KontrakJT.HeaderText = "Jatuh Tempo"
        KontrakJT.MinimumWidth = 6
        KontrakJT.Name = "KontrakJT"
        KontrakJT.ReadOnly = True
        ' 
        ' KontrakAnggota
        ' 
        KontrakAnggota.HeaderText = "Nama Anggota"
        KontrakAnggota.MinimumWidth = 6
        KontrakAnggota.Name = "KontrakAnggota"
        KontrakAnggota.ReadOnly = True
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F)
        Label8.Location = New Point(177, 142)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 31)
        Label8.TabIndex = 7
        Label8.Text = "Bapak/Ibu ..."
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnsubmit.BackColor = Color.Teal
        btnsubmit.FlatStyle = FlatStyle.Flat
        btnsubmit.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsubmit.ForeColor = Color.White
        btnsubmit.Location = New Point(1055, 740)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(170, 55)
        btnsubmit.TabIndex = 8
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' FormPembayaranAngsuran
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(1237, 801)
        Controls.Add(btnsubmit)
        Controls.Add(Label8)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10F)
        Name = "FormPembayaranAngsuran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PembayaranAngsuran"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipePokok As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TipeBunga As RadioButton
    Friend WithEvents TipeDenda As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents JumlahBayar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As Label
    Friend WithEvents KontrakID As DataGridViewTextBoxColumn
    Friend WithEvents KontrakStatus As DataGridViewTextBoxColumn
    Friend WithEvents KontrakMB As DataGridViewTextBoxColumn
    Friend WithEvents KontrakJT As DataGridViewTextBoxColumn
    Friend WithEvents KontrakAnggota As DataGridViewTextBoxColumn
    Friend WithEvents btnsubmit As Button
End Class
