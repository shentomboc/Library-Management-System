Public Class User
    'logging in error different account |
    'unable to borrow same book |

    'ERROR ENCOUNTERED
    'viewbooks - overdue not updating  |
    'when lost = lost  |
    'search bar | added just configure |
    'viewbooks excedded the number of books |
    'book tab, adding same book error, on second and so on  |

    Dim uptemp As Boolean = True
    Dim limiter, closetime As Integer
    Private Sub userwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BookView()
        DueDateChecker()
        UserProfile()
        nobooksdisplay()
        librarycontact()
    End Sub

    Public Sub UserProfile()
        query = "Select fldidnumber, fldpassword, fldname,fldcontact from tblusers where fldidnumber = '" & Login.idnumber.Text & "'"
        exec()

        For Each r As DataRow In dt.Rows
            uidnumber.Text = r(0)
            uname.Text = r(2)
            ucontact.Text = r(3)
            upassword.Text = r(1)
        Next
    End Sub

    Public Sub librarycontact()
        query = "Select fldcontact from tblusers where fldname = 'admin'"
        exec()

        For Each r As DataRow In dt.Rows
            libraryconctactnumber.Text = "Library Contact No. " & r(0)
        Next

        query = "Select tblusers.fldusertype, tblnoborrow.*  from tblusers, tblnoborrow where tblusers.fldidnumber = '" & uidnumber.Text & "'"
        exec()

        For Each r As DataRow In dt.Rows
            If r(0) = "Student" Then
                limiter = r(1)
                nobooksborrowdisplay.Text = "No. Books Students Can Borrow: " & r(1)
            ElseIf r(0) = "Faculty" Then
                limiter = r(2)
                nobooksborrowdisplay.Text = "No. Books Faculty Can Borrow: " & r(2)
            End If
            closetime = r(3)
        Next
    End Sub

    Public Sub nobooksdisplay()             'books on home numbers
        Dim cb, co, cl As Integer
        query = "SELECT fldidnumber, fldstatus from tbluserbook"
        exec()
        For Each r As DataRow In dt.Rows
            If r(0) = uidnumber.Text Then
                If r(1) = "Checked Out" Then
                    cb += 1
                ElseIf r(1) = "Overdue" Then
                    co += 1
                ElseIf r(1) = "Pay" Or r(1) = "Change" Then
                    cl += 1
                End If
            End If
        Next
        unobookborrowed.Text = cb + co + cl
        unobookoverdue.Text = co
        unobooklost.Text = cl
    End Sub

    Private Sub uupdatebtn_Click(sender As Object, e As EventArgs) Handles uupdatebtn.Click
        If uptemp = True Then
            upassword.Enabled = True
            uname.Enabled = True
            ucontact.Enabled = True
            uptemp = False
        Else
            If upassword.Text = "" Or uname.Text = "" Or ucontact.Text = "" Then

                MsgBox("Please Complete the Required Data", vbOKOnly, "Update Failed")
            Else
                query = "Update tblusers set fldpassword ='" & upassword.Text & "', fldname ='" & uname.Text & "', fldcontact='" & ucontact.Text & "' where fldidnumber = '" & uidnumber.Text & "'"
                exec()
                Specialshit.Show()
                'MsgBox("Account Updated!", vbOK, "Update Successful")
                upassword.Enabled = False
                uname.Enabled = False
                ucontact.Enabled = False
            End If
            uptemp = True
        End If
    End Sub

    Public Sub BookView()
        query = "Select * from tblbookinfos ORDER BY ID ASC"
        exec()
        For Each r As DataRow In dt.Rows
            ubooklv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(4), r(8), r(7), r(9), r(10)}))
        Next
    End Sub

    Private Sub BorrowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowToolStripMenuItem.Click
        If ubooklv.SelectedItems.Count = 0 Then Exit Sub
        Dim ans As String = MsgBox("Borrow This Book?", vbYesNo, "Confirmation")
        If ans = vbYes Then
            Dim n As Integer
            Int32.TryParse(unobookborrowed.Text, n)
            If n >= limiter Then
                MsgBox("Reached the Maximum Books", vbInformation, "Failed!")
            Else
                If ubooklv.SelectedItems(0).SubItems(7).Text = "Checked Out" Then
                    MsgBox("Currently Unavailable", vbInformation, "Unavailable!")
                Else
                    Dim tempaccessionno, temploan As String
                    Dim lp As Integer
                    Dim id, dd As Date
                    unobookborrowed.Text = n + 1                       'count +1 for Books
                    tempaccessionno = ubooklv.SelectedItems(0).SubItems(0).Text
                    temploan = ubooklv.SelectedItems(0).SubItems(6).Text
                    ubooklv.SelectedItems(0).SubItems(7).Text = "Checked Out"
                    Int32.TryParse(temploan, lp)
                    id = Date.Now
                    dd = DateAdd(DateInterval.Day, lp, id)
                    If lp = 0 Then
                        dd = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, closetime, 0, 0, 0)
                    End If
                    query = "INSERT INTO tbluserbook VALUES ('" & uidnumber.Text & "','" & tempaccessionno & "','" & id & "','" & dd & "','Checked Out')
                             UPDATE tblbookinfos SET fldstatus = 'Checked Out' WHERE fldaccessionno  = '" & tempaccessionno & "'
                             INSERT INTO tbltransaction VALUES('" & id & "','Pending','" & uidnumber.Text & "','" & tempaccessionno & "','" & ubooklv.SelectedItems(0).SubItems(1).Text & "','Pending','Return')"
                    exec()
                    Specialshit.Show()
                End If
            End If
        End If
    End Sub

    Private Sub usearch_TextChanged(sender As Object, e As EventArgs) Handles usearch.TextChanged
        If usearch.Text = "Search" Then Exit Sub
        query = "SELECT * FROM tblbookinfos where fldaccessionno LIKE '%" & usearch.Text &
                "%' OR fldtitle LIKE '%" & usearch.Text & "%' OR fldauthor1  LIKE '%" & usearch.Text &
                "%' OR fldisbn LIKE '%" & usearch.Text & "%' OR fldcategory  LIKE '%" & usearch.Text & "%'"
        exec()
        ubooklv.Items.Clear()
        For Each r As DataRow In dt.Rows
            ubooklv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(4), r(8), r(7), r(9), r(10)}))
        Next
    End Sub
    Private Sub usearch_Enter(sender As Object, e As EventArgs) Handles usearch.Enter
        If usearch.Text = "Search" Then
            usearch.Clear()
        End If
    End Sub
    Private Sub usearch_Leave(sender As Object, e As EventArgs) Handles usearch.Leave
        If usearch.Text.Length = 0 Then
            usearch.Text = "Search"
        End If
    End Sub
    Private Sub uviewbtn_Click_1(sender As Object, e As EventArgs) Handles uviewbtn.Click
        viewbooks.Show()
    End Sub
    Private Sub ulogout_Click(sender As Object, e As EventArgs) Handles ulogout.Click
        Me.Close()
        Login.Show()
        Login.loginbtn.Select()
    End Sub
    Private Sub ucontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucontact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class