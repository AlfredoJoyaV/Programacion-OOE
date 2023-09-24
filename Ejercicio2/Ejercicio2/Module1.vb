Module Module1

    Sub Main()
        '2. Escriba un programa que determine si un número es positivo o negativo.
        'Declaramos variables
        Dim Numero As Double


        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("                Bienvenidos a Programación Orientada a Objetos y Eventos")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        'Mandamos un mensaje para pedir la información que necesitamos
        Console.WriteLine("Con este programa podremos identificar si tu numero es negativo (-) o positovo (+)")
        Console.WriteLine("************************************************************************************************")
        Console.WriteLine("¡¡¡¡¡¡¡¡¡¡INDICACIONES: SOLO DATOS NUMERICOS!!!!!!!!!!")
        Console.WriteLine("************************************************************************************************")
        Console.Write("Por favor coloca tu numero: ")
        Numero = Console.ReadLine()
        Convert.ToDouble(Numero)

        'Realizamos el proceso
        If (Numero = 0) Then
            Console.WriteLine("/////////////////////////////////////////////")
            Console.WriteLine("          Tu numero es Neutro")
            Console.WriteLine("/////////////////////////////////////////////")
        ElseIf (Numero < 0) Then
            Console.WriteLine("/////////////////////////////////////////////")
            Console.WriteLine("          Tu numero es Negativo")
            Console.WriteLine("/////////////////////////////////////////////")
        ElseIf (Numero > 0) Then
            Console.WriteLine("/////////////////////////////////////////////")
            Console.WriteLine("          Tu numero es Positivo")
            Console.WriteLine("/////////////////////////////////////////////")
        End If

        Console.ReadLine()
    End Sub

End Module
