using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace grape
{
    class BingImageSearch
    {                                                             
        private ImageSearchClient client;

        public BingImageSearch()
        {
            string subscriptionKey = "4f489680f20742cc9839ac4cdb9e8f0b";
            //stores the image results returned by Bing
            
            // the image search term to be used in the query
            
            client = new ImageSearchClient(new ApiKeyServiceClientCredentials(subscriptionKey));
        }

        public Image rtnImagies(String searchTerm)
        {
            Random rnd = new Random();
            var a = client.Images.SearchAsync(query: searchTerm).Result.Value.ElementAt(rnd.Next(1,8));
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(a.ThumbnailUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
        }
    }
}
