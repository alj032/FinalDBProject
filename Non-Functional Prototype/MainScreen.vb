Public Class MainScreen
    Protected db As New db
    Dim index As Integer

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''When the form loads 

        DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub
    Private Sub MyCartToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MyCart.Show()
    End Sub

    Private Sub ButtonMovies_Click(sender As Object, e As EventArgs) Handles ButtonMovies.Click
        ''MOVIES when we click this we want to fill the DGV with only movies

        ''Filling the DGV below is just a test for now
        db.sql = "SELECT Title, Category, Price, Rating, Quantity From Movies"
        db.fill(DataGridViewMain)

    End Sub
    Private Sub ButtonVideoGames_Click(sender As Object, e As EventArgs) Handles ButtonVideoGames.Click
        ''VIDEO GAMES 

        ''Fill DGV
        db.sql = "SELECT Title, Category, Price, Rating, Quantity From Video_Games"
        db.fill(DataGridViewMain)
    End Sub
    Private Sub ButtonTV_Click(sender As Object, e As EventArgs) Handles ButtonTV.Click
        ''TV 

        ''Fill DGV
        db.sql = "SELECT Title, Category, Price, Rating, Quantity From TV_Shows"
        db.fill(DataGridViewMain)
    End Sub
    Private Sub ButtonTopSellers_Click(sender As Object, e As EventArgs) Handles ButtonTopSellers.Click
        ''TOP SELLERS
        db.sql = "SELECT top(10) Title, Category, Price, Rating, Quantity, Times_Rented

		


                 From Item
                 Order by Times_Rented Desc"
        db.fill(DataGridViewMain)
    End Sub





    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click
        ''Shows MyCart Form where user needs to enter information to checkout.
        MyCart.Show()
    End Sub

    Private Sub DataGridViewMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMain.CellClick
        LabelMovieTite.Visible = True
        index = e.RowIndex

        If (DataGridViewMain.SelectedRows.Count > 0) Then ''make Then sure user Select at least 1 row 

            LabelMovieTite.Text = DataGridViewMain.SelectedRows(0).Cells(0).Value
            TextBoxCategory.Text = DataGridViewMain.SelectedRows(0).Cells(1).Value
            TextBoxPrice.Text = DataGridViewMain.SelectedRows(0).Cells(2).Value
            TextBoxRating.Text = DataGridViewMain.SelectedRows(0).Cells(3).Value
            TextBoxQuantity.Text = DataGridViewMain.SelectedRows(0).Cells(4).Value

        End If



        ''What happens when the user clicks on a cell in the datagrid view

        ''If e.RowIndex >= 0 Then

        ''Dim row As DataGridViewRow
        ''row = Me.DataGridViewMain.Rows(e.RowIndex)
        ''Setting the textbox equal to their matching row.
        ''https://www.youtube.com/watch?v=m8syCe8Uamk


        ''End If

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs)
        ''https://www.youtube.com/watch?v=zn4zgBeUwnA
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''Show Manager Form when we click the menustrip button

    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        ManageInventoryScreen.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRating.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
