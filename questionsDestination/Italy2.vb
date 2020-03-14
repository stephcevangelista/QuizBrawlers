Public Class Italy2
    Private Sub Italy2confirm_Click(sender As Object, e As EventArgs) Handles Italy2confirm.Click
        Me.Hide()
        Italy3.Show()
    End Sub

    Private Sub Italy2A_Click(sender As Object, e As EventArgs) Handles Italy2A.Click
        Dim Italy2A As Boolean = False, Italy2B As Boolean = False,
            Italy2C As Boolean = False, Italy2D As Boolean = False

        If Not Italy2A Then
            Me.Italy2A.BackColor = Color.IndianRed
            Italy2A = True
            Me.Italy2C.BackColor = Color.IndianRed
            Italy2C = True
        End If
        If Not Italy2B Then
            Me.Italy2B.BackColor = Color.DarkSeaGreen
            Italy2B = True
            Me.Italy2D.BackColor = Color.DarkSeaGreen
            Italy2D = True
        End If
    End Sub

    Private Sub Italy2B_Click(sender As Object, e As EventArgs) Handles Italy2B.Click
        Dim Italy2B As Boolean = False
        Me.Italy2B.BackColor = Color.DarkSeaGreen
        Italy2B = True
    End Sub

    Private Sub Italy2C_Click(sender As Object, e As EventArgs) Handles Italy2C.Click
        Dim Italy2A As Boolean = False, Italy2B As Boolean = False,
            Italy2C As Boolean = False, Italy2D As Boolean = False

        If Not Italy2C Then
            Me.Italy2C.BackColor = Color.IndianRed
            Italy2C = True
            Me.Italy2A.BackColor = Color.IndianRed
            Italy2A = True
        End If
        If Not Italy2B Then
            Me.Italy2B.BackColor = Color.DarkSeaGreen
            Italy2B = True
            Me.Italy2D.BackColor = Color.DarkSeaGreen
            Italy2D = True
        End If
    End Sub

    Private Sub Italy2D_Click(sender As Object, e As EventArgs) Handles Italy2D.Click
        Dim Italy2D As Boolean = False
        Me.Italy2D.BackColor = Color.DarkSeaGreen
        Italy2D = True
    End Sub
End Class