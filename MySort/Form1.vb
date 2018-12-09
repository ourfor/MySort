Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As MyArray = New MyArray()
        a.GetN(InputBox("输入数组中有多少个元素:"))
        a.MakeArray()
        Dim b As MySort = New MySort
        'b.BubbleSort(a.array)
        'b.ShellSort(a.array)
        b.InsertSort(a.array)
        a.ToString()
        End
    End Sub
End Class

Class MySort
    Function ShellSort(ByRef array As Double())
        Dim stepE As Integer = array.Length / 2
        For index1 As Integer = 0 To 1 Step 0
            If stepE <= 0 Then
                Exit For
            End If
            For index2 As Integer = 0 To array.Length - stepE - 1
                If array(index2) > array(index2 + stepE) Then
                    Dim tmp As Double = array(index2)
                    array(index2) = array(index2 + stepE)
                    array(index2 + stepE) = tmp
                End If
            Next index2
                stepE /= 2
        Next index1
    End Function

    Function InsertSort(ByRef array As Double())
        For index1 As Integer = 1 To array.Length - 1
            For index2 As Integer = 0 To index1 - 1
                If array(index2) > array(index1) Then
                    Dim tmp As Double = array(index1)
                    For index3 As Integer = index1 - 1 To index2 Step -1
                        array(index3 + 1) = array(index3)
                    Next index3
                    array(index2) = tmp
                End If
            Next index2
        Next index1
    End Function

    Function BubbleSort(ByRef array As Double())
        For index1 As Integer = array.Length - 1 To 1 Step -1
            For index2 As Integer = 0 To index1 - 1
                If array(index2) > array(index2 + 1) Then
                    Dim tmp As Double = array(index2)
                    array(index2) = array(index2 + 1)
                    array(index2 + 1) = tmp
                End If
            Next index2
        Next index1
    End Function
End Class

Class MyArray
    Private n As Integer
    Public array As Double()
    Sub GetN(ByVal num As Integer)
        n = num
        ReDim array(num)
    End Sub

    Public Function MakeArray() As Double()
        Dim index As Integer
        Try
            For index = 0 To UBound(array)
                array(index) = InputBox("输入第" + index.ToString + "的值")
            Next index
        Catch ex As Exception
            index -= 1
        End Try

    End Function

    Public Function ToString() As String
        Dim Str As String = ""
        For Each index As Double In array
            Str += index.ToString + " "
        Next index
        MsgBox(Str)
        Return Str
    End Function
End Class
