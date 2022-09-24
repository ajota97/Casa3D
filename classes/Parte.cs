using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Proyecto1_01.Utils;

namespace Proyecto1_01.classes
{
    class Parte:IDibujable
    {
        Dictionary<String, Vector3> listaPuntos = new Dictionary<string, Vector3>();
        public Vector3 centro;

        public Parte(Dictionary<string, Vector3> listaPuntos, Vector3 centro)
        {
            this.listaPuntos = listaPuntos; 
            this.centro = centro;
        }

        public Vector3 getCentro() {
            return centro;
        }

        public void setCentro(Vector3 c) {
            centro = c;
        }

        public Dictionary<String, Vector3> getListaPartes() {
            return listaPuntos;
        }

        public void setListaPartes(Dictionary<string, Vector3> v) {
            this.listaPuntos = v;
        }

        public void añadir(String nombre, Vector3 v) {
            listaPuntos.Add(nombre, v); 
        }

        public void dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
