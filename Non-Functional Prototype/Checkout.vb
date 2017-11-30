Public Class Checkout
    Protected db As New db

    Private Sub Refresh()

        db.sql = "Select * from ItemsCheckedOut Order by Date_Out ASC"
        db.fill(DataGridView1)

    End Sub


    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        db.sql = "Select * from ItemsCheckedOut Order by Date_Out ASC"
        db.fill(DataGridView1)

    End Sub

    Private Sub ButtonCheckIn_Click(sender As Object, e As EventArgs) Handles ButtonCheckIn.Click
        db.sql = "UPDATE checkout SET Date_in = GETDATE() WHERE Item_ID = @ID"
        db.bind("@ID", DataGridView1.SelectedRows(0).Cells(4).Value)
        db.execute()
        Refresh()


    End Sub
End Class