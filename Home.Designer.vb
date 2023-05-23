<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Nav3Custom = New System.Windows.Forms.PictureBox()
        Me.BTNHome = New System.Windows.Forms.PictureBox()
        Me.BTNAbout = New System.Windows.Forms.PictureBox()
        Me.BTNRestaurants = New System.Windows.Forms.PictureBox()
        Me.lblNav = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblRestaurants = New System.Windows.Forms.Label()
        Me.bgNav = New System.Windows.Forms.PictureBox()
        Me.CopyrightLBL = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNRemove = New System.Windows.Forms.Button()
        Me.BTNCart = New System.Windows.Forms.Button()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNCustomer = New System.Windows.Forms.PictureBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        CType(Me.Nav3Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNRestaurants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nav3Custom
        '
        Me.Nav3Custom.BackgroundImage = CType(resources.GetObject("Nav3Custom.BackgroundImage"), System.Drawing.Image)
        Me.Nav3Custom.Location = New System.Drawing.Point(12, 12)
        Me.Nav3Custom.Name = "Nav3Custom"
        Me.Nav3Custom.Size = New System.Drawing.Size(124, 259)
        Me.Nav3Custom.TabIndex = 0
        Me.Nav3Custom.TabStop = False
        '
        'BTNHome
        '
        Me.BTNHome.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNHome.BackgroundImage = CType(resources.GetObject("BTNHome.BackgroundImage"), System.Drawing.Image)
        Me.BTNHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHome.Location = New System.Drawing.Point(46, 52)
        Me.BTNHome.Name = "BTNHome"
        Me.BTNHome.Size = New System.Drawing.Size(58, 58)
        Me.BTNHome.TabIndex = 1
        Me.BTNHome.TabStop = False
        '
        'BTNAbout
        '
        Me.BTNAbout.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNAbout.BackgroundImage = CType(resources.GetObject("BTNAbout.BackgroundImage"), System.Drawing.Image)
        Me.BTNAbout.Location = New System.Drawing.Point(46, 119)
        Me.BTNAbout.Name = "BTNAbout"
        Me.BTNAbout.Size = New System.Drawing.Size(58, 58)
        Me.BTNAbout.TabIndex = 2
        Me.BTNAbout.TabStop = False
        '
        'BTNRestaurants
        '
        Me.BTNRestaurants.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNRestaurants.BackgroundImage = CType(resources.GetObject("BTNRestaurants.BackgroundImage"), System.Drawing.Image)
        Me.BTNRestaurants.Location = New System.Drawing.Point(46, 187)
        Me.BTNRestaurants.Name = "BTNRestaurants"
        Me.BTNRestaurants.Size = New System.Drawing.Size(58, 58)
        Me.BTNRestaurants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNRestaurants.TabIndex = 3
        Me.BTNRestaurants.TabStop = False
        '
        'lblNav
        '
        Me.lblNav.AutoSize = True
        Me.lblNav.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblNav.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNav.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNav.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNav.Location = New System.Drawing.Point(31, 24)
        Me.lblNav.Name = "lblNav"
        Me.lblNav.Size = New System.Drawing.Size(84, 15)
        Me.lblNav.TabIndex = 4
        Me.lblNav.Text = "Navigation"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.BackColor = System.Drawing.Color.Silver
        Me.lblHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHome.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHome.Location = New System.Drawing.Point(49, 93)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(52, 15)
        Me.lblHome.TabIndex = 5
        Me.lblHome.Text = "HOME"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Silver
        Me.lblAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAbout.Font = New System.Drawing.Font("Lucida Calligraphy", 2.45!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAbout.Location = New System.Drawing.Point(47, 164)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(55, 13)
        Me.lblAbout.TabIndex = 6
        Me.lblAbout.Text = "ABOUT"
        '
        'lblRestaurants
        '
        Me.lblRestaurants.AutoSize = True
        Me.lblRestaurants.BackColor = System.Drawing.Color.Silver
        Me.lblRestaurants.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRestaurants.Font = New System.Drawing.Font("Lucida Calligraphy", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaurants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRestaurants.Location = New System.Drawing.Point(34, 237)
        Me.lblRestaurants.Name = "lblRestaurants"
        Me.lblRestaurants.Size = New System.Drawing.Size(73, 8)
        Me.lblRestaurants.TabIndex = 7
        Me.lblRestaurants.Text = "RESTAURANT"
        '
        'bgNav
        '
        Me.bgNav.BackColor = System.Drawing.Color.NavajoWhite
        Me.bgNav.Location = New System.Drawing.Point(0, 0)
        Me.bgNav.Name = "bgNav"
        Me.bgNav.Size = New System.Drawing.Size(152, 503)
        Me.bgNav.TabIndex = 8
        Me.bgNav.TabStop = False
        '
        'CopyrightLBL
        '
        Me.CopyrightLBL.AutoSize = True
        Me.CopyrightLBL.BackColor = System.Drawing.Color.NavajoWhite
        Me.CopyrightLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyrightLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CopyrightLBL.Location = New System.Drawing.Point(12, 488)
        Me.CopyrightLBL.Name = "CopyrightLBL"
        Me.CopyrightLBL.Size = New System.Drawing.Size(125, 12)
        Me.CopyrightLBL.TabIndex = 10
        Me.CopyrightLBL.Text = "@2023    FoodieMonarch Inc."
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(310, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(404, 20)
        Me.txtSearch.TabIndex = 11
        '
        'BTNSearch
        '
        Me.BTNSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTNSearch.Location = New System.Drawing.Point(220, 10)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.Size = New System.Drawing.Size(75, 23)
        Me.BTNSearch.TabIndex = 12
        Me.BTNSearch.Text = "Search"
        Me.BTNSearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Violet
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BTNRemove)
        Me.GroupBox1.Controls.Add(Me.BTNCart)
        Me.GroupBox1.Controls.Add(Me.txtVAT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProductPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(174, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 203)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cashiering Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BTNRemove
        '
        Me.BTNRemove.BackColor = System.Drawing.Color.Red
        Me.BTNRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRemove.Location = New System.Drawing.Point(366, 153)
        Me.BTNRemove.Name = "BTNRemove"
        Me.BTNRemove.Size = New System.Drawing.Size(105, 22)
        Me.BTNRemove.TabIndex = 25
        Me.BTNRemove.Text = "Remove"
        Me.BTNRemove.UseVisualStyleBackColor = False
        '
        'BTNCart
        '
        Me.BTNCart.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNCart.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCart.Location = New System.Drawing.Point(480, 148)
        Me.BTNCart.Name = "BTNCart"
        Me.BTNCart.Size = New System.Drawing.Size(100, 33)
        Me.BTNCart.TabIndex = 23
        Me.BTNCart.Text = "Add to Cart"
        Me.BTNCart.UseVisualStyleBackColor = False
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(501, 77)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(79, 20)
        Me.txtVAT.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "VAT 12%"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(501, 38)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(79, 20)
        Me.txtTotalPrice.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(260, 112)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(139, 20)
        Me.txtQuantity.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Quantity"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(260, 74)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(139, 20)
        Me.txtProductPrice.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Product Price"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(260, 38)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(139, 20)
        Me.txtProductName.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'BTNCustomer
        '
        Me.BTNCustomer.BackColor = System.Drawing.Color.NavajoWhite
        Me.BTNCustomer.BackgroundImage = CType(resources.GetObject("BTNCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BTNCustomer.Image = CType(resources.GetObject("BTNCustomer.Image"), System.Drawing.Image)
        Me.BTNCustomer.Location = New System.Drawing.Point(46, 334)
        Me.BTNCustomer.Name = "BTNCustomer"
        Me.BTNCustomer.Size = New System.Drawing.Size(58, 58)
        Me.BTNCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNCustomer.TabIndex = 14
        Me.BTNCustomer.TabStop = False
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblCustomer.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(25, 395)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(102, 28)
        Me.lblCustomer.TabIndex = 15
        Me.lblCustomer.Text = "Customer Reservation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "History"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(809, 502)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.BTNCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.CopyrightLBL)
        Me.Controls.Add(Me.lblRestaurants)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblNav)
        Me.Controls.Add(Me.BTNRestaurants)
        Me.Controls.Add(Me.BTNAbout)
        Me.Controls.Add(Me.BTNHome)
        Me.Controls.Add(Me.Nav3Custom)
        Me.Controls.Add(Me.bgNav)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.Nav3Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNRestaurants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nav3Custom As PictureBox
    Friend WithEvents BTNHome As PictureBox
    Friend WithEvents BTNAbout As PictureBox
    Friend WithEvents BTNRestaurants As PictureBox
    Friend WithEvents lblNav As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblRestaurants As Label
    Friend WithEvents bgNav As PictureBox
    Friend WithEvents CopyrightLBL As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BTNSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNCart As Button
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNRemove As Button
    Friend WithEvents BTNCustomer As PictureBox
    Friend WithEvents lblCustomer As Label
End Class
