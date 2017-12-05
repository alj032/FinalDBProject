Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

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
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=ISYS4283F1720;Trusted_Connection=yes;"}
        ' prepare a query
        Dim command As New SqlCommand With {.Connection = connection}


        Dim sqlsales As String = "Select Year(Date_out) AS 'Year', Sum(Price) As 'Total Sales' from CheckoutHistory Group by Year(Date_out) Order by Year(Date_out)"

        Dim adapter As New SqlDataAdapter(sqlsales, connection)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "CheckoutHistory")

        Dim chartarea1 As ChartArea = New ChartArea()
        Dim legend1 As Legend = New Legend()
        Dim series1 As Series = New Series()
        Dim chart1 = New Chart()
        Me.Controls.Add(chart1)
        chartarea1.Name = "ChartArea"
        chart1.ChartAreas.Add(chartarea1)
        legend1.Name = "Legend"
        chart1.Legends.Add(legend1)
        chart1.Location = New System.Drawing.Point(13, 13)
        chart1.Name = "Sales by Year"
        chart1.Titles.Add("Sales By Year")
        series1.ChartArea = "ChartArea"
        series1.Legend = "Legend"
        series1.Name = "series1"
        chart1.Series.Add(series1)
        chart1.Size = New System.Drawing.Size(1000, 400)
        chart1.TabIndex = 0
        chart1.Text = "chart1"
        chart1.Series("series1").XValueMember = "Year"
        chart1.Series("series1").YValueMembers = "Total Sales"
        chart1.ChartAreas(0).AxisX.Title = "Year"
        chart1.ChartAreas(0).AxisY.Title = "Total Annual Sales"



        chart1.DataSource = dataset.Tables("CheckoutHistory")




    End Sub


End Class