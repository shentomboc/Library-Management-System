<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewbooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewbooks))
        Me.viewbooklv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmslost = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LostChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmslost.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewbooklv
        '
        Me.viewbooklv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.viewbooklv.ContextMenuStrip = Me.cmslost
        Me.viewbooklv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewbooklv.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewbooklv.FullRowSelect = True
        Me.viewbooklv.HideSelection = False
        Me.viewbooklv.Location = New System.Drawing.Point(0, 0)
        Me.viewbooklv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.viewbooklv.Name = "viewbooklv"
        Me.viewbooklv.Size = New System.Drawing.Size(987, 507)
        Me.viewbooklv.TabIndex = 1
        Me.viewbooklv.UseCompatibleStateImageBehavior = False
        Me.viewbooklv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Accession No."
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 225
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Author"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Editor"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Edition"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ISBN"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 145
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Issued Date"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 180
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Due Date"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 180
        '
        'cmslost
        '
        Me.cmslost.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmslost.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LostChangeToolStripMenuItem})
        Me.cmslost.Name = "cmslost"
        Me.cmslost.Size = New System.Drawing.Size(181, 52)
        '
        'LostChangeToolStripMenuItem
        '
        Me.LostChangeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem, Me.PayToolStripMenuItem})
        Me.LostChangeToolStripMenuItem.Image = CType(resources.GetObject("LostChangeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LostChangeToolStripMenuItem.Name = "LostChangeToolStripMenuItem"
        Me.LostChangeToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.LostChangeToolStripMenuItem.Text = "Lost"
        '
        'ChangeToolStripMenuItem1
        '
        Me.ChangeToolStripMenuItem1.Image = CType(resources.GetObject("ChangeToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ChangeToolStripMenuItem1.Name = "ChangeToolStripMenuItem1"
        Me.ChangeToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.ChangeToolStripMenuItem1.Text = "Change"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Image = CType(resources.GetObject("ChangeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Image = CType(resources.GetObject("PayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.PayToolStripMenuItem.Text = "Pay"
        '
        'viewbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 507)
        Me.Controls.Add(Me.viewbooklv)
        Me.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1003, 546)
        Me.Name = "viewbooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book List"
        Me.cmslost.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents viewbooklv As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents cmslost As ContextMenuStrip
    Friend WithEvents ChangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LostChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
End Class
