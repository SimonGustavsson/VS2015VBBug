Imports System.Windows.Forms

Public Class Class1

    Public Sub Test(ByVal form As Form)
        Console.WriteLine(form.Name)
    End Sub

    Public Sub Test(ByVal s As String)
        Console.WriteLine(s)
    End Sub

End Class
