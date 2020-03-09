<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagePlayLAN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pagePlayLAN))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playlanprev = New System.Windows.Forms.Button()
        Me.gameCreate = New System.Windows.Forms.Button()
        Me.gameJoin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gameStart = New System.Windows.Forms.Button()
        Me.Game1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.playlanprev)
        Me.GroupBox1.Controls.Add(Me.gameCreate)
        Me.GroupBox1.Controls.Add(Me.gameJoin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 651)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LAN GAMES"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.lanconnection
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(571, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 240)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'playlanprev
        '
        Me.playlanprev.BackColor = System.Drawing.Color.White
        Me.playlanprev.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.Picture4
        Me.playlanprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.playlanprev.Location = New System.Drawing.Point(732, 531)
        Me.playlanprev.Name = "playlanprev"
        Me.playlanprev.Size = New System.Drawing.Size(80, 80)
        Me.playlanprev.TabIndex = 4
        Me.playlanprev.UseVisualStyleBackColor = False
        '
        'gameCreate
        '
        Me.gameCreate.BackColor = System.Drawing.Color.White
        Me.gameCreate.Font = New System.Drawing.Font("Games", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameCreate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gameCreate.Location = New System.Drawing.Point(557, 427)
        Me.gameCreate.Name = "gameCreate"
        Me.gameCreate.Size = New System.Drawing.Size(255, 90)
        Me.gameCreate.TabIndex = 3
        Me.gameCreate.Text = "CREATE"
        Me.gameCreate.UseVisualStyleBackColor = False
        '
        'gameJoin
        '
        Me.gameJoin.BackColor = System.Drawing.Color.White
        Me.gameJoin.Font = New System.Drawing.Font("Games", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameJoin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gameJoin.Location = New System.Drawing.Point(557, 331)
        Me.gameJoin.Name = "gameJoin"
        Me.gameJoin.Size = New System.Drawing.Size(255, 90)
        Me.gameJoin.TabIndex = 2
        Me.gameJoin.Text = "JOIN"
        Me.gameJoin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Games", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(84, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GAME LOBBY"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.gameStart)
        Me.Panel1.Controls.Add(Me.Game1)
        Me.Panel1.Location = New System.Drawing.Point(51, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Panel1.TabIndex = 0
        '
        'gameStart
        '
        Me.gameStart.BackColor = System.Drawing.Color.White
        Me.gameStart.Font = New System.Drawing.Font("Games", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameStart.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gameStart.Location = New System.Drawing.Point(271, 388)
        Me.gameStart.Name = "gameStart"
        Me.gameStart.Size = New System.Drawing.Size(155, 50)
        Me.gameStart.TabIndex = 1
        Me.gameStart.Text = "START"
        Me.gameStart.UseVisualStyleBackColor = False
        '
        'Game1
        '
        Me.Game1.Enabled = False
        Me.Game1.Font = New System.Drawing.Font("Arca Majora 3 Heavy", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Game1.FormattingEnabled = True
        Me.Game1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Game1.ItemHeight = 40
        Me.Game1.Items.AddRange(New Object() {"Game 1 (1/2)"})
        Me.Game1.Location = New System.Drawing.Point(42, 68)
        Me.Game1.Name = "Game1"
        Me.Game1.ScrollAlwaysVisible = True
        Me.Game1.Size = New System.Drawing.Size(383, 284)
        Me.Game1.TabIndex = 0
        '
        'pagePlayLAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pagePlayLAN"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gameCreate As Button
    Friend WithEvents gameJoin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gameStart As Button
    Friend WithEvents Game1 As ListBox
    Friend WithEvents playlanprev As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
