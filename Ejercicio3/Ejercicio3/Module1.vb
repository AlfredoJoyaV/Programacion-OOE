Module Module1

    Sub Main()
        '3. Elabore un programa que de acuerdo con un monto de compra muestre el descuento aplicado y total a pagar.
        '$ 1000.00 30%
        '$ 500.00 20%
        '$ 250.00 10%
        'Otra Cantidad 5%

        'Declaramos las variables
        Dim Nom As String
        Dim Monto, Descuento, Total As Double

        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("                Bienvenidos a Programación Orientada a Objetos y Eventos")
        Console.WriteLine("------------------------------------------------------------------------------------------------")
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
        Console.WriteLine("Con este programa podremos identificar el porcentaje de descuento, el monto del descuento y el total a pagar")
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
        'Pedimos los datos al cliente
        Console.WriteLine("Nombre del comprador: ")
        Nom = Console.ReadLine()
        Console.Write("Total de la compra: $")
        Monto = Console.ReadLine()
        'Proceso

        If (Monto <= 249.99) Then
            Descuento = Monto * 0.05
            Total = Monto - Descuento
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Nombre del cliente: " + Nom)
            Console.WriteLine("Monto de la compra: $" + Monto.ToString)
            Console.WriteLine("Descuento: $" + Descuento.ToString)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Total a pagar: $" + Total.ToString)
            Console.WriteLine("-------------------------------------------")
        ElseIf (Monto = 250.0 Or Monto <= 499.99) Then
            Descuento = Monto * 0.1
            Total = Monto - Descuento
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Nombre del cliente: " + Nom)
            Console.WriteLine("Monto de la compra: $" + Monto.ToString)
            Console.WriteLine("Descuento: $" + Descuento.ToString)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Total a pagar: $" + Total.ToString)
            Console.WriteLine("-------------------------------------------")
        ElseIf (Monto = 500.0 Or Monto <= 999.99) Then
            Descuento = Monto * 0.2
            Total = Monto - Descuento
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Nombre del cliente: " + Nom)
            Console.WriteLine("Monto de la compra: $" + Monto.ToString)
            Console.WriteLine("Descuento: $" + Descuento.ToString)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Total a pagar: $" + Total.ToString)
            Console.WriteLine("-------------------------------------------")
        ElseIf (Monto >= 1000.0) Then
            Descuento = Monto * 0.3
            Total = Monto - Descuento
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Nombre del cliente: " + Nom)
            Console.WriteLine("Monto de la compra: $" + Monto.ToString)
            Console.WriteLine("Descuento: $" + Descuento.ToString)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Total a pagar: $" + Total.ToString)
            Console.WriteLine("-------------------------------------------")

        End If
        Console.WriteLine("**GRACIAS POR SU PREFERENCIA LE ESPERAMOS PRONTO**")

        Console.ReadLine()
    End Sub

End Module
