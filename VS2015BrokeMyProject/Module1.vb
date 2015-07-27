Imports ClassLibrary1

Module Module1

    Sub Main()
        Dim c As New Class1()

        ' Error BC30652	Reference required To assembly 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' containing the type 'Form'. Add one to your project.	VS2015BrokeMyProject	VS2015BrokeMyProject\VS2015BrokeMyProject\Module1.vb	9
        c.Test("hello")
    End Sub

End Module
