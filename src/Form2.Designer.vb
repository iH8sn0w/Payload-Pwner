<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.Quote = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.find312 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Quote
        '
        Me.Quote.AutoSize = True
        Me.Quote.Location = New System.Drawing.Point(300, 143)
        Me.Quote.Name = "Quote"
        Me.Quote.Size = New System.Drawing.Size(12, 13)
        Me.Quote.TabIndex = 4
        Me.Quote.Text = """"
        Me.Quote.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(325, 77)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pwn 3.1.2 iBoot"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'find312
        '
        Me.find312.FileName = "iPhone2,1_3.1.2_7D11_Restore.ipsw"
        Me.find312.Filter = "iPhone 3GS Firmware|*.ipsw"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 115)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Quote)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payload Pwner - iPod Touch 2G -- By: iH8sn0w"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Quote As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents find312 As System.Windows.Forms.OpenFileDialog
End Class
