using Proyecto1_01.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Utils
{
    interface IConverter
    {
        void saveObjeto(Objeto coords, String fileName);
        Objeto GetObjeto(string myFile);

    }
}
