<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pop10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pop10))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pop10confirm = New System.Windows.Forms.Button()
        Me.Pop10avatar = New System.Windows.Forms.PictureBox()
        Me.Pop10D = New System.Windows.Forms.Button()
        Me.Pop10C = New System.Windows.Forms.Button()
        Me.Pop10B = New System.Windows.Forms.Button()
        Me.Pop10A = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pop10avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.questionsCountries.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BackgroundImage = Global.questionsCountries.My.Resources.Resources.unnamed
        Me.Panel1.Controls.Add(Me.Pop10confirm)
        Me.Panel1.Controls.Add(Me.Pop10avatar)
        Me.Panel1.Controls.Add(Me.Pop10D)
        Me.Panel1.Controls.Add(Me.Pop10C)
        Me.Panel1.Controls.Add(Me.Pop10B)
        Me.Panel1.Controls.Add(Me.Pop10A)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Pop10confirm
        '
        Me.Pop10confirm.BackColor = System.Drawing.Color.White
        Me.Pop10confirm.BackgroundImage = Global.questionsCountries.My.Resources.Resources.confirm
        resources.ApplyResources(Me.Pop10confirm, "Pop10confirm")
        Me.Pop10confirm.ForeColor = System.Drawing.Color.Black
        Me.Pop10confirm.Name = "Pop10confirm"
        Me.Pop10confirm.UseVisualStyleBackColor = False
        '
        'Pop10avatar
        '
        Me.Pop10avatar.BackColor = System.Drawing.Color.Transparent
        Me.Pop10avatar.BackgroundImage = Global.questionsCountries.My.Resources.Resources._063_batman
        resources.ApplyResources(Me.Pop10avatar, "Pop10avatar")
        Me.Pop10avatar.Name = "Pop10avatar"
        Me.Pop10avatar.TabStop = False
        '
        'Pop10D
        '
        Me.Pop10D.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Pop10D, "Pop10D")
        Me.Pop10D.ForeColor = System.Drawing.Color.Black
        Me.Pop10D.Name = "Pop10D"
        Me.Pop10D.UseVisualStyleBackColor = False
        '
        'Pop10C
        '
        Me.Pop10C.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Pop10C, "Pop10C")
        Me.Pop10C.ForeColor = System.Drawing.Color.Black
        Me.Pop10C.Name = "Pop10C"
        Me.Pop10C.UseVisualStyleBackColor = False
        '
        'Pop10B
        '
        Me.Pop10B.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Pop10B, "Pop10B")
        Me.Pop10B.ForeColor = System.Drawing.Color.Black
        Me.Pop10B.Name = "Pop10B"
        Me.Pop10B.UseVisualStyleBackColor = False
        '
        'Pop10A
        '
        Me.Pop10A.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Pop10A, "Pop10A")
        Me.Pop10A.ForeColor = System.Drawing.Color.Black
        Me.Pop10A.Name = "Pop10A"
        Me.Pop10A.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        '
        'Pop10
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.questionsCountries.My.Resources.Resources._118_1183591_cool_modern_wallpapers_full_hd_wall_blue_modern
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pop10"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pop10avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Pop10confirm As Button
    Friend WithEvents Pop10avatar As PictureBox
    Friend WithEvents Pop10D As Button
    Friend WithEvents Pop10C As Button
    Friend WithEvents Pop10B As Button
    Friend WithEvents Pop10A As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
