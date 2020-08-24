using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Newtonsoft.Json;

namespace Test.RPA.LoggerEK
{
    [TestClass]
    public class TestElasticLogger
    {
        //public static class Erro
        //{
        //    public enum Generico
        //    {
        //        InstanciaDeObjeto = 1001,
        //        ApenasMensagem = 1002
        //    }

        //    public enum Aplicacao
        //    {
        //        NullReference = 2001
        //    }

        //    public enum Servico
        //    {
        //        Indisponivel = 3001,
        //        Offline = 3002
        //    }

        //    public enum Formatacao
        //    {
        //        FormatException = 4001
        //    }

        //    public enum API
        //    {
        //        Teste = 5001
        //    }

        //    public enum RPA
        //    {
        //        FalhaDeLogin = 6001
        //    }
        //}


        //public enum Nivel
        //{
        //    TRACE, DEBUG, INFO, WARN, ERROR, FATAL
        //}



        private static string INDEX_URL = "http://10.50.6.98:9200/rpa_lancamentodespesas_teste/_doc/";

        private static HttpClient httpClient = new HttpClient();
        [TestMethod]
        public async void TestErrorAsync()
        {
            //var payload = new LogModel
            //{
            //    registro_mensagem = "TESTE",
            //    registro_codigoerro = 1,
            //    registro_tipo = "TESTE",
            //    registro_datahora = "TESTE",
            //    outroObjeto = "TESTE",
            //    IdAutomacao = 1,

            //};

            // Serialize our concrete class into a JSON String
            // var stringPayload = JsonConvert.SerializeObject(payload);

            //// Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            //var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            //// Do the actual request and await the response
            //var httpResponse = await httpClient.PostAsync(INDEX_URL, httpContent);

            //// If the response contains content we want to read it!
            //if (httpResponse.Content != null)
            //{
            //    var responseContent = await httpResponse.Content.ReadAsStringAsync();

            // From here on you could deserialize the ResponseContent back again to a concrete C# type using Json.Net
            //}
            Console.WriteLine("TEste)");
        }
    }
}
