using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace ElasticSimpleLogger
{

    public static class ElasticLogger
    {

        private static int AUTOMACAO_ID = 0;
        private static string INDEX = "";
        private static string BASE_URL = "";

        private static HttpClient httpClient = new HttpClient();


        public static void Configure(string _baseUrl, string _index, int _automacaoId)
        {
            AUTOMACAO_ID = _automacaoId;
            INDEX = _index;
            BASE_URL = _baseUrl;
        }



        public static void Error(LogModel logModel)
        {

            logModel.registro_nivel = NivelEnum.ERROR;
            logModel.registro_tipo = TipoEnum.INFO;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_datahora = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }

        public static void ErrorSystemException(LogModel logModel, Exception exception)
        {
            logModel.registro_nivel = NivelEnum.ERROR;
            logModel.registro_tipo = TipoEnum.SYSTEM_EXCEPTION;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_detalhes = exception;
            logModel.registro_datahora =  DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }

        public static void ErrorBusinessRuleException(LogModel logModel, Exception exception)
        {
            logModel.registro_nivel = NivelEnum.ERROR;
            logModel.registro_tipo = TipoEnum.BUSINESS_RULE_EXCEPTION;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_detalhes = exception;
            logModel.registro_datahora =  DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }

        public static void Info(LogModel logModel)
        {
            logModel.registro_nivel = NivelEnum.INFO;
            logModel.registro_tipo = TipoEnum.INFO;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_datahora =  DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }


        public static void Debug(LogModel logModel)
        {
            logModel.registro_nivel = NivelEnum.DEBUG;
            logModel.registro_tipo = TipoEnum.INFO;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_datahora =  DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }

        public static void Fatal(LogModel logModel, Exception exception)
        {
            logModel.registro_nivel = NivelEnum.FATAL;
            logModel.registro_tipo = TipoEnum.SYSTEM_EXCEPTION;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_detalhes = exception;
            logModel.registro_datahora =  DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }

        public static void Fatal(LogModel logModel)
        {
            logModel.registro_nivel = NivelEnum.FATAL;
            logModel.registro_tipo = TipoEnum.SYSTEM_EXCEPTION;
            logModel.registro_automacao_id = AUTOMACAO_ID;
            logModel.registro_datahora = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            SendPost($"{BASE_URL}/{INDEX}/_doc/", logModel);
        }


        private static void SendPost(string url, LogModel logModel)
        {

            // Serialize our concrete class into a JSON String
            var stringPayload = JsonConvert.SerializeObject(logModel);

            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            // Do the actual request and await the response
            var httpResponse = httpClient.PostAsync(url, httpContent).Result;

            // If the response contains content we want to read it!
            if (httpResponse.Content != null)
            {
                var responseContent = httpResponse.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
