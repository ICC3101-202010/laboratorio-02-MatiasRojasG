namespace Lab2POO
{
    public class Cancion
    {//Atributos
        private string Genero;
        private string Artista;
        private string Album;
        private string Nombre;

        //Constructor publico
        public Cancion(string Genero, string Artista, string Album, string Nombre)
        {
            this.Genero = Genero;
            this.Artista = Artista;
            this.Album = Album;
            this.Nombre = Nombre;

        }
        //Constructor default
        public Cancion()
        {
            Genero = "Pop";
            Artista = "Ellie Goulding";
            Album = "Lights";
            Nombre = "Lights";
        }
        //Metodo
        public string Informacion()
        {
            return "Genero:" + Genero + " " + "Artista:" + Artista + " " + "Album:" + Album + " " + "Nombre:" + Nombre;
        }
        public string GetName()
        {
            return Nombre;
        }
        public string GetArtist()
        {
            return Artista;
        }
        public string GetAlbum()
        {
            return Album;
        }
        public string GetGenre()
        {
            return Genero;
        }

    }

}
