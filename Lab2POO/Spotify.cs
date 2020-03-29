using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab2POO
{
    public class Spotify
    {
        //Creo una lista de strings
        List<Cancion> canciones = new List<Cancion>();

        public static void AgregarCancion(Cancion cancion)
        {
            canciones.Add(cancion);
           
        }
        public void VerCanciones()
        {
            canciones.ToString();
        }










        //Arreglo
        //public string VerCanciones()
        //{ 
        //        return Canciones.Informacion()
        //}
        //public bool AgregarCancion()
        //{

        //}


        //Dentro de Agregar Cancion
        //Console.WriteLine("Ingrese el genero de la cancion:");
        //genero = Console.ReadLine();
        //Console.WriteLine("Ingrese al artista de la cancion:");
        //artista = Console.ReadLine();
        //Console.WriteLine("Ingrese el album de la cancion:");
        //album = Console.ReadLine();
        //Console.WriteLine("Ingrese el nombre de la cancion:");
        //nombre = Console.ReadLine();
        //Cancion primeracancion = new Cancion(genero, artista, album, nombre);
        // Se agrega la cancion


    }
}
