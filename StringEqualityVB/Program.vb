Option Compare Text

Imports System

Module Program
    Sub Main(args As String())
        Dim stringValue1 As String = "a"
        Dim stringValue2 As String = "A"

        ' �uOption Compare Text�v���L���ɂȂ��Ă���ƁA = �̔�r��True�ɂȂ�B
        Console.WriteLine(stringValue1 = stringValue2)
        Console.WriteLine(stringValue1.Equals(stringValue2))
    End Sub
End Module
