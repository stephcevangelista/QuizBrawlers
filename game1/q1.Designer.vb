<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class q1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pop2confirm = New System.Windows.Forms.Button()
        Me.Pop2avatar = New System.Windows.Forms.PictureBox()
        Me.Pop2D = New System.Windows.Forms.Button()
        Me.Pop2C = New System.Windows.Forms.Button()
        Me.Pop2B = New System.Windows.Forms.Button()
        Me.Pop2A = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pop2avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, -2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 651)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUESTIONS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.game1.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.Pop2confirm)
        Me.Panel1.Controls.Add(Me.Pop2avatar)
        Me.Panel1.Controls.Add(Me.Pop2D)
        Me.Panel1.Controls.Add(Me.Pop2C)
        Me.Panel1.Controls.Add(Me.Pop2B)
        Me.Panel1.Controls.Add(Me.Pop2A)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(35, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 460)
        Me.Panel1.TabIndex = 0
        '
        'Pop2confirm
        '
        Me.Pop2confirm.BackColor = System.Drawing.Color.White
        Me.Pop2confirm.BackgroundImage = Global.game1.My.Resources.Resources.confirm
        Me.Pop2confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pop2confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pop2confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Pop2confirm.ForeColor = System.Drawing.Color.Black
        Me.Pop2confirm.Location = New System.Drawing.Point(690, 364)
        Me.Pop2confirm.Name = "Pop2confirm"
        Me.Pop2confirm.Size = New System.Drawing.Size(70, 70)
        Me.Pop2confirm.TabIndex = 6
        Me.Pop2confirm.UseVisualStyleBackColor = False
        '
        'Pop2avatar
        '
        Me.Pop2avatar.BackColor = System.Drawing.Color.Transparent
        Me.Pop2avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pop2avatar.Image = Global.game1.My.Resources.Resources.batman
        Me.Pop2avatar.Location = New System.Drawing.Point(35, 344)
        Me.Pop2avatar.Name = "Pop2avatar"
        Me.Pop2avatar.Size = New System.Drawing.Size(90, 90)
        Me.Pop2avatar.TabIndex = 5
        Me.Pop2avatar.TabStop = False
        '
        'Pop2D
        '
        Me.Pop2D.BackColor = System.Drawing.Color.White
        Me.Pop2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pop2D.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Pop2D.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pop2D.ForeColor = System.Drawing.Color.Black
        Me.Pop2D.Location = New System.Drawing.Point(400, 278)
        Me.Pop2D.Name = "Pop2D"
        Me.Pop2D.Size = New System.Drawing.Size(360, 60)
        Me.Pop2D.TabIndex = 4
        Me.Pop2D.Text = "Ferdinand Marcos"
        Me.Pop2D.UseVisualStyleBackColor = False
        '
        'Pop2C
        '
        Me.Pop2C.BackColor = System.Drawing.Color.White
        Me.Pop2C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pop2C.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Pop2C.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pop2C.ForeColor = System.Drawing.Color.Black
        Me.Pop2C.Location = New System.Drawing.Point(35, 278)
        Me.Pop2C.Name = "Pop2C"
        Me.Pop2C.Size = New System.Drawing.Size(360, 60)
        Me.Pop2C.TabIndex = 3
        Me.Pop2C.Text = "Fidel V.Ramos "
        Me.Pop2C.UseVisualStyleBackColor = False
        '
        'Pop2B
        '
        Me.Pop2B.BackColor = System.Drawing.Color.White
        Me.Pop2B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pop2B.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Pop2B.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pop2B.ForeColor = System.Drawing.Color.Black
        Me.Pop2B.Location = New System.Drawing.Point(400, 212)
        Me.Pop2B.Name = "Pop2B"
        Me.Pop2B.Size = New System.Drawing.Size(360, 60)
        Me.Pop2B.TabIndex = 2
        Me.Pop2B.Text = "Sergio Osmena Sr. "
        Me.Pop2B.UseVisualStyleBackColor = False
        '
        'Pop2A
        '
        Me.Pop2A.BackColor = System.Drawing.Color.White
        Me.Pop2A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pop2A.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Pop2A.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pop2A.ForeColor = System.Drawing.Color.Black
        Me.Pop2A.Location = New System.Drawing.Point(35, 212)
        Me.Pop2A.Name = "Pop2A"
        Me.Pop2A.Size = New System.Drawing.Size(360, 60)
        Me.Pop2A.TabIndex = 1
        Me.Pop2A.Text = "Jose P.Laurel"
        Me.Pop2A.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arca Majora 3 Bold", 29.95!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.Location = New System.Drawing.Point(35, 36)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(725, 170)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Which are the 2 oldest presidents of the Philippines?"
        '
        'q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "q1"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pop2avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Pop2confirm As Button
    Friend WithEvents Pop2avatar As PictureBox
    Friend WithEvents Pop2D As Button
    Friend WithEvents Pop2C As Button
    Friend WithEvents Pop2B As Button
    Friend WithEvents Pop2A As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
