using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Proyecto1;
using Proyecto1_01.Utils;
using OpenTK.Graphics.OpenGL;

namespace Proyecto1_01.classes
{
    [Serializable]
    class Parte
    {

        private Dictionary<String, Punto> listaPunto { get; set; }
        private Punto centr { get; set; }

        public Dictionary<string, Punto> listaPuntos { get { return listaPunto; } set { listaPunto = value; } }
        public Punto centro { get { return centr; } set { centr = value; } }

        public Parte(Dictionary<string, Punto> listaPuntos, Punto centro)
        {
            this.listaPunto = listaPuntos; 
            this.centr = centro;
        }

        public void añadir(String nombre, Punto v) {
            listaPuntos.Add(nombre, v); 
        }

        public void dibujar(Punto p1,Punto p2)
        {
            //GL.Rotate(10, 1, 1, 0);
            PrimitiveType primitiveType = PrimitiveType.Polygon;
            GL.Begin(primitiveType);
           // GL.Rotate(15, 1, 1, 1);

            Dictionary<string, Punto>.ValueCollection misPuntos = listaPuntos.Values;

            foreach (Punto p in misPuntos)
            {
                GL.Vertex3(p1.x+p2.x+centro.x + p.x,p1.y+p2.y+centro.y+ p.y,p1.z+p2.z+ centro.z+ p.z );
            }

            GL.End();
            GL.PopMatrix();
        }
    }
}
