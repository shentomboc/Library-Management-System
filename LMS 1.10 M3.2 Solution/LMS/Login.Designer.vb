<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.passerr = New System.Windows.Forms.PictureBox()
        Me.unerr = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.idnumber = New System.Windows.Forms.TextBox()
        Me.Library = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.passerr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unerr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(987, 253)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.passerr)
        Me.Panel1.Controls.Add(Me.unerr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.loginbtn)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.idnumber)
        Me.Panel1.Location = New System.Drawing.Point(394, 132)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 248)
        Me.Panel1.TabIndex = 11
        '
        'passerr
        '
        Me.passerr.BackColor = System.Drawing.Color.Transparent
        Me.passerr.Image = CType(resources.GetObject("passerr.Image"), System.Drawing.Image)
        Me.passerr.Location = New System.Drawing.Point(174, 137)
        Me.passerr.Name = "passerr"
        Me.passerr.Size = New System.Drawing.Size(18, 24)
        Me.passerr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.passerr.TabIndex = 15
        Me.passerr.TabStop = False
        Me.passerr.Visible = False
        '
        'unerr
        '
        Me.unerr.BackColor = System.Drawing.Color.Transparent
        Me.unerr.Image = CType(resources.GetObject("unerr.Image"), System.Drawing.Image)
        Me.unerr.Location = New System.Drawing.Point(175, 99)
        Me.unerr.Name = "unerr"
        Me.unerr.Size = New System.Drawing.Size(18, 24)
        Me.unerr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.unerr.TabIndex = 14
        Me.unerr.TabStop = False
        Me.unerr.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Hello, Reader!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 61)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "LOGIN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginbtn
        '
        Me.loginbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginbtn.BackColor = System.Drawing.Color.LightBlue
        Me.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Location = New System.Drawing.Point(15, 177)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(181, 30)
        Me.loginbtn.TabIndex = 1
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(14, 135)
        Me.password.Margin = New System.Windows.Forms.Padding(5)
        Me.password.MaxLength = 20
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(180, 29)
        Me.password.TabIndex = 3
        Me.password.Text = "Password"
        '
        'idnumber
        '
        Me.idnumber.Location = New System.Drawing.Point(15, 97)
        Me.idnumber.Margin = New System.Windows.Forms.Padding(5)
        Me.idnumber.MaxLength = 10
        Me.idnumber.Name = "idnumber"
        Me.idnumber.Size = New System.Drawing.Size(180, 29)
        Me.idnumber.TabIndex = 2
        Me.idnumber.Text = "ID Number"
        '
        'Library
        '
        Me.Library.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Library.BackColor = System.Drawing.Color.LightBlue
        Me.Library.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Library.ForeColor = System.Drawing.Color.White
        Me.Library.Location = New System.Drawing.Point(11, 81)
        Me.Library.Name = "Library"
        Me.Library.Size = New System.Drawing.Size(963, 37)
        Me.Library.TabIndex = 12
        Me.Library.Text = "Library System"
        Me.Library.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Login
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 479)
        Me.Controls.Add(Me.Library)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1003, 518)
        Me.MinimumSize = New System.Drawing.Size(350, 518)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.passerr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unerr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents loginbtn As Button
    Friend WithEvents password As TextBox
    Friend WithEvents idnumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Library As Label
    Friend WithEvents unerr As PictureBox
    Friend WithEvents passerr As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
