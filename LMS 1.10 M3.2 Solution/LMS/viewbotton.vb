Public Class viewbooks
    Public Sub viewbookdisplay()
        viewbooklv.Items.Clear()
        query = "Select tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldeditor, tblbookinfos.fldedition, tblbookinfos.fldisbn, tbluserbook.fldstatus, tbluserbook.fldissued, tbluserbook.flddue  
                from ((tbluserbook inner join tblbookinfos On tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) 
                inner join tblusers on tbluserbook.fldidnumber=tblusers.fldidnumber) where tbluserbook.fldidnumber = '" & User.uidnumber.Text & "'"
        exec()

        For Each r As DataRow In dt.Rows
            viewbooklv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8)}))
        Next
    End Sub
    Private Sub viewbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewbookdisplay()
    End Sub

    Public Sub statandtype(type)
        query = "UPDATE tbluserbook SET fldstatus = '" & type & "' WHERE fldidnumber ='" & User.uidnumber.Text & "' AND fldaccessionno = '" & viewbooklv.SelectedItems(0).SubItems(0).Text & "'
                 UPDATE tbltransaction SET fldtype = '" & type & "' WHERE fldidnumber ='" & User.uidnumber.Text & "' AND fldaccessionno = '" & viewbooklv.SelectedItems(0).SubItems(0).Text & "' "
        exec()
        viewbookdisplay()
        User.nobooksdisplay()
    End Sub
    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        statandtype("Change")
    End Sub
    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        statandtype("Pay")
    End Sub
End Class