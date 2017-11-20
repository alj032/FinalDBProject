Public Class MainScreen
    Protected db As New db



    Private Sub MyCartToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MyCart.Show()
    End Sub

    Private Sub ButtonMovies_Click(sender As Object, e As EventArgs) Handles ButtonMovies.Click
        ''MOVIES when we click this we want to fill the DGV with only movies

        ''Filling the DGV below is just a test for now
        db.sql = "SELECT Title, 
		                [Year],
		                Quantity,
		                Price,
		                Times_Rented,
		                Category,
		                Rating
                         
                   From Item
                   Where Category = 'Movie'"
        db.fill(DataGridViewMain)

    End Sub
    Private Sub ButtonVideoGames_Click(sender As Object, e As EventArgs) Handles ButtonVideoGames.Click
        ''VIDEO GAMES 

        ''Fill DGV
        db.sql = "SELECT Title,
		                Quantity,
		                Price,
		                Times_Rented,
		                Category,
		                Rating,
		                [Platform],
		                Developers,
		                Publisher


                    From Item
                    Where Category = 'Video Game'"
        db.fill(DataGridViewMain)
    End Sub
    Private Sub ButtonTV_Click(sender As Object, e As EventArgs) Handles ButtonTV.Click
        ''TV 

        ''Fill DGV
        db.sql = "SELECT Title,
		                Quantity,
		                Price,
		                Times_Rented, 
		                Category,
		                Rating

		


                    From Item
                    Where Category = 'TV Show'"
        db.fill(DataGridViewMain)
    End Sub
    Private Sub ButtonTopSellers_Click(sender As Object, e As EventArgs) Handles ButtonTopSellers.Click
        ''TOP SELLERS
        db.sql = "SELECT top(10) Title,
		                        Quantity,
		                        Price,
		                        Times_Rented, 
		                        Category,
		                        Rating

		


                 From Item
                 Order by Times_Rented Desc"
        db.fill(DataGridViewMain)
    End Sub





    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click
        ''Shows MyCart Form where user needs to enter information to checkout.
        MyCart.Show()
    End Sub

    Private Sub DataGridViewMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMain.CellClick
        ''What happens when the user clicks on a cell in the datagrid view

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridViewMain.Rows(e.RowIndex)
            ''Setting the textbox equal to their matching row.
            'https://www.youtube.com/watch?v=m8syCe8Uamk'


        End If

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        ''https://www.youtube.com/watch?v=zn4zgBeUwnA
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        ''Show Manager Form when we click the menustrip button
        AddItemScreen.Show()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        DeleteItemScreen.Show()
    End Sub
End Class
