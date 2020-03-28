using System;
namespace Lab2POO
{
    public class Spotify
    {
        private Cancion[] cancion = new Cancion[1];
        public Spotify(Cancion[] canciones)
        {
            for (int i=0;i<1;i++)
            {
                cancion[i] = canciones[i];
            }
        }
        public Cancion[] getcanciones()
        {
            return cancion;
        }
        public void setCancion(Cancion[] cancion)
        {
            this.cancion = cancion;
        }
    }

        //public bool AgregarCancion()
        //{
        //}

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
//Console.WriteLine("Desea ver la informacion de la cancion?");
//respuesta = Console.ReadLine();
//if (respuesta=="si")
//{
//    Console.WriteLine(primeracancion.Informacion());
//}
//else
//{
//    Console.WriteLine("Tonc Chupalo");            }



//}
//Metodo public void VerCanciones()
//public void VerCanciones()
//{
//indice que al correr haga writeline a todas las canciones.informacion()
//}

}
