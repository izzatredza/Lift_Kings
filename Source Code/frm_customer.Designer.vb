<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_customer_a187795
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
        Me.customer_label = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.btn_mainmenu = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customer_label
        '
        Me.customer_label.AutoSize = True
        Me.customer_label.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_label.Location = New System.Drawing.Point(305, 49)
        Me.customer_label.Name = "customer_label"
        Me.customer_label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.customer_label.Size = New System.Drawing.Size(187, 43)
        Me.customer_label.TabIndex = 0
        Me.customer_label.Text = "Customer "
        '
        'grd_customer
        '
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(12, 105)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(776, 320)
        Me.grd_customer.TabIndex = 1
        '
        'btn_mainmenu
        '
        Me.btn_mainmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_mainmenu.Location = New System.Drawing.Point(23, 45)
        Me.btn_mainmenu.Name = "btn_mainmenu"
        Me.btn_mainmenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_mainmenu.Size = New System.Drawing.Size(119, 47)
        Me.btn_mainmenu.TabIndex = 2
        Me.btn_mainmenu.Text = "Main Menu"
        Me.btn_mainmenu.UseVisualStyleBackColor = True
        '
        'frm_customer_a187795
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(811, 464)
        Me.Controls.Add(Me.btn_mainmenu)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.customer_label)
        Me.Name = "frm_customer_a187795"
        Me.Text = "Customer Form"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customer_label As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents btn_mainmenu As Button
End Class
