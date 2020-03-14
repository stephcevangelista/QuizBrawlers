Public Class Nether3
    Private Sub Nether3confirm_Click(sender As Object, e As EventArgs) Handles Nether3confirm.Click
        Me.Hide()
        Nether4.Show()
    End Sub

    Private Sub Nether3A_Click(sender As Object, e As EventArgs) Handles Nether3A.Click
        Dim Nether3A As Boolean = False, Nether3B As Boolean = False,
            Nether3C As Boolean = False, Nether3D As Boolean = False

        If Not Nether3A Then
            Me.Nether3A.BackColor = Color.IndianRed
            Nether3A = True
            Me.Nether3B.BackColor = Color.IndianRed
            Nether3B = True
        End If
        If Not Nether3C Then
            Me.Nether3C.BackColor = Color.DarkSeaGreen
            Nether3C = True
            Me.Nether3D.BackColor = Color.DarkSeaGreen
            Nether3D = True
        End If
    End Sub

    Private Sub Nether3B_Click(sender As Object, e As EventArgs) Handles Nether3B.Click
        Dim Nether3A As Boolean = False, Nether3B As Boolean = False,
           Nether3C As Boolean = False, Nether3D As Boolean = False

        If Not Nether3B Then
            Me.Nether3B.BackColor = Color.IndianRed
            Nether3B = True
            Me.Nether3A.BackColor = Color.IndianRed
            Nether3A = True
        End If
        If Not Nether3C Then
            Me.Nether3C.BackColor = Color.DarkSeaGreen
            Nether3C = True
            Me.Nether3D.BackColor = Color.DarkSeaGreen
            Nether3D = True
        End If
    End Sub

    Private Sub Nether3C_Click(sender As Object, e As EventArgs) Handles Nether3C.Click
        Dim Nether3C As Boolean = False
        Me.Nether3C.BackColor = Color.DarkSeaGreen
        Nether3C = True
    End Sub

    Private Sub Nether3D_Click(sender As Object, e As EventArgs) Handles Nether3D.Click
        Dim Nether3D As Boolean = False
        Me.Nether3D.BackColor = Color.DarkSeaGreen
        Nether3D = True
    End Sub
End Class