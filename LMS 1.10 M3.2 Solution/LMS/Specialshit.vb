Public Class Specialshit
    Private Sub roundCorners(obj As Form)

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 15, 15), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 15, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 15, 0, 15, 15), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 15)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 15, obj.Height - 15, 15, 15), 0, 90)
        DGP.AddLine(obj.Width - 20, obj.Height, 20, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 15, 15, 15), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Private Sub Specialshit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Close()
    End Sub
End Class