Public Class Nether1
    Private Sub Nether1confirm_Click(sender As Object, e As EventArgs) Handles Nether1confirm.Click
        Me.Hide()
        Nether2.Show()
    End Sub

    Private Sub Nether1A_Click(sender As Object, e As EventArgs) Handles Nether1A.Click
        Dim Nether1A As Boolean = False
        Me.Nether1A.BackColor = Color.DarkSeaGreen
        Nether1A = True
    End Sub

    Private Sub Nether1B_Click(sender As Object, e As EventArgs) Handles Nether1B.Click
        Dim Nether1B As Boolean = False
        Me.Nether1B.BackColor = Color.DarkSeaGreen
        Nether1B = True
    End Sub

    Private Sub Nether1C_Click(sender As Object, e As EventArgs) Handles Nether1C.Click
        Dim Nether1A As Boolean = False, Nether1B As Boolean = False,
           Nether1C As Boolean = False, Nether1D As Boolean = False

        If Not Nether1C Then
            Me.Nether1C.BackColor = Color.IndianRed
            Nether1C = True
            Me.Nether1D.BackColor = Color.IndianRed
            Nether1D = True
        End If
        If Not Nether1A Then
            Me.Nether1A.BackColor = Color.DarkSeaGreen
            Nether1A = True
            Me.Nether1B.BackColor = Color.DarkSeaGreen
            Nether1B = True
        End If
    End Sub

    Private Sub Nether1D_Click(sender As Object, e As EventArgs) Handles Nether1D.Click
        Dim Nether1A As Boolean = False, Nether1B As Boolean = False,
            Nether1C As Boolean = False, Nether1D As Boolean = False

        If Not Nether1D Then
            Me.Nether1D.BackColor = Color.IndianRed
            Nether1D = True
            Me.Nether1C.BackColor = Color.IndianRed
            Nether1C = True
        End If
        If Not Nether1A Then
            Me.Nether1A.BackColor = Color.DarkSeaGreen
            Nether1A = True
            Me.Nether1B.BackColor = Color.DarkSeaGreen
            Nether1B = True
        End If
    End Sub
End Class