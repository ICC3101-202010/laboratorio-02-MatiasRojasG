using System;

namespace Lab2POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Buenos días Matias");
            Console.WriteLine("Menú: Elija una opcion numerica");
            Console.WriteLine("1) Ver Canciones");
            Console.WriteLine(" ");
            Console.WriteLine("2) Agregar Cancion");
            Console.WriteLine(" ");
            Console.WriteLine("3) Salir de Espotifai");
            Console.WriteLine(" ");

            string respuesta;
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                //Espotifai.VerCanciones()
            }
            if (respuesta == "2")
            {
                //Espotifai.AgregarCancion()
            }
            if (respuesta == "3")
            {
                Console.WriteLine("Chao qlo xd");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }





        }
    }
}
