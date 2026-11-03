<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPinjaman
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Label12 = New Label()
        Panel3 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 28)
        Label1.TabIndex = 0
        Label1.Text = "Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 28)
        Label2.TabIndex = 1
        Label2.Text = "Produk Pinjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 28)
        Label3.TabIndex = 2
        Label3.Text = "Batasan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 28)
        Label4.TabIndex = 3
        Label4.Text = "Tenor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 28)
        Label5.TabIndex = 4
        Label5.Text = "Suku Bunga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 28)
        Label6.TabIndex = 5
        Label6.Text = "Tanggal Target"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 28)
        Label7.TabIndex = 6
        Label7.Text = "Tujuan"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label8)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 73)
        Panel1.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(247, 45)
        Label8.TabIndex = 0
        Label8.Text = "Form Pinjaman"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(190, 96)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(338, 36)
        ComboBox1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(RadioButton1)
        Panel2.Location = New Point(190, 143)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(262, 28)
        Panel2.TabIndex = 9
        Panel2.Visible = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(3, 0)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(110, 32)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Personal"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(325, 143)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(85, 32)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "Bisnis"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(190, 187)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 34)
        TextBox1.TabIndex = 11
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(190, 237)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(218, 34)
        NumericUpDown1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(190, 281)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(218, 34)
        TextBox2.TabIndex = 13
        TextBox2.Text = "%"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(190, 326)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(218, 34)
        DateTimePicker1.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.ForeColor = Color.Gray
        TextBox3.Location = New Point(190, 377)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(683, 34)
        TextBox3.TabIndex = 15
        TextBox3.Text = "e.g., Renovasi Rumah"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(468, 239)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 28)
        Label9.TabIndex = 16
        Label9.Text = "Tenor"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(468, 284)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 28)
        Label10.TabIndex = 17
        Label10.Text = "Efektif"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(468, 331)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 28)
        Label11.TabIndex = 18
        Label11.Text = "Asuransi"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ScrollBar
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(614, 236)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(259, 36)
        ComboBox2.TabIndex = 19
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = SystemColors.ScrollBar
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(614, 281)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(259, 36)
        ComboBox3.TabIndex = 20
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = SystemColors.ScrollBar
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(614, 328)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(259, 36)
        ComboBox4.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(761, 417)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 22
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Teal
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(761, 540)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 23
        Button2.Text = "Kirim"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Teal
        PictureBox1.Location = New Point(544, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 36)
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(584, 99)
        Label12.Name = "Label12"
        Label12.Size = New Size(114, 28)
        Label12.TabIndex = 25
        Label12.Text = "Member ID:"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(19, 470)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(854, 52)
        Panel3.TabIndex = 26
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(684, 6)
        Label14.Name = "Label14"
        Label14.Size = New Size(156, 38)
        Label14.TabIndex = 1
        Label14.Text = "215.350,00"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(8, 11)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 28)
        Label13.TabIndex = 0
        Label13.Text = "Cicilan Bulanan"
        ' 
        ' FormPinjaman
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 28.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(904, 597)
        Controls.Add(Panel3)
        Controls.Add(Label12)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(NumericUpDown1)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton2)
        Controls.Add(Panel2)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormPinjaman"
        Text = "Form Pinjaman"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label

End Class
