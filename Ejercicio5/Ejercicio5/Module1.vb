Module Module1

    Sub Main()

        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("                Bienvenidos a Programación Orientada a Objetos y Eventos")


        While (True)
            Try
                'Declaramos las variables
                Dim nTabla, I As Double
                Console.WriteLine("------------------------------------------------------------------------------------------------")
                Console.Write("Escriba el numero de la tabla que desea calcular: ")
                nTabla = Console.ReadLine()

                For I = 1 To 10
                    Console.WriteLine(nTabla.ToString() + "x" + I.ToString() + "=" + (nTabla * I).ToString())
                Next

                Console.Write("Deseas salir presiona (s), sino enter: ")
                Dim salir = Console.ReadLine()
                If (salir.ToLower() = "s") Then
                    Exit While
                End If
            Catch oError As Exception
                Console.WriteLine("Por favor ingrese solo valores numericos. " + oError.StackTrace)
            End Try
        End While
    End Sub

End Module
