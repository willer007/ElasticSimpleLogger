using ElasticSimpleLogger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestElasticSimpleLogger
{
    [TestClass]
    public class TestElasticLogger
    {
        private static string ELASTIC_URL = "http://10.50.6.98:9200";
        private static string ELASTIC_INDEX = "teste";
        private static int APPLICATION_ID = 10;


        [TestMethod]
        public void TestErrorSystemException()
        {
            ElasticLogger.Configure(ELASTIC_URL, ELASTIC_INDEX, APPLICATION_ID);

            try
            {

                throw new Exception("TESTE");

            } catch (Exception e)  {

                ElasticLogger.ErrorSystemException(new LogModel()
                {
                    registro_mensagem = "TESTE",
                    registro_codigo_erro = (int)ErroEnum.RPA.FalhaDeLogin

                }, e);

            }
        }


        [TestMethod]

        public void TestErrorBusinessRuleException()
        {
            ElasticLogger.Configure(ELASTIC_URL, ELASTIC_INDEX, APPLICATION_ID);

            try
            {
                throw new Exception("TESTE");

            }
            catch (Exception e)
            {

                ElasticLogger.ErrorBusinessRuleException(new LogModel()
                {
                    registro_mensagem = "TESTE",
                    registro_codigo_erro = (int)ErroEnum.Servico.Indisponivel

                }, e);

            }

         

        }


        public void TestInfo()
        {
            ElasticLogger.Configure(ELASTIC_URL, ELASTIC_INDEX, APPLICATION_ID);
            ElasticLogger.Info(new LogModel()
            {
                registro_mensagem = "TESTE",
                registro_codigo_erro = (int)ErroEnum.RPA.FalhaDeLogin

            });
        }

        public void TestDebug()
        {
            ElasticLogger.Configure(ELASTIC_URL, ELASTIC_INDEX, APPLICATION_ID);

            ElasticLogger.Debug(new LogModel()
            {
                registro_mensagem = "TESTE",
                registro_codigo_erro = (int) ErroEnum.RPA.FalhaDeLogin

            });
        }


        public void Test()
        {
            ElasticLogger.Configure(ELASTIC_URL, ELASTIC_INDEX, APPLICATION_ID);
            ElasticLogger.Debug(new LogModel()
            {
                registro_mensagem = "TESTE",
                registro_codigo_erro = (int)ErroEnum.RPA.FalhaDeLogin

            });
        }
    }
}
