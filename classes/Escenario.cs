using OpenTK;
using Proyecto1_01.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.classes
{
    class Escenario:IDibujable 
    {
        Dictionary<String, Objeto> listaObjeto = new Dictionary<string, Objeto>();
        private Vector3 centro;

        public Escenario(Dictionary<string, Objeto> listaObjeto, Vector3 centro)
        {
            this.listaObjeto = listaObjeto;
            this.centro = centro;
        }

        public Vector3 getCentro() {
            return centro;
        }

        public void setCentro(Vector3 c) {
            centro = c;
        }

        public Dictionary<String,Objeto> getListaObjeto() { 
        return this.listaObjeto;
        }

        public void añadir(string nombre, Objeto nObjeto) {
            listaObjeto.Add(nombre, nObjeto); 
        }

        public void dibujar()
        {
            throw new NotImplementedException();
        }

        //TODO Dibujar

    }
}
