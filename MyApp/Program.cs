
/* Console.WriteLine("Ingrese texto");
string numero1 = Console.ReadLine();
int numero = 4;
Console.WriteLine("Uds escribio " + texto + " y el numero " + numero); */

//double resultado = Convert.ToDouble(numero1) + Convert.ToDouble(numero2); //Int32.Parse

/****************************************Ejercicio 1************************************************/



/*Console.WriteLine("Ingrese un numero:");
string numero = Console.ReadLine();
int N = Convert.ToInt32(numero);
int Ninv=0;
if (N>=0) //Si es 0 o negativo evitar la inversion
{
    while (N>0)
    {
        Ninv = Ninv * 10 + (N % 10);
        N /= 10;
    }
}
Console.WriteLine("El numero es: " + numero);
Console.WriteLine("El numero invertido es: " + Ninv);*/

/***************************************Calculadora*************************************************/



string numero1,menu;
double N1=0;
double resultado=0;
do
{
    Console.WriteLine("¿Que operacion desea realizar?");
    Console.WriteLine("1.Valor absoluto\n2.Cuadrado\n3.Raiz cuadrada\n4.Seno\n5.Coseno\n6.Parte entera");
    int flag = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero:");
    numero1 = Console.ReadLine();
    N1 = Convert.ToDouble(numero1);
    switch (flag)
    {
        case 1:
            resultado=Math.Abs(N1);
        break;

        case 2:
            resultado=Math.Pow(N1,2);
        break;

        case 3:
            resultado=Math.Sqrt(N1);
        break;

        case 4:
            resultado=Math.Sin(N1); 
        break;
        
        case 5:
            resultado=Math.Cos(N1);
        break;

        case 6:
            resultado=Math.Truncate(N1); //Calcula la parte entera de un número de punto flotante de precisión doble especificado.
        break;

        default:
            Console.WriteLine("Error");
        break;
    }
    Console.WriteLine("El resultado es: " + resultado);
    Console.WriteLine("¿Desea realizar otra opreacion? 1.Si 2.No");
    menu = Console.ReadLine();
} while (menu=="1");