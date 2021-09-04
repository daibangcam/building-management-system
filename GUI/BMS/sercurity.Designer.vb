<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sercurity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sercurity))
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.btn_verify = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(103, 43)
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.Size = New System.Drawing.Size(117, 21)
        Me.txtbox_pass.TabIndex = 39
        Me.txtbox_pass.Text = "admin"
        '
        'txtbox_user
        '
        Me.txtbox_user.Location = New System.Drawing.Point(103, 10)
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(117, 21)
        Me.txtbox_user.TabIndex = 40
        Me.txtbox_user.Text = "admin"
        '
        'btn_verify
        '
        Me.btn_verify.Location = New System.Drawing.Point(71, 81)
        Me.btn_verify.Name = "btn_verify"
        Me.btn_verify.Size = New System.Drawing.Size(92, 28)
        Me.btn_verify.TabIndex = 38
        Me.btn_verify.Text = "Verify"
        Me.btn_verify.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Username"
        '
        'sercurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 120)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.btn_verify)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sercurity"
        Me.Text = "Sercurity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents btn_verify As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
