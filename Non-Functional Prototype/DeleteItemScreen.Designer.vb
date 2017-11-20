<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteItemScreen
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonDisable = New System.Windows.Forms.Button()
        Me.ButtonEnable = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 314)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(775, 177)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(146, 58)
        Me.ButtonUpdate.TabIndex = 1
        Me.ButtonUpdate.Text = "Update Record"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        Me.ButtonUpdate.Visible = False
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
        'ButtonDisable
        '
        Me.ButtonDisable.Location = New System.Drawing.Point(775, 49)
        Me.ButtonDisable.Name = "ButtonDisable"
        Me.ButtonDisable.Size = New System.Drawing.Size(146, 58)
        Me.ButtonDisable.TabIndex = 4
        Me.ButtonDisable.Text = "Disable Editing Mode"
        Me.ButtonDisable.UseVisualStyleBackColor = True
        Me.ButtonDisable.Visible = False
        '
        'ButtonEnable
        '
        Me.ButtonEnable.Location = New System.Drawing.Point(775, 49)
        Me.ButtonEnable.Name = "ButtonEnable"
        Me.ButtonEnable.Size = New System.Drawing.Size(146, 58)
        Me.ButtonEnable.TabIndex = 3
        Me.ButtonEnable.Text = "Enable Editing Mode"
        Me.ButtonEnable.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 58)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DeleteItemScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(932, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDisable)
        Me.Controls.Add(Me.ButtonEnable)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DeleteItemScreen"
        Me.Text = "Delete Item"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonDisable As Button
    Friend WithEvents ButtonEnable As Button
    Friend WithEvents Button1 As Button
End Class
