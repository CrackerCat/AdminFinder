Imports System.Net

Module Main


    Sub Main()
        Console.Title = "AdminFinder v0.1 For Windows : Nyan Cat"
1:
        Console.Clear()
        Console.WriteLine("++-++-++-++-++-++-++-++")
        Console.WriteLine(" github.com/NYAN-x-CAT")
        Console.WriteLine("++-++-++-++-++-++-++-++")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter Website...")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Example: http://website.com/")
        Console.ResetColor()
        Console.WriteLine("")
        Dim Read = Console.ReadLine
        For Each G In L1.ToList
            Try : Target(Read + G) : Catch : GoTo 1 : End Try
        Next
        Console.WriteLine("DONE!")
        Console.ReadKey()
        GoTo 1
    End Sub

    Function Target(ByVal URL As String) As Boolean
        Dim request As WebRequest = WebRequest.Create(URL)
        request.Timeout = 15 * 1000
        Try
            Dim response As WebResponse = request.GetResponse()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(URL + "  [FOUND!]")
            Console.ResetColor()
            response.Close()
            request = Nothing
            Return True
        Catch ex As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(URL + "  [NOT FOUND!]")
            Console.ResetColor()
            request = Nothing
            Return False
        End Try
    End Function

End Module
