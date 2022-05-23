
/* Console.WriteLine("Ingrese texto");
string numero1 = Console.ReadLine();
int numero = 4;
Console.WriteLine("Uds escribio " + texto + " y el numero " + numero); */

//double resultado = Convert.ToDouble(numero1) + Convert.ToDouble(numero2); //Int32.Parse

/*Ejercicio 1*/

Console.WriteLine("Ingrese un numero:");
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
Console.WriteLine("El numero invertido es: " + Ninv);
