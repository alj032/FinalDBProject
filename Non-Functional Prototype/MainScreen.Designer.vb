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
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsCheckedOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelMAINLOGO = New System.Windows.Forms.Label()
        Me.ButtonTopSellers = New System.Windows.Forms.Button()
        Me.ButtonMovies = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonTV = New System.Windows.Forms.Button()
        Me.ButtonVideoGames = New System.Windows.Forms.Button()
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelMovieTite = New System.Windows.Forms.Label()
        Me.ButtonCheckout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRating = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCustID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ManagersScreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteItemToolStripMenuItem, Me.ItemsCheckedOutToolStripMenuItem, Me.SalesDataToolStripMenuItem})
        Me.ManagersScreenToolStripMenuItem.Name = "ManagersScreenToolStripMenuItem"
        Me.ManagersScreenToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ManagersScreenToolStripMenuItem.Text = "Managers Screen"
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteItemToolStripMenuItem.Text = "Manage Inventory"
        '
        'ItemsCheckedOutToolStripMenuItem
        '
        Me.ItemsCheckedOutToolStripMenuItem.Name = "ItemsCheckedOutToolStripMenuItem"
        Me.ItemsCheckedOutToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ItemsCheckedOutToolStripMenuItem.Text = "Items Checked Out"
        '
        'SalesDataToolStripMenuItem
        '
        Me.SalesDataToolStripMenuItem.Name = "SalesDataToolStripMenuItem"
        Me.SalesDataToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SalesDataToolStripMenuItem.Text = "Sales Data"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Controls.Add(Me.ButtonTV)
        Me.GroupBox1.Controls.Add(Me.ButtonVideoGames)
        Me.GroupBox1.Controls.Add(Me.ButtonMovies)
        Me.GroupBox1.Controls.Add(Me.ButtonTopSellers)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1321, 160)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
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
        Me.DataGridViewMain.Location = New System.Drawing.Point(21, 205)
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.Size = New System.Drawing.Size(645, 386)
        Me.DataGridViewMain.TabIndex = 16
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(953, 310)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.ReadOnly = True
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrice.TabIndex = 17
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(916, 313)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(31, 13)
        Me.LabelPrice.TabIndex = 20
        Me.LabelPrice.Text = "Price"
        '
        'LabelMovieTite
        '
        Me.LabelMovieTite.AutoSize = True
        Me.LabelMovieTite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMovieTite.Location = New System.Drawing.Point(932, 246)
        Me.LabelMovieTite.Name = "LabelMovieTite"
        Me.LabelMovieTite.Size = New System.Drawing.Size(101, 24)
        Me.LabelMovieTite.TabIndex = 21
        Me.LabelMovieTite.Text = "Movie Title"
        Me.LabelMovieTite.Visible = False
        '
        'ButtonCheckout
        '
        Me.ButtonCheckout.Location = New System.Drawing.Point(899, 508)
        Me.ButtonCheckout.Name = "ButtonCheckout"
        Me.ButtonCheckout.Size = New System.Drawing.Size(187, 44)
        Me.ButtonCheckout.TabIndex = 22
        Me.ButtonCheckout.Text = "Checkout"
        Me.ButtonCheckout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(896, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Category"
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(953, 284)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.ReadOnly = True
        Me.TextBoxCategory.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCategory.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(909, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Rating"
        '
        'TextBoxRating
        '
        Me.TextBoxRating.Location = New System.Drawing.Point(953, 336)
        Me.TextBoxRating.Name = "TextBoxRating"
        Me.TextBoxRating.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRating.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(900, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cutsomer ID:"
        '
        'TextBoxCustID
        '
        Me.TextBoxCustID.Location = New System.Drawing.Point(972, 482)
        Me.TextBoxCustID.Name = "TextBoxCustID"
        Me.TextBoxCustID.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxCustID.TabIndex = 31
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1321, 623)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCustID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCategory)
        Me.Controls.Add(Me.ButtonCheckout)
        Me.Controls.Add(Me.LabelMovieTite)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.DataGridViewMain)
        Me.Controls.Add(Me.LabelMAINLOGO)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainScreen"
        Me.Text = "The Entertainment Store"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LabelMAINLOGO As Label
    Friend WithEvents ButtonTopSellers As Button
    Friend WithEvents ButtonMovies As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ManagersScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonTV As Button
    Friend WithEvents ButtonVideoGames As Button
    Friend WithEvents DataGridViewMain As DataGridView
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelMovieTite As Label
    Friend WithEvents ButtonCheckout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRating As TextBox
    Friend WithEvents ItemsCheckedOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCustID As TextBox
    Friend WithEvents SalesDataToolStripMenuItem As ToolStripMenuItem
End Class
