<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSimpanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(880, 73)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 45)
        Label1.TabIndex = 0
        Label1.Text = "Form Simpanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 28)
        Label2.TabIndex = 1
        Label2.Text = "Anggota"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 28)
        Label3.TabIndex = 2
        Label3.Text = "Tipe"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 28)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 28)
        Label5.TabIndex = 4
        Label5.Text = "Tanggal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 269)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 28)
        Label6.TabIndex = 5
        Label6.Text = "Catatan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ScrollBar
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(156, 82)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(273, 36)
        ComboBox1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Location = New Point(156, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(301, 37)
        Panel2.TabIndex = 7
        Panel2.Visible = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(195, 2)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(111, 32)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "Sukarela"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(3, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(91, 32)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pokok"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(102, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(87, 32)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Wajib"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(156, 173)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(221, 34)
        TextBox1.TabIndex = 8
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(156, 216)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(221, 34)
        DateTimePicker1.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(490, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 28)
        Label7.TabIndex = 10
        Label7.Text = "Tipe Transaksi"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ScrollBar
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(636, 218)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(220, 36)
        ComboBox2.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(156, 266)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(700, 75)
        TextBox2.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(744, 351)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 23
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(22, 395)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(834, 175)
        DataGridView1.TabIndex = 24
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID Transaksi"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Anggota"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tanggal"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Tipe"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Jumlah"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Balance"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Catatan"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Teal
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(440, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(36, 36)
        Button2.TabIndex = 25
        Button2.Text = "..."
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormSimpanan
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 28.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(880, 570)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox2)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Controls.Add(Panel2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormSimpanan"
        Text = "Form Simpanan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
