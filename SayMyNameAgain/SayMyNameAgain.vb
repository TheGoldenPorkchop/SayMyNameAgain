'Angel Nava
'Spring 2025
'RCET2265
'SayMyName

Module SayMyNameAgain

    Sub Main()
        Dim userName As String

        Console.WriteLine("Give me your name: ")
        userName = Console.ReadLine()

        If userName = "Emily" Then
            Console.WriteLine("Greetings, Emily.")
        ElseIf userName = "Joe" Then
            Console.WriteLine("Ay! What it do, Joe.")
        ElseIf userName = "Angel" Then
            Console.WriteLine("Woah, that's the programmer")
        Else
            Console.WriteLine(vbNewLine & "Hello, " & userName)
        End If
    End Sub

End Module
