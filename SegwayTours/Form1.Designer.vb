<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmb_tour = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tickets = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_dicount = New System.Windows.Forms.ListBox()
        Me.btn_compute = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_tour
        '
        Me.cmb_tour.FormattingEnabled = True
        Me.cmb_tour.Location = New System.Drawing.Point(249, 107)
        Me.cmb_tour.Name = "cmb_tour"
        Me.cmb_tour.Size = New System.Drawing.Size(194, 21)
        Me.cmb_tour.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Type of Tour:"
        '
        'txt_tickets
        '
        Me.txt_tickets.Location = New System.Drawing.Point(173, 160)
        Me.txt_tickets.Name = "txt_tickets"
        Me.txt_tickets.Size = New System.Drawing.Size(100, 20)
        Me.txt_tickets.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Tickets:"
        '
        'lb_dicount
        '
        Me.lb_dicount.FormattingEnabled = True
        Me.lb_dicount.Items.AddRange(New Object() {"Military Discount (10%)", "Student Discount (20%)", "Senior Citizen Discount (25%)"})
        Me.lb_dicount.Location = New System.Drawing.Point(173, 213)
        Me.lb_dicount.Name = "lb_dicount"
        Me.lb_dicount.Size = New System.Drawing.Size(160, 43)
        Me.lb_dicount.TabIndex = 4
        '
        'btn_compute
        '
        Me.btn_compute.Location = New System.Drawing.Point(109, 311)
        Me.btn_compute.Name = "btn_compute"
        Me.btn_compute.Size = New System.Drawing.Size(75, 23)
        Me.btn_compute.TabIndex = 5
        Me.btn_compute.Text = "Compute"
        Me.btn_compute.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Clear Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Discount Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Segway Tour Tickets"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(184, 280)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(105, 13)
        Me.lbl_total.TabIndex = 9
        Me.lbl_total.Text = "Your final tour cost is"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 144)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 356)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_compute)
        Me.Controls.Add(Me.lb_dicount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_tickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tour)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_tour As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_tickets As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_dicount As ListBox
    Friend WithEvents btn_compute As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
