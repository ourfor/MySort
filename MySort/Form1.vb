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
        Dim c As Math1 = New Math1()
        MsgBox(c.Sum(a.array).ToString)
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 博客ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 博客ToolStripMenuItem.Click
        Process.Start("https://blog.ourfor.top")
    End Sub
End Class



Class Math1
    Implements MyMath

    Const PI As Double = 3.1415926535

    Public Function Area(radius As Double) As Double Implements MyMath.Area
        Return radius * radius * PI
    End Function

    Public Function Sum(array() As Double) As Double Implements MyMath.Sum
        Dim SumR As Double = 0
        For Each index As Double In array
            SumR += index
        Next index
        Return SumR
    End Function

End Class
