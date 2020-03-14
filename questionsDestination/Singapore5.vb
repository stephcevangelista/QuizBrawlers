Public Class Singapore5
    Private Sub Singapore5confirm_Click(sender As Object, e As EventArgs) Handles Singapore5confirm.Click
        Me.Hide()
        Egypt1.Show()
    End Sub

    Private Sub Singapore5A_Click(sender As Object, e As EventArgs) Handles Singapore5A.Click
        Dim Singapore5A As Boolean = False, Singapore5B As Boolean = False,
         Singapore5C As Boolean = False, Singapore5D As Boolean = False

        If Not Singapore5A Then
            Me.Singapore5A.BackColor = Color.IndianRed
            Singapore5A = True
            Me.Singapore5C.BackColor = Color.IndianRed
            Singapore5C = True
        End If
        If Not Singapore5B Then
            Me.Singapore5B.BackColor = Color.DarkSeaGreen
            Singapore5B = True
            Me.Singapore5D.BackColor = Color.DarkSeaGreen
            Singapore5D = True
        End If
    End Sub

    Private Sub Singapore5B_Click(sender As Object, e As EventArgs) Handles Singapore5B.Click
        Dim Singapore5B As Boolean = False
        Me.Singapore5B.BackColor = Color.DarkSeaGreen
        Singapore5B = True
    End Sub

    Private Sub Singapore5C_Click(sender As Object, e As EventArgs) Handles Singapore5C.Click
        Dim Singapore5A As Boolean = False, Singapore5B As Boolean = False,
         Singapore5C As Boolean = False, Singapore5D As Boolean = False

        If Not Singapore5C Then
            Me.Singapore5C.BackColor = Color.IndianRed
            Singapore5C = True
            Me.Singapore5A.BackColor = Color.IndianRed
            Singapore5A = True
        End If
        If Not Singapore5B Then
            Me.Singapore5B.BackColor = Color.DarkSeaGreen
            Singapore5B = True
            Me.Singapore5D.BackColor = Color.DarkSeaGreen
            Singapore5D = True
        End If
    End Sub

    Private Sub Singapore5D_Click(sender As Object, e As EventArgs) Handles Singapore5D.Click
        Dim Singapore5D As Boolean = False
        Me.Singapore5D.BackColor = Color.DarkSeaGreen
        Singapore5D = True
    End Sub
End Class