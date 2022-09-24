using OpenTK;
using Proyecto1_01.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.classes
{
    class Objeto : IDibujable
    {
        Dictionary<String, Parte> listaPartes = new Dictionary<string, Parte>();
        private Vector3 centro;

        public Objeto(Dictionary<string, Parte> listaPartes, Vector3 centro)
        {
            this.listaPartes = listaPartes;
            this.centro = centro;
        }

        public Vector3 getCentro() {
            return centro;
        }

        public void setCentro(Vector3 c) {
            centro = c;
        }

        public Dictionary<String, Parte> getListaPartes() {
            return listaPartes;
        }

        public void setListaPartes(Dictionary<String,Parte> v) {
            this.listaPartes = v;
        }

        public void añadir(string nombre, Parte nParte)
        {
            listaPartes.Add(nombre, nParte);
        }

        public void dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
