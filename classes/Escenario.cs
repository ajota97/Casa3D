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
    class Escenario 
    {

        private Dictionary<String, Objeto> listaObject { get; set; }
        private Punto centr { get; set; }

        public Dictionary<string, Objeto> listaObjetos { get { return listaObject; } set { listaObject = value; } }
         public Punto centro { get { return centr; } set { centr = value; } }

        public Escenario(Dictionary<string, Objeto> listaObjeto, Punto centro)
        {
            this.listaObject = listaObjeto;
            this.centr = centro;
        }

        public Escenario()
        {
            this.centr = centro;
        }


        public void añadir(string nombre, Objeto nObjeto) {
            listaObjetos.Add(nombre, nObjeto); 
        }

        public void dibujar()
        {
            foreach (var objeto in listaObjetos) {
               
                objeto.Value.dibujar(centro);
            }
        }

        public void setSerializable(Escenario esc, String name) {
            Converter<Escenario> c = new Converter<Escenario>();
            c.saveObjeto(esc, name);
        }

        public void  GetSerializable(String filename)
        {
            Converter<Escenario> c = new Converter<Escenario>();
            Escenario esc = c.GetSerializable(filename);
            this.centr = new Punto(esc.centro.x, esc.centro.y, esc.centro.z);
            listaObjetos = esc.listaObjetos;
          
        }
    }
}
