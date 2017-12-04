Public Class SalesData
    Protected db As New db



    Protected Function GetYear() As Integer

        db.sql = "Select Date_Out From CheckoutHistory"
        db.execute()



        Return GetYear()
    End Function

    Protected Function GetPrice() As Integer

        db.sql = "Select  Sum(Price) AS 'Sales for 2017' From CheckoutHistory Where Date_Out Between '2017-01-01 00:00:00.000' And '2017-12-31 12:59:59.999'"
        db.execute()

        Return GetPrice()
    End Function



    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Chart1.Series("Year VS Sales").Points.AddXY(GetYear(), GetPrice())
    End Sub
End Class