Console.WriteLine("Ingrese un número para invertirlo: ");
string entrada = Console.ReadLine();

int number = 0;

if (Int32.TryParse(entrada, out number)) {
    if (number > 0) {
        int inverted = 0, ultimoDigito = 0;

        while (number > 0) {
            ultimoDigito = number % 10;
            inverted = inverted * 10 + ultimoDigito;
            number /= 10;
        }

        Console.WriteLine("Número invertido: " + inverted);
    } else {
        Console.WriteLine("El número ingresado es menor que cero. No se invertirá el número");
    }
} else {
    Console.WriteLine("Error! Debe ingresar un número");
}

