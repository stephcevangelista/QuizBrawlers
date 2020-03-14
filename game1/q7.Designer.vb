<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class q7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q7))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mcu2confirm = New System.Windows.Forms.Button()
        Me.mcu2D = New System.Windows.Forms.Button()
        Me.mcu2B = New System.Windows.Forms.Button()
        Me.mcu2C = New System.Windows.Forms.Button()
        Me.mcu2A = New System.Windows.Forms.Button()
        Me.mcu2avatar = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.mcu2avatar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.mcu2confirm)
        Me.Panel1.Controls.Add(Me.mcu2D)
        Me.Panel1.Controls.Add(Me.mcu2B)
        Me.Panel1.Controls.Add(Me.mcu2C)
        Me.Panel1.Controls.Add(Me.mcu2A)
        Me.Panel1.Controls.Add(Me.mcu2avatar)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(36, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 460)
        Me.Panel1.TabIndex = 0
        '
        'mcu2confirm
        '
        Me.mcu2confirm.BackColor = System.Drawing.Color.White
        Me.mcu2confirm.BackgroundImage = Global.game1.My.Resources.Resources.confirm
        Me.mcu2confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mcu2confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu2confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu2confirm.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu2confirm.ForeColor = System.Drawing.Color.Black
        Me.mcu2confirm.Location = New System.Drawing.Point(688, 359)
        Me.mcu2confirm.Name = "mcu2confirm"
        Me.mcu2confirm.Size = New System.Drawing.Size(70, 70)
        Me.mcu2confirm.TabIndex = 6
        Me.mcu2confirm.UseVisualStyleBackColor = False
        '
        'mcu2D
        '
        Me.mcu2D.BackColor = System.Drawing.Color.White
        Me.mcu2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu2D.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu2D.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu2D.ForeColor = System.Drawing.Color.Black
        Me.mcu2D.Location = New System.Drawing.Point(397, 273)
        Me.mcu2D.Name = "mcu2D"
        Me.mcu2D.Size = New System.Drawing.Size(360, 60)
        Me.mcu2D.TabIndex = 5
        Me.mcu2D.Text = "Nick Fury"
        Me.mcu2D.UseVisualStyleBackColor = False
        '
        'mcu2B
        '
        Me.mcu2B.BackColor = System.Drawing.Color.White
        Me.mcu2B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu2B.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu2B.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu2B.ForeColor = System.Drawing.Color.Black
        Me.mcu2B.Location = New System.Drawing.Point(31, 273)
        Me.mcu2B.Name = "mcu2B"
        Me.mcu2B.Size = New System.Drawing.Size(360, 60)
        Me.mcu2B.TabIndex = 4
        Me.mcu2B.Text = "Scarlet Witch"
        Me.mcu2B.UseVisualStyleBackColor = False
        '
        'mcu2C
        '
        Me.mcu2C.BackColor = System.Drawing.Color.White
        Me.mcu2C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu2C.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu2C.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu2C.ForeColor = System.Drawing.Color.Black
        Me.mcu2C.Location = New System.Drawing.Point(398, 207)
        Me.mcu2C.Name = "mcu2C"
        Me.mcu2C.Size = New System.Drawing.Size(360, 60)
        Me.mcu2C.TabIndex = 3
        Me.mcu2C.Text = "Iron Man"
        Me.mcu2C.UseVisualStyleBackColor = False
        '
        'mcu2A
        '
        Me.mcu2A.BackColor = System.Drawing.Color.White
        Me.mcu2A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcu2A.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mcu2A.Font = New System.Drawing.Font("Arca Majora 3 Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcu2A.ForeColor = System.Drawing.Color.Black
        Me.mcu2A.Location = New System.Drawing.Point(32, 207)
        Me.mcu2A.Name = "mcu2A"
        Me.mcu2A.Size = New System.Drawing.Size(360, 60)
        Me.mcu2A.TabIndex = 2
        Me.mcu2A.Text = "Captain America"
        Me.mcu2A.UseVisualStyleBackColor = False
        '
        'mcu2avatar
        '
        Me.mcu2avatar.BackColor = System.Drawing.Color.Transparent
        Me.mcu2avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mcu2avatar.Image = Global.game1.My.Resources.Resources.batman
        Me.mcu2avatar.Location = New System.Drawing.Point(32, 339)
        Me.mcu2avatar.Name = "mcu2avatar"
        Me.mcu2avatar.Size = New System.Drawing.Size(90, 90)
        Me.mcu2avatar.TabIndex = 1
        Me.mcu2avatar.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arca Majora 3 Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(32, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(725, 170)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "In the first Avengers movie, The Avengers, premiered last 2012, who were the supe" &
    "rheroes that appeared?"
        '
        'q7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arca Majora 3 Bold", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "q7"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.mcu2avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mcu2confirm As Button
    Friend WithEvents mcu2D As Button
    Friend WithEvents mcu2B As Button
    Friend WithEvents mcu2C As Button
    Friend WithEvents mcu2A As Button
    Friend WithEvents mcu2avatar As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
