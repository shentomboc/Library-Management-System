Public Class Form1
    Dim tabpages As Object()
    Dim nostudentborrow, nofacultyborrow As Integer
    Dim tempsearch As String

    'REQUEST
    'when add a quantity available add to  |
    'in registerng if id number already there ID Number Already registered  |
    'put some notice 'that student or faculties have limited books to borrow  ins  |
    'we need another table for no of books to be borrowed  |
    'accession number should't be repeated  |
    'all books cms not in proper location  |

    'FINISHING PART
    'make the duedate available to each form, maybe add a module  |
    'adjust all input fields, later  |
    'organize your code please!  '
    'what if differemt query one exec, then just add the query  

    'ERRORS ENCOUNTERED
    'update button not updating  |
    'student can't remove  |
    'when lost = lost  |
    'if user is remove, remove all borrowed books  |
    'when returned update available  |
    'add msg box in adding new book  |
    'update quality shouldn't below available books ex. av = 8 quality shouldexceed to 8  | = 0
    'not updating in home when removing  |
    'user search  |
    'erroe when search is in process, and moving to other tab  |
    'Overdue Return, all dissapear after click but only one removed  |
    'when add category is selected, invalid  |
    'when update, available is a shit  |
    'add to issued books (overude and lost)  |
    'LCase each ID number, to prevent duplicates  |
    'the borrow limmit not working  |
    'when searching available column = nothing shows  |
    'when a book is removed, remove all info EVERYTHING  |
    'accession no wrong count when exceed 20  |
    'when removed all books not updating as well as home  |
    'when user is removed and have issued, all books checked out will be available  |
    'transaction have repeated AN but unique time, sort it  |
    'overdue should also be in transaction  |
    'double check overdue, if same 8 am and 8 pm  |
    'login focus  |

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabpages = {home, allbooks, borrowedbooks, overduebooks, lostbooks, newbook, admin, faculty, student, adduser, complete, pending}

        tabpagefilter("Home")
        DueDateChecker()
        Homedisplay()
        Categorylist()
    End Sub

    Public Sub Categorylist()
        query = "SELECT * FROM tblcategory"
        exec()
        For Each r As DataRow In dt.Rows
            category.Items.Add(r(0))
        Next
    End Sub

    Public Sub tabpagefilter(t)             'menu display tab
        For Each i In tabpages
            TabControl1.TabPages.Remove(i)
            If i.Text = t Then
                TabControl1.TabPages.Insert(0, i)
                If i.Text = "Pending" Then
                    TabControl1.TabPages.Insert(0, complete)
                    TabControl1.SelectedIndex = 0
                End If
            End If
        Next
    End Sub

    Public Sub Clear()                      'clear all new book fields
        Dim temp As Object() = {isbn, title, author, editor, publicationplace, publisher, edition}
        For k = 0 To UBound(temp)
            temp(k).Clear()
        Next
        category.SelectedIndex = -1
        loanperiod.Value = 0
    End Sub

    Public Sub Homedisplay()                        'home tab Loader contents counter
        query = "SELECT (SELECT COUNT(*) FROM tblbookinfos), (SELECT COUNT(*) FROM tbluserbook WHERE fldstatus = 'Checked Out'), (SELECT COUNT(*) FROM tbluserbook WHERE fldstatus = 'Overdue'), (SELECT COUNT(*) FROM tbluserbook WHERE (fldstatus = 'Change' OR fldstatus = 'Pay')), 
                (SELECT COUNT(*) FROM tblusers WHERE fldusertype <> 'admin'), (SELECT COUNT(*) FROM tblusers WHERE fldusertype = 'Faculty'), (SELECT COUNT(*) FROM tblusers WHERE fldusertype = 'Student'), (SELECT COUNT(*) FROM tblbookinfos WHERE fldstatus = 'Available')"
        exec()
        Dim q As Object() = {totalbooks, totalborrowed, totallost, totaluser}
        For Each r As DataRow In dt.Rows
            If r(0) Is DBNull.Value Then Exit For
            totalbooks.Text = r(0)
            totalborrowed.Text = r(1) + r(2) + r(3)
            totaloverdue.Text = r(2)
            totallost.Text = r(3)
            totaluser.Text = r(4)
            totalavailable.Text = r(7)
            totalfaculties.Text = r(5)
            totalstudents.Text = r(6)
        Next
    End Sub

    Public Sub View()                         'from all books tab
        booklv.Items.Clear()
        query = "SELECT * FROM tblbookinfos ORDER BY ID ASC"
        exec()

        For Each r As DataRow In dt.Rows
            If r(0) = Nothing Then Exit Sub
            booklv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8), r(9), r(10)}))
        Next
    End Sub

    Public Sub Bookstatdisplay(templv1)       'overdue, and lost Tab Listview Loader
        templv1.Items.Clear()
        If templv1 Is lostlv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact, tbluserbook.fldstatus  
                     FROM ((tbluserbook INNER JOIN tblbookinfos On tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) WHERE tbluserbook.fldstatus = 'Change' OR tbluserbook.fldstatus = 'Pay' ORDER BY tbluserbook.ID ASC"
            exec()
            For Each r As DataRow In dt.Rows
                templv1.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8), r(9)}))
            Next
            Exit Sub
        End If
        If templv1 Is overduelv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact  
                     FROM ((tbluserbook INNER JOIN tblbookinfos On tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) WHERE tbluserbook.fldstatus = 'Overdue' ORDER BY tbluserbook.ID ASC"
        ElseIf templv1 Is borrowedlv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact  
                     FROM ((tbluserbook INNER JOIN tblbookinfos ON tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) ORDER BY tbluserbook.ID ASC"
        End If
        exec()
        For Each r As DataRow In dt.Rows
            templv1.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8)}))
        Next
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If booklv.SelectedItems.Count = 0 Then Exit Sub
        Dim ans As String = MsgBox("Do you want to Update Info of this Book?", vbInformation + vbYesNo, "Confirmation Box")
        If ans = vbYes Then
            gsearch.Text = "Search"
            gsearch.Visible = False
            Dim templp1 As Integer
            tabpagefilter("New Book")
            clearbtn.Enabled = False
            addbtn.Text = "Update"

            accessionno.Text = booklv.SelectedItems(0).Text
            Dim txt As TextBox() = {title, author, editor, edition, publicationplace, publisher, isbn}
            For k = 0 To UBound(txt)
                txt(k).Text = booklv.SelectedItems(0).SubItems(k + 1).Text
            Next

            Int32.TryParse(booklv.SelectedItems(0).SubItems(9).Text, templp1)
            loanperiod.Value = templp1
            category.Text = booklv.SelectedItems(0).SubItems(8).Text
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If booklv.SelectedItems.Count = 0 Then Exit Sub
        Dim temp As String = booklv.SelectedItems(0).SubItems(0).Text
        Dim ans As String = MsgBox("Are you sure?", vbYesNo, "Confirmation")
        If ans = vbYes Then
            gsearch.Text = "Search"
            query = "DELETE FROM tblbookinfos WHERE fldaccessionno = '" & temp & "'
                         DELETE FROM tbluserbook WHERE fldaccessionno = '" & temp & "'"
            exec()
            Specialshit.Show()
            booklv.SelectedItems(0).Remove()
        End If
    End Sub

    Public Sub ReturnStripMenu(templv)              'return strip menu updater (tasker)
        If templv.SelectedItems.Count = 0 Then Exit Sub
        query = "DELETE FROM tbluserbook WHERE fldidnumber = '" & templv.SelectedItems(0).SubItems(6).Text & "' AND fldaccessionno = '" & templv.SelectedItems(0).SubItems(0).Text & "'"
        exec()
        query = "UPDATE tblbookinfos SET fldstatus = 'Available' WHERE fldaccessionno = '" & templv.SelectedItems(0).SubItems(0).Text & "'"
        exec()
        transstat(templv.SelectedItems(0).SubItems(4).Text, templv.SelectedItems(0).SubItems(0).Text, templv.SelectedItems(0).SubItems(6).Text)
        templv.SelectedItems(0).Remove()
    End Sub

    Private Sub ReturnedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedToolStripMenuItem.Click
        If TabControl1.SelectedTab Is borrowedbooks Then
            ReturnStripMenu(borrowedlv)
        ElseIf TabControl1.SelectedTab Is overduebooks Then
            ReturnStripMenu(overduelv)
        ElseIf TabControl1.SelectedTab Is lostbooks Then
            ReturnStripMenu(lostlv)
        End If
        Specialshit.Show()
    End Sub

    Public Sub AccessionNoFormat()          'YY#
        Dim year, anyear, ano, tempan, lastan As Integer
        year = Convert.ToInt32(Now.ToString("yy"))
        query = "SELECT COUNT(*) FROM tblbookinfos WHERE fldaccessionno Like '" & year & "%'"
        exec()
        For Each r As DataRow In dt.Rows
            If r(0) = 0 Then
                tempan = year & 1
                accessionno.Text = tempan
                Exit Sub
            Else
                query = "SELECT MAX(fldaccessionno) FROM tblbookinfos WHERE fldaccessionno Like '" & year & "%'"
                exec()
                For Each rr As DataRow In dt.Rows
                    lastan = rr(0)
                    anyear = lastan.ToString().Substring(0, 2)
                    ano = lastan.ToString().Remove(0, 2)
                Next
                Int32.Parse(anyear)
                If anyear = year Then
                    tempan = year & ano + 1
                Else
                    tempan = year & 1
                End If
                accessionno.Text = tempan
            End If
        Next
    End Sub

    Public Sub ANF()                        'YY-MM-#
        Dim dash As String = "-"
        Dim year, ANyear, ANDg1, tempAN, lastAN As String
        Dim ANdg As Integer

        year = Date.Now.ToString("yy-MM")
        query = "SELECT COUNT(*) FROM tblbookinfos WHERE fldaccessionno Like '" & year & "%'"
        exec()
        For Each r As DataRow In dt.Rows        'check if empty 'neccessary for first use
            If r(0) = 0 Then
                tempAN = year & dash & "01"
                accessionno.Text = tempAN
                Exit Sub
            Else
                query = "SELECT TOP 1 fldaccessionno FROM tblbookinfos ORDER BY ID DESC"
                exec()
                For Each rr As DataRow In dt.Rows
                    lastAN = rr(0)
                    ANyear = lastAN.ToString().Substring(0, 5)
                    ANdg = lastAN.ToString().Remove(0, 6) + 1
                    ANDg1 = String.Format("{0:0#}", ANdg)
                    If ANyear = year Then
                        tempAN = year & dash & ANDg1
                    Else
                        tempAN = year & dash & "01"
                    End If
                    accessionno.Text = tempAN
                Next
            End If
        Next
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click             'new book tab addbutton
        Dim entries As Object = {accessionno, title, author, editor, edition, publicationplace, publisher, isbn, category, loanperiod}
        For k = 0 To UBound(entries)
            If entries(k).Text = "" Then
                MsgBox("Incomplete Data", vbInformation, "Add Failed!")
                Exit Sub
            End If
        Next

        If addbtn.Text = "Add" Then
            'MsgBox("Book Added Successfully", vbInformation, "Add Success")
            query = "INSERT INTO tblbookinfos VALUES ('" & entries(0).Text & "','" & entries(1).Text & "','" & entries(2).Text & "','" & entries(3).Text & "','" & entries(4).Text & "','" & entries(5).Text & "','" & entries(6).Text & "','" & entries(7).Text & "','" & entries(8).Text & "','" & entries(9).Value & "','Available')"
            exec()
            'AccessionNoFormat()
            ANF()
        Else            'update
            query = "UPDATE tblbookinfos SET fldtitle = '" & title.Text & "', fldauthor1 ='" & author.Text & "', fldeditor ='" & editor.Text & "',fldedition ='" & edition.Text & "',fldpublicationplace ='" & publicationplace.Text & "',fldpublisher ='" & publisher.Text & "',fldcategory ='" & category.Text & "',fldisbn='" & isbn.Text & "', fldloanperiod='" & loanperiod.Value & "' where fldaccessionno ='" & accessionno.Text & "'"
            exec()
            clearbtn.Enabled = True
            gsearch.Visible = True
            addbtn.Text = "Add"
            tabpagefilter("All Books")
            Clear()
            View()
        End If
        Specialshit.Show()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Clear()
    End Sub

    Public Sub LibrarianTab()                                   'Librarian Tab Loader
        query = "SELECT fldidnumber, fldpassword, fldcontact FROM tblusers WHERE fldname = 'admin'"
        exec()
        For Each r As DataRow In dt.Rows
            lusername.Text = r(0)
            lpassword.Text = r(1)
            lcontact.Text = r(2)
        Next

        query = "SELECT * FROM tblnoborrow"
        exec()
        For Each r As DataRow In dt.Rows
            nobookstudent.Value = r(0)
            nobookfaculty.Value = r(1)
        Next
    End Sub

    Private Sub lupdate_Click(sender As Object, e As EventArgs) Handles lupdate.Click               'librarian profile update
        If lusername.Enabled = False Then
            lupdate.Text = "Update"
            lusername.Enabled = True
            lpassword.Enabled = True
            lcontact.Enabled = True

        ElseIf lusername.Enabled = True Then
            lupdate.Text = "Change"
            lusername.Enabled = False
            lpassword.Enabled = False
            lcontact.Enabled = False
            query = "UPDATE tblusers SET fldidnumber = '" & lusername.Text & "', fldpassword = '" & lpassword.Text & "', fldcontact = '" & lcontact.Text & "' WHERE fldname = 'admin'"
            exec()
        End If
    End Sub

    Private Sub noupdate_Click(sender As Object, e As EventArgs) Handles noupdate.Click           'libraian no of borrows loader (below in librarian tab)
        If nobookstudent.Enabled = False Then       'first press
            noupdate.Text = "Update"
            nobookstudent.Enabled = True
            nobookfaculty.Enabled = True
            closetime.Enabled = True
        Else                                        'second press
            noupdate.Text = "Change"
            nostudentborrow = nobookstudent.Value
            nofacultyborrow = nobookfaculty.Value
            nobookstudent.Enabled = False
            nobookfaculty.Enabled = False
            closetime.Enabled = False
            query = "UPDATE tblnoborrow SET fldnoborrowstudent = " & nobookstudent.Value & ", fldnoborrowstaff = " & nobookfaculty.Value & ", fldclose = " & closetime.Value & " "
            exec()
        End If
    End Sub

    Public Sub userlvdisplay(userlv)                    'users in each user tab Loader
        query = "SELECT fldidnumber, fldname, fldcontact, (SELECT COUNT(*) from tbluserbook WHERE fldidnumber = tblusers.fldidnumber) AS 'ISSUED' ,
                (SELECT COUNT(*) from tbluserbook WHERE fldstatus = 'Overdue' AND fldidnumber = tblusers.fldidnumber), (SELECT COUNT(*) from tbluserbook WHERE (fldstatus = 'Change' OR fldstatus = 'Pay') AND fldidnumber = tblusers.fldidnumber), fldusertype from tblusers ORDER BY ISSUED DESC"
        exec()
        userlv.Items.Clear()
        For Each r As DataRow In dt.Rows
            If r(6) = "Faculty" Then
                facultylv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5)}))
            ElseIf r(6) = "Student" Then
                userslv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5)}))
            End If
        Next
    End Sub

    Public Sub criticremove(templv99, idn)
        If templv99.SelectedItems(0).SubItems(3).Text <> 0 Then
            query = "UPDATE tblbookinfos SET tblbookinfos.fldstatus = 'Available' FROM tblbookinfos INNER JOIN tbluserbook ON tblbookinfos.fldaccessionno= tbluserbook.fldaccessionno WHERE tbluserbook.fldidnumber  ='" & idn & "'"
            exec()
        End If
    End Sub

    Public Sub removeuser(templv9)
        Dim temp As String = templv9.SelectedItems(0).SubItems(0).Text
        Dim ans As String = MsgBox("Do you want to Remove this User?" & vbCrLf & "This action cannot be undone", vbYesNo, "Confirmation") 'this action cannot be undone
        If ans = vbYes Then
            criticremove(templv9, temp)
            Specialshit.Show()
            query = "DELETE FROM  tblusers WHERE fldidnumber = '" & temp & "'
                     DELETE FROM tbluserbook WHERE fldidnumber  = '" & temp & "'"
            exec()

            templv9.SelectedItems(0).Remove()
        End If
        'userlvdisplay(templv9)
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        If userslv.SelectedItems.Count > 0 Then
            removeuser(userslv)
        ElseIf facultylv.SelectedItems.Count > 0 Then
            removeuser(facultylv)
        Else
            MsgBox("Please Select User first!", vbInformation, "No User Selected!")
        End If
        'gsearch.Text = "Search"
    End Sub

    Private Sub rregisterbtn_Click(sender As Object, e As EventArgs) Handles rregisterbtn.Click
        If rrole.Text = "" Or ridnumber.Text = "" Or rname.Text = "" Or rpassword.Text = "" Or rcontact.Text = "" Then
            MsgBox("Please Complete the Required Data", vbInformation, "Sign Up Failed")
        ElseIf rcontact.Text.Length < 11 Then
            contacterror.Visible = True
            Exit Sub
        Else
            query = "SELECT fldidnumber FROM tblusers"
            exec()
            For Each r As DataRow In dt.Rows
                Dim Lr, Li As String
                Lr = UCase(r(0))
                Li = UCase(ridnumber.Text)
                If Lr = Li Then
                    MsgBox("ID Number Already Registered. Try Logging in", vbInformation, "ID Number Existed!")
                    Exit Sub
                End If
            Next
            contacterror.Visible = False
            query = "INSERT INTO tblusers VALUES ('" & ridnumber.Text & "','" & rpassword.Text & "','" & rname.Text & "','" & rcontact.Text & "','" & rrole.Text & "')"
            exec()
            Specialshit.Show()
            'MsgBox("Account Created!", vbOK, "Sign up Successful")
            registerclear()
        End If
    End Sub

    Public Sub registerclear()          'registration clear
        rrole.SelectedIndex = -1
        ridnumber.Clear()
        rname.Clear()
        rpassword.Clear()
        rcontact.Clear()
    End Sub

    Public Sub TransactionDisplay(templvCP)
        templvCP.Items.Clear()
        If templvCP Is completelv Then
            query = "SELECT * from tbltransaction WHERE fldstatus = 'Complete' ORDER BY ID DESC"
        ElseIf templvCP Is pendinglv Then
            query = "SELECT * from tbltransaction WHERE fldstatus = 'Pending' ORDER BY ID DESC"
        End If
        exec()
        For Each r As DataRow In dt.Rows
            templvCP.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(6)}))
        Next
    End Sub

    Public Sub transstat(tempBD, tempAN, tempID)   'when a book is returned transaction completes
        Dim type As String
        query = "SELECT fldtype FROM tbltransaction WHERE flddate = '" & tempBD & "' AND fldaccessionno = '" & tempAN & "' AND fldidnumber ='" & tempID & "'"
        exec()
        For Each r As DataRow In dt.Rows
            If r(0) = "Return" Then
                type = "Returned"
            ElseIf r(0) = "Overdue" Then
                type = "Overdue"
            ElseIf r(0) = "Pay" Then
                type = "Paid"
            ElseIf r(0) = "Change" Then
                type = "Changed"
            End If
        Next
        Dim d As Date = Date.Now
        query = "UPDATE tbltransaction SET fldreturndate = '" & d & "',fldstatus = 'Complete', fldtype = '" & type & "' WHERE fldaccessionno = '" & tempAN & "' AND fldidnumber = '" & tempID & "'"
        exec()
    End Sub

    Private Sub gsearch_TextChanged(sender As Object, e As EventArgs) Handles gsearch.TextChanged
        Dim x As String = TabControl1.SelectedTab.Text
        If x = "All Books" Then
            allbooksearch(gsearch.Text)
        ElseIf x = "Issued Books" Then
            bookoverlostsearch(gsearch.Text, borrowedlv)
        ElseIf x = "Overdue Books" Then
            bookoverlostsearch(gsearch.Text, overduelv)
        ElseIf x = "Lost Books" Then
            bookoverlostsearch(gsearch.Text, lostlv)
        ElseIf x = "Student" Then
            usersearch(gsearch.Text, userslv, "Student")
        ElseIf x = "Faculty" Then
            usersearch(gsearch.Text, facultylv, "Faculty")
        ElseIf x = "Complete" Then
            Transactionsearch(gsearch.Text, completelv)
        ElseIf x = "Pending" Then
            Transactionsearch(gsearch.Text, pendinglv)
        End If
    End Sub

    Public Sub allbooksearch(keyword)
        If keyword <> "Search" Or keyword = "" Then
            query = "SELECT * FROM tblbookinfos WHERE fldaccessionno LIKE '%" & keyword & "%' OR fldtitle LIKE '%" & keyword & "%' OR fldauthor1 LIKE '%" & keyword & "%' OR fldedition LIKE '%" & keyword & "%' OR fldisbn LIKE '%" & keyword & "%' OR fldcategory LIKE '%" & keyword & "%'"
            exec()
            booklv.Items.Clear()
            For Each r As DataRow In dt.Rows
                booklv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8), r(9), r(10)}))
            Next
        End If
    End Sub

    Public Sub bookoverlostsearch(keyword, templv)
        If keyword = "Search" Then Exit Sub
        If templv Is lostlv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact, tbluserbook.fldstatus
		        FROM ((tbluserbook INNER JOIN tblbookinfos ON tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) 
                INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) WHERE (tbluserbook.fldstatus = 'Pay' OR tbluserbook.fldstatus = 'Change') AND ( tblbookinfos.fldaccessionno LIKE '%" & keyword & "%' OR tblbookinfos.fldtitle  LIKE '%" & keyword & "%' OR tblbookinfos.fldauthor1  LIKE '%" & keyword & "%' 
                OR tblbookinfos.fldedition  LIKE '%" & keyword & "%' OR tbluserbook.fldissued LIKE '%" & keyword & "%' OR tbluserbook.flddue  LIKE '%" & keyword & "%' OR tblusers.fldidnumber  LIKE '%" & keyword & "%' OR tblusers.fldname  LIKE '%" & keyword & "%' OR tblusers.fldcontact   LIKE '%" & keyword & "%') ORDER BY tbluserbook.fldissued ASC"
            exec()
            templv.Items.Clear()
            For Each r As DataRow In dt.Rows
                templv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8), r(9)}))
            Next
            Exit Sub
        End If
        If templv Is borrowedlv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact  
		        FROM ((tbluserbook INNER JOIN tblbookinfos ON tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) 
                INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) WHERE tblbookinfos.fldaccessionno LIKE '%" & keyword & "%' OR tblbookinfos.fldtitle  LIKE '%" & keyword & "%' OR tblbookinfos.fldauthor1  LIKE '%" & keyword & "%' 
                OR tblbookinfos.fldedition  LIKE '%" & keyword & "%' OR tbluserbook.fldissued LIKE '%" & keyword & "%' OR tbluserbook.flddue  LIKE '%" & keyword & "%' OR tblusers.fldidnumber  LIKE '%" & keyword & "%' OR tblusers.fldname  LIKE '%" & keyword & "%' OR tblusers.fldcontact   LIKE '%" & keyword & "%' "
        ElseIf templv Is overduelv Then
            query = "SELECT tblbookinfos.fldaccessionno,tblbookinfos.fldtitle,tblbookinfos.fldauthor1,tblbookinfos.fldedition, tbluserbook.fldissued, tbluserbook.flddue, tblusers.fldidnumber, tblusers.fldname,tblusers.fldcontact  
		        FROM ((tbluserbook INNER JOIN tblbookinfos ON tbluserbook.fldaccessionno=tblbookinfos.fldaccessionno) 
                INNER JOIN tblusers ON tbluserbook.fldidnumber=tblusers.fldidnumber) WHERE (tbluserbook.fldstatus = 'Overdue') AND ( tblbookinfos.fldaccessionno LIKE '%" & keyword & "%' OR tblbookinfos.fldtitle  LIKE '%" & keyword & "%' OR tblbookinfos.fldauthor1  LIKE '%" & keyword & "%' 
                OR tblbookinfos.fldedition  LIKE '%" & keyword & "%' OR tbluserbook.fldissued LIKE '%" & keyword & "%' OR tbluserbook.flddue  LIKE '%" & keyword & "%' OR tblusers.fldidnumber  LIKE '%" & keyword & "%' OR tblusers.fldname  LIKE '%" & keyword & "%' OR tblusers.fldcontact   LIKE '%" & keyword & "%') "
        End If
        exec()
        templv.Items.Clear()
        For Each r As DataRow In dt.Rows
            templv.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5), r(6), r(7), r(8)}))
        Next
    End Sub

    Public Sub usersearch(keyword, templv3, usertype)
        If keyword = "Search" Then Exit Sub
        query = "SELECT fldidnumber, fldname, fldcontact, (SELECT COUNT (*) from tbluserbook WHERE fldstatus = 'Checked Out' AND fldidnumber = tblusers.fldidnumber) ,
                (SELECT COUNT (*) from tbluserbook WHERE fldstatus = 'Overdue' AND fldidnumber = tblusers.fldidnumber), (SELECT COUNT (*) from tbluserbook WHERE (fldstatus = 'Change' OR fldstatus = 'Pay') AND fldidnumber = tblusers.fldidnumber)
                FROM tblusers WHERE (fldusertype = '" & usertype & "') AND (fldidnumber LIKE '%" & keyword & "%' OR fldname LIKE '%" & keyword & "%' OR fldcontact LIKE '%" & keyword & "%')"
        exec()
        templv3.Items.Clear()
        For Each r As DataRow In dt.Rows
            templv3.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(5)}))
        Next
    End Sub

    Public Sub Transactionsearch(keyword, templv01)
        If keyword = "Search" Then Exit Sub
        If templv01 Is completelv Then
            query = "SELECT * FROM tbltransaction WHERE (fldstatus = 'Complete') AND (flddate LIKE '%" & keyword & "%' OR fldreturndate LIKE '%" & keyword & "%' OR fldidnumber LIKE '%" & keyword & "%' OR fldaccessionno LIKE '%" & keyword & "%' OR fldtitle LIKE  '%" & keyword & "%' OR fldstatus LIKE  '%" & keyword & "%') ORDER BY flddate DESC"
        ElseIf templv01 Is pendinglv Then
            query = "SELECT * FROM tbltransaction WHERE (fldstatus = 'Pending') AND (flddate LIKE '%" & keyword & "%' OR fldreturndate LIKE '%" & keyword & "%' OR fldidnumber LIKE '%" & keyword & "%' OR fldaccessionno LIKE '%" & keyword & "%' OR fldtitle LIKE  '%" & keyword & "%' OR fldstatus LIKE  '%" & keyword & "%') ORDER BY flddate DESC"
        End If
        exec()
        templv01.Items.Clear()
        For Each r As DataRow In dt.Rows
            templv01.Items.Add(New ListViewItem({r(0), r(1), r(2), r(3), r(4), r(6)}))
        Next
    End Sub
    Private Sub gsearch_Enter(sender As Object, e As EventArgs) Handles gsearch.Enter
        If gsearch.Text = "Search" Then
            gsearch.Text = ""
        End If
    End Sub

    Private Sub gsearch_Leave(sender As Object, e As EventArgs) Handles gsearch.Leave
        If gsearch.Text.Length = 0 Then
            gsearch.Text = "Search"
        End If
    End Sub

    Private Sub rcancelbtn_Click(sender As Object, e As EventArgs) Handles rcancelbtn.Click
        registerclear()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        gsearch.Text = "Search"
    End Sub
    Private Sub category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles category.SelectedIndexChanged
        If category.Text = "(add category)" Then
            categorywindow.Show()
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        If addbtn.Text = "Update" Then
            Clear()
        End If
        tabpagefilter("All Books")
        gsearch.Visible = True
        View()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        gsearch.Visible = False
        tabpagefilter("Home")
        Homedisplay()
        DueDateChecker()
    End Sub
    Private Sub AllBooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AllBooksToolStripMenuItem1.Click
        tabpagefilter("All Books")
        gsearch.Visible = True
        View()
    End Sub
    Private Sub BorrowedBooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrowedBooksToolStripMenuItem1.Click
        tabpagefilter("Issued Books")
        gsearch.Visible = True
        Bookstatdisplay(borrowedlv)
    End Sub
    Private Sub OverdueBooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OverdueBooksToolStripMenuItem1.Click
        tabpagefilter("Overdue Books")
        gsearch.Visible = True
        Bookstatdisplay(overduelv)
    End Sub
    Private Sub LostBooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LostBooksToolStripMenuItem1.Click
        tabpagefilter("Lost Books")
        gsearch.Visible = True
        Bookstatdisplay(lostlv)
    End Sub
    Private Sub NewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBookToolStripMenuItem.Click
        gsearch.Visible = False
        tabpagefilter("New Book")
        'AccessionNoFormat()
        ANF()
    End Sub
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        gsearch.Visible = False
        tabpagefilter("Librarian")
        LibrarianTab()
    End Sub
    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        tabpagefilter("Faculty")
        gsearch.Visible = True
        gsearch.Text = "Search"
        userlvdisplay(facultylv)
    End Sub
    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        tabpagefilter("Student")
        gsearch.Visible = True
        gsearch.Text = "Search"
        userlvdisplay(userslv)
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        gsearch.Visible = False
        tabpagefilter("Add")
    End Sub
    Private Sub TransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem.Click
        tabpagefilter("Pending")
        gsearch.Visible = True
        TransactionDisplay(completelv)
        TransactionDisplay(pendinglv)
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim ans As String = MsgBox("Do you want to Logout?", vbYesNo, "Confirmation")
        If ans = vbYes Then
            Me.Close()
            Login.Show()
            Login.loginbtn.Select()
        End If
    End Sub
    Private Sub accessionno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles accessionno.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub lcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lcontact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub rcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rcontact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles isbn.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

'Simple Library Management System by Team MUJI (plain) (BSCOE2A)