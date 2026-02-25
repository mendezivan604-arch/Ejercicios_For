Console.WriteLine("Ejercicio 1");
//Ejercicio 1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Número: {i}");
}

Console.WriteLine("Ejercicio 2");
//Ejercicio 2
for (int i = 1; i <= 20; i++)
{
    Console.Write($"{i} ");
}

Console.WriteLine(" ");
Console.WriteLine("Ejercicio 3");
//Ejercicio 3
for (int i2 = 10; i2 >= 1; i2--)
{
    Console.WriteLine($"Número: {i2}");
}

Console.WriteLine("Ejercicio 4");
//Ejercicio 4
for (int i2 = 0; i2 <= 20; i2+=2)
{
    Console.WriteLine($"Número: {i2}");
}

Console.WriteLine("Ejercicio 5");
//Ejercicio 5
for (int i2 = 1; i2 <= 20; i2 += 2)
{
    Console.WriteLine($"Número: {i2}");
}

Console.WriteLine("Ejercicio 6");
//Ejercicio 6
for (int i2 = 1; i2 <= 5; i2++)
{
    Console.WriteLine($"Hola");
}

Console.WriteLine("Ejercicio 7");
//Ejercicio 7
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Número: {i} -> {i * i}");
}

Console.WriteLine("Ejercicio 8");
//Ejercicio 8
for (int i = 5; i <= 50; i+= 5)
{
    Console.WriteLine($"{i}");
}

Console.WriteLine("Ejercicio 9");
//Ejercicio 9
int suma = 0;
for (int i = 1; i <= 10; i++)
{
    suma += i;
}
Console.WriteLine($"Suma: {suma}");

Console.WriteLine("Ejercicio 10");
//Ejercicio 10
int suma1 = 0;
for (int i = 1; i <= 100; i++)
{
    suma1 += i;
}
Console.WriteLine($"Suma: {suma1}");

Console.WriteLine("Ejercicio 11");
//Ejercicio 11
Console.Write("Ingrese un número: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}

Console.WriteLine("Ejercicio 12");
//Ejercicio 12
Console.Write("Ingrese un número: ");
int n1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= n1; i++)
{
    Console.WriteLine($"{i} ");
}

Console.WriteLine("Ejercicio 13");
//Ejercicio 13
Console.Write("Ingrese un número: ");
int n2 = int.Parse(Console.ReadLine());

for (int i = n2; i >= 1; i--)
{
    Console.WriteLine($"{i} ");
}

Console.WriteLine("Ejercicio 14");
//Ejercicio 14
int suma2 = 0;

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Ingrese número {i}: ");
    suma2 += int.Parse(Console.ReadLine());
}

Console.WriteLine($"La suma total es: {suma2}");

Console.WriteLine("Ejercicio 15");
//Ejercicio 15
double suma3 = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingrese número {i}: ");
    suma3 += double.Parse(Console.ReadLine());
}

double promedio = suma3 / 5;
Console.WriteLine($"El promedio es: {promedio}");

Console.WriteLine("Ejercicio 16");
//Ejercicio 16
int contador = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingrese número {i}: ");
    int n4 = int.Parse(Console.ReadLine());

    if (n4 > 10)
        contador++;
}

Console.WriteLine($"Cantidad mayores que 10: {contador}");

Console.WriteLine("Ejercicio 17");
//Ejercicio 17
int pares = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingrese número {i}: ");
    int n5 = int.Parse(Console.ReadLine());

    if (n5 % 2 == 0)
        pares++;
}

Console.WriteLine($"Cantidad de números pares: {pares}");

Console.WriteLine("Ejercicio 18");
//Ejercicio 18
Console.Write("Ingrese número 1: ");
int mayor = int.Parse(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.Write($"Ingrese número {i}: ");
    int n7 = int.Parse(Console.ReadLine());

    if (n7 > mayor)
        mayor = n7;
}

Console.WriteLine($"El número mayor es: {mayor}");