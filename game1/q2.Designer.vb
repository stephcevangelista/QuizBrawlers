<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class q2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mcu4confirm = New System.Windows.Forms.Button()
        Me.mcu4D = New System.Windows.Forms.Button()
        Me.mcu4B = New System.Windows.Forms.Button()
        Me.mcu4C = New System.Windows.Forms.Button()
        Me.mcu4A = New System.Windows.Forms.Button()
        Me.mcu4avatar = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.mcu4avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 649)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUESTIONS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.game1.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.mcu4confirm)
        Me.Panel1.Controls.Add(Me.mcu4D)
        Me.Panel1.Controls.Add(Me.mcu4B)
        Me.Panel1.Controls.Add(Me.mcu4C)
        Me.Panel1.Controls.Add(Me.mcu4A)
        Me.Panel1.Controls.Add(Me.mcu4avatar)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(36, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 460)
        Me.Panel1.TabIndex = 0
        '
        'mcu4confirm
        '
        Me.mcu4confirm.BackColor = System.Drawing.Color.White
        Me.mcu4confirm.BackgroundImage = Global.game1.My.Resources.Resources.confirm
        Me.mcu4confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mcu4confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu4confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu4confirm.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu4confirm.ForeColor = System.Drawing.Color.Black
        Me.mcu4confirm.Location = New System.Drawing.Point(688, 359)
        Me.mcu4confirm.Name = "mcu4confirm"
        Me.mcu4confirm.Size = New System.Drawing.Size(70, 70)
        Me.mcu4confirm.TabIndex = 6
        Me.mcu4confirm.UseVisualStyleBackColor = False
        '
        'mcu4D
        '
        Me.mcu4D.BackColor = System.Drawing.Color.White
        Me.mcu4D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu4D.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu4D.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu4D.ForeColor = System.Drawing.Color.Black
        Me.mcu4D.Location = New System.Drawing.Point(397, 273)
        Me.mcu4D.Name = "mcu4D"
        Me.mcu4D.Size = New System.Drawing.Size(360, 60)
        Me.mcu4D.TabIndex = 5
        Me.mcu4D.Text = "Black Panther"
        Me.mcu4D.UseVisualStyleBackColor = False
        '
        'mcu4B
        '
        Me.mcu4B.BackColor = System.Drawing.Color.White
        Me.mcu4B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu4B.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu4B.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu4B.ForeColor = System.Drawing.Color.Black
        Me.mcu4B.Location = New System.Drawing.Point(31, 273)
        Me.mcu4B.Name = "mcu4B"
        Me.mcu4B.Size = New System.Drawing.Size(360, 60)
        Me.mcu4B.TabIndex = 4
        Me.mcu4B.Text = "Spider-Man"
        Me.mcu4B.UseVisualStyleBackColor = False
        '
        'mcu4C
        '
        Me.mcu4C.BackColor = System.Drawing.Color.White
        Me.mcu4C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu4C.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu4C.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu4C.ForeColor = System.Drawing.Color.Black
        Me.mcu4C.Location = New System.Drawing.Point(398, 207)
        Me.mcu4C.Name = "mcu4C"
        Me.mcu4C.Size = New System.Drawing.Size(360, 60)
        Me.mcu4C.TabIndex = 3
        Me.mcu4C.Text = "Thanos"
        Me.mcu4C.UseVisualStyleBackColor = False
        '
        'mcu4A
        '
        Me.mcu4A.BackColor = System.Drawing.Color.White
        Me.mcu4A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu4A.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu4A.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu4A.ForeColor = System.Drawing.Color.Black
        Me.mcu4A.Location = New System.Drawing.Point(32, 207)
        Me.mcu4A.Name = "mcu4A"
        Me.mcu4A.Size = New System.Drawing.Size(360, 60)
        Me.mcu4A.TabIndex = 2
        Me.mcu4A.Text = "Scarlet Witch"
        Me.mcu4A.UseVisualStyleBackColor = False
        '
        'mcu4avatar
        '
        Me.mcu4avatar.BackColor = System.Drawing.Color.Transparent
        Me.mcu4avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mcu4avatar.Image = Global.game1.My.Resources.Resources.batman
        Me.mcu4avatar.Location = New System.Drawing.Point(32, 339)
        Me.mcu4avatar.Name = "mcu4avatar"
        Me.mcu4avatar.Size = New System.Drawing.Size(90, 90)
        Me.mcu4avatar.TabIndex = 1
        Me.mcu4avatar.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arca Majora 3 Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(32, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(725, 170)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "In the Avengers: Infinity War movie, who were the new heroes that appeared in The" &
    " Avengers movie?"
        '
        'q2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arca Majora 3 Bold", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "q2"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.mcu4avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mcu4confirm As Button
    Friend WithEvents mcu4D As Button
    Friend WithEvents mcu4B As Button
    Friend WithEvents mcu4C As Button
    Friend WithEvents mcu4A As Button
    Friend WithEvents mcu4avatar As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
