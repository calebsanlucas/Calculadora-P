bool repetir = true;
do
{

    Console.WriteLine("*");
    Console.WriteLine("Calculadora");
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Resta");
    Console.WriteLine("3.Multiplicación");
    Console.WriteLine("4.División");
    Console.WriteLine("5.Salir");
    Console.WriteLine("1.Ingrese una opción entre 1 y 4");
    string opcion = Console.ReadLine();

    int a = 0;
    int b = 0;

    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
    {
        Console.WriteLine("Ingrese el primer número: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        b = int.Parse(Console.ReadLine());
    }



    switch (opcion)
    {
        case "1":
            int resultadoSuma = a + b;
            Console.WriteLine($"El resultado de la suma es {resultadoSuma}");
            break;

        case "2":
            int resultadoResta = a - b;
            Console.WriteLine($"El resultado de la resta es {resultadoResta}");
            break;


        case "3":
            int resultadoMultiplicacion = a * b;
            Console.WriteLine($"El resultado de la suma es {resultadoMultiplicacion}");
            break;


        case "4":
            int resultadoDivision = a + b;
            Console.WriteLine($"El resultado de la suma es {resultadoDivision}");
            break;

        case "5":
            Console.WriteLine("Hasta pronto....");
            repetir = false;
            break;


        default:
            Console.WriteLine("Ingrese una opción correcta");
            break;
    }


} while (repetir);