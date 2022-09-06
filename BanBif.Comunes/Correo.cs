using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;

namespace BanBif.Comunes.Util
{
    public class Request
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public string AttachmentFileDir { get; set; }
        public string AttachmentFileName { get; set; }
    }

    public class Response
    {
        public bool Enviado { get; set; }
        public string Resultado { get; set; }
    }

    public static class Correo
    {
        public static string apiUrl { get; set; } = "http://10.200.101.89:8084/api/Correo/EnviarCorreo";
        public static Request request { get; set; }
        public static Response EnviarCorreo()
        {



            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                var jsonObject = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Response>(dataObjects);
                return response;
            }
        }
    }
}
