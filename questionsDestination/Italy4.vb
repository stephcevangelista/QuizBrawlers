Public Class Italy4
    Private Sub Italy4confirm_Click(sender As Object, e As EventArgs) Handles Italy4confirm.Click
        Me.Hide()
        Italy5.Show()
    End Sub

    Private Sub Italy4A_Click(sender As Object, e As EventArgs) Handles Italy4A.Click
        Dim Italy4A As Boolean = False
        Me.Italy4A.BackColor = Color.DarkSeaGreen
        Italy4A = True
    End Sub

    Private Sub Italy4B_Click(sender As Object, e As EventArgs) Handles Italy4B.Click
        Dim Italy4A As Boolean = False, Italy4B As Boolean = False,
            Italy4C As Boolean = False, Italy4D As Boolean = False

        If Not Italy4B Then
            Me.Italy4B.BackColor = Color.IndianRed
            Italy4B = True
            Me.Italy4C.BackColor = Color.IndianRed
            Italy4C = True
        End If
        If Not Italy4A Then
            Me.Italy4A.BackColor = Color.DarkSeaGreen
            Italy4A = True
            Me.Italy4D.BackColor = Color.DarkSeaGreen
            Italy4D = True
        End If
    End Sub

    Private Sub Italy4C_Click(sender As Object, e As EventArgs) Handles Italy4C.Click
        Dim Italy4A As Boolean = False, Italy4B As Boolean = False,
          Italy4C As Boolean = False, Italy4D As Boolean = False

        If Not Italy4C Then
            Me.Italy4C.BackColor = Color.IndianRed
            Italy4C = True
            Me.Italy4B.BackColor = Color.IndianRed
            Italy4B = True
        End If
        If Not Italy4A Then
            Me.Italy4A.BackColor = Color.DarkSeaGreen
            Italy4A = True
            Me.Italy4D.BackColor = Color.DarkSeaGreen
            Italy4D = True
        End If
    End Sub

    Private Sub Italy4D_Click(sender As Object, e As EventArgs) Handles Italy4D.Click
        Dim Italy4D As Boolean = False
        Me.Italy4D.BackColor = Color.DarkSeaGreen
        Italy4D = True
    End Sub
End Class