using System;
using System.Linq;

namespace Laboratorio2;
/*/
//solicite el numero de tamaño de arreglos de entero
//calcular la suma de sus elementos y mostrar la cantidad de elementos.
public static class Program
{
	public static void Main()
	{
     Console.Write("tamaño de arreglo:");
	 int n=int.Parse(Console.ReadLine());
	 Double[] m= new double[n];
	 Console.WriteLine("ingrese elementos:");
	 Double temp=0;
	 for (int i=0;i<m.Length;i++)
	 {
      Console.Write("ingrese elemento["+i+"]:");
	  m[i]=double.Parse(Console.ReadLine());
	  temp += m[i];
	  
     }
	 Console.WriteLine("la suma de elementos es:"+temp);
	 int tamaño = m.Length;
	 Console.WriteLine("la cantidad de elemento es:{0}",tamaño);
     Console.ReadLine();
    }
}
/*/ 
 
/*/
//1)  
public static class Program
{
	public static void Main()
	{
     // Solicitar al usuario que ingrese dos números
     Console.WriteLine("Ingresa el primer número:");
     double num1 = Convert.ToDouble(Console.ReadLine());

     Console.WriteLine("Ingresa el segundo número:");
     double num2 = Convert.ToDouble(Console.ReadLine());

     // Realizar las operaciones
     double suma = num1 + num2;
     double resta = num1 - num2;
     double multiplicacion = num1 * num2;
     double division = num1 / num2;

     // Mostrar los resultados
     Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
     Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
     Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
     Console.WriteLine($"División: {num1} / {num2} = {division}");

     Console.ReadLine();
	}
}
/*/

/*/
//2)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("ingresar numero:");
	int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}
/*/

/*/
//3)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Por favor, introduce la base del triángulo:");
     double baseTriangulo = Convert.ToDouble(Console.ReadLine());

     Console.WriteLine("Ahora, introduce la altura del triángulo:");
     double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

     double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

     Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }
}

/*/

/*/
//4)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Por favor, introduce un número para calcular su factorial:");
     int numero = Convert.ToInt32(Console.ReadLine());

     long factorial = CalcularFactorial(numero);
        
     Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
    static long CalcularFactorial(int numero)
    {
     if (numero < 0)
     {
      throw new ArgumentException("El factorial no está definido para números negativos.");
     }
      else if (numero == 0 || numero == 1)
     {
      return 1;
     }
     else
	{
     long resultado = 1;
     for (int i = 2; i <= numero; i++)
      {
       resultado *= i;
      }
       return resultado;
     }
	}
	
}	 
/*/

/*/	 
//5)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Por favor, introduce un número para verificar si es primo:");
     int numero = Convert.ToInt32(Console.ReadLine());

     bool esPrimo = VerificarPrimo(numero);

     if (esPrimo)
     {
      Console.WriteLine(numero + " es un número primo.");
     }
     else
     {
      Console.WriteLine(numero + " no es un número primo.");
     }
	}
    static bool VerificarPrimo(int n)
    {
     if (n <= 1)
     {
      return false;
     }

      for (int i = 2; i <= Math.Sqrt(n); i++)
      {
       if (n % i == 0)
       {
        return false;
       }
      }
        
      return true;
    }
}
/*/

/*/
//6)
public static class Program
{
	public static void Main()
	{
    Console.WriteLine("Por favor, introduce una cadena de texto:");
     string texto = Console.ReadLine();

     string textoInvertido = InvertirCadena(texto);

     Console.WriteLine("La cadena invertida es: " + textoInvertido);
    }

    static string InvertirCadena(string cadena)
    {
     char[] caracteres = cadena.ToCharArray();
     Array.Reverse(caracteres);
     return new string(caracteres);
    }
}
/*/
/*/
//7)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Por favor, introduce el número inicial del rango:");
     int inicio = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Ahora, introduce el número final del rango:");
     int fin = Convert.ToInt32(Console.ReadLine());

     int sumaPares = SumarNumerosParesEnRango(inicio, fin);

     Console.WriteLine("La suma de los números pares en el rango [" + inicio + ", " + fin + "] es: " + sumaPares);
    }
    static int SumarNumerosParesEnRango(int inicio, int fin)
    {
     int suma = 0;
     for (int i = inicio; i <= fin; i++)
     {
      if (i % 2 == 0)
      {
       suma += i;
      }
     }
     return suma;
    }
}
/*/

/*/
//8)
public static class Program
{
 public static void Main()	
 {
  int[] cuadrados = new int[10];

  Console.WriteLine("Cuadrados de los primeros 10 números naturales:");

  for (int i = 1; i <= 10; i++)
  {
   int cuadrado = i * i;
   cuadrados[i - 1] = cuadrado;
   Console.WriteLine(cuadrado);
  }
 }
}
/*/

/*/
//9
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Por favor, introduce una cadena de texto:");
     string texto = Console.ReadLine();

     int contadorVocales = ContarVocales(texto);

     Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);
    }
    static int ContarVocales(string cadena)
    {
     int contador = 0;
     foreach (char caracter in cadena)
     {
      if (EsVocal(caracter))
      {
       contador++;
      }
     }
     return contador;
    }
    static bool EsVocal(char caracter)
    {
     switch (char.ToLower(caracter))
     {
      case 'a':
      case 'e':
      case 'i':
      case 'o':
      case 'u':
      return true;
      default:
      return false;
     }
	}
}
/*/
/*/
//10)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Los primeros 10 números de la serie Fibonacci son:");
     for (int i = 0; i < 10; i++)
     {
      Console.WriteLine(Fibonacci(i));
     }
    }
     static int Fibonacci(int n)
    {
     if (n <= 1)
     {
      return n;
     }
      else
     {
      int a = 0;
      int b = 1;
      int temp = 0;
      for (int i = 2; i <= n; i++)
      {
       temp = a + b;
       a = b;
       b = temp;
      }
      return b;
     }
    }
}
/*/

/*/
//11)
public static class Program
{
	public static void Main()
	{
     Console.WriteLine("Ingrese la cantidad de números que desea ordenar:");
     int cantidadNumeros = int.Parse(Console.ReadLine());

     int[] numeros = new int[cantidadNumeros];

     Console.WriteLine("Ingrese los números uno por uno:");

     for (int i = 0; i < cantidadNumeros; i++)
     {
      numeros[i] = int.Parse(Console.ReadLine());
     }

     OrdenarNumeros(numeros);

     Console.WriteLine("Lista ordenada de menor a mayor:");
     foreach (int num in numeros)
     {
      Console.WriteLine(num);
     }
    }
     static void OrdenarNumeros(int[] array)
    {
     for (int i = 0; i < array.Length - 1; i++)
     {
      int indiceMenor = i;
      for (int j = i + 1; j < array.Length; j++)
      {
       if (array[j] < array[indiceMenor])
       {
        indiceMenor = j;
       }
      }
       if (indiceMenor != i)
       {
        int temp = array[i];
        array[i] = array[indiceMenor];
        array[indiceMenor] = temp;
       }
     }
    }
}
/*/

/*/
//12)
public static class Program
{
 public static void Main()
 {
  Console.WriteLine("Por favor, introduce una palabra para verificar si es un palíndromo:");
  string palabra = Console.ReadLine();

  if (EsPalindromo(palabra))
  {
   Console.WriteLine("La palabra '" + palabra + "' es un palíndromo.");
  }
   else
  {
   Console.WriteLine("La palabra '" + palabra + "' no es un palíndromo.");
  }  
 }
 static bool EsPalindromo(string palabra)
 {
  int longitud = palabra.Length;
  for (int i = 0; i < longitud / 2; i++)	
  {
   if (palabra[i] != palabra[longitud - i - 1])
   {
    return false;
   }
  }
  return true;
  }
}
  
/*/

/*/
//13)
public static class Program
{
 public static void Main()
 {
  Console.WriteLine("Por favor, introduce un número para generar su tabla de multiplicar:");
  int numero = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Tabla de multiplicar de " + numero + ":");

  for (int i = 1; i <= 10; i++)
  {
   Console.WriteLine(numero + " x " + i + " = " + (numero * i));
  }
 }
}
/*/

/*/
//14)
public static class Program
{
 public static void Main()
 {
  Console.WriteLine("Por favor, introduce el radio del círculo:");
  double radio = Convert.ToDouble(Console.ReadLine());

  double area = CalcularAreaCirculo(radio);

  Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
 }

 static double CalcularAreaCirculo(double radio)
 {
  return Math.PI * Math.Pow(radio, 2);
 }
}
/*/

/*/
//15)
public static class Program
{
 public static void Main()
 {
  Console.WriteLine("Por favor, introduce un número entero:");
  int numero = Convert.ToInt32(Console.ReadLine());

  int sumaDigitos = CalcularSumaDigitos(numero);

  Console.WriteLine("La suma de los dígitos de " + numero + " es: " + sumaDigitos);
 }
 static int CalcularSumaDigitos(int numero)
 {
  int suma = 0;
  while (numero != 0)
  {
   suma += numero % 10;
   numero /= 10;
  }
  return suma;
 }
}
  
/*/




     
