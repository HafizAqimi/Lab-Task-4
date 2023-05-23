<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WelcomeSign = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CopyrightLBL = New System.Windows.Forms.Label()
        Me.linkResetPassword = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Location = New System.Drawing.Point(27, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 401)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WelcomeSign
        '
        Me.WelcomeSign.BackColor = System.Drawing.Color.LightCoral
        Me.WelcomeSign.BackgroundImage = CType(resources.GetObject("WelcomeSign.BackgroundImage"), System.Drawing.Image)
        Me.WelcomeSign.Location = New System.Drawing.Point(27, 29)
        Me.WelcomeSign.Name = "WelcomeSign"
        Me.WelcomeSign.Size = New System.Drawing.Size(438, 156)
        Me.WelcomeSign.TabIndex = 1
        Me.WelcomeSign.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.LightCoral
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblUsername.Location = New System.Drawing.Point(95, 227)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(64, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username : "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(177, 224)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(225, 20)
        Me.txtUsername.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.LightCoral
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblEmail.Location = New System.Drawing.Point(95, 271)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email : "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(177, 268)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(177, 311)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(225, 20)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.LightCoral
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPassword.Location = New System.Drawing.Point(95, 314)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(62, 13)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password : "
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Tomato
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(127, 358)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(234, 36)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'CopyrightLBL
        '
        Me.CopyrightLBL.AutoSize = True
        Me.CopyrightLBL.BackColor = System.Drawing.Color.Transparent
        Me.CopyrightLBL.ForeColor = System.Drawing.SystemColors.Control
        Me.CopyrightLBL.Location = New System.Drawing.Point(134, 465)
        Me.CopyrightLBL.Name = "CopyrightLBL"
        Me.CopyrightLBL.Size = New System.Drawing.Size(210, 13)
        Me.CopyrightLBL.TabIndex = 9
        Me.CopyrightLBL.Text = "@2023    FoodieMonarch Inc. , Copyrights."
        '
        'linkResetPassword
        '
        Me.linkResetPassword.AutoSize = True
        Me.linkResetPassword.Location = New System.Drawing.Point(154, 400)
        Me.linkResetPassword.Name = "linkResetPassword"
        Me.linkResetPassword.Size = New System.Drawing.Size(175, 13)
        Me.linkResetPassword.TabIndex = 10
        Me.linkResetPassword.TabStop = True
        Me.linkResetPassword.Text = "Forgot Password? Reset Password."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(498, 487)
        Me.Controls.Add(Me.linkResetPassword)
        Me.Controls.Add(Me.CopyrightLBL)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.WelcomeSign)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeSign As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents CopyrightLBL As Label
    Friend WithEvents linkResetPassword As LinkLabel
End Class
