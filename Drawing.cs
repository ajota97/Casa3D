using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Proyecto1
{
    public class Drawing
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;

        public Drawing(Punto p, float ancho, float alto, float profundidad)
        {
            origen = p;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }

        public void Draw()
        {
           GL.Rotate(10, 1, 1, 0);
            PrimitiveType primitiveType = PrimitiveType.Triangles;
            //PrimitiveType primitiveType = PrimitiveType.Quads;
            // GL.Rotate(15, 1, 1, 1);
            triangle(primitiveType);  //verde
          
        }

        


    


        private void triangle(PrimitiveType primitiveType)
        {
            
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul
            GL.Vertex3(origen.x - ancho, origen.y + alto,  profundidad);
            GL.Vertex3(origen.x + ancho, origen.y + alto,  profundidad);
            GL.Vertex3(origen.x , origen.y - alto,  profundidad);
            GL.End();
        }

   

    }
}

