<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputAnggota
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
        lblJudulInput = New Label()
        txtNoAnggota = New Label()
        txtNamaAnggota = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' lblJudulInput
        ' 
        lblJudulInput.AutoSize = True
        lblJudulInput.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulInput.ForeColor = Color.MidnightBlue
        lblJudulInput.Location = New Point(30, 21)
        lblJudulInput.Name = "lblJudulInput"
        lblJudulInput.Size = New Size(341, 41)
        lblJudulInput.TabIndex = 0
        lblJudulInput.Text = "Form Tambah Anggota"
        ' 
        ' txtNoAnggota
        ' 
        txtNoAnggota.AutoSize = True
        txtNoAnggota.Location = New Point(40, 98)
        txtNoAnggota.Name = "txtNoAnggota"
        txtNoAnggota.Size = New Size(94, 20)
        txtNoAnggota.TabIndex = 1
        txtNoAnggota.Text = "No. Anggota"
        ' 
        ' txtNamaAnggota
        ' 
        txtNamaAnggota.AutoSize = True
        txtNamaAnggota.Location = New Point(40, 163)
        txtNamaAnggota.Name = "txtNamaAnggota"
        txtNamaAnggota.Size = New Size(111, 20)
        txtNamaAnggota.TabIndex = 2
        txtNamaAnggota.Text = "Nama Anggota"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(171, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(171, 163)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 4
        ' 
        ' FormInputAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(632, 553)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtNamaAnggota)
        Controls.Add(txtNoAnggota)
        Controls.Add(lblJudulInput)
        Location = New Point(180, 75)
        Name = "FormInputAnggota"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Anggota"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulInput As Label
    Friend WithEvents txtNoAnggota As Label
    Friend WithEvents txtNamaAnggota As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
