<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesData
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
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(465, 428)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(104, 50)
        Me.ButtonLoad.TabIndex = 1
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'SalesData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Non_Functional_Prototype.My.Resources.Resources.MainScreenBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1049, 552)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Name = "SalesData"
        Me.Text = "Sales Data"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonLoad As Button
End Class
