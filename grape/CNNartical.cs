using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using RestSharp;

namespace grape
{
    class CNNartical
    {

        public List<articles> ar;

        public CNNartical()
        {
            var cliean = new RestClient("https://newsapi.org/v2/top-headlines?country=us&apiKey=e53db10bedcc4efa89fc6e3f0592b839");

            var request = new RestRequest();
            IRestResponse<results> response2 = cliean.Execute<results>(request);

            ar = response2.Data.articles;
            
        }

        public string[] getTitleList()
        {
            string[] tiles = new string[ar.Count()];

            for (int i = 0; i < ar.Count(); i++)
            {
                tiles[i] = ar[i].title;
            }

            return tiles;
        }
        //
        //public string getContent(int i)
        //{
        //    
        //}
    }
}
