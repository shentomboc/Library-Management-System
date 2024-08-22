Imports System.Data.OleDb
Module Module1
    Public connectionString As String = "Provider=SQLOLEDB.1 ; Persist Security Info=true ; User ID=sa ; Password=8080 ; Initial Catalog = dbLMS3 ; Data Source=LAPTOP-GBJE49GS\SQLEXPRESS"
    Public conn As New OleDbConnection(connectionString)
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter

    Public dt As DataTable
    Public cnt As Long
    Public query As String

    Public Sub exec()
        If conn.State = ConnectionState.Open Then conn.Close()
        Try
            conn.Open()
            cmd = New OleDbCommand(query, conn)
            da = New OleDbDataAdapter(cmd)
            dt = New DataTable()
            cnt = da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub DueDateChecker()
        query = "SELECT * FROM tbluserbook"
        exec()
        Dim id As Date
        id = Date.Now
        For Each r As DataRow In dt.Rows
            If r(3) < id Then
                If r(4) = "Checked Out" Then
                    query = "UPDATE tbluserbook SET fldstatus = 'Overdue' WHERE fldidnumber = '" & r(0) & "' AND fldaccessionno = '" & r(1) & "'
                             UPDATE tbltransaction SET fldtype = 'Overdue' WHERE fldidnumber = '" & r(0) & "' AND fldaccessionno = '" & r(1) & "'"
                    exec()
                End If
            End If
        Next
    End Sub
End Module
