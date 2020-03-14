Public Class q3
    Private Sub Singapore3confirm_Click(sender As Object, e As EventArgs) Handles Singapore3confirm.Click
        Me.Hide()
        q4.Show()
    End Sub

    'A: correct'
    Private Sub Singapore3A_Click(sender As Object, e As EventArgs) Handles Singapore3A.Click
        Dim Singapore3A As Boolean = False
        Me.Singapore3A.BackColor = Color.DarkSeaGreen
        Singapore3A = True
        Singapore3avatar.Image = My.Resources.superman
    End Sub

    'B: correct'
    Private Sub Singapore3B_Click(sender As Object, e As EventArgs) Handles Singapore3B.Click
        Dim Singapore3B As Boolean = False
        Me.Singapore3B.BackColor = Color.DarkSeaGreen
        Singapore3B = True
        Singapore3avatar.Image = My.Resources.superman
    End Sub

    'C: wrong'
    Private Sub Singapore3C_Click(sender As Object, e As EventArgs) Handles Singapore3C.Click
        Dim Singapore3A As Boolean = False, Singapore3B As Boolean = False,
          Singapore3C As Boolean = False, Singapore3D As Boolean = False

        If Not Singapore3A Then
            Me.Singapore3C.BackColor = Color.IndianRed
            Singapore3C = True
            Me.Singapore3D.BackColor = Color.IndianRed
            Singapore3D = True
        End If
        If Not Singapore3B Then
            Me.Singapore3A.BackColor = Color.DarkSeaGreen
            Singapore3A = True
            Me.Singapore3B.BackColor = Color.DarkSeaGreen
            Singapore3B = True
        End If
        Singapore3avatar.Image = My.Resources.superman
    End Sub

    'D: correct'
    Private Sub Singapore3D_Click(sender As Object, e As EventArgs) Handles Singapore3D.Click
        Dim Singapore3A As Boolean = False, Singapore3B As Boolean = False,
          Singapore3C As Boolean = False, Singapore3D As Boolean = False

        If Not Singapore3A Then
            Me.Singapore3C.BackColor = Color.IndianRed
            Singapore3C = True
            Me.Singapore3D.BackColor = Color.IndianRed
            Singapore3D = True
        End If
        If Not Singapore3B Then
            Me.Singapore3A.BackColor = Color.DarkSeaGreen
            Singapore3A = True
            Me.Singapore3B.BackColor = Color.DarkSeaGreen
            Singapore3B = True
        End If
        Singapore3avatar.Image = My.Resources.superman
    End Sub


End Class