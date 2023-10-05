Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        Dim counter, sum As Integer
        For counter = 1 To 100 Step 10
            sum += counter
            lBoxItems.Items.Add(sum)
        Next
    End Sub
End Class
