do {
    Console.Clear();

    Console.WriteLine("====== Calculadora V1 ======");
    Console.WriteLine("1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir");

    string entrada = Console.ReadLine();
    int operacion = 0;

    while (!Int32.TryParse(entrada, out operacion) || operacion < 1 || operacion > 4) {
        Console.WriteLine("Error! Debe ingresar una opción válida");
        entrada = Console.ReadLine();
    }

    double num1 = 0, num2 = 0;
    Console.Write("Número 1: ");
    entrada = Console.ReadLine();
    while (!Double.TryParse(entrada, out num1)) {
        Console.WriteLine("Error! Debe ingresar un número entero");
        entrada = Console.ReadLine();
    }

    Console.Write("Número 2: ");
    entrada = Console.ReadLine();
    while (!Double.TryParse(entrada, out num2)) {
        Console.WriteLine("Error! Debe ingresar un número entero");
        entrada = Console.ReadLine();
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
    }

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
