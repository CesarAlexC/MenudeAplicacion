/*Se creara un menu de diversas aplicaciones hechas por mi,
 * en caso que vean si se puede mejorar algo lo tomare en cuenta 
 */

//Priper programa calculadora basica suma, resta, multiplicacion, division


using System.Timers;

List<float> Numero = new List<float>();
float numero1 = 0f;
float numero2 = 0f;
float resultado = 0f;

Console.WriteLine("Ingrese que operacion requiere hacer, \n 1.- suma \n 2.- Resta \n 3.- Multiplicacion \n 4.- Divicion ");
int menu = int.Parse(Console.ReadLine());
Console.Clear();

if (menu <= 4)
    {
    switch (menu)
    {
        case 1:
            Console.WriteLine("Suma \n");
            Console.WriteLine("Ingresa el primer numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            numero2 = float.Parse(Console.ReadLine());
            resultado= numero1 + numero2;
            Console.WriteLine("El resultado es " + resultado);
            break;
        case 2:
            Console.WriteLine("Resta \n");
            Console.WriteLine("Ingresa el primer numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            numero2 = float.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado es " + resultado);
            break;
        case 3:
            Console.WriteLine("Multiplicacion \n");
            Console.WriteLine("Ingresa el primer numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            numero2 = float.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado es " + resultado);
            break;
        case 4:
            Console.WriteLine("Divicion \n");
            Console.WriteLine("Ingresa el primer numero");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            numero2 = float.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado es " + resultado);
            break;
        default:
            Console.WriteLine("FIN");
            break;

    }

    Console.ReadLine();
}
