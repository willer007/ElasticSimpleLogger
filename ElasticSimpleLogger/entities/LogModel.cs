using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSimpleLogger
{

    public class LogModel
    {
        public string registro_mensagem { get; set; }
        public int registro_codigo_erro { get; set; }


        public string registro_datahora { get; set; }

        public string registro_tipo { get; set; }

        public string registro_nivel { get; set; }

        public int registro_automacao_id { get; set; }

        public object registro_detalhes { get; set; }

    }
}
