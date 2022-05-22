
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



string numero1,numero2,menu;
double N1=0,N2=0;
double resultado=0;
do
{
    Console.WriteLine("¿Que operacion desea realizar?");
    Console.WriteLine("\n1.Suma\n2.Resta\n3.Multiplicar\n4.Dividir");
    int flag = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese un numero:");
    numero1 = Console.ReadLine();
    N1 = Convert.ToDouble(numero1);
    Console.WriteLine("Ingrese otro numero:");
    numero2 = Console.ReadLine();
    N2 = Convert.ToDouble(numero2);
    
    switch (flag)
    {
        case 1:
            resultado=N1+N2;
        break;

        case 2:
            resultado=N1-N2;
        break;

        case 3:
            resultado=N1*N2;
        break;

        case 4:
            resultado=N1/N2; 
        break;
        default:
            Console.WriteLine("Error");
        break;
    }
    Console.WriteLine("El resultado es: " + resultado);
    Console.WriteLine("¿Desea realizar otra opreacion? 1.Si 2.No");
    menu = Console.ReadLine();
} while (menu=="1");