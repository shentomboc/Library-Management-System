<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uidnumber = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.ucontact = New System.Windows.Forms.TextBox()
        Me.upassword = New System.Windows.Forms.TextBox()
        Me.uupdatebtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.uviewbtn = New System.Windows.Forms.Button()
        Me.unobookborrowed = New System.Windows.Forms.Label()
        Me.unobookoverdue = New System.Windows.Forms.Label()
        Me.unobooklost = New System.Windows.Forms.Label()
        Me.ulogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nobooksborrowdisplay = New System.Windows.Forms.Label()
        Me.libraryconctactnumber = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ubooklv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsborrow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.usearch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.cmsborrow.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(987, 479)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(981, 395)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(973, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ulogout, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(967, 355)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.uidnumber, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.uname, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ucontact, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.upassword, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.uupdatebtn, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBox2, 1, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(477, 267)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PROFILE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Contact"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 32)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'uidnumber
        '
        Me.uidnumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uidnumber.Enabled = False
        Me.uidnumber.Location = New System.Drawing.Point(130, 35)
        Me.uidnumber.MaxLength = 10
        Me.uidnumber.Name = "uidnumber"
        Me.uidnumber.Size = New System.Drawing.Size(344, 29)
        Me.uidnumber.TabIndex = 6
        '
        'uname
        '
        Me.uname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uname.Enabled = False
        Me.uname.Location = New System.Drawing.Point(130, 67)
        Me.uname.MaxLength = 50
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(344, 29)
        Me.uname.TabIndex = 7
        '
        'ucontact
        '
        Me.ucontact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucontact.Enabled = False
        Me.ucontact.Location = New System.Drawing.Point(130, 99)
        Me.ucontact.MaxLength = 11
        Me.ucontact.Name = "ucontact"
        Me.ucontact.Size = New System.Drawing.Size(344, 29)
        Me.ucontact.TabIndex = 8
        '
        'upassword
        '
        Me.upassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upassword.Enabled = False
        Me.upassword.Location = New System.Drawing.Point(130, 131)
        Me.upassword.MaxLength = 15
        Me.upassword.Name = "upassword"
        Me.upassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.upassword.Size = New System.Drawing.Size(344, 29)
        Me.upassword.TabIndex = 9
        '
        'uupdatebtn
        '
        Me.uupdatebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.uupdatebtn.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel3.SetColumnSpan(Me.uupdatebtn, 2)
        Me.uupdatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.uupdatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.uupdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uupdatebtn.Location = New System.Drawing.Point(201, 238)
        Me.uupdatebtn.Name = "uupdatebtn"
        Me.uupdatebtn.Size = New System.Drawing.Size(75, 26)
        Me.uupdatebtn.TabIndex = 10
        Me.uupdatebtn.Text = "Update"
        Me.uupdatebtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(130, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 50)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hello, Reader!"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.uviewbtn, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.unobookborrowed, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.unobookoverdue, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.unobooklost, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(486, 34)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(478, 267)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "BOOKS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "No. of Checked Out Books:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 32)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "No. of Overdue Books:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 32)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "No. of Lost Books:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'uviewbtn
        '
        Me.uviewbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.uviewbtn.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel4.SetColumnSpan(Me.uviewbtn, 2)
        Me.uviewbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.uviewbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.uviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uviewbtn.Location = New System.Drawing.Point(193, 238)
        Me.uviewbtn.Name = "uviewbtn"
        Me.uviewbtn.Size = New System.Drawing.Size(92, 26)
        Me.uviewbtn.TabIndex = 9
        Me.uviewbtn.Text = "View Books"
        Me.uviewbtn.UseVisualStyleBackColor = False
        '
        'unobookborrowed
        '
        Me.unobookborrowed.AutoSize = True
        Me.unobookborrowed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unobookborrowed.Location = New System.Drawing.Point(187, 32)
        Me.unobookborrowed.Name = "unobookborrowed"
        Me.unobookborrowed.Size = New System.Drawing.Size(288, 32)
        Me.unobookborrowed.TabIndex = 10
        Me.unobookborrowed.Text = "0"
        Me.unobookborrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unobookoverdue
        '
        Me.unobookoverdue.AutoSize = True
        Me.unobookoverdue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unobookoverdue.Location = New System.Drawing.Point(187, 64)
        Me.unobookoverdue.Name = "unobookoverdue"
        Me.unobookoverdue.Size = New System.Drawing.Size(288, 32)
        Me.unobookoverdue.TabIndex = 11
        Me.unobookoverdue.Text = "0"
        Me.unobookoverdue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'unobooklost
        '
        Me.unobooklost.AutoSize = True
        Me.unobooklost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unobooklost.Location = New System.Drawing.Point(187, 96)
        Me.unobooklost.Name = "unobooklost"
        Me.unobooklost.Size = New System.Drawing.Size(288, 32)
        Me.unobooklost.TabIndex = 12
        Me.unobooklost.Text = "0"
        Me.unobooklost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ulogout
        '
        Me.ulogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ulogout.BackColor = System.Drawing.Color.LightBlue
        Me.ulogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ulogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ulogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulogout.Location = New System.Drawing.Point(889, 322)
        Me.ulogout.Name = "ulogout"
        Me.ulogout.Size = New System.Drawing.Size(75, 30)
        Me.ulogout.TabIndex = 4
        Me.ulogout.Text = "Logout"
        Me.ulogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.nobooksborrowdisplay)
        Me.Panel1.Controls.Add(Me.libraryconctactnumber)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 45)
        Me.Panel1.TabIndex = 5
        '
        'nobooksborrowdisplay
        '
        Me.nobooksborrowdisplay.AutoSize = True
        Me.nobooksborrowdisplay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nobooksborrowdisplay.Location = New System.Drawing.Point(0, 3)
        Me.nobooksborrowdisplay.Name = "nobooksborrowdisplay"
        Me.nobooksborrowdisplay.Size = New System.Drawing.Size(213, 21)
        Me.nobooksborrowdisplay.TabIndex = 7
        Me.nobooksborrowdisplay.Text = "No. Books Students Can Borrow:"
        '
        'libraryconctactnumber
        '
        Me.libraryconctactnumber.AutoSize = True
        Me.libraryconctactnumber.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.libraryconctactnumber.Location = New System.Drawing.Point(0, 24)
        Me.libraryconctactnumber.Name = "libraryconctactnumber"
        Me.libraryconctactnumber.Size = New System.Drawing.Size(132, 21)
        Me.libraryconctactnumber.TabIndex = 6
        Me.libraryconctactnumber.Text = "Library Contact No."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(973, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Books"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ubooklv, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.usearch, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(967, 355)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'ubooklv
        '
        Me.ubooklv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.TableLayoutPanel5.SetColumnSpan(Me.ubooklv, 2)
        Me.ubooklv.ContextMenuStrip = Me.cmsborrow
        Me.ubooklv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ubooklv.FullRowSelect = True
        Me.ubooklv.HideSelection = False
        Me.ubooklv.Location = New System.Drawing.Point(3, 39)
        Me.ubooklv.MultiSelect = False
        Me.ubooklv.Name = "ubooklv"
        Me.ubooklv.Size = New System.Drawing.Size(961, 313)
        Me.ubooklv.TabIndex = 0
        Me.ubooklv.UseCompatibleStateImageBehavior = False
        Me.ubooklv.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Author"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Edition"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Category"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 195
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ISBN"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Loan Period (days)"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Status"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 145
        '
        'cmsborrow
        '
        Me.cmsborrow.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsborrow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem})
        Me.cmsborrow.Name = "cmsborrow"
        Me.cmsborrow.Size = New System.Drawing.Size(147, 30)
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Image = CType(resources.GetObject("BorrowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.BorrowToolStripMenuItem.Text = "Check Out"
        '
        'usearch
        '
        Me.usearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usearch.Location = New System.Drawing.Point(656, 3)
        Me.usearch.Name = "usearch"
        Me.usearch.Size = New System.Drawing.Size(308, 29)
        Me.usearch.TabIndex = 1
        Me.usearch.Text = "Search"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(981, 72)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(78, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 72)
        Me.Panel2.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Quicksand", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(862, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "MUJI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Watchword Thin Demo", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 36)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "LIBRARY"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 479)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1003, 518)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MUJI Library"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.cmsborrow.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents uidnumber As TextBox
    Friend WithEvents uname As TextBox
    Friend WithEvents ucontact As TextBox
    Friend WithEvents upassword As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents uupdatebtn As Button
    Friend WithEvents uviewbtn As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ubooklv As ListView
    Friend WithEvents usearch As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ulogout As Button
    Friend WithEvents cmsborrow As ContextMenuStrip
    Friend WithEvents BorrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents unobookborrowed As Label
    Friend WithEvents unobookoverdue As Label
    Friend WithEvents unobooklost As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nobooksborrowdisplay As Label
    Friend WithEvents libraryconctactnumber As Label
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
