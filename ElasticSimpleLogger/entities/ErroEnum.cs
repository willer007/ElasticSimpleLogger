using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSimpleLogger
{
    public class ErroEnum
    {
        public enum Generico
        {
            InstanciaDeObjeto = 1001,
            ApenasMensagem = 1002
        }

        public enum Aplicacao
        {
            NullReference = 2001
        }

        public enum Servico
        {
            Indisponivel = 3001,
            Offline = 3002
        }

        public enum Formatacao
        {
            FormatException = 4001
        }

        public enum API
        {
            Teste = 5001
        }

        public enum RPA
        {
            FalhaDeLogin = 6001
        }
    }
}
