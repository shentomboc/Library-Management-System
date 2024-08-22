<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categorywindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categorywindow))
        Me.catcancelbtn = New System.Windows.Forms.Button()
        Me.cataddbtn = New System.Windows.Forms.Button()
        Me.addcategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'catcancelbtn
        '
        Me.catcancelbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.catcancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.catcancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.catcancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.catcancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.catcancelbtn.Font = New System.Drawing.Font("Antipasto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catcancelbtn.Location = New System.Drawing.Point(205, 55)
        Me.catcancelbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.catcancelbtn.Name = "catcancelbtn"
        Me.catcancelbtn.Size = New System.Drawing.Size(80, 27)
        Me.catcancelbtn.TabIndex = 7
        Me.catcancelbtn.Text = "Cancel"
        Me.catcancelbtn.UseVisualStyleBackColor = False
        '
        'cataddbtn
        '
        Me.cataddbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cataddbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cataddbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.cataddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cataddbtn.Font = New System.Drawing.Font("Antipasto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cataddbtn.Location = New System.Drawing.Point(76, 55)
        Me.cataddbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cataddbtn.Name = "cataddbtn"
        Me.cataddbtn.Size = New System.Drawing.Size(80, 27)
        Me.cataddbtn.TabIndex = 6
        Me.cataddbtn.Text = "Add"
        Me.cataddbtn.UseVisualStyleBackColor = False
        '
        'addcategory
        '
        Me.addcategory.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcategory.Location = New System.Drawing.Point(97, 20)
        Me.addcategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addcategory.Name = "addcategory"
        Me.addcategory.Size = New System.Drawing.Size(276, 29)
        Me.addcategory.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Category :"
        '
        'categorywindow
        '
        Me.AcceptButton = Me.cataddbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.catcancelbtn
        Me.ClientSize = New System.Drawing.Size(386, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.catcancelbtn)
        Me.Controls.Add(Me.cataddbtn)
        Me.Controls.Add(Me.addcategory)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "categorywindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Category"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents catcancelbtn As Button
    Friend WithEvents cataddbtn As Button
    Friend WithEvents addcategory As TextBox
    Friend WithEvents Label1 As Label
End Class
