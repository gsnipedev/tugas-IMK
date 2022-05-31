Class penggunaan3
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim bulan As String
        bulan = input3.Text
        hasil3.Foreground = Brushes.Black
        Select Case bulan
            Case "1"
                hasil3.Text = "Januari"
            Case "2"
                hasil3.Text = "Februari"
            Case "3"
                hasil3.Text = "Maret"
            Case "4"
                hasil3.Text = "April"
            Case "5"
                hasil3.Text = "Mei"
            Case "6"
                hasil3.Text = "Juni"
            Case "7"
                hasil3.Text = "Juli"
            Case "8"
                hasil3.Text = "Agustus"
            Case "9"
                hasil3.Text = "September"
            Case "10"
                hasil3.Text = "Oktober"
            Case "11"
                hasil3.Text = "November"
            Case "12"
                hasil3.Text = "Desember"
            Case Else
                hasil3.Text = "ERROR"
                hasil3.Foreground = Brushes.Red
        End Select
    End Sub
End Class
