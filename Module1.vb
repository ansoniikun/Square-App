Module Module1

    Class Square

        Public length As Integer

    End Class

    Sub Main()
        Dim ob As New Square
        Dim param As Integer
        Dim area As Integer
        Dim diag As Double


        Console.WriteLine("Enter the length of your square: ")
        ob.length = Console.ReadLine()

        param = 4 * ob.length
        area = ob.length * ob.length
        diag = Math.Sqrt(2) * ob.length

        Console.WriteLine("Parameter of your square= " & param & "cm")
        Console.WriteLine("Area of your square= " & area & "cm")
        Console.WriteLine("Diagonal of your square= " & diag & "cm")
        Console.ReadKey()


    End Sub

    'Designed and coded by Hlompho Anthony Maleke 202105507
End Module
