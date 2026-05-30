<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_lists_a187795
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lists_a187795))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_lists = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_order = New System.Windows.Forms.ComboBox()
        Me.date_gen = New System.Windows.Forms.DateTimePicker()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.grd_lists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Lists"
        '
        'grd_lists
        '
        Me.grd_lists.AllowUserToAddRows = False
        Me.grd_lists.AllowUserToDeleteRows = False
        Me.grd_lists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_lists.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grd_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_lists.Location = New System.Drawing.Point(71, 176)
        Me.grd_lists.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_lists.Name = "grd_lists"
        Me.grd_lists.ReadOnly = True
        Me.grd_lists.RowHeadersWidth = 51
        Me.grd_lists.RowTemplate.Height = 24
        Me.grd_lists.Size = New System.Drawing.Size(642, 136)
        Me.grd_lists.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(11, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 37)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "ORDER ID:"
        '
        'cmb_order
        '
        Me.cmb_order.FormattingEnabled = True
        Me.cmb_order.Location = New System.Drawing.Point(336, 82)
        Me.cmb_order.Name = "cmb_order"
        Me.cmb_order.Size = New System.Drawing.Size(121, 21)
        Me.cmb_order.TabIndex = 86
        '
        'date_gen
        '
        Me.date_gen.CalendarForeColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTitleForeColor = System.Drawing.Color.Transparent
        Me.date_gen.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.date_gen.Dock = System.Windows.Forms.DockStyle.Right
        Me.date_gen.Location = New System.Drawing.Point(560, 0)
        Me.date_gen.Name = "date_gen"
        Me.date_gen.Size = New System.Drawing.Size(200, 20)
        Me.date_gen.TabIndex = 87
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(560, 351)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(105, 20)
        Me.txt_total.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(448, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Total (RM)"
        '
        'frm_lists_a187795
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 499)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.date_gen)
        Me.Controls.Add(Me.cmb_order)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grd_lists)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_lists_a187795"
        Me.Text = "Order Lists Form"
        CType(Me.grd_lists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_lists As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_order As ComboBox
    Friend WithEvents date_gen As DateTimePicker
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label13 As Label
End Class
