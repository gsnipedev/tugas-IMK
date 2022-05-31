Class penggunaan1
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim Nilai As Byte
            Nilai = input1.Text
            If Nilai >= 80 Then hasil1.Text = "Nilai kamu bagus dengan predikat A"
            hasil1.Foreground = Brushes.Green
        Catch ex As Exception
            hasil1.Foreground = Brushes.Red
            hasil1.Text = "ERROR"
        End Try
    End Sub
End Class
