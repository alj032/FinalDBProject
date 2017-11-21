Public Class MyCart
    Protected db As New db


    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click


        ''db.sql = "INSERT INTO dbo.Checkout (Title, Quantity, Price, Times_Rented, Category, Rating) Values (@Title, @Quantity, @Price, @Times_Rented, @Category, @Rating);"
        ''db.bind("@Title", Title)
        ''db.bind("@Quantity", Quantity)
        ''db.bind("@Price", Price)
        ''db.bind("@Times_Rented", Times_Rented)
        ''db.bind("@Category", Category)
        ''db.bind("@Rating", Rating)
    End Sub
End Class