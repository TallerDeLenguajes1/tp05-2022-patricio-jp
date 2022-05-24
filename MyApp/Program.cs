do {
    Console.Clear();

    Console.WriteLine("====== Calculadora V2 ======");
    Console.WriteLine("1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Valor Absoluto\n6) Cuadrado de un número\n7) Raíz cuadrada de un número\n8) Seno de un número\n9) Coseno de un número\n10) Parte entera de un número");

    string entrada = Console.ReadLine();
    int operacion = 0;

    while (!Int32.TryParse(entrada, out operacion) || operacion < 1 || operacion > 10) {
        Console.WriteLine("Error! Debe ingresar una opción válida");
        entrada = Console.ReadLine();
    }

    double num = 0, num1 = 0, num2 = 0;
    if (operacion > 4) {
        Console.Write("Número: ");
        entrada = Console.ReadLine();
        while (!Double.TryParse(entrada, out num)) {
            Console.WriteLine("Error! Debe ingresar un número válido");
            entrada = Console.ReadLine();
        }
    } else {
        Console.Write("Número 1: ");
        entrada = Console.ReadLine();
        while (!Double.TryParse(entrada, out num1)) {
            Console.WriteLine("Error! Debe ingresar un número válido");
            entrada = Console.ReadLine();
        }

        Console.Write("Número 2: ");
        entrada = Console.ReadLine();
        while (!Double.TryParse(entrada, out num2)) {
            Console.WriteLine("Error! Debe ingresar un número válido");
            entrada = Console.ReadLine();
        }
    }


    switch (operacion) {
        case 1:
            Console.WriteLine("Resultado: " + sumar(num1, num2));
            break;
        case 2:
            Console.WriteLine("Resultado: " + restar(num1, num2));
            break;
        case 3:
            Console.WriteLine("Resultado: " + multiplicar(num1, num2));
            break;
        case 4:
            Console.WriteLine("Resultado: " + dividir(num1, num2));
            break;
        case 5:
            Console.WriteLine("Resultado: " + Math.Abs(num));
            break;
        case 6:
            Console.WriteLine("Resultado: " + Math.Pow(num, 2));
            break;
        case 7:
            Console.WriteLine("Resultado: " + Math.Sqrt(num));
            break;
        case 8:
            Console.WriteLine("Resultado: " + Math.Sin(num * Math.PI / 180));
            break;
        case 9:
            Console.WriteLine("Resultado: " + Math.Cos(num * Math.PI / 180));
            break;
        case 10:
            Console.WriteLine("Resultado: " + Math.Truncate(num));
            break;
    }

    Console.WriteLine("\nIngrese dos números para determinar el mínimo y el máximo entre ambos");
    Console.Write("Número 1: ");
    entrada = Console.ReadLine();
    while (!Double.TryParse(entrada, out num1)) {
        Console.WriteLine("Error! Debe ingresar un número válido");
        entrada = Console.ReadLine();
    }

    Console.Write("Número 2: ");
    entrada = Console.ReadLine();
    while (!Double.TryParse(entrada, out num2)) {
        Console.WriteLine("Error! Debe ingresar un número válido");
        entrada = Console.ReadLine();
    }

    Console.WriteLine("Mínimo: " + Math.Min(num1, num2));
    Console.WriteLine("Máximo: " + Math.Max(num1, num2) + "\n");

    Console.WriteLine("Desea realizar otra operación?\n0. No\n1. Si");
} while (Console.ReadKey(false).Key != ConsoleKey.D0);

double sumar(double num1, double num2) {
    return num1 + num2;
}

double restar(double num1, double num2) {
    return num1 - num2;
}

double multiplicar(double num1, double num2) {
    return num1 * num2;
}

double dividir(double num1, double num2) {
    return num1 / num2;
}
