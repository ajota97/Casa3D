using OpenTK;
using Proyecto1;
using Proyecto1_01.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.classes
{
    [Serializable]
    class Objeto 
    {
        private Dictionary<String, Parte> listaParte { get; set; }
        private Punto centr { get; set; }
        
        public Dictionary<string, Parte> listaPartes { get { return listaParte; } set { listaParte = value; } }
        public Punto centro { get { return centr; } set { centr = value; } }

        public Objeto(Dictionary<string, Parte> listaPartes, Punto centro)
        {
            this.listaParte = listaPartes;
            this.centr = centro;
        }

        public void añadir(string nombre, Parte nParte)
        {
            listaPartes.Add(nombre, nParte);
        }

        public void dibujar(Punto p)
        {

            foreach (var parte in listaPartes)
            {
                parte.Value.dibujar(p,centro);
                
            }
        }

        
    }
}
