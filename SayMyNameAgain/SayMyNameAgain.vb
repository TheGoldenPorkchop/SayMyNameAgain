'Angel Nava
'Spring 2025
'RCET2265
'SayMyName
'https://github.com/TheGoldenPorkchop/SayMyNameAgain/blob/main/SayMyNameAgain/SayMyNameAgain.vb

Option Explicit On
Option Strict On
Option Compare Text
Module SayMyNameAgain

    Sub Main()
        Dim userName As String
        Dim quit As Boolean = False

        Do
            Console.WriteLine("Enter Username: ")
            userName = Console.ReadLine()
            If userName = "Emily" Then
                Console.WriteLine("Greetings, Emily.")
                quit = True
            ElseIf userName = "Joe" Then
                Console.WriteLine("Ay! What it do, Joe.")
                quit = True
            ElseIf userName = "Angel" Then
                Console.WriteLine("Woah, that's the programmer")
                quit = True
            Else
                Console.WriteLine("Invalid user. Please try again." & vbNewLine)
            End If
        Loop Until quit = True
    End Sub

End Module
