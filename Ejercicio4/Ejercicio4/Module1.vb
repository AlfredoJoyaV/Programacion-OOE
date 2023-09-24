Module Module1

    Sub Main()
        '4. Calcule la suma de los números naturales desde 1 hasta n. Ejemplo: 1+2+3+4+5=15
        'Declaramos variables
        Dim N, Suma, I As Double

        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("                Bienvenidos a Programación Orientada a Objetos y Eventos")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
        Console.WriteLine("Con este programa podremos hacer la suma de numeros naturales desde el 1 a N cantidad monstrando el resultado")
        While (True)
            Try
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
                'Pedimos la informacion

                Console.WriteLine("Coloca la cantidad con la que quieres que llegue el programa sumando: ")
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------")
                N = Console.ReadLine()

                Suma = 0

                For I = 1 To N
                    Suma = Suma + I

                Next
                Console.WriteLine("El resultado de la suma desde 1 hasta " + N.ToString + " es: " + Suma.ToString)

                Console.WriteLine("Si desea salir del programa preciosa S, si desea continuar presiona Enter: ")
                Dim salir = Console.ReadLine()

                If (salir.ToLower = "s") Then

                    Exit While
                End If
            Catch oError As Exception
                Console.WriteLine("Por favor ingrese solo valores numericos" + oError.StackTrace)
            End Try
        End While
    End Sub

End Module
