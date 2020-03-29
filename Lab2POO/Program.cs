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
                Spotify.VerCanciones(canciones);
            }
            if (respuesta == "2")
            {
                Console.WriteLine("Ingrese el genero de la cancion:");
                genero = Console.ReadLine();
                Console.WriteLine("Ingrese al artista de la cancion:");
                artista = Console.ReadLine();
                Console.WriteLine("Ingrese el album de la cancion:");
                album = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de la cancion:");
                nombre = Console.ReadLine();
                Cancion cancion1 = new Cancion(genero, artista, album, nombre);
                Spotify.AgregarCancion(Cancion cancion1);
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
