Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Class MySort
    Function ShellSort(ByRef array As Double())
        Dim stepE As Integer = array.Length / 2
        For index1 As Integer = 0 To 1 Step 0
            For index2 As Integer = 0 To array.Length - stepE - 1
                If array(index2) > array(index2 + 1) Then
                    Dim tmp As Double = array(index2)
                    array(index2) = array(index2 + 1)
                    array(index2 + 1) = tmp
                End If
            Next index2
        Next index1
    End Function

    Function InsertSort(ByRef array As Double())
        For index1 As Integer = 1 To array.Length
            For index2 As Integer = 0 To index1
                If array(index2) > array(index1) Then
                    Dim tmp As Double = array(index1)
                    For index3 As Integer = index2 To index1 - 1
                        array(index3 + 1) = array(index3)
                    Next index3
                    array(index2) = array(index1)
                End If
            Next index2
        Next index1
    End Function

    Function Bubble(ByRef array As Double())
        For index1 As Integer = array.Length To 1
            For index2 As Integer = 0 To index1
                If array(index2) > array(index2 + 1) Then
                    Dim tmp As Double = array(index2)
                    array(index2) = array(index2 + 1)
                    array(index2 + 1) = tmp
                End If
            Next index2
        Next index1
    End Function

    Function QuickSort(ByRef array As Double())
        Dim low As Integer = 0
        Dim high As Integer = array.Length
        Dim pivotkey As Double = array((low + high) / 2)
        Do While high > low
            Do While low < high And array(high) >= pivotkey
                array(low) = array(high)
                high -= 1
            Loop
    End Function
End Class
