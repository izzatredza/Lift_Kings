<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a187795
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a187795))
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_lists = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_customer.Location = New System.Drawing.Point(445, 323)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(201, 119)
        Me.btn_customer.TabIndex = 1
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AccessibleName = "Label of the app"
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(334, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lift Kings"
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_order.Location = New System.Drawing.Point(141, 323)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(201, 119)
        Me.btn_order.TabIndex = 3
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_lists
        '
        Me.btn_lists.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_lists.Location = New System.Drawing.Point(296, 472)
        Me.btn_lists.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_lists.Name = "btn_lists"
        Me.btn_lists.Size = New System.Drawing.Size(201, 119)
        Me.btn_lists.TabIndex = 4
        Me.btn_lists.Text = "Lists"
        Me.btn_lists.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_staff.Location = New System.Drawing.Point(445, 171)
        Me.btn_staff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(201, 119)
        Me.btn_staff.TabIndex = 5
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_product.Location = New System.Drawing.Point(141, 171)
        Me.btn_product.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(201, 119)
        Me.btn_product.TabIndex = 6
        Me.btn_product.Text = "Product"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'frm_mainmenu_a187795
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 600)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_lists)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_customer)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_mainmenu_a187795"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_customer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_lists As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_product As Button
End Class
