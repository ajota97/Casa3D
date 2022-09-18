using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Proyecto1
{
    public class Drawing
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;
        public Dictionary<string, float> coords;

        public Drawing(Punto p, float ancho, float alto, float profundidad)
        {
            origen = p;
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
            coords= new Dictionary<string, float>();
            coords.Add("ancho", ancho);
            coords.Add("alto", alto);
            coords.Add("profundidad", profundidad);
        }

        public Drawing(Punto p) {
            origen = p;
        }

        public void Draw()
        {
           GL.Rotate(10, 1, 1, 0);
             PrimitiveType primitiveType = PrimitiveType.Triangles;
             GL.Rotate(15, 1, 1, 1);
             Triangle(primitiveType);  //verde
             SetObjeto(coords,"Test2");
            
            
        }

        public void DrawCoord(Dictionary<String, float> coords) {
            GL.Rotate(10, 1, 1, 0);
             PrimitiveType primitiveType = PrimitiveType.Triangles;
             GL.Rotate(15, 1, 1, 1);
             TriangleCoords(primitiveType,coords);  //verde
        }

        private void TriangleCoords(PrimitiveType primitiveType, Dictionary<String, float> coords)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul
            GL.Vertex3(origen.x - coords["ancho"], origen.y + coords["alto"], coords["profundidad"]);
            GL.Vertex3(origen.x + coords["ancho"], origen.y + coords["alto"], coords["profundidad"]);
            GL.Vertex3(origen.x, origen.y - coords["alto"], coords["profundidad"]);
            GL.End();
        }

        private void SetObjeto(Dictionary<string, float> coords,String fileName)
        {
           
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\JOSE  MERIDA ROCA\Desktop\Computing engineering\Programacion grafica\ELC102-Proyecto1-tarea-1\bin\Debug\"+fileName+".txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, coords);
            }
        }

        public Dictionary<String,float> GetObjeto(string myFile)
        {
            string myjson = File.ReadAllText(myFile);
            Dictionary<String,float> resp = JsonConvert.DeserializeObject<Dictionary<String,float>>(myjson);
            return resp;
        }






        private void Triangle(PrimitiveType primitiveType)
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

