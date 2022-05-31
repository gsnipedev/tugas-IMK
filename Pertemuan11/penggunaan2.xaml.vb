Class penggunaan2
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim Nilai As Byte
            Nilai = input2.Text
            If Nilai >= 80 Then
                hasil2.Text = "Nilai kamu bagus dengan predikat A"
                hasil2.Foreground = Brushes.Green
            Else
                hasil2.Text = "Kamu harus melakukan perbaikan Nilai"
                hasil2.Foreground = Brushes.Red
            End If

        Catch ex As Exception
            hasil2.Foreground = Brushes.Red
            hasil2.Text = "ERROR"
        End Try
    End Sub
End Class
