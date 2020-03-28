using System;

namespace Lab2POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string genero;
            string artista;
            string album;
            string nombre;
            string respuesta;

            Console.WriteLine("Buenos días Matias");
            Console.WriteLine("Menú: Elija una opcion numerica");
            Console.WriteLine("1) Ver Canciones");
            Console.WriteLine(" ");
            Console.WriteLine("2) Agregar Cancion");
            Console.WriteLine(" ");
            Console.WriteLine("3) Salir de Spotify");
            Console.WriteLine(" ");

            
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Console.WriteLine(Spotify.VerCanciones());
            }
            if (respuesta == "2")
            {
                //Espotifai.AgregarCancion()
            }
            if (respuesta == "3")
            {
                Console.WriteLine("Saliendo de Spotify...");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }





        }
    }
}
