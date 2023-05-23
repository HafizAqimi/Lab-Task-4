<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restaurant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restaurant))
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.BTNCustomer = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNReservation = New System.Windows.Forms.Button()
        Me.txtPopularDish = New System.Windows.Forms.TextBox()
        Me.lblPopularDish = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.txtCuisine = New System.Windows.Forms.TextBox()
        Me.lblCuisine = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtRestaurantName = New System.Windows.Forms.TextBox()
        Me.lblRestaurantName = New System.Windows.Forms.Label()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.CopyrightLBL = New System.Windows.Forms.Label()
        Me.bgNav = New System.Windows.Forms.PictureBox()
        Me.Nav3Custom = New System.Windows.Forms.PictureBox()
        Me.lblNav = New System.Windows.Forms.Label()
        Me.lblRestaurants = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.BTNRestaurants = New System.Windows.Forms.PictureBox()
        Me.BTNAbout = New System.Windows.Forms.PictureBox()
        Me.BTNHome = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblReseDate = New System.Windows.Forms.Label()
        Me.txtReseDate = New System.Windows.Forms.TextBox()
        Me.lblRestName = New System.Windows.Forms.Label()
        Me.txtRestName = New System.Windows.Forms.TextBox()
        Me.lblRestLocation = New System.Windows.Forms.Label()
        Me.txtRestLocation = New System.Windows.Forms.TextBox()
        Me.BTNConfirm = New System.Windows.Forms.Button()
        Me.txtRating = New System.Windows.Forms.TextBox()
        CType(Me.BTNCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nav3Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNRestaurants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblCustomer.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(25, 395)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(102, 28)
        Me.lblCustomer.TabIndex = 30
        Me.lblCustomer.Text = "Customer Reservation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "History"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BTNCustomer.TabIndex = 29
        Me.BTNCustomer.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.txtRating)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.BTNCancel)
        Me.GroupBox1.Controls.Add(Me.BTNReservation)
        Me.GroupBox1.Controls.Add(Me.txtPopularDish)
        Me.GroupBox1.Controls.Add(Me.lblPopularDish)
        Me.GroupBox1.Controls.Add(Me.lblRating)
        Me.GroupBox1.Controls.Add(Me.txtCuisine)
        Me.GroupBox1.Controls.Add(Me.lblCuisine)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.txtRestaurantName)
        Me.GroupBox1.Controls.Add(Me.lblRestaurantName)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(174, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 300)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Restaurant Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BTNCancel
        '
        Me.BTNCancel.BackColor = System.Drawing.Color.Red
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.Location = New System.Drawing.Point(348, 253)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(105, 22)
        Me.BTNCancel.TabIndex = 25
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.UseVisualStyleBackColor = False
        '
        'BTNReservation
        '
        Me.BTNReservation.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNReservation.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNReservation.Location = New System.Drawing.Point(473, 247)
        Me.BTNReservation.Name = "BTNReservation"
        Me.BTNReservation.Size = New System.Drawing.Size(116, 33)
        Me.BTNReservation.TabIndex = 23
        Me.BTNReservation.Text = "Make a Reservation"
        Me.BTNReservation.UseVisualStyleBackColor = False
        '
        'txtPopularDish
        '
        Me.txtPopularDish.Location = New System.Drawing.Point(313, 190)
        Me.txtPopularDish.Name = "txtPopularDish"
        Me.txtPopularDish.Size = New System.Drawing.Size(276, 20)
        Me.txtPopularDish.TabIndex = 22
        '
        'lblPopularDish
        '
        Me.lblPopularDish.AutoSize = True
        Me.lblPopularDish.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPopularDish.Location = New System.Drawing.Point(205, 193)
        Me.lblPopularDish.Name = "lblPopularDish"
        Me.lblPopularDish.Size = New System.Drawing.Size(67, 13)
        Me.lblPopularDish.TabIndex = 21
        Me.lblPopularDish.Text = "Popular Dish"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(46, 28)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(51, 20)
        Me.txtCustomerID.TabIndex = 20
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRating.Location = New System.Drawing.Point(205, 154)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(38, 13)
        Me.lblRating.TabIndex = 19
        Me.lblRating.Text = "Rating"
        '
        'txtCuisine
        '
        Me.txtCuisine.Location = New System.Drawing.Point(313, 112)
        Me.txtCuisine.Name = "txtCuisine"
        Me.txtCuisine.Size = New System.Drawing.Size(158, 20)
        Me.txtCuisine.TabIndex = 18
        '
        'lblCuisine
        '
        Me.lblCuisine.AutoSize = True
        Me.lblCuisine.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCuisine.Location = New System.Drawing.Point(205, 115)
        Me.lblCuisine.Name = "lblCuisine"
        Me.lblCuisine.Size = New System.Drawing.Size(41, 13)
        Me.lblCuisine.TabIndex = 17
        Me.lblCuisine.Text = "Cuisine"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(313, 74)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(276, 20)
        Me.txtLocation.TabIndex = 16
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLocation.Location = New System.Drawing.Point(205, 77)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 15
        Me.lblLocation.Text = "Location"
        '
        'txtRestaurantName
        '
        Me.txtRestaurantName.Location = New System.Drawing.Point(313, 38)
        Me.txtRestaurantName.Name = "txtRestaurantName"
        Me.txtRestaurantName.Size = New System.Drawing.Size(276, 20)
        Me.txtRestaurantName.TabIndex = 14
        '
        'lblRestaurantName
        '
        Me.lblRestaurantName.AutoSize = True
        Me.lblRestaurantName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRestaurantName.Location = New System.Drawing.Point(205, 41)
        Me.lblRestaurantName.Name = "lblRestaurantName"
        Me.lblRestaurantName.Size = New System.Drawing.Size(90, 13)
        Me.lblRestaurantName.TabIndex = 0
        Me.lblRestaurantName.Text = "Restaurant Name"
        '
        'BTNSearch
        '
        Me.BTNSearch.BackColor = System.Drawing.Color.DarkOrange
        Me.BTNSearch.Location = New System.Drawing.Point(220, 10)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.Size = New System.Drawing.Size(75, 23)
        Me.BTNSearch.TabIndex = 27
        Me.BTNSearch.Text = "Search"
        Me.BTNSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(310, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(404, 20)
        Me.txtSearch.TabIndex = 26
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
        Me.CopyrightLBL.TabIndex = 25
        Me.CopyrightLBL.Text = "@2023    FoodieMonarch Inc."
        '
        'bgNav
        '
        Me.bgNav.BackColor = System.Drawing.Color.NavajoWhite
        Me.bgNav.Location = New System.Drawing.Point(0, 0)
        Me.bgNav.Name = "bgNav"
        Me.bgNav.Size = New System.Drawing.Size(152, 503)
        Me.bgNav.TabIndex = 24
        Me.bgNav.TabStop = False
        '
        'Nav3Custom
        '
        Me.Nav3Custom.BackgroundImage = CType(resources.GetObject("Nav3Custom.BackgroundImage"), System.Drawing.Image)
        Me.Nav3Custom.Location = New System.Drawing.Point(12, 12)
        Me.Nav3Custom.Name = "Nav3Custom"
        Me.Nav3Custom.Size = New System.Drawing.Size(124, 259)
        Me.Nav3Custom.TabIndex = 31
        Me.Nav3Custom.TabStop = False
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
        Me.lblNav.TabIndex = 32
        Me.lblNav.Text = "Navigation"
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
        Me.lblRestaurants.TabIndex = 38
        Me.lblRestaurants.Text = "RESTAURANT"
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
        Me.lblAbout.TabIndex = 37
        Me.lblAbout.Text = "ABOUT"
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
        Me.lblHome.TabIndex = 36
        Me.lblHome.Text = "HOME"
        '
        'BTNRestaurants
        '
        Me.BTNRestaurants.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNRestaurants.BackgroundImage = CType(resources.GetObject("BTNRestaurants.BackgroundImage"), System.Drawing.Image)
        Me.BTNRestaurants.Location = New System.Drawing.Point(46, 187)
        Me.BTNRestaurants.Name = "BTNRestaurants"
        Me.BTNRestaurants.Size = New System.Drawing.Size(58, 58)
        Me.BTNRestaurants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNRestaurants.TabIndex = 35
        Me.BTNRestaurants.TabStop = False
        '
        'BTNAbout
        '
        Me.BTNAbout.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNAbout.BackgroundImage = CType(resources.GetObject("BTNAbout.BackgroundImage"), System.Drawing.Image)
        Me.BTNAbout.Location = New System.Drawing.Point(46, 119)
        Me.BTNAbout.Name = "BTNAbout"
        Me.BTNAbout.Size = New System.Drawing.Size(58, 58)
        Me.BTNAbout.TabIndex = 34
        Me.BTNAbout.TabStop = False
        '
        'BTNHome
        '
        Me.BTNHome.BackColor = System.Drawing.Color.SandyBrown
        Me.BTNHome.BackgroundImage = CType(resources.GetObject("BTNHome.BackgroundImage"), System.Drawing.Image)
        Me.BTNHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHome.Location = New System.Drawing.Point(46, 52)
        Me.BTNHome.Name = "BTNHome"
        Me.BTNHome.Size = New System.Drawing.Size(58, 58)
        Me.BTNHome.TabIndex = 33
        Me.BTNHome.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Controls.Add(Me.BTNConfirm)
        Me.GroupBox2.Controls.Add(Me.lblRestLocation)
        Me.GroupBox2.Controls.Add(Me.txtRestLocation)
        Me.GroupBox2.Controls.Add(Me.lblRestName)
        Me.GroupBox2.Controls.Add(Me.txtRestName)
        Me.GroupBox2.Controls.Add(Me.lblReseDate)
        Me.GroupBox2.Controls.Add(Me.txtReseDate)
        Me.GroupBox2.Controls.Add(Me.lblLName)
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.lblFName)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Controls.Add(Me.lblCustomerID)
        Me.GroupBox2.Controls.Add(Me.txtCustomerID)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(174, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 149)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reservation"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCustomerID.Location = New System.Drawing.Point(18, 31)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(18, 13)
        Me.lblCustomerID.TabIndex = 27
        Me.lblCustomerID.Text = "ID"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFName.Location = New System.Drawing.Point(120, 34)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 29
        Me.lblFName.Text = "First Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(180, 31)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(79, 20)
        Me.txtFName.TabIndex = 28
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLName.Location = New System.Drawing.Point(263, 34)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 31
        Me.lblLName.Text = "Last Name"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(323, 31)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(79, 20)
        Me.txtLName.TabIndex = 30
        '
        'lblReseDate
        '
        Me.lblReseDate.AutoSize = True
        Me.lblReseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReseDate.Location = New System.Drawing.Point(17, 112)
        Me.lblReseDate.Name = "lblReseDate"
        Me.lblReseDate.Size = New System.Drawing.Size(90, 13)
        Me.lblReseDate.TabIndex = 33
        Me.lblReseDate.Text = "Reservation Date"
        '
        'txtReseDate
        '
        Me.txtReseDate.Location = New System.Drawing.Point(108, 109)
        Me.txtReseDate.Name = "txtReseDate"
        Me.txtReseDate.Size = New System.Drawing.Size(135, 20)
        Me.txtReseDate.TabIndex = 32
        '
        'lblRestName
        '
        Me.lblRestName.AutoSize = True
        Me.lblRestName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRestName.Location = New System.Drawing.Point(17, 60)
        Me.lblRestName.Name = "lblRestName"
        Me.lblRestName.Size = New System.Drawing.Size(90, 13)
        Me.lblRestName.TabIndex = 35
        Me.lblRestName.Text = "Restaurant Name"
        '
        'txtRestName
        '
        Me.txtRestName.Location = New System.Drawing.Point(108, 57)
        Me.txtRestName.Name = "txtRestName"
        Me.txtRestName.Size = New System.Drawing.Size(294, 20)
        Me.txtRestName.TabIndex = 34
        '
        'lblRestLocation
        '
        Me.lblRestLocation.AutoSize = True
        Me.lblRestLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRestLocation.Location = New System.Drawing.Point(17, 86)
        Me.lblRestLocation.Name = "lblRestLocation"
        Me.lblRestLocation.Size = New System.Drawing.Size(103, 13)
        Me.lblRestLocation.TabIndex = 37
        Me.lblRestLocation.Text = "Restaurant Location"
        '
        'txtRestLocation
        '
        Me.txtRestLocation.Location = New System.Drawing.Point(126, 83)
        Me.txtRestLocation.Name = "txtRestLocation"
        Me.txtRestLocation.Size = New System.Drawing.Size(276, 20)
        Me.txtRestLocation.TabIndex = 36
        '
        'BTNConfirm
        '
        Me.BTNConfirm.BackColor = System.Drawing.Color.Lime
        Me.BTNConfirm.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNConfirm.Location = New System.Drawing.Point(473, 96)
        Me.BTNConfirm.Name = "BTNConfirm"
        Me.BTNConfirm.Size = New System.Drawing.Size(116, 33)
        Me.BTNConfirm.TabIndex = 27
        Me.BTNConfirm.Text = "Confirm"
        Me.BTNConfirm.UseVisualStyleBackColor = False
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(313, 151)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(89, 20)
        Me.txtRating.TabIndex = 38
        '
        'Restaurant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 502)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblRestaurants)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.BTNRestaurants)
        Me.Controls.Add(Me.BTNAbout)
        Me.Controls.Add(Me.BTNHome)
        Me.Controls.Add(Me.lblNav)
        Me.Controls.Add(Me.Nav3Custom)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.BTNCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.CopyrightLBL)
        Me.Controls.Add(Me.bgNav)
        Me.Name = "Restaurant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant"
        CType(Me.BTNCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nav3Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNRestaurants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomer As Label
    Friend WithEvents BTNCustomer As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNCancel As Button
    Friend WithEvents BTNReservation As Button
    Friend WithEvents txtPopularDish As TextBox
    Friend WithEvents lblPopularDish As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblRating As Label
    Friend WithEvents txtCuisine As TextBox
    Friend WithEvents lblCuisine As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtRestaurantName As TextBox
    Friend WithEvents lblRestaurantName As Label
    Friend WithEvents BTNSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents CopyrightLBL As Label
    Friend WithEvents bgNav As PictureBox
    Friend WithEvents Nav3Custom As PictureBox
    Friend WithEvents lblNav As Label
    Friend WithEvents lblRestaurants As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents BTNRestaurants As PictureBox
    Friend WithEvents BTNAbout As PictureBox
    Friend WithEvents BTNHome As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNConfirm As Button
    Friend WithEvents lblRestLocation As Label
    Friend WithEvents txtRestLocation As TextBox
    Friend WithEvents lblRestName As Label
    Friend WithEvents txtRestName As TextBox
    Friend WithEvents lblReseDate As Label
    Friend WithEvents txtReseDate As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtRating As TextBox
End Class
