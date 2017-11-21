<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageInventoryScreen
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
        Me.DataGridViewDelete = New System.Windows.Forms.DataGridView()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxYear = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTimesRented = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRating = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.ButtonAddRecord = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDelete
        '
        Me.DataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDelete.Location = New System.Drawing.Point(26, 49)
        Me.DataGridViewDelete.Name = "DataGridViewDelete"
        Me.DataGridViewDelete.Size = New System.Drawing.Size(743, 314)
        Me.DataGridViewDelete.TabIndex = 0
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(775, 113)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(146, 58)
        Me.ButtonUpdate.TabIndex = 1
        Me.ButtonUpdate.Text = "Update Record"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(775, 177)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(146, 58)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "Delete Item"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(426, 401)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Year"
        '
        'TextBoxYear
        '
        Me.TextBoxYear.Location = New System.Drawing.Point(463, 398)
        Me.TextBoxYear.Name = "TextBoxYear"
        Me.TextBoxYear.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxYear.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Price"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(269, 395)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrice.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Quantity"
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(269, 439)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxQuantity.TabIndex = 39
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Items.AddRange(New Object() {"TV", "Video Game", "Movie"})
        Me.ComboBoxCategory.Location = New System.Drawing.Point(101, 441)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxCategory.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Times Rented"
        '
        'TextBoxTimesRented
        '
        Me.TextBoxTimesRented.Location = New System.Drawing.Point(463, 440)
        Me.TextBoxTimesRented.Name = "TextBoxTimesRented"
        Me.TextBoxTimesRented.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTimesRented.TabIndex = 35
        Me.TextBoxTimesRented.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(587, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Rating"
        '
        'TextBoxRating
        '
        Me.TextBoxRating.Location = New System.Drawing.Point(631, 437)
        Me.TextBoxRating.Name = "TextBoxRating"
        Me.TextBoxRating.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRating.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Title"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(101, 395)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTitle.TabIndex = 29
        '
        'ButtonAddRecord
        '
        Me.ButtonAddRecord.Location = New System.Drawing.Point(775, 49)
        Me.ButtonAddRecord.Name = "ButtonAddRecord"
        Me.ButtonAddRecord.Size = New System.Drawing.Size(146, 58)
        Me.ButtonAddRecord.TabIndex = 49
        Me.ButtonAddRecord.Text = "Add Record"
        Me.ButtonAddRecord.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(775, 305)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(146, 58)
        Me.ButtonClear.TabIndex = 50
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ManageInventoryScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 545)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonAddRecord)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxYear)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.ComboBoxCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxTimesRented)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.DataGridViewDelete)
        Me.Name = "ManageInventoryScreen"
        Me.Text = "Manage Inventory"
        CType(Me.DataGridViewDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewDelete As DataGridView
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxYear As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents ComboBoxCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTimesRented As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRating As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents ButtonAddRecord As Button
    Friend WithEvents ButtonClear As Button
End Class
