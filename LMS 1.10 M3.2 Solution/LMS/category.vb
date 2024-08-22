Public Class categorywindow
    Private Sub cataddbtn_Click(sender As Object, e As EventArgs) Handles cataddbtn.Click
        Form1.category.Items.Insert(1, addcategory.Text)
        Form1.category.SelectedIndex = 1

        query = "INSERT INTO tblcategory values ('" & addcategory.Text & "')
                 SELECT * FROM tblcategory ORDER BY fldcategory ASC"
        exec()
        Me.Close()

    End Sub

    Private Sub catcancelbtn_Click(sender As Object, e As EventArgs) Handles catcancelbtn.Click
        Form1.category.SelectedIndex = -1
        Me.Close()
    End Sub
End Class