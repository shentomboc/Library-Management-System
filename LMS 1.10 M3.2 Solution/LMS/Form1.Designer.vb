<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverdueBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LostBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.allbooks = New System.Windows.Forms.TabPage()
        Me.booklv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader63 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader59 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsallbooks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.borrowedbooks = New System.Windows.Forms.TabPage()
        Me.borrowedlv = New System.Windows.Forms.ListView()
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsreturn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReturnedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.overduebooks = New System.Windows.Forms.TabPage()
        Me.overduelv = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lostbooks = New System.Windows.Forms.TabPage()
        Me.lostlv = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader62 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.newbook = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.accessionno = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.author = New System.Windows.Forms.TextBox()
        Me.editor = New System.Windows.Forms.TextBox()
        Me.edition = New System.Windows.Forms.TextBox()
        Me.publicationplace = New System.Windows.Forms.TextBox()
        Me.publisher = New System.Windows.Forms.TextBox()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.category = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.loanperiod = New System.Windows.Forms.NumericUpDown()
        Me.admin = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.noupdate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nobookstudent = New System.Windows.Forms.NumericUpDown()
        Me.nobookfaculty = New System.Windows.Forms.NumericUpDown()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.closetime = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lusername = New System.Windows.Forms.TextBox()
        Me.lpassword = New System.Windows.Forms.TextBox()
        Me.lupdate = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lcontact = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.faculty = New System.Windows.Forms.TabPage()
        Me.facultylv = New System.Windows.Forms.ListView()
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsuser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.student = New System.Windows.Forms.TabPage()
        Me.userslv = New System.Windows.Forms.ListView()
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.home = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.totalbooks = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.totalavailable = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.totalborrowed = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.totaloverdue = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.totallost = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.totaluser = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.totalfaculties = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.totalstudents = New System.Windows.Forms.Label()
        Me.adduser = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ridnumber = New System.Windows.Forms.TextBox()
        Me.rname = New System.Windows.Forms.TextBox()
        Me.rcontact = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.rrole = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.rregisterbtn = New System.Windows.Forms.Button()
        Me.rcancelbtn = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.rpassword = New System.Windows.Forms.TextBox()
        Me.contacterror = New System.Windows.Forms.PictureBox()
        Me.complete = New System.Windows.Forms.TabPage()
        Me.completelv = New System.Windows.Forms.ListView()
        Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader54 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader52 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader64 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pending = New System.Windows.Forms.TabPage()
        Me.pendinglv = New System.Windows.Forms.ListView()
        Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader60 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader65 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gsearch = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LostBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverdueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.allbooks.SuspendLayout()
        Me.cmsallbooks.SuspendLayout()
        Me.borrowedbooks.SuspendLayout()
        Me.cmsreturn.SuspendLayout()
        Me.overduebooks.SuspendLayout()
        Me.lostbooks.SuspendLayout()
        Me.newbook.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.loanperiod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.admin.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.nobookstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nobookfaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.closetime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.faculty.SuspendLayout()
        Me.cmsuser.SuspendLayout()
        Me.student.SuspendLayout()
        Me.home.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.adduser.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.contacterror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.complete.SuspendLayout()
        Me.pending.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label26, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gsearch, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label27, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.538011!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.46199!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(987, 479)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BooksToolStripMenuItem, Me.NewBookToolStripMenuItem, Me.UsersToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 71)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(122, 408)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllBooksToolStripMenuItem1, Me.BorrowedBooksToolStripMenuItem1, Me.OverdueBooksToolStripMenuItem1, Me.LostBooksToolStripMenuItem1})
        Me.BooksToolStripMenuItem.Image = CType(resources.GetObject("BooksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.BooksToolStripMenuItem.Text = "View Books"
        Me.BooksToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AllBooksToolStripMenuItem1
        '
        Me.AllBooksToolStripMenuItem1.Image = CType(resources.GetObject("AllBooksToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AllBooksToolStripMenuItem1.Name = "AllBooksToolStripMenuItem1"
        Me.AllBooksToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.AllBooksToolStripMenuItem1.Text = "All Books"
        '
        'BorrowedBooksToolStripMenuItem1
        '
        Me.BorrowedBooksToolStripMenuItem1.Image = CType(resources.GetObject("BorrowedBooksToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.BorrowedBooksToolStripMenuItem1.Name = "BorrowedBooksToolStripMenuItem1"
        Me.BorrowedBooksToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.BorrowedBooksToolStripMenuItem1.Text = "Issued Books"
        '
        'OverdueBooksToolStripMenuItem1
        '
        Me.OverdueBooksToolStripMenuItem1.Image = CType(resources.GetObject("OverdueBooksToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OverdueBooksToolStripMenuItem1.Name = "OverdueBooksToolStripMenuItem1"
        Me.OverdueBooksToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.OverdueBooksToolStripMenuItem1.Text = "Overdue Books"
        '
        'LostBooksToolStripMenuItem1
        '
        Me.LostBooksToolStripMenuItem1.Image = CType(resources.GetObject("LostBooksToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LostBooksToolStripMenuItem1.Name = "LostBooksToolStripMenuItem1"
        Me.LostBooksToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.LostBooksToolStripMenuItem1.Text = "Lost Books"
        '
        'NewBookToolStripMenuItem
        '
        Me.NewBookToolStripMenuItem.Image = CType(resources.GetObject("NewBookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewBookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.NewBookToolStripMenuItem.Text = "New Book"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.FacultyToolStripMenuItem, Me.StudentToolStripMenuItem, Me.AddUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.Image = CType(resources.GetObject("UsersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AdminToolStripMenuItem.Text = "Librarian"
        '
        'FacultyToolStripMenuItem
        '
        Me.FacultyToolStripMenuItem.Image = CType(resources.GetObject("FacultyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        Me.FacultyToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.FacultyToolStripMenuItem.Text = "Faculty"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Image = CType(resources.GetObject("StudentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Image = CType(resources.GetObject("AddUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AddUserToolStripMenuItem.Text = "Add"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Image = CType(resources.GetObject("TransactionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransactionsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 2)
        Me.TabControl1.Controls.Add(Me.allbooks)
        Me.TabControl1.Controls.Add(Me.borrowedbooks)
        Me.TabControl1.Controls.Add(Me.overduebooks)
        Me.TabControl1.Controls.Add(Me.lostbooks)
        Me.TabControl1.Controls.Add(Me.newbook)
        Me.TabControl1.Controls.Add(Me.admin)
        Me.TabControl1.Controls.Add(Me.faculty)
        Me.TabControl1.Controls.Add(Me.student)
        Me.TabControl1.Controls.Add(Me.home)
        Me.TabControl1.Controls.Add(Me.adduser)
        Me.TabControl1.Controls.Add(Me.complete)
        Me.TabControl1.Controls.Add(Me.pending)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(122, 71)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 408)
        Me.TabControl1.TabIndex = 1
        '
        'allbooks
        '
        Me.allbooks.Controls.Add(Me.booklv)
        Me.allbooks.ImageKey = "(none)"
        Me.allbooks.Location = New System.Drawing.Point(4, 30)
        Me.allbooks.Name = "allbooks"
        Me.allbooks.Padding = New System.Windows.Forms.Padding(3)
        Me.allbooks.Size = New System.Drawing.Size(857, 374)
        Me.allbooks.TabIndex = 0
        Me.allbooks.Text = "All Books"
        Me.allbooks.UseVisualStyleBackColor = True
        '
        'booklv
        '
        Me.booklv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader45, Me.ColumnHeader35, Me.ColumnHeader4, Me.ColumnHeader63, Me.ColumnHeader38, Me.ColumnHeader5, Me.ColumnHeader59, Me.ColumnHeader34})
        Me.booklv.ContextMenuStrip = Me.cmsallbooks
        Me.booklv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.booklv.FullRowSelect = True
        Me.booklv.HideSelection = False
        Me.booklv.Location = New System.Drawing.Point(3, 3)
        Me.booklv.Margin = New System.Windows.Forms.Padding(0)
        Me.booklv.MultiSelect = False
        Me.booklv.Name = "booklv"
        Me.booklv.Size = New System.Drawing.Size(851, 368)
        Me.booklv.TabIndex = 1
        Me.booklv.UseCompatibleStateImageBehavior = False
        Me.booklv.View = System.Windows.Forms.View.Details
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
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "Editor"
        Me.ColumnHeader45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader45.Width = 120
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Edition"
        Me.ColumnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader35.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Publication Place"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 145
        '
        'ColumnHeader63
        '
        Me.ColumnHeader63.Text = "Publisher"
        Me.ColumnHeader63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader63.Width = 150
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "ISBN"
        Me.ColumnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader38.Width = 140
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Category"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader59
        '
        Me.ColumnHeader59.Text = "Loan Period (Days)"
        Me.ColumnHeader59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader59.Width = 100
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Status"
        Me.ColumnHeader34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader34.Width = 130
        '
        'cmsallbooks
        '
        Me.cmsallbooks.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsallbooks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.cmsallbooks.Name = "cmsallbooks"
        Me.cmsallbooks.Size = New System.Drawing.Size(133, 56)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = CType(resources.GetObject("UpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Image = CType(resources.GetObject("RemoveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'borrowedbooks
        '
        Me.borrowedbooks.Controls.Add(Me.borrowedlv)
        Me.borrowedbooks.Location = New System.Drawing.Point(4, 30)
        Me.borrowedbooks.Name = "borrowedbooks"
        Me.borrowedbooks.Padding = New System.Windows.Forms.Padding(3)
        Me.borrowedbooks.Size = New System.Drawing.Size(857, 374)
        Me.borrowedbooks.TabIndex = 1
        Me.borrowedbooks.Text = "Issued Books"
        Me.borrowedbooks.UseVisualStyleBackColor = True
        '
        'borrowedlv
        '
        Me.borrowedlv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader48, Me.ColumnHeader47, Me.ColumnHeader49})
        Me.borrowedlv.ContextMenuStrip = Me.cmsreturn
        Me.borrowedlv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.borrowedlv.FullRowSelect = True
        Me.borrowedlv.HideSelection = False
        Me.borrowedlv.Location = New System.Drawing.Point(3, 3)
        Me.borrowedlv.MultiSelect = False
        Me.borrowedlv.Name = "borrowedlv"
        Me.borrowedlv.Size = New System.Drawing.Size(851, 368)
        Me.borrowedlv.TabIndex = 2
        Me.borrowedlv.UseCompatibleStateImageBehavior = False
        Me.borrowedlv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "Accession No."
        Me.ColumnHeader39.Width = 105
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "Book Title"
        Me.ColumnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader40.Width = 180
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "Author"
        Me.ColumnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader41.Width = 100
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "Edition"
        Me.ColumnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader42.Width = 100
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "Issued Date"
        Me.ColumnHeader43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader43.Width = 180
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "Due Date"
        Me.ColumnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader44.Width = 180
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "ID Number"
        Me.ColumnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader48.Width = 140
        '
        'ColumnHeader47
        '
        Me.ColumnHeader47.Text = "Name"
        Me.ColumnHeader47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader47.Width = 150
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "Contact"
        Me.ColumnHeader49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader49.Width = 100
        '
        'cmsreturn
        '
        Me.cmsreturn.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsreturn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnedToolStripMenuItem})
        Me.cmsreturn.Name = "cmsreturn"
        Me.cmsreturn.Size = New System.Drawing.Size(139, 30)
        '
        'ReturnedToolStripMenuItem
        '
        Me.ReturnedToolStripMenuItem.Image = CType(resources.GetObject("ReturnedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReturnedToolStripMenuItem.Name = "ReturnedToolStripMenuItem"
        Me.ReturnedToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.ReturnedToolStripMenuItem.Text = "Returned"
        '
        'overduebooks
        '
        Me.overduebooks.Controls.Add(Me.overduelv)
        Me.overduebooks.Location = New System.Drawing.Point(4, 30)
        Me.overduebooks.Name = "overduebooks"
        Me.overduebooks.Padding = New System.Windows.Forms.Padding(3)
        Me.overduebooks.Size = New System.Drawing.Size(857, 374)
        Me.overduebooks.TabIndex = 2
        Me.overduebooks.Text = "Overdue Books"
        Me.overduebooks.UseVisualStyleBackColor = True
        '
        'overduelv
        '
        Me.overduelv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.overduelv.ContextMenuStrip = Me.cmsreturn
        Me.overduelv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.overduelv.FullRowSelect = True
        Me.overduelv.HideSelection = False
        Me.overduelv.Location = New System.Drawing.Point(3, 3)
        Me.overduelv.MultiSelect = False
        Me.overduelv.Name = "overduelv"
        Me.overduelv.Size = New System.Drawing.Size(851, 368)
        Me.overduelv.TabIndex = 2
        Me.overduelv.UseCompatibleStateImageBehavior = False
        Me.overduelv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Accession No."
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Book Title"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Author"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Edition"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Issued Date"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 180
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Due Date"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 180
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ID Number"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 140
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Name"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Contact"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 100
        '
        'lostbooks
        '
        Me.lostbooks.Controls.Add(Me.lostlv)
        Me.lostbooks.Location = New System.Drawing.Point(4, 30)
        Me.lostbooks.Name = "lostbooks"
        Me.lostbooks.Padding = New System.Windows.Forms.Padding(3)
        Me.lostbooks.Size = New System.Drawing.Size(857, 374)
        Me.lostbooks.TabIndex = 3
        Me.lostbooks.Text = "Lost Books"
        Me.lostbooks.UseVisualStyleBackColor = True
        '
        'lostlv
        '
        Me.lostlv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader62})
        Me.lostlv.ContextMenuStrip = Me.cmsreturn
        Me.lostlv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lostlv.FullRowSelect = True
        Me.lostlv.HideSelection = False
        Me.lostlv.Location = New System.Drawing.Point(3, 3)
        Me.lostlv.MultiSelect = False
        Me.lostlv.Name = "lostlv"
        Me.lostlv.Size = New System.Drawing.Size(851, 368)
        Me.lostlv.TabIndex = 2
        Me.lostlv.UseCompatibleStateImageBehavior = False
        Me.lostlv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Accession No."
        Me.ColumnHeader15.Width = 105
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Book Title"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 180
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Author"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Edition"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Issued Date"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader19.Width = 180
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Due Date"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader20.Width = 180
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "ID Number"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader21.Width = 140
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Name"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader22.Width = 150
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Contact"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader23.Width = 100
        '
        'ColumnHeader62
        '
        Me.ColumnHeader62.Text = "Action"
        Me.ColumnHeader62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader62.Width = 100
        '
        'newbook
        '
        Me.newbook.Controls.Add(Me.TableLayoutPanel2)
        Me.newbook.Location = New System.Drawing.Point(4, 30)
        Me.newbook.Name = "newbook"
        Me.newbook.Padding = New System.Windows.Forms.Padding(3)
        Me.newbook.Size = New System.Drawing.Size(857, 374)
        Me.newbook.TabIndex = 4
        Me.newbook.Text = "New Book"
        Me.newbook.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.accessionno, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.title, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.author, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.editor, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.edition, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.publicationplace, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.publisher, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.isbn, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.category, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 3, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.loanperiod, 3, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(851, 368)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accession No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Editor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 35)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edition"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(409, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 35)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Publication Place"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(409, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 35)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Publisher"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(409, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 35)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ISBN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(409, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 35)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Category"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'accessionno
        '
        Me.accessionno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.accessionno.Enabled = False
        Me.accessionno.Location = New System.Drawing.Point(116, 3)
        Me.accessionno.MaxLength = 20
        Me.accessionno.Name = "accessionno"
        Me.accessionno.Size = New System.Drawing.Size(287, 29)
        Me.accessionno.TabIndex = 10
        '
        'title
        '
        Me.title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.title.Location = New System.Drawing.Point(116, 38)
        Me.title.MaxLength = 200
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(287, 29)
        Me.title.TabIndex = 1
        '
        'author
        '
        Me.author.Dock = System.Windows.Forms.DockStyle.Fill
        Me.author.Location = New System.Drawing.Point(116, 73)
        Me.author.MaxLength = 50
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(287, 29)
        Me.author.TabIndex = 2
        '
        'editor
        '
        Me.editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editor.Location = New System.Drawing.Point(116, 108)
        Me.editor.MaxLength = 50
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(287, 29)
        Me.editor.TabIndex = 3
        '
        'edition
        '
        Me.edition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.edition.Location = New System.Drawing.Point(116, 143)
        Me.edition.MaxLength = 50
        Me.edition.Name = "edition"
        Me.edition.Size = New System.Drawing.Size(287, 29)
        Me.edition.TabIndex = 4
        '
        'publicationplace
        '
        Me.publicationplace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.publicationplace.Location = New System.Drawing.Point(561, 3)
        Me.publicationplace.MaxLength = 50
        Me.publicationplace.Name = "publicationplace"
        Me.publicationplace.Size = New System.Drawing.Size(287, 29)
        Me.publicationplace.TabIndex = 5
        '
        'publisher
        '
        Me.publisher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.publisher.Location = New System.Drawing.Point(561, 38)
        Me.publisher.MaxLength = 50
        Me.publisher.Name = "publisher"
        Me.publisher.Size = New System.Drawing.Size(287, 29)
        Me.publisher.TabIndex = 6
        '
        'isbn
        '
        Me.isbn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.isbn.Location = New System.Drawing.Point(561, 73)
        Me.isbn.MaxLength = 13
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(287, 29)
        Me.isbn.TabIndex = 7
        '
        'category
        '
        Me.category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.category.FormattingEnabled = True
        Me.category.Items.AddRange(New Object() {"(add category)"})
        Me.category.Location = New System.Drawing.Point(561, 108)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(287, 29)
        Me.category.Sorted = True
        Me.category.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(409, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 35)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Loan Period (days)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.addbtn, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cancelbtn, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.clearbtn, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(561, 331)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(287, 34)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.LightBlue
        Me.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addbtn.Location = New System.Drawing.Point(186, 2)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(100, 30)
        Me.addbtn.TabIndex = 10
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.LightBlue
        Me.cancelbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.Location = New System.Drawing.Point(82, 2)
        Me.cancelbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(76, 30)
        Me.cancelbtn.TabIndex = 1
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.LightBlue
        Me.clearbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Location = New System.Drawing.Point(2, 2)
        Me.clearbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(76, 30)
        Me.clearbtn.TabIndex = 2
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'loanperiod
        '
        Me.loanperiod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loanperiod.Location = New System.Drawing.Point(561, 143)
        Me.loanperiod.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.loanperiod.Name = "loanperiod"
        Me.loanperiod.Size = New System.Drawing.Size(287, 29)
        Me.loanperiod.TabIndex = 9
        '
        'admin
        '
        Me.admin.Controls.Add(Me.TableLayoutPanel8)
        Me.admin.Location = New System.Drawing.Point(4, 30)
        Me.admin.Name = "admin"
        Me.admin.Padding = New System.Windows.Forms.Padding(3)
        Me.admin.Size = New System.Drawing.Size(857, 374)
        Me.admin.TabIndex = 5
        Me.admin.Text = "Librarian"
        Me.admin.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.Label13, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label16, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.lusername, 2, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lpassword, 2, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.lupdate, 1, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label18, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.lcontact, 2, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label31, 0, 7)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 9
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66667!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(851, 368)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel9.ColumnCount = 7
        Me.TableLayoutPanel8.SetColumnSpan(Me.TableLayoutPanel9, 4)
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.noupdate, 6, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label23, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.nobookstudent, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.nobookfaculty, 3, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel9, 5, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(0, 332)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(851, 36)
        Me.TableLayoutPanel9.TabIndex = 6
        '
        'noupdate
        '
        Me.noupdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.noupdate.BackColor = System.Drawing.Color.LightBlue
        Me.noupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.noupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.noupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.noupdate.Location = New System.Drawing.Point(766, 3)
        Me.noupdate.Name = "noupdate"
        Me.noupdate.Size = New System.Drawing.Size(82, 29)
        Me.noupdate.TabIndex = 4
        Me.noupdate.Text = "Change"
        Me.noupdate.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Lavender
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(456, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 36)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Closing Time (24h):"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Location = New System.Drawing.Point(3, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 36)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Student Can Borrow:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Location = New System.Drawing.Point(231, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 36)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Faculty Can Borrow:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nobookstudent
        '
        Me.nobookstudent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nobookstudent.Enabled = False
        Me.nobookstudent.Location = New System.Drawing.Point(151, 3)
        Me.nobookstudent.Name = "nobookstudent"
        Me.nobookstudent.Size = New System.Drawing.Size(74, 29)
        Me.nobookstudent.TabIndex = 2
        '
        'nobookfaculty
        '
        Me.nobookfaculty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nobookfaculty.Enabled = False
        Me.nobookfaculty.Location = New System.Drawing.Point(379, 3)
        Me.nobookfaculty.Name = "nobookfaculty"
        Me.nobookfaculty.Size = New System.Drawing.Size(74, 29)
        Me.nobookfaculty.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Lavender
        Me.Panel9.Controls.Add(Me.closetime)
        Me.Panel9.Location = New System.Drawing.Point(604, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(80, 36)
        Me.Panel9.TabIndex = 5
        '
        'closetime
        '
        Me.closetime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.closetime.BackColor = System.Drawing.SystemColors.Window
        Me.closetime.Enabled = False
        Me.closetime.Location = New System.Drawing.Point(3, 4)
        Me.closetime.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.closetime.Name = "closetime"
        Me.closetime.Size = New System.Drawing.Size(74, 29)
        Me.closetime.TabIndex = 2
        Me.closetime.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(241, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 35)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Username"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(241, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 35)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lusername
        '
        Me.lusername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lusername.Enabled = False
        Me.lusername.Location = New System.Drawing.Point(341, 43)
        Me.lusername.Name = "lusername"
        Me.lusername.Size = New System.Drawing.Size(269, 29)
        Me.lusername.TabIndex = 2
        '
        'lpassword
        '
        Me.lpassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lpassword.Enabled = False
        Me.lpassword.Location = New System.Drawing.Point(341, 78)
        Me.lpassword.Name = "lpassword"
        Me.lpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.lpassword.Size = New System.Drawing.Size(269, 29)
        Me.lpassword.TabIndex = 3
        '
        'lupdate
        '
        Me.lupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lupdate.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel8.SetColumnSpan(Me.lupdate, 2)
        Me.lupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.lupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.lupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lupdate.Location = New System.Drawing.Point(379, 183)
        Me.lupdate.Name = "lupdate"
        Me.lupdate.Size = New System.Drawing.Size(93, 30)
        Me.lupdate.TabIndex = 0
        Me.lupdate.Text = "Change"
        Me.lupdate.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(274, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 21)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Contact"
        '
        'lcontact
        '
        Me.lcontact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcontact.Enabled = False
        Me.lcontact.Location = New System.Drawing.Point(341, 113)
        Me.lcontact.MaxLength = 11
        Me.lcontact.Name = "lcontact"
        Me.lcontact.Size = New System.Drawing.Size(269, 29)
        Me.lcontact.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel8.SetColumnSpan(Me.Label31, 4)
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label31.Location = New System.Drawing.Point(3, 311)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(845, 21)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "Max. number of Book the ..."
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'faculty
        '
        Me.faculty.Controls.Add(Me.facultylv)
        Me.faculty.Location = New System.Drawing.Point(4, 30)
        Me.faculty.Name = "faculty"
        Me.faculty.Padding = New System.Windows.Forms.Padding(3)
        Me.faculty.Size = New System.Drawing.Size(857, 374)
        Me.faculty.TabIndex = 6
        Me.faculty.Text = "Faculty"
        Me.faculty.UseVisualStyleBackColor = True
        '
        'facultylv
        '
        Me.facultylv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader36, Me.ColumnHeader37})
        Me.facultylv.ContextMenuStrip = Me.cmsuser
        Me.facultylv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.facultylv.FullRowSelect = True
        Me.facultylv.HideSelection = False
        Me.facultylv.Location = New System.Drawing.Point(3, 3)
        Me.facultylv.MultiSelect = False
        Me.facultylv.Name = "facultylv"
        Me.facultylv.Size = New System.Drawing.Size(851, 368)
        Me.facultylv.TabIndex = 1
        Me.facultylv.UseCompatibleStateImageBehavior = False
        Me.facultylv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "ID Number"
        Me.ColumnHeader24.Width = 110
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Name"
        Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader25.Width = 180
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Contact"
        Me.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader26.Width = 150
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "No. of Issued Books"
        Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader27.Width = 140
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "No. of Overdue Books"
        Me.ColumnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader36.Width = 150
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "No. of Lost Books"
        Me.ColumnHeader37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader37.Width = 120
        '
        'cmsuser
        '
        Me.cmsuser.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsuser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem1})
        Me.cmsuser.Name = "cmsuser"
        Me.cmsuser.Size = New System.Drawing.Size(133, 30)
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Image = CType(resources.GetObject("RemoveToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(132, 26)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'student
        '
        Me.student.Controls.Add(Me.userslv)
        Me.student.Location = New System.Drawing.Point(4, 30)
        Me.student.Name = "student"
        Me.student.Padding = New System.Windows.Forms.Padding(3)
        Me.student.Size = New System.Drawing.Size(857, 374)
        Me.student.TabIndex = 7
        Me.student.Text = "Student"
        Me.student.UseVisualStyleBackColor = True
        '
        'userslv
        '
        Me.userslv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33})
        Me.userslv.ContextMenuStrip = Me.cmsuser
        Me.userslv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userslv.FullRowSelect = True
        Me.userslv.HideSelection = False
        Me.userslv.Location = New System.Drawing.Point(3, 3)
        Me.userslv.MultiSelect = False
        Me.userslv.Name = "userslv"
        Me.userslv.Size = New System.Drawing.Size(851, 368)
        Me.userslv.TabIndex = 1
        Me.userslv.UseCompatibleStateImageBehavior = False
        Me.userslv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "ID Number"
        Me.ColumnHeader28.Width = 110
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Name"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader29.Width = 180
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Contact"
        Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader30.Width = 150
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "No. of Issued Books"
        Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader31.Width = 140
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "No. of Overdue Books"
        Me.ColumnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader32.Width = 150
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "No. of Lost Books"
        Me.ColumnHeader33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader33.Width = 162
        '
        'home
        '
        Me.home.Controls.Add(Me.TableLayoutPanel5)
        Me.home.Location = New System.Drawing.Point(4, 30)
        Me.home.Name = "home"
        Me.home.Padding = New System.Windows.Forms.Padding(3)
        Me.home.Size = New System.Drawing.Size(857, 374)
        Me.home.TabIndex = 9
        Me.home.Text = "Home"
        Me.home.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.37349!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.62651!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(851, 368)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel8)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 147)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(845, 182)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.totalbooks)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 21)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Total Books"
        '
        'totalbooks
        '
        Me.totalbooks.AutoSize = True
        Me.totalbooks.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalbooks.Location = New System.Drawing.Point(3, 0)
        Me.totalbooks.Name = "totalbooks"
        Me.totalbooks.Size = New System.Drawing.Size(22, 26)
        Me.totalbooks.TabIndex = 0
        Me.totalbooks.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.totalavailable)
        Me.Panel5.Location = New System.Drawing.Point(188, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(179, 59)
        Me.Panel5.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 36)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(146, 21)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Total Available Books"
        '
        'totalavailable
        '
        Me.totalavailable.AutoSize = True
        Me.totalavailable.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalavailable.Location = New System.Drawing.Point(3, 0)
        Me.totalavailable.Name = "totalavailable"
        Me.totalavailable.Size = New System.Drawing.Size(22, 26)
        Me.totalavailable.TabIndex = 0
        Me.totalavailable.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.totalborrowed)
        Me.Panel2.Location = New System.Drawing.Point(373, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 59)
        Me.Panel2.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 21)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Total Issued Books"
        '
        'totalborrowed
        '
        Me.totalborrowed.AutoSize = True
        Me.totalborrowed.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalborrowed.Location = New System.Drawing.Point(3, 0)
        Me.totalborrowed.Name = "totalborrowed"
        Me.totalborrowed.Size = New System.Drawing.Size(22, 26)
        Me.totalborrowed.TabIndex = 0
        Me.totalborrowed.Text = "0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Controls.Add(Me.totaloverdue)
        Me.Panel6.Location = New System.Drawing.Point(558, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(179, 59)
        Me.Panel6.TabIndex = 4
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 21)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Total Overdue Books"
        '
        'totaloverdue
        '
        Me.totaloverdue.AutoSize = True
        Me.totaloverdue.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaloverdue.Location = New System.Drawing.Point(3, 0)
        Me.totaloverdue.Name = "totaloverdue"
        Me.totaloverdue.Size = New System.Drawing.Size(22, 26)
        Me.totaloverdue.TabIndex = 0
        Me.totaloverdue.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.totallost)
        Me.Panel3.Location = New System.Drawing.Point(3, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 59)
        Me.Panel3.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 21)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Total Lost Books"
        '
        'totallost
        '
        Me.totallost.AutoSize = True
        Me.totallost.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totallost.Location = New System.Drawing.Point(3, 0)
        Me.totallost.Name = "totallost"
        Me.totallost.Size = New System.Drawing.Size(22, 26)
        Me.totallost.TabIndex = 0
        Me.totallost.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.totaluser)
        Me.Panel4.Location = New System.Drawing.Point(188, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 59)
        Me.Panel4.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 21)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Total Users"
        '
        'totaluser
        '
        Me.totaluser.AutoSize = True
        Me.totaluser.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaluser.Location = New System.Drawing.Point(3, 0)
        Me.totaluser.Name = "totaluser"
        Me.totaluser.Size = New System.Drawing.Size(22, 26)
        Me.totaluser.TabIndex = 0
        Me.totaluser.Text = "0"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel7.Controls.Add(Me.Label29)
        Me.Panel7.Controls.Add(Me.totalfaculties)
        Me.Panel7.Location = New System.Drawing.Point(373, 68)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(179, 59)
        Me.Panel7.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 36)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 21)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Total Faculties"
        '
        'totalfaculties
        '
        Me.totalfaculties.AutoSize = True
        Me.totalfaculties.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalfaculties.Location = New System.Drawing.Point(3, 0)
        Me.totalfaculties.Name = "totalfaculties"
        Me.totalfaculties.Size = New System.Drawing.Size(22, 26)
        Me.totalfaculties.TabIndex = 0
        Me.totalfaculties.Text = "0"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel8.Controls.Add(Me.Label32)
        Me.Panel8.Controls.Add(Me.totalstudents)
        Me.Panel8.Location = New System.Drawing.Point(558, 68)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(179, 59)
        Me.Panel8.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(4, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(93, 21)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Total Student"
        '
        'totalstudents
        '
        Me.totalstudents.AutoSize = True
        Me.totalstudents.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalstudents.Location = New System.Drawing.Point(3, 0)
        Me.totalstudents.Name = "totalstudents"
        Me.totalstudents.Size = New System.Drawing.Size(22, 26)
        Me.totalstudents.TabIndex = 0
        Me.totalstudents.Text = "0"
        '
        'adduser
        '
        Me.adduser.Controls.Add(Me.TableLayoutPanel6)
        Me.adduser.Location = New System.Drawing.Point(4, 30)
        Me.adduser.Name = "adduser"
        Me.adduser.Padding = New System.Windows.Forms.Padding(3)
        Me.adduser.Size = New System.Drawing.Size(857, 374)
        Me.adduser.TabIndex = 10
        Me.adduser.Text = "Add"
        Me.adduser.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label12, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label21, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label22, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.ridnumber, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.rname, 2, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.rcontact, 2, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label25, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.rrole, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label24, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.rpassword, 2, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.contacterror, 3, 4)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 10
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(851, 368)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(240, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 35)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID Number"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Location = New System.Drawing.Point(240, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 35)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Full Name"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Location = New System.Drawing.Point(240, 140)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 35)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Contact No."
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ridnumber
        '
        Me.ridnumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ridnumber.Location = New System.Drawing.Point(340, 73)
        Me.ridnumber.MaxLength = 10
        Me.ridnumber.Name = "ridnumber"
        Me.ridnumber.Size = New System.Drawing.Size(269, 29)
        Me.ridnumber.TabIndex = 5
        '
        'rname
        '
        Me.rname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rname.Location = New System.Drawing.Point(340, 108)
        Me.rname.MaxLength = 50
        Me.rname.Name = "rname"
        Me.rname.Size = New System.Drawing.Size(269, 29)
        Me.rname.TabIndex = 6
        '
        'rcontact
        '
        Me.rcontact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rcontact.Location = New System.Drawing.Point(340, 143)
        Me.rcontact.MaxLength = 11
        Me.rcontact.Name = "rcontact"
        Me.rcontact.Size = New System.Drawing.Size(269, 29)
        Me.rcontact.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Location = New System.Drawing.Point(240, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 35)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Role"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rrole
        '
        Me.rrole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rrole.FormattingEnabled = True
        Me.rrole.Items.AddRange(New Object() {"Faculty", "Student"})
        Me.rrole.Location = New System.Drawing.Point(340, 38)
        Me.rrole.Name = "rrole"
        Me.rrole.Size = New System.Drawing.Size(269, 29)
        Me.rrole.TabIndex = 11
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel6.SetColumnSpan(Me.TableLayoutPanel7, 2)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.rregisterbtn, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.rcancelbtn, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(237, 280)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(375, 35)
        Me.TableLayoutPanel7.TabIndex = 12
        '
        'rregisterbtn
        '
        Me.rregisterbtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rregisterbtn.BackColor = System.Drawing.Color.LightBlue
        Me.rregisterbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.rregisterbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.rregisterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rregisterbtn.Location = New System.Drawing.Point(91, 3)
        Me.rregisterbtn.Name = "rregisterbtn"
        Me.rregisterbtn.Size = New System.Drawing.Size(93, 29)
        Me.rregisterbtn.TabIndex = 0
        Me.rregisterbtn.Text = "Register"
        Me.rregisterbtn.UseVisualStyleBackColor = False
        '
        'rcancelbtn
        '
        Me.rcancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rcancelbtn.BackColor = System.Drawing.Color.LightBlue
        Me.rcancelbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.rcancelbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.rcancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rcancelbtn.Location = New System.Drawing.Point(190, 3)
        Me.rcancelbtn.Name = "rcancelbtn"
        Me.rcancelbtn.Size = New System.Drawing.Size(93, 29)
        Me.rcancelbtn.TabIndex = 1
        Me.rcancelbtn.Text = "Cancel"
        Me.rcancelbtn.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Location = New System.Drawing.Point(240, 175)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 35)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Password"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rpassword
        '
        Me.rpassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpassword.Location = New System.Drawing.Point(340, 178)
        Me.rpassword.MaxLength = 15
        Me.rpassword.Name = "rpassword"
        Me.rpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.rpassword.Size = New System.Drawing.Size(269, 29)
        Me.rpassword.TabIndex = 9
        '
        'contacterror
        '
        Me.contacterror.Dock = System.Windows.Forms.DockStyle.Left
        Me.contacterror.Image = CType(resources.GetObject("contacterror.Image"), System.Drawing.Image)
        Me.contacterror.Location = New System.Drawing.Point(615, 143)
        Me.contacterror.Name = "contacterror"
        Me.contacterror.Size = New System.Drawing.Size(16, 29)
        Me.contacterror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.contacterror.TabIndex = 13
        Me.contacterror.TabStop = False
        Me.contacterror.Visible = False
        '
        'complete
        '
        Me.complete.Controls.Add(Me.completelv)
        Me.complete.Location = New System.Drawing.Point(4, 30)
        Me.complete.Name = "complete"
        Me.complete.Padding = New System.Windows.Forms.Padding(3)
        Me.complete.Size = New System.Drawing.Size(857, 374)
        Me.complete.TabIndex = 11
        Me.complete.Text = "Complete"
        Me.complete.UseVisualStyleBackColor = True
        '
        'completelv
        '
        Me.completelv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader46, Me.ColumnHeader54, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52, Me.ColumnHeader64})
        Me.completelv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.completelv.FullRowSelect = True
        Me.completelv.GridLines = True
        Me.completelv.HideSelection = False
        Me.completelv.Location = New System.Drawing.Point(3, 3)
        Me.completelv.MultiSelect = False
        Me.completelv.Name = "completelv"
        Me.completelv.Size = New System.Drawing.Size(851, 368)
        Me.completelv.TabIndex = 0
        Me.completelv.UseCompatibleStateImageBehavior = False
        Me.completelv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.Text = "Borrowed Date"
        Me.ColumnHeader46.Width = 170
        '
        'ColumnHeader54
        '
        Me.ColumnHeader54.Text = "Returned Date"
        Me.ColumnHeader54.Width = 170
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "ID Number"
        Me.ColumnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader50.Width = 170
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "AN"
        Me.ColumnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader51.Width = 90
        '
        'ColumnHeader52
        '
        Me.ColumnHeader52.Text = "Title"
        Me.ColumnHeader52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader52.Width = 213
        '
        'ColumnHeader64
        '
        Me.ColumnHeader64.Text = "Return"
        Me.ColumnHeader64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader64.Width = 100
        '
        'pending
        '
        Me.pending.Controls.Add(Me.pendinglv)
        Me.pending.Location = New System.Drawing.Point(4, 30)
        Me.pending.Name = "pending"
        Me.pending.Padding = New System.Windows.Forms.Padding(3)
        Me.pending.Size = New System.Drawing.Size(857, 374)
        Me.pending.TabIndex = 12
        Me.pending.Text = "Pending"
        Me.pending.UseVisualStyleBackColor = True
        '
        'pendinglv
        '
        Me.pendinglv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader57, Me.ColumnHeader58, Me.ColumnHeader60, Me.ColumnHeader65})
        Me.pendinglv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pendinglv.FullRowSelect = True
        Me.pendinglv.GridLines = True
        Me.pendinglv.HideSelection = False
        Me.pendinglv.Location = New System.Drawing.Point(3, 3)
        Me.pendinglv.MultiSelect = False
        Me.pendinglv.Name = "pendinglv"
        Me.pendinglv.Size = New System.Drawing.Size(851, 368)
        Me.pendinglv.TabIndex = 1
        Me.pendinglv.UseCompatibleStateImageBehavior = False
        Me.pendinglv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "Borrowed Date"
        Me.ColumnHeader55.Width = 170
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "Returned Date"
        Me.ColumnHeader56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader56.Width = 170
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "ID Number"
        Me.ColumnHeader57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader57.Width = 170
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "AN"
        Me.ColumnHeader58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader58.Width = 90
        '
        'ColumnHeader60
        '
        Me.ColumnHeader60.Text = "Title"
        Me.ColumnHeader60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader60.Width = 213
        '
        'ColumnHeader65
        '
        Me.ColumnHeader65.Text = "Return"
        Me.ColumnHeader65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader65.Width = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(122, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label26, 2)
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Watchword Thin Demo", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(122, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(865, 38)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "LIBRARY MANAGEMENT SYSTEM"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'gsearch
        '
        Me.gsearch.BackColor = System.Drawing.Color.White
        Me.gsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gsearch.Location = New System.Drawing.Point(690, 41)
        Me.gsearch.Name = "gsearch"
        Me.gsearch.Size = New System.Drawing.Size(294, 29)
        Me.gsearch.TabIndex = 2
        Me.gsearch.Text = "Search"
        Me.gsearch.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Quicksand", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(122, 38)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(565, 33)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "MUJI"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LostBooksToolStripMenuItem
        '
        Me.LostBooksToolStripMenuItem.Name = "LostBooksToolStripMenuItem"
        Me.LostBooksToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.LostBooksToolStripMenuItem.Text = "Lost Books"
        '
        'OverdueBooksToolStripMenuItem
        '
        Me.OverdueBooksToolStripMenuItem.Name = "OverdueBooksToolStripMenuItem"
        Me.OverdueBooksToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.OverdueBooksToolStripMenuItem.Text = "Overdue Books"
        '
        'BorrowedBooksToolStripMenuItem
        '
        Me.BorrowedBooksToolStripMenuItem.Name = "BorrowedBooksToolStripMenuItem"
        Me.BorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.BorrowedBooksToolStripMenuItem.Text = "Borrowed Books"
        '
        'AllBooksToolStripMenuItem
        '
        Me.AllBooksToolStripMenuItem.Name = "AllBooksToolStripMenuItem"
        Me.AllBooksToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.AllBooksToolStripMenuItem.Text = "All Books"
        '
        'Form1
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
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MUJI Library [admin]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.allbooks.ResumeLayout(False)
        Me.cmsallbooks.ResumeLayout(False)
        Me.borrowedbooks.ResumeLayout(False)
        Me.cmsreturn.ResumeLayout(False)
        Me.overduebooks.ResumeLayout(False)
        Me.lostbooks.ResumeLayout(False)
        Me.newbook.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.loanperiod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.admin.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.nobookstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nobookfaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.closetime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.faculty.ResumeLayout(False)
        Me.cmsuser.ResumeLayout(False)
        Me.student.ResumeLayout(False)
        Me.home.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.adduser.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.contacterror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.complete.ResumeLayout(False)
        Me.pending.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents allbooks As TabPage
    Friend WithEvents booklv As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader45 As ColumnHeader
    Friend WithEvents ColumnHeader35 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader63 As ColumnHeader
    Friend WithEvents ColumnHeader38 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader59 As ColumnHeader
    Friend WithEvents ColumnHeader34 As ColumnHeader
    Friend WithEvents borrowedbooks As TabPage
    Friend WithEvents borrowedlv As ListView
    Friend WithEvents ColumnHeader39 As ColumnHeader
    Friend WithEvents ColumnHeader40 As ColumnHeader
    Friend WithEvents ColumnHeader41 As ColumnHeader
    Friend WithEvents ColumnHeader42 As ColumnHeader
    Friend WithEvents ColumnHeader43 As ColumnHeader
    Friend WithEvents ColumnHeader44 As ColumnHeader
    Friend WithEvents ColumnHeader48 As ColumnHeader
    Friend WithEvents ColumnHeader47 As ColumnHeader
    Friend WithEvents ColumnHeader49 As ColumnHeader
    Friend WithEvents overduebooks As TabPage
    Friend WithEvents overduelv As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents lostbooks As TabPage
    Friend WithEvents lostlv As ListView
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents newbook As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents accessionno As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents author As TextBox
    Friend WithEvents editor As TextBox
    Friend WithEvents edition As TextBox
    Friend WithEvents publicationplace As TextBox
    Friend WithEvents publisher As TextBox
    Friend WithEvents isbn As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents addbtn As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents category As ComboBox
    Friend WithEvents loanperiod As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents admin As TabPage
    Friend WithEvents faculty As TabPage
    Friend WithEvents facultylv As ListView
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader36 As ColumnHeader
    Friend WithEvents ColumnHeader37 As ColumnHeader
    Friend WithEvents student As TabPage
    Friend WithEvents userslv As ListView
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents ColumnHeader33 As ColumnHeader
    Friend WithEvents home As TabPage
    Friend WithEvents cmsallbooks As ContextMenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsuser As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cmsreturn As ContextMenuStrip
    Friend WithEvents ReturnedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents totalbooks As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents totalborrowed As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents totallost As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents totaluser As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents adduser As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ridnumber As TextBox
    Friend WithEvents rname As TextBox
    Friend WithEvents rcontact As TextBox
    Friend WithEvents rpassword As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents rrole As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents rregisterbtn As Button
    Friend WithEvents rcancelbtn As Button
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lusername As TextBox
    Friend WithEvents lpassword As TextBox
    Friend WithEvents lupdate As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents lcontact As TextBox
    Friend WithEvents LostBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverdueBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllBooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OverdueBooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LostBooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents gsearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents nobookstudent As NumericUpDown
    Friend WithEvents nobookfaculty As NumericUpDown
    Friend WithEvents noupdate As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents totalavailable As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents totaloverdue As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents totalfaculties As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents totalstudents As Label
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents complete As TabPage
    Friend WithEvents completelv As ListView
    Friend WithEvents ColumnHeader46 As ColumnHeader
    Friend WithEvents ColumnHeader50 As ColumnHeader
    Friend WithEvents ColumnHeader51 As ColumnHeader
    Friend WithEvents ColumnHeader52 As ColumnHeader
    Friend WithEvents ColumnHeader54 As ColumnHeader
    Friend WithEvents pending As TabPage
    Friend WithEvents pendinglv As ListView
    Friend WithEvents ColumnHeader55 As ColumnHeader
    Friend WithEvents ColumnHeader56 As ColumnHeader
    Friend WithEvents ColumnHeader57 As ColumnHeader
    Friend WithEvents ColumnHeader58 As ColumnHeader
    Friend WithEvents ColumnHeader60 As ColumnHeader
    Friend WithEvents ColumnHeader62 As ColumnHeader
    Friend WithEvents ColumnHeader64 As ColumnHeader
    Friend WithEvents ColumnHeader65 As ColumnHeader
    Friend WithEvents contacterror As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents closetime As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel9 As Panel
End Class
