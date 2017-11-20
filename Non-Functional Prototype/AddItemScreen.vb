Public Class AddItemScreen
    Protected db As New db


    Private Sub AddItemScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT Title,
		                Quantity,
		                Price,
		                Times_Rented, 
		                Category,
		                Rating

		


                    From Item
                    Where Category = 'TV Show'"
        db.fill(DataGridView1)
    End Sub
End Class