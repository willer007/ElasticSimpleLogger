using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.RPA.LoggerEK
{

    public class LogModel
    {
        public string registro_mensagem { get; set; }
        public int registro_codigoerro { get; set; }
        public string registro_tipo { get; set; }
        public string registro_datahora { get; set; }
        public object outroObjeto { get; set; }
        public int IdAutomacao { get; set; }
    }
}
