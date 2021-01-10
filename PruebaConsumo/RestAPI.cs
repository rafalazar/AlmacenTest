using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

namespace PruebaConsumo
{
    public class RestAPI
    {
        public AuthResponse SignIn(String user, String pass)
        {
            //
            AuthRequest req = new AuthRequest();
            req.Username = user;
            req.Password = pass;

            var client = new RestClient("http://159.203.78.14:3000/auth/signin");
            var request = new RestRequest(Method.POST);
            request.AddHeader("version", "app_v1");
            request.AddParameter("application/x-www-form-urlencoded", $"username={req.Username}&password={req.Password}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            AuthResponse clientResponse = JsonConvert.DeserializeObject<AuthResponse>(response.Content);

            return clientResponse;
        }

        public Boolean ValidateToken(DateTime tokenDate, int expiresIn)
        {
            DateTime today = DateTime.Now;

            var diff = (today - tokenDate).TotalMilliseconds;

            Console.WriteLine(diff);

            if (expiresIn - diff >= 300000)
            {
                Console.WriteLine("El TOKEN es válido");
                return true;
            }
            else
            {
                Console.WriteLine("El TOKEN ha caducado");
                return false;
            }
        }

        public TokenResponse RefreshToken(String token, String userId)
        {
            var client = new RestClient("http://159.203.78.14:3000/token/refresh");
            var request = new RestRequest(Method.POST);
            request.AddHeader("version", "app_v1");
            request.AddParameter("application/x-www-form-urlencoded", $"token={token}&user_id={userId}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);

            return tokenResponse;
        }

        public CategoriasResponse GetAllCategories(String token)
        {
            var client = new RestClient("http://159.203.78.14:3000/category?offset=0&state=1");
            var request = new RestRequest(Method.GET);
            request.AddHeader("version", "app_v1");
            request.AddHeader("token", token);
            IRestResponse response = client.Execute(request);

            CategoriasResponse categoriasResponse = JsonConvert.DeserializeObject<CategoriasResponse>(response.Content);

            //Console.WriteLine(JsonConvert.SerializeObject(categoriasResponse, Formatting.Indented));

            return categoriasResponse;
        }
    }
}
