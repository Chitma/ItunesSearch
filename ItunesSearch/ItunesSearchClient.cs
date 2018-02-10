using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ItunesSearch
{
    class ItunesSearchClient : IRequestMaker
    {
        public ItunesCollection MakeRequest(string query)
        {
            var responseString = string.Empty;
            //Build the URI
            Uri itunesUriBase = new Uri("https://itunes.apple.com/search");
            var builder = new UriBuilder($"{itunesUriBase}?term={query}&limit=25");

            //Send the POST request
            using (WebClient client = new WebClient())
            {
                //Set the encoding to UTF8
                client.Encoding = System.Text.Encoding.UTF8;
          
                client.Headers.Add("Content-Type", "application/json");
                responseString = client.UploadString(builder.Uri,string.Empty);

                var result =  JsonConvert.DeserializeObject<ItunesCollection>(responseString);

                return result;
            }
        }
    }
}
