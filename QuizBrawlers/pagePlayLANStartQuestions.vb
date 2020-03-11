Public Class pagePlayLANStartQuestions
    Private Function Rand(v1 As Integer, v2 As Integer) As Long
    End Function
    Private Sub startquestionsconfirm_Click(sender As Object, e As EventArgs) Handles startquestionsconfirm.Click
        Me.Hide()
        'Console.WriteLine(Application.StartupPath)
        Dim Form1 As New testquestions_years.yearsVideoGamesQ1
        Dim Form2 As New testquestions_years.Form2
        Dim Form3 As New testquestions_years.Form3
        Dim Form4 As New testquestions_years.Form4
        Dim Form5 As New testquestions_years.Form5
        'Form1.Show()

        Dim arrValues(10) As Long
        Dim i As Long
        Dim j As Long
        Dim k As Long
        Dim lngTemp As Long

        'seed the array with numbers 1 - 10
        For i = 1 To 10
            arrValues(i) = i
        Next i

        'shuffle it 7 times
        For i = 1 To 20
            'iterate through the deck
            For j = 1 To 10
                'get random location to swap with
                k = Rand(1, 10)

                'swap the values
                lngTemp = arrValues(j)
                arrValues(j) = arrValues(k)
                arrValues(k) = lngTemp
            Next j
        Next i

        For i = 1 To 10
            Select Case arrValues(i)
                Case 1
                    Form1.Show()
                Case 2
                    Form2.Show()
                Case 3
                    Form3.Show()
                Case 4
                    Form4.Show()
                Case 5
                    Form5.Show()
                Case Else
                    Me.Show()
            End Select
        Next
    End Sub
End Class