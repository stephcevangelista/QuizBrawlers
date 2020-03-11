<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pageHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pageHome))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.homeQuit = New System.Windows.Forms.Button()
        Me.homeExtras = New System.Windows.Forms.Button()
        Me.homeHow2Play = New System.Windows.Forms.Button()
        Me.homeAbout = New System.Windows.Forms.Button()
        Me.homePlay = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.homeQuit)
        Me.GroupBox1.Controls.Add(Me.homeExtras)
        Me.GroupBox1.Controls.Add(Me.homeHow2Play)
        Me.GroupBox1.Controls.Add(Me.homeAbout)
        Me.GroupBox1.Controls.Add(Me.homePlay)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(857, 632)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUIZ BRAWLERS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.Picture1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 498)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'homeQuit
        '
        Me.homeQuit.BackColor = System.Drawing.Color.White
        Me.homeQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeQuit.Font = New System.Drawing.Font("Games", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeQuit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.homeQuit.Location = New System.Drawing.Point(503, 499)
        Me.homeQuit.Name = "homeQuit"
        Me.homeQuit.Size = New System.Drawing.Size(305, 77)
        Me.homeQuit.TabIndex = 4
        Me.homeQuit.Text = "QUIT"
        Me.homeQuit.UseVisualStyleBackColor = False
        '
        'homeExtras
        '
        Me.homeExtras.BackColor = System.Drawing.Color.White
        Me.homeExtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeExtras.Font = New System.Drawing.Font("Games", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeExtras.ForeColor = System.Drawing.Color.MidnightBlue
        Me.homeExtras.Location = New System.Drawing.Point(503, 416)
        Me.homeExtras.Name = "homeExtras"
        Me.homeExtras.Size = New System.Drawing.Size(305, 77)
        Me.homeExtras.TabIndex = 3
        Me.homeExtras.Text = "EXTRAS"
        Me.homeExtras.UseVisualStyleBackColor = False
        '
        'homeHow2Play
        '
        Me.homeHow2Play.BackColor = System.Drawing.Color.White
        Me.homeHow2Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeHow2Play.Font = New System.Drawing.Font("Games", 30.0!)
        Me.homeHow2Play.ForeColor = System.Drawing.Color.MidnightBlue
        Me.homeHow2Play.Location = New System.Drawing.Point(503, 333)
        Me.homeHow2Play.Name = "homeHow2Play"
        Me.homeHow2Play.Size = New System.Drawing.Size(305, 77)
        Me.homeHow2Play.TabIndex = 2
        Me.homeHow2Play.Text = "HOW TO PLAY"
        Me.homeHow2Play.UseVisualStyleBackColor = False
        '
        'homeAbout
        '
        Me.homeAbout.BackColor = System.Drawing.Color.White
        Me.homeAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeAbout.Font = New System.Drawing.Font("Games", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeAbout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.homeAbout.Location = New System.Drawing.Point(503, 250)
        Me.homeAbout.Name = "homeAbout"
        Me.homeAbout.Size = New System.Drawing.Size(305, 77)
        Me.homeAbout.TabIndex = 1
        Me.homeAbout.Text = "ABOUT"
        Me.homeAbout.UseVisualStyleBackColor = False
        '
        'homePlay
        '
        Me.homePlay.BackColor = System.Drawing.Color.White
        Me.homePlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homePlay.Font = New System.Drawing.Font("Games", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homePlay.ForeColor = System.Drawing.Color.MidnightBlue
        Me.homePlay.Location = New System.Drawing.Point(503, 128)
        Me.homePlay.Name = "homePlay"
        Me.homePlay.Size = New System.Drawing.Size(305, 116)
        Me.homePlay.TabIndex = 0
        Me.homePlay.Text = "PLAY"
        Me.homePlay.UseVisualStyleBackColor = False
        '
        'pageHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pageHome"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents homeQuit As Button
    Friend WithEvents homeExtras As Button
    Friend WithEvents homeHow2Play As Button
    Friend WithEvents homeAbout As Button
    Friend WithEvents homePlay As Button
End Class
