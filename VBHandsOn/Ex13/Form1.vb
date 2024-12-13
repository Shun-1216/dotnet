Public Class Form1

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim price, volume As Integer
        If Integer.TryParse(unitPriceTextBox.Text, price) Then
            If Integer.TryParse(volumeTextBox.Text, volume) Then
                amountLabel.Text = (price * volume).ToString("C")

            Else
                amountLabel.Text = "適切な値を入力"
            End If
        Else
            amountLabel.Text = "適切な値を入力"
        End If
    End Sub

    Private Sub endButton_Click(sender As Object, e As EventArgs) Handles endButton.Click
        Me.Close()
    End Sub
End Class
