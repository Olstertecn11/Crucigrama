using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucigrama
{

    public class Vertical
    {
        public string id;
        public string val;
    }
    public class Horizontal 
    {
        public string id;
        public string val;
    }
    public class Config
    {
        public List<Horizontal> horizontales;
        public List<Vertical> verticales;
    }
}
