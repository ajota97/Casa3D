using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Game : GameWindow
    {
       
        
        //public Drawing triangle1;
        //Dictionary<String, Punto> coords = new Dictionary<string, Punto>();
        //Dictionary<String, Parte> parts = new Dictionary<String, Parte>();
        //Dictionary<String, Objeto> objects = new Dictionary<String, Objeto>();
        //public Drawing triangle2;
        //private Punto punto2=new Punto(10,10,10);
        //private Punto punto1, punto2, punto3;
        //private Parte partetriangulo;
        private Objeto objeto;
        private Escenario esc=new Escenario();


        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {
            //punto1 = new Punto(5, 0, 0);
            //punto2 = new Punto(0, 5, 0);
            //punto3 = new Punto(-5, 0, 0);

            //coords.Add("p1",punto1);
            //coords.Add("p2", punto2);
            //coords.Add("p3", punto3);

            //partetriangulo = new Parte(coords, new Punto(2,2,2));

            //parts.Add("triangulo", partetriangulo);

            //objeto = new Objeto(parts, new Punto(1,1,1));

            //objects.Add("triangulito", objeto);

            // esc = new Escenario(objects, new Punto(3,3,3));
          //  esc = new Escenario();
           // esc.GetSerializable("Escenario.json");
            esc.GetSerializable("EscenarioCasa.json");


            //esc.GetSerializable("Escenario.json");
            //  esc.save(esc, "Escenario");
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            
            GL.ClearColor(Color4.Black);
            //triangle1 = new Drawing(new Punto(), 7, 7 ,0);
            //triangle1 = new Drawing(new Punto());
            // coords = triangle1.GetObjeto("test.txt");
            //  triangle2 = new Drawing(punto2, 5, 5, 0);
          
            base.OnLoad(e);     
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //-----------------------

            //triangle1.DrawCoord(coords);
            // this.triangle2.Draw();
            //-----------------------
            esc.dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

       

    }
}
