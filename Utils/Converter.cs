using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Proyecto1_01.classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1_01.Utils
{
    class Converter<T>
    {
        
        public void saveObjeto(T coords, String fileName)
        {

                    String json = JsonConvert.SerializeObject(coords);
            File.WriteAllText(fileName + ".json", json);
        }

        public T GetSerializable(string myFile)
        {
                        string json;
            using (StreamReader jsonStream = File.OpenText(myFile))
            {
                json = jsonStream.ReadToEnd();
            }
            T resp = JsonConvert.DeserializeObject<T>(json);
            return resp;
        }
    }
}
