using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            Espotifai a = new Espotifai();
            Console.WriteLine("Buenos días Matias");
            while (true)
            {


                Console.WriteLine("Menú: Elija una opcion numerica");
                Console.WriteLine(" ");
                Console.WriteLine("1) Ver Canciones");
                Console.WriteLine(" ");
                Console.WriteLine("2) Agregar Cancion");
                Console.WriteLine(" ");
                Console.WriteLine("3) Salir de Spotify");
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
                        Console.WriteLine("Saliendo de Spotify...");
                        break;
                    }
                }
            }
        }
    }
}