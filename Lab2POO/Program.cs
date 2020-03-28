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
            Console.WriteLine("3) Salir de Espotifai");
            Console.WriteLine(" ");

            
            respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                //Espotifai.VerCanciones()
            }
            if (respuesta == "2")
            {
                Console.WriteLine("Introduzca el Género:");
                genero = Console.ReadLine();
                Console.WriteLine("Introduzca el Artista:");
                artista = Console.ReadLine();
                Console.WriteLine("Introduzca el Album:");
                album = Console.ReadLine();
                Console.WriteLine("Introduzca el Nombre:");
                nombre = Console.ReadLine();
                Cancion cancion1 = new Cancion(genero, artista, album, nombre);
                Spotify spotify = new Spotify(new Cancion[] {cancion1});
                Console.WriteLine(cancion1.Informacion());
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
