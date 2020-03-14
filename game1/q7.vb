Public Class q7
    Private Sub mcu2confirm_Click(sender As Object, e As EventArgs) Handles mcu2confirm.Click
        Me.Hide()
        q8.Show()
    End Sub

    'A: CORRECT'
    Private Sub mcu2A_Click(sender As Object, e As EventArgs) Handles mcu2A.Click
        Dim mcu2A As Boolean = False
        Me.mcu2A.BackColor = Color.DarkSeaGreen
        mcu2A = True
    End Sub

    'B: WRONG'
    Private Sub mcu2B_Click(sender As Object, e As EventArgs) Handles mcu2B.Click
        Dim mcu2A As Boolean = False, mcu2B As Boolean = False,
        mcu2C As Boolean = False, mcu2D As Boolean = False

        If Not mcu2A Then
            Me.mcu2B.BackColor = Color.IndianRed
            mcu2B = True
            Me.mcu2D.BackColor = Color.IndianRed
            mcu2D = True
        End If
        If Not mcu2C Then
            Me.mcu2A.BackColor = Color.DarkSeaGreen
            mcu2A = True
            Me.mcu2C.BackColor = Color.DarkSeaGreen
            mcu2C = True
        End If
    End Sub

    'C: CORRECT'
    Private Sub mcu2C_Click(sender As Object, e As EventArgs) Handles mcu2C.Click
        Dim mcu2C As Boolean = False
        Me.mcu2C.BackColor = Color.DarkSeaGreen
        mcu2C = True
    End Sub

    'D: WRONG'
    Private Sub mcu2D_Click(sender As Object, e As EventArgs) Handles mcu2D.Click
        Dim mcu2A As Boolean = False, mcu2B As Boolean = False,
        mcu2C As Boolean = False, mcu2D As Boolean = False

        If Not mcu2A Then
            Me.mcu2B.BackColor = Color.IndianRed
            mcu2B = True
            Me.mcu2D.BackColor = Color.IndianRed
            mcu2D = True
        End If
        If Not mcu2C Then
            Me.mcu2A.BackColor = Color.DarkSeaGreen
            mcu2A = True
            Me.mcu2C.BackColor = Color.DarkSeaGreen
            mcu2C = True
        End If
    End Sub
End Class