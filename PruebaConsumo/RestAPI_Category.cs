using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace PruebaConsumo
{
    public class RestAPI_Category
    {
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

        public bool CreateCategory(String token, String cateName, int cateState)
        {
            var client = new RestClient("http://159.203.78.14:3000/category");
            var request = new RestRequest(Method.POST);
            request.AddHeader("token", token);
            request.AddHeader("version", "app_v1");
            request.AddParameter("application/x-www-form-urlencoded", $"category_name={cateName}&state={cateState}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            CrearCategoriaResponse cateResponse = JsonConvert.DeserializeObject<CrearCategoriaResponse>(response.Content);

            if(bool.Parse(cateResponse.Ok) == true)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool UpdateCategory(String token, String cateName, int cateState, int idCate)
        {
            var client = new RestClient($"http://159.203.78.14:3000/category/{idCate}");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("token", token);
            request.AddHeader("version", "app_v1");
            request.AddParameter("application/x-www-form-urlencoded", $"category_name={cateName}&state={cateState}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            CrearCategoriaResponse cateResponse = JsonConvert.DeserializeObject<CrearCategoriaResponse>(response.Content);

            if (bool.Parse(cateResponse.Ok) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
