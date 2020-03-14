Public Class Singapore2
    Private Sub Singapore2confirm_Click(sender As Object, e As EventArgs) Handles Singapore2confirm.Click
        Me.Hide()
        Singapore3.Show()
    End Sub

    Private Sub Singapore2A_Click(sender As Object, e As EventArgs) Handles Singapore2A.Click
        Dim Singapore2A As Boolean = False, Singapore2B As Boolean = False,
            Singapore2C As Boolean = False, Singapore2D As Boolean = False

        If Not Singapore2A Then
            Me.Singapore2A.BackColor = Color.IndianRed
            Singapore2A = True
            Me.Singapore2C.BackColor = Color.IndianRed
            Singapore2C = True
        End If
        If Not Singapore2B Then
            Me.Singapore2B.BackColor = Color.DarkSeaGreen
            Singapore2B = True
            Me.Singapore2D.BackColor = Color.DarkSeaGreen
            Singapore2D = True
        End If
    End Sub

    Private Sub Singapore2B_Click(sender As Object, e As EventArgs) Handles Singapore2B.Click
        Dim Singapore2B As Boolean = False
        Me.Singapore2B.BackColor = Color.DarkSeaGreen
        Singapore2B = True

    End Sub

    Private Sub Singapore2C_Click(sender As Object, e As EventArgs) Handles Singapore2C.Click
        Dim Singapore2A As Boolean = False, Singapore2B As Boolean = False,
           Singapore2C As Boolean = False, Singapore2D As Boolean = False

        If Not Singapore2A Then
            Me.Singapore2A.BackColor = Color.IndianRed
            Singapore2A = True
            Me.Singapore2C.BackColor = Color.IndianRed
            Singapore2C = True
        End If
        If Not Singapore2B Then
            Me.Singapore2B.BackColor = Color.DarkSeaGreen
            Singapore2B = True
            Me.Singapore2D.BackColor = Color.DarkSeaGreen
            Singapore2D = True
        End If
    End Sub

    Private Sub Singapore2D_Click(sender As Object, e As EventArgs) Handles Singapore2D.Click
        Dim Singapore2D As Boolean = False
        Me.Singapore2D.BackColor = Color.DarkSeaGreen
        Singapore2D = True

    End Sub
End Class