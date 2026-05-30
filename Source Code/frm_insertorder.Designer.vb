<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insertorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertorder))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.date_gen = New System.Windows.Forms.DateTimePicker()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst_productid = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_nameproduct = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 46)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.ForeColor = System.Drawing.Color.White
        Me.lbl_order.Location = New System.Drawing.Point(563, 33)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(223, 43)
        Me.lbl_order.TabIndex = 78
        Me.lbl_order.Text = "Make Order"
        '
        'date_gen
        '
        Me.date_gen.CalendarForeColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTitleForeColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.date_gen.Dock = System.Windows.Forms.DockStyle.Right
        Me.date_gen.Location = New System.Drawing.Point(1183, 0)
        Me.date_gen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.date_gen.Name = "date_gen"
        Me.date_gen.Size = New System.Drawing.Size(265, 22)
        Me.date_gen.TabIndex = 79
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(177, 546)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(1025, 137)
        Me.grd_order.TabIndex = 80
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_remove.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.Location = New System.Drawing.Point(769, 790)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(236, 57)
        Me.btn_remove.TabIndex = 81
        Me.btn_remove.Text = "REMOVE ALL"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_confirm.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(432, 790)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(229, 57)
        Me.btn_confirm.TabIndex = 82
        Me.btn_confirm.Text = "CONFRIM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 24)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "ORDER ID:"
        '
        'txt_orderid
        '
        Me.txt_orderid.BackColor = System.Drawing.SystemColors.Control
        Me.txt_orderid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderid.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_orderid.Location = New System.Drawing.Point(236, 238)
        Me.txt_orderid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(131, 26)
        Me.txt_orderid.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "STAFF ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "CUSTOMER ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(580, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "SHOPPING CART:"
        '
        'lst_productid
        '
        Me.lst_productid.FormattingEnabled = True
        Me.lst_productid.ItemHeight = 16
        Me.lst_productid.Location = New System.Drawing.Point(516, 224)
        Me.lst_productid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_productid.Name = "lst_productid"
        Me.lst_productid.Size = New System.Drawing.Size(139, 116)
        Me.lst_productid.TabIndex = 104
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(1088, 239)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(158, 139)
        Me.pic_product.TabIndex = 103
        Me.pic_product.TabStop = False
        '
        'txt_nameproduct
        '
        Me.txt_nameproduct.Location = New System.Drawing.Point(769, 194)
        Me.txt_nameproduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nameproduct.Name = "txt_nameproduct"
        Me.txt_nameproduct.Size = New System.Drawing.Size(247, 22)
        Me.txt_nameproduct.TabIndex = 101
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(769, 316)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(141, 22)
        Me.txt_type.TabIndex = 100
        '
        'txt_product
        '
        Me.txt_product.Location = New System.Drawing.Point(769, 128)
        Me.txt_product.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(100, 22)
        Me.txt_product.TabIndex = 99
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(769, 383)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(159, 22)
        Me.txt_brand.TabIndex = 98
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(769, 257)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(139, 22)
        Me.txt_price.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(512, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Select Product"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(772, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(769, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Price (RM)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(769, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Brand"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(768, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(768, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 17)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "ID"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(236, 293)
        Me.cmb_staff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(131, 24)
        Me.cmb_staff.TabIndex = 105
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(1043, 401)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(236, 57)
        Me.btn_add.TabIndex = 106
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(1083, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Quantity"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(1087, 194)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(139, 22)
        Me.txt_subtotal.TabIndex = 110
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(1083, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "Total (RM)"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(1087, 128)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(139, 22)
        Me.txt_quantity.TabIndex = 112
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(244, 719)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 25)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Total (RM)"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(445, 721)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(139, 22)
        Me.txt_total.TabIndex = 114
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(236, 352)
        Me.cmb_customer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(131, 24)
        Me.cmb_customer.TabIndex = 115
        '
        'frm_insertorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1448, 882)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.lst_productid)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_nameproduct)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_product)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.date_gen)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_insertorder"
        Me.Text = "Make Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_order As Label
    Friend WithEvents date_gen As DateTimePicker
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_productid As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_nameproduct As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_product As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents btn_add As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents cmb_customer As ComboBox
End Class
