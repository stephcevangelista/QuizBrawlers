<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.player1score = New System.Windows.Forms.RichTextBox()
        Me.homebutton = New System.Windows.Forms.Button()
        Me.player2scorestatus = New System.Windows.Forms.PictureBox()
        Me.player2score = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.player1scorestatus = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.player2scorestatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player1scorestatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.player1score)
        Me.GroupBox1.Controls.Add(Me.homebutton)
        Me.GroupBox1.Controls.Add(Me.player2scorestatus)
        Me.GroupBox1.Controls.Add(Me.player2score)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.player1scorestatus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(860, 647)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SCORES"
        '
        'player1score
        '
        Me.player1score.BackColor = System.Drawing.Color.White
        Me.player1score.Font = New System.Drawing.Font("Arca Majora 3 Bold", 39.7!, System.Drawing.FontStyle.Bold)
        Me.player1score.Location = New System.Drawing.Point(285, 505)
        Me.player1score.Name = "player1score"
        Me.player1score.ReadOnly = True
        Me.player1score.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.player1score.Size = New System.Drawing.Size(94, 73)
        Me.player1score.TabIndex = 9
        Me.player1score.Text = "5"
        '
        'homebutton
        '
        Me.homebutton.BackColor = System.Drawing.Color.White
        Me.homebutton.BackgroundImage = Global.game1.My.Resources.Resources.home
        Me.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homebutton.Location = New System.Drawing.Point(392, 505)
        Me.homebutton.Name = "homebutton"
        Me.homebutton.Size = New System.Drawing.Size(80, 75)
        Me.homebutton.TabIndex = 8
        Me.homebutton.UseVisualStyleBackColor = False
        '
        'player2scorestatus
        '
        Me.player2scorestatus.BackColor = System.Drawing.Color.Transparent
        Me.player2scorestatus.BackgroundImage = Global.game1.My.Resources.Resources.LOSER
        Me.player2scorestatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player2scorestatus.Location = New System.Drawing.Point(602, 516)
        Me.player2scorestatus.Name = "player2scorestatus"
        Me.player2scorestatus.Size = New System.Drawing.Size(183, 62)
        Me.player2scorestatus.TabIndex = 7
        Me.player2scorestatus.TabStop = False
        '
        'player2score
        '
        Me.player2score.BackColor = System.Drawing.Color.White
        Me.player2score.Font = New System.Drawing.Font("Arca Majora 3 Bold", 39.7!, System.Drawing.FontStyle.Bold)
        Me.player2score.Location = New System.Drawing.Point(485, 505)
        Me.player2score.Name = "player2score"
        Me.player2score.ReadOnly = True
        Me.player2score.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.player2score.Size = New System.Drawing.Size(94, 73)
        Me.player2score.TabIndex = 6
        Me.player2score.Text = "4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(485, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 315)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = Global.game1.My.Resources.Resources._064_superman
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(41, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(229, 231)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Games", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(505, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 61)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PLAYER 2"
        '
        'player1scorestatus
        '
        Me.player1scorestatus.BackColor = System.Drawing.Color.Transparent
        Me.player1scorestatus.BackgroundImage = Global.game1.My.Resources.Resources.WINNER
        Me.player1scorestatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player1scorestatus.Location = New System.Drawing.Point(82, 516)
        Me.player1scorestatus.Name = "player1scorestatus"
        Me.player1scorestatus.Size = New System.Drawing.Size(183, 62)
        Me.player1scorestatus.TabIndex = 3
        Me.player1scorestatus.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Games", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(107, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PLAYER 1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(79, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 315)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.game1.My.Resources.Resources._063_batman
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(35, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 231)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "scores"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.player2scorestatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player1scorestatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents player1scorestatus As PictureBox
    Friend WithEvents player2scorestatus As PictureBox
    Friend WithEvents player2score As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents homebutton As Button
    Friend WithEvents player1score As RichTextBox
End Class
