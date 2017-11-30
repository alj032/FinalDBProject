<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Me.ButtonCheckIn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(794, 428)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonCheckIn
        '
        Me.ButtonCheckIn.Location = New System.Drawing.Point(812, 320)
        Me.ButtonCheckIn.Name = "ButtonCheckIn"
        Me.ButtonCheckIn.Size = New System.Drawing.Size(165, 67)
        Me.ButtonCheckIn.TabIndex = 1
        Me.ButtonCheckIn.Text = "Check In"
        Me.ButtonCheckIn.UseVisualStyleBackColor = True
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 492)
        Me.Controls.Add(Me.ButtonCheckIn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Checkout"
        Me.Text = "Items Currently Checked Out"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonCheckIn As Button
End Class
