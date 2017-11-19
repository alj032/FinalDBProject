<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManagersScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelMAINLOGO = New System.Windows.Forms.Label()
        Me.ButtonTopSellers = New System.Windows.Forms.Button()
        Me.ButtonMovies = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonTV = New System.Windows.Forms.Button()
        Me.ButtonVideoGames = New System.Windows.Forms.Button()
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.LabelQuantity = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelMovieTite = New System.Windows.Forms.Label()
        Me.ButtonCheckout = New System.Windows.Forms.Button()
        Me.LabelGenre = New System.Windows.Forms.Label()
        Me.TextBoxGenre = New System.Windows.Forms.TextBox()
        Me.PictureBoxOutOfStock = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutOfStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagersScreenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1321, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManagersScreenToolStripMenuItem
        '
        Me.ManagersScreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.DeleteItemToolStripMenuItem})
        Me.ManagersScreenToolStripMenuItem.Name = "ManagersScreenToolStripMenuItem"
        Me.ManagersScreenToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ManagersScreenToolStripMenuItem.Text = "Managers Screen"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'LabelMAINLOGO
        '
        Me.LabelMAINLOGO.AutoSize = True
        Me.LabelMAINLOGO.BackColor = System.Drawing.SystemColors.GrayText
        Me.LabelMAINLOGO.Font = New System.Drawing.Font("Pristina", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMAINLOGO.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelMAINLOGO.Location = New System.Drawing.Point(12, 45)
        Me.LabelMAINLOGO.Name = "LabelMAINLOGO"
        Me.LabelMAINLOGO.Size = New System.Drawing.Size(456, 49)
        Me.LabelMAINLOGO.TabIndex = 8
        Me.LabelMAINLOGO.Text = "Welcome to The Entertainment Store"
        '
        'ButtonTopSellers
        '
        Me.ButtonTopSellers.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTopSellers.Location = New System.Drawing.Point(577, 20)
        Me.ButtonTopSellers.Name = "ButtonTopSellers"
        Me.ButtonTopSellers.Size = New System.Drawing.Size(168, 53)
        Me.ButtonTopSellers.TabIndex = 9
        Me.ButtonTopSellers.Text = "Top Sellers"
        Me.ButtonTopSellers.UseVisualStyleBackColor = True
        '
        'ButtonMovies
        '
        Me.ButtonMovies.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMovies.Location = New System.Drawing.Point(403, 79)
        Me.ButtonMovies.Name = "ButtonMovies"
        Me.ButtonMovies.Size = New System.Drawing.Size(168, 53)
        Me.ButtonMovies.TabIndex = 10
        Me.ButtonMovies.Text = "Movies"
        Me.ButtonMovies.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(1092, 83)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxSearch.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Non_Functional_Prototype.My.Resources.Resources.that_70s_show
        Me.PictureBox1.Location = New System.Drawing.Point(1034, 270)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 261)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.ButtonTV)
        Me.GroupBox1.Controls.Add(Me.ButtonVideoGames)
        Me.GroupBox1.Controls.Add(Me.ButtonMovies)
        Me.GroupBox1.Controls.Add(Me.ButtonTopSellers)
        Me.GroupBox1.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1321, 160)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(1002, 77)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(84, 42)
        Me.ButtonSearch.TabIndex = 14
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonTV
        '
        Me.ButtonTV.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTV.Location = New System.Drawing.Point(751, 79)
        Me.ButtonTV.Name = "ButtonTV"
        Me.ButtonTV.Size = New System.Drawing.Size(168, 53)
        Me.ButtonTV.TabIndex = 12
        Me.ButtonTV.Text = "TV"
        Me.ButtonTV.UseVisualStyleBackColor = True
        '
        'ButtonVideoGames
        '
        Me.ButtonVideoGames.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVideoGames.Location = New System.Drawing.Point(577, 79)
        Me.ButtonVideoGames.Name = "ButtonVideoGames"
        Me.ButtonVideoGames.Size = New System.Drawing.Size(168, 53)
        Me.ButtonVideoGames.TabIndex = 11
        Me.ButtonVideoGames.Text = "Video Games"
        Me.ButtonVideoGames.UseVisualStyleBackColor = True
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.Location = New System.Drawing.Point(79, 236)
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.Size = New System.Drawing.Size(602, 355)
        Me.DataGridViewMain.TabIndex = 16
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(819, 377)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.ReadOnly = True
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrice.TabIndex = 17
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(819, 351)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxQuantity.TabIndex = 18
        '
        'LabelQuantity
        '
        Me.LabelQuantity.AutoSize = True
        Me.LabelQuantity.Location = New System.Drawing.Point(767, 358)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(46, 13)
        Me.LabelQuantity.TabIndex = 19
        Me.LabelQuantity.Text = "Quantity"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(782, 380)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(31, 13)
        Me.LabelPrice.TabIndex = 20
        Me.LabelPrice.Text = "Price"
        '
        'LabelMovieTite
        '
        Me.LabelMovieTite.AutoSize = True
        Me.LabelMovieTite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMovieTite.Location = New System.Drawing.Point(1078, 243)
        Me.LabelMovieTite.Name = "LabelMovieTite"
        Me.LabelMovieTite.Size = New System.Drawing.Size(101, 24)
        Me.LabelMovieTite.TabIndex = 21
        Me.LabelMovieTite.Text = "Movie Title"
        '
        'ButtonCheckout
        '
        Me.ButtonCheckout.Location = New System.Drawing.Point(765, 417)
        Me.ButtonCheckout.Name = "ButtonCheckout"
        Me.ButtonCheckout.Size = New System.Drawing.Size(187, 44)
        Me.ButtonCheckout.TabIndex = 22
        Me.ButtonCheckout.Text = "Checkout"
        Me.ButtonCheckout.UseVisualStyleBackColor = True
        '
        'LabelGenre
        '
        Me.LabelGenre.AutoSize = True
        Me.LabelGenre.Location = New System.Drawing.Point(775, 332)
        Me.LabelGenre.Name = "LabelGenre"
        Me.LabelGenre.Size = New System.Drawing.Size(36, 13)
        Me.LabelGenre.TabIndex = 24
        Me.LabelGenre.Text = "Genre"
        '
        'TextBoxGenre
        '
        Me.TextBoxGenre.Location = New System.Drawing.Point(819, 325)
        Me.TextBoxGenre.Name = "TextBoxGenre"
        Me.TextBoxGenre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGenre.TabIndex = 23
        '
        'PictureBoxOutOfStock
        '
        Me.PictureBoxOutOfStock.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxOutOfStock.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.out_of_stock
        Me.PictureBoxOutOfStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxOutOfStock.Location = New System.Drawing.Point(988, 537)
        Me.PictureBoxOutOfStock.Name = "PictureBoxOutOfStock"
        Me.PictureBoxOutOfStock.Size = New System.Drawing.Size(267, 74)
        Me.PictureBoxOutOfStock.TabIndex = 25
        Me.PictureBoxOutOfStock.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(762, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Category"
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(819, 299)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.ReadOnly = True
        Me.TextBoxCategory.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCategory.TabIndex = 26
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Delete Item"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1321, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCategory)
        Me.Controls.Add(Me.PictureBoxOutOfStock)
        Me.Controls.Add(Me.LabelGenre)
        Me.Controls.Add(Me.TextBoxGenre)
        Me.Controls.Add(Me.ButtonCheckout)
        Me.Controls.Add(Me.LabelMovieTite)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelQuantity)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.DataGridViewMain)
        Me.Controls.Add(Me.LabelMAINLOGO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainScreen"
        Me.Text = "The Entertainment Store"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutOfStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelMAINLOGO As Label
    Friend WithEvents ButtonTopSellers As Button
    Friend WithEvents ButtonMovies As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ManagersScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonTV As Button
    Friend WithEvents ButtonVideoGames As Button
    Friend WithEvents DataGridViewMain As DataGridView
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents LabelQuantity As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelMovieTite As Label
    Friend WithEvents ButtonCheckout As Button
    Friend WithEvents LabelGenre As Label
    Friend WithEvents TextBoxGenre As TextBox
    Friend WithEvents PictureBoxOutOfStock As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
End Class
