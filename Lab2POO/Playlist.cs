using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Lab2POO
{
    public class Playlist
    {
        string valorname;
        string valorcrit;
        string valorvc;
        private string Namep;
        private string Criterio;
        private string valorcriterio;

        public List<Cancion> cancionesplay = new List<Cancion> { };

        //Metodos get
        public string GetNamep()
        {
            return Namep;
        }
        public string GetCriterio()
        {
            return Criterio;
        }
        public string Getvalorcriterio()
        {
            return valorcriterio;
        }
        //Metodos set
        public string SetName(string valorname)
        {
            return Namep = valorname;
        }
        public string SetCriterio(string valorcrit)
        {
            return Criterio = valorcrit;
        }
        public string Setvc(string valorvc)
        {
            return valorcriterio = valorvc;
        }

        public void GetNameCanciones()
        {
            Console.WriteLine("Canciones dentro de la playlist");
            foreach (Cancion a in cancionesplay)
            {
                Console.WriteLine(a.Informacion());
            }
        }
        //Constructor vacio
        public Playlist()
        {

        }
        public void AgregarCancionaPlaylist(Cancion cancionparaplaylist)
        {
            cancionesplay.Add(cancionparaplaylist);
        }
    }
}
