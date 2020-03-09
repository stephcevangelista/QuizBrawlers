<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pageAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pageAbout))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.aboutPrev = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.aboutPrev)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 637)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ABOUT"
        '
        'aboutPrev
        '
        Me.aboutPrev.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.Picture4
        Me.aboutPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.aboutPrev.Location = New System.Drawing.Point(747, 540)
        Me.aboutPrev.Name = "aboutPrev"
        Me.aboutPrev.Size = New System.Drawing.Size(80, 80)
        Me.aboutPrev.TabIndex = 1
        Me.aboutPrev.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(33, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 405)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arca Majora 3 Heavy", 30.0!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.Location = New System.Drawing.Point(44, 45)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(703, 321)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Quiz Brawlers is a form of game or mind sport, in which the players attempt to an" &
    "swer questions correctly. It is a game to test the knowledge about a certain sub" &
    "ject. "
        '
        'pageAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pageAbout"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents aboutPrev As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
