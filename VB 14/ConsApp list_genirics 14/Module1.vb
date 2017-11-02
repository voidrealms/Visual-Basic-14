Module Module1

    Sub Main()
        Dim People As List(Of String)

        'list is generic.

        People = New List(Of String)
       
        People.Add("bob") '0 
        People.Add("marry") '1
        People.Add("chad") '2

        People.Insert(1, "heather")


        'If People.Contains("bob") Then
        'People.Remove("bob")
        'End If

        Dim sName As String
        For Each sName In People
            Console.WriteLine(sName)
        Next

        Console.ReadLine()

    End Sub

End Module
