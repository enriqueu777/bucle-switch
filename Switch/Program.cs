using System.Net.Mime;



internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Introduce el nuemero de mes para el calculo de la comision");


        int mes = Int32.Parse(Console.ReadLine());

        switch (mes) {


            case 1:
                Console.WriteLine("Mes escogido Enero");

                break;


            case 2:
                Console.WriteLine("Mes escogido Febrero");

                break;

            case 3:
                Console.WriteLine("Mes escogido Marzo");

                break;



            case 4:
                Console.WriteLine("Mes escogido Abril");

                break;

            case 5:
                Console.WriteLine("Mes escogido Mayo");

                break;

            case 6:
                Console.WriteLine("Mes escogido Junio");

                break;


            case 7:
                Console.WriteLine("Mes escogido Julio");

                break;


            case 8:
                Console.WriteLine("Mes escogido Agosto");

                break;


            case 9:
                Console.WriteLine("Mes escogido Septiembre");

                break;

            case 10:
                Console.WriteLine("Mes escogido Octubre");

                break;

            case 11:
                Console.WriteLine("Mes escogido Noviembre");

                break;

            case 12:
                Console.WriteLine("Mes escogido Noviembre");

                break;





                break;
            default:

                Console.WriteLine("El numero de mes escogido no es el correcto");
                break;






        }
    }

}
