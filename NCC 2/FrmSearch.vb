Public Class FrmSearch
    Dim Stri As IO.StreamReader
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click

        Dim target As String = TextBox1.Text ' Change this to the target string you want to search for

        'Perform the Linear search and display the result
        Dim index As Integer = LinearSearch(target)

        If index >= 0 Then
            'Item found, do something with it
            MessageBox.Show("Item found using linear search at : " & index)
        Else
            MessageBox.Show("Item not found using linear search")
        End If
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        Stri = New IO.StreamReader("C:\Users\DELL\Desktop\ncc talha.txt")
        ListBox1.Items.Clear()
        While (Stri.Peek > -1)
            ListBox1.Items.Add(Stri.ReadLine)
        End While
        Stri.Close()

    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Public Function LinearSearch(ByVal target As String) As Integer
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i) = target Then
                'Item found, return the index
                Return i
            End If
        Next

        'Item not found'
        Return -1
    End Function

    Public Sub BinarySearch(ByVal target As String)

        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = ListBox1.Items.Count - 1

        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentItem As String = ListBox1.Items(middle)

            If currentItem = target Then
                'Item found, do something with it 
                MessageBox.Show("Item found using binary search : " & currentItem)
                Exit Sub
            ElseIf currentItem < target Then
                lowerbound = middle + 1
            Else
                upperbound = middle - 1
            End If
        End While

        'Item not found
        MessageBox.Show("Item not found: " & target)
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        Dim data As List(Of String) = ListBox1.Items.Cast(Of String)().ToList()
        data.Sort()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(data.ToArray())
        BinarySearch(TextBox1.Text)
    End Sub
End Class