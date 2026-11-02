
Imports MySql.Data.MySqlClient

Module Koneksi
    Public Conn As MySqlConnection

    Public Sub BukaKoneksi()
        Try
            If Conn Is Nothing Then
                Conn = New MySqlConnection(
                    "server=localhost;port=3306;database=DbKSP;id=root;password=;"
                )
            End If

            If Conn.State <> ConnectionState.Open Then
                Conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(
                "Koneksi database gagal: " & ex.Message,
                "Kesalahan Koneksi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Public Sub TesKoneksi()
        Try
            BukaKoneksi()

            If Conn IsNot Nothing AndAlso
           Conn.State = ConnectionState.Open Then

                MessageBox.Show(
                "Koneksi ke database DbKSP berhasil!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

                Conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal: " & ex.Message)
        End Try
    End Sub

End Module
