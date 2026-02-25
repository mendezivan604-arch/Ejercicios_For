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

Console.WriteLine("Ejercicio 19");
//Ejercicio 19
Console.Write("Ingrese número 1: ");
int menor = int.Parse(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.Write($"Ingrese número {i}: ");
    int n8 = int.Parse(Console.ReadLine());

    if (n8 < menor)
        menor = n8;
}

Console.WriteLine($"El número menor es: {menor}");

Console.WriteLine("Ejercicio 20");
//Ejercicio 20
Console.Write("¿Cuántos números desea ingresar?: ");
int N = int.Parse(Console.ReadLine());

int positivos = 0;

for (int i = 1; i <= N; i++)
{
    Console.Write($"Ingrese número {i}: ");
    int n8 = int.Parse(Console.ReadLine());

    if (n8 > 0)
        positivos++;
}

Console.WriteLine($"Cantidad de números positivos: {positivos}");

Console.WriteLine("Ejercicio 21");
//Ejercicio 21
Console.WriteLine("¿Cuántos números desea ingresar?: ");
int cantidad = int.Parse(Console.ReadLine());
int negativos = 0;
for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Ingrese un numero");
    double n9 = double.Parse(Console.ReadLine());
    if (n9 < 0)
        negativos++;
    
}

Console.WriteLine("Ejercicio 22");
//Ejercicio 22
Console.WriteLine("Ingrese la cantidad de ventas: ");
int cantidadventas = int.Parse(Console.ReadLine());
double total = 0;
for (int i = 1; i <= cantidadventas; i++)
{
    Console.WriteLine("Ingrese el costo de la venta");
    double venta = double.Parse(Console.ReadLine());
    total += venta;
}
Console.WriteLine($"la cantidad de venta sumada es : {total}");

Console.WriteLine("Ejercicio 23");
//Ejercicio 23
Console.WriteLine("Ingrese la cantidad de notas");
int cnotas = int.Parse(Console.ReadLine());
double suma4 = 0;
for (int i = 1; i <= cnotas; i++)
{
    Console.WriteLine("Ingrese nota");
    double notas = double.Parse(Console.ReadLine());
    suma4 += notas;
}
Console.WriteLine($"el promedio final es: {suma4 / cnotas}");

Console.WriteLine("Ejercicio 24");
//Ejercicio 24
Console.WriteLine("Ingrese la cantidad de notas");
int cantidaddenotas = int.Parse(Console.ReadLine());
double sumanotass = 0;
for (int i = 1; i <= cantidaddenotas; i++)
{
    Console.WriteLine("Ingrese nota");
    double notas = double.Parse(Console.ReadLine());
    sumanotass += notas;
}
double promedio1 = sumanotass / cantidaddenotas;
if (promedio >= 61)
{
    Console.WriteLine("Aprobo felicidades");
}
else
{
    Console.WriteLine("Pongase pilas");
}

Console.WriteLine("Ejercicio 25");
//Ejercicio 25
Console.WriteLine("Ingrese el numero de asteriscos");
int asterisco = int.Parse(Console.ReadLine());
string asteriscossuma = "";
for (int i = 1; i <= asterisco; i++)
{

    asteriscossuma += "*";
    Console.WriteLine(asteriscossuma);
}