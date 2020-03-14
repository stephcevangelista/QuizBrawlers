Public Class Italy5
    Private Sub Italy5confirm_Click(sender As Object, e As EventArgs) Handles Italy5confirm.Click
        Me.Hide()
        Nether1.Show()
    End Sub

    Private Sub Italy5A_Click(sender As Object, e As EventArgs) Handles Italy5A.Click
        Dim Italy5A As Boolean = False
        Me.Italy5A.BackColor = Color.DarkSeaGreen
        Italy5A = True
    End Sub

    Private Sub Italy5B_Click(sender As Object, e As EventArgs) Handles Italy5B.Click
        Dim Italy5A As Boolean = False, Italy5B As Boolean = False,
            Italy5C As Boolean = False, Italy5D As Boolean = False

        If Not Italy5B Then
            Me.Italy5B.BackColor = Color.IndianRed
            Italy5B = True
            Me.Italy5D.BackColor = Color.IndianRed
            Italy5D = True
        End If
        If Not Italy5A Then
            Me.Italy5A.BackColor = Color.DarkSeaGreen
            Italy5A = True
            Me.Italy5C.BackColor = Color.DarkSeaGreen
            Italy5C = True
        End If
    End Sub

    Private Sub Italy5C_Click(sender As Object, e As EventArgs) Handles Italy5C.Click
        Dim Italy5C As Boolean = False
        Me.Italy5C.BackColor = Color.DarkSeaGreen
        Italy5C = True
    End Sub

    Private Sub Italy5D_Click(sender As Object, e As EventArgs) Handles Italy5D.Click
        Dim Italy5A As Boolean = False, Italy5B As Boolean = False,
           Italy5C As Boolean = False, Italy5D As Boolean = False

        If Not Italy5D Then
            Me.Italy5D.BackColor = Color.IndianRed
            Italy5D = True
            Me.Italy5B.BackColor = Color.IndianRed
            Italy5B = True
        End If
        If Not Italy5A Then
            Me.Italy5A.BackColor = Color.DarkSeaGreen
            Italy5A = True
            Me.Italy5C.BackColor = Color.DarkSeaGreen
            Italy5C = True
        End If
    End Sub
End Class