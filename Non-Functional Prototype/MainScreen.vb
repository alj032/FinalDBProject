Public Class MainScreen
    Protected db As New db
    Protected question_id As Integer
    Protected answer_id As Integer


    Private Sub MyCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyCartToolStripMenuItem.Click
        MyCart.Show()
    End Sub

    Private Sub ButtonMovies_Click(sender As Object, e As EventArgs) Handles ButtonMovies.Click
        db.sql = "SELECT * FROM Items"

        db.fill(DataGridViewMain)
    End Sub

    Private Sub ManagersScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagersScreenToolStripMenuItem.Click
        ManagerScreen.Show()
    End Sub

    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click

    End Sub
End Class
