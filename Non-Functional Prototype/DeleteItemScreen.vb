Public Class DeleteItemScreen
    Protected db As New db

    Private Sub DeleteItemScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Form Loading up

        ''Fill DataGridView
        db.sql = "SELECT *	From Item"
        db.fill(DataGridView1)



    End Sub
    Private Sub ButtonEnable_Click(sender As Object, e As EventArgs) Handles ButtonEnable.Click
        ''what happens when we enable editing mode

        ''hiding unecessary buttons
        ButtonEnable.Visible = False
        ButtonDelete.Visible = False

        ''showing usefull buttons
        ButtonDisable.Visible = True
        ButtonUpdate.Visible = True


    End Sub

    Private Sub ButtonDisable_Click(sender As Object, e As EventArgs) Handles ButtonDisable.Click
        ''What happens when we disable editing mode

        ''showing usefull buttons
        ButtonEnable.Visible = True
        ButtonDelete.Visible = True


        ''hiding unecessary buttons
        ButtonDisable.Visible = False
        ButtonUpdate.Visible = False


    End Sub


End Class