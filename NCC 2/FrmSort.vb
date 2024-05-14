Public Class FrmSort
    Dim randomNumbers(10) As Integer
    Private Sub Btn_10_Click(sender As Object, e As EventArgs) Handles Btn_10.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        'Start 10 random unsorted numbers in range between 1 and 100'
        For i = 0 To 9
            randomNumbers(i) = CInt(Rnd() * 100) + 1 'Scale and offset for range 1 to 100 '
        Next

        'Clearing the listbox before new data is being displayed'
        ListBox2.Items.Clear()

        'Show unsorted numbers'
        ListBox2.Items.Add("Unsorted")
        For i = 0 To 9
            ListBox2.Items.Add(randomNumbers(i).ToString())
        Next

        'Bubble logic'
        Dim swapped As Boolean = True 'method to see if any swaps have been made'

        'while loop added in the array for multiple loops to start.
        Do While swapped
            swapped = False 'Reset loop after each pass

            'Compare adjacent nums and swap if they are true
            For i = 0 To UBound(randomNumbers) - 1
                If randomNumbers(i) > randomNumbers(i + 1) Then
                    ' Then no command needed directly swap them
                    Dim temp As Integer = randomNumbers(i)
                    randomNumbers(i) = randomNumbers(i + 1)
                    randomNumbers(i + 1) = temp
                    swapped = True 'Set mark if a swap occurred'
                End If
            Next
        Loop


        'Show sorted numbers
        ListBox2.Items.Add("")
        ListBox2.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox2.Items.Add(randomNumbers(i).ToString())
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        ' Start Random Numbers
        For i = 0 To 9
            randomNumbers(i) = CInt(Rnd() * 100) + 1
        Next
        'Clearing the listbox before user pressed insertion sorting again
        ListBox2.Items.Clear()

        'Show Unsorted Numbers
        ListBox2.Items.Add("UNSORTED:")
        For i = 0 To 9
            ListBox2.Items.Add(randomNumbers(i).ToString())
        Next
        'Insertion Logic
        For i = 0 To 9 'Initiate from 2nd element (indexing from 1)
            Dim x As Integer = randomNumbers(i)
            Dim a As Integer = i - 1
            While a >= 0 AndAlso randomNumbers(a) > x
                randomNumbers(a + 1) = randomNumbers(a)
                a -= 1
                If a < 0 Then Exit While ' Make sure a doesn't go below 0 
            End While
            randomNumbers(a + 1) = x
        Next

        'Show Sorted Numbers
        ListBox2.Items.Add("")
        ListBox2.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox2.Items.Add(randomNumbers(i).ToString())
        Next

    End Sub
End Class