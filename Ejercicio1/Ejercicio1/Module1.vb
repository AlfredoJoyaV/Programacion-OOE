Module Module1

    Sub Main()
        '1. Escriba un programa que solicite la edad de una persona y determine si es menor o mayor de edad, deberá mostrar un mensaje.
        'Declaramos variables

        Dim Nombre As String
        Dim Edad As Int16
        'Mandamos un mensaje para pedir la información que necesitamos

        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("                Bienvenidos a Programación Orientada a Objetos y Eventos")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("Por favor coloca tu nombre")
        Nombre = Console.ReadLine()
        Console.WriteLine("Por favor coloca tu edad")
        Edad = Console.ReadLine()

        'Hacemos el proceso
        Select Case Edad
            Case 0 To 17
                Console.WriteLine("*******************************************************************")
                Console.WriteLine("             " + Nombre + " tu eres menor de edad")
                Console.WriteLine("*******************************************************************")
            Case 18 To 127
                Console.WriteLine("*******************************************************************")
                Console.WriteLine("             " + Nombre + " tu eres mayor de edad")
                Console.WriteLine("*******************************************************************")
            Case Else
                Console.WriteLine("///////////////////////////////////////////////////////////////////")
                Console.WriteLine("          No es posible esa edad, intente nuevamente")
                Console.WriteLine("///////////////////////////////////////////////////////////////////")
        End Select


        Console.ReadLine()
    End Sub

End Module
