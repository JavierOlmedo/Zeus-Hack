Public Class about

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        System.Diagnostics.Process.Start("https://twitter.com/JJavierOlmedo")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("https://hackpuntes.com/")
    End Sub
End Class