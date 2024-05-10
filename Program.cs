using System;
using System.Linq;

namespace Laboratorio4;

// recursividad
/*
//1)
public static class Program
{
    static void Main(string[] args)
    {
        PrintNumbers(1);
    }

    static void PrintNumbers(int n)
    {
        if (n <= 100)
        {
            Console.WriteLine(n);
            PrintNumbers(n + 1);
        }
	}
}
/*/

/*/
//2)
public static class Program
{
    static void Main(string[] args)
    {
     int n = 10; // Cambia este valor por el número hasta el cual quieres calcular la suma
     Console.WriteLine("La suma de los números del 1 al " + n + " es: " + SumNumbers(n));
    }

    static int SumNumbers(int n)
    {
     if (n == 1)
     {
       return 1;
     }
       else
       {
         return n + SumNumbers(n - 1);
       }
    }
}
/*/

/*/
//3)
public static class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Cambia este valor por el número de filas de la pirámide
        PrintPyramid(n, 1);
    }

    static void PrintPyramid(int n, int current)
    {
        if (current <= n)
        {
            PrintNumbers(current);
            Console.WriteLine(); // Salto de línea para pasar a la siguiente fila
            PrintPyramid(n, current + 1);
        }
    }

    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            PrintNumbers(n - 1);
            Console.Write(n + " ");
        }
	}
}
/*/

/*/
//4)
public static class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Cambia este valor por el número de filas de la pirámide
        PrintInvertedPyramid(n, n);
    }

    static void PrintInvertedPyramid(int n, int current)
    {
        if (current > 0)
        {
            PrintNumbers(current);
            Console.WriteLine(); // Salto de línea para pasar a la siguiente fila
            PrintInvertedPyramid(n, current - 1);
        }
    }

    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }
	}
}
/*/

/*/
//5)
public static class Program
{
    static void Main(string[] args)
    {
        int n = 6; // Cambia este valor por el número del cual quieres imprimir la tabla de multiplicar
        PrintMultiplicationTable(n, 0);
    }

    static void PrintMultiplicationTable(int n, int multiplier)
    {
        if (multiplier <= 12)
        {
            Console.WriteLine(n + " x " + multiplier + " = " + (n * multiplier));
            PrintMultiplicationTable(n, multiplier + 1);
        }
	}
}
/*/

/*/
//Arreglos y Matrices
//6)

class Program
{
    static void Main()
    {
        // Definir el tamaño de la matriz
        int filas = 3;
        int columnas = 4;

        // Crear la matriz
        double[,] matriz = new double[filas, columnas];

       // Asignar valores a la matriz
        matriz[0, 0] = 1.1;
        matriz[0, 1] = 2.2;
        matriz[0, 2] = 3.3;
        matriz[0, 3] = 4.4;
        matriz[1, 0] = 5.5;
        matriz[1, 1] = 6.6;
        matriz[1, 2] = 7.7;
        matriz[1, 3] = 8.8;
        matriz[2, 0] = 9.9;
        matriz[2, 1] = 10.10;
        matriz[2, 2] = 11.11;
        matriz[2, 3] = 12.12;

        // Imprimir la matriz
        Console.WriteLine("Matriz:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
/*/

/*/
//7)

struct NumeroComplejo
{
    public double Real { get; }
    public double Imaginario { get; }

    public NumeroComplejo(double real, double imaginario)
    {
        Real = real;
        Imaginario = imaginario;
    }

    public override string ToString()
    {
        if (Imaginario >= 0)
            return $"{Real} + {Imaginario}i";
        else
            return $"{Real} - {-Imaginario}i";
    }
}

class Program
{
    static void Main()
    {
        NumeroComplejo[,] matriz = new NumeroComplejo[,]
        {
            { new NumeroComplejo(1, 2), new NumeroComplejo(3, 4), new NumeroComplejo(5, 6) },
            { new NumeroComplejo(7, 8), new NumeroComplejo(9, 10), new NumeroComplejo(11, 12) },
            { new NumeroComplejo(13, 14), new NumeroComplejo(15, 16), new NumeroComplejo(17, 18) }
        };

        // Ejemplo de acceso a un elemento de la matriz
        Console.WriteLine("Elemento en la fila 1, columna 2: " + matriz[0, 1]);
    }
}
/*/

/*/
//8
class Program
{
    static void Main()
    {
        int[][][] matrizDeMatrices = new int[][][]
        {
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            },
            new int[][]
            {
                new int[] { 7, 8, 9 },
                new int[] { 10, 11, 12 },
                new int[] { 13, 14, 15 }
            }
        };

        // Acceder a un elemento de la matriz
        Console.WriteLine("Elemento en la fila 0, columna 1, fila interna 1, columna 2: " + matrizDeMatrices[0][1][2]);
    }
}
/*/

/*/
//9)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Calcular los índices del elemento central
        int filaCentral = filas / 2;
        int columnaCentral = columnas / 2;

        // Acceder al elemento central
        int elementoCentral = matriz[filaCentral, columnaCentral];

        Console.WriteLine("Elemento central de la matriz: " + elementoCentral);
    }
}
/*/
/*/

//10)
class Program
{
    static void Main()
    {
        // Definir dos matrices de diferentes tamaños
        int[,] matriz1 = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
			{ 5, 7, 1 }
        };

        int[,] matriz2 = new int[,]
        {
            { 7, 8, 9 },
            { 10, 11, 12 },
            { 13, 14, 15 }
        };

        // Verificar si las matrices tienen las mismas dimensiones
        if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            Console.WriteLine("No se pueden sumar las matrices porque tienen dimensiones diferentes.");
            return;
        }

        // Sumar las matrices
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        int[,] suma = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Mostrar la matriz resultante
        Console.WriteLine("Matriz resultante de la suma:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(suma[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

/*/
/*/
//11)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int numero = 2; // El número por el cual multiplicar la matriz

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Multiplicar la matriz por el número
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] *= numero;
            }
        }

        // Mostrar la matriz resultante
        Console.WriteLine("Matriz resultante de la multiplicación por " + numero + ":");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
/*/

/*/
//12)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int medida = CalcularMedida(matriz);

        Console.WriteLine("La medida de los elementos de la matriz es: " + medida);
    }

    static int CalcularMedida(int[,] matriz)
    {
        int medida = 0;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                medida += matriz[i, j];
            }
        }

        return medida;
    }
}
/*/

/*/
// Matrices
//1)

class Program
{
    static void Main()
    {
        int filas = 100;
        int columnas = 100;

        int[,] matriz = CrearMatrizAleatoria(filas, columnas);

        // Solo se mostrará una porción de la matriz para evitar saturar la consola
        MostrarMatriz(matriz, 5, 5);
    }

    static int[,] CrearMatrizAleatoria(int filas, int columnas)
    {
        Random rnd = new Random();
        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(100); // Generar números aleatorios entre 0 y 99
            }
        }

        return matriz;
    }

    static void MostrarMatriz(int[,] matriz, int filasMostrar, int columnasMostrar)
    {
        for (int i = 0; i < filasMostrar; i++)
        {
            for (int j = 0; j < columnasMostrar; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
/*/ 
 
/*/
//2)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        double media = CalcularMedia(matriz);
        double mediana = CalcularMediana(matriz);
        double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);

        Console.WriteLine("Media de los elementos: " + media);
        Console.WriteLine("Mediana de los elementos: " + mediana);
        Console.WriteLine("Desviación estándar de los elementos: " + desviacionEstandar);
    }

    static double CalcularMedia(int[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        int suma = 0;

        foreach (int elemento in matriz)
        {
            suma += elemento;
        }

        return (double)suma / totalElementos;
    }

    static double CalcularMediana(int[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        int[] elementosOrdenados = new int[totalElementos];
        int index = 0;

        foreach (int elemento in matriz)
        {
            elementosOrdenados[index] = elemento;
            index++;
        }

        Array.Sort(elementosOrdenados);

        if (totalElementos % 2 == 0)
        {
            // Si el número total de elementos es par, la mediana es el promedio de los dos valores centrales
            int medio1 = elementosOrdenados[totalElementos / 2 - 1];
            int medio2 = elementosOrdenados[totalElementos / 2];
            return (double)(medio1 + medio2) / 2;
        }
        else
        {
            // Si el número total de elementos es impar, la mediana es el valor central
            return elementosOrdenados[totalElementos / 2];
        }
    }

    static double CalcularDesviacionEstandar(int[,] matriz, double media)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        double sumaCuadrados = 0;

        foreach (int elemento in matriz)
        {
            sumaCuadrados += Math.Pow(elemento - media, 2);
        }

        double varianza = sumaCuadrados / totalElementos;
        return Math.Sqrt(varianza);
    }
}
/*/

/*/
//3)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 9, 6 },
            { 7, 8, 5 }
        };

        int maximo = EncontrarMaximo(matriz);

        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = int.MinValue;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }

        return maximo;
    }
}

/*/
 
/*/
//4)
class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, 2, -1, -4, -20 },
            { -8, -3, 4, 2, 1 },
            { 3, 8, 10, 1, 3 },
            { -4, -1, 1, 7, -6 }
        };

        int sumaMaxima;
        int[,] submatriz = EncontrarSubmatrizDeMayorSuma(matriz, out sumaMaxima);

        Console.WriteLine("La submatriz de mayor suma es:");
        MostrarMatriz(submatriz);

        Console.WriteLine("La suma máxima es: " + sumaMaxima);
    }

    static int[,] EncontrarSubmatrizDeMayorSuma(int[,] matriz, out int sumaMaxima)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Inicializar variables para mantener el resultado
        int maxSuma = int.MinValue;
        int[,] submatrizResultante = new int[2, 2];

        for (int izq = 0; izq < columnas; izq++)
        {
            int[] temp = new int[filas];

            for (int der = izq; der < columnas; der++)
            {
                // Acumular las sumas de cada columna desde izq hasta der
                for (int i = 0; i < filas; i++)
                {
                    temp[i] += matriz[i, der];
                }

                // Encontrar la máxima suma de subarreglo unidimensional
                int sumaActual = temp[0];
                int sumaInicio = 0;
                int filaInicio = 0;

                for (int i = 1; i < filas; i++)
                {
                    if (temp[i] > temp[i] + sumaActual)
                    {
                        sumaActual = temp[i];
                        sumaInicio = i;
                    }
                    else
                    {
                        sumaActual += temp[i];
                    }

                    // Actualizar la submatriz de mayor suma si es necesario
                    if (sumaActual > maxSuma)
                    {
                        maxSuma = sumaActual;
                        submatrizResultante[0, 0] = sumaInicio;
                        submatrizResultante[1, 0] = i;
                        submatrizResultante[0, 1] = izq;
                        submatrizResultante[1, 1] = der;
                    }
                }
            }
        }

        // Calcular la suma máxima de la submatriz
        sumaMaxima = maxSuma;
        return ObtenerSubmatriz(matriz, submatrizResultante);
    }

    static int[,] ObtenerSubmatriz(int[,] matriz, int[,] indices)
    {
        int filaInicio = indices[0, 0];
        int filaFin = indices[1, 0];
        int columnaInicio = indices[0, 1];
        int columnaFin = indices[1, 1];

        int filasSubmatriz = filaFin - filaInicio + 1;
        int columnasSubmatriz = columnaFin - columnaInicio + 1;

        int[,] submatriz = new int[filasSubmatriz, columnasSubmatriz];

        for (int i = 0; i < filasSubmatriz; i++)
        {
            for (int j = 0; j < columnasSubmatriz; j++)
            {
                submatriz[i, j] = matriz[filaInicio + i, columnaInicio + j];
            }
        }

        return submatriz;
    }

    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
/*/


//5)

class Program
{
    static void Main()
    {
        double[,] matriz1 = new double[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double[,] matriz2 = new double[,]
        {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);

        Console.WriteLine("Matriz de covarianza:");
        MostrarMatriz(matrizCovarianza);
    }

    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        // Verificar si las matrices tienen las mismas dimensiones
        if (filas != matriz2.GetLength(0) || columnas != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
        }

        // Calcular la media de cada matriz
        double mediaMatriz1 = CalcularMedia(matriz1);
        double mediaMatriz2 = CalcularMedia(matriz2);

        // Calcular la matriz de covarianza
        double[,] matrizCovarianza = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizCovarianza[i, j] = ((matriz1[i, j] - mediaMatriz1) * (matriz2[i, j] - mediaMatriz2)) / (filas * columnas);
            }
        }

        return matrizCovarianza;
    }

    static double CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double suma = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        return suma / (filas * columnas);
    }

    static void MostrarMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
} 
