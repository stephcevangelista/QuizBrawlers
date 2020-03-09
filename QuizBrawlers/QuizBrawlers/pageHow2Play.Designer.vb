<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pageHow2Play
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pageHow2Play))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.how2playprev = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.how2playprev)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Games", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 637)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HOW TO PLAY"
        '
        'how2playprev
        '
        Me.how2playprev.BackColor = System.Drawing.Color.White
        Me.how2playprev.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.Picture4
        Me.how2playprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.how2playprev.Location = New System.Drawing.Point(751, 532)
        Me.how2playprev.Name = "how2playprev"
        Me.how2playprev.Size = New System.Drawing.Size(80, 80)
        Me.how2playprev.TabIndex = 1
        Me.how2playprev.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(29, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 398)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arca Majora 3 Heavy", 29.95!, System.Drawing.FontStyle.Bold)
        Me.RichTextBox1.Location = New System.Drawing.Point(52, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(696, 308)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'pageHow2Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizBrawlers.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pageHow2Play"
        Me.Text = "QUIZ BRAWLERS"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents how2playprev As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
