Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.SqlServer

Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDashboardUI()
    End Sub

    Private Sub SetupDashboardUI()
        ' Pengaturan Form Utama
        Me.Text = "Dashboard Utama"
        Me.Size = New Size(1100, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(244, 247, 249)

        ' Warna Tema
        Dim primaryTeal As Color = Color.FromArgb(0, 123, 140)
        Dim darkTeal As Color = Color.FromArgb(0, 95, 108)

        ' 1. Sidebar Panel (Kiri)
        Dim sidebar As New Panel With {
            .Dock = DockStyle.Left,
            .Width = 220,
            .BackColor = primaryTeal
        }
        Me.Controls.Add(sidebar)

        ' Menu Sidebar
        Dim menuItems As String() = {"2. Anggota", "2. Dashboard", "Simpanan", "Pinjaman", "Transaksi", "Laporan", "Pengaturan"}
        Dim topPos As Integer = 100
        For Each item As String In menuItems
            Dim btn As New Button With {
                .Text = "   " & item,
                .Location = New Point(0, topPos),
                .Size = New Size(220, 45),
                .FlatStyle = FlatStyle.Flat,
                .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                .TextAlign = ContentAlignment.MiddleLeft,
                .BackColor = If(item.Contains("Dashboard"), darkTeal, primaryTeal)
            }
            btn.FlatAppearance.BorderSize = 0
            sidebar.Controls.Add(btn)
            topPos += 45
        Next

        ' 2. Header Banner (Atas)
        Dim headerPanel As New Panel With {
            .Location = New Point(220, 0),
            .Size = New Size(880, 120),
            .BackColor = primaryTeal,
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }
        Me.Controls.Add(headerPanel)

        Dim lblWelcome As New Label With {
            .Text = "Welcome",
            .Font = New Font("Segoe UI", 20, FontStyle.Bold),
            .ForeColor = Color.White,
            .Location = New Point(30, 25),
            .AutoSize = True
        }
        Dim lblSubWelcome As New Label With {
            .Text = "Koperasi Unit Desa: Solusi Keuangan Mandiri",
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .ForeColor = Color.FromArgb(220, 240, 245),
            .Location = New Point(32, 65),
            .AutoSize = True
        }
        headerPanel.Controls.Add(lblWelcome)
        headerPanel.Controls.Add(lblSubWelcome)

        ' 3. Ringkasan Kartu (KPI Cards)
        CreateCard("Total Anggota", "56", New Point(250, 140), 240, 110)
        CreateCard("Total Simpanan", "$55.09K", New Point(510, 140), 240, 110)
        CreateCard("Total Pinjaman", "35.89K", New Point(770, 140), 240, 110)

        ' 4. Grafik Batang (Total Pinjaman Bulan Ini)
        Dim barChart As New Chart With {
            .Location = New Point(250, 270),
            .Size = New Size(500, 360),
            .BackColor = Color.White
        }
        Dim barArea As New ChartArea("BarArea")
        barArea.AxisX.MajorGrid.LineColor = Color.LightGray
        barArea.AxisY.MajorGrid.LineColor = Color.LightGray
        barChart.ChartAreas.Add(barArea)

        Dim barSeries As New Series("Pinjaman") With {
            .ChartType = SeriesChartType.Column,
            .Color = primaryTeal
        }
        barSeries.Points.AddXY("Jan", 1000000)
        barSeries.Points.AddXY("Feb", 1500000)
        barSeries.Points.AddXY("Mar", 500000)
        barSeries.Points.AddXY("Apr", 1300000)
        barSeries.Points.AddXY("May", 600000)
        barChart.Series.Add(barSeries)

        Dim barTitle As New Title("Total Pinjaman Bulan Ini", Docking.Top, New Font("Segoe UI", 12, FontStyle.Bold), Color.Black)
        barTitle.Alignment = ContentAlignment.TopLeft
        barChart.Titles.Add(barTitle)
        Me.Controls.Add(barChart)

        ' 5. Grafik Lingkaran (Pemasukan Bulan Ini)
        Dim pieChart As New Chart With {
            .Location = New Point(770, 270),
            .Size = New Size(280, 360),
            .BackColor = Color.White
        }
        Dim pieArea As New ChartArea("PieArea")
        pieChart.ChartAreas.Add(pieArea)

        Dim pieSeries As New Series("Pemasukan") With {
            .ChartType = SeriesChartType.Pie
        }
        pieSeries.Points.AddXY("Simpanan", 55)
        pieSeries.Points.AddXY("Angsuran", 30)
        pieSeries.Points.AddXY("Lainnya", 15)

        pieSeries.Points(0).Color = primaryTeal
        pieSeries.Points(1).Color = Color.FromArgb(41, 128, 185)
        pieSeries.Points(2).Color = Color.FromArgb(241, 196, 15)

        pieChart.Series.Add(pieSeries)

        Dim pieTitle As New Title("Pemasukan Bulan Ini", Docking.Top, New Font("Segoe UI", 12, FontStyle.Bold), Color.Black)
        pieTitle.Alignment = ContentAlignment.TopLeft
        pieChart.Titles.Add(pieTitle)
        Me.Controls.Add(pieChart)
    End Sub

    Private Sub CreateCard(title As String, value As String, location As Point, width As Integer, height As Integer)
        Dim card As New Panel With {
            .Location = location,
            .Size = New Size(width, height),
            .BackColor = Color.White
        }

        Dim lblTitle As New Label With {
            .Text = title,
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DimGray,
            .Location = New Point(15, 15),
            .AutoSize = True
        }

        Dim lblValue As New Label With {
            .Text = value,
            .Font = New Font("Segoe UI", 18, FontStyle.Bold),
            .ForeColor = Color.Black,
            .Location = New Point(15, 50),
            .AutoSize = True
        }

        card.Controls.Add(lblTitle)
        card.Controls.Add(lblValue)
        Me.Controls.Add(card)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class