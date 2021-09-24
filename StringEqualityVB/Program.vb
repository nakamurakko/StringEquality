Option Compare Text

Imports System

Module Program
    Sub Main(args As String())
        Dim stringValue1 As String = "a"
        Dim stringValue2 As String = "A"

        ' 「Option Compare Text」が有効になっていると、 = の比較がTrueになる。
        Console.WriteLine(stringValue1 = stringValue2)
        Console.WriteLine(stringValue1.Equals(stringValue2))
    End Sub
End Module
