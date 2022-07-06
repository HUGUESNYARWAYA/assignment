Module Module1

    Sub Main()
        Dim NameList As List(Of String) = New List(Of String)
        Dim OOPList As List(Of Decimal) = New List(Of Decimal)
        Dim JavaList As List(Of Decimal) = New List(Of Decimal)
        Dim CList As List(Of Decimal) = New List(Of Decimal)
        Dim Name As String
        Dim OOP, Java, C As Decimal
        Dim AvgOOP, AvgJava, AvgC As Decimal
        AvgOOP = 0
        AvgJava = 0
        AvgC = 0
        Do
            Console.Write("Enter student name:")
            Name = Console.ReadLine()

            If Name <> LCase("N") Then
                NameList.Add(Name)
                Console.Write(Name & " OOP Grade:")
                OOP = Console.ReadLine()
                OOPList.Add(OOP)
                AvgOOP = AvgOOP + OOP
                Console.Write(Name & " Java Grade:")
                Java = Console.ReadLine()
                JavaList.Add(Java)
                AvgJava = AvgJava + Java
                Console.Write(Name & " C Grade:")
                C = Console.ReadLine()
                CList.Add(C)
                AvgC = AvgC + C

            End If
            Console.WriteLine(" ")
        Loop While Name <> LCase("N")

        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("List of students with their respective Grades:")
        Console.WriteLine("  ")
        Console.WriteLine("  Student Name     OOP   Java   C")
        Console.WriteLine("  ")
        For i As Integer = 0 To NameList.Count - 1
            Console.WriteLine("   " & NameList(i) & "         " & OOPList(i) & "     " & JavaList(i) & "    " & CList(i))
        Next
        Console.WriteLine(" ")
        Console.WriteLine("  Average          " & AvgOOP / NameList.Count & "     " & AvgJava / NameList.Count & "     " & AvgC / NameList.Count)
        Console.ReadLine()

    End Sub

End Module
