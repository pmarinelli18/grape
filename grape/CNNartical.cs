using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace grape
{
    class CNNartical
    {

        ArticlesResult ar;

        public CNNartical()
        {
            var newsApiClient = new NewsApiClient("df3a00e24d6f4d6e912a12f2ce9704a0");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = "Tech",
                Language = Languages.EN
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                ar = articlesResponse;
            }                      

        }

        public string[] getTitleList()
        {
            string[] titles = new string[ar.Articles.Count];

            for (int i = 0; i < titles.Count(); i++)
            {
                titles[i] = ar.Articles.ElementAt(i).Title;
            }

            return titles;
        }

        public string getContent(int i)
        {
            return ar.Articles.ElementAt(i).Description;
        }
    }
}
