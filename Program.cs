using System;
using System.Linq;

namespace Ttabajo_lab3;
/*
//1)
public static class Program
{
	public static void Main()
	{
     double d, v, t;
     Console.Write("ingrese la velocidad constante: ");
     v = int.Parse(Console.ReadLine());
	 Console.Write("ingrese el tiempo : ");
	 t = int.Parse(Console.ReadLine()); 
	 d = v * t;
     Console.Write("la distancia es: {0}", d);
	 Console.ReadLine();


	}
}
/*/
/*
//2)
public static class Program
{
	public static void Main()
	{
     double n1, n2, n3, p;
     Console.Write("primera nota parcial: ");
     n1 = int.Parse(Console.ReadLine());
     Console.Write("segunda nota parcial: ");
     n2 = int.Parse(Console.ReadLine());
     Console.Write("tercera nota parcial: ");
	 n3 = int.Parse(Console.ReadLine());
	 p = (n1 + n2 + n3) / 3;
     Console.Write("promedio final:{0}", p);
     Console.ReadLine();

    }
}

/*/
/*
//3)
public static class Program
{
	public static void Main()
	{
     double pf, rc, ri, rb, prc, pri;
     Console.Write("ingrese número de respuestas correctas: ");
     rc = int.Parse(Console.ReadLine());
     Console.Write("ingrese número de respuestas incorrectas: ");
     ri = int.Parse(Console.ReadLine());
     Console.Write("ingrese número de respuestas en blanco: ");
     rb = int.Parse(Console.ReadLine());
     prc = rc * 4;
     Console.WriteLine("puntaje de respuestas correctas:| {0} |", prc);
     pri = ri * -1;
     Console.WriteLine("puntaje de respuestas en blanco:| {0} |", pri);
     pf = prc + pri;
     Console.WriteLine("promedio final:| {0} |", pf);
     Console.ReadLine();

    }
}
/*/ 
/*
//4)
public static class Program
{
	public static void Main()
	{
     double pt, pg, pe, pp, ppg, ppe;
     Console.Write("ingrese número de partidos ganados: ");
     pg = int.Parse(Console.ReadLine());
     Console.Write("ingrese número de partidos empatados: ");
     pe = int.Parse(Console.ReadLine());
     Console.Write("ingrese número de partidos perdidos: ");
     pp = int.Parse(Console.ReadLine());
     ppg = pg * 3;
     Console.WriteLine("->puntaje de partidos ganados:|{0}|", ppg);
     ppe = pe * 1;
     Console.WriteLine("->puntaje de partidos empatados:|{0}|", ppe);
     pt = ppg + ppe;
     Console.WriteLine("->puntaje total:|{0}|", pt);
     Console.ReadLine();

	        
    }
}
/*/
/*
//5)
public static class Program
{
	public static void Main()
	{
     double p, hl, th;
     Console.Write("número de horas laboradas en el mes: ");
     hl = int.Parse(Console.ReadLine()); 
	 Console.Write("tarifa por hora: ");
	 th = int.Parse(Console.ReadLine());
	 p = hl * th;
     Console.Write("planilla:|{0}|", p);
     Console.ReadLine();		
    }
}
/*/
/*
//6)
public static class Program
{
	public static void Main()
	{
     int at, la, lb, lc, ls;
     Console.Write("longitud del lado a:| ");
     la = int.Parse(Console.ReadLine());
     Console.Write("longitud del lado b:| ");
     lb = int.Parse(Console.ReadLine());
     Console.Write("longitud del lado c:| ");
	 lc = int.Parse(Console.ReadLine());
     ls = (la + lb + lc) / 2;
     Console.Write("longitud del semiperimetro:|{0}|", ls);
     at = (ls*(ls-la)*(ls-lb)*(ls-lc)) ^ 1;
     Console.Write(" area del triangular:|{0}|",at);
     Console.ReadLine();		
    }
}
/*/
/*
//7)
public static class Program
{
	public static void Main()
	{
     double cd, gb, mg;
     Console.Write("ingrese número de Gigabytes del disco duro:| "); 
	 gb = int.Parse(Console.ReadLine());
     mg = gb * 1.024;
     Console.WriteLine("->número de megabytes del disco duro:|{0}|", mg);
	 cd = ((mg / 700) + 1);
     Console.WriteLine("->número de CD:|{0}|", cd);
	 Console.ReadLine();		
    }
}
/*/
/*
//8)
public static class Program
{
	public static void Main()
	{
     int aa, ab, oa, ob, d;
     Console.Write("ingrese la abscisa de A: "); aa = int.Parse(Console.ReadLine()); Console.Write("ingrese la abscisa B: "); ab = int.Parse(Console.ReadLine()); Console.Write("ingrese ordenada A: "); oa = int.Parse(Console.ReadLine()); Console.Write("ingrese ordenada B: "); ob = int.Parse(Console.ReadLine()); d = ((ab - aa) ^ 2 + (ob - oa) ^ 2) ^ 1;
     Console.Write("la distancia de A y B es: {0}",d); Console.ReadLine();
    }
}

/*
//9)
public static class Program
{
	public static void Main()
	{	
     int an, aa, e;
     Console.Write("ingrese el año de nacimiento:| ");
     an = int.Parse(Console.ReadLine());
	 Console.Write("ingrese año actual:| ");
	 aa = int.Parse(Console.ReadLine());
	 e = aa - an;
	 Console.WriteLine("edad:|{0}|", e);
	 if (e > 17)
     Console.WriteLine("->debe solicitar su DNI”, e);
	 else
     Console.WriteLine("->no debe solicitar su DNI”, e);
	 Console.ReadLine();
    }
}
/*/
/*
//10)
public static class Program
{
	public static void Main()
	{
     int e1, e2, de;
     Console.Write("ingrese edad del primer hermano:| "); e1 = int.Parse(Console.ReadLine());
     Console.Write("ingrese edad del segundo hermano:| "); e2 = int.Parse(Console.ReadLine());
     if (e1 > e2)
     Console.WriteLine("el primer hermano es Mayor, por:|{0}| años", de = e1 - e2); else
     Console.WriteLine("el segundo hermano es Mayor, por:|{0}| años", de = e2 - e1); Console.ReadLine();
    }
}
/*/
/*
//11)
public static class Program
{
	public static void Main()
	{				
     int pl, pma, pmi, pj, pv, ps, pt, pp;
     Console.Write("ingrese producción del día lunes:| "); pl = int.Parse(Console.ReadLine());
     Console.Write("ingrese producción del día martes:| "); pma = int.Parse(Console.ReadLine());
     Console.Write("ingrese producción del día miércoles:| "); pmi = int.Parse(Console.ReadLine());
     Console.Write("ingrese producción del día jueves:| "); pj = int.Parse(Console.ReadLine());
     Console.Write("ingrese producción del día viernes:| "); pv = int.Parse(Console.ReadLine());
     Console.Write("ingrese producción del día sábado:| "); ps = int.Parse(Console.ReadLine()); pt = (pl + pma + pmi + pj + pv + ps);
     Console.WriteLine("->la producción total es:|{0}|", pt); pp = pt / 6;
     Console.WriteLine("->la producción promedia es:|{0}|", pp); if (pp >= 100)
     Console.WriteLine("-|recibirá incentivos|-"); else
     Console.WriteLine("-|no recibirá incentivos|-"); Console.ReadLine();
    }
}
/*/
/*
//12)
public static class Program
{
	public static void Main()
	{
     int n1, n2, n3, mn;
     Console.Write("ingrese primer número entero:| "); n1 = int.Parse(Console.ReadLine());
     Console.Write("ingrese segundo numero entero:| "); n2 = int.Parse(Console.ReadLine());
     Console.Write("ingrese tercer numero entero:| "); n3 = int.Parse(Console.ReadLine()); if (n1 > n2 && n1 > n3)
     Console.Write("->número mayor es:|{0}|", mn = n1); else if (n2 > n3)
     Console.Write("->número mayor es:|{0}|", mn = n2); else
     Console.Write("->número mayor es:|{0}|", mn = n3);
     Console.ReadLine();
	}
}
/*/
/*
//13)
public static class Program
{
	public static void Main()
	{
     double l1, l2, l3;
     Console.Write("ingrese el primer lado:| "); l1 = int.Parse(Console.ReadLine()); Console.Write("ingrese el segundo lado:| "); l2 = int.Parse(Console.ReadLine()); Console.Write("ingrese el tercer lado:| "); l3 = int.Parse(Console.ReadLine()); if (l1 < l2 && l2 < l3 && l3 > l1)
     Console.Write("tipo de triangulo |escaleno|"); else if (l1 == l2 && l2 == l3)
     Console.Write("tipo de triangulo |equilátero|"); else
     Console.Write("tipo de triangulo |isósceles|"); Console.ReadLine();
    }
}
/*/
/*
//14)
public static class Program
{
	public static void Main()
	{
     int ne;
     Console.Write("ingrese numero entero de 1 a 10:| "); ne = int.Parse(Console.ReadLine()); switch (ne)
     { 
      case (1):
      Console.Write("el numero entero |{0}| en romano es:|I|", ne); break;
      case (2):
      Console.Write("el numero entero |{0}| en romano es:|II|", ne); break;
      case (3):
      Console.Write("el numero entero |{0}| en romano es:|III|", ne); break;
      case (4):
      Console.Write("el numero entero |{0}| en romano es:|IV|", ne); break;
      case (5):
      Console.Write("el numero entero |{0}| en romano es:|V|", ne); break;
      case (6):
      Console.Write("el numero entero |{0}| en romano es:|VI", ne); break;
      case (7):
      Console.Write("el numero entero |{0}| en romano es:|VII|", ne); break;
      case (8):
      Console.Write("el numero entero |{0}| en romano es:|VIII|", ne); break;
      case (9):
      Console.Write("el numero entero |{0}| en romano es:|IX|", ne); break; case (10):
      Console.Write("el numero entero |{0}| en romano es:|X|", ne); break;
      default:
      Console.Write("|valor incorrecto|"); break;
     }
     Console.ReadLine();
	}
}
/*/
/*
//15)
public static class Program
{
	public static void Main()
	{
     Monto 	Bonificación (%)
 	0 - 1000 	0
 	1000 - 5000 	3
 	5000 - 20000 	5
 	20000 a mas 	8
     double tb, mv;
     Console.Write("ingrese monto de venta: "); mv = Convert.ToInt32(Console.ReadLine());
     if(mv >= 0 && mv < 100)
     Console.Write("total de bonificación es: {0}", tb = (0 * mv) / 100); else if(mv >= 1000 && mv < 5000)
     Console.Write("total de bonificación es: {0}", tb = (3 * mv) / 100); else if(mv >= 5000 && mv < 20000)
     Console.Write("total de bonificación es: {0}", tb = (5 * mv) / 100); else if (mv >= 20000)
     Console.Write("total de bonificación es: {0}", tb = (8 * mv) / 100); Console.ReadLine();
     }
}
/*/
/*
//16)
public static class Program
{
	public static void Main()
	{
     Console.Write("ingrese numero entero:| "); int ne = int.Parse(Console.ReadLine()); switch (ne)
     { 
      case (1):
      Console.Write(" |A| "); break;
      case (2):
      Console.Write(" |E| "); break;
      case (3):
      Console.Write(" |I| "); break;
      case (4):
      Console.Write(" |O| "); break;
      case (5):
      Console.Write(" |U| "); break;
      default:
      Console.Write("|valor incorrecto|"); break;
     }
	 Console.ReadLine();
	}
}
/*/
/*
//17)
public static class Program
{
	public static void Main()
	{
     int d, u, ne, q, r;
     Console.Write("ingrese numero entero de 2 dígitos:| "); ne = int.Parse(Console.ReadLine()); q = (ne / 10);
     Console.WriteLine("=cociente entero: |{0}| ", q); r = ne - (q * 10);
     Console.WriteLine("=residuo: |{0}| ", r); d = q;
     Console.WriteLine("->número de decenas: |{0}| ", d); u = r;
     Console.WriteLine("->número de unidades: |{0}| ", u);
     Console.ReadLine();
	}
}
/*/
/*
//18)
public static class Program
{
	public static void Main()
	{
     int ne, r, q;
     Console.Write("ingrese un numero entero:| "); ne = int.Parse(Console.ReadLine());
     q = ne / 2;
     Console.WriteLine("cociente entero: |{0}| ", q); r = ne - (q * 2);
     Console.WriteLine("residuo: |{0}| ", r); if (r == 0)
     Console.WriteLine("|--ES PAR--|"); else
     Console.WriteLine("|--ES IMPAR--|"); Console.ReadLine();
    }
}
/*/
/*
//19)
public static class Program
{
	public static void Main()
	{
     int n = 0;
     Console.WriteLine("||números pares entre 1 y 10||"); for (n = 2; n <= 10; n = n + 2)
     {
      Console.WriteLine(n);
     }
     Console.ReadLine();
	}
}
/*/
/*
//20)
public static class Program
{
	public static void Main()
	{
     int se, ne, ss=0, sp, k;
     Console.WriteLine("ingrese sueldo del empleado: "); se = int.Parse(Console.ReadLine());
     Console.WriteLine("ingrese número de empleados: "); ne = int.Parse(Console.ReadLine()); for (k = 1; k <= ne; k++)
     { ss = ne * se;
      Console.WriteLine("suma de sueldo: {0}", ss); sp = ss / ne;
      Console.WriteLine("-->sueldo promedio es :{0}", sp);
     }
     Console.ReadLine();
	}
}
/*/
/*
//21)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); int num, resto; num = azar.Next(1, 1000);
     Console.WriteLine("numero:{0}", num); resto = num % 3; if (resto == 0)
     Console.WriteLine("{0} es múltiplo de 3", num); else
     Console.WriteLine("{0} no es múltiplo de 3", num); Console.ReadLine();
    }
}
/*/
/*
//22)
public static class Program
{
	public static void Main()
	{
     int num;
     Console.Write("ingrese número"); num = int.Parse(Console.ReadLine()); if (num > 500)
     {
      Console.Write("{0} es mayor de 500", num);
     } else
     {
     Console.Write("{0} es menor o igual a 500", num);
     }
     Console.ReadKey();
	}
}
/*/
/*
//23)
public static class Program
{
	public static void Main()
	{
     int num, apuesta, ganancia, nazar;
     Random azar = new Random();
     Console.Write("Ingrese el Numero Ganador(1 a 20):");
     num = int.Parse(Console.ReadLine()); Console.Write("ingrese apuesta:"); apuesta = int.Parse(Console.ReadLine());
     nazar = azar.Next(1, 20);
     Console.WriteLine("Numero lotería: {0}", nazar); if (num == nazar)
     { ganancia = apuesta * 100;
      Console.WriteLine("ganaste{0} soles", ganancia);
     } else
     Console.WriteLine("perdiste{0} soles", apuesta); Console.ReadLine();
    }
}
/*/
/*
//24)
public static class Program
{
	public static void Main()
	{
     Console.Write("salió uno"); else if(dado==2)
     Console.Write("salió dos"); else if(dado==3)
     Console.Write("salió tres"); else if(dado==4)
     Console.Write("salió cuatro"); else if(dado==5)
     Console.Write("salió cinco"); else if(dado==6)
     Console.Write("salió seis");
     Console.ReadLine();
	}
}
/*/
/*
//25)
public static class Program
{
	public static void Main()
	{
     string nombre;
     int nota1,nota2,promedio;
     Console.WriteLine("ingrese alumno:"); nombre =Console.ReadLine();
     Console.Write("ingrese nota1:"); nota1 =int.Parse(Console.ReadLine());
     Console.Write("ingrese nota2:"); nota2 =int.Parse(Console.ReadLine());
     promedio=(int)Math.Ceiling((nota1+nota2)/2.0); if(promedio<13)
     Console.Write("Promedio {0},{1} mal alumno”, promedio, nombre); else if(promedio>=13 && promedio<=15)
     Console.Write("Promedio {0}, {1} regular alumno”, promedio, nombre); else if(promedio>=16 && promedio<=18)
     Console.Write("Promedio {0}, {1} buen alumno”, promedio, nombre); else if(promedio>=19 && promedio<=20)
     Console.Write("Promedio {0}, {1} excelente alumno”, promedio, nombre); Console.ReadLine();
    }
}
/*/
/*
//26)
public static class Program
{
	public static void Main()
	{
     string cliente, plato; int cantidad, pago;
     Console.Write("ingrese cliente:"); cliente =Console.ReadLine();
     Console.Write("ingrese plato a consumir:"); plato =Console.ReadLine();
     Console.Write("ingrese cantidad de platos:"); cantidad =int.Parse(Console.ReadLine()); if(pago=="chaufa")
     { pago=cantidad*7;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
     }
     else if(pago=="seco")
     { pago=cantidad*8;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
     } else if(pago=="estofado")
     { pago=cantidad*9;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
     } else if(pago=="ceviche")
     { pago=cantidad*12;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
     } else if(pago=="pachamanca")
     { pago=cantidad*25;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
     } else
     { pago=cantidad*10;
      Console.Write("{0} consumió {1} platos de {2} y su pago es {3} soles”, cliente,
      cantidad, plato, pago);
    }
     Console.ReadLine();
	}
}
/*/
/*
//27)
public static class Program
{
	public static void Main()
	{
     double minutos, costo, adicionales;
	 Console.Write("ingrese minutos:");
	 minutos = double.Parse(Console.ReadLine());
	 if (minutos <= 3)
	 { costo = 0.5;	
      Console.Write("Costo de llamada:{0}", costo);
     } else
	 { adicionales = minutos - 3; costo = 0.5 + adicionales * 0.2;
     Console.Write("Costo de llamada:{0}", costo);
     }
     Console.ReadLine();
	}
}
/*/
/*
//28)
public static class Program
{
	public static void Main()
	{
     int llantas, costo, adicionales;
	 Console.Write("ingrese llantas:");
	 llantas = int.Parse(Console.ReadLine());
     if (llantas <5)
     { 
      costo = llantas * 200;
  	Console.Write("Costo {0} llantas compradas	es {1} soles”,llantas, costo);
 	} 
	  else
      { 
       adicionales = llantas -4;
	   costo = 800 +adicionales*180;
   	Console.Write("Costo de {0} llantas compradas	es {1} soles”, llantas,costo);
      }
     Console.ReadLine();
    }
}
/*/
/*
//29)
public static class Program
{
	public static void Main()
	{
     String moneda,moneda1; int numero;
     Random azar=new Random();
     Console.Write("elegir cara o sello: "); moneda= Console.ReadLine(); numero=azar.Next(2); Console.WriteLine(numero); if (numero==0) moneda1 ="cara";
     else moneda1="sello";
     if(moneda1=="sello")
     Console.WriteLine("adivinaste salió {0}”, moneda1); else
     Console.WriteLine("no adivinaste salió {0}”, moneda1); Console.ReadLine();
    }
}
/*/
/*
//30)
public static class Program
{
	public static void Main()
	{
     String nombre; int jornal,días,dominical,salario; Console.Write("ingrese nombre: "); nombre=Console.ReadLine(); Console.Write("ingrese jornal: "); jornal=int.Parse(Console.ReadLine()); Console.Write("ingrese días trabajados: "); días =int.Parse(Console.ReadLine()); if(días>=6) dominical=jornal; else dominical=0;
     salario= jornal*días dominical;
     Console.WriteLine("dominical es {0}",dominical);
     Console.WriteLine("salario es {0}",salario); Console.ReadLine();
    }
}
/*/
/*
//31)
public static class Program
{
	public static void Main()
	{
     String artículo, color, color1=""; int cantidad, importe, precio, num; Console.WriteLine("ingrese importe: "); articulo = Console.ReadLine();
     Console.WriteLine("ingrese cantidad: ");
     cantidad = int.Parse(Console.ReadLine()); Console.WriteLine("ingrese precio: "); precio = int.Parse(Console.ReadLine()); Console.WriteLine("ingrese color: "); color = Console.ReadLine(); importe=precio*cantidad; Random azar=new Random(); num=azar.Next(1,3); if(num==1) color1="rojo";
     else if(num==2) color1="naranja";
     else if(num==3) color1="verde";
     if (color1 == "rojo")
     Console.Write("paga todo: {0}, salió {1}”, importe); else if(color1=="naranja")
     Console.Write("para el 50%: {0}, salió {1}”, importe/2); else if(color1=="verde")
     Console.Write("no paga nada: {0}, salió {1}”, importe*0); Console.ReadLine();
    }
}
/*/
/*
//32)
public static class Program
{
	public static void Main()
	{
     Console.Write("ingrese promedio: "); p = int.Parse(Console.ReadLine()); if (p >= 0 && p <= 5)
     { 
      r = "pesimo";
     }
     else if (p >= 6 && p <= 10)
     { 
      r = "malo";
     }
     else if (p >= 11 && p <= 15)
     { 
      r = "bueno";
     }
     else if (p >= 16 && p <= 20)
     { 
      r = "excelente";
     }
     Console.WriteLine("tu promedio es: " + r); Console.ReadKey();
    }
}
/*/
/*
//33)
public static class Program
{
	public static void Main()
	{
     int c;
     string[] comidas = new string[4]; comidas[0] = "chaufa"; comidas[1] = "pollo a la brasa"; comidas[2] = "arroz con pollo"; comidas[3] = "chancho al palo";
     Console.Write("ingrese numero entre 0 y 3: ");
     c= int.Parse(Console.ReadLine());
     Console.WriteLine("tu plato favorito es: " + comidas[c]);
    //for (int i = 0; i < 4; i++)
    {
    //Console.WriteLine("tu plato favorito es: " +comidas[i]); }
     Console.ReadKey();
    }
}
/*/
/*
//34)
public static class Program
{
	public static void Main()
	{
     int total = 0;
     int[,] numeros = new int[3, 3];
     numeros[0, 0] = 10;
	 numeros[0, 1] = 20;
	 numeros[0, 2] = 30;
	 numeros[1, 0] = 40;
	 numeros[1, 1] = 50;
	 numeros[1, 2] = 60;
	 numeros[2, 0] = 70; 
	 numeros[2, 1] = 80; 
	 numeros[2, 2] = 90; 
	 for (int f = 0; f < 3; 
	 f++){ for (int c = 0; c < 3; 
	 c++){ total = total + numeros[f, c];
     Console.WriteLine("el numeros es: " + numeros[f, c]); }}
     Console.Write("la suma total es: " + total); Console.ReadKey();
	}
}
/*/
/*
//35)
public static class Program
{
	public static void Main()
	{
     string[,] anbac = new string[5, 5]; anbac[0, 0] = " |ted|"; anbac[0, 1] = " |spiderman|"; anbac[0, 2] = " |superman |"; anbac[0, 3] = " |batman|"; anbac[0, 4] = " |ironman|"; anbac[1, 0] = "----------rapidos y furiosos 1"; anbac[1, 1] = "----------rapidos y furiosos 2"; anbac[1, 2] = "----------rapidos y furiosos 3"; anbac[1, 3] = "----------rapidos y furiosos 4"; anbac[1, 4] = "----------rapidos y furiosos 5"; anbac[2, 0] = " |rapidos y furiosos 6 |"; anbac[2, 1] = " |rapidos y furiosos 7 |"; anbac[2, 2] = " |caino hacia el terror|"; anbac[2, 3] = " |orca|"; anbac[2, 4] = " |la llorona|"; anbac[3, 0] = "----------aro 1"; anbac[3, 1] = "----------aro2"; anbac[3, 2] = "----------bruce lee"; anbac[3, 3] = "----------viaje al universo"; anbac[3, 4] = "----------armagedon"; anbac[4, 0] = " |duende maldito|"; anbac[4, 1] = " |chuki|"; anbac[4, 2] = " |minions|"; anbac[4, 3] = " |mi villano favorito|"; anbac[4, 4] = " |fin del mundo|";
     //Console.WriteLine("tu pelicula es: "+ anbac[0, 0]);
     for (int f = 0; f < 5; f++)
     { 
      for (int c = 0; c < 5; c++)
      {
       Console.WriteLine(anbac[f,c]);
      }
     }
     Console.ReadKey();
	}
}
/*/
/*
//36)public static class Program
{
	public static void Main()
	{
     string nombre; int n;
     Random azar = new Random();
     Console.WriteLine("ingrese nombre: "); nombre = Console.ReadLine(); n = azar.Next(6); switch(n){ case 1:
     Console.WriteLine("peluche"); break;
     case 2:
     Console.WriteLine("pelota"); break;
     case 3:
     Console.WriteLine("calculadora"); break;
     case 4:
     Console.WriteLine("tablet"); break;
     case 5:
     Console.WriteLine("smartphone"); break;
     case 6:
     Console.WriteLine("laptop"); break;}
     Console.ReadKey();
	}
}
/*/
/*
//37)
public static class Program
{
	public static void Main()
	{
     int opcion;
     double base1, altura, area, lado, dmayor, dmenor; Console.WriteLine("menu de areas");
     Console.WriteLine("1.area de un rectangulo");
     Console.WriteLine("2. area de un triángulo");
     Console.WriteLine("3.area de un cuadrado");
     Console.WriteLine("4.area de un rombo"); Console.Write("elegir opcion: "); opcion=int.Parse(Console.ReadLine());
     if (opcion==1)
	 {
      Console.WriteLine("ingrese base: "); base1=double.Parse(Console.ReadLine()); Console.WriteLine("ingrese altura: "); altura=double.Parse(Console.ReadLine());
      area= base1*altura;
      Console.WriteLine("area rectangular es: {0}", area);
     }
	 else if(opcion==2)
	 {
     Console.WriteLine("ingrese base: "); base1=double.Parse(Console.ReadLine()); Console.WriteLine("ingrese altura: "); altura = double.Parse(Console.ReadLine()); area= base1*altura / 2;
     Console.WriteLine("area triangulo es: {0}", area);
     }
	 else if(opcion==3)
	 {
     Console.WriteLine("ingrese lado: "); lado=double.Parse(Console.ReadLine());
     area= lado*lado;
     Console.WriteLine("area del cuadrado es: {0}", area);
     }
	 else if(opcion==4)
	 {
     Console.WriteLine("ingrese dimencion menor: "); dmenor=double.Parse(Console.ReadLine()); Console.WriteLine("ingrese dimencion mayor: "); dmayor = double.Parse(Console.ReadLine()); area= dmenor*dmayor/2;
     Console.WriteLine("area del rombo es: {0}", area);}Console.ReadKey();
    }
}
/*/
/*
//38)
public static class Program
{
	public static void Main()
	{
     string nombre;
     Random azar = new Random();
     int num;
     Console.Write("ingrese nombre: "); nombre = Console.ReadLine(); num = azar.Next(4) + 1; switch (num)
     { 
      case 1:
      Console.Write("{0}@gmail.com", nombre); break;
      case 2:
      Console.Write("{0}@hotmail.com", nombre); break;
      case 3:
      Console.Write("{0}@yahoo.com", nombre); break;
      case 4:
      Console.Write("{0}@terra.com", nombre); break;
     }
     Console.ReadKey();
	}
}
/*/
/*
//39)
public static class Program
{
	public static void Main()
	{
     string lugar;
     Console.Write("ingrese lugar turistico: "); lugar = Console.ReadLine(); switch (lugar)
     { 
      case "machupicchu":
      Console.Write("{0} esta en el cusco", lugar); break;
      case "caral":
      Console.Write("{0} esta en el lima", lugar); break;
     //lo mismo para varios lugares turisticos... default:
      Console.Write("{0} no se donde esta", lugar); break;
     }
     Console.ReadKey();
	}
}
/*/
/*
//40)
public static class Program
{
	public static void Main()
	{
     int num, resto, ndigitos = 0, sdigitos = 0; Console.Write("ingrese numero entre 1 y 9:| "); num = int.Parse(Console.ReadLine()); while (num>0)
     { 
      resto = num % 10; ndigitos = ndigitos + 1; sdigitos = sdigitos + resto; num = (int)(num / 10);
     }
     Console.WriteLine("numero de digitos:|{0}|", ndigitos); Console.WriteLine("suma de digitos:|{0}|", sdigitos); Console.ReadKey();
    }
}
/*/
/*
//41)
public static class Program
{
	public static void Main()
	{	
     string articulo, rpta = "si";
     double precio, cantidad, total = 0, importe; while (rpta == "si")
     {
      Console.Write("ingrese aticulo: "); articulo = Console.ReadLine(); Console.Write("ingrese cantidad: "); cantidad = double.Parse(Console.ReadLine()); Console.Write("ingrese precio: "); precio = double.Parse(Console.ReadLine()); importe = precio * cantidad;
      Console.WriteLine("importe: {0} ", importe); total = total + importe;
      Console.Write("comprar otro articulo (si/no):| "); rpta = Console.ReadLine();
     }
     Console.WriteLine("total a pagar: {0}", total); Console.ReadKey();
    }
}
/*/
/*
//42)
public static class Program
{
	public static void Main()
	{
     int num, resto; string octal = "";
     Console.Write("ingrese numero:|"); num = int.Parse(Console.ReadLine());
	 while (num>0)
	 { resto = num % 8; octal = resto + octal; num = (int)(num / 8);
     }
     Console.WriteLine("octal: {0}", octal);
     Console.ReadKey();
    }
}
/*/
/*
//43)
public static class Program
{
	public static void Main()
	{
	 string[] datos = new string[3]; datos[0] = "A"; datos[1] = "B"; datos[2] = "C";
     for (int x = 0; x < datos.Length; x++)
	 { 
      Console.WriteLine(datos[x]);
     }
     Console.ReadKey();
	}
}
/*/
/*
//44)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); int[,] m1 = new int[2, 3];
     int f, c;
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 1!");
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 2; f++)
	 { 
      for (c = 0; c < 3; c++)
	  { 
       m1[f, c] = azar.Next(-5, 11);
	   Console.Write("\t{0}", m1[f, c]);
      }
     Console.WriteLine();
     } 
	  int escalar;
      int[,] mr = new int[2, 3];
      Console.WriteLine("---------------------------------");
      Console.Write("------ingrese constante o escalar>>>:");
	  Console.WriteLine("---------------------------------"); 
	  escalar = int.Parse(Console.ReadLine());
      Console.WriteLine("---------------------------------");
      Console.WriteLine("--elementos de la matriz escalar!"); 
	  Console.WriteLine("---------------------------------"); 
	  for (f = 0; f < 2; f++)
     { 
      for (c = 0; c < 3; c++)
      { 
       mr[f, c] = m1[f, c] * escalar; 
	   Console.Write("\t{0}", mr[f, c]);
      }
      Console.WriteLine(); 
 	}
     Console.ReadKey();
    }
}
/*/
/*
//45)
public static class Program
{
	public static void Main()
	{ 
     Random azar = new Random(); 
	 int[,] m1 = new int[3, 3]; 
	 int[,] m2 = new int[3, 3]; 
	 int[,] sumatriz = new int[3, 3];
     int f, c;
     //--------------------------------matriz 1
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 1!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (	f = 0; f < 3; f++)
	 { 
      for (c = 0; c < 3; c++)
	  { 
       m1[f, c] = azar.Next(-5, 11); 
	   Console.Write("\t{0}", m1[f, c]);
      }
     Console.WriteLine();
     }
      //--------------------------------matriz 2
      Console.WriteLine("---------------------------------");
      Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 2!"); 
	  Console.WriteLine("---------------------------------"); 
	  for (f = 0; f < 3; f++)
	  { 
       for (c = 0; c < 3; c++)
	   { 
        m2[f, c] = azar.Next(-5, 11);
	    Console.Write("\t{0}", m2[f, c]);
       }
      Console.WriteLine();
      }
      //--------------------------------sumatriz
      Console.WriteLine("---------------------------------");
      Console.WriteLine("--------ELEMENTOS DE LA SUMATRIZ!"); 
	  Console.WriteLine("---------------------------------"); 
	  for (f = 0; f < 3; f++)
	  { 
       for (c = 0; c < 3; c++)
	   { 
        sumatriz[f, c] = m1[f, c] + m2[f, c]; 
		Console.Write("\t{0}", sumatriz[f, c]);
       }
      Console.WriteLine(); 
	  }
     Console.ReadKey();
	}
}
/*/
/*
//46)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random();
	 int[,] m1 = new int[2, 4]; 
	 int[,] m2 = new int[2, 4]; 
	 int[,] restatriz = new int[2, 4];
     int f, c;
     //--------------------------------matriz 1
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 1!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 2; f++)
	 { 
      for (c = 0; c < 4; c++)
	  { 
       m1[f, c] = azar.Next(5, 11); 
	   Console.Write("\t{0}", m1[f, c]);
      }
     Console.WriteLine();
     }
	 //--------------------------------matriz 2
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 2!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 2; f++)
	 { 
      for (c = 0; c < 4; c++)
	  { 
       m2[f, c] = azar.Next(5, 11);
       Console.Write("\t{0}", m2[f, c]);
      }
     Console.WriteLine();
     }
     //--------------------------------sumatriz
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA RESTATRIZ!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 2; f++)
	 { 
      for (c = 0; c < 4; c++)
	  { 
       restatriz[f, c] = m1[f, c] - m2[f, c]; 
	   Console.Write("\t{0}", restatriz[f, c]);
      }
      Console.WriteLine();
     }
	 Console.ReadKey();
	}
}
/*/
/*
//47)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); int[,] m1 = new int[3, 2]; int[,] transpuesta = new int[2, 3]; int f, c;
     //--------------------------------matriz 1
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 1!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 3; f++)
	 { 
      for (c = 0; c < 2; c++)
	  { 
       m1[f, c] = azar.Next(5, 11);
	   Console.Write("\t{0}", m1[f, c]);
      }
     Console.WriteLine();
     }
     //-----------------------------transpuesta
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------------MATRIZ TRANSPUESTA!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 2; f++)
	 { 
      for (c = 0; c < 3; c++)
	  { 
       transpuesta[f,c] = m1[c,f];
       Console.Write("\t{0}", transpuesta[f, c]);
      }
     Console.WriteLine(); 
	 }
     Console.ReadKey();
	}
}
/*/
/*
//48)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); 
	 int[,] m1 = new int[4, 3]; 
	 int f, c, mayor = 0;
     Console.WriteLine("---------------------------------");
     Console.WriteLine("--------ELEMENTOS DE LA MATRIZ 1!"); 
	 Console.WriteLine("---------------------------------"); 
	 for (f = 0; f < 4; f++)
	 { 
      for (c = 0; c < 3; c++)
	  { 
       m1[f, c] = azar.Next(-5, 11); 
	   Console.Write("\t{0}", m1[f, c]);
      }
     Console.WriteLine();
     }
     for (f = 0; f < 4; f++)
	 { 
      for (c = 0; c < 3; c++)
	  { 
       if (m1[f, c] > mayor) mayor = m1[f, c];
      }
	 }
     Console.Write("elemento mayor es {0}", mayor);
     Console.ReadKey();
	}
}
/*/
/*
//49)
public static class Program
{
	public static void Main()
	{
     string elector, candidato;
     int x,vkeiko=0, vppk=0, vacuña=0, valan=0, vtoledo=0, votros = 0; 
	 for (x = 1; x <= 5; x++)
     {
      Console.Write("ingrese elector:"); 
	  elector = Console.ReadLine(); 
	  Console.Write("ingrese candidato:"); 
	  candidato = Console.ReadLine(); 
	  switch (candidato)
      { 
       case "keiko": vkeiko++; break;
       case "ppk": vppk++; break;
       case "acuña": vacuña++; break;
       case "alan": valan++; break;
       case "toledo": vtoledo++; break;
       default: votros++; break;
      }
     }
     Console.WriteLine("votos de keiko:{0}", vkeiko);
     Console.WriteLine("votos de ppk:{0}", vppk);
     Console.WriteLine("votos de acuña:{0}", vacuña);
     Console.WriteLine("votos de alan:{0}", valan);
     Console.WriteLine("votos de toledo:{0}", vtoledo);
     Console.WriteLine("votos de otros:{0}", votros); 
	 Console.ReadLine();
	}
}
/*/
/*
//50)
public static class Program
{
	public static void Main()
	{
     int num, x, resto, npares = 0, spares = 0, nimpares = 0, simpares = 0; 
	 int resto1;
     Console.Write("ingrese numero:"); 
	 num = int.Parse(Console.ReadLine()); 
	 for (x = 1; x <= num; x++)
	 { 
      resto = num % x; 
	  if (resto == 0)
	  { 
       Console.WriteLine(x); 
	   resto1 = x % 2; 
	   if (resto1 == 0)
	   { 
        spares = spares + x; 
		npares = npares + 1;
       }
	   else
	   { 
        simpares = simpares + x; 
		nimpares = nimpares + 1;
       }
      }
     }
     Console.WriteLine("nro de divisores pares:{0}", npares);
     Console.WriteLine("suma de divisores pares:{0}", spares);
     Console.WriteLine("nro de divisores pares:{0}", nimpares);
     Console.WriteLine("suma de divisores pares:{0}", simpares); 
	 Console.ReadLine();
    }
}
/*/
/*
//51)
public static class Program
{
	public static void Main()
	{
     int num, x, factorial = 1; 
	 Console.Write("ingrese numero:"); 
	 num = int.Parse(Console.ReadLine()); 
	 for (x = 1; x <= num; x++)
	 { 
      factorial = factorial * x;
     }
     Console.WriteLine("factorial {0}", factorial); 
	 Console.ReadLine();
    }
}
/*/
/*
//52)
public static class Program
{
	public static void Main()
	{
     double bmayor, bmenor, altura, atrap; 
	 Console.Write("ingrese base mayor:"); 
	 bmayor = double.Parse(Console.ReadLine()); 
	 Console.Write("ingrese base menor:"); 
	 bmenor = double.Parse(Console.ReadLine()); 
	 Console.Write("ingrese altura:"); 
	 altura = double.Parse(Console.ReadLine()); 
	 atrap = (bmayor + bmenor) / 2 * altura; 
	 Console.Write("area tratecio:{0}", atrap); 
	 Console.ReadLine();
	}
}
/*/
/*
//53)
public static class Program
{
	public static void Main()
	{
     rcuarta=Math.Sqrt(Math.Sqrt(numero)
	 //FORMULA PARA LA RAIZ CUARTA RCUBICA
     Random azar1 = new Random(); 
	 Random azar2 = new Random(); 
	 int dado1, dado2, suma; 
	 dado1 = azar1.Next(1, 6); 
	 dado2 = azar2.Next(1, 6); 
	 suma = dado1 + dado2;
     Console.WriteLine("dado1:{0}:", dado1);
     Console.WriteLine("dado2:{0}:" ,dado2);
	 Console.WriteLine("suma:{0}:" ,suma); 
	 if (suma == 7 || suma == 11)
     Console.Write("ganaste suertudo"); else if (suma == 2 || suma == 3 || suma == 12)
     Console.Write("perdiste "); else
     Console.Write("jugar de nuevo");
     Console.ReadLine();
	}
}
/*/
/*
//54)
public static class Program
{
	public static void Main()
	{ 
     int num, cuadrado, resto; 
	 Console.Write("ingrese numero:"); 
	 num = int.Parse(Console.ReadLine()); 
	 cuadrado = num * num; 
	 resto = num % 5;
     Console.Writeline("cuadrado:{0}", cuadrado);
     Console.Writeline("resto:{0}",resto);
     Console.ReadLine()
	}
}
/*/
/*
//55)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); double num, cuadrado, cubo; num = azar.Next(1, 20);
     Console.WriteLine("numero:{0}",num); cuadrado=Math.Pow(num,2);
     cubo=Math.Pow(num,3);
     Console.WriteLine("cuadrado :{0}",cuadrado);
     Console.WriteLine("cubo :{0}",cubo);
     Console.ReadLine();
	}
}
/*/
/*
//56)
public static class Program
{
	public static void Main()
	{
     int num, resto, ninv=0;
     Console.Write("ingrese el numero:"); 
	 num = int.Parse(Console.ReadLine()); 
	 while (num > 0)
	 { 
      resto = num % 10; 
	  ninv = ninv * 10 + resto;
	  num = (int)(num / 10);
     }
     Console.Write("Numero invertido:{0}",ninv);
     Console.ReadLine();
    }
 	Console.ReadLine();
}
/*/
/*
//57)
public static class Program
{
	public static void Main()
	{
	 int num, resto; string binario = "";
     Console.Write("ingrese el numero:"); 
	 num = int.Parse(Console.ReadLine());
	 while(num>0)
	 { 
      resto=num%2; binario=resto+binario; 
	  num=(int) (num/2);
     }
     Console.Write("binarios:{0}",binario);
     Console.ReadLine();
	}
}
/*/
/*
//58)
public static class Program
{
	public static void Main()
	{
     Random azar = new Random(); 
	 int num, resto1, rest2; num = azar.Next(1, 50);
     Console.WriteLine("numero:{0}", num); 
	 resto1 = num % 3; rest2 = num % 5;
     if (resto1 == 0 && resto1 == 0)
     Console.Write("{0} es multiplo de 3 y 5 a la vez", num);
	 else
     Console.Write("{0} no es multiplo de 3 y 5 a la vez", num); 
	 Console.ReadLine();
	}
}
/*/
/*
//59)
public static class Program
{
	public static void Main()
	{
     Console.Write("ingrese numero 1: "); 
	 n1 = double.Parse(Console.ReadLine()); 
	 Console.Write("ingrese numero 2: "); 
	 n2 = double.Parse(Console.ReadLine()); 
	 Console.Write("ingrese numero 3: "); 
	 n3 = double.Parse(Console.ReadLine()); 
	 double mayor, menor;
     mayor = Math.Max(Math.Max(n1, n2), n3);
	 //MAX HALLA EL MAYOR Console.WriteLine("el mayor {0} ", mayor);
     menor = Math.Min(Math.Min(n1, n2), n3);
	 //MIN HALLA EL MENOR Console.WriteLine("el manor {0} ", menor);
	}
}
/*/
/*
//60)
public static class Program
{
	public static void Main()
	{
     string frase; char car;
     int x, longitud,nvocales=0; 
	 Console.Write("ingrese frase:"); 
	 frase = Console.ReadLine(); 
	 longitud = frase.Length; 
	 for (x = 0; x < longitud; x++)
	 { 
      car = frase.ElementAt(x);
	  //extrae 1 caracter de posicion x
     if (car == 'A'||car == 'a'||car == 'a') nvocales++;
     }
     Console.Write("numero de vocales A{0}", nvocales);
     Console.ReadLine();
    }
}
/*/
/*

