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
            string criterio;
            string valor;
            string crit;
            string val;
            string vcrit;
            string respuesta2;
            Espotifai a = new Espotifai();
            Playlist b = new Playlist();
            Console.WriteLine("Nombre de Usuario:");
            respuesta2 = Console.ReadLine();
            Console.WriteLine("Buenos días "+respuesta2);
            while (true)
            {


                Console.WriteLine("Menú: Elija una opcion numerica");
                Console.WriteLine(" ");
                Console.WriteLine("1) Ver Canciones");
                Console.WriteLine(" ");
                Console.WriteLine("2) Agregar Cancion");
                Console.WriteLine(" ");
                Console.WriteLine("3) Ver Canciones por criterio");
                Console.WriteLine(" ");
                Console.WriteLine("4) Crear Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("5) Ver mis Playlists");
                Console.WriteLine(" ");
                Console.WriteLine("6) Salir de Spotify");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                respuesta = Console.ReadLine();
                {
                    if (respuesta == "1")
                    {
                        a.VerCanciones();
                    }


                    if (respuesta == "2")
                    {
                        Console.WriteLine("Ingrese el genero de la cancion:");
                        genero = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese al artista de la cancion:");
                        artista = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el album de la cancion:");
                        album = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el nombre de la cancion:");
                        nombre = Console.ReadLine();
                        Console.WriteLine(" ");
                        Cancion cancion1 = new Cancion(genero, artista, album, nombre);
                        a.AgregarCancion(cancion1);

                    }
                    if (respuesta == "3")
                    {
                        Console.WriteLine("Ingrese el criterio de búsqueda:");
                        criterio = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor del criterio:");
                        valor = Console.ReadLine();
                        a.CriteriosPorCancion(criterio, valor);
                    }
                    //Crear Playlist
                    if (respuesta == "4")
                    {
                        Console.WriteLine("Criterio:");
                        crit = Console.ReadLine();
                        Console.WriteLine("Valor criterio");
                        vcrit = Console.ReadLine();
                        Console.WriteLine("Nombre Playlist");
                        valor = Console.ReadLine();
                        a.GenerarPlaylist(crit, vcrit, valor);

                    }
                    if (respuesta == "5")
                    {
                        a.VerMisPlaylists();
                    }

                    if (respuesta == "6")
                    {
                        Console.WriteLine("Saliendo de Spotify...");
                        break;
                    }
                    if (respuesta != "1" || respuesta != "2" || respuesta != "3" || respuesta != "4" || respuesta != "5" || respuesta != "6")
                    {
                        Console.WriteLine("Porfavor intente de nuevo...");
                    }
                }
            }
        }
    }
}