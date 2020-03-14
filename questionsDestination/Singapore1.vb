Public Class Singapore1
    Private Sub Singapore1confirm_Click(sender As Object, e As EventArgs) Handles Singapore1confirm.Click
        Me.Hide()
        Singapore2.Show()
    End Sub

    Private Sub Singapore1A_Click(sender As Object, e As EventArgs) Handles Singapore1A.Click
        Dim Singapore1A As Boolean = False
        Me.Singapore1A.BackColor = Color.DarkSeaGreen
        Singapore1A = True

    End Sub

    Private Sub Singapore1B_Click(sender As Object, e As EventArgs) Handles Singapore1B.Click
        Dim Singapore1A As Boolean = False, Singapore1B As Boolean = False,
            Singapore1C As Boolean = False, Singapore1D As Boolean = False

        If Not Singapore1B Then
            Me.Singapore1B.BackColor = Color.IndianRed
            Singapore1B = True
            Me.Singapore1C.BackColor = Color.IndianRed
            Singapore1C = True
        End If
        If Not Singapore1A Then
            Me.Singapore1A.BackColor = Color.DarkSeaGreen
            Singapore1A = True
            Me.Singapore1D.BackColor = Color.DarkSeaGreen
            Singapore1D = True
        End If
    End Sub

    Private Sub Singapore1C_Click(sender As Object, e As EventArgs) Handles Singapore1C.Click
        Dim Singapore1A As Boolean = False, Singapore1B As Boolean = False,
            Singapore1C As Boolean = False, Singapore1D As Boolean = False

        If Not Singapore1B Then
            Me.Singapore1B.BackColor = Color.IndianRed
            Singapore1B = True
            Me.Singapore1C.BackColor = Color.IndianRed
            Singapore1C = True
        End If
        If Not Singapore1D Then
            Me.Singapore1D.BackColor = Color.DarkSeaGreen
            Singapore1D = True
            Me.Singapore1A.BackColor = Color.DarkSeaGreen
            Singapore1A = True
        End If
    End Sub

    Private Sub Singapore1D_Click(sender As Object, e As EventArgs) Handles Singapore1D.Click
        Dim Singapore1D As Boolean = False
        Me.Singapore1D.BackColor = Color.DarkSeaGreen
        Singapore1D = True
    End Sub
End Class
