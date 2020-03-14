Public Class q2

    Private Sub mcu4confirm_Click(sender As Object, e As EventArgs) Handles mcu4confirm.Click
        Me.Hide()
        q3.Show()
    End Sub

    'A: wrong'
    Private Sub mcu4A_Click(sender As Object, e As EventArgs) Handles mcu4A.Click
        Dim mcu4A As Boolean = False, mcu4B As Boolean = False,
          mcu4C As Boolean = False, mcu4D As Boolean = False

        If Not mcu4B Then
            Me.mcu4A.BackColor = Color.IndianRed
            mcu4A = True
            Me.mcu4C.BackColor = Color.IndianRed
            mcu4C = True
        End If
        If Not mcu4D Then
            Me.mcu4B.BackColor = Color.DarkSeaGreen
            mcu4B = True
            Me.mcu4D.BackColor = Color.DarkSeaGreen
            mcu4D = True
        End If
    End Sub

    'B: correct '
    Private Sub mcu4B_Click(sender As Object, e As EventArgs) Handles mcu4B.Click
        Dim mcu4B As Boolean = False
        Me.mcu4B.BackColor = Color.DarkSeaGreen
        mcu4B = True
    End Sub

    'C: wrong'
    Private Sub mcu4C_Click(sender As Object, e As EventArgs) Handles mcu4C.Click
        Dim mcu4A As Boolean = False, mcu4B As Boolean = False,
          mcu4C As Boolean = False, mcu4D As Boolean = False

        If Not mcu4B Then
            Me.mcu4A.BackColor = Color.IndianRed
            mcu4A = True
            Me.mcu4C.BackColor = Color.IndianRed
            mcu4C = True
        End If
        If Not mcu4D Then
            Me.mcu4B.BackColor = Color.DarkSeaGreen
            mcu4B = True
            Me.mcu4D.BackColor = Color.DarkSeaGreen
            mcu4D = True
        End If
    End Sub

    'D: correct'
    Private Sub mcu4D_Click(sender As Object, e As EventArgs) Handles mcu4D.Click
        Dim mcu4D As Boolean = False
        Me.mcu4D.BackColor = Color.DarkSeaGreen
        mcu4D = True
    End Sub
End Class