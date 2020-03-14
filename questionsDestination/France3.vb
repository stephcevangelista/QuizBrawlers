Public Class France3
    Private Sub France3confirm_Click(sender As Object, e As EventArgs) Handles France3confirm.Click
        Me.Hide()
        France4.Show()
    End Sub

    Private Sub France3A_Click(sender As Object, e As EventArgs) Handles France3A.Click
        Dim France3A As Boolean = False, France3B As Boolean = False,
          France3C As Boolean = False, France3D As Boolean = False

        If Not France3A Then
            Me.France3A.BackColor = Color.IndianRed
            France3A = True
            Me.France3B.BackColor = Color.IndianRed
            France3B = True
        End If
        If Not France3C Then
            Me.France3C.BackColor = Color.DarkSeaGreen
            France3C = True
            Me.France3D.BackColor = Color.DarkSeaGreen
            France3D = True
        End If
    End Sub

    Private Sub France3B_Click(sender As Object, e As EventArgs) Handles France3B.Click
        Dim France3A As Boolean = False, France3B As Boolean = False,
            France3C As Boolean = False, France3D As Boolean = False

        If Not France3B Then
            Me.France3B.BackColor = Color.IndianRed
            France3B = True
            Me.France3A.BackColor = Color.IndianRed
            France3A = True
        End If
        If Not France3C Then
            Me.France3C.BackColor = Color.DarkSeaGreen
            France3C = True
            Me.France3D.BackColor = Color.DarkSeaGreen
            France3D = True
        End If
    End Sub

    Private Sub France3C_Click(sender As Object, e As EventArgs) Handles France3C.Click
        Dim France3C As Boolean = False
        Me.France3C.BackColor = Color.DarkSeaGreen
        France3C = True
    End Sub

    Private Sub France3D_Click(sender As Object, e As EventArgs) Handles France3D.Click
        Dim France3D As Boolean = False
        Me.France3D.BackColor = Color.DarkSeaGreen
        France3D = True
    End Sub

End Class