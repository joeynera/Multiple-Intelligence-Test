<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phase2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Phase2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.femalepanel = New System.Windows.Forms.Panel()
        Me.female = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.male = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_start = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.malepanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.femalepanel.SuspendLayout()
        CType(Me.female, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.male, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.malepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.femalepanel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.male)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_start)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.malepanel)
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 526)
        Me.Panel1.TabIndex = 0
        '
        'femalepanel
        '
        Me.femalepanel.BackColor = System.Drawing.Color.Magenta
        Me.femalepanel.Controls.Add(Me.female)
        Me.femalepanel.Controls.Add(Me.Panel4)
        Me.femalepanel.Location = New System.Drawing.Point(497, 89)
        Me.femalepanel.Name = "femalepanel"
        Me.femalepanel.Size = New System.Drawing.Size(180, 260)
        Me.femalepanel.TabIndex = 12
        '
        'female
        '
        Me.female.Image = CType(resources.GetObject("female.Image"), System.Drawing.Image)
        Me.female.Location = New System.Drawing.Point(10, 8)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(160, 239)
        Me.female.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.female.TabIndex = 9
        Me.female.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(170, 250)
        Me.Panel4.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Raleway", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(507, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 34)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Female"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Raleway", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 35)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Male"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'male
        '
        Me.male.Image = CType(resources.GetObject("male.Image"), System.Drawing.Image)
        Me.male.Location = New System.Drawing.Point(159, 97)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(160, 239)
        Me.male.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.male.TabIndex = 8
        Me.male.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 504)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(850, 8)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'lbl_start
        '
        Me.lbl_start.BackColor = System.Drawing.Color.Silver
        Me.lbl_start.Font = New System.Drawing.Font("aposiopesis normal", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_start.ForeColor = System.Drawing.Color.White
        Me.lbl_start.Location = New System.Drawing.Point(0, 435)
        Me.lbl_start.Name = "lbl_start"
        Me.lbl_start.Size = New System.Drawing.Size(879, 66)
        Me.lbl_start.TabIndex = 6
        Me.lbl_start.Text = "Start"
        Me.lbl_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(850, 8)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(876, 35)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose your Character"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'malepanel
        '
        Me.malepanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.malepanel.Controls.Add(Me.Panel5)
        Me.malepanel.Location = New System.Drawing.Point(150, 89)
        Me.malepanel.Name = "malepanel"
        Me.malepanel.Size = New System.Drawing.Size(180, 260)
        Me.malepanel.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 250)
        Me.Panel5.TabIndex = 15
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.White
        Me.btn_minimize.BackgroundImage = CType(resources.GetObject("btn_minimize.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.White
        Me.btn_minimize.Location = New System.Drawing.Point(836, 0)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(26, 23)
        Me.btn_minimize.TabIndex = 1
        Me.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.White
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(865, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(26, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "__"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Phase2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(905, 560)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(905, 560)
        Me.MinimumSize = New System.Drawing.Size(905, 560)
        Me.Name = "Phase2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.femalepanel.ResumeLayout(False)
        CType(Me.female, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.male, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.malepanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_start As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents male As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents female As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_minimize As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents femalepanel As System.Windows.Forms.Panel
    Friend WithEvents malepanel As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel

End Class
