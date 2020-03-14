Public Class Italy1
    Private Sub Italy1confirm_Click(sender As Object, e As EventArgs) Handles Italy1confirm.Click
        Me.Hide()
        Italy2.Show()
    End Sub

    Private Sub Italy1A_Click(sender As Object, e As EventArgs) Handles Italy1A.Click
        Dim Italy1A As Boolean = False
        Me.Italy1A.BackColor = Color.DarkSeaGreen
        Italy1A = True
    End Sub

    Private Sub Italy1B_Click(sender As Object, e As EventArgs) Handles Italy1B.Click
        Dim Italy1A As Boolean = False, Italy1B As Boolean = False,
            Italy1C As Boolean = False, Italy1D As Boolean = False

        If Not Italy1B Then
            Me.Italy1B.BackColor = Color.IndianRed
            Italy1B = True
            Me.Italy1D.BackColor = Color.IndianRed
            Italy1D = True
        End If
        If Not Italy1A Then
            Me.Italy1A.BackColor = Color.DarkSeaGreen
            Italy1A = True
            Me.Italy1C.BackColor = Color.DarkSeaGreen
            Italy1C = True
        End If
    End Sub

    Private Sub Italy1C_Click(sender As Object, e As EventArgs) Handles Italy1C.Click
        Dim Italy1C As Boolean = False
        Me.Italy1C.BackColor = Color.DarkSeaGreen
        Italy1C = True
    End Sub

    Private Sub Italy1D_Click(sender As Object, e As EventArgs) Handles Italy1D.Click
        Dim Italy1A As Boolean = False, Italy1B As Boolean = False,
            Italy1C As Boolean = False, Italy1D As Boolean = False

        If Not Italy1D Then
            Me.Italy1D.BackColor = Color.IndianRed
            Italy1D = True
            Me.Italy1B.BackColor = Color.IndianRed
            Italy1B = True
        End If
        If Not Italy1A Then
            Me.Italy1A.BackColor = Color.DarkSeaGreen
            Italy1A = True
            Me.Italy1C.BackColor = Color.DarkSeaGreen
            Italy1C = True
        End If
    End Sub
End Class