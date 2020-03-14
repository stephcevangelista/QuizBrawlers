Public Class Italy3
    Private Sub Italy3confirm_Click(sender As Object, e As EventArgs) Handles Italy3confirm.Click
        Me.Hide()
        Italy4.Show()
    End Sub

    Private Sub Italy3A_Click(sender As Object, e As EventArgs) Handles Italy3A.Click
        Dim Italy3A As Boolean = False, Italy3B As Boolean = False,
            Italy3C As Boolean = False, Italy3D As Boolean = False

        If Not Italy3A Then
            Me.Italy3A.BackColor = Color.IndianRed
            Italy3A = True
            Me.Italy3B.BackColor = Color.IndianRed
            Italy3B = True
        End If
        If Not Italy3C Then
            Me.Italy3C.BackColor = Color.DarkSeaGreen
            Italy3C = True
            Me.Italy3D.BackColor = Color.DarkSeaGreen
            Italy3D = True
        End If
    End Sub

    Private Sub Italy3B_Click(sender As Object, e As EventArgs) Handles Italy3B.Click
        Dim Italy3A As Boolean = False, Italy3B As Boolean = False,
            Italy3C As Boolean = False, Italy3D As Boolean = False

        If Not Italy3B Then
            Me.Italy3B.BackColor = Color.IndianRed
            Italy3B = True
            Me.Italy3A.BackColor = Color.IndianRed
            Italy3A = True
        End If
        If Not Italy3C Then
            Me.Italy3C.BackColor = Color.DarkSeaGreen
            Italy3C = True
            Me.Italy3D.BackColor = Color.DarkSeaGreen
            Italy3D = True
        End If
    End Sub

    Private Sub Italy3C_Click(sender As Object, e As EventArgs) Handles Italy3C.Click
        Dim Italy3C As Boolean = False
        Me.Italy3C.BackColor = Color.DarkSeaGreen
        Italy3C = True
    End Sub

    Private Sub Italy3D_Click(sender As Object, e As EventArgs) Handles Italy3D.Click
        Dim Italy3D As Boolean = False
        Me.Italy3D.BackColor = Color.DarkSeaGreen
        Italy3D = True
    End Sub
End Class