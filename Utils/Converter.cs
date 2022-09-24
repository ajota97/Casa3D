using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Proyecto1_01.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1_01.Utils
{
    class Converter
    {
        
        public void saveObjeto(Objeto coords, String fileName)
        {

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\JOSE  MERIDA ROCA\Desktop\Computing engineering\Programacion grafica\ELC102-Proyecto1-tarea-1\bin\Debug\" + fileName + ".json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, coords);
            }
        }

        public Objeto GetObjeto(string myFile)
        {
            string myjson = File.ReadAllText(myFile);
            Objeto resp = JsonConvert.DeserializeObject<Objeto>(myjson);

            return resp;
        }
    }
}
