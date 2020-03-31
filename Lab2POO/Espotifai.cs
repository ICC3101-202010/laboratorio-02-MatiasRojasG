using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab2POO
{
    public class Espotifai
    {
        public List<Cancion> canciones = new List<Cancion> { };
        public List<Cancion> cancionescrit = new List<Cancion> { };
        //Lista que contiene Playlists dentro
        public List<Playlist> listaplaylist = new List<Playlist> { };

        public Espotifai()
        {

        }
        //Metodo para agregar cancion
        public bool AgregarCancion(Cancion cancion)
        {
            if (canciones.Contains(cancion))
            {
                return false;
            }
            else
            {
                canciones.Add(cancion);
                return true;
            }

        }
        //Metodo para ver canciones
        public void VerCanciones()
        {
            foreach (Cancion iden in canciones)
            {
                Console.WriteLine(iden.Informacion());
            }
        }
        //Metodo para buscar canciones por criterio
        public void CriteriosPorCancion(string criterio, string valor)
        {
            foreach (Cancion iden1 in canciones)
            {
                if (criterio == "Nombre")
                {
                    if (iden1.GetName() == valor)
                    {
                        cancionescrit.Add(iden1);
                    }
                }
                if (criterio == "Artista")
                {
                    if (iden1.GetArtist() == valor)
                    {
                        cancionescrit.Add(iden1);
                    }
                }
                if (criterio == "Album")
                {
                    if (iden1.GetAlbum() == valor)
                    {
                        cancionescrit.Add(iden1);
                    }
                }
                if (criterio == "Genero")
                {
                    if (iden1.GetGenre() == valor)
                    {
                        cancionescrit.Add(iden1);
                    }
                }
                if (criterio != "Genero" || criterio != "Album" || criterio != "Genero" || criterio != "Nombre")
                {
                    Console.WriteLine("Error");
                }
            }
            foreach (Cancion iden2 in cancionescrit)
            {
                Console.WriteLine(iden2.Informacion());
            }
        }

        //Metodo crear Playlist
        public bool GenerarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            Playlist ola = new Playlist();
            ola.SetName(nombrePlaylist);
            ola.SetCriterio(criterio);
            ola.Setvc(valorCriterio);
            if (listaplaylist.Contains(ola))
            {
                Console.WriteLine("No se pudo agregar debido a que ya existe una playlist con ese nombre");
                return false;
            }
            else
            {
                listaplaylist.Add(ola);
                return true;
            }
        }
        //Metodo ver nombre de las playlist
        public string VerMisPlaylists()
        {
            Console.WriteLine("Playlists guardadas:");

            foreach(Playlist ind in listaplaylist)
            {
                Console.WriteLine("Nombre Playlist: "+ind.GetNamep()+" Criterio Playlist: "+ ind.GetCriterio()+" Val Criterio :"+ind.Getvalorcriterio());
            }
            return "Fin";

        }
    }

}
