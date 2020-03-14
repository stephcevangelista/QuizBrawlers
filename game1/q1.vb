Public Class q1
    Private Sub Pop2confirm_Click(sender As Object, e As EventArgs) Handles Pop2confirm.Click
        Me.Hide()
        q2.Show()
    End Sub

    'A: correct'
    Private Sub Pop2A_Click(sender As Object, e As EventArgs) Handles Pop2A.Click
        Dim Pop2A As Boolean = False
        Me.Pop2A.BackColor = Color.DarkSeaGreen
        Pop2A = True
        Pop2avatar.Image = Image.FromFile("C:\Users\Steph\Downloads\superman.png")

    End Sub

    'B: correct'
    Private Sub Pop2B_Click(sender As Object, e As EventArgs) Handles Pop2B.Click
        Dim Pop2B As Boolean = False
        Me.Pop2B.BackColor = Color.DarkSeaGreen
        Pop2B = True
        Pop2avatar.Image = Image.FromFile("C:\Users\Steph\Downloads\superman.png")
    End Sub

    'C: wrong'
    Private Sub Pop2C_Click(sender As Object, e As EventArgs) Handles Pop2C.Click
        Dim Pop2A As Boolean = False, Pop2B As Boolean = False,
           Pop2C As Boolean = False, Pop2D As Boolean = False

        If Not Pop2A Then
            Me.Pop2C.BackColor = Color.IndianRed
            Pop2C = True
            Me.Pop2D.BackColor = Color.IndianRed
            Pop2D = True
        End If
        If Not Pop2B Then
            Me.Pop2A.BackColor = Color.DarkSeaGreen
            Pop2A = True
            Me.Pop2B.BackColor = Color.DarkSeaGreen
            Pop2B = True
        End If
        Pop2avatar.Image = Image.FromFile("C:\Users\Steph\Downloads\superman.png")
    End Sub

    'D: Wrong'
    Private Sub Pop2D_Click(sender As Object, e As EventArgs) Handles Pop2D.Click
        Dim Pop2A As Boolean = False, Pop2B As Boolean = False,
           Pop2C As Boolean = False, Pop2D As Boolean = False

        If Not Pop2A Then
            Me.Pop2C.BackColor = Color.IndianRed
            Pop2C = True
            Me.Pop2D.BackColor = Color.IndianRed
            Pop2D = True
        End If
        If Not Pop2B Then
            Me.Pop2A.BackColor = Color.DarkSeaGreen
            Pop2A = True
            Me.Pop2B.BackColor = Color.DarkSeaGreen
            Pop2B = True
        End If
        Pop2avatar.Image = Image.FromFile("C:\Users\Steph\Downloads\superman.png")
    End Sub

End Class