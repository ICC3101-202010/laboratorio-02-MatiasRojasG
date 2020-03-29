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
            List<Cancion> canciones = new List<Cancion>();
            Cancion ola = new Cancion("a", "b", "c", "d");
            //Cancion ola1=new Cancion("1", "2", "3", "4");
            //canciones.Add(ola);
            //canciones.Add(ola1);

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
                foreach (Cancion iden in canciones)
            {
              iden.Informacion();
            }

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
                if (canciones.Contains(cancion1))
                {
                    Console.WriteLine("Ya esta la cancion");
                }
                else
                {
                    canciones.Add(cancion1);
                    Console.WriteLine("Agregada");
                }

            }

            if (respuesta == "3")
            {
                  Console.WriteLine("Saliendo de Spotify...");
            }
            else
                {
                    Console.WriteLine("Debe ingresar un numero. ERROR...");
                }
            }
        }
    }
