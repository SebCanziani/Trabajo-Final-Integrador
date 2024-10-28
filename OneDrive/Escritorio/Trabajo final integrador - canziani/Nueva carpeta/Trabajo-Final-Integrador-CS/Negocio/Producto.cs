using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Negocio
{
    public class Producto
    {

        public int Id { get; set; }

        public string title { get; set; }

        public string Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public static List<Producto> GetAll(string url )
        {
            Producto producto = new Producto();


            var client = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest("products", Method.Get);
            List<Producto> list = client.Get<List<Producto>>(request);
            return list;
        }

       
      /*
        private static void GetItems()
        {
            var client = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest("items", Method.Get);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }  */

        private static void GetItems(string filter)
        {
            var client = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest("items", Method.Get);
            request.AddParameter("filter", filter);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        private static void PostItem(string data)
        {
            var client = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest("products", Method.Post);
            request.AddParameter("data", data);
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }








    }
        
}
