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

        public Espotifai()
        {

        }
        public bool AgregarCancion(Cancion cancion, List<Cancion> canciones)
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
        public void VerCanciones()
        {
            foreach (Cancion iden in canciones)
            {
                iden.Informacion();
            }
        }

    }
}