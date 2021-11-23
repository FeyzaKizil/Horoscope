using Core.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.WebApi
{
    public class Api
    {

        //public Api()
        //{
        //    List<JsonDataType> dataRecord = new List<JsonDataType>();
        //}
        public JsonDataType pullData(string sign, string day)
        {
            string link = "https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign=" + sign + "&day=" + day;
            var client = new RestClient(link);
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-rapidapi-host", "sameer-kumar-aztro-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "cbf2e04e45mshc39cfae44f117d6p1d6639jsnfbf8c0f60fcc");
            IRestResponse response = client.Execute(request);

            JsonDataType data = JsonConvert.DeserializeObject<JsonDataType>(response.Content);
            return data;
        }
    }
}
