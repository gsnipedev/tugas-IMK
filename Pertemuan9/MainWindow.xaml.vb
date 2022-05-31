Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        mainFrame.Navigate(New penggunaan1)
        While mainFrame.CanGoBack
            Try
                mainFrame.RemoveBackEntry()
            Catch ex As Exception
                Exit While
            End Try
        End While

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        mainFrame.Navigate(New penggunaan2)
        While mainFrame.CanGoBack
            Try
                mainFrame.RemoveBackEntry()
            Catch ex As Exception
                Exit While
            End Try
        End While
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        mainFrame.Navigate(New penggunaan3)
        While mainFrame.CanGoBack
            Try
                mainFrame.RemoveBackEntry()
            Catch ex As Exception
                Exit While
            End Try
        End While
    End Sub
End Class

